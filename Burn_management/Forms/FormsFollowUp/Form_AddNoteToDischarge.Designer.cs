namespace Burn_management.Forms.FormsFollowUp
{
    partial class Form_AddNoteToDischarge
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTX_Note = new System.Windows.Forms.RichTextBox();
            this.BTN_Add_Close = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this._animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Close);
            this.groupBox1.Controls.Add(this.BTN_Add_Close);
            this.groupBox1.Controls.Add(this.RTX_Note);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل التخريج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اضافة ملاحظة عند التخريج";
            // 
            // RTX_Note
            // 
            this.RTX_Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RTX_Note.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTX_Note.ForeColor = System.Drawing.Color.White;
            this.RTX_Note.Location = new System.Drawing.Point(20, 69);
            this.RTX_Note.Name = "RTX_Note";
            this.RTX_Note.Size = new System.Drawing.Size(606, 133);
            this.RTX_Note.TabIndex = 1;
            this.RTX_Note.Text = "";
            // 
            // BTN_Add_Close
            // 
            this.BTN_Add_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Add_Close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Add_Close.BorderColor = System.Drawing.Color.Red;
            this.BTN_Add_Close.BorderRadius = 8;
            this.BTN_Add_Close.BorderThickness = 2;
            this.BTN_Add_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Add_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Add_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Add_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Add_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Add_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Add_Close.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Close.ForeColor = System.Drawing.Color.White;
            this.BTN_Add_Close.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Add_Close.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Add_Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BTN_Add_Close.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Add_Close.Image = global::Burn_management.Properties.Resources.icons8_save_close_50px;
            this.BTN_Add_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Add_Close.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Add_Close.Location = new System.Drawing.Point(344, 221);
            this.BTN_Add_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Add_Close.Name = "BTN_Add_Close";
            this.BTN_Add_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Add_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Add_Close.ShadowDecoration.Depth = 100;
            this.BTN_Add_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Add_Close.Size = new System.Drawing.Size(282, 52);
            this.BTN_Add_Close.TabIndex = 19;
            this.BTN_Add_Close.Tag = "";
            this.BTN_Add_Close.Text = "حفظ واغلاق";
            this.BTN_Add_Close.Click += new System.EventHandler(this.BTN_Add_Close_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Close.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.BorderRadius = 8;
            this.BTN_Close.BorderThickness = 2;
            this.BTN_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Close.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Close.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.BorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.HoverState.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.Image = global::Burn_management.Properties.Resources.icons8_cancel_32px_2;
            this.BTN_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Close.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Close.Location = new System.Drawing.Point(20, 221);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Close.ShadowDecoration.Depth = 100;
            this.BTN_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Close.Size = new System.Drawing.Size(282, 52);
            this.BTN_Close.TabIndex = 20;
            this.BTN_Close.Tag = "";
            this.BTN_Close.Text = "اغـــــــــلاق";
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // _animate
            // 
            this._animate.TargetForm = this;
            // 
            // Form_AddNoteToDischarge
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 320);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddNoteToDischarge";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTX_Note;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2Button BTN_Add_Close;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animate;
    }
}