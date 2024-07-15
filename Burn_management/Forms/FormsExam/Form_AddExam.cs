using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.CoursesProcess;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Burn_management.Forms.FormsExam
{
    public partial class Form_AddExam : DevExpress.XtraEditors.XtraForm
    {
        Form formMain;
        private bool isClose;
        private int id = 0;
        Cls_BranchDB branchDB = new Cls_BranchDB();
        Cls_ExamDB action = new Cls_ExamDB();
        Cls_CoursesDB coursesDB = new Cls_CoursesDB();
        public Form_AddExam(Form formMain)
        {
            InitializeComponent();
            this.formMain= formMain;
            loadYearOfCompo();
            GetYearNowAndNext();
            loadCourse();
        }
        public Form_AddExam(Form formMain, int id, string Branch, String year,String Season, String Course, String DateExam, String NameExam,string CountQuestion,string FinalGrade, String note)
        {
            InitializeComponent();
            this.formMain= formMain;
            this.id = id;
            loadYearOfCompo();
            loadData( Branch,  year,  Season,  Course,  DateExam,  NameExam,  CountQuestion,  FinalGrade,  note);
        }
        private void loadData(string Branch,String year, String Season, String Course,String DateExam, String NameExam, String CountQuestion, String FinalGrade, String note)
        {
           
            TX_NameExam.Text = NameExam;
            TX_Branch.Text = Branch;
            COMP_Year.Text = year;
            COMP_Season.Text = Season;
            COMP_Course.Text = Course;
            TX_DateExam.Text = DateExam;
            TX_CountQuExam.Text = CountQuestion;
            TX_FinalGradeExam.Text = FinalGrade;
            RIT_NoteExam.Text = note;
            this.Text = "تعديل نموذج";
            TX_CountQuExam.ReadOnly = Convert.ToInt32(action.getQuestionToExam(id).Rows[0][0]) != 0;
            TX_FinalGradeExam.ReadOnly = Convert.ToInt32(action.getQuestionToExam(id).Rows[0][0]) != 0;
          
        }
        private void loadCourse()
        {
            COMP_Course.Text = "";
            COMP_Course.DataSource = coursesDB.getDataCourseFromIdTeacher(Cls_UsersDB.idUser, COMP_Year.Text.ToString());
            COMP_Course.DisplayMember = "name";
            COMP_Course.ValueMember = "id";
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
        private int getIdCourse()
        {
            try
            {
                if (COMP_Course.SelectedIndex != -1)
                {
                    int idCourse;
                    Int32.TryParse(COMP_Course.SelectedValue.ToString(), out idCourse);
                    return idCourse;
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
        private void addData()
        {
            try
            {
                if (Cls_UsersDB.idUser == 0 || TX_NameExam.Text == "" || COMP_Course.SelectedIndex== -1|| TX_FinalGradeExam.Text == "" || TX_DateExam.Text == "" || TX_CountQuExam.Text == "" || COMP_Year.Text == "" || COMP_Season.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertExam(Cls_UsersDB.idUser, Cls_UsersDB.idBranch, getIdCourse()
                            , COMP_Year.Text,COMP_Season.Text, TX_DateExam.Text,TX_NameExam.Text,Int32.Parse(TX_CountQuExam.Text),Convert.ToSingle(TX_FinalGradeExam.Text),RIT_NoteExam.Text,DateTime.Now);
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
                if (Cls_UsersDB.idUser == 0 || TX_NameExam.Text == "" || COMP_Course.SelectedIndex == -1 || TX_FinalGradeExam.Text == "" || TX_DateExam.Text == "" || TX_CountQuExam.Text == "" || COMP_Year.Text == "" || COMP_Season.Text == "")
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionUpdateMessageData() == DialogResult.OK)
                    {
                        action.updateExam(id,Cls_UsersDB.idUser, Cls_UsersDB.idBranch,
                            getIdCourse(), COMP_Year.Text, COMP_Season.Text, TX_DateExam.Text, 
                            TX_NameExam.Text, Int32.Parse(TX_CountQuExam.Text), Convert.ToSingle(TX_FinalGradeExam.Text), RIT_NoteExam.Text);
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
        private void COMP_Year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshDateYearAndSeason();
            loadCourse();
        }
        private void RefreshDateYearAndSeason()
        {
            int MaxCountItems = COMP_Year.Items.Count - 1;
            if (COMP_Year.SelectedIndex == MaxCountItems)
            {
                COMP_Season.Items.Clear();
                COMP_Season.Items.AddRange(new object[] { "الفصل الأول", "الفصل الثاني", "الفصل الثالث", "الفصل الرابع" });
            }
            else
            {
                COMP_Season.Items.Clear();
                COMP_Season.Items.AddRange(new object[] { "الفصل الأول", "الفصل الثاني", "الفصل الثالث" });
            }
        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.InformationOptions.Icon = null;
            MessageShow.Show(formMain, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void clearField()
        {
            TX_NameExam.Clear();
            COMP_Season.SelectedIndex = 0;
            COMP_Year.SelectedIndex = 0;
            RIT_NoteExam.Clear();
            COMP_Course.SelectedIndex = -1;
            TX_DateExam.Clear();
            TX_FinalGradeExam.Clear();
            TX_CountQuExam.Clear();
        }
        private void GetYearNowAndNext()
        {
            int currentYear = DateTime.Now.Year;
            int nextYear = currentYear + 1;
            TX_DateExam.Text = currentYear.ToString() + " - " + nextYear.ToString();
        }
        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void COMP_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCourse();
            RefreshDateYearAndSeason();
        }

        private void TX_CountQuExam_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TX_FinalGradeExam_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TX_FinalGradeExam_TextChanged(object sender, EventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(TX_FinalGradeExam);
        }

        private void TX_CountQuExam_TextChanged(object sender, EventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(TX_CountQuExam);
        }

        private void TX_CountQuExam_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }

        private void TX_FinalGradeExam_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(sender, e);
        }
    }
}