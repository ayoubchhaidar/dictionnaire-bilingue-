namespace Dic
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.import = new System.Windows.Forms.PictureBox();
            this.export = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.IM = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.export)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.Transparent;
            this.import.Image = ((System.Drawing.Image)(resources.GetObject("import.Image")));
            this.import.InitialImage = ((System.Drawing.Image)(resources.GetObject("import.InitialImage")));
            this.import.Location = new System.Drawing.Point(432, 74);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(223, 234);
            this.import.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.import.TabIndex = 1;
            this.import.TabStop = false;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.Transparent;
            this.export.Image = ((System.Drawing.Image)(resources.GetObject("export.Image")));
            this.export.InitialImage = ((System.Drawing.Image)(resources.GetObject("export.InitialImage")));
            this.export.Location = new System.Drawing.Point(121, 74);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(223, 234);
            this.export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.export.TabIndex = 2;
            this.export.TabStop = false;
            this.export.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Controls.Add(this.ComboBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.IM, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.L1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(441, 333);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 57);
            this.tableLayoutPanel2.TabIndex = 69;
            this.tableLayoutPanel2.Visible = false;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "FR",
            "EN"});
            this.ComboBox1.Location = new System.Drawing.Point(3, 26);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(43, 21);
            this.ComboBox1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(72, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "L2 :";
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "FR",
            "EN"});
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "FR",
            "EN"});
            this.comboBox4.Location = new System.Drawing.Point(72, 26);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(43, 21);
            this.comboBox4.TabIndex = 56;
            // 
            // IM
            // 
            this.IM.BackColor = System.Drawing.SystemColors.Window;
            this.IM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.IM.Location = new System.Drawing.Point(141, 26);
            this.IM.Name = "IM";
            this.IM.Size = new System.Drawing.Size(70, 21);
            this.IM.TabIndex = 49;
            this.IM.Text = "Importer ";
            this.IM.UseVisualStyleBackColor = false;
            this.IM.Click += new System.EventHandler(this.IM_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.L1.Location = new System.Drawing.Point(3, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(25, 13);
            this.L1.TabIndex = 48;
            this.L1.Text = "L1 :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 72;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Retour";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Rockwell Extra Bold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(141, 9);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(488, 40);
            this.label13.TabIndex = 84;
            this.label13.Text = "EXPORT    ET    IMPORT ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.export)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox import;
        private System.Windows.Forms.PictureBox export;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button IM;
        internal System.Windows.Forms.Label L1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label13;
    }
}