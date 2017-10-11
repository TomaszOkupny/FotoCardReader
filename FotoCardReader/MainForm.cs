﻿using System;
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




        private void OpenFolderDestDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.Description = "Wybierz folder docelowy";
            if (folderBrowserDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowserDlg.SelectedPath;
                CardReader.setDestinationDir(folderBrowserDlg.SelectedPath);
                checkEnableCopyBtn();

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
            checkEnableCopyBtn();
        }

        private void listCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnableCopyBtn();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            var listDrive = listCards.CheckedItems;

            foreach (string disc in listDrive)
            {
                //txtResultInfo.AppendText(item + Environment.NewLine);
                CardReader.CopyFiles(disc);
            }

        }


        private void checkEnableCopyBtn()
        {
            var listDrive = listCards.CheckedItems;

            if (txtDestinationFolder.Text != string.Empty && listDrive.Count > 0)
            {
                cmdCopy.Enabled = true;
            }
            else
            {
                cmdCopy.Enabled = false;
            }
            
        }











        // public void SetFileCounter(int currCount, int allFiles)
        // {
        //     lblFileCounter.Text = "Skopiowano " + currCount + " z " + allFiles + " plików";
        // }
    }
}
