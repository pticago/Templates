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
                    refreshCollection();

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
                        else if (f is Run && f.InnerText.Trim().StartsWith("FILLIN ") && f.InnerText.Trim().EndsWith("MERGEFORMAT"))
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
                        else if(f is Run && f.InnerText.Trim().StartsWith("FILLIN"))
                        {
                            //teži put, našo rascijepani FILLIN, nafilaj key do MERGEFORMAT
                            string key = f.InnerText;
                            for(int y = i +1; y < fields.Count; y++)
                            {
                                if(fields[y] is Run && fields[y].InnerText.Trim().EndsWith("MERGEFORMAT"))
                                {
                                    key += fields[y].InnerText;

                                    //opet isto, jedno od sljedećih Run polja je polje koje opet ima traženo Text child polje
                                    for (int x = y + 1; x < fields.Count; x++)
                                    {
                                        if (fields[x] is Run && !string.IsNullOrEmpty(fields[x].InnerText))
                                        {
                                            replaceTextOfField(key, fields[x]);
                                            break;
                                        }
                                    }

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
            collection.Add("Ime", !string.IsNullOrEmpty(txtIme.Text) ? txtIme.Text : "-");
            collection.Add("Prezime", !string.IsNullOrEmpty(txtPrezime.Text) ? txtPrezime.Text : "-");
            collection.Add("Adresa", !string.IsNullOrEmpty(txtAdresa.Text) ? txtAdresa.Text : "-");
            collection.Add("Telefon", !string.IsNullOrEmpty(txtTelefon.Text) ? txtTelefon.Text : "-");
            collection.Add("Email", !string.IsNullOrEmpty(txtEmail.Text) ? txtEmail.Text : "-");
            collection.Add("RezID", !string.IsNullOrEmpty(txtRezID.Text) ? txtRezID.Text : "-");
            collection.Add("VrstaAktivnosti", !string.IsNullOrEmpty(txtVrstaAktivnosti.Text) ? txtVrstaAktivnosti.Text : "-");
            collection.Add("NazivPriredbe", !string.IsNullOrEmpty(txtNazivPriredbe.Text) ? txtNazivPriredbe.Text : "-");
            collection.Add("Lokacija", !string.IsNullOrEmpty(txtLokacija.Text) ? txtLokacija.Text : "-");
            collection.Add("GornjaGranica", !string.IsNullOrEmpty(txtGornjaGranica.Text) ? txtGornjaGranica.Text : "-");
            collection.Add("DonjaGranica", !string.IsNullOrEmpty(txtDonjaGranica.Text) ? txtDonjaGranica.Text : "-");
            collection.Add("Polumjer", !string.IsNullOrEmpty(txtPolumjer.Text) ? txtPolumjer.Text : "-");
            collection.Add("DnevniPeriodAktivnosti", !string.IsNullOrEmpty(txtDnevniPeriodAktivnosti.Text) ? txtDnevniPeriodAktivnosti.Text : "-");
            collection.Add("ValjanostOdobrenja", !string.IsNullOrEmpty(txtValjanostOdobrenja.Text) ? txtValjanostOdobrenja.Text : "-");
            collection.Add("DatumZahtjeva", !string.IsNullOrEmpty(txtDatumZahtjeva.Text) ? txtDatumZahtjeva.Text : "-");
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

        private void replaceTextOfField(string key, OpenXmlElement textField)
        {
            foreach (var item in collection)
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
