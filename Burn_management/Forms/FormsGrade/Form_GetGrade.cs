using DevExpress.XtraEditors;
using Burn_management.Classes;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.CoursesProcess;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.UsersProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Burn_management.Forms.FormsGrade
{
    public partial class Form_GetGrade : DevExpress.XtraEditors.XtraForm
    {
        Cls_BranchDB branchDB = new Cls_BranchDB();
        Cls_CoursesDB coursesDB=new Cls_CoursesDB();
        Cls_ExamDB examDB=new Cls_ExamDB();
        private int idForm;
        private string nameExam;
        private Form formMain;

        public Form_GetGrade(Form form)
        {
            InitializeComponent();
            this.formMain = form;
            loadYearOfCompo();
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

        private void COMP_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDateYearAndSeason();
            loadYearNumberExam();
            loadCourse();
            loadInfoForm();
        }
        private void loadCourse()
        {
            if (COMP_Year.Text != "")
            {
                COMP_Course.Text = "";
                COMP_Course.DataSource = coursesDB.getDataCourseFromIdTeacher(Cls_UsersDB.idUser, COMP_Year.Text.ToString());
                COMP_Course.DisplayMember = "name";
                COMP_Course.ValueMember = "id";
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
        private void loadInfoForm()
        {
            if (COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1 && COMP_YearNumberExam.SelectedIndex != -1)
            {
                if (Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
               , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows.Count) > 0)
                {
                    idForm = Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                   , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows[0][0]);
                    nameExam = examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                  , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows[0][1].ToString();
                    TX_NameEX.Text = nameExam;
                }
                else
                {

                    idForm = 0;
                    nameExam = "";
                    TX_NameEX.Clear();
                }
            }
            else
            {
                idForm = 0;
                nameExam = "";
                TX_NameEX.Clear();
            }
        }
        private void loadYearNumberExam()
        {
            COMP_YearNumberExam.Text = "";
            COMP_YearNumberExam.Enabled = false;
            if (COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1)
            {
                COMP_YearNumberExam.Enabled = true;
                COMP_YearNumberExam.DataSource = examDB.getDtatYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                , COMP_Season.Text, getIdCourse());
                COMP_YearNumberExam.DisplayMember = "dateYear";
                COMP_YearNumberExam.ValueMember = "id";
            }

        }
        private void loadExamsToView()
        {

            if (COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1 && COMP_YearNumberExam.SelectedIndex != -1)
            {
                if (Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
               , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows.Count) > 0)
                {
                    idForm = Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                   , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows[0][0]);
                    nameExam= examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                   , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows[0][1].ToString();
                }
                else
                {

                    idForm = 0;
                    nameExam = "";
                }
            }
            else
            {

                /*ClsMessageCollections.showEmptyMessageData();*/

            }
            if (nameExam !=""&& idForm != 0 && COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1 && COMP_YearNumberExam.SelectedIndex != -1)
            {

                TX_NameEX.Text = nameExam;


            }
            else
            {
                TX_NameEX.Clear();
            }
        }

        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            loadExamsToView();
            if (nameExam != "" && idForm != 0 && COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1 && COMP_YearNumberExam.SelectedIndex != -1)
            {
                
                new Form_ViewGrade(formMain, idForm, COMP_Year.Text, COMP_Season.Text, COMP_Course.Text, TX_NameEX.Text, COMP_YearNumberExam.Text).ShowDialog();


            }
              else
            {

                ClsMessageCollections.showEmptyMessageData();

            }
    
         
          
        }

        private void COMP_YearNumberExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInfoForm();
        }

       

        private void COMP_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadYearNumberExam();
            loadInfoForm();
        }

        private void COMP_Season_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadYearNumberExam();
            loadInfoForm();
        }

        private void COMP_YearNumberExam_TextChanged(object sender, EventArgs e)
        {
            loadInfoForm();
        }
    }
}