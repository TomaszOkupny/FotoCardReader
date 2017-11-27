using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FotoCardReader
{
    public partial class MainForm : Form
    {
        int togMove;
        int mValX;
        int mValY;

        CardReader CardReader = new CardReader();
        LogInfo logInfo = new LogInfo();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void SwitchControlDisc(string ctrlName, bool ctrlEnable, bool ctrlChecked, string ctrlText)
        {
            string labelText = ctrlText;


            if (Controls.Find(ctrlName, true).FirstOrDefault() is CheckBox checkBox)
            {
                if (ctrlText == string.Empty)
                    labelText = "Disc:";

                checkBox.Enabled = ctrlEnable;
                checkBox.Checked = ctrlChecked;
                checkBox.Text = labelText;
            }
        }


        protected void PrepareCopy()
        {
 

            foreach (Control c in panel1.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    {
                    switch (c.Name)
                    {
                        case "checkBox1":
                            CardReader disk1 = new CardReader(c.Text, txtDestinationFolder.Text);
                            disk1.ObjNo = 1;
                            Thread thread1 = new Thread(() => CopyFiles(disk1));
                            thread1.Start();
                            thread1.IsBackground = true;
                            break;

                        case "checkBox2":
                            CardReader disk2 = new CardReader(c.Text, txtDestinationFolder.Text);
                            disk2.ObjNo = 2;
                            Thread thread2 = new Thread(() => CopyFiles(disk2));
                            thread2.Start();
                            thread2.IsBackground = true;
                            break;

                        case "checkBox3":
                            CardReader disk3 = new CardReader(c.Text, txtDestinationFolder.Text);
                            disk3.ObjNo = 3;
                            Thread thread3 = new Thread(() => CopyFiles(disk3));
                            thread3.Start();
                            thread3.IsBackground = true;
                            break;

                        case "checkBox4":
                            CardReader disk4 = new CardReader(c.Text, txtDestinationFolder.Text);
                            disk4.ObjNo = 4;
                            Thread thread4 = new Thread(() => CopyFiles(disk4));
                            thread4.Start();
                            thread4.IsBackground = true;
                            break;

                    }
                    /*
                    if (c.Name == "checkBox1") {
                        CardReader disk1 = new CardReader(c.Text, txtDestinationFolder.Text);
                        disk1.ObjNo = 1;
                        Thread thread1 = new Thread(() => CopyFiles(disk1));
                        thread1.Start();
                        thread1.IsBackground = true;
                    }
                    if (c.Name == "checkBox2")
                    {                    
                        CardReader disk2 = new CardReader(c.Text, txtDestinationFolder.Text);
                        disk2.ObjNo = 2;
                        Thread thread2 = new Thread(() => CopyFiles(disk2));
                        thread2.Start();
                        thread2.IsBackground = true;
                    }
                    if (c.Name == "checkBox3")
                    {
                        CardReader disk3 = new CardReader(c.Text, txtDestinationFolder.Text);
                        disk3.ObjNo = 3;
                        Thread thread3 = new Thread(() => CopyFiles(disk3));
                        thread3.Start();
                        thread3.IsBackground = true;
                    }
                    if (c.Name == "checkBox4")
                    {
                        CardReader disk4 = new CardReader(c.Text, txtDestinationFolder.Text);
                        disk4.ObjNo = 4;
                        Thread thread4 = new Thread(() => CopyFiles(disk4));
                        thread4.Start();
                        thread4.IsBackground = true;
                    }
                    */
                    
                    logInfo.AddResultInfo(txtResultInfo, "Copy " + c.Text + " index="  + c.Name);
                    
                }
            }
        }


        public void CopyFiles(CardReader obj)
        {

            string[] srcFileList = obj.GetSrcFileList();
            string info = string.Empty;
   
            ProgressBar progressCrl = new ProgressBar();


            logInfo.AddResultInfo(txtResultInfo, "Rozpoczęto kopiowanie dysku: " + obj.SrcDir);


            foreach (var srcFile in srcFileList)
            {

                info = obj.CopyFile(srcFile);
                logInfo.AddResultInfo(txtResultInfo,info);

                switch (obj.ObjNo)
                {
                    case 1:
                        progressCrl = progressBar1;
                        break;
                    case 2:
                        progressCrl = progressBar2;
                        break;
                    case 3:
                        progressCrl = progressBar3;
                        break;
                    case 4:
                        progressCrl = progressBar4;
                        break;
                }

                logInfo.SetProgressBarValue(progressCrl, obj.CopyProgress);
            }


          }

        private void CheckEnableCopyBtn()
        {
            bool choseDrv = false;

            if (checkBox1.Checked) choseDrv = true;

            if (checkBox2.Checked) choseDrv = true;

            if (checkBox3.Checked) choseDrv = true;

            if (checkBox4.Checked) choseDrv = true;

            if (txtDestinationFolder.Text != string.Empty && choseDrv)
            {
                cmdCopy.Enabled = true;
            }
            else
            {
                cmdCopy.Enabled = false;
            }
        }

        private void ScanCards()
        {
            string[] itemList;
            int index = 1;

            CardReader.SetAllSrcDirList();
            itemList = CardReader.GetSrcDirList();

            for (int i = 0; i <= 4; i++)
            {
                SwitchControlDisc("checkBox" + i, false, false, string.Empty);
            }

            foreach (var item in itemList)
            {
                logInfo.AddResultInfo(txtResultInfo, "Wykryto dysk " + index + " - Etykieta " + item);
                SwitchControlDisc("checkBox" + index, true, true, item);
                index++;
            }
            CheckEnableCopyBtn();
        }
        #endregion Methods

        #region Events
        private void CmdCopy_Click(object sender, EventArgs e)
        {
            PrepareCopy();
        }

        private void OpenFolderDestDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.Description = "Wybierz folder docelowy";
            if (folderBrowserDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowserDlg.SelectedPath;
                //CardReader.DestDir = folderBrowserDlg.SelectedPath;
                CheckEnableCopyBtn();

            }
        }

        private void CmdScanCards_Click(object sender, EventArgs e)
        {
            ScanCards();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEnableCopyBtn();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckEnableCopyBtn();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckEnableCopyBtn();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckEnableCopyBtn();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            mValX = e.X;
            mValY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void MoveForm()
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY);
            }
        }

        #endregion Events

    }
}
