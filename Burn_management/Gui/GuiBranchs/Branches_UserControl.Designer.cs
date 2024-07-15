
namespace Burn_management.Gui.GuiHome
{
    partial class Branches_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branches_UserControl));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewBranchs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Export = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Update = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Add = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TX_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.MessageShow = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranchs)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 19.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1259, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 62);
            this.label10.TabIndex = 5;
            this.label10.Text = "الافــــرع";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = global::Burn_management.Properties.Resources.icons8_department_40px;
            this.label9.Location = new System.Drawing.Point(1389, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 62);
            this.label9.TabIndex = 3;
            this.label9.Text = "        ";
            // 
            // dataGridViewBranchs
            // 
            this.dataGridViewBranchs.AllowUserToAddRows = false;
            this.dataGridViewBranchs.AllowUserToDeleteRows = false;
            this.dataGridViewBranchs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBranchs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBranchs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBranchs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBranchs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBranchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBranchs.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBranchs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBranchs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.dataGridViewBranchs.Location = new System.Drawing.Point(0, 73);
            this.dataGridViewBranchs.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dataGridViewBranchs.Name = "dataGridViewBranchs";
            this.dataGridViewBranchs.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBranchs.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBranchs.RowHeadersWidth = 20;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBranchs.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBranchs.RowTemplate.Height = 26;
            this.dataGridViewBranchs.RowTemplate.ReadOnly = true;
            this.dataGridViewBranchs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBranchs.Size = new System.Drawing.Size(1474, 478);
            this.dataGridViewBranchs.StandardTab = true;
            this.dataGridViewBranchs.TabIndex = 18;
            this.dataGridViewBranchs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBranchs_CellClick);
            this.dataGridViewBranchs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBranchs_CellDoubleClick);
            this.dataGridViewBranchs.SelectionChanged += new System.EventHandler(this.dataGridViewBranchs_SelectionChanged);
            this.dataGridViewBranchs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewBranchs_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.BTN_Export);
            this.panel1.Controls.Add(this.BTN_Update);
            this.panel1.Controls.Add(this.BTN_Delete);
            this.panel1.Controls.Add(this.BTN_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 73);
            this.panel1.TabIndex = 19;
            // 
            // BTN_Export
            // 
            this.BTN_Export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Export.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Export.BorderColor = System.Drawing.Color.White;
            this.BTN_Export.BorderRadius = 8;
            this.BTN_Export.BorderThickness = 2;
            this.BTN_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Export.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Export.ForeColor = System.Drawing.Color.White;
            this.BTN_Export.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Export.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Export.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Export.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Export.HoverState.Image = global::Burn_management.Properties.Resources.icons8_upload_50px_2;
            this.BTN_Export.Image = global::Burn_management.Properties.Resources.icons8_upload_50px_1;
            this.BTN_Export.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Export.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Export.Location = new System.Drawing.Point(311, 11);
            this.BTN_Export.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Export.Name = "BTN_Export";
            this.BTN_Export.ShadowDecoration.BorderRadius = 20;
            this.BTN_Export.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Export.ShadowDecoration.Depth = 100;
            this.BTN_Export.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Export.Size = new System.Drawing.Size(191, 53);
            this.BTN_Export.TabIndex = 19;
            this.BTN_Export.Tag = "";
            this.BTN_Export.Text = "تصد ير ";
            this.BTN_Export.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Export.Click += new System.EventHandler(this.BTN_Export_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Update.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Update.BorderColor = System.Drawing.Color.White;
            this.BTN_Update.BorderRadius = 8;
            this.BTN_Update.BorderThickness = 2;
            this.BTN_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Update.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Update.ForeColor = System.Drawing.Color.White;
            this.BTN_Update.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Update.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Update.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Update.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Update.HoverState.Image = global::Burn_management.Properties.Resources.icons8_edit_50px_3;
            this.BTN_Update.Image = global::Burn_management.Properties.Resources.icons8_edit_50px;
            this.BTN_Update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Update.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Update.Location = new System.Drawing.Point(769, 11);
            this.BTN_Update.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.ShadowDecoration.BorderRadius = 20;
            this.BTN_Update.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Update.ShadowDecoration.Depth = 100;
            this.BTN_Update.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Update.Size = new System.Drawing.Size(193, 53);
            this.BTN_Update.TabIndex = 18;
            this.BTN_Update.Tag = "";
            this.BTN_Update.Text = "تعد يل";
            this.BTN_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Delete.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Delete.BorderColor = System.Drawing.Color.White;
            this.BTN_Delete.BorderRadius = 8;
            this.BTN_Delete.BorderThickness = 2;
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Delete.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Delete.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Delete.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Delete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Delete.HoverState.Image = global::Burn_management.Properties.Resources.icons8_Delete_Trash_50px_2;
            this.BTN_Delete.Image = global::Burn_management.Properties.Resources.icons8_Delete_Trash_50px;
            this.BTN_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Delete.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Delete.Location = new System.Drawing.Point(540, 11);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.ShadowDecoration.BorderRadius = 20;
            this.BTN_Delete.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Delete.ShadowDecoration.Depth = 100;
            this.BTN_Delete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Delete.Size = new System.Drawing.Size(191, 53);
            this.BTN_Delete.TabIndex = 17;
            this.BTN_Delete.Tag = "";
            this.BTN_Delete.Text = "حذف";
            this.BTN_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
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
            this.BTN_Add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Add.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Add.HoverState.FillColor = System.Drawing.Color.White;
            this.BTN_Add.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.BTN_Add.HoverState.Image = global::Burn_management.Properties.Resources.icons8_add_50px_4;
            this.BTN_Add.Image = global::Burn_management.Properties.Resources.icons8_add_50px_1;
            this.BTN_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Add.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Add.Location = new System.Drawing.Point(1000, 11);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.ShadowDecoration.BorderRadius = 20;
            this.BTN_Add.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Add.ShadowDecoration.Depth = 100;
            this.BTN_Add.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Add.Size = new System.Drawing.Size(193, 53);
            this.BTN_Add.TabIndex = 16;
            this.BTN_Add.Tag = "";
            this.BTN_Add.Text = "اضافة";
            this.BTN_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TX_Search);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 73);
            this.panel2.TabIndex = 20;
            // 
            // TX_Search
            // 
            this.TX_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.TX_Search.BorderRadius = 8;
            this.TX_Search.BorderThickness = 3;
            this.TX_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TX_Search.DefaultText = "";
            this.TX_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TX_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TX_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TX_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TX_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TX_Search.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.TX_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TX_Search.IconLeft = global::Burn_management.Properties.Resources.icons8_search_50px;
            this.TX_Search.IconLeftSize = new System.Drawing.Size(40, 40);
            this.TX_Search.Location = new System.Drawing.Point(52, 9);
            this.TX_Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TX_Search.Name = "TX_Search";
            this.TX_Search.Padding = new System.Windows.Forms.Padding(10, 2, 20, 2);
            this.TX_Search.PasswordChar = '\0';
            this.TX_Search.PlaceholderText = "";
            this.TX_Search.SelectedText = "";
            this.TX_Search.Size = new System.Drawing.Size(331, 54);
            this.TX_Search.TabIndex = 4;
            this.TX_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_Search.TextChanged += new System.EventHandler(this.TX_Search_TextChanged);
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
            this.MessageShow.ErrorOptions.ActionBorderRadius = 5;
            this.MessageShow.ErrorOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.ErrorOptions.BorderColor = System.Drawing.Color.Red;
            this.MessageShow.ErrorOptions.CloseIconColor = System.Drawing.Color.Red;
            this.MessageShow.ErrorOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.ErrorOptions.ForeColor = System.Drawing.Color.Red;
            this.MessageShow.ErrorOptions.Icon = global::Burn_management.Properties.Resources.CourseHome;
            this.MessageShow.ErrorOptions.IconLeftMargin = 12;
            this.MessageShow.FadeCloseIcon = false;
            this.MessageShow.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.Screen;
            this.MessageShow.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.InformationOptions.ActionBorderRadius = 1;
            this.MessageShow.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MessageShow.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.InformationOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.MessageShow.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.MessageShow.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MessageShow.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.MessageShow.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.MessageShow.InformationOptions.IconLeftMargin = 12;
            this.MessageShow.Margin = 10;
            this.MessageShow.MaximumSize = new System.Drawing.Size(0, 0);
            this.MessageShow.MaximumViews = 7;
            this.MessageShow.MessageRightMargin = 15;
            this.MessageShow.MessageTopMargin = 0;
            this.MessageShow.MinimumSize = new System.Drawing.Size(300, 0);
            this.MessageShow.ShowBorders = true;
            this.MessageShow.ShowCloseIcon = true;
            this.MessageShow.ShowIcon = true;
            this.MessageShow.ShowShadows = true;
            this.MessageShow.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessageShow.SuccessOptions.ActionBorderRadius = 1;
            this.MessageShow.SuccessOptions.ActionFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.MessageShow.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.MessageShow.SuccessOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.MessageShow.SuccessOptions.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold);
            this.MessageShow.SuccessOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(247)))));
            this.MessageShow.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
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
            this.MessageShow.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.MessageShow.WarningOptions.IconLeftMargin = 12;
            this.MessageShow.ZoomCloseIcon = true;
            // 
            // Branches_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBranchs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Branches_UserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1474, 624);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranchs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewBranchs;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BTN_Export;
        private Guna.UI2.WinForms.Guna2Button BTN_Update;
        private Guna.UI2.WinForms.Guna2Button BTN_Delete;
        private Guna.UI2.WinForms.Guna2Button BTN_Add;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox TX_Search;
        private Bunifu.UI.WinForms.BunifuSnackbar MessageShow;
    }
}
