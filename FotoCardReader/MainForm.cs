using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FotoCardReader
{
    public partial class MainForm : Form
    {
        CardReader CardReader = new CardReader();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmdCopy.Enabled = false;
        }


        private void OpenFolderDestDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.Description = "Wybierz folder docelowy";
            if (folderBrowserDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowserDlg.SelectedPath;
                CardReader.setDestinationDir(folderBrowserDlg.SelectedPath);
                cmdCopy.Enabled = true;
                
            }
        }

        private void cmdScanCards_Click(object sender, EventArgs e)
        {
            listCards.Items.Clear();
            var itemList = CardReader.ListDrive();
            foreach (var item in itemList)
            {
                listCards.Items.Add(item, true);
            }

        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            string[] listDrive = listCards.CheckedItems;

            foreach (string item in listDrive)
            {
                txtResultInfo.AppendText(item + Environment.NewLine);
                //CardReader.CopyFiles(item.);
            }

        }












       // public void SetFileCounter(int currCount, int allFiles)
       // {
       //     lblFileCounter.Text = "Skopiowano " + currCount + " z " + allFiles + " plików";
       // }
    }
}
