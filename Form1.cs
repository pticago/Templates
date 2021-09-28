using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Templates
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> collection = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            if(!string.IsNullOrEmpty( dialog.FileName ))
            {
                txtTemplatePath.Text = dialog.FileName;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtTemplatePath.Text))
            {
                string newFileName = System.IO.Path.Combine(
                        System.IO.Path.GetDirectoryName(txtTemplatePath.Text),
                        Guid.NewGuid().ToString() + "__" + System.IO.Path.GetFileName(txtTemplatePath.Text));

                try
                {
                    System.IO.File.Copy(txtTemplatePath.Text, newFileName);

                    WordprocessingDocument myDoc = WordprocessingDocument.Open(newFileName, true);
                    MainDocumentPart mainPart = myDoc.MainDocumentPart;

                    var fields = mainPart.Document.Descendants().ToList();
                    for (int i = 0; i < fields.Count; i++)
                    {
                        var f = fields[i];

                        //ako je SimpleField onda laganica jer se mijenja text od njegovog Text child polja
                        if (f is SimpleField)
                        {
                            replaceTextOfField(f, f);
                        }
                        else if (f is Run && f.InnerText.Contains("FILLIN"))
                        {
                            //ako je Run sa InnerText FILLIN, jedno od sljedećih Run polja je polje koje opet ima traženo Text child polje
                            for (int x = i + 1; x < fields.Count; x++)
                            {
                                if (fields[x] is Run && !string.IsNullOrEmpty(fields[x].InnerText))
                                {
                                    replaceTextOfField(f, fields[x]);
                                    break;
                                }
                            }
                        }
                    }

                    mainPart.Document.Save();
                    myDoc.Close();
                    myDoc.Dispose();

                    try
                    {
                        new System.Diagnostics.Process { StartInfo = new System.Diagnostics.ProcessStartInfo(newFileName) { UseShellExecute = true } }.Start();
                    }
                    catch { }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please choose template");
            }
        }

        private void refreshCollection()
        {
            collection.Clear();
            collection.Add("Ime", txtIme.Text);
            collection.Add("Prezime", txtPrezime.Text);
            collection.Add("Adresa", txtAdresa.Text);
            collection.Add("Telefon", txtTelefon.Text);
            collection.Add("Email", txtEmail.Text);
            collection.Add("UasProizvodjac", txtUasProizvodjac.Text);
            collection.Add("UasModel", txtUasModel.Text);
            collection.Add("RezID", txtRezID.Text);
            collection.Add("NazivAero", txtNazivAero.Text);
            collection.Add("NazivPriredbe", txtNazivPriredbe.Text);
            collection.Add("Lokacija", txtLokacija.Text);
            collection.Add("GornjaGranica", txtGornjaGranica.Text);
            collection.Add("DonjaGranica", txtDonjaGranica.Text);
            collection.Add("Polumjer", txtPolumjer.Text);
            collection.Add("DatumPocetka", txtDatumPocetka.Text);
            collection.Add("VrijemeOd", txtVrijemeOd.Text);
            collection.Add("DatumZavrsetka", txtDatumZavrsetka.Text);
            collection.Add("VrijemeDo", txtVrijemeDo.Text);
            collection.Add("DatumZahtjeva", txtDatumZahtjeva.Text);
        }

        private void replaceTextOfFirstChildTextField(OpenXmlElement field, string text)
        {
            var fText = field.Descendants<Text>().FirstOrDefault();
            if (fText != null)
                fText.Text = text;
        }

        private void replaceTextOfField(OpenXmlElement keyField, OpenXmlElement textField)
        {
            string key = keyField.InnerText;

            if (keyField is SimpleField)
                key = (keyField as SimpleField).Instruction;

            foreach(var item in collection)
            {
                if (key.Contains(item.Key))
                {
                    replaceTextOfFirstChildTextField(textField, item.Value);
                    break;
                }
            }
        }

        
    }
}
