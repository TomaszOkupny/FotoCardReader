using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoCardReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        

        private void OpenFolderDestDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.Description = "Wybierz folder docelowy";
            if (folderBrowserDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowserDlg.SelectedPath;
            }
        }


        public string[] ListDrive()
        {
            var allDrives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);

            string[] result = new string[allDrives.Count()];
            int i = 0;
            foreach (DriveInfo d in allDrives)
            {
                result[i] = d.Name;
                i++;
                //Console.WriteLine(d.Name);
            }
            return result;

        }

        public void ScanFiles(string[] drives)
        {
            string[] allfiles;
            string msg = string.Empty;

            foreach (var drive in drives)
            {
                allfiles = Directory.GetFiles(drive, "*.cr2", SearchOption.AllDirectories);
                string destFilePath = string.Empty;
                foreach (var file in allfiles)
                {
                    FileInfo srcFileInfo = new FileInfo(file);
                    destFilePath = GetDestFilePath(srcFileInfo.Name);

                    try
                    {
                        srcFileInfo.CopyTo(destFilePath);
                    }
                    catch (Exception ex)
                    {

                        msg = ex.Message + "  Błąd podczas kopiowania pliku " + srcFileInfo.FullName ;
                        txtResultInfo.AppendText(msg + Environment.NewLine);
                    }

                }
            }
        }

        public string GetDestFilePath(string fileName)
        {
            string destDirPath = "D:\\AAA\\";
            string destFilePath = destDirPath + fileName;

            FileInfo destFileInfo = new FileInfo(destFilePath);

            if (destFileInfo.Exists)
            {
                destFilePath = destDirPath + Path.GetFileNameWithoutExtension(destFilePath) + "_1" + Path.GetExtension(destFilePath);
                destFilePath = GetDestFilePath(Path.GetFileName(destFilePath));
            }

            return destFilePath;
        }

        private void scanCards_Click(object sender, EventArgs e)
        {
            //ScanFiles(ListDrive());
            var itemList = ListDrive();
            foreach (var item in itemList)
            {
                listCards.Items.Add(item, true);
            }

        }
    }
}
