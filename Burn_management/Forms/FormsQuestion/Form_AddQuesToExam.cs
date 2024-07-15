using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.QuestionProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using System;
using System.Windows.Forms;

namespace Burn_management.Forms.FormsQuestion
{
    public partial class Form_AddQuesToExam : DevExpress.XtraEditors.XtraForm
    {
        Cls_BranchDB branchDB = new Cls_BranchDB();
        Cls_ExamDB examDB = new Cls_ExamDB();
        Cls_QuestionDB action = new Cls_QuestionDB();
        private int idQues = 0;
   
        private Form formMain;

        public Form_AddQuesToExam(Form form ,int idQ,string typeQ)
        {
            InitializeComponent();
            loadYearOfCompo();
            loadData(form,idQ,typeQ);
            
        }

        private void loadData(Form form, int idQ, string typeQ)
        {
           this.idQues = idQ;
           COMP_TypeQuestion.Text= typeQ;
           this.formMain = form;
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
        private int getIdExam()
        {
            try
            {
                if (COMP_Exams.SelectedIndex != -1)
                {
                    int IdForm;
                    Int32.TryParse(COMP_Exams.SelectedValue.ToString(), out IdForm);
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
        private void setGradeQuestion()
        {
            if (getIdExam() != 0)
            {

                TX_MarkQuestion.Text = action.getDataCalculateQuestionMark(getIdExam()).Rows[0][0].ToString(); ;
            }
            else
            {
                TX_MarkQuestion.Clear();
            }

        }
        private void loadExams()
        {
            COMP_Exams.Text = "";
            COMP_Exams.DataSource = examDB.getDataExamsToAddQuestionFilterByYear(Cls_UsersDB.idUser, COMP_Year.Text.ToString());
            COMP_Exams.DisplayMember = "اسم النموذج";
            COMP_Exams.ValueMember = "المعرف";
        }
        private void showSuccessAddMessageData(Form formMain)
        {
            MessageShow.Show(formMain, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);

        }
        private int getIDCurrentQuestion()
        {
            if (action.getIDQuestionToAddAnswer().Rows.Count > 0)
            {
                return Convert.ToInt32(action.getIDQuestionToAddAnswer().Rows[0][0]);
            }
            else
            {
                return -1;
            }

        }
        private void COMP_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadExams();
            setGradeQuestion();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_AddClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMP_Year.SelectedIndex == -1 
                    || COMP_Exams.SelectedIndex == -1 || TX_MarkQuestion.Text == ""
                    )
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                        action.insertQuestionToExam(idQues, getIdExam(), Convert.ToSingle(TX_MarkQuestion.Text), DateTime.Now);
                        int idCurrentQuestion = getIDCurrentQuestion();
                        action.insertAnswersQuesToExam(idQues, idCurrentQuestion);
                        showSuccessAddMessageData(formMain);
                            this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Code:LI:135-FA_User ", "خطأ");
            }
        }

        private void COMP_Exams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(COMP_Exams.SelectedIndex != -1)
            {
                setGradeQuestion();
            }
         
        }
    }
}