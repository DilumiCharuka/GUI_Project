namespace Kaizen_DIY_Gym
{
    partial class Formsearchmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formsearchmember));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelenterid = new System.Windows.Forms.Label();
            this.textBoxenterid = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.dataGridViewsearchmember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsearchmember)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelenterid
            // 
            this.labelenterid.AutoSize = true;
            this.labelenterid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelenterid.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenterid.Location = new System.Drawing.Point(185, 222);
            this.labelenterid.Name = "labelenterid";
            this.labelenterid.Size = new System.Drawing.Size(93, 22);
            this.labelenterid.TabIndex = 1;
            this.labelenterid.Text = "Enter ID";
            // 
            // textBoxenterid
            // 
            this.textBoxenterid.Location = new System.Drawing.Point(319, 222);
            this.textBoxenterid.Name = "textBoxenterid";
            this.textBoxenterid.Size = new System.Drawing.Size(290, 22);
            this.textBoxenterid.TabIndex = 2;
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonsearch.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.Location = new System.Drawing.Point(381, 269);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(149, 47);
            this.buttonsearch.TabIndex = 3;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // dataGridViewsearchmember
            // 
            this.dataGridViewsearchmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsearchmember.Location = new System.Drawing.Point(27, 342);
            this.dataGridViewsearchmember.Name = "dataGridViewsearchmember";
            this.dataGridViewsearchmember.RowHeadersWidth = 51;
            this.dataGridViewsearchmember.RowTemplate.Height = 24;
            this.dataGridViewsearchmember.Size = new System.Drawing.Size(950, 334);
            this.dataGridViewsearchmember.TabIndex = 4;
            // 
            // Formsearchmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 688);
            this.Controls.Add(this.dataGridViewsearchmember);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textBoxenterid);
            this.Controls.Add(this.labelenterid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formsearchmember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchmember";
            this.Load += new System.EventHandler(this.Formsearchmember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsearchmember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelenterid;
        private System.Windows.Forms.TextBox textBoxenterid;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.DataGridView dataGridViewsearchmember;
    }
}