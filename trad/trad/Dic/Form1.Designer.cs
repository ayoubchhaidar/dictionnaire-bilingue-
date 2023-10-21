namespace Dic
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.Mot = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.admin = new System.Windows.Forms.Button();
            this.rechercher = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(124, 81);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(26, 24);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 47;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.BackColor = System.Drawing.Color.Transparent;
            this.L1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.L1.Location = new System.Drawing.Point(20, 84);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(25, 13);
            this.L1.TabIndex = 46;
            this.L1.Text = "L1 :";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.BackColor = System.Drawing.Color.Transparent;
            this.L2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.L2.Location = new System.Drawing.Point(174, 86);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(25, 13);
            this.L2.TabIndex = 45;
            this.L2.Text = "L2 :";
            // 
            // Mot
            // 
            this.Mot.AutoSize = true;
            this.Mot.BackColor = System.Drawing.Color.Transparent;
            this.Mot.Location = new System.Drawing.Point(17, 125);
            this.Mot.Name = "Mot";
            this.Mot.Size = new System.Drawing.Size(31, 13);
            this.Mot.TabIndex = 41;
            this.Mot.Text = "Mot :";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TextBox1.Location = new System.Drawing.Point(54, 122);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(110, 20);
            this.TextBox1.TabIndex = 37;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ComboBox2
            // 
            this.ComboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "FR",
            "EN"});
            this.ComboBox2.Location = new System.Drawing.Point(205, 83);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(40, 21);
            this.ComboBox2.TabIndex = 36;
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "FR",
            "EN"});
            this.ComboBox1.Location = new System.Drawing.Point(54, 81);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(43, 21);
            this.ComboBox1.TabIndex = 35;
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.SystemColors.Window;
            this.admin.Location = new System.Drawing.Point(590, 9);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(77, 26);
            this.admin.TabIndex = 34;
            this.admin.Text = "admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click_1);
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.SystemColors.Window;
            this.rechercher.Location = new System.Drawing.Point(189, 113);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(140, 36);
            this.rechercher.TabIndex = 33;
            this.rechercher.Text = "rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Font = new System.Drawing.Font("Monotype Koufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(632, 187);
            this.richTextBox1.TabIndex = 56;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            this.label13.Location = new System.Drawing.Point(170, 9);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(300, 40);
            this.label13.TabIndex = 84;
            this.label13.Text = "DICTIONNERE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 382);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.Mot);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.rechercher);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label L1;
        internal System.Windows.Forms.Label L2;
        internal System.Windows.Forms.Label Mot;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Button admin;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.Label label13;
    }
}

