namespace ProjetNadhamni
{
    partial class EditEmail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmail));
            this.txt_emailUpdated = new System.Windows.Forms.TextBox();
            this.btn_updateEmail = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_emailUpdated
            // 
            this.txt_emailUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.txt_emailUpdated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_emailUpdated.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_emailUpdated.HideSelection = false;
            this.txt_emailUpdated.Location = new System.Drawing.Point(65, 72);
            this.txt_emailUpdated.Name = "txt_emailUpdated";
            this.txt_emailUpdated.Size = new System.Drawing.Size(211, 18);
            this.txt_emailUpdated.TabIndex = 315;
            this.txt_emailUpdated.TabStop = false;
            this.txt_emailUpdated.Text = "Email";
            this.txt_emailUpdated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_emailUpdated.Click += new System.EventHandler(this.txt_emailUpdated_Click);
            // 
            // btn_updateEmail
            // 
            this.btn_updateEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.btn_updateEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateEmail.FlatAppearance.BorderSize = 0;
            this.btn_updateEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateEmail.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateEmail.ForeColor = System.Drawing.Color.White;
            this.btn_updateEmail.Location = new System.Drawing.Point(218, 121);
            this.btn_updateEmail.Name = "btn_updateEmail";
            this.btn_updateEmail.Size = new System.Drawing.Size(78, 26);
            this.btn_updateEmail.TabIndex = 312;
            this.btn_updateEmail.Text = "Update";
            this.btn_updateEmail.UseVisualStyleBackColor = false;
            this.btn_updateEmail.Click += new System.EventHandler(this.btn_updateEmail_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(55, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 1);
            this.panel6.TabIndex = 314;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 313;
            this.label1.Text = "Set your new Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 316;
            this.pictureBox1.TabStop = false;
            // 
            // EditEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(327, 180);
            this.Controls.Add(this.txt_emailUpdated);
            this.Controls.Add(this.btn_updateEmail);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_emailUpdated;
        private System.Windows.Forms.Button btn_updateEmail;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}