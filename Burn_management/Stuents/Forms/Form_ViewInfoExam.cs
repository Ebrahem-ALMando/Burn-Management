using DevExpress.XtraEditors;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burn_management.Stuents.Forms
{
    public partial class Form_ViewInfoExam : DevExpress.XtraEditors.XtraForm
    {
        public Form_ViewInfoExam()
        {
            InitializeComponent();
        }
        public Form_ViewInfoExam(string nameEx,string gradeEx,string gradeStu)
        {
            InitializeComponent();
           
            loadData(nameEx, gradeEx, gradeStu);
        }
        private void loadData(string nameEx, string gradeEx, string gradeStu)
        {
            LBL_NameExam.Text = nameEx;
            LBL_NameStudent.Text = Cls_UsersDB.nameUser;
            TX_GradeEX.Text = gradeEx;
            TX_GradeSTU.Text = gradeStu;
            var gradeState = Convert.ToSingle(gradeStu) >= (Convert.ToSingle(gradeEx) * 0.6);
            if (gradeState)
            {
                PIBOIMAGE.Image = Resources.happy_120px;
                PIIMAGEHAPPY.Visible = true;
            }
            else
            {
                PIBOIMAGE.Image = Resources.sad_120px;
                PIBOIMAGE.Location = new Point(340, 246);
                PIIMAGEHAPPY.Visible = false;
            }
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form_GetExam().ShowDialog();
        }
    }
}