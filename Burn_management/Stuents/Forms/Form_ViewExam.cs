using Burn_management.Classes;
using Burn_management.Classes.Connection;
using Burn_management.Classes.Connection.ActiveExamsProcess;
using Burn_management.Classes.Connection.ExamProcess;
using Burn_management.Classes.Connection.GradeProccess;
using Burn_management.Classes.Connection.QuestionProcess;
using Burn_management.Classes.Connection.UsersProcess;
using Burn_management.Forms.FormsActiveExams;
using Burn_management.Stuents.Forms;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Serialization;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace Burn_management
{
    public partial class Form_ViewExam : DevExpress.XtraEditors.XtraForm
    {
        bool isSendForm=false;
        List<QuestionAnswerData> questionDataList = new List<QuestionAnswerData>();
        private float lineThickness = 3.7f; // سمك الخط
        private int lineAlpha = 190;
        Cls_QuestionDB questionDB = new Cls_QuestionDB();
        Cls_GradeDB gradeDB = new Cls_GradeDB();    
        Cls_ActiveExamsDB activeExamsDB = new Cls_ActiveExamsDB();
        QuestionAnswerData questionAnswerData = new QuestionAnswerData();
        int[] shuffledQuestionIds;
        private int idExam;
        private int idActiveExam;
        private int countQU;
        private int totalTimeInMinutes;
        private string gradeEX;
        private int remainingTimeInSeconds;
        private int numberCurrentBTNl;
        private int []idAnswer;
        private bool[] checkedAnswer=new bool[5];
        private int IDTrueAnswer;
        private string TextTrueAnswer;//False Or True
        private Button nameBTN=null;  
        int i ;
        private bool drawLine;
        private bool rightClick;
        private float valProgras = 0;
        private float finalGrade = 0;
        private float GradeCurrentQuestion = 0;
        private string typeQ;
        private bool isClickCOMP_TR_FA;
        private bool tasksCompleted = false;

        private int lastTime = 0;

        private int currentProgress = 0; // التقدم الحالي
        private int totalProgress ; // الإجمالي (عدد الأسئلة أو الأقسام الكلي)

        public Form_ViewExam()
        {
            InitializeComponent();
           
        }
        public Form_ViewExam(int idExam, int idActiveExam, string nameExam, string time, string quCount, string gradeEX)
        {
            InitializeComponent();

            SystemEvents.DisplaySettingsChanged += (sender, e) =>
            {
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                this.Location = Screen.PrimaryScreen.Bounds.Location;
            };

            loadData(idExam, idActiveExam, nameExam, time, quCount, gradeEX);
            loadQuestion();
            createBTNQu();
            remainingTimeInSeconds = totalTimeInMinutes * 60; // تحويل الوقت الإجمالي إلى ثواني
            updateTime();

            TaskbarInteraction.HideTaskbar();


            /*KeyboardInteraction.DisableWinKey();*/
        }


        private async void alertStartExam()
        {
            Form_AlertStartExam form_AlertStartExam = new Form_AlertStartExam();
            form_AlertStartExam.Show();

            await Task.Delay(5000); 

            form_AlertStartExam.Hide();
            form_AlertStartExam.Dispose(); 
        }


        private void updateTime()
        {
            int hours = remainingTimeInSeconds / 3600;
            int minutes = (remainingTimeInSeconds % 3600) / 60;
            int seconds = remainingTimeInSeconds % 60;

            LBL_Time.Text = $"{hours:00}:{minutes:00}:{seconds:00}";
            tasksCompleted = true;
        }
        private void loadData(int idExam, int idActiveExam, string nameExam, string time, string quCount, string gradeEX)
        {
            this.idExam = idExam;
            this.idActiveExam = idActiveExam;
            this.countQU =Int32.Parse(quCount);
            totalProgress =  countQU;
            Progress.Value = Convert.ToInt16(valProgras);
            this.totalTimeInMinutes = Int32.Parse(time.Replace("-دقيقة",""));
            lastTime = totalTimeInMinutes;
            this.gradeEX = gradeEX;
            LBL_NameStudent.Text=Cls_UsersDB.nameUser;
            LBL_NameExam.Text=nameExam;
            LBL_QUCount.Text= $"“{quCount}”";
            LBL_Time.Text=time;

        }
        private void loadTimeNew()
        {
            int newTime = Convert.ToInt32(activeExamsDB.getDataNewTimeToActiveExam(idActiveExam).Rows[0][0]);

            if(newTime !=lastTime) 
            {
                this.totalTimeInMinutes = newTime;
                remainingTimeInSeconds = totalTimeInMinutes * 60;
                updateTime();
                lastTime = newTime;
                ClsMessageCollections.showSuccessUpdateTimeMessageData();
               
            }
        }
        private void loadQuestion()
        {
            // قم بالحصول على DataTable الذي يحتوي على معرفات الأسئلة
            DataTable questionTable = questionDB.getDataQuestionToByIdExamToGuiExam(idExam); 

            // استخراج الأعمدة التي تحتوي على معرفات الأسئلة
            int[] questionIds = questionTable.AsEnumerable()
                                            .Select(row => row.Field<int>("المعرف"))
                                            .ToArray();

            // ترتيب المصفوفة بشكل عشوائي
            Random random = new Random();
             shuffledQuestionIds = questionIds.OrderBy(x => random.Next()).ToArray();
        }
        private void loadAnswer(int idQ, string typeQ)
        {
            idAnswer = new int[4];
            if (typeQ == "اختر الاجابة الصحيحة")
            {

                PAN_TrueFalseAnswer.Visible = false;
                PAN_TrueFalseAnswer.SendToBack();
                PAN_CheckedAnswer.Visible = true;
                PAN_CheckedAnswer.BringToFront();
                if (questionDB.getDataCurrentQuestionToGuiExam(idQ).Rows.Count > 0)
                {
                
                    BTN_Answer_1.Text = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[0][2].ToString();
                    BTN_Answer_1.Tag = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[0][3].ToString();
                    idAnswer[0] = Convert.ToInt32(questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[0][0]);

                    BTN_Answer_2.Text = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[1][2].ToString();
                    BTN_Answer_2.Tag = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[1][3].ToString();
                    idAnswer[1] = Convert.ToInt32(questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[1][0]);

                    BTN_Answer_3.Text = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[2][2].ToString();
                    BTN_Answer_3.Tag = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[2][3];
                    idAnswer[2] = Convert.ToInt32(questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[2][0]);

                    BTN_Answer_4.Text = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[3][2].ToString();
                    BTN_Answer_4.Tag = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[3][3].ToString();
                    idAnswer[3] = Convert.ToInt32(questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[3][0]);
                }
                 
            }
            else
            {
                
                PAN_CheckedAnswer.Visible = false;
                PAN_CheckedAnswer.SendToBack();
                PAN_TrueFalseAnswer.Visible = true;
                PAN_TrueFalseAnswer.BringToFront();
                if (questionDB.getDataCurrentQuestionToGuiExam(idQ).Rows.Count > 0)
                {
                    COMP_Answer_TrueFalse.Tag = questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[0][2].ToString();
                    COMP_Answer_TrueFalse.TabIndex = Convert.ToInt32(questionDB.getDataAnswerByIdQuestionToQuestion(idQ).Rows[0][0]);
                }
                  
            }
        }
        private void loadCurrentQuestion(int idQ,string numQ)
        {

            LBL_IdQuestion.Text = $"“{numQ}”";
            if (questionDB.getDataCurrentQuestionToGuiExam(idQ).Rows.Count > 0)
            {
                RI_QuestionText.Text = questionDB.getDataCurrentQuestionToGuiExam(idQ).Rows[0][1].ToString(); 
                typeQ= questionDB.getDataCurrentQuestionToGuiExam(idQ).Rows[0][2].ToString();
                loadAnswer(idQ, typeQ);
                GradeCurrentQuestion = Convert.ToSingle(questionDB.getDataCurrentQuestionToGuiExam(idQ).Rows[0][3].ToString());
            }
            
        }
        private void createBTNQu()
        {
            int buttonWidth = 80; // عرض الزر
            int buttonHeight = 46; // ارتفاع الزر
            int buttonsPerRow = 3; // عدد الأزرار في كل سطر
            int spacingX = 5; // المسافة الأفقية بين الأزرار
            int spacingY = 5; // المسافة العمودية بين الأزرار


            QuestionProgrees[] questionProgressArray = new QuestionProgrees[countQU+1];
            for (int j = 0; j <= countQU; j++)
            {
                int questionId = 0;
                int progressValue = 0;
               
                if (j != 0)
                {
                     questionId = shuffledQuestionIds[j - 1];
                     progressValue = j * (100 / countQU); 
                }
             
        

                questionProgressArray[j] = new QuestionProgrees(questionId, progressValue);
            }


            for ( i = 1; i <= countQU; i++) 
            {
               
                Button btns = new Button();
                btns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
                btns.ForeColor = System.Drawing.Color.White;

                // حساب موقع الزر باستناء العدد i
                int row = (i - 1) / buttonsPerRow;
                int col = (i - 1) % buttonsPerRow;

                int buttonX = col * (buttonWidth + spacingX);
                int buttonY = row * (buttonHeight + spacingY);

                btns.Location = new System.Drawing.Point(buttonX, buttonY);
                btns.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
                btns.Name = "BTN_Q" + i.ToString();
                btns.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                btns.TabIndex = 2;
                btns.Text = i.ToString();
                btns.UseVisualStyleBackColor = false;

                btns.Tag = shuffledQuestionIds[i - 1];


            


                PAN_QU.Controls.Add(btns);
                if (i == 1)
                {
                   
                    btns.PerformClick();
                  
                }
                btns.Click += (sender, e) =>
                {
                    
                    int questionId = (int)((Button)sender).Tag;
                    string numQ= ((Button)sender).Name.Replace("BTN_Q", "").ToString();
                    numberCurrentBTNl = Convert.ToInt32(numQ);
                    checkBTNTranslate();
                    loadCurrentQuestion(questionId, numQ);
                    IDTrueAnswer = getIDTrueAnswer();
                    nameBTN = ((Button)sender);
                    loadAnswerWithNextOrBack(questionId);
                    deleteLinesFromBTN();
                    QuestionProgrees buttonProgress = questionProgressArray.FirstOrDefault(qp => qp.QuestionNumber == questionId);
                  
                    if (buttonProgress != null)
                    {
                        Progress.Value = buttonProgress.ValProgrees;
                        LBL_Progress.Text = $"% {Progress.Value}";
                    }
                   
                 
                    /*currentProgress++;
                    Progress.Value = (int)(((double)currentProgress / totalProgress) * 100);*/
                    /* MessageBox.Show("تم النقر على الزر " + ((Button)sender).Name);*/
                    /*     nameBTN = ((Button)sender);*/
                    checkMark();
                };
               
            }
        }
        private void checkBTNTranslate()
        {
            if (numberCurrentBTNl == 1)
            {
                BTN_Back.Enabled = false;
            }
            else
            {
                BTN_Back.Enabled = true;
            }
            if (PAN_QU.Controls.Count > numberCurrentBTNl)
            {
                BTN_Next.Enabled = true;
            }
            else
            {
                BTN_Next.Enabled = false;
            }
        }
        private int getIDTrueAnswer()
        {

            var answer_1 = BTN_Answer_1.Tag.ToString() == "نعم";
            var answer_2 = BTN_Answer_2.Tag.ToString() == "نعم";
            var answer_3 = BTN_Answer_3.Tag.ToString() == "نعم";
            var answer_4 = BTN_Answer_4.Tag.ToString() == "نعم";
            if (answer_1)
            {
                return idAnswer[0];
            }
            else if (answer_2)
            {
                return idAnswer[1];
            }
            else if (answer_3)
            {
                return idAnswer[2];
            }
            else if (answer_4)
            {
                return idAnswer[3];
            }
            else
            {
                return -1;//غير صح وخطأ
            }
        }
        private void BTN_Next_Click(object sender, EventArgs e)
        {
              
                Button Button = (Button)PAN_QU.Controls[numberCurrentBTNl];
                Button.PerformClick();
            if (valProgras <= 100)
            {
         
                LBL_Progress.Text = $"{Progress.Value} %";
            }
               
        }
        private void checkMark()
        {
            if (nameBTN.Image != null)
            {

                BTN_AddMark.Text = "حذف علامة";
                BTN_AddMark.Image = Properties.Resources.icons8_Delete_Trash_50px;

            }
            else
            {
                BTN_AddMark.Text = "اضافة علامة";
                BTN_AddMark.Image = Properties.Resources.icons8_add_50px_1;

            }
        }
        private void loadAnswerWithNextOrBack(int id)
        {
            int numAnswer = questionAnswerData.getSelectedAnswer(id);
            if (PAN_CheckedAnswer.Visible)
            {
                foreach (Guna2Button menuButton in PAN_CheckedAnswer.Controls.OfType<Guna2Button>())
                {
                    if (menuButton.Tag != null)
                    {
                        int tabIndex = menuButton.TabIndex;

                        if (PAN_CheckedAnswer.Controls.Count > 1)
                        {
                            if (tabIndex >= 0 && tabIndex < idAnswer.Length)
                            {
                                int idAn = idAnswer[tabIndex];

                                if (idAn == numAnswer)
                                {
                                    menuButton.FillColor = Color.Green;
                                }
                                else
                                {
                                    menuButton.FillColor = Color.FromArgb(35, 35, 35);
                                }
                            }
                        }

                    }
                }
            }
            else if(numAnswer == -1&& !PAN_CheckedAnswer.Visible) 
            {
              
                isClickCOMP_TR_FA=false;
                string textAnswerTR_FA = questionAnswerData.getSelectedAnswer_TR_FA_state(id);
                
                if(textAnswerTR_FA == "صح")
                {
                    COMP_Answer_TrueFalse.SelectedIndex = 0;
                }else if(textAnswerTR_FA == "خطأ")
                {
                    COMP_Answer_TrueFalse.SelectedIndex=1;
                }
                else
                {
                    COMP_Answer_TrueFalse.SelectedIndex = -1;
                }
            
            }
         


            /*  List<Guna2Button> answerButtons = new List<Guna2Button>
          {
           BTN_Answer_1,
           BTN_Answer_2,
           BTN_Answer_3,
           BTN_Answer_4
          };


      for (int i = 0; i < checkedAnswer.Length && i < answerButtons.Count; i++)
      {
          answerButtons[i].FillColor = checkedAnswer[i] ? Color.Green : Color.FromArgb(35, 35, 35);
      }*/

        }


        private float getGradeForm()
        {
            foreach (QuestionAnswerData questionDataList in questionAnswerData.questionDataList)
            {
            /*    MessageBox.Show(questionDataList.CorrectAnswer.ToString()+"couurect");
                MessageBox.Show(questionDataList.SelectedAnswer.ToString()+"asd");
                MessageBox.Show(questionDataList.CorrectAnswer_TR_FA_state.ToString() + "couurectTR");
                MessageBox.Show(questionDataList.SelectedAnswer_TR_FA_state.ToString() + "asdTR");*/
                if (questionDataList.CorrectAnswer== questionDataList.SelectedAnswer&&
                    questionDataList.CorrectAnswer>0 &&questionDataList.SelectedAnswer>0)
                {
                    finalGrade += questionDataList.QuestionGrade;
                }
                if(questionDataList.CorrectAnswer_TR_FA_state == questionDataList.SelectedAnswer_TR_FA_state
                    && questionDataList.CorrectAnswer_TR_FA_state!=""&& questionDataList.SelectedAnswer_TR_FA_state!="")
                {
                    finalGrade += questionDataList.QuestionGrade;
                }
            /*    MessageBox.Show(questionDataList.QuestionGrade.ToString() + " grade");
                MessageBox.Show(finalGrade.ToString() + ":finalGrade");*/

            }
            return finalGrade;
        }
        private void deleteLinesFromBTN()
        {



            drawLine = !drawLine; // تبديل حالة رسم الخط

            if (!drawLine)
            {
                // إعادة رسم الزر لتطبيق التغييرات (بدون الخط)
                BTN_Answer_1.Invalidate();
                BTN_Answer_2.Invalidate();
                BTN_Answer_3.Invalidate();
                BTN_Answer_4.Invalidate();
            }
            else
            {
                // إعادة رسم الزر بما فيها الخط
                BTN_Answer_1.Refresh();
                BTN_Answer_2.Refresh();
                BTN_Answer_3.Refresh();
                BTN_Answer_4.Refresh();
            }
        }



        private void setCheckAnswer(bool[] answers,int indexTrueAnswer )
        {
            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = false;
            }

            foreach (Guna2Button menuButton in PAN_CheckedAnswer.Controls.OfType<Guna2Button>())
            {
                menuButton.FillColor = Color.FromArgb(35, 35, 35);
            }
            answers[indexTrueAnswer] = true;
            nameBTN.BackColor = Color.FromArgb(133, 189, 52);
           /* MessageBox.Show(questionAnswerData.compareAnswers(Convert.ToInt32(nameBTN.Tag)).ToString());*/

            
        }

        private void finchExam()
        {
            gradeDB.insertGrade(Cls_UsersDB.idUser, idExam, idActiveExam, getGradeForm());
            ClsMessageCollections.showSuccessSubmiteExamMessageData();
            isSendForm = true;
            if (activeExamsDB.getDataviewGradeActiveExamToStudent(idActiveExam).Rows[0][0].ToString() == "نعم")
            {
                this.Hide();
                new Form_ViewInfoExam(LBL_NameExam.Text, gradeEX, finalGrade.ToString()).Show();
            }
            else
            {
                this.Close();
                Application.OpenForms["Form_GetExam"].Show();
            }
            TaskbarInteraction.ShowTaskbar();
         
            
        }
        private void BTN_AddMark_Click(object sender, EventArgs e)
        {
            if (nameBTN != null)
            {
                if (nameBTN.Image != null)
                {
                    nameBTN.Image = null;
                }
                else
                {
                    nameBTN.Image = Properties.Resources.icons8_bookmark_32px;
                    nameBTN.ImageAlign = ContentAlignment.MiddleLeft;
                }
                checkMark();
            }
          

        }
     /*   private void getNewTime()
        {
            this.totalTimeInMinutes = Int32.Parse(Cls_ExamDB.newTime);
            remainingTimeInSeconds = totalTimeInMinutes * 60;
            updateTime();
        }*/
            

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (remainingTimeInSeconds > 0)
            {



                --remainingTimeInSeconds;
                 updateTime();
                loadTimeNew();
            }
            else
            {
                timer1.Stop();
                if (!isSendForm)
                {
                    finchExam();
                }
                
            }


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void Form_ViewExam_Load(object sender, EventArgs e)
        {
           
            if (PAN_QU.Controls.Count > 0)
            {
                Button firstButton = (Button)PAN_QU.Controls[0];
                firstButton.PerformClick();
            }
            await Task.Delay(1000); // انتظر لمدة ثانية واحدة
            alertStartExam();

        }
        private void BTN_Back_Click(object sender, EventArgs e)
        {
            Button Button = (Button)PAN_QU.Controls[numberCurrentBTNl-2];
            Button.PerformClick();
           /* Progress.Value -= Convert.ToInt32(valProgras);
            LBL_Progress.Text = $"{Progress.Value} %";*/

        }

        private void BTN_Answer_1_Click(object sender, EventArgs e)
        {
            questionAnswerData.storeAnswer(Convert.ToInt32(nameBTN.Tag), idAnswer[0], IDTrueAnswer, GradeCurrentQuestion);

            setCheckAnswer(checkedAnswer, 0);

            BTN_Answer_1.FillColor = Color.Green;
           
        }
        private void BTN_Answer_2_Click(object sender, EventArgs e)
        {
          
            questionAnswerData.storeAnswer(Convert.ToInt32(nameBTN.Tag), idAnswer[1], IDTrueAnswer, GradeCurrentQuestion);
            setCheckAnswer(checkedAnswer, 1);
            BTN_Answer_2.FillColor = Color.Green;
        }
        private void BTN_Answer_3_Click(object sender, EventArgs e)
        {
            questionAnswerData.storeAnswer(Convert.ToInt32(nameBTN.Tag), idAnswer[2], IDTrueAnswer, GradeCurrentQuestion);
            setCheckAnswer(checkedAnswer, 2);

            BTN_Answer_3.FillColor = Color.Green;
        }

        private void BTN_Answer_4_Click(object sender, EventArgs e)
        {
           /* if (!rightClick)
            {*/
                questionAnswerData.storeAnswer(Convert.ToInt32(nameBTN.Tag), idAnswer[3], IDTrueAnswer, GradeCurrentQuestion);
                setCheckAnswer(checkedAnswer, 3);
                BTN_Answer_4.FillColor = Color.Green;
        /*    }*/
             
        }

        private void BTN_Finish_Click(object sender, EventArgs e)
        {
            if (ClsMessageCollections.showQuitionEndExamMessageData() == DialogResult.OK)
            {
                if (!isSendForm)
                {
                    finchExam();
                }
            
            }
            
         



        }

        private void BTN_Answer_1_MouseClick(object sender, MouseEventArgs e)
        {
          /*  if (e.Button == MouseButtons.Right) // اختبار النقر بزر اليمين
            {
                Guna2Button button = (Guna2Button)sender;
                button.Paint -= BTN_Answer_1_Paint; // تجنب مضاعفة الحدث
                button.Paint += BTN_Answer_1_Paint; // قم بربط حدث الرسم مع الزر

                button.Invalidate(); // أعد رسم الزر لتطبيق التغييرات
            }*/
        }

        private void BTN_Answer_1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BTN_Answer_2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void BTN_Answer_3_Paint(object sender, PaintEventArgs e)
        {
           /* Guna2Button button = (Guna2Button)sender;
            string buttonText = button.Text;

            // احسب موقع النص في الزر
            float x = (button.Width - e.Graphics.MeasureString(buttonText, button.Font).Width) / 2;
            float y = (button.Height - e.Graphics.MeasureString(buttonText, button.Font).Height) / 2;

            // رسم النص
            e.Graphics.DrawString(buttonText, button.Font, Brushes.Black, x, y);

            // رسم الخط في منتصف النص
            e.Graphics.DrawLine(Pens.Black, x, y + (e.Graphics.MeasureString(buttonText, button.Font).Height / 2), x + e.Graphics.MeasureString(buttonText, button.Font).Width, y + (e.Graphics.MeasureString(buttonText, button.Font).Height / 2));*/
        }

        private void BTN_Answer_4_Paint(object sender, PaintEventArgs e)
        {
        /*    Guna2Button button = (Guna2Button)sender;
            string buttonText = button.Text;

            // احسب موقع النص في الزر
            float x = (button.Width - e.Graphics.MeasureString(buttonText, button.Font).Width) / 2;
            float y = (button.Height - e.Graphics.MeasureString(buttonText, button.Font).Height) / 2;

            // رسم النص
            *//*    e.Graphics.DrawString(buttonText, button.Font, Brushes.Black, x, y);*//*
           

        // في دالة الرسم

            // رسم الخط في منتصف النص
            if (drawLine)
            {
                e.Graphics.DrawLine(new Pen(Color.FromArgb(lineAlpha, Color.White), lineThickness), 0, y + (e.Graphics.MeasureString(buttonText, button.Font).Height / 2), button.Width, y + (e.Graphics.MeasureString(buttonText, button.Font).Height / 2));
            }*/
        }

        private void BTN_Answer_2_MouseClick(object sender, MouseEventArgs e)
        {
           /* if (e.Button == MouseButtons.Right) // اختبار النقر بزر اليمين
            {
                Guna2Button button = (Guna2Button)sender;
                button.Paint -= BTN_Answer_2_Paint; // تجنب مضاعفة الحدث
                button.Paint += BTN_Answer_2_Paint; // قم بربط حدث الرسم مع الزر

                button.Invalidate(); // أعد رسم الزر لتطبيق التغييرات
            }*/
        }

        private void BTN_Answer_3_MouseClick(object sender, MouseEventArgs e)
        {
           /* if (e.Button == MouseButtons.Right) // اختبار النقر بزر اليمين
            {
                Guna2Button button = (Guna2Button)sender;
                button.Paint -= BTN_Answer_3_Paint; // تجنب مضاعفة الحدث
                button.Paint += BTN_Answer_3_Paint; // قم بربط حدث الرسم مع الزر

                button.Invalidate(); // أعد رسم الزر لتطبيق التغييرات
            }*/
        }

        private void BTN_Answer_4_MouseClick(object sender, MouseEventArgs e)
        {
          /*  if (e.Button == MouseButtons.Right) {
                Guna2Button button = (Guna2Button)sender;

                drawLine = !drawLine; // تبديل حالة رسم الخط

                button.Invalidate(); // أعد رسم الزر لتطبيق التغييرات
            }*/
            
        }

        private void BTN_Answer_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // اختبار النقر بزر اليمين
            {
                rightClick = true; // تعيين حالة النقر بزر اليمين إلى true
            }
        }

        private void BTN_Answer_4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // اختبار رفع النقر بزر اليمين
            {
                rightClick = false; // تعيين حالة النقر بزر اليمين إلى false
            }
        }

        private void COMP_Answer_TrueFalse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isClickCOMP_TR_FA)
            {
                if (typeQ != "اختر الاجابة الصحيحة")
                {
                    questionAnswerData.storeAnswer(Convert.ToInt32(nameBTN.Tag), COMP_Answer_TrueFalse.Text, COMP_Answer_TrueFalse.Tag.ToString(), GradeCurrentQuestion);
                     nameBTN.BackColor = Color.FromArgb(133, 189, 52);
                   /* if (COMP_Answer_TrueFalse.Text.Length > 0)
                    {
                       
                    }*/

                }
            }
          

        }

        private void COMP_Answer_TrueFalse_Click(object sender, EventArgs e)
        {
            isClickCOMP_TR_FA = true;
        }

        private void Form_ViewExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isSendForm)
            {
                finchExam();
            }
           
          
        }

        private void Form_ViewExam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
            {
                
                e.Handled = true;
            }
        }
    }
}
