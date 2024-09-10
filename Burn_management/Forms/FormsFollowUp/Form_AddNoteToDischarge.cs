using System;

namespace Burn_management.Forms.FormsFollowUp
{
    public partial class Form_AddNoteToDischarge : DevExpress.XtraEditors.XtraForm
    {
        private string _note;
       
        public Form_AddNoteToDischarge()
        {
            InitializeComponent();
            RTX_Note.Select();
        }
        public string getNote()
        {
            return _note;
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            _note = "";
            this.Close();
        }

        private void BTN_Add_Close_Click(object sender, EventArgs e)
        {
            _note = RTX_Note.Text;
            this.Close();
        }
    }
}