using System;
using System.Drawing;

namespace Burn_management.Forms.FormsFollowUp
{
    public partial class FormDeleteFollowUp : DevExpress.XtraEditors.XtraForm
    {
        private int resultDelete = -1;

        public FormDeleteFollowUp(string resultFollowUp)
        {
            InitializeComponent();
            configForm(resultFollowUp);
        }
        public void configForm(string resultFollowUp)
        {
            if (resultFollowUp == "تـخــريــج")
            {
                BTN_Delete.Visible = false;
                BTN_Close.Size = new Size(460, 52);
                BTN_Close.Location = new Point(140, 197);
                BTN_Delete_DelFollowUp.Text = "حذف والغاء التخريج";
            }
            LBL_Result.Text = resultFollowUp;
        }
        public int getResult()
        {
            return resultDelete;
        }
        public void setResult(int result)
        {
            this.resultDelete = result;
            this.Close();
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            setResult(1);
        }

        private void BTN_Delete_DelFollowUp_Click(object sender, EventArgs e)
        {
            setResult(2);
        }
    }
}