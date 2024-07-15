using Bunifu.UI.WinForms;
using Burn_management.Classes;
using Burn_management.Classes.Connection.BranchProcess;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.QuestionProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Burn_management.Forms.FormsQuestion
{
    public partial class Form_AddQuestion : DevExpress.XtraEditors.XtraForm
    {
        Cls_BranchDB branchDB = new Cls_BranchDB();
        Cls_ExamDB examDB = new Cls_ExamDB();
        Cls_QuestionDB action= new Cls_QuestionDB();
        private bool checkAnswer_1;
        private bool checkAnswer_2;
        private bool checkAnswer_3;
        private bool checkAnswer_4;
        int numAnswer;
        private int countAnswer = 0;
        private int lastSelect;
        private int id=0;
        private bool isClose;
        private Form formMain;

        public Form_AddQuestion(Form form)
        {
            InitializeComponent();
            this.formMain = form;
            loadYearOfCompo();
            COMP_TypeQuestion.SelectedIndex = 0;
            COMP_Answer_TrueFalse.SelectedIndex = 0;
            loadTypeAnswer();
            setGradeQuestion();
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
        private void loadExams()
        {
            COMP_Exams.Text = "";
            COMP_Exams.DataSource = examDB.getDataExamsToAddQuestionFilterByYear(Cls_UsersDB.idUser, COMP_Year.Text.ToString());
            COMP_Exams.DisplayMember = "اسم النموذج";
            COMP_Exams.ValueMember = "المعرف";
        }
        private void loadTypeAnswer()
        {
            if(COMP_TypeQuestion.SelectedIndex == 0)
            {
                PAN_AnswerTrueFalse.Visible = false;
                PAN_AnswerTrueFalse.SendToBack();
                PAN_AnswerCheck.Visible = true;
                PAN_AnswerCheck.BringToFront();

            }
            else
            {
                PAN_AnswerCheck.Visible = false;
                PAN_AnswerCheck.SendToBack();
                PAN_AnswerTrueFalse.Visible = true;
                PAN_AnswerTrueFalse.BringToFront();
                
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
        private void clearData()
        {
            if (COMP_TypeQuestion.SelectedIndex == 0)
            {
                TX_Answer_1.Clear();
                TX_Answer_2.Clear();
                TX_Answer_3.Clear();
                TX_Answer_4.Clear();
                RAD_Answer_1.Checked = false;
                RAD_Answer_2.Checked = false;
                RAD_Answer_3.Checked = false;
                RAD_Answer_4.Checked = false;
            }
            else
            {

            }


        }
        private void loadCheckAnswer()
        {
            checkAnswer_1 = RAD_Answer_1.Checked;
            checkAnswer_2 = RAD_Answer_2.Checked;
            checkAnswer_3 = RAD_Answer_3.Checked;
            checkAnswer_4 = RAD_Answer_4.Checked;
        }
        private void disableTXAnswer()
        {
            if (COMP_TypeQuestion.SelectedIndex == 0)
            {

              TX_Answer_1.Enabled=false;
              TX_Answer_2.Enabled = false;
              TX_Answer_3.Enabled=false;
              TX_Answer_4.Enabled=false;
              RAD_Answer_1.Enabled = false;
              RAD_Answer_2.Enabled = false;
              RAD_Answer_3.Enabled = false;
              RAD_Answer_4.Enabled = false;


            }
        }
        private void enableTXAnswer()
        {
            TX_Answer_1.Clear();
            TX_Answer_2.Clear();
            TX_Answer_3.Clear();
            TX_Answer_4.Clear();
            RAD_Answer_1.Checked = false;
            RAD_Answer_2.Checked = false;
            RAD_Answer_3.Checked = false;
            RAD_Answer_4.Checked = false;
            TX_Answer_1.Enabled = true;
            TX_Answer_2.Enabled = true;
            TX_Answer_3.Enabled = true;
            TX_Answer_4.Enabled = true;
            RAD_Answer_1.Enabled =true;
            RAD_Answer_2.Enabled =true;
            RAD_Answer_3.Enabled =true;
            RAD_Answer_4.Enabled =true;


           
        }
        private void loadDataFromDGV()
        {
            clearData();
            if (COMP_TypeQuestion.SelectedIndex == 0)
            {
                if(dataGridViewQuestionsDetails.CurrentRow != null)
                {
                     numAnswer = Convert.ToInt32(dataGridViewQuestionsDetails.CurrentRow.Cells[0].Value);
                     var textAnswer = dataGridViewQuestionsDetails.CurrentRow.Cells[2].Value.ToString();
                    if (numAnswer == 1)
                    {
                        disableTXAnswer();
                        RAD_Answer_1.Enabled = true;
                        RAD_Answer_1.Checked = checkAnswer_1;
                        TX_Answer_1.Enabled = true;
                        TX_Answer_1.Text = textAnswer;
                    }
                    else if (numAnswer == 2)
                    {
                        disableTXAnswer();
                        RAD_Answer_2.Enabled = true;
                        RAD_Answer_2.Checked = checkAnswer_2;
                        TX_Answer_2.Enabled = true;
                        TX_Answer_2.Text = textAnswer;
                    }
                    else if (numAnswer == 3)
                    {
                        disableTXAnswer();
                        RAD_Answer_3.Enabled = true;
                        RAD_Answer_3.Checked = checkAnswer_3;
                        TX_Answer_3.Enabled = true;
                        TX_Answer_3.Text = textAnswer;
                    }
                    else if (numAnswer == 4)
                    {
                        disableTXAnswer();
                        RAD_Answer_4.Enabled = true;
                        RAD_Answer_4.Checked = checkAnswer_4;
                        TX_Answer_4.Enabled = true;
                        TX_Answer_4.Text = textAnswer;
                    }
                }
             
               
            }
            else
            {

            }
        }
        private void checkChangetTrueAnswer(bool val)
        {
            if (val)
            {
                foreach (DataGridViewRow row in dataGridViewQuestionsDetails.Rows)
                {
                    row.Cells[3].Value = false;

                }
            }
        }
        private void showSuccessAddMessageData()
        {
            MessageShow.Show(this, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void showSuccessAddMessageData(Form form)
        {
            MessageShow.Show(form, Resources.SuccessAddData, BunifuSnackbar.MessageTypes.Success, 3000, "", BunifuSnackbar.Positions.TopRight);
        }
        private void showSuccessUpdateMessageData()
        {
            MessageShow.InformationOptions.Icon = null;
            MessageShow.Show(this, Resources.SuccessUpdateData, BunifuSnackbar.MessageTypes.Information, 3000, "", BunifuSnackbar.Positions.TopRight);

        }

        private void saveData()
        {
            if (id != 0)
            {
                /*updateData();*/
            }
            else
            {
                addData();
            }
        }
        private void clearField()
        {
            
            
            COMP_TypeQuestion.SelectedIndex = 0;
            RIT_QuestionText.Clear();
            if (dataGridViewQuestionsDetails.Rows.Count > 0)
            {
                dataGridViewQuestionsDetails.Rows.Clear();
                enableTXAnswer();
                BTN_AddAnswer.Enabled = true;
                COMP_Answer_TrueFalse.SelectedIndex = 0;
            }
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
        private int getIDCurrentQuestion()
        {
            if(action.getIDQuestionToAddAnswer().Rows.Count > 0)
            {
                return Convert.ToInt32(action.getIDQuestionToAddAnswer().Rows[0][0]);
            }
            else
            {
                return -1;
            }
            
        }
        private void addData()
        {
            try
            {
                if (COMP_Year.SelectedIndex==-1||dataGridViewQuestionsDetails.Rows.Count==0
                    || COMP_Exams.SelectedIndex == -1 || RIT_QuestionText.Text == "" || TX_MarkQuestion.Text == ""
                    )
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
                else
                {
                    if (ClsMessageCollections.showQuitionAddMessageData() == DialogResult.OK)
                    {
                  
                        action.insertQuestion(Cls_UsersDB.idUser, getIdExam(), RIT_QuestionText.Text,
                            COMP_TypeQuestion.Text, Convert.ToSingle(TX_MarkQuestion.Text), DateTime.Now);

                        int n = dataGridViewQuestionsDetails.Rows.Count;
                        for (int i = 0; i < n; i++)
                        {
                            string istrue = "";

                            var celIsTrue = Convert.ToBoolean(dataGridViewQuestionsDetails.Rows[i].Cells[3].Value);
                            if (celIsTrue)
                            {
                                istrue = "نعم";
                            }
                            else
                            {
                                istrue = "لا";
                            }
                            action.insertAnswer(getIDCurrentQuestion(),
                                dataGridViewQuestionsDetails.Rows[i].Cells[2].Value.ToString()
                                , istrue);

                        }

                        showSuccessAddMessageData(formMain);
                        clearField();
                        loadExams();
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

  

        private void COMP_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadExams();
            setGradeQuestion();
        }

        private void TX_MarkQuestion_TextChanged(object sender, EventArgs e)
        {
            ClsMessageCollections.checkInputTextBoxNumber(TX_MarkQuestion);
        }

        private void TX_MarkQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* ClsMessageCollections.checkInputTextBoxNumber(sender, e);*/
        }

        private void CIMP_TypeQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTypeAnswer();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_AddAnswer_Click(object sender, EventArgs e)
        {
            if (COMP_TypeQuestion.SelectedIndex == 0)
            {
                if (TX_Answer_1.Text != "" && TX_Answer_2.Text != "" && TX_Answer_3.Text != "" && TX_Answer_4.Text != ""
                    && COMP_Exams.SelectedIndex != -1 && RIT_QuestionText.Text != "" && TX_MarkQuestion.Text != ""
                    )
                {
                    if (RAD_Answer_1.Checked || RAD_Answer_2.Checked || RAD_Answer_3.Checked || RAD_Answer_4.Checked)
                    {
                        ++countAnswer;
                        dataGridViewQuestionsDetails.Rows.Add(countAnswer, COMP_Exams.Text, TX_Answer_1.Text, checkAnswer_1);
                        ++countAnswer;
                        dataGridViewQuestionsDetails.Rows.Add(countAnswer, COMP_Exams.Text, TX_Answer_2.Text, checkAnswer_2);
                        ++countAnswer;
                        dataGridViewQuestionsDetails.Rows.Add(countAnswer, COMP_Exams.Text, TX_Answer_3.Text, checkAnswer_3);
                        ++countAnswer;
                        dataGridViewQuestionsDetails.Rows.Add(countAnswer, COMP_Exams.Text, TX_Answer_4.Text, checkAnswer_4);

                        clearData();
                        BTN_AddAnswer.Enabled = false;
                        disableTXAnswer();
                        showSuccessAddMessageData();
                    }
                    else
                    {
                        ClsMessageCollections.showEmptyMessageData();
                    }

                }
                else
                {
                    ClsMessageCollections.showEmptyMessageData();
                }
            }
            else
            {
                dataGridViewQuestionsDetails.Rows.Clear();
                if (COMP_Answer_TrueFalse.SelectedIndex != -1 && COMP_Exams.SelectedIndex != -1
                    && RIT_QuestionText.Text != "" && TX_MarkQuestion.Text != "")
                {
                    dataGridViewQuestionsDetails.Rows.Add(1, COMP_Exams.Text, COMP_Answer_TrueFalse.Text,true);
                    BTN_AddAnswer.Enabled = false;
                    showSuccessAddMessageData();
                }
                else
                {
                    ClsMessageCollections.showEmptyMessageData();
                }



            }
        }
     
        private void RAD_Answer_1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RAD_Answer_2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void RAD_Answer_3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RAD_Answer_4_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridViewQuestionsDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewQuestionsDetails.Rows)
            {
                bool val =Convert.ToBoolean(row.Cells[3].Value);
                if (val)
                {

                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridViewQuestionsDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataFromDGV();
        }

        private void RAD_Answer_1_Click(object sender, EventArgs e)
        {
            loadCheckAnswer();
        }

        private void RAD_Answer_2_Click(object sender, EventArgs e)
        {
            loadCheckAnswer();
        }

        private void RAD_Answer_3_Click(object sender, EventArgs e)
        {
            loadCheckAnswer();
        }

        private void RAD_Answer_4_Click(object sender, EventArgs e)
        {
            loadCheckAnswer();
        }

        private void COMP_Answer_TrueFalse_SelectedIndexChanged(object sender, EventArgs e)
        {
        
          
        }

        private void TX_Answer_1_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void BTN_UpdateAnswer_Click(object sender, EventArgs e)
        {
            if (COMP_TypeQuestion.SelectedIndex == 0)
            {
                if (dataGridViewQuestionsDetails.CurrentRow != null && dataGridViewQuestionsDetails.Rows.Count > 1)
                {
                    if (numAnswer == 1)
                    {
                        checkChangetTrueAnswer(checkAnswer_1);
                        if (TX_Answer_1.Text != "")
                        {
                            dataGridViewQuestionsDetails.CurrentRow.Cells[2].Value = TX_Answer_1.Text;
                            dataGridViewQuestionsDetails.CurrentRow.Cells[3].Value = checkAnswer_1;
                            showSuccessUpdateMessageData();
                        }
                        else
                        {
                            ClsMessageCollections.showEmptyMessageData();
                        }


                    }
                    else if (numAnswer == 2)
                    {
                        if (TX_Answer_2.Text != "")
                        {
                            checkChangetTrueAnswer(checkAnswer_2);
                            dataGridViewQuestionsDetails.CurrentRow.Cells[2].Value = TX_Answer_2.Text;
                            dataGridViewQuestionsDetails.CurrentRow.Cells[3].Value = checkAnswer_2;
                            showSuccessUpdateMessageData();
                        }
                        else
                        {
                            ClsMessageCollections.showEmptyMessageData();
                        }

                    }
                    else if (numAnswer == 3)
                    {
                        if (TX_Answer_3.Text != "")
                        {
                            checkChangetTrueAnswer(checkAnswer_3);
                            dataGridViewQuestionsDetails.CurrentRow.Cells[2].Value = TX_Answer_3.Text;
                            dataGridViewQuestionsDetails.CurrentRow.Cells[3].Value = checkAnswer_3;
                            showSuccessUpdateMessageData();
                        }
                        else
                        {
                            ClsMessageCollections.showEmptyMessageData();
                        }

                    }
                    else if (numAnswer == 4)
                    {
                        if (TX_Answer_4.Text != "")
                        {
                            checkChangetTrueAnswer(checkAnswer_4);
                            dataGridViewQuestionsDetails.CurrentRow.Cells[2].Value = TX_Answer_4.Text;
                            dataGridViewQuestionsDetails.CurrentRow.Cells[3].Value = checkAnswer_4;
                            showSuccessUpdateMessageData();
                        }
                        else
                        {
                            ClsMessageCollections.showEmptyMessageData();
                        }
                    }
                }
            }
            else
            {
                if(dataGridViewQuestionsDetails.CurrentRow != null&&dataGridViewQuestionsDetails.Rows.Count==1)
                {
                    dataGridViewQuestionsDetails.CurrentRow.Cells[2].Value = COMP_Answer_TrueFalse.Text;
                    showSuccessUpdateMessageData();
                }
            }

        }

        private void COMP_TypeQuestion_Click(object sender, EventArgs e)
        {
            lastSelect = COMP_TypeQuestion.SelectedIndex;
        }

        private void BTB_DeleteLastAnser_Click(object sender, EventArgs e)
        {
            if (dataGridViewQuestionsDetails.Rows.Count > 0)
            {
                if (ClsMessageCollections.showWarningClrearAnswerMessageData() == DialogResult.OK)
                {

                    dataGridViewQuestionsDetails.Rows.Clear();
                    enableTXAnswer();
                    BTN_AddAnswer.Enabled = true;
                    COMP_Answer_TrueFalse.SelectedIndex = 0;
                }
                else
                {

                }
            }
            else
            {

            } 
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

        private void COMP_Exams_SelectedIndexChanged(object sender, EventArgs e)
        {
            setGradeQuestion();
        }

        private void COMP_Exams_TextChanged(object sender, EventArgs e)
        {
            setGradeQuestion();
        }
    }
}