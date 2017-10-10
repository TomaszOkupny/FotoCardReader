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
            this.scanCards = new System.Windows.Forms.Button();
            this.listCards = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // OpenFolderDestDialog
            // 
            this.OpenFolderDestDialog.Location = new System.Drawing.Point(384, 35);
            this.OpenFolderDestDialog.Name = "OpenFolderDestDialog";
            this.OpenFolderDestDialog.Size = new System.Drawing.Size(32, 23);
            this.OpenFolderDestDialog.TabIndex = 0;
            this.OpenFolderDestDialog.Text = "...";
            this.OpenFolderDestDialog.UseVisualStyleBackColor = true;
            this.OpenFolderDestDialog.Click += new System.EventHandler(this.OpenFolderDestDialog_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(422, 38);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(252, 20);
            this.txtDestinationFolder.TabIndex = 1;
            // 
            // txtResultInfo
            // 
            this.txtResultInfo.Location = new System.Drawing.Point(12, 317);
            this.txtResultInfo.Multiline = true;
            this.txtResultInfo.Name = "txtResultInfo";
            this.txtResultInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultInfo.Size = new System.Drawing.Size(689, 129);
            this.txtResultInfo.TabIndex = 2;
            // 
            // scanCards
            // 
            this.scanCards.Location = new System.Drawing.Point(53, 34);
            this.scanCards.Name = "scanCards";
            this.scanCards.Size = new System.Drawing.Size(75, 23);
            this.scanCards.TabIndex = 3;
            this.scanCards.Text = "Skanuj";
            this.scanCards.UseVisualStyleBackColor = true;
            this.scanCards.Click += new System.EventHandler(this.scanCards_Click);
            // 
            // listCards
            // 
            this.listCards.CheckOnClick = true;
            this.listCards.FormattingEnabled = true;
            this.listCards.Location = new System.Drawing.Point(25, 104);
            this.listCards.Name = "listCards";
            this.listCards.Size = new System.Drawing.Size(228, 154);
            this.listCards.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 508);
            this.Controls.Add(this.listCards);
            this.Controls.Add(this.scanCards);
            this.Controls.Add(this.txtResultInfo);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.OpenFolderDestDialog);
            this.Name = "MainForm";
            this.Text = "Foto Card Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenFolderDestDialog;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.TextBox txtResultInfo;
        private System.Windows.Forms.Button scanCards;
        private System.Windows.Forms.CheckedListBox listCards;
    }
}

