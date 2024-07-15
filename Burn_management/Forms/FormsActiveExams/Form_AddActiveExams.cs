using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.ActiveExamsProcess;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace Burn_management.Forms.FormsActiveExams
{
    public partial class Form_AddActiveExams : DevExpress.XtraEditors.XtraForm
    {
        Cls_ExamDB examDB=new Cls_ExamDB();
        Cls_BranchDB branchDB = new Cls_BranchDB();
        Cls_ActiveExamsDB action =new Cls_ActiveExamsDB();
        Form formMain;
      
        public Form_AddActiveExams(Form formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            loadYearOfCompo();
        }
     
        private void loadFormsExams()
        {
            
            COMP_NameExam.Text = "";
            COMP_NameExam.DataSource = examDB.getDataExamsToActiveFilterByYear(Cls_UsersDB.idUser, COMP_Year.Text);
            COMP_NameExam.DisplayMember = "اسم النموذج";
            COMP_NameExam.ValueMember = "المعـرف";
        }
        public int getYearCountOfBranchUser()
        {
            try
            {
                return Convert.ToInt32(branchDB.getYearCountOfBranchUser(Cls_UsersDB.idBranch).Rows[0][0]);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public void loadYearOfCompo()
        {
            var yearCount = getYearCountOfBranchUser();
            if (yearCount == 2)
            {
                COMP_Year.Items.Clear();
                COMP_Year.Items.AddRange(new object[] { "السنة الأولى", "السنة الثانية" });
            }
            else if (yearCount == 4)
            {
                COMP_Year.Items.Clear();
                COMP_Year.Items.AddRange(new object[] { "السنة الأولى", "السنة الثانية"
                    ,"السنة الثالثة","السنة الرابعة" });
            }
            else if (yearCount == 5)
            {

                COMP_Year.Items.Clear();
                COMP_Year.Items.AddRange(new object[] { "السنة الأولى", "السنة الثانية"
                    ,"السنة الثالثة","السنة الرابعة","السنة الخامسة" });
            }
            else if (yearCount == 6)
            {
                COMP_Year.Items.Clear();
                COMP_Year.Items.AddRange(new object[] { "السنة الأولى", "السنة الثانية"
                    ,"السنة الثالثة","السنة الرابعة","السنة الخامسة","السنة السادسة" });
            }
            COMP_Year.SelectedIndex = 0;
            TX_Branch.Text = Cls_UsersDB.nameBranch;

        }
        private int getIdForm()
        {
            try
            {
                if (COMP_NameExam.SelectedIndex != -1)
                {
                    int IdForm;
                    Int32.TryParse(COMP_NameExam.SelectedValue.ToString(), out IdForm);
                    return IdForm;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CODE:LI-88-FAUS");
                return 0;
            }
        }
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void addData()
        {
            try
            {
                if (Cls_UsersDB.idUser == 0 || COMP_NameExam.SelectedIndex== -1
                    || COMP_Year.Text == "" || TX_Password.Text== ""||TX_CountStudent.Text==""||TX_TimePeriod.Text=="")
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertActiveExam(getIdForm(),TX_Password.Text,Convert.ToInt32(TX_CountStudent.Text),TX_TimePeriod.Text,CHECK_viewGrade.Checked?"نعم":"لا");

                        showSuccessAddMessageData();
                            this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_User ", "خطأ");
            }
        }
        private void COMP_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFormsExams();
        }

    

        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void TX_CountStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void TX_TimePeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);

        }

        private void TX_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2MessageDialog message = new Guna2MessageDialog();
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.OK;
            message.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
            {
                e.Handled = true;

                message.Show(" لا يمكن ان تحوي كلمة السر  " + "\n" + " محارف باللغة العربية\n   ", " تنبيه");

            }
            else
            {
                e.Handled = false;
            }

        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}