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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenFolderDestDialog = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.txtResultInfo = new System.Windows.Forms.TextBox();
            this.cmdScanCards = new System.Windows.Forms.Button();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFolderDestDialog
            // 
            this.OpenFolderDestDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.OpenFolderDestDialog.FlatAppearance.BorderSize = 0;
            this.OpenFolderDestDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolderDestDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenFolderDestDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.OpenFolderDestDialog.Image = global::FotoCardReader.Properties.Resources.folder;
            this.OpenFolderDestDialog.Location = new System.Drawing.Point(98, 56);
            this.OpenFolderDestDialog.Name = "OpenFolderDestDialog";
            this.OpenFolderDestDialog.Size = new System.Drawing.Size(64, 45);
            this.OpenFolderDestDialog.TabIndex = 2;
            this.OpenFolderDestDialog.UseVisualStyleBackColor = false;
            this.OpenFolderDestDialog.Click += new System.EventHandler(this.OpenFolderDestDialog_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDestinationFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtDestinationFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestinationFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDestinationFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.txtDestinationFolder.Location = new System.Drawing.Point(16, 11);
            this.txtDestinationFolder.Multiline = true;
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.ReadOnly = true;
            this.txtDestinationFolder.Size = new System.Drawing.Size(542, 24);
            this.txtDestinationFolder.TabIndex = 1;
            this.txtDestinationFolder.TabStop = false;
            // 
            // txtResultInfo
            // 
            this.txtResultInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtResultInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtResultInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtResultInfo.Location = new System.Drawing.Point(15, 5);
            this.txtResultInfo.Multiline = true;
            this.txtResultInfo.Name = "txtResultInfo";
            this.txtResultInfo.ReadOnly = true;
            this.txtResultInfo.Size = new System.Drawing.Size(578, 183);
            this.txtResultInfo.TabIndex = 2;
            this.txtResultInfo.TabStop = false;
            // 
            // cmdScanCards
            // 
            this.cmdScanCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.cmdScanCards.FlatAppearance.BorderSize = 0;
            this.cmdScanCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdScanCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdScanCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmdScanCards.Image = global::FotoCardReader.Properties.Resources.repeat;
            this.cmdScanCards.Location = new System.Drawing.Point(15, 56);
            this.cmdScanCards.Name = "cmdScanCards";
            this.cmdScanCards.Size = new System.Drawing.Size(64, 45);
            this.cmdScanCards.TabIndex = 1;
            this.cmdScanCards.UseVisualStyleBackColor = false;
            this.cmdScanCards.Click += new System.EventHandler(this.CmdScanCards_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.cmdCopy.Enabled = false;
            this.cmdCopy.FlatAppearance.BorderSize = 0;
            this.cmdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmdCopy.Image = global::FotoCardReader.Properties.Resources.get_files;
            this.cmdCopy.Location = new System.Drawing.Point(181, 56);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(64, 45);
            this.cmdCopy.TabIndex = 6;
            this.cmdCopy.UseVisualStyleBackColor = false;
            this.cmdCopy.Click += new System.EventHandler(this.CmdCopy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.progressBar1.Location = new System.Drawing.Point(14, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(574, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.checkBox1.Location = new System.Drawing.Point(15, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Disc 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.checkBox2.Location = new System.Drawing.Point(15, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Disc 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.progressBar2.Location = new System.Drawing.Point(14, 84);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(574, 10);
            this.progressBar2.TabIndex = 10;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.checkBox3.Location = new System.Drawing.Point(15, 108);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Disc 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.progressBar3.Location = new System.Drawing.Point(14, 131);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(574, 10);
            this.progressBar3.TabIndex = 12;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.checkBox4.Location = new System.Drawing.Point(15, 152);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(53, 17);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Disc 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.progressBar4.Location = new System.Drawing.Point(14, 175);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(574, 10);
            this.progressBar4.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.progressBar4);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.progressBar3);
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 209);
            this.panel1.TabIndex = 16;
            // 
            // cmdExit
            // 
            this.cmdExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.cmdExit.Location = new System.Drawing.Point(573, 0);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(35, 35);
            this.cmdExit.TabIndex = 17;
            this.cmdExit.Text = "X";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblFormTitle);
            this.panel2.Controls.Add(this.cmdExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 35);
            this.panel2.TabIndex = 18;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::FotoCardReader.Properties.Resources.photo_camera;
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 35);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lblFormTitle.Location = new System.Drawing.Point(55, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(137, 17);
            this.lblFormTitle.TabIndex = 18;
            this.lblFormTitle.Text = "Foto Card Reader";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.txtResultInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panel3.Size = new System.Drawing.Size(608, 193);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel4.Controls.Add(this.txtDestinationFolder);
            this.panel4.Location = new System.Drawing.Point(15, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 43);
            this.panel4.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(608, 570);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.cmdScanCards);
            this.Controls.Add(this.OpenFolderDestDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Foto Card Reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenFolderDestDialog;
        private System.Windows.Forms.Button cmdScanCards;
        private System.Windows.Forms.Button cmdCopy;
        public System.Windows.Forms.TextBox txtResultInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

