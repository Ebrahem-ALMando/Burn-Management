using DevExpress.XtraEditors;
using Burn_management.Classes;
using Burn_management.Classes.Connection.ActiveExamsProcess;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.CoursesProcess;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.GradeProccess;
using Burn_management.Classes.Connection.UsersProcess;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Burn_management.Stuents.Forms
{
    public partial class Form_GetExam : DevExpress.XtraEditors.XtraForm
    {
        Cls_BranchDB branchDB = new Cls_BranchDB();
        Cls_CoursesDB coursesDB=new Cls_CoursesDB();
        Cls_ExamDB examDB = new Cls_ExamDB();
        Cls_ActiveExamsDB activeExamsDB = new Cls_ActiveExamsDB();
        Cls_GradeDB gradeDB = new Cls_GradeDB();
        Form_ViewExam viewExam;
        private int idForm =0;
        private int idExam;
        private int idActiveExam;
        private string nameExam;
        private string time;
        private string quCount;
        private string password;
        private int studentAccessCount;
        private string gradeEX;

        public Form_GetExam()
        {
            InitializeComponent();
            loadData();
            loadYearOfCompo();
            loadDataToDGVForms();


        }
        private void getDataFromDGV()
        {
            if (dataGridViewActiveExams.CurrentRow != null)
            {
                idExam = Convert.ToInt32(dataGridViewActiveExams.CurrentRow.Cells[0].Value);
                idActiveExam = Convert.ToInt32(dataGridViewActiveExams.CurrentRow.Cells[11].Value);
                nameExam = dataGridViewActiveExams.CurrentRow.Cells[1].Value.ToString();
                time = dataGridViewActiveExams.CurrentRow.Cells[3].Value.ToString();
                password = dataGridViewActiveExams.CurrentRow.Cells[4].Value.ToString();
              /*  studentAccessCount= Convert.ToInt32(dataGridViewActiveExams.CurrentRow.Cells[5].Value.ToString());*/
                quCount = dataGridViewActiveExams.CurrentRow.Cells[9].Value.ToString();
                gradeEX= dataGridViewActiveExams.CurrentRow.Cells[2].Value.ToString();

            }
        }
        private void loadDataToDGVForms()
        {
            dataGridViewActiveExams.DataSource = examDB.getDataActiveExamFromToStudents(idForm);
            dataGridViewActiveExams.Columns[4].Visible = false;
            dataGridViewActiveExams.Columns[5].Visible = false;
            dataGridViewActiveExams.Columns[6].Visible = false;
            dataGridViewActiveExams.Columns[7].Visible = false;
            dataGridViewActiveExams.Columns[8].Visible = false;
            dataGridViewActiveExams.Columns[9].Visible = false;
            dataGridViewActiveExams.Columns[10].Visible = false;
            dataGridViewActiveExams.Columns[11].Visible = false;
        }
        private void loaddIdForm()
        {
            if (COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1 && COMP_YearNumberExam.SelectedIndex != -1)
            {
                if (Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
               , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows.Count) > 0)
                {
                    idForm = Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                   , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows[0][0]);
                }
                else
                {

                    idForm = 0;
                }
            }
            else
            {
                idForm = 0;
            }
        }
        private void loadData()
        {

            LBL_NameUser.Text += Cls_UsersDB.nameUser ?? "Gust";
        }
        private void loadCourse()
        {
            if (COMP_Year.Text !="")
            {
                COMP_Course.Text = "";
                COMP_Course.DataSource = coursesDB.getDataCourseForGetExamGUI(Cls_UsersDB.idBranch, COMP_Year.Text.ToString());
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
        private void loadYearNumberExam()
        {
            COMP_YearNumberExam.Text = "";
            COMP_YearNumberExam.Enabled = false;
            if (COMP_Year.Text != ""&&COMP_Season.Text!=""&&COMP_Course.SelectedIndex!=-1)
            {
                COMP_YearNumberExam.Enabled = true;
                COMP_YearNumberExam.DataSource = examDB.getDtatYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                , COMP_Season.Text, getIdCourse());
                COMP_YearNumberExam.DisplayMember = "dateYear";
                COMP_YearNumberExam.ValueMember = "id";
            }
         
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

        
        private void loadExamsToView()
        {
         
            if (COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1&&COMP_YearNumberExam.SelectedIndex!=-1)
            {
                if(Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
               , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows.Count) > 0)
                {
                    idForm = Convert.ToInt32(examDB.getDtatExamFromYearNumberExam(Cls_UsersDB.idBranch, COMP_Year.Text.ToString()
                   , COMP_Season.Text, getIdCourse(), COMP_YearNumberExam.Text).Rows[0][0]);
                }
                else
                {
                   
                    idForm = 0;
                }
            }
            else
            {

                ClsMessageCollections.showEmptyMessageData();
                
            }
            if (idForm!=0&&COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1 && COMP_YearNumberExam.SelectedIndex != -1)
            {
                /*  string timeDateStart, timeHourStart, timeMinutesStart;
                  DateTime currentDate = DateTime.Now;

                  timeDateStart = currentDate.ToString("yyyy-MM-dd");
                  timeHourStart = currentDate.ToString("HH");
                  timeMinutesStart = currentDate.ToString("mm");*/

                loadDataToDGVForms();
            }
            else
            {
              
            }
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            loadExamsToView();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Guna2MessageDialog message = new Guna2MessageDialog();
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.YesNo;
            message.Icon = MessageDialogIcon.Question;
            DialogResult check = message.Show("هل تريد تسجيل الخروج \n ", "خروج");
            if (check == DialogResult.Yes)
            {
                this.Close();
                Application.OpenForms["Form_Login"].Show();

            }
           
        }

        private void COMP_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDateYearAndSeason();
            loadCourse();
            loadYearNumberExam();
            loaddIdForm();
            loadDataToDGVForms();
        }

        private void COMP_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadYearNumberExam();
        }

        private void COMP_Course_TextChanged(object sender, EventArgs e)
        {
            loadYearNumberExam();
            loaddIdForm();
            loadDataToDGVForms();
        }

        private void COMP_Season_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadYearNumberExam();
            loaddIdForm();
            loadDataToDGVForms();
        }

        private void COMP_YearNumberExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadExamsToView();
        }

        private void COMP_YearNumberExam_TextChanged(object sender, EventArgs e)
        {
            loaddIdForm();
            loadDataToDGVForms();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (idForm != 0 && COMP_Year.Text != "" && COMP_Season.Text != "" && COMP_Course.SelectedIndex != -1 && COMP_YearNumberExam.SelectedIndex != -1)
            {
                if (examDB.getDataActiveExamFromToStudents(idForm).Rows.Count > 0)
                {
                    if (TX_Pass.Text == password)
                    {
                        studentAccessCount=Convert.ToInt32(activeExamsDB.getDataStudentAccessCountToExam(idActiveExam).Rows[0][0].ToString());
                        if (studentAccessCount != 0)
                        {
                            var isSubmittedExam = gradeDB.getDataCheckGradeToStudent(Cls_UsersDB.idUser, idActiveExam).Rows.Count==0;
                            if (isSubmittedExam)
                            {
                                this.Hide();
                                
                                viewExam = new Form_ViewExam(idExam, idActiveExam, nameExam, time, quCount, gradeEX);
                                activeExamsDB.insertNewRequestExam(idActiveExam);
                                viewExam.ShowDialog();
                                viewExam.Dispose();
                            }
                            else
                            {
                                ClsMessageCollections.showWarningThisExamHasBeenProvidedPreviouslytMessageData();
                            }
                       

                        }
                        else
                        {
                            ClsMessageCollections.showWarningOverFlowCountMessageData();
                        }
                     
                    }
                    else
                    {
                        ClsMessageCollections.showWarningInputvalidPasswordMessageData();

                    }

                }
                else
                {
                    ClsMessageCollections.showCheckGetExamMessageData();
                }
               
            }
            else
            {
                ClsMessageCollections.showEmptyMessageData();
            }
          
        }

        private void dataGridViewActiveExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDGV();
        }

        private void dataGridViewActiveExams_SelectionChanged(object sender, EventArgs e)
        {
            getDataFromDGV();
        }
    }
}