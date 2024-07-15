namespace Burn_management.Forms.FormsGrade
{
    partial class Form_GetGrade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TX_NameEX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.COMP_YearNumberExam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.COMP_Course = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TX_Branch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COMP_Season = new System.Windows.Forms.ComboBox();
            this.COMP_Year = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_AddClose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TX_NameEX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.guna2PictureBox1);
            this.groupBox1.Controls.Add(this.COMP_YearNumberExam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.COMP_Course);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TX_Branch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.COMP_Season);
            this.groupBox1.Controls.Add(this.COMP_Year);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTN_AddClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الاختبار";
            // 
            // TX_NameEX
            // 
            this.TX_NameEX.BackColor = System.Drawing.SystemColors.Control;
            this.TX_NameEX.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_NameEX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.TX_NameEX.Location = new System.Drawing.Point(451, 414);
            this.TX_NameEX.Name = "TX_NameEX";
            this.TX_NameEX.ReadOnly = true;
            this.TX_NameEX.Size = new System.Drawing.Size(339, 45);
            this.TX_NameEX.TabIndex = 57;
            this.TX_NameEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F);
            this.label2.Location = new System.Drawing.Point(812, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 37);
            this.label2.TabIndex = 56;
            this.label2.Text = "اسم النموذج";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Burn_management.Properties.Resources.Grades;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(433, 427);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 54;
            this.guna2PictureBox1.TabStop = false;
            // 
            // COMP_YearNumberExam
            // 
            this.COMP_YearNumberExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_YearNumberExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_YearNumberExam.BackColor = System.Drawing.SystemColors.Window;
            this.COMP_YearNumberExam.DisplayMember = "bh";
            this.COMP_YearNumberExam.DropDownHeight = 170;
            this.COMP_YearNumberExam.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_YearNumberExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_YearNumberExam.FormattingEnabled = true;
            this.COMP_YearNumberExam.IntegralHeight = false;
            this.COMP_YearNumberExam.Location = new System.Drawing.Point(451, 341);
            this.COMP_YearNumberExam.MaxDropDownItems = 5;
            this.COMP_YearNumberExam.Name = "COMP_YearNumberExam";
            this.COMP_YearNumberExam.Size = new System.Drawing.Size(339, 45);
            this.COMP_YearNumberExam.TabIndex = 47;
            this.COMP_YearNumberExam.SelectedIndexChanged += new System.EventHandler(this.COMP_YearNumberExam_SelectedIndexChanged);
            this.COMP_YearNumberExam.TextChanged += new System.EventHandler(this.COMP_YearNumberExam_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 12F);
            this.label9.Location = new System.Drawing.Point(812, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 37);
            this.label9.TabIndex = 48;
            this.label9.Text = "تاريخ دورة النموذج";
            // 
            // COMP_Course
            // 
            this.COMP_Course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_Course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_Course.BackColor = System.Drawing.SystemColors.Window;
            this.COMP_Course.DisplayMember = "bh";
            this.COMP_Course.DropDownHeight = 170;
            this.COMP_Course.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Course.FormattingEnabled = true;
            this.COMP_Course.IntegralHeight = false;
            this.COMP_Course.Location = new System.Drawing.Point(451, 262);
            this.COMP_Course.MaxDropDownItems = 5;
            this.COMP_Course.Name = "COMP_Course";
            this.COMP_Course.Size = new System.Drawing.Size(339, 45);
            this.COMP_Course.TabIndex = 46;
            this.COMP_Course.SelectedIndexChanged += new System.EventHandler(this.COMP_Course_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F);
            this.label6.Location = new System.Drawing.Point(812, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 37);
            this.label6.TabIndex = 53;
            this.label6.Text = "اسـم الـمـادة";
            // 
            // TX_Branch
            // 
            this.TX_Branch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Branch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.TX_Branch.Location = new System.Drawing.Point(451, 40);
            this.TX_Branch.Name = "TX_Branch";
            this.TX_Branch.ReadOnly = true;
            this.TX_Branch.Size = new System.Drawing.Size(339, 45);
            this.TX_Branch.TabIndex = 52;
            this.TX_Branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F);
            this.label1.Location = new System.Drawing.Point(812, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 51;
            this.label1.Text = "الفرع الدراسي";
            // 
            // COMP_Season
            // 
            this.COMP_Season.BackColor = System.Drawing.Color.White;
            this.COMP_Season.DropDownHeight = 170;
            this.COMP_Season.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_Season.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_Season.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Season.FormattingEnabled = true;
            this.COMP_Season.IntegralHeight = false;
            this.COMP_Season.Items.AddRange(new object[] {
            "الفصل الأول",
            "الفصل الثاني",
            "الفصل الثالث"});
            this.COMP_Season.Location = new System.Drawing.Point(451, 186);
            this.COMP_Season.MaxDropDownItems = 5;
            this.COMP_Season.Name = "COMP_Season";
            this.COMP_Season.Size = new System.Drawing.Size(339, 45);
            this.COMP_Season.TabIndex = 45;
            this.COMP_Season.SelectedIndexChanged += new System.EventHandler(this.COMP_Season_SelectedIndexChanged);
            // 
            // COMP_Year
            // 
            this.COMP_Year.BackColor = System.Drawing.Color.White;
            this.COMP_Year.DropDownHeight = 170;
            this.COMP_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_Year.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Year.FormattingEnabled = true;
            this.COMP_Year.IntegralHeight = false;
            this.COMP_Year.Location = new System.Drawing.Point(451, 110);
            this.COMP_Year.MaxDropDownItems = 5;
            this.COMP_Year.Name = "COMP_Year";
            this.COMP_Year.Size = new System.Drawing.Size(339, 45);
            this.COMP_Year.TabIndex = 44;
            this.COMP_Year.SelectedIndexChanged += new System.EventHandler(this.COMP_Year_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F);
            this.label5.Location = new System.Drawing.Point(812, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 50;
            this.label5.Text = "السنة الدراسية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F);
            this.label3.Location = new System.Drawing.Point(806, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 37);
            this.label3.TabIndex = 49;
            this.label3.Text = "الفصل الدراسي";
            // 
            // BTN_AddClose
            // 
            this.BTN_AddClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_AddClose.BackColor = System.Drawing.Color.Transparent;
            this.BTN_AddClose.BorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.BorderRadius = 8;
            this.BTN_AddClose.BorderThickness = 2;
            this.BTN_AddClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AddClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_AddClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_AddClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_AddClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddClose.ForeColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_AddClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_AddClose.Image = global::Burn_management.Properties.Resources.icons8_Sync_50px_1;
            this.BTN_AddClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_AddClose.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_AddClose.Location = new System.Drawing.Point(192, 472);
            this.BTN_AddClose.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_AddClose.Name = "BTN_AddClose";
            this.BTN_AddClose.ShadowDecoration.BorderRadius = 20;
            this.BTN_AddClose.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_AddClose.ShadowDecoration.Depth = 100;
            this.BTN_AddClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_AddClose.Size = new System.Drawing.Size(584, 53);
            this.BTN_AddClose.TabIndex = 6;
            this.BTN_AddClose.Tag = "";
            this.BTN_AddClose.Text = "جلب العلامات";
            this.BTN_AddClose.Click += new System.EventHandler(this.BTN_AddClose_Click);
            // 
            // Form_GetGrade
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 537);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::Burn_management.Properties.Resources.icons8_test_40px_1;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GetGrade";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلومات الاختبار";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button BTN_AddClose;
        private System.Windows.Forms.ComboBox COMP_YearNumberExam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox COMP_Course;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TX_Branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COMP_Season;
        private System.Windows.Forms.ComboBox COMP_Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TX_NameEX;
    }
}