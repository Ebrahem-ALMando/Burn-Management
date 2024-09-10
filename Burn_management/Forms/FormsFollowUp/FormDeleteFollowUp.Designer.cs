namespace Burn_management.Forms.FormsFollowUp
{
    partial class FormDeleteFollowUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Result = new System.Windows.Forms.Label();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Delete_DelFollowUp = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Delete = new Guna.UI2.WinForms.Guna2Button();
            this._animateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(541, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "تنبيه هـــام";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Burn_management.Properties.Resources.icons8_box_important_50px;
            this.pictureBox1.Location = new System.Drawing.Point(656, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "هذه المتابعة نتيجتها                      هل تريد حذفها بالتأكيد ؟";
            // 
            // LBL_Result
            // 
            this.LBL_Result.AutoSize = true;
            this.LBL_Result.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Result.ForeColor = System.Drawing.Color.Red;
            this.LBL_Result.Location = new System.Drawing.Point(337, 67);
            this.LBL_Result.Name = "LBL_Result";
            this.LBL_Result.Size = new System.Drawing.Size(86, 37);
            this.LBL_Result.TabIndex = 6;
            this.LBL_Result.Text = "\" إحالة \"";
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
            this.BTN_Close.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.BorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Close.HoverState.ForeColor = System.Drawing.Color.Red;
            this.BTN_Close.Image = global::Burn_management.Properties.Resources.icons8_cancel_32px_2;
            this.BTN_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Close.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Close.Location = new System.Drawing.Point(397, 197);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.BorderRadius = 20;
            this.BTN_Close.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Close.ShadowDecoration.Depth = 100;
            this.BTN_Close.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Close.Size = new System.Drawing.Size(203, 52);
            this.BTN_Close.TabIndex = 10;
            this.BTN_Close.Tag = "";
            this.BTN_Close.Text = "اغلاق";
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Delete_DelFollowUp
            // 
            this.BTN_Delete_DelFollowUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Delete_DelFollowUp.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Delete_DelFollowUp.BorderColor = System.Drawing.Color.White;
            this.BTN_Delete_DelFollowUp.BorderRadius = 8;
            this.BTN_Delete_DelFollowUp.BorderThickness = 2;
            this.BTN_Delete_DelFollowUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete_DelFollowUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete_DelFollowUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Delete_DelFollowUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Delete_DelFollowUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Delete_DelFollowUp.FillColor = System.Drawing.Color.Firebrick;
            this.BTN_Delete_DelFollowUp.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete_DelFollowUp.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete_DelFollowUp.HoverState.BorderColor = System.Drawing.Color.White;
            this.BTN_Delete_DelFollowUp.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BTN_Delete_DelFollowUp.HoverState.FillColor = System.Drawing.Color.Brown;
            this.BTN_Delete_DelFollowUp.HoverState.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete_DelFollowUp.Image = global::Burn_management.Properties.Resources.icons8_Delete_Trash_50px;
            this.BTN_Delete_DelFollowUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Delete_DelFollowUp.ImageSize = new System.Drawing.Size(45, 45);
            this.BTN_Delete_DelFollowUp.Location = new System.Drawing.Point(140, 123);
            this.BTN_Delete_DelFollowUp.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Delete_DelFollowUp.Name = "BTN_Delete_DelFollowUp";
            this.BTN_Delete_DelFollowUp.ShadowDecoration.BorderRadius = 20;
            this.BTN_Delete_DelFollowUp.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Delete_DelFollowUp.ShadowDecoration.Depth = 100;
            this.BTN_Delete_DelFollowUp.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Delete_DelFollowUp.Size = new System.Drawing.Size(460, 52);
            this.BTN_Delete_DelFollowUp.TabIndex = 12;
            this.BTN_Delete_DelFollowUp.Tag = "";
            this.BTN_Delete_DelFollowUp.Text = "حذف والغاء الاحالة";
            this.BTN_Delete_DelFollowUp.Click += new System.EventHandler(this.BTN_Delete_DelFollowUp_Click);
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
            this.BTN_Delete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Delete.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.BTN_Delete.ForeColor = System.Drawing.Color.Red;
            this.BTN_Delete.HoverState.BorderColor = System.Drawing.Color.Red;
            this.BTN_Delete.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.BTN_Delete.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Delete.HoverState.ForeColor = System.Drawing.Color.Red;
            this.BTN_Delete.Image = global::Burn_management.Properties.Resources.icons8_Delete_Trash_60px_1;
            this.BTN_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTN_Delete.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Delete.Location = new System.Drawing.Point(140, 197);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.ShadowDecoration.BorderRadius = 20;
            this.BTN_Delete.ShadowDecoration.Color = System.Drawing.Color.White;
            this.BTN_Delete.ShadowDecoration.Depth = 100;
            this.BTN_Delete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Delete.Size = new System.Drawing.Size(203, 52);
            this.BTN_Delete.TabIndex = 13;
            this.BTN_Delete.Tag = "";
            this.BTN_Delete.Text = "حذف";
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // _animateWindow
            // 
            this._animateWindow.TargetForm = this;
            // 
            // FormDeleteFollowUp
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 266);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Delete_DelFollowUp);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.LBL_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "FormDeleteFollowUp";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeleteFollowUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Result;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private Guna.UI2.WinForms.Guna2Button BTN_Delete_DelFollowUp;
        private Guna.UI2.WinForms.Guna2Button BTN_Delete;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animateWindow;
    }
}