namespace ProjetNadhamni
{
    partial class EditStartTimeTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStartTimeTask));
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_startTimeTaskM = new System.Windows.Forms.ComboBox();
            this.cmb_startTimeTaskH = new System.Windows.Forms.ComboBox();
            this.btn_updateStartTask = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(64, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 138;
            this.label5.Text = "Start time";
            // 
            // cmb_startTimeTaskM
            // 
            this.cmb_startTimeTaskM.FormattingEnabled = true;
            this.cmb_startTimeTaskM.Items.AddRange(new object[] {
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
            this.cmb_startTimeTaskM.Location = new System.Drawing.Point(201, 71);
            this.cmb_startTimeTaskM.Name = "cmb_startTimeTaskM";
            this.cmb_startTimeTaskM.Size = new System.Drawing.Size(51, 21);
            this.cmb_startTimeTaskM.TabIndex = 136;
            // 
            // cmb_startTimeTaskH
            // 
            this.cmb_startTimeTaskH.FormattingEnabled = true;
            this.cmb_startTimeTaskH.Items.AddRange(new object[] {
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
            this.cmb_startTimeTaskH.Location = new System.Drawing.Point(143, 71);
            this.cmb_startTimeTaskH.Name = "cmb_startTimeTaskH";
            this.cmb_startTimeTaskH.Size = new System.Drawing.Size(52, 21);
            this.cmb_startTimeTaskH.TabIndex = 134;
            // 
            // btn_updateStartTask
            // 
            this.btn_updateStartTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.btn_updateStartTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateStartTask.FlatAppearance.BorderSize = 0;
            this.btn_updateStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStartTask.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateStartTask.ForeColor = System.Drawing.Color.White;
            this.btn_updateStartTask.Location = new System.Drawing.Point(217, 123);
            this.btn_updateStartTask.Name = "btn_updateStartTask";
            this.btn_updateStartTask.Size = new System.Drawing.Size(78, 26);
            this.btn_updateStartTask.TabIndex = 140;
            this.btn_updateStartTask.Text = "Update";
            this.btn_updateStartTask.UseVisualStyleBackColor = false;
            this.btn_updateStartTask.Click += new System.EventHandler(this.btn_updateStartTask_Click);
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
            this.panel6.Location = new System.Drawing.Point(54, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 1);
            this.panel6.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 141;
            this.label1.Text = "Set your new task\'s Start Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(187, 123);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 150;
            this.pictureBox9.TabStop = false;
            // 
            // EditStartTimeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(327, 180);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_updateStartTask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_startTimeTaskM);
            this.Controls.Add(this.cmb_startTimeTaskH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStartTimeTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStartTimeTask";
            this.Load += new System.EventHandler(this.EditStartEndTimeTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_startTimeTaskM;
        private System.Windows.Forms.ComboBox cmb_startTimeTaskH;
        private System.Windows.Forms.Button btn_updateStartTask;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
    }
}