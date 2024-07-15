using Bunifu.UI.WinForms;
using DevExpress.XtraEditors;
using Burn_management.Classes;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;

namespace Burn_management.Forms.FormsUser
{
    public partial class Form__AddUsers : DevExpress.XtraEditors.XtraForm
    {
       
        private string lastUserName;
        private int id;
        Form formMain;
        
        private bool isClose;
        Cls_UsersDB action = new Cls_UsersDB();
        public Form__AddUsers(Form formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.Text = "إضافة مستخدم";
        }
        public Form__AddUsers(Form formMain, int id,string name,string age,string phone,string
            address,string userName,string password,string typeUser)
        {
            InitializeComponent();
            this.id = id;
            loadData(name, age, phone, address, userName, password, typeUser);
            this.formMain = formMain;

        }
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void loadData( string name, string age, string phone, string
            locition, string userName, string password, string typeUser)
        {
            TX_Name_User.Text = name;
            TX_Age.Text = age;
            TX_Phone_User.Text = phone;
            TX_Address_User.Text = locition;
            TX_UserName.Text = userName;
            lastUserName = userName;
            TX_Password.Text = password;
            COMP_TypeUser.Text = typeUser.Trim();
            checkUserName(TX_UserName.Text);
            this.Text = "تعديل مستخدم";
        }
        private void clearField()
        {
            TX_Name_User.Clear();
            TX_Age.Clear();
            TX_Phone_User.Clear();
            TX_Address_User.Clear();
            TX_UserName.Clear();
            TX_Password.Clear();
            COMP_TypeUser.SelectedIndex = 0;
            lastUserName = "";
        }
        private bool checkUserName(string userN)
        {
            if (lastUserName == TX_UserName.Text && TX_UserName.Text != "" && TX_UserName.Text.Length >= 5)
            {
                pictureBox_CheckUserName.Visible = true;
                pictureBox_CheckUserName.Image = Properties.Resources.icons8_Checkmark_32px_1;
                label7.Visible = false;
                return true;
            }
            else
            {
                if (TX_UserName.Text != "" && TX_UserName.Text.Length >= 5)
                {
                    if (action.getDataCheckUserName(userN).Rows.Count == 0)
                    {
                        pictureBox_CheckUserName.Visible = true;
                        pictureBox_CheckUserName.Image = Properties.Resources.icons8_Checkmark_32px_1;
                        label7.Visible = false;
                        return true;
                    }
                    else
                    {
                        pictureBox_CheckUserName.Visible = true;
                        pictureBox_CheckUserName.Image = Properties.Resources.icons8_cancel_32px_2;
                        label7.Visible = true;
                        return false;
                    }
                }
                else
                {
                    pictureBox_CheckUserName.Visible = false;
                    label7.Visible = false;
                    return false;

                }
            }

        }
        private bool checkPassword()
        {

            if (TX_Password.Text != "" && TX_Password.Text.Length >= 8)
            {

                pictureBoxCheckPassword.Visible = true;
                pictureBoxCheckPassword.Image = Properties.Resources.icons8_Checkmark_32px_1;
                label10.Visible = false;
                return true;

            }
            else if (TX_Password.Text != "")
            {
                pictureBoxCheckPassword.Visible = true;
                pictureBoxCheckPassword.Image = Properties.Resources.icons8_cancel_32px_2;
                label10.Visible = true;
                return false;
            }
            else
            {
                pictureBoxCheckPassword.Visible = false;
                label10.Visible = false;
                return false;

            }
        }
        private void addData()
        {
            try
            {
                if (TX_Name_User.Text == "" ||TX_Age.Text==""|| TX_Address_User.Text == "" || TX_Phone_User.Text == ""
                   || !checkPassword() || !checkUserName(TX_UserName.Text) || COMP_TypeUser.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertUser(TX_Name_User.Text,TX_Age.Text, TX_Phone_User.Text, TX_Address_User.Text,
                            TX_UserName.Text, TX_Password.Text, COMP_TypeUser.Text, DateTime.Now);
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
                
                if (TX_Name_User.Text == "" || TX_Age.Text == "" || TX_Address_User.Text == "" || TX_Phone_User.Text == ""
                || !checkPassword() || !checkUserName(TX_UserName.Text) || COMP_TypeUser.Text == "")
                {
                  ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        
                         action.updateUser(id,TX_Name_User.Text, TX_Age.Text, TX_Phone_User.Text, TX_Address_User.Text,
                         TX_UserName.Text, TX_Password.Text, COMP_TypeUser.Text);
                         lastUserName = TX_UserName.Text;
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
        private void chickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_AddClose.PerformClick();
            }
        }

        private void TX_UserName_TextChanged_1(object sender, EventArgs e)
        {
            checkUserName(TX_UserName.Text);
        }

        private void TX_Password_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            isClose = false;
            saveData();
        }

        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            isClose = true;
            saveData();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TX_Phone_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void TX_Name_User_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void COMP_Branchs_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_Phone_User_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_Address_User_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_Password_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }

        private void TX_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void TX_Age_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
    }
}