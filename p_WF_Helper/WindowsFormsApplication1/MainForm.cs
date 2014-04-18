using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;




namespace WFHelper
{

    public partial class MainForm : Form
    {
     
        List<string> _companyList;
      
       
        Process _cleanBuildDeployProcess; 
     
        string _xslValue, _xmlValue;

        enum BuildType
        {
            WebForms,
            ShippingLabels
        };

        delegate void UpdateConsoleWindowDelegate(String msg);
        delegate void UpdateProgressDelegate(int value);
        delegate void UpdateLabelDelegate(String value);


        public MainForm()
        {
            InitializeComponent();

            _companyList = new List<string>();

       }

        private void CleanBuildDeploy_Click(object sender, EventArgs e)
        {

       
            DeleteFile1();         //deleting Standards Files from HUB's folder
             CopyFile();            //copying Standards Files
             DeleteFile();          //deleting old pdf.bat
             WriteFile();           //creating new pdf.bat for current HUB
             //ReadFile();          //checking pdf.bat
             CreatePDF();           //running pdf.bat
             DeleteFile1();         //deleting Standards Files from HUB's folder
             ProcessStartInfo psi2;
           
             if (divBox.Text.Equals(""))
             {
                 psi2 = new ProcessStartInfo("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\out.pdf");
               }

             else
             { psi2 = new ProcessStartInfo("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\out.pdf");
              
                

             }
             _cleanBuildDeployProcess = new Process { StartInfo = psi2 };
             try
             {

                 _cleanBuildDeployProcess.Start();
             }
             catch (System.Exception)
             {
                 System.Diagnostics.Debug.WriteLine("Some fail");
             }
         
        
        }
        private void searchType_CheckStateChanged(object sender, EventArgs e)
        {
            List<String> globalCompaniesList = new List<String>();
            if (searchTypeCheckBox.CheckState == CheckState.Checked)
            {
                try
                {
                    foreach (String d in Directory.GetDirectories(@"C:\jv\implementation\maps\"))
                    {
                        globalCompaniesList.AddRange(Directory.GetDirectories(d).Distinct().ToList());
                    }
                }
                catch { }

                RefreshComboBox(globalCompaniesList.Distinct().Select(n => n.Substring(n.LastIndexOf("\\", StringComparison.CurrentCulture) + 1)));

            }
            else
            {
                RefreshComboBox(_companyList);
            }

        }

         public void CreatePDF()
        {
          
             ProcessStartInfo psi = new ProcessStartInfo("D:\\prog\\pdf.bat");
            _cleanBuildDeployProcess = new Process { StartInfo = psi };

            try
            {

                _cleanBuildDeployProcess.Start();
            }
            catch (System.Exception)
            {
                System.Diagnostics.Debug.WriteLine("Fail, Please close your out.pdf");
            }
           

         
            _cleanBuildDeployProcess.WaitForExit();

            


        }

        public void CopyFile()
        {
            _xslValue = xslBox.Text;
            _xmlValue = xmlBox.Text;

         

                string sourceFile1 = @" C:\jv\implementation\maps\s\standards\web\BaseLabelPdf.xsl";
                string sourceFile2 = @" C:\jv\implementation\maps\s\standards\web\UtilitiesPdf.xsl";
                string sourceFile3 = @" C:\jv\implementation\maps\s\standards\web\BasePackingSlipPdf.xsl";
                string destinationFile1;
                string destinationFile2;
                string destinationFile3;

            
            
            if (divBox.Text.Equals(""))
                {
                    destinationFile1 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\BaseLabelPdf.xsl";
                    destinationFile2 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\UtilitiesPdf.xsl";
                    destinationFile3 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\BasePackingSlipPdf.xsl";
                }



                else
            {
                destinationFile1 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\BaseLabelPdf.xsl";
                destinationFile2 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\UtilitiesPdf.xsl";
                destinationFile3 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\BasePackingSlipPdf.xsl";
              
             
                }
             
                System.Console.WriteLine("destinationFile1:" + destinationFile1);
                System.Console.WriteLine("destinationFile2:" + destinationFile2);
                System.Console.WriteLine("destinationFile3:" + destinationFile3);

                // To move a file or folder to a new location:
                System.IO.File.Copy(sourceFile1, destinationFile1);
                System.IO.File.Copy(sourceFile2, destinationFile2);
                System.IO.File.Copy(sourceFile3, destinationFile3);

        }

        public void ReadFile()
        {
            StreamReader streamReader = new StreamReader("D:\\prog\\p_WF_Helper\\p_WF_Helper\\WindowsFormsApplication1\\bin\\Debug\\system_files\\pdf.bat"); 
            string str = "";

            while (!streamReader.EndOfStream) 
            {
                str += streamReader.ReadLine(); 
            }

            System.Console.WriteLine("Data file: " +str);
        }
        private void DeleteFile()
        {
            FileInfo file = new FileInfo("D:\\prog\\pdf.bat");
            if (file.Exists == true) //Если файл существует
            {
                file.Delete(); //Удаляем
            }
            else MessageBox.Show("Файла не существует!!");
        }
        private void DeleteFile1()
        {
            _xslValue = xslBox.Text;
            _xmlValue = xmlBox.Text;
            //FileInfo file1 = new FileInfo("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\out.pdf");
           
            string destinationFile1;
            string destinationFile2;
            string destinationFile3;
            if (divBox.Text.Equals(""))
            {
                destinationFile1 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\BaseLabelPdf.xsl";
                destinationFile2 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\UtilitiesPdf.xsl";
                destinationFile3 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\BasePackingSlipPdf.xsl";
            }



            else
            {
                destinationFile1 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\BaseLabelPdf.xsl";
                destinationFile2 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\UtilitiesPdf.xsl";
                destinationFile3 = "C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\BasePackingSlipPdf.xsl";


            }
            System.Console.WriteLine("destinationFile1:" + destinationFile1);
            System.Console.WriteLine("destinationFile2:" + destinationFile2);
            System.Console.WriteLine("destinationFile3:" + destinationFile3);

            FileInfo file = new FileInfo(destinationFile1);
            if (file.Exists == true) //Если файл существует
            {
                file.Delete(); //Удаляем
            }
            file = new FileInfo(destinationFile2);
            if (file.Exists == true) //Если файл существует
            {
                file.Delete(); //Удаляем
            }
            file = new FileInfo(destinationFile3);
            if (file.Exists == true) //Если файл существует
            {
                file.Delete(); //Удаляем
            }
        
            // else MessageBox.Show("Файла не существует!!");
        }

        public void WriteFile()
        {
            _xslValue = xslBox.Text;
            _xmlValue = xmlBox.Text;
         
            StreamWriter write_text;  //Класс для записи в файл
            FileInfo file = new FileInfo("D:\\prog\\pdf.bat");
            write_text = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся

            if (divBox.Text.Equals(""))
            {
                write_text.WriteLine("fop -xsl C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + _xslValue
                     + " -xml C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + _xmlValue
                     + " -pdf C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\out.pdf  & pause"); //Записываем в файл текст из текстового поля
            }
           


             else
            {
                write_text.WriteLine("fop -xsl C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\" + _xslValue
                  + " -xml C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\"+_xmlValue
                  + " -pdf C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\out.pdf  & pause"); //Записываем в файл текст из текстового поля
      
            }
            write_text.Close(); // Закрываем файл
        }
     
       
          

        public void RefreshComboBox(IEnumerable<String> list)
        {
            CompanyNameComboBox.Items.Clear();
            // ReSharper disable CoVariantArrayConversion
            if (list != null) CompanyNameComboBox.Items.AddRange(list.Distinct().ToArray());
            // ReSharper restore CoVariantArrayConversion           
        }

        public void RefreshComboBox()
        {
            CompanyNameComboBox.Items.Clear();
            // ReSharper disable CoVariantArrayConversion
            if (_companyList != null) CompanyNameComboBox.Items.AddRange(_companyList.Distinct().ToArray());
            // ReSharper restore CoVariantArrayConversion            
        }
        /*
          else if (divBox.Text.Trim().Length > 0)
            {
                PdfCreate.Enabled = true;
                //        LabelAppletBuilder.Enabled = true;
                DivisionComboBoxFill();
                XmlComboBoxFill();
                XSLBoxFill();
            }*/
        private void comboBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (CompanyNameComboBox.Text.Trim().Length > 0)
            {
                PdfCreate.Enabled = true;
        //        LabelAppletBuilder.Enabled = true;
                DivisionComboBoxFill();
                XmlComboBoxFill();
                XSLBoxFill();
            }
           
            else
            {
                PdfCreate.Enabled = false;
      //          LabelAppletBuilder.Enabled = false;
               DivisionComboBoxFill();
                XSLBoxFill();
            }

        }
        private void divBox_TextChanged_1(object sender, EventArgs e)
        {
            if (CompanyNameComboBox.Text.Trim().Length > 0)
            {
                PdfCreate.Enabled = true;
               
                XmlComboBoxFill();
                XSLBoxFill();
            }

            else
            {
                PdfCreate.Enabled = false;
                XmlComboBoxFill();
                XSLBoxFill();
                XSLBoxFill();
            }

        }

        private void XSLBoxFill()
        {
            var folders = new List<string>();


            try
            {
                xslBox.Items.Clear();
                if (divBox.Text.Equals(""))
                {
                    folders.AddRange(Directory.GetFiles("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\"));
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\.svn");
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\.svn");
                }
                else
                {
                    folders.AddRange(Directory.GetFiles("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text+"\\"));
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\");
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\");
                }
                if (folders.Count > 0)
                {
                    foreach (string item in folders)
                    {
                        
                      
                      System.Console.WriteLine("item:" + item);
             
                      if (item.Substring(item.IndexOf('.') + 1, 3).Equals("xsl"))
                        xslBox.Items.Add(item.Substring(item.LastIndexOf("\\", StringComparison.CurrentCulture) + 1));
                    }
                }
            }
            catch
            {
                xslBox.Items.Clear();
            }
        }


        private void DivisionComboBoxFill()
        {
            var folders = new List<string>();


            try
            {
                divBox.Items.Clear();
                //  Directory.GetFiles
                folders.AddRange(Directory.GetDirectories("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\"));
                folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\.svn");

                folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\.svn");

                if (folders.Count > 0)
                {
                    foreach (string item in folders)
                    {


                        System.Console.WriteLine("item:" + item);

                       
                            divBox.Items.Add(item.Substring(item.LastIndexOf("\\", StringComparison.CurrentCulture) + 1));
                    }
                }
            }
            catch
            {
                divBox.Items.Clear();
            }

        }


        private void XmlComboBoxFill()
        {
            var folders = new List<string>();


            try
            {
                xmlBox.Items.Clear();
                //  Directory.GetFiles
                if (divBox.Text.Equals(""))
                {
                    folders.AddRange(Directory.GetFiles("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\"));
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\.svn");
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\.svn");
                }
                else
                {
                    folders.AddRange(Directory.GetFiles("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\"));
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\");
                    folders.Remove("C:\\jv\\implementation\\maps\\" + CompanyNameComboBox.Text.Substring(0, 1) + "\\" + CompanyNameComboBox.Text + "\\web\\" + divBox.Text + "\\");
                }

                if (folders.Count > 0)
                {
                    foreach (string item in folders)
                    {
                        //34534534

                        System.Console.WriteLine("item:" + item);

                        if (item.Substring(item.IndexOf('.') + 1, 3).Equals("xml"))
                            xmlBox.Items.Add(item.Substring(item.LastIndexOf("\\", StringComparison.CurrentCulture) + 1));
                    }
                }
            }
            catch
            {
                xmlBox.Items.Clear();
            }

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !String.IsNullOrEmpty(CompanyNameComboBox.Text.Trim()))
            {
                PdfCreate.Focus();
            }
        }

        private void subDivisionComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !String.IsNullOrEmpty(CompanyNameComboBox.Text.Trim()))
            {
                PdfCreate.Focus();
            }
        }


        private void TomcatLogsButton_Click(object sender, EventArgs e)
        {
            Width = Width != 986 ? 986 : 373;
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CompanyNameComboBox.SelectedIndex = CompanyNameComboBox.Items.Count - 1;
            CompanyNameComboBox.Focus();
        }

     

        private void folderOpener(String s, String ss = "")
        {
            if (Directory.Exists(s + ss))
            {
                Process.Start("explorer", s + ss);
            }
            else
            {
                Process.Start("explorer", s);
            }
        }

        private void xslBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CompanyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

       

       
  
  
    }
}
