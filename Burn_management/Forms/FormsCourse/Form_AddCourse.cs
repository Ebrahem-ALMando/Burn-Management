using Bunifu.UI.WinForms;
using DevExpress.XtraEditors;
using Burn_management.Classes;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.CoursesProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Burn_management.Forms.FormsCourse
{
    public partial class Form_AddCourse : DevExpress.XtraEditors.XtraForm
    {
        Form formMain;
        private bool isClose;
        private int id = 0;
        Cls_BranchDB branchDB=new Cls_BranchDB();
        Cls_CoursesDB action=new Cls_CoursesDB();
        public Form_AddCourse(Form form)
        {
            InitializeComponent();
            this.formMain = form;
            TX_NameCourse.Select();
            loadYearOfCompo();
        }
        public Form_AddCourse(Form form,int id, string name, string yearName, string season, string note)
        {
            InitializeComponent();
            this.formMain = form;
            loadYearOfCompo();
            this.id = id;
            loadData(name, yearName, season, note);
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
        private void chickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BTN_AddClose.PerformClick();
            }
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
        public void loadYearOfCompo ()
        {
            var yearCount = getYearCountOfBranchUser();
            if(yearCount == 2)
            {
                COMP_Year.Items.Clear();
                COMP_Year.Items.AddRange(new object[] { "السنة الأولى","السنة الثانية" });
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
        private void addData()
        {
            try
            {
                if (Cls_UsersDB.idUser==0|| TX_NameCourse.Text == "" || COMP_Year.Text == "" || COMP_Season.Text == "")
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertCourse(Cls_UsersDB.idUser,Cls_UsersDB.idBranch,
                            TX_NameCourse.Text,COMP_Year.Text
                            ,COMP_Season.Text, RIT_NoteCourse.Text, DateTime.Now);
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
        private void loadData(string name, string yearName, string season , string note)
        {
            TX_NameCourse.Text = name;
            COMP_Year.Text = yearName;
            COMP_Season.Text = season;
            RIT_NoteCourse.Text = note;
            this.Text = "تعديل مادة";
        }
        private void updateData()
        {
            try
            {
                if (Cls_UsersDB.idUser == 0 || TX_NameCourse.Text == "" || COMP_Year.Text == "" || COMP_Season.Text == "")
                {

                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateCourse(id, Cls_UsersDB.idBranch,
                              TX_NameCourse.Text, COMP_Year.Text
                              , COMP_Season.Text, RIT_NoteCourse.Text);
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
        private void clearField()
        {
            TX_NameCourse.Clear();
            COMP_Season.SelectedIndex = 0;
            COMP_Year.SelectedIndex = 0;
            RIT_NoteCourse.Clear();
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
        private void TX_NameCourse_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
        private void RIT_NoteCourse_KeyDown(object sender, KeyEventArgs e)
        {
            chickEnter(sender, e);
        }
    }
}