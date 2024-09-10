using Bunifu.UI.WinForms;
using Burn_management.Classes.Connection.PatientProcess;
using Burn_management.Properties;
using System;
using System.Windows.Forms;
using ClsMessageCollections = Burn_management.Classes.ClsMessageCollections;
using Burn_management.Classes.Connection.UsersProcess;

namespace Burn_management.Forms.FormsPatient
{
    public partial class Form_AddPatients : DevExpress.XtraEditors.XtraForm
    {
        #region Var
        private int id=0;
        private bool isClose;
        private Form formMain;
        Cls_PatientsDB action = new Cls_PatientsDB();
        private string isReferral="لا";
        #endregion
        public Form_AddPatients(Form formMain)
        {
            InitializeComponent();
            loadInitConfig(formMain);

        }
        public Form_AddPatients(Form formMain, int id ,string name, string age,string gender,
            string address,string phone, string isReferral, string note)
        {
            InitializeComponent();
            loadData(formMain, id, name, age, gender, address, phone, isReferral, note);
        }
        #region Method

        private void loadInitConfig(Form formMain)
        {
            this.formMain = formMain;
            TX_NamePatient.Select();
            RB_No.Checked = true;
            this.Text = "اضافة مريض";
        }
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.InformationOptions.Icon = null;
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void loadData(Form formMain, int id, string name, string age, string gender,
            string address, string phone, string isReferral, string note)
        {
            this.id = id;
            TX_NamePatient.Text = name;
            TX_AgePatient.Text = age;
            COMP_GenderPatient.Text = gender;
            TX_Address.Text = address;
            TX_Phone.Text = phone;
            RB_Yes.Checked = isReferral == "نعم";
            RB_No.Checked= isReferral == "لا";
            RIT_NotePatient.Text = note;
            this.Text = "تعديل مريض";
            this.formMain = formMain;
            TX_NamePatient.Select();
        }
        private void chickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_AddClose.PerformClick();
            }
        }
        private void clearField()
        {
            TX_NamePatient.Clear();
            TX_AgePatient.Clear();
            TX_Address.Clear();
            COMP_GenderPatient.SelectedIndex = -1;
            TX_Phone.Clear();
            RIT_NotePatient.Clear();
            RB_No.Checked = true;
        }
        private void addData()
        {
            try
            {
                if (TX_NamePatient.Text == "" || TX_AgePatient.Text == "" || TX_Address.Text == ""|| COMP_GenderPatient.SelectedIndex==-1||
                    TX_Phone.Text==""||(!RB_Yes.Checked&&!RB_No.Checked))
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertPatients(Cls_UsersDB.idUser,TX_NamePatient.Text, TX_AgePatient.Text, COMP_GenderPatient.Text,
                                TX_Address.Text,TX_Phone.Text,isReferral,RIT_NotePatient.Text, DateTime.Now);
                        showSuccessAddMessageData();
                        clearField();
                        if (isClose)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_User ", "خطأ");
            }
        }
        private void updateData()
        {
            try
            {
                if (TX_NamePatient.Text == "" || TX_AgePatient.Text == "" || TX_Address.Text == "" || COMP_GenderPatient.SelectedIndex == -1 ||
                     TX_Phone.Text == "" || (!RB_Yes.Checked && !RB_No.Checked))
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updatePatient(id, TX_NamePatient.Text, TX_AgePatient.Text, COMP_GenderPatient.Text,
                                TX_Address.Text, TX_Phone.Text, isReferral, RIT_NotePatient.Text);

                        showSuccessUpdateMessageData();
                        if (isClose)
                        {
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:185-FA_User ", "خطأ");
            }
        }
        private void saveData()
        {
            if (id != 0)
            {
                updateData();
            }
            else
            {
                addData();
            }
        }
        #endregion
        #region Event
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TX_NamePatient_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void TX_AgePatient_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);

        }
        private void TX_Address_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);

        }
        private void RIT_NotePatient_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);

        }
        private void TX_AgePatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void TX_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
        private void TX_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void RB_Yes_CheckedChanged(object sender, EventArgs e)
        {
            isReferral = "نعم";

        }
        private void RB_No_CheckedChanged(object sender, EventArgs e)
        {
            isReferral = "لا";
        }
        private void BTN_Add_Click_1(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }
        private void BTN_AddClose_Click_1(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }
        #endregion
    }
}