namespace Burn_management.Forms.FormsExam
{
    partial class Form_AddExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddExam));
            this.MessageShow = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.BTN_Add = new Guna.UI2.WinForms.Guna2Button();
            this.TX_Branch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.COMP_Season = new System.Windows.Forms.ComboBox();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_AddClose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RIT_NoteExam = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.COMP_Course = new System.Windows.Forms.ComboBox();
            this.TX_DateExam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TX_FinalGradeExam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TX_CountQuExam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.COMP_Year = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_NameExam = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageShow
            // 
            this.MessageShow.AllowDragging = false;
            this.MessageShow.AllowMultipleViews = true;
            this.MessageShow.ClickToClose = true;
            this.MessageShow.DoubleClickToClose = true;
            this.MessageShow.DurationAfterIdle = 3000;
            this.MessageShow.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.ErrorOptions.ActionBorderRadius = 1;
            this.MessageShow.ErrorOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageShow.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.ErrorOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.MessageShow.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.MessageShow.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MessageShow.ErrorOptions.ForeColor = System.Drawing.Color.White;
            this.MessageShow.ErrorOptions.Icon = null;
            this.MessageShow.ErrorOptions.IconLeftMargin = 12;
            this.MessageShow.FadeCloseIcon = false;
            this.MessageShow.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.MessageShow.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.ActionBorderRadius = 0;
            this.MessageShow.InformationOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.InformationOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.InformationOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.InformationOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(189)))), ((int)(((byte)(66)))));
            this.MessageShow.InformationOptions.Icon = global::Burn_management.Properties.Resources.icons8_ok_50px;
            this.MessageShow.InformationOptions.IconLeftMargin = 0;
            this.MessageShow.Margin = 1;
            this.MessageShow.MaximumSize = new System.Drawing.Size(0, 0);
            this.MessageShow.MaximumViews = 7;
            this.MessageShow.MessageRightMargin = 15;
            this.MessageShow.MessageTopMargin = 0;
            this.MessageShow.MinimumSize = new System.Drawing.Size(300, 0);
            this.MessageShow.ShowBorders = true;
            this.MessageShow.ShowCloseIcon = true;
            this.MessageShow.ShowIcon = true;
            this.MessageShow.ShowShadows = true;
            this.MessageShow.SuccessOptions.ActionBackColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.ActionBorderColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.ActionBorderRadius = 3;
            this.MessageShow.SuccessOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ActionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.Icon = null;
            this.MessageShow.SuccessOptions.IconLeftMargin = 12;
            this.MessageShow.ViewsMargin = 7;
            this.MessageShow.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.WarningOptions.ActionBorderRadius = 1;
            this.MessageShow.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MessageShow.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.WarningOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.MessageShow.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.MessageShow.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MessageShow.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.MessageShow.WarningOptions.Icon = null;
            this.MessageShow.WarningOptions.IconLeftMargin = 12;
            this.MessageShow.ZoomCloseIcon = true;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Add.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Add.BorderColor = System.Drawing.Color.White;
            this.BTN_Add.BorderRadius = 8;
            this.BTN_Add.BorderThickness = 2;
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Add.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Add.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.Image = global::Burn_management.Properties.Resources.icons8_save_50px;
            this.BTN_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Add.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Add.Location = new System.Drawing.Point(470, 30);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.ShadowDecoration.BorderRadius = 20;
            this.BTN_Add.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Add.ShadowDecoration.Depth = 100;
            this.BTN_Add.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Add.Size = new System.Drawing.Size(584, 53);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.Tag = "";
            this.BTN_Add.Text = "حفظ";
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // TX_Branch
            // 
            this.TX_Branch.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Branch.Location = new System.Drawing.Point(542, 133);
            this.TX_Branch.Name = "TX_Branch";
            this.TX_Branch.ReadOnly = true;
            this.TX_Branch.Size = new System.Drawing.Size(339, 45);
            this.TX_Branch.TabIndex = 27;
            this.TX_Branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 12F);
            this.label4.Location = new System.Drawing.Point(903, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "الفرع الدراسي";
            // 
            // COMP_Season
            // 
            this.COMP_Season.BackColor = System.Drawing.Color.White;
            this.COMP_Season.DropDownHeight = 170;
            this.COMP_Season.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_Season.Font = new System.Drawing.Font("Cairo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_Season.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Season.FormattingEnabled = true;
            this.COMP_Season.IntegralHeight = false;
            this.COMP_Season.Items.AddRange(new object[] {
            "الفصل الأول",
            "الفصل الثاني",
            "الفصل الثالث"});
            this.COMP_Season.Location = new System.Drawing.Point(542, 301);
            this.COMP_Season.MaxDropDownItems = 5;
            this.COMP_Season.Name = "COMP_Season";
            this.COMP_Season.Size = new System.Drawing.Size(339, 50);
            this.COMP_Season.TabIndex = 3;
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Close.BorderColor = System.Drawing.Color.White;
            this.BTN_Close.BorderRadius = 8;
            this.BTN_Close.BorderThickness = 2;
            this.BTN_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Close.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_Close.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Close.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.Brown;
            this.BTN_Close.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Close.Image")));
            this.BTN_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Close.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Close.Location = new System.Drawing.Point(470, 150);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Close.ShadowDecoration.Depth = 100;
            this.BTN_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Close.Size = new System.Drawing.Size(584, 53);
            this.BTN_Close.TabIndex = 7;
            this.BTN_Close.Tag = "";
            this.BTN_Close.Text = "اغلاق";
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
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
            this.BTN_AddClose.Image = global::Burn_management.Properties.Resources.icons8_save_close_50px;
            this.BTN_AddClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_AddClose.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_AddClose.Location = new System.Drawing.Point(470, 90);
            this.BTN_AddClose.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_AddClose.Name = "BTN_AddClose";
            this.BTN_AddClose.ShadowDecoration.BorderRadius = 20;
            this.BTN_AddClose.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_AddClose.ShadowDecoration.Depth = 100;
            this.BTN_AddClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_AddClose.Size = new System.Drawing.Size(584, 53);
            this.BTN_AddClose.TabIndex = 6;
            this.BTN_AddClose.Tag = "";
            this.BTN_AddClose.Text = "حفظ وخروج";
            this.BTN_AddClose.Click += new System.EventHandler(this.BTN_AddClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.BTN_Close);
            this.groupBox2.Controls.Add(this.BTN_AddClose);
            this.groupBox2.Controls.Add(this.BTN_Add);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox2.Location = new System.Drawing.Point(5, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1518, 199);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحكم";
            // 
            // RIT_NoteExam
            // 
            this.RIT_NoteExam.Font = new System.Drawing.Font("Cairo", 12F);
            this.RIT_NoteExam.Location = new System.Drawing.Point(6, 296);
            this.RIT_NoteExam.Name = "RIT_NoteExam";
            this.RIT_NoteExam.Size = new System.Drawing.Size(339, 124);
            this.RIT_NoteExam.TabIndex = 4;
            this.RIT_NoteExam.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F);
            this.label1.Location = new System.Drawing.Point(903, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسـم النموذج";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Burn_management.Properties.Resources.exam;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-49, 34);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(576, 467);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 37;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F);
            this.label5.Location = new System.Drawing.Point(903, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "السنة الدراسية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F);
            this.label2.Location = new System.Drawing.Point(368, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "ملاحـــظـــات";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.COMP_Course);
            this.groupBox1.Controls.Add(this.TX_DateExam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TX_FinalGradeExam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TX_CountQuExam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TX_Branch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.COMP_Season);
            this.groupBox1.Controls.Add(this.COMP_Year);
            this.groupBox1.Controls.Add(this.RIT_NoteExam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TX_NameExam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox1.Location = new System.Drawing.Point(476, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 471);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات النـموذج";
            // 
            // COMP_Course
            // 
            this.COMP_Course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_Course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_Course.BackColor = System.Drawing.SystemColors.Window;
            this.COMP_Course.DisplayMember = "bh";
            this.COMP_Course.DropDownHeight = 170;
            this.COMP_Course.Font = new System.Drawing.Font("Cairo", 13.2F);
            this.COMP_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Course.FormattingEnabled = true;
            this.COMP_Course.IntegralHeight = false;
            this.COMP_Course.Location = new System.Drawing.Point(542, 385);
            this.COMP_Course.MaxDropDownItems = 5;
            this.COMP_Course.Name = "COMP_Course";
            this.COMP_Course.Size = new System.Drawing.Size(339, 50);
            this.COMP_Course.TabIndex = 36;
            // 
            // TX_DateExam
            // 
            this.TX_DateExam.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_DateExam.Location = new System.Drawing.Point(6, 52);
            this.TX_DateExam.Name = "TX_DateExam";
            this.TX_DateExam.Size = new System.Drawing.Size(339, 45);
            this.TX_DateExam.TabIndex = 34;
            this.TX_DateExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 12F);
            this.label9.Location = new System.Drawing.Point(366, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 37);
            this.label9.TabIndex = 35;
            this.label9.Text = "تاريخ دورة النموذج";
            // 
            // TX_FinalGradeExam
            // 
            this.TX_FinalGradeExam.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_FinalGradeExam.Location = new System.Drawing.Point(6, 214);
            this.TX_FinalGradeExam.Name = "TX_FinalGradeExam";
            this.TX_FinalGradeExam.Size = new System.Drawing.Size(339, 45);
            this.TX_FinalGradeExam.TabIndex = 32;
            this.TX_FinalGradeExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_FinalGradeExam.TextChanged += new System.EventHandler(this.TX_FinalGradeExam_TextChanged);
            this.TX_FinalGradeExam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_FinalGradeExam_KeyDown);
            this.TX_FinalGradeExam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_FinalGradeExam_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo", 12F);
            this.label8.Location = new System.Drawing.Point(366, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 37);
            this.label8.TabIndex = 33;
            this.label8.Text = "علامة النموذج";
            // 
            // TX_CountQuExam
            // 
            this.TX_CountQuExam.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_CountQuExam.Location = new System.Drawing.Point(6, 133);
            this.TX_CountQuExam.Name = "TX_CountQuExam";
            this.TX_CountQuExam.Size = new System.Drawing.Size(339, 45);
            this.TX_CountQuExam.TabIndex = 30;
            this.TX_CountQuExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_CountQuExam.TextChanged += new System.EventHandler(this.TX_CountQuExam_TextChanged);
            this.TX_CountQuExam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_CountQuExam_KeyDown);
            this.TX_CountQuExam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_CountQuExam_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 12F);
            this.label7.Location = new System.Drawing.Point(366, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 37);
            this.label7.TabIndex = 31;
            this.label7.Text = "عـدد الاسـئـلـة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F);
            this.label6.Location = new System.Drawing.Point(903, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 37);
            this.label6.TabIndex = 29;
            this.label6.Text = "اسـم الـمـادة";
            // 
            // COMP_Year
            // 
            this.COMP_Year.BackColor = System.Drawing.Color.White;
            this.COMP_Year.DropDownHeight = 170;
            this.COMP_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_Year.Font = new System.Drawing.Font("Cairo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Year.FormattingEnabled = true;
            this.COMP_Year.IntegralHeight = false;
            this.COMP_Year.Location = new System.Drawing.Point(542, 218);
            this.COMP_Year.MaxDropDownItems = 5;
            this.COMP_Year.Name = "COMP_Year";
            this.COMP_Year.Size = new System.Drawing.Size(339, 50);
            this.COMP_Year.TabIndex = 2;
            this.COMP_Year.SelectedIndexChanged += new System.EventHandler(this.COMP_Year_SelectedIndexChanged);
            this.COMP_Year.SelectionChangeCommitted += new System.EventHandler(this.COMP_Year_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F);
            this.label3.Location = new System.Drawing.Point(897, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "الفصل الدراسي";
            // 
            // TX_NameExam
            // 
            this.TX_NameExam.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_NameExam.Location = new System.Drawing.Point(543, 52);
            this.TX_NameExam.Name = "TX_NameExam";
            this.TX_NameExam.Size = new System.Drawing.Size(339, 45);
            this.TX_NameExam.TabIndex = 0;
            this.TX_NameExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_AddExam
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 695);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.IconOptions.Image = global::Burn_management.Properties.Resources.icons8_Add_properties_60px_2;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddExam";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة نموذج";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuSnackbar MessageShow;
        private Guna.UI2.WinForms.Guna2Button BTN_Add;
        private System.Windows.Forms.TextBox TX_Branch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMP_Season;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2Button BTN_AddClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RIT_NoteExam;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TX_NameExam;
        private System.Windows.Forms.TextBox TX_FinalGradeExam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TX_CountQuExam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TX_DateExam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox COMP_Course;
        private System.Windows.Forms.ComboBox COMP_Year;
    }
}