namespace FotoCardReader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFolderDestDialog = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.txtResultInfo = new System.Windows.Forms.TextBox();
            this.cmdScanCards = new System.Windows.Forms.Button();
            this.listCards = new System.Windows.Forms.CheckedListBox();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.lblFileCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFolderDestDialog
            // 
            this.OpenFolderDestDialog.Location = new System.Drawing.Point(364, 24);
            this.OpenFolderDestDialog.Name = "OpenFolderDestDialog";
            this.OpenFolderDestDialog.Size = new System.Drawing.Size(32, 23);
            this.OpenFolderDestDialog.TabIndex = 0;
            this.OpenFolderDestDialog.Text = "...";
            this.OpenFolderDestDialog.UseVisualStyleBackColor = true;
            this.OpenFolderDestDialog.Click += new System.EventHandler(this.OpenFolderDestDialog_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(402, 27);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.ReadOnly = true;
            this.txtDestinationFolder.Size = new System.Drawing.Size(252, 20);
            this.txtDestinationFolder.TabIndex = 1;
            // 
            // txtResultInfo
            // 
            this.txtResultInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResultInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultInfo.Location = new System.Drawing.Point(6, 146);
            this.txtResultInfo.Multiline = true;
            this.txtResultInfo.Name = "txtResultInfo";
            this.txtResultInfo.ReadOnly = true;
            this.txtResultInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultInfo.Size = new System.Drawing.Size(689, 208);
            this.txtResultInfo.TabIndex = 2;
            // 
            // cmdScanCards
            // 
            this.cmdScanCards.Location = new System.Drawing.Point(6, 12);
            this.cmdScanCards.Name = "cmdScanCards";
            this.cmdScanCards.Size = new System.Drawing.Size(75, 23);
            this.cmdScanCards.TabIndex = 3;
            this.cmdScanCards.Text = "Skanuj";
            this.cmdScanCards.UseVisualStyleBackColor = true;
            this.cmdScanCards.Click += new System.EventHandler(this.cmdScanCards_Click);
            // 
            // listCards
            // 
            this.listCards.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCards.CheckOnClick = true;
            this.listCards.FormattingEnabled = true;
            this.listCards.Location = new System.Drawing.Point(6, 50);
            this.listCards.Name = "listCards";
            this.listCards.Size = new System.Drawing.Size(174, 90);
            this.listCards.TabIndex = 5;
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(364, 67);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(75, 23);
            this.cmdCopy.TabIndex = 6;
            this.cmdCopy.Text = "Kopiuj";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // lblFileCounter
            // 
            this.lblFileCounter.AutoSize = true;
            this.lblFileCounter.Location = new System.Drawing.Point(364, 109);
            this.lblFileCounter.Name = "lblFileCounter";
            this.lblFileCounter.Size = new System.Drawing.Size(66, 13);
            this.lblFileCounter.TabIndex = 7;
            this.lblFileCounter.Text = "Skopiowano";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 361);
            this.Controls.Add(this.lblFileCounter);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.listCards);
            this.Controls.Add(this.cmdScanCards);
            this.Controls.Add(this.txtResultInfo);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.OpenFolderDestDialog);
            this.Name = "MainForm";
            this.Text = "Foto Card Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenFolderDestDialog;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button cmdScanCards;
        private System.Windows.Forms.CheckedListBox listCards;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Label lblFileCounter;
        public System.Windows.Forms.TextBox txtResultInfo;
    }
}

