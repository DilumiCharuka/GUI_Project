namespace Kaizen_DIY_Gym
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labellogintype = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonlogin);
            this.panel1.Controls.Add(this.textBoxpassword);
            this.panel1.Controls.Add(this.textBoxusername);
            this.panel1.Controls.Add(this.labelpassword);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Controls.Add(this.labellogintype);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(550, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 461);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labellogintype
            // 
            this.labellogintype.AutoSize = true;
            this.labellogintype.BackColor = System.Drawing.Color.Transparent;
            this.labellogintype.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogintype.Location = new System.Drawing.Point(3, 3);
            this.labellogintype.Name = "labellogintype";
            this.labellogintype.Size = new System.Drawing.Size(99, 23);
            this.labellogintype.TabIndex = 1;
            this.labellogintype.Text = "GYM Login";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.BackColor = System.Drawing.Color.Transparent;
            this.labelusername.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(104, 204);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(96, 23);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "User Name";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.BackColor = System.Drawing.Color.Transparent;
            this.labelpassword.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(104, 289);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(84, 23);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxusername.Location = new System.Drawing.Point(104, 234);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(247, 22);
            this.textBoxusername.TabIndex = 4;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxpassword.Location = new System.Drawing.Point(108, 324);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(243, 22);
            this.textBoxpassword.TabIndex = 5;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Lime;
            this.buttonlogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.Location = new System.Drawing.Point(156, 382);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(139, 47);
            this.buttonlogin.TabIndex = 6;
            this.buttonlogin.Text = "Log In";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 739);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labellogintype;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}