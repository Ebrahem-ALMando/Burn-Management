using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.QuestionProcess
{
    public class QuestionAnswerData
    {
        public   List<QuestionAnswerData> questionDataList = new List<QuestionAnswerData>();
        public int QuestionNumber { get; set; } // رقم السؤال
        public float QuestionGrade { get; set; } // علامة السؤال
        public int SelectedAnswer { get; set; } // رقم الإجابة المختارة
        public int CorrectAnswer { get; set; } // رقم الإجابة الصحيحة
        public bool AnswersMatch { get; set; } // هل الإجابة المختارة متطابقة مع الإجابة الصحيحة؟


        /* True Or False */
        public string CorrectAnswer_TR_FA_state { get; set; } = "";//الاجابة الصحيحة
        public string SelectedAnswer_TR_FA_state { get; set; } = "";//الاجابة المختارة

        public QuestionAnswerData() {

    
        }
    public void storeAnswer(int questionNumber, int selectedAnswer, int correctAnswer,float questionGrade)
    {
        // ابحث عن بيانات السؤال باستخدام LINQ
        var questionData = questionDataList.FirstOrDefault(q => q.QuestionNumber == questionNumber);

        // إذا تم العثور على البيانات، قم بتحديثها
        if (questionData != null)
        {
            questionData.SelectedAnswer = selectedAnswer;
            questionData.CorrectAnswer = correctAnswer;
            questionData.QuestionGrade = questionGrade;
        }
        else
        {
                // إذا لم يتم العثور على البيانات، قم بإنشاء بيانات جديدة وإضافتها إلى القائمة
                var newQuestionData = new QuestionAnswerData
                {
                    QuestionNumber = questionNumber,
                    SelectedAnswer = selectedAnswer,
                    CorrectAnswer = correctAnswer,
                    SelectedAnswer_TR_FA_state = "",
                    CorrectAnswer_TR_FA_state="",
                    QuestionGrade = questionGrade
            };

            questionDataList.Add(newQuestionData);
        }
       }

        public void storeAnswer(int questionNumber, string selectedAnswer_TR_FA_state, string correctAnswer_TR_FA_state, float questionGrade)
        {
            // ابحث عن بيانات السؤال باستخدام LINQ
            var questionData = questionDataList.FirstOrDefault(q => q.QuestionNumber == questionNumber);

            // إذا تم العثور على البيانات، قم بتحديثها
            if (questionData != null)
            {
                questionData.SelectedAnswer_TR_FA_state = selectedAnswer_TR_FA_state;
                questionData.CorrectAnswer_TR_FA_state = correctAnswer_TR_FA_state;
                questionData.QuestionGrade = questionGrade;
            }
            else
            {
                // إذا لم يتم العثور على البيانات، قم بإنشاء بيانات جديدة وإضافتها إلى القائمة
                var newQuestionData = new QuestionAnswerData
                {
                    QuestionNumber = questionNumber,
                   
                    SelectedAnswer = -1,
                    CorrectAnswer = -1,

                    SelectedAnswer_TR_FA_state = selectedAnswer_TR_FA_state,
                    CorrectAnswer_TR_FA_state = correctAnswer_TR_FA_state,
                    QuestionGrade = questionGrade
                };

                questionDataList.Add(newQuestionData);
            }
        }
        public bool compareAnswers(int questionNumber)
        {
            // ابحث عن بيانات السؤال باستخدام LINQ
            var questionData = questionDataList.FirstOrDefault(q => q.QuestionNumber == questionNumber);
/*            Console.Write(questionData.SelectedAnswer +""+""+ questionData.CorrectAnswer+""+(questionData.SelectedAnswer == questionData.CorrectAnswer));*/
            // إذا تم العثور على البيانات، قم بمقارنة الإجابتين
            if (questionData != null)
            {
                return questionData.SelectedAnswer == questionData.CorrectAnswer;
            }

            // إذا لم يتم العثور على البيانات، يمكن أن تقوم بإرجاع قيمة افتراضية (مثل false)
            return false;
        }
        public int getSelectedAnswer(int questionNumber)
        {
            // ابحث عن بيانات السؤال باستخدام LINQ
            var questionData = questionDataList.FirstOrDefault(q => q.QuestionNumber == questionNumber);

            // إذا تم العثور على البيانات، قم بإرجاع رقم الإجابة المختارة
            // إذا لم يتم العثور على البيانات، قم بإرجاع قيمة افتراضية (مثلاً -1)
            return questionData != null ? questionData.SelectedAnswer : -1;
        }

        public string getSelectedAnswer_TR_FA_state(int questionNumber)
        {
            // ابحث عن بيانات السؤال باستخدام LINQ
            var questionData = questionDataList.FirstOrDefault(q => q.QuestionNumber == questionNumber);

            // إذا تم العثور على البيانات، قم بإرجاع القيمة في الحقل SelectedAnswer_TR_FA_state
            // إذا لم يتم العثور على البيانات، يمكنك ترك القيمة فارغة أو إرجاع قيمة افتراضية حسب الحاجة
            return questionData != null ? questionData.SelectedAnswer_TR_FA_state : "";
        }

        public void PrintData()
        {
            foreach (var questionData in questionDataList)
            {
                Console.WriteLine($"Question {questionData.QuestionNumber}:");
                Console.WriteLine($"Selected Answer: {questionData.SelectedAnswer}");
                Console.WriteLine($"Correct Answer: {questionData.CorrectAnswer}");
                Console.WriteLine($"Correct Answer: {questionData.QuestionGrade}");

                Console.WriteLine($"Answers Match: {compareAnswers(QuestionNumber)}");
                Console.WriteLine();
            }
        }



    }

}
