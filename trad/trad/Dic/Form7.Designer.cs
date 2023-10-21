namespace Dic
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label3 = new System.Windows.Forms.Label();
            this.Exemple = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(54, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "password :";
            // 
            // Exemple
            // 
            this.Exemple.AutoSize = true;
            this.Exemple.BackColor = System.Drawing.Color.Transparent;
            this.Exemple.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Exemple.Location = new System.Drawing.Point(54, 114);
            this.Exemple.Name = "Exemple";
            this.Exemple.Size = new System.Drawing.Size(59, 13);
            this.Exemple.TabIndex = 86;
            this.Exemple.Text = "username :";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(127, 111);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(146, 20);
            this.user.TabIndex = 87;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(127, 155);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(146, 20);
            this.pwd.TabIndex = 88;
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
            this.label13.Location = new System.Drawing.Point(120, 24);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(153, 40);
            this.label13.TabIndex = 90;
            this.label13.Text = "LOG IN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.SystemColors.Window;
            this.supprimer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.supprimer.Location = new System.Drawing.Point(281, 207);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(92, 25);
            this.supprimer.TabIndex = 91;
            this.supprimer.Text = "log in";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exemple);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.label13);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Exemple;
        internal System.Windows.Forms.TextBox user;
        internal System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button supprimer;
    }
}