namespace ProjetNadhamni
{
    partial class EditEndTimeTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEndTimeTask));
            this.btn_updateEndTask = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_endTimeTaskM = new System.Windows.Forms.ComboBox();
            this.cmb_endTimeTaskH = new System.Windows.Forms.ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_updateEndTask
            // 
            this.btn_updateEndTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.btn_updateEndTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateEndTask.FlatAppearance.BorderSize = 0;
            this.btn_updateEndTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateEndTask.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateEndTask.ForeColor = System.Drawing.Color.White;
            this.btn_updateEndTask.Location = new System.Drawing.Point(216, 121);
            this.btn_updateEndTask.Name = "btn_updateEndTask";
            this.btn_updateEndTask.Size = new System.Drawing.Size(78, 26);
            this.btn_updateEndTask.TabIndex = 154;
            this.btn_updateEndTask.Text = "Update";
            this.btn_updateEndTask.UseVisualStyleBackColor = false;
            this.btn_updateEndTask.Click += new System.EventHandler(this.btn_updateEndTask_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(63, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 153;
            this.label5.Text = "Start time";
            // 
            // cmb_endTimeTaskM
            // 
            this.cmb_endTimeTaskM.FormattingEnabled = true;
            this.cmb_endTimeTaskM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmb_endTimeTaskM.Location = new System.Drawing.Point(200, 69);
            this.cmb_endTimeTaskM.Name = "cmb_endTimeTaskM";
            this.cmb_endTimeTaskM.Size = new System.Drawing.Size(51, 21);
            this.cmb_endTimeTaskM.TabIndex = 152;
            // 
            // cmb_endTimeTaskH
            // 
            this.cmb_endTimeTaskH.FormattingEnabled = true;
            this.cmb_endTimeTaskH.Items.AddRange(new object[] {
            "1 AM",
            "2 AM",
            "3 AM",
            "4 AM",
            "5 AM",
            "6 AM",
            "7 AM",
            "8 AM",
            "9 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "13 PM",
            "14 PM",
            "15 PM",
            "16 PM",
            "17 PM",
            "18 PM",
            "19 PM",
            "20 PM",
            "21 PM",
            "22 PM",
            "23 PM",
            "00 AM"});
            this.cmb_endTimeTaskH.Location = new System.Drawing.Point(142, 69);
            this.cmb_endTimeTaskH.Name = "cmb_endTimeTaskH";
            this.cmb_endTimeTaskH.Size = new System.Drawing.Size(52, 21);
            this.cmb_endTimeTaskH.TabIndex = 151;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(53, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 1);
            this.panel6.TabIndex = 156;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(186, 121);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 157;
            this.pictureBox9.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 24);
            this.label2.TabIndex = 158;
            this.label2.Text = "Set your new task\'s End Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditEndTimeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(327, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_updateEndTask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_endTimeTaskM);
            this.Controls.Add(this.cmb_endTimeTaskH);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEndTimeTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEndTimeTask";
            this.Load += new System.EventHandler(this.EditEndTimeTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_updateEndTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_endTimeTaskM;
        private System.Windows.Forms.ComboBox cmb_endTimeTaskH;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
    }
}