namespace Kaizen_DIY_Gym
{
    partial class Formdeletemember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formdeletemember));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDeennterid = new System.Windows.Forms.Label();
            this.textBoxDeenterid = new System.Windows.Forms.TextBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.dataGridViewdeletemember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdeletemember)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDeennterid
            // 
            this.labelDeennterid.AutoSize = true;
            this.labelDeennterid.BackColor = System.Drawing.Color.Transparent;
            this.labelDeennterid.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeennterid.Location = new System.Drawing.Point(181, 243);
            this.labelDeennterid.Name = "labelDeennterid";
            this.labelDeennterid.Size = new System.Drawing.Size(84, 21);
            this.labelDeennterid.TabIndex = 1;
            this.labelDeennterid.Text = "Enter ID";
            // 
            // textBoxDeenterid
            // 
            this.textBoxDeenterid.Location = new System.Drawing.Point(314, 237);
            this.textBoxDeenterid.Name = "textBoxDeenterid";
            this.textBoxDeenterid.Size = new System.Drawing.Size(306, 22);
            this.textBoxDeenterid.TabIndex = 2;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttondelete.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(382, 287);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(133, 49);
            this.buttondelete.TabIndex = 3;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // dataGridViewdeletemember
            // 
            this.dataGridViewdeletemember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdeletemember.Location = new System.Drawing.Point(38, 355);
            this.dataGridViewdeletemember.Name = "dataGridViewdeletemember";
            this.dataGridViewdeletemember.RowHeadersWidth = 51;
            this.dataGridViewdeletemember.RowTemplate.Height = 24;
            this.dataGridViewdeletemember.Size = new System.Drawing.Size(955, 293);
            this.dataGridViewdeletemember.TabIndex = 4;
            // 
            // Formdeletemember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 660);
            this.Controls.Add(this.dataGridViewdeletemember);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.textBoxDeenterid);
            this.Controls.Add(this.labelDeennterid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formdeletemember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Member";
            this.Load += new System.EventHandler(this.Formdeletemember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdeletemember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDeennterid;
        private System.Windows.Forms.TextBox textBoxDeenterid;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.DataGridView dataGridViewdeletemember;
    }
}