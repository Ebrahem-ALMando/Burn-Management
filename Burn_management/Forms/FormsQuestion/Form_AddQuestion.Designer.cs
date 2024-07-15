namespace Burn_management.Forms.FormsQuestion
{
    partial class Form_AddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddQuestion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.COMP_Exams = new System.Windows.Forms.ComboBox();
            this.TX_MarkQuestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TX_Branch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.COMP_Year = new System.Windows.Forms.ComboBox();
            this.RIT_QuestionText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_AddClose = new Guna.UI2.WinForms.Guna2Button();
            this.MessageShow = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Add = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTB_DeleteLastAnser = new System.Windows.Forms.Button();
            this.COMP_TypeQuestion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PAN_AnswerTrueFalse = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.COMP_Answer_TrueFalse = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.PAN_AnswerCheck = new System.Windows.Forms.Panel();
            this.RAD_Answer_1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RAD_Answer_2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RAD_Answer_4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RAD_Answer_3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_Answer_4 = new System.Windows.Forms.TextBox();
            this.TX_Answer_3 = new System.Windows.Forms.TextBox();
            this.TX_Answer_2 = new System.Windows.Forms.TextBox();
            this.TX_Answer_1 = new System.Windows.Forms.TextBox();
            this.BTN_DeleteAnswer = new System.Windows.Forms.Button();
            this.BTN_UpdateAnswer = new System.Windows.Forms.Button();
            this.BTN_AddAnswer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewQuestionsDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PAN_AnswerTrueFalse.SuspendLayout();
            this.PAN_AnswerCheck.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // COMP_Exams
            // 
            this.COMP_Exams.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COMP_Exams.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_Exams.BackColor = System.Drawing.SystemColors.Window;
            this.COMP_Exams.DisplayMember = "bh";
            this.COMP_Exams.DropDownHeight = 170;
            this.COMP_Exams.Font = new System.Drawing.Font("Cairo", 13.2F);
            this.COMP_Exams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Exams.FormattingEnabled = true;
            this.COMP_Exams.IntegralHeight = false;
            this.COMP_Exams.Location = new System.Drawing.Point(580, 177);
            this.COMP_Exams.MaxDropDownItems = 5;
            this.COMP_Exams.Name = "COMP_Exams";
            this.COMP_Exams.Size = new System.Drawing.Size(339, 50);
            this.COMP_Exams.TabIndex = 36;
            this.COMP_Exams.SelectedIndexChanged += new System.EventHandler(this.COMP_Exams_SelectedIndexChanged);
            this.COMP_Exams.TextChanged += new System.EventHandler(this.COMP_Exams_TextChanged);
            // 
            // TX_MarkQuestion
            // 
            this.TX_MarkQuestion.BackColor = System.Drawing.Color.White;
            this.TX_MarkQuestion.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_MarkQuestion.Location = new System.Drawing.Point(30, 44);
            this.TX_MarkQuestion.Name = "TX_MarkQuestion";
            this.TX_MarkQuestion.ReadOnly = true;
            this.TX_MarkQuestion.Size = new System.Drawing.Size(339, 45);
            this.TX_MarkQuestion.TabIndex = 30;
            this.TX_MarkQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_MarkQuestion.TextChanged += new System.EventHandler(this.TX_MarkQuestion_TextChanged);
            this.TX_MarkQuestion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TX_MarkQuestion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 12F);
            this.label7.Location = new System.Drawing.Point(398, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 37);
            this.label7.TabIndex = 31;
            this.label7.Text = "علامة السؤال";
            // 
            // TX_Branch
            // 
            this.TX_Branch.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Branch.Location = new System.Drawing.Point(580, 37);
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
            this.label4.Location = new System.Drawing.Point(946, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "الفرع الدراسي";
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
            this.COMP_Year.Location = new System.Drawing.Point(580, 105);
            this.COMP_Year.MaxDropDownItems = 5;
            this.COMP_Year.Name = "COMP_Year";
            this.COMP_Year.Size = new System.Drawing.Size(339, 50);
            this.COMP_Year.TabIndex = 2;
            this.COMP_Year.SelectedIndexChanged += new System.EventHandler(this.COMP_Year_SelectedIndexChanged);
            // 
            // RIT_QuestionText
            // 
            this.RIT_QuestionText.Font = new System.Drawing.Font("Cairo", 12F);
            this.RIT_QuestionText.Location = new System.Drawing.Point(15, 268);
            this.RIT_QuestionText.Name = "RIT_QuestionText";
            this.RIT_QuestionText.Size = new System.Drawing.Size(1057, 368);
            this.RIT_QuestionText.TabIndex = 4;
            this.RIT_QuestionText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F);
            this.label5.Location = new System.Drawing.Point(946, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "السنة الدراسية";
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
            this.BTN_Close.Location = new System.Drawing.Point(12, 32);
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
            this.BTN_AddClose.Location = new System.Drawing.Point(598, 31);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.BTN_Close);
            this.groupBox2.Controls.Add(this.BTN_Add);
            this.groupBox2.Controls.Add(this.BTN_AddClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 637);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1806, 91);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحكم";
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
            this.BTN_Add.Location = new System.Drawing.Point(1188, 31);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.COMP_Exams);
            this.groupBox1.Controls.Add(this.RIT_QuestionText);
            this.groupBox1.Controls.Add(this.TX_Branch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.COMP_Year);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox1.Location = new System.Drawing.Point(715, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 649);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات النـموذج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(380, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 37);
            this.label3.TabIndex = 40;
            this.label3.Text = "نـــــــــــــــــــص الـســـــــــــــــؤوال";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.BTB_DeleteLastAnser);
            this.groupBox3.Controls.Add(this.COMP_TypeQuestion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TX_MarkQuestion);
            this.groupBox3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 227);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "معلومات السؤال";
            // 
            // BTB_DeleteLastAnser
            // 
            this.BTB_DeleteLastAnser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTB_DeleteLastAnser.ForeColor = System.Drawing.Color.White;
            this.BTB_DeleteLastAnser.Image = global::Burn_management.Properties.Resources.icons8_Delete_Trash_50px;
            this.BTB_DeleteLastAnser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTB_DeleteLastAnser.Location = new System.Drawing.Point(31, 172);
            this.BTB_DeleteLastAnser.Margin = new System.Windows.Forms.Padding(5);
            this.BTB_DeleteLastAnser.Name = "BTB_DeleteLastAnser";
            this.BTB_DeleteLastAnser.Size = new System.Drawing.Size(339, 55);
            this.BTB_DeleteLastAnser.TabIndex = 45;
            this.BTB_DeleteLastAnser.Text = "حذف الاجابات السابقة";
            this.BTB_DeleteLastAnser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTB_DeleteLastAnser.UseVisualStyleBackColor = false;
            this.BTB_DeleteLastAnser.Click += new System.EventHandler(this.BTB_DeleteLastAnser_Click);
            // 
            // COMP_TypeQuestion
            // 
            this.COMP_TypeQuestion.BackColor = System.Drawing.Color.White;
            this.COMP_TypeQuestion.DropDownHeight = 170;
            this.COMP_TypeQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_TypeQuestion.Font = new System.Drawing.Font("Cairo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_TypeQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_TypeQuestion.FormattingEnabled = true;
            this.COMP_TypeQuestion.IntegralHeight = false;
            this.COMP_TypeQuestion.Items.AddRange(new object[] {
            "اختر الاجابة الصحيحة",
            "صح وخطأ"});
            this.COMP_TypeQuestion.Location = new System.Drawing.Point(30, 112);
            this.COMP_TypeQuestion.MaxDropDownItems = 5;
            this.COMP_TypeQuestion.Name = "COMP_TypeQuestion";
            this.COMP_TypeQuestion.Size = new System.Drawing.Size(339, 50);
            this.COMP_TypeQuestion.TabIndex = 2;
            this.COMP_TypeQuestion.SelectedIndexChanged += new System.EventHandler(this.CIMP_TypeQuestion_SelectedIndexChanged);
            this.COMP_TypeQuestion.Click += new System.EventHandler(this.COMP_TypeQuestion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F);
            this.label6.Location = new System.Drawing.Point(410, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "نوع الســؤال";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F);
            this.label1.Location = new System.Drawing.Point(946, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسـم النموذج";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.BTN_DeleteAnswer);
            this.groupBox4.Controls.Add(this.BTN_UpdateAnswer);
            this.groupBox4.Controls.Add(this.BTN_AddAnswer);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.groupBox4.Location = new System.Drawing.Point(33, -5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(676, 636);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "معلومات الاجابات";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.PAN_AnswerTrueFalse);
            this.panel1.Controls.Add(this.PAN_AnswerCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 232);
            this.panel1.TabIndex = 44;
            // 
            // PAN_AnswerTrueFalse
            // 
            this.PAN_AnswerTrueFalse.Controls.Add(this.label21);
            this.PAN_AnswerTrueFalse.Controls.Add(this.COMP_Answer_TrueFalse);
            this.PAN_AnswerTrueFalse.Controls.Add(this.label18);
            this.PAN_AnswerTrueFalse.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_AnswerTrueFalse.Location = new System.Drawing.Point(0, 0);
            this.PAN_AnswerTrueFalse.Name = "PAN_AnswerTrueFalse";
            this.PAN_AnswerTrueFalse.Size = new System.Drawing.Size(670, 229);
            this.PAN_AnswerTrueFalse.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cairo", 12F);
            this.label21.Location = new System.Drawing.Point(499, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 37);
            this.label21.TabIndex = 36;
            this.label21.Text = "الاجــــابــــــة ";
            // 
            // COMP_Answer_TrueFalse
            // 
            this.COMP_Answer_TrueFalse.BackColor = System.Drawing.Color.White;
            this.COMP_Answer_TrueFalse.DropDownHeight = 170;
            this.COMP_Answer_TrueFalse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_Answer_TrueFalse.Font = new System.Drawing.Font("Cairo", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMP_Answer_TrueFalse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.COMP_Answer_TrueFalse.FormattingEnabled = true;
            this.COMP_Answer_TrueFalse.IntegralHeight = false;
            this.COMP_Answer_TrueFalse.Items.AddRange(new object[] {
            "صح",
            "خطأ"});
            this.COMP_Answer_TrueFalse.Location = new System.Drawing.Point(53, 77);
            this.COMP_Answer_TrueFalse.MaxDropDownItems = 5;
            this.COMP_Answer_TrueFalse.Name = "COMP_Answer_TrueFalse";
            this.COMP_Answer_TrueFalse.Size = new System.Drawing.Size(368, 50);
            this.COMP_Answer_TrueFalse.TabIndex = 32;
            this.COMP_Answer_TrueFalse.SelectedIndexChanged += new System.EventHandler(this.COMP_Answer_TrueFalse_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Crimson;
            this.label18.Location = new System.Drawing.Point(427, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 37);
            this.label18.TabIndex = 45;
            this.label18.Text = "*";
            // 
            // PAN_AnswerCheck
            // 
            this.PAN_AnswerCheck.Controls.Add(this.RAD_Answer_1);
            this.PAN_AnswerCheck.Controls.Add(this.RAD_Answer_2);
            this.PAN_AnswerCheck.Controls.Add(this.RAD_Answer_4);
            this.PAN_AnswerCheck.Controls.Add(this.RAD_Answer_3);
            this.PAN_AnswerCheck.Controls.Add(this.label13);
            this.PAN_AnswerCheck.Controls.Add(this.label12);
            this.PAN_AnswerCheck.Controls.Add(this.label11);
            this.PAN_AnswerCheck.Controls.Add(this.label16);
            this.PAN_AnswerCheck.Controls.Add(this.label10);
            this.PAN_AnswerCheck.Controls.Add(this.label9);
            this.PAN_AnswerCheck.Controls.Add(this.label8);
            this.PAN_AnswerCheck.Controls.Add(this.label2);
            this.PAN_AnswerCheck.Controls.Add(this.TX_Answer_4);
            this.PAN_AnswerCheck.Controls.Add(this.TX_Answer_3);
            this.PAN_AnswerCheck.Controls.Add(this.TX_Answer_2);
            this.PAN_AnswerCheck.Controls.Add(this.TX_Answer_1);
            this.PAN_AnswerCheck.Location = new System.Drawing.Point(14, 0);
            this.PAN_AnswerCheck.Name = "PAN_AnswerCheck";
            this.PAN_AnswerCheck.Size = new System.Drawing.Size(641, 238);
            this.PAN_AnswerCheck.TabIndex = 0;
            // 
            // RAD_Answer_1
            // 
            this.RAD_Answer_1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_1.CheckedState.BorderThickness = 0;
            this.RAD_Answer_1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RAD_Answer_1.Location = new System.Drawing.Point(27, 28);
            this.RAD_Answer_1.Name = "RAD_Answer_1";
            this.RAD_Answer_1.Size = new System.Drawing.Size(20, 20);
            this.RAD_Answer_1.TabIndex = 52;
            this.RAD_Answer_1.Text = "guna2CustomRadioButton4";
            this.RAD_Answer_1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RAD_Answer_1.UncheckedState.BorderThickness = 2;
            this.RAD_Answer_1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_1.CheckedChanged += new System.EventHandler(this.RAD_Answer_1_CheckedChanged);
            this.RAD_Answer_1.Click += new System.EventHandler(this.RAD_Answer_1_Click);
            // 
            // RAD_Answer_2
            // 
            this.RAD_Answer_2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_2.CheckedState.BorderThickness = 0;
            this.RAD_Answer_2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RAD_Answer_2.Location = new System.Drawing.Point(26, 80);
            this.RAD_Answer_2.Name = "RAD_Answer_2";
            this.RAD_Answer_2.Size = new System.Drawing.Size(20, 20);
            this.RAD_Answer_2.TabIndex = 51;
            this.RAD_Answer_2.Text = "guna2CustomRadioButton3";
            this.RAD_Answer_2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RAD_Answer_2.UncheckedState.BorderThickness = 2;
            this.RAD_Answer_2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_2.CheckedChanged += new System.EventHandler(this.RAD_Answer_2_CheckedChanged);
            this.RAD_Answer_2.Click += new System.EventHandler(this.RAD_Answer_2_Click);
            // 
            // RAD_Answer_4
            // 
            this.RAD_Answer_4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_4.CheckedState.BorderThickness = 0;
            this.RAD_Answer_4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RAD_Answer_4.Location = new System.Drawing.Point(26, 187);
            this.RAD_Answer_4.Name = "RAD_Answer_4";
            this.RAD_Answer_4.Size = new System.Drawing.Size(20, 20);
            this.RAD_Answer_4.TabIndex = 50;
            this.RAD_Answer_4.Text = "guna2CustomRadioButton2";
            this.RAD_Answer_4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RAD_Answer_4.UncheckedState.BorderThickness = 2;
            this.RAD_Answer_4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_4.CheckedChanged += new System.EventHandler(this.RAD_Answer_4_CheckedChanged);
            this.RAD_Answer_4.Click += new System.EventHandler(this.RAD_Answer_4_Click);
            // 
            // RAD_Answer_3
            // 
            this.RAD_Answer_3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_3.CheckedState.BorderThickness = 0;
            this.RAD_Answer_3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAD_Answer_3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RAD_Answer_3.Location = new System.Drawing.Point(26, 136);
            this.RAD_Answer_3.Name = "RAD_Answer_3";
            this.RAD_Answer_3.Size = new System.Drawing.Size(20, 20);
            this.RAD_Answer_3.TabIndex = 49;
            this.RAD_Answer_3.Text = "guna2CustomRadioButton1";
            this.RAD_Answer_3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RAD_Answer_3.UncheckedState.BorderThickness = 2;
            this.RAD_Answer_3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RAD_Answer_3.CheckedChanged += new System.EventHandler(this.RAD_Answer_3_CheckedChanged);
            this.RAD_Answer_3.Click += new System.EventHandler(this.RAD_Answer_3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(468, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 37);
            this.label13.TabIndex = 48;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(468, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 37);
            this.label12.TabIndex = 47;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(468, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 37);
            this.label11.TabIndex = 46;
            this.label11.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(468, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 37);
            this.label16.TabIndex = 45;
            this.label16.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 12F);
            this.label10.Location = new System.Drawing.Point(508, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 37);
            this.label10.TabIndex = 38;
            this.label10.Text = "الاجابة الرابعة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 12F);
            this.label9.Location = new System.Drawing.Point(514, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 37);
            this.label9.TabIndex = 37;
            this.label9.Text = "الاجابة الثالثة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo", 12F);
            this.label8.Location = new System.Drawing.Point(514, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 37);
            this.label8.TabIndex = 36;
            this.label8.Text = "الاجابة الثانية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F);
            this.label2.Location = new System.Drawing.Point(508, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "الاجابة الاولى";
            // 
            // TX_Answer_4
            // 
            this.TX_Answer_4.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Answer_4.Location = new System.Drawing.Point(53, 181);
            this.TX_Answer_4.Name = "TX_Answer_4";
            this.TX_Answer_4.Size = new System.Drawing.Size(409, 45);
            this.TX_Answer_4.TabIndex = 35;
            this.TX_Answer_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TX_Answer_3
            // 
            this.TX_Answer_3.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Answer_3.Location = new System.Drawing.Point(53, 122);
            this.TX_Answer_3.Name = "TX_Answer_3";
            this.TX_Answer_3.Size = new System.Drawing.Size(409, 45);
            this.TX_Answer_3.TabIndex = 34;
            this.TX_Answer_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TX_Answer_2
            // 
            this.TX_Answer_2.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Answer_2.Location = new System.Drawing.Point(53, 65);
            this.TX_Answer_2.Name = "TX_Answer_2";
            this.TX_Answer_2.Size = new System.Drawing.Size(409, 45);
            this.TX_Answer_2.TabIndex = 33;
            this.TX_Answer_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TX_Answer_1
            // 
            this.TX_Answer_1.Font = new System.Drawing.Font("Cairo", 12F);
            this.TX_Answer_1.Location = new System.Drawing.Point(53, 9);
            this.TX_Answer_1.Name = "TX_Answer_1";
            this.TX_Answer_1.Size = new System.Drawing.Size(409, 45);
            this.TX_Answer_1.TabIndex = 32;
            this.TX_Answer_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Answer_1.TextChanged += new System.EventHandler(this.TX_Answer_1_TextChanged);
            // 
            // BTN_DeleteAnswer
            // 
            this.BTN_DeleteAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_DeleteAnswer.ForeColor = System.Drawing.Color.White;
            this.BTN_DeleteAnswer.Image = global::Burn_management.Properties.Resources.icons8_Delete_Trash_50px;
            this.BTN_DeleteAnswer.Location = new System.Drawing.Point(145, 281);
            this.BTN_DeleteAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_DeleteAnswer.Name = "BTN_DeleteAnswer";
            this.BTN_DeleteAnswer.Size = new System.Drawing.Size(98, 55);
            this.BTN_DeleteAnswer.TabIndex = 43;
            this.BTN_DeleteAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DeleteAnswer.UseVisualStyleBackColor = false;
            // 
            // BTN_UpdateAnswer
            // 
            this.BTN_UpdateAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_UpdateAnswer.ForeColor = System.Drawing.Color.White;
            this.BTN_UpdateAnswer.Image = global::Burn_management.Properties.Resources.icons8_edit_50px;
            this.BTN_UpdateAnswer.Location = new System.Drawing.Point(261, 281);
            this.BTN_UpdateAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_UpdateAnswer.Name = "BTN_UpdateAnswer";
            this.BTN_UpdateAnswer.Size = new System.Drawing.Size(98, 55);
            this.BTN_UpdateAnswer.TabIndex = 42;
            this.BTN_UpdateAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_UpdateAnswer.UseVisualStyleBackColor = false;
            this.BTN_UpdateAnswer.Click += new System.EventHandler(this.BTN_UpdateAnswer_Click);
            // 
            // BTN_AddAnswer
            // 
            this.BTN_AddAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_AddAnswer.ForeColor = System.Drawing.Color.White;
            this.BTN_AddAnswer.Image = global::Burn_management.Properties.Resources.icons8_add_50px_1;
            this.BTN_AddAnswer.Location = new System.Drawing.Point(386, 281);
            this.BTN_AddAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_AddAnswer.Name = "BTN_AddAnswer";
            this.BTN_AddAnswer.Size = new System.Drawing.Size(98, 55);
            this.BTN_AddAnswer.TabIndex = 41;
            this.BTN_AddAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_AddAnswer.UseVisualStyleBackColor = false;
            this.BTN_AddAnswer.Click += new System.EventHandler(this.BTN_AddAnswer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewQuestionsDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 294);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewQuestionsDetails
            // 
            this.dataGridViewQuestionsDetails.AllowUserToAddRows = false;
            this.dataGridViewQuestionsDetails.AllowUserToDeleteRows = false;
            this.dataGridViewQuestionsDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuestionsDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewQuestionsDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuestionsDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewQuestionsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestionsDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameExam,
            this.Column2,
            this.TrueAnswer});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuestionsDetails.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewQuestionsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuestionsDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewQuestionsDetails.Name = "dataGridViewQuestionsDetails";
            this.dataGridViewQuestionsDetails.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuestionsDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewQuestionsDetails.RowHeadersWidth = 20;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewQuestionsDetails.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewQuestionsDetails.RowTemplate.Height = 26;
            this.dataGridViewQuestionsDetails.RowTemplate.ReadOnly = true;
            this.dataGridViewQuestionsDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuestionsDetails.Size = new System.Drawing.Size(670, 294);
            this.dataGridViewQuestionsDetails.StandardTab = true;
            this.dataGridViewQuestionsDetails.TabIndex = 23;
            this.dataGridViewQuestionsDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuestionsDetails_CellClick);
            this.dataGridViewQuestionsDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewQuestionsDetails_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // nameExam
            // 
            this.nameExam.FillWeight = 80F;
            this.nameExam.HeaderText = "اسم النموذج";
            this.nameExam.MinimumWidth = 6;
            this.nameExam.Name = "nameExam";
            this.nameExam.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الاجابات";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // TrueAnswer
            // 
            this.TrueAnswer.HeaderText = "الاجابة الصح";
            this.TrueAnswer.MinimumWidth = 6;
            this.TrueAnswer.Name = "TrueAnswer";
            this.TrueAnswer.ReadOnly = true;
            this.TrueAnswer.Visible = false;
            // 
            // Form_AddQuestion
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 728);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::Burn_management.Properties.Resources.icons8_Add_properties_60px_2;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddQuestion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة اسئلة";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PAN_AnswerTrueFalse.ResumeLayout(false);
            this.PAN_AnswerTrueFalse.PerformLayout();
            this.PAN_AnswerCheck.ResumeLayout(false);
            this.PAN_AnswerCheck.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionsDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox COMP_Exams;
        private System.Windows.Forms.TextBox TX_MarkQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TX_Branch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMP_Year;
        private System.Windows.Forms.RichTextBox RIT_QuestionText;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2Button BTN_AddClose;
        public Bunifu.UI.WinForms.BunifuSnackbar MessageShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox COMP_TypeQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BTN_Add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PAN_AnswerCheck;
        private System.Windows.Forms.TextBox TX_Answer_2;
        private System.Windows.Forms.TextBox TX_Answer_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TX_Answer_4;
        private System.Windows.Forms.TextBox TX_Answer_3;
        private System.Windows.Forms.DataGridView dataGridViewQuestionsDetails;
        private System.Windows.Forms.Button BTN_DeleteAnswer;
        private System.Windows.Forms.Button BTN_UpdateAnswer;
        private System.Windows.Forms.Button BTN_AddAnswer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RAD_Answer_3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RAD_Answer_1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RAD_Answer_2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RAD_Answer_4;
        private System.Windows.Forms.Panel PAN_AnswerTrueFalse;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox COMP_Answer_TrueFalse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueAnswer;
        private System.Windows.Forms.Button BTB_DeleteLastAnser;
    }
}