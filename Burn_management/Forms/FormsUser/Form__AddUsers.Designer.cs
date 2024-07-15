namespace Burn_management.Forms.FormsUser
{
    partial class Form__AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form__AddUsers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TX_Age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Home = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_CheckUserName = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckPassword = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.COMP_TypeUser = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TX_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TX_UserName = new System.Windows.Forms.TextBox();
            this.TX_Address_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_Phone_User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_Name_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_AddClose = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MessageShow = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CheckUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckPassword)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TX_Age);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TX_Address_User);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TX_Phone_User);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TX_Name_User);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox1.Location = new System.Drawing.Point(514, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 612);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم";
            // 
            // TX_Age
            // 
            this.TX_Age.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_Age.Location = new System.Drawing.Point(35, 145);
            this.TX_Age.Name = "TX_Age";
            this.TX_Age.Size = new System.Drawing.Size(365, 45);
            this.TX_Age.TabIndex = 2;
            this.TX_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_Age_KeyDown);
            this.TX_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_Age_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(486, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "العمر \"السنة\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.pictureBox_CheckUserName);
            this.groupBox3.Controls.Add(this.pictureBoxCheckPassword);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.COMP_TypeUser);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TX_Password);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TX_UserName);
            this.groupBox3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 249);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "معلومات المصادقة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.guna2Button2);
            this.groupBox2.Controls.Add(this.guna2Button1);
            this.groupBox2.Controls.Add(this.BTN_Home);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 205);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحكم";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Firebrick;
            this.guna2Button2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Brown;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button2.Location = new System.Drawing.Point(31, 153);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 20;
            this.guna2Button2.ShadowDecoration.Color = System.Drawing.Color.White;
            this.guna2Button2.ShadowDecoration.Depth = 100;
            this.guna2Button2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Button2.Size = new System.Drawing.Size(584, 53);
            this.guna2Button2.TabIndex = 19;
            this.guna2Button2.Tag = "";
            this.guna2Button2.Text = "اغلاق";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.guna2Button1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Burn_management.Properties.Resources.icons8_save_close_50px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button1.Location = new System.Drawing.Point(31, 93);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 20;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.guna2Button1.ShadowDecoration.Depth = 100;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Button1.Size = new System.Drawing.Size(584, 53);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Tag = "";
            this.guna2Button1.Text = "حفظ وخروج";
            // 
            // BTN_Home
            // 
            this.BTN_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Home.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Home.BorderColor = System.Drawing.Color.White;
            this.BTN_Home.BorderRadius = 8;
            this.BTN_Home.BorderThickness = 2;
            this.BTN_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Home.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Home.ForeColor = System.Drawing.Color.White;
            this.BTN_Home.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Home.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Home.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Home.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Home.Image = global::Burn_management.Properties.Resources.icons8_save_50px;
            this.BTN_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Home.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Home.Location = new System.Drawing.Point(31, 33);
            this.BTN_Home.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.ShadowDecoration.BorderRadius = 20;
            this.BTN_Home.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Home.ShadowDecoration.Depth = 100;
            this.BTN_Home.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Home.Size = new System.Drawing.Size(584, 53);
            this.BTN_Home.TabIndex = 17;
            this.BTN_Home.Tag = "";
            this.BTN_Home.Text = "حفظ";
            // 
            // pictureBox_CheckUserName
            // 
            this.pictureBox_CheckUserName.BackColor = System.Drawing.Color.White;
            this.pictureBox_CheckUserName.Location = new System.Drawing.Point(46, 59);
            this.pictureBox_CheckUserName.Name = "pictureBox_CheckUserName";
            this.pictureBox_CheckUserName.Size = new System.Drawing.Size(33, 35);
            this.pictureBox_CheckUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CheckUserName.TabIndex = 31;
            this.pictureBox_CheckUserName.TabStop = false;
            this.pictureBox_CheckUserName.Visible = false;
            // 
            // pictureBoxCheckPassword
            // 
            this.pictureBoxCheckPassword.BackColor = System.Drawing.Color.White;
            this.pictureBoxCheckPassword.Location = new System.Drawing.Point(46, 142);
            this.pictureBoxCheckPassword.Name = "pictureBoxCheckPassword";
            this.pictureBoxCheckPassword.Size = new System.Drawing.Size(33, 35);
            this.pictureBoxCheckPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheckPassword.TabIndex = 30;
            this.pictureBoxCheckPassword.TabStop = false;
            this.pictureBoxCheckPassword.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(265, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "كلمة المرور قصيرة جدا";
            this.label10.Visible = false;
            // 
            // COMP_TypeUser
            // 
            this.COMP_TypeUser.BackColor = System.Drawing.Color.White;
            this.COMP_TypeUser.DropDownHeight = 170;
            this.COMP_TypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_TypeUser.Font = new System.Drawing.Font("Cairo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_TypeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.COMP_TypeUser.FormattingEnabled = true;
            this.COMP_TypeUser.IntegralHeight = false;
            this.COMP_TypeUser.Items.AddRange(new object[] {
            "مسؤول",
            "مشرف علاج",
            "مدخل بيانات"});
            this.COMP_TypeUser.Location = new System.Drawing.Point(35, 196);
            this.COMP_TypeUser.MaxDropDownItems = 5;
            this.COMP_TypeUser.Name = "COMP_TypeUser";
            this.COMP_TypeUser.Size = new System.Drawing.Size(365, 50);
            this.COMP_TypeUser.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label9.Location = new System.Drawing.Point(478, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 37);
            this.label9.TabIndex = 28;
            this.label9.Text = "نوع المستخدم";
            // 
            // TX_Password
            // 
            this.TX_Password.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_Password.Location = new System.Drawing.Point(35, 134);
            this.TX_Password.Name = "TX_Password";
            this.TX_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TX_Password.Size = new System.Drawing.Size(365, 45);
            this.TX_Password.TabIndex = 6;
            this.TX_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Password.TextChanged += new System.EventHandler(this.TX_Password_TextChanged);
            this.TX_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_Password_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label8.Location = new System.Drawing.Point(491, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "كلــمة الســر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(493, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "اسم الحساب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(228, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "اسم المستخدم موجود مسبقا";
            this.label7.Visible = false;
            // 
            // TX_UserName
            // 
            this.TX_UserName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_UserName.Location = new System.Drawing.Point(35, 53);
            this.TX_UserName.Name = "TX_UserName";
            this.TX_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TX_UserName.Size = new System.Drawing.Size(365, 45);
            this.TX_UserName.TabIndex = 5;
            this.TX_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_UserName.TextChanged += new System.EventHandler(this.TX_UserName_TextChanged_1);
            this.TX_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_UserName_KeyDown);
            // 
            // TX_Address_User
            // 
            this.TX_Address_User.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Address_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_Address_User.Location = new System.Drawing.Point(35, 269);
            this.TX_Address_User.Name = "TX_Address_User";
            this.TX_Address_User.Size = new System.Drawing.Size(365, 45);
            this.TX_Address_User.TabIndex = 4;
            this.TX_Address_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Address_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_Address_User_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(474, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "مــكان الإقــامـة";
            // 
            // TX_Phone_User
            // 
            this.TX_Phone_User.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Phone_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_Phone_User.Location = new System.Drawing.Point(35, 204);
            this.TX_Phone_User.Name = "TX_Phone_User";
            this.TX_Phone_User.Size = new System.Drawing.Size(365, 45);
            this.TX_Phone_User.TabIndex = 3;
            this.TX_Phone_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Phone_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_Phone_User_KeyDown);
            this.TX_Phone_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_Phone_User_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(484, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "رقـــم الهاتــــف";
            // 
            // TX_Name_User
            // 
            this.TX_Name_User.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Name_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TX_Name_User.Location = new System.Drawing.Point(35, 83);
            this.TX_Name_User.Name = "TX_Name_User";
            this.TX_Name_User.Size = new System.Drawing.Size(365, 45);
            this.TX_Name_User.TabIndex = 1;
            this.TX_Name_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Name_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_Name_User_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(486, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BTN_Close);
            this.groupBox4.Controls.Add(this.BTN_AddClose);
            this.groupBox4.Controls.Add(this.BTN_Add);
            this.groupBox4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.groupBox4.Location = new System.Drawing.Point(7, 609);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1160, 205);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تحكم";
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
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.BTN_Close.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Close.Image")));
            this.BTN_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Close.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Close.Location = new System.Drawing.Point(288, 145);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Close.ShadowDecoration.Depth = 100;
            this.BTN_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Close.Size = new System.Drawing.Size(584, 53);
            this.BTN_Close.TabIndex = 10;
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
            this.BTN_AddClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTN_AddClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddClose.ForeColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_AddClose.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_AddClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_AddClose.Image = global::Burn_management.Properties.Resources.icons8_save_close_50px;
            this.BTN_AddClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_AddClose.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_AddClose.Location = new System.Drawing.Point(288, 85);
            this.BTN_AddClose.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_AddClose.Name = "BTN_AddClose";
            this.BTN_AddClose.ShadowDecoration.BorderRadius = 20;
            this.BTN_AddClose.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_AddClose.ShadowDecoration.Depth = 100;
            this.BTN_AddClose.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_AddClose.Size = new System.Drawing.Size(584, 53);
            this.BTN_AddClose.TabIndex = 9;
            this.BTN_AddClose.Tag = "";
            this.BTN_AddClose.Text = "حفظ وخروج";
            this.BTN_AddClose.Click += new System.EventHandler(this.BTN_AddClose_Click);
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
            this.BTN_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BTN_Add.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_Add.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Add.Image = global::Burn_management.Properties.Resources.icons8_save_50px;
            this.BTN_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Add.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Add.Location = new System.Drawing.Point(288, 25);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.ShadowDecoration.BorderRadius = 20;
            this.BTN_Add.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Add.ShadowDecoration.Depth = 100;
            this.BTN_Add.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Add.Size = new System.Drawing.Size(584, 53);
            this.BTN_Add.TabIndex = 8;
            this.BTN_Add.Tag = "";
            this.BTN_Add.Text = "حفظ";
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Burn_management.Properties.Resources.Add_User1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 76);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(501, 539);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 32;
            this.guna2PictureBox1.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Burn_management.Properties.Resources._2148748915_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(7, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 594);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form__AddUsers
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 818);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::Burn_management.Properties.Resources.icons8_Add_Male_User_Group_40px;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form__AddUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CheckUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckPassword)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TX_Address_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TX_Phone_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TX_Name_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button BTN_Home;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TX_Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox COMP_TypeUser;
        private System.Windows.Forms.PictureBox pictureBox_CheckUserName;
        private System.Windows.Forms.PictureBox pictureBoxCheckPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TX_UserName;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2Button BTN_AddClose;
        private Guna.UI2.WinForms.Guna2Button BTN_Add;
        public Bunifu.UI.WinForms.BunifuSnackbar MessageShow;
        private System.Windows.Forms.TextBox TX_Age;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}