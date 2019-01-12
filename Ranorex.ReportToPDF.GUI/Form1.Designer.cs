namespace Ranorex.ReportToPDF.GUI
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpReportPath = new System.Windows.Forms.TextBox();
            this.inpSaveDirectory = new System.Windows.Forms.TextBox();
            this.inpPDFName = new System.Windows.Forms.TextBox();
            this.btnBrowseReportFile = new System.Windows.Forms.Button();
            this.btnBrowsesaveDirectory = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rxzlogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectStyleSheet = new System.Windows.Forms.Button();
            this.inpStyleSheet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inpDetailLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cssFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compressed Report*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PDF Save Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PDF File Name*";
            // 
            // inpReportPath
            // 
            this.inpReportPath.Location = new System.Drawing.Point(118, 6);
            this.inpReportPath.Name = "inpReportPath";
            this.inpReportPath.Size = new System.Drawing.Size(280, 20);
            this.inpReportPath.TabIndex = 3;
            this.inpReportPath.TextChanged += new System.EventHandler(this.inpReportPath_TextChanged);
            // 
            // inpSaveDirectory
            // 
            this.inpSaveDirectory.Location = new System.Drawing.Point(118, 30);
            this.inpSaveDirectory.Name = "inpSaveDirectory";
            this.inpSaveDirectory.Size = new System.Drawing.Size(280, 20);
            this.inpSaveDirectory.TabIndex = 4;
            // 
            // inpPDFName
            // 
            this.inpPDFName.Location = new System.Drawing.Point(118, 79);
            this.inpPDFName.Name = "inpPDFName";
            this.inpPDFName.Size = new System.Drawing.Size(161, 20);
            this.inpPDFName.TabIndex = 5;
            // 
            // btnBrowseReportFile
            // 
            this.btnBrowseReportFile.Location = new System.Drawing.Point(400, 4);
            this.btnBrowseReportFile.Name = "btnBrowseReportFile";
            this.btnBrowseReportFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseReportFile.TabIndex = 6;
            this.btnBrowseReportFile.Text = "Browse";
            this.btnBrowseReportFile.UseVisualStyleBackColor = true;
            this.btnBrowseReportFile.Click += new System.EventHandler(this.btnBrowseReportFile_Click);
            // 
            // btnBrowsesaveDirectory
            // 
            this.btnBrowsesaveDirectory.Location = new System.Drawing.Point(400, 28);
            this.btnBrowsesaveDirectory.Name = "btnBrowsesaveDirectory";
            this.btnBrowsesaveDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsesaveDirectory.TabIndex = 7;
            this.btnBrowsesaveDirectory.Text = "Browse";
            this.btnBrowsesaveDirectory.UseVisualStyleBackColor = true;
            this.btnBrowsesaveDirectory.Click += new System.EventHandler(this.btnBrowsesaveDirectory_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(118, 105);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(357, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rxzlogFileDialog
            // 
            this.rxzlogFileDialog.Filter = "Ranorex Report|*.rxzlog";
            // 
            // btnSelectStyleSheet
            // 
            this.btnSelectStyleSheet.Location = new System.Drawing.Point(400, 52);
            this.btnSelectStyleSheet.Name = "btnSelectStyleSheet";
            this.btnSelectStyleSheet.Size = new System.Drawing.Size(75, 23);
            this.btnSelectStyleSheet.TabIndex = 12;
            this.btnSelectStyleSheet.Text = "Browse";
            this.btnSelectStyleSheet.UseVisualStyleBackColor = true;
            this.btnSelectStyleSheet.Click += new System.EventHandler(this.btnSelectStyleSheet_Click);
            // 
            // inpStyleSheet
            // 
            this.inpStyleSheet.Location = new System.Drawing.Point(118, 54);
            this.inpStyleSheet.Name = "inpStyleSheet";
            this.inpStyleSheet.Size = new System.Drawing.Size(280, 20);
            this.inpStyleSheet.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Custom Style Sheet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Detail Level";
            // 
            // inpDetailLevel
            // 
            this.inpDetailLevel.FormattingEnabled = true;
            this.inpDetailLevel.Items.AddRange(new object[] {
            "All",
            "None",
            "Failed"});
            this.inpDetailLevel.Location = new System.Drawing.Point(354, 78);
            this.inpDetailLevel.Name = "inpDetailLevel";
            this.inpDetailLevel.Size = new System.Drawing.Size(121, 21);
            this.inpDetailLevel.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "*Required";
            // 
            // cssFileDialog
            // 
            this.cssFileDialog.Filter = "Style Sheet|*.xml";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 139);
            this.Controls.Add(this.inpDetailLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectStyleSheet);
            this.Controls.Add(this.inpStyleSheet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowsesaveDirectory);
            this.Controls.Add(this.btnBrowseReportFile);
            this.Controls.Add(this.inpPDFName);
            this.Controls.Add(this.inpSaveDirectory);
            this.Controls.Add(this.inpReportPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ranorex - Report To PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpReportPath;
        private System.Windows.Forms.TextBox inpSaveDirectory;
        private System.Windows.Forms.TextBox inpPDFName;
        private System.Windows.Forms.Button btnBrowseReportFile;
        private System.Windows.Forms.Button btnBrowsesaveDirectory;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog rxzlogFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSelectStyleSheet;
        private System.Windows.Forms.TextBox inpStyleSheet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inpDetailLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog cssFileDialog;
    }
}

