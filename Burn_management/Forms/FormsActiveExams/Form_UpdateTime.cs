using DevExpress.XtraEditors;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Burn_management.Properties;
using Burn_management.Classes.Connection.ActiveExamsProcess;
using Burn_management.Classes.Connection.ExamProcess;

namespace Burn_management.Forms.FormsActiveExams
{
    public partial class Form_UpdateTime : DevExpress.XtraEditors.XtraForm
    {
        private int id;
        private Form formMain;
        Cls_ActiveExamsDB action = new Cls_ActiveExamsDB();
        public Form_UpdateTime(int id,string name ,string time,Form formMain)
        {
            InitializeComponent();
            this.id = id;
            this.formMain=formMain;
            loadData(name,time);
        }
        private void loadData( string name, string time)
        {
            TX_Form.Text = name;
            TX_TimePeriod.Text = time;
        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.InformationOptions.Icon = null;
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void updateData()
        {
            try
            {
                if (Cls_UsersDB.idUser == 0 ||
                     TX_TimePeriod.Text == "")
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateTimeActiveExam(id, TX_TimePeriod.Text);
                    /*    MessageBox.Show(Cls_ExamDB.isUpdateTime.ToString());*/
                        Cls_ExamDB.isUpdateTime=true;
                    /*    MessageBox.Show(Cls_ExamDB.isUpdateTime.ToString()+"asd");
                        Cls_ExamDB.newTime = TX_TimePeriod.Text;*/
                       
                         showSuccessUpdateMessageData();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_User ", "خطأ");
            }
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void TX_TimePeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
    }
}