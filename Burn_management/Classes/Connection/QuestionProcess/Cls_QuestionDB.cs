using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.QuestionProcess
{
    internal class Cls_QuestionDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Question Forms

        //    <=============== Method ======================>

        //==> 1 Get Data Question
        public DataTable getDataQuestion()
        {
            DataTable dataCourses = new DataTable();
            try
            {
                connection.open();
                dataCourses = connection.Read_Data("getDataQuestion", null);
                connection.cloes();
                return dataCourses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourses;
            }
        }
        //==> 2 Get Data Question To Teacher
        public DataTable getDataQuestionToTeacher(int idTrainer)
        {
            DataTable dataCourses = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTrainer;
                dataCourses = connection.Read_Data("getDataQuestionToTeacher", param);
                connection.cloes();
                return dataCourses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourses;
            }
        }

        //==> 1 get Data Id Question To Add Answer

        public DataTable getIDQuestionToAddAnswer()
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                dataQuestion = connection.Read_Data("getIDQuestionToAddAnswer ", null);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }

        }
        //==> 2  Insert Question
        public void insertQuestion(int idTeacher, int idExam,string text,string typeQuestion,float grade,  DateTime addedDate)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTeacher;
                param[1] = new SqlParameter("@idExam", SqlDbType.Int);
                param[1].Value = idExam;
                param[2] = new SqlParameter("@text", SqlDbType.Text);
                param[2].Value = text;
                param[3] = new SqlParameter("@typeQuestion", SqlDbType.NVarChar);
                param[3].Value = typeQuestion;
                param[4] = new SqlParameter("@grade", SqlDbType.Float);
                param[4].Value = grade;
                param[5] = new SqlParameter("@AddedDate", SqlDbType.Date);
                param[5].Value = addedDate;

                connection.process("insertQuestion", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //==> 2  Insert Answer
        public void insertAnswer(int idQuestion,string text,string isTrue)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@idQuestion", SqlDbType.Int);
                param[0].Value = idQuestion;
                param[1] = new SqlParameter("@text", SqlDbType.Text);
                param[1].Value = text;
                param[2] = new SqlParameter("@isTrue", SqlDbType.NVarChar);
                param[2].Value = isTrue;
                connection.process("insertAnswer", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //==> 1 Get Data Question To By Id Exam To Gui Exam
        public DataTable getDataQuestionToByIdExamToGuiExam(int idExam)
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idExam", SqlDbType.Int);
                param[0].Value = idExam;
                dataQuestion = connection.Read_Data("getDataQuestionToByIdExamToGuiExam", param);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }
        }

        public DataTable getDataCurrentQuestionToGuiExam(int idQuestion)
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idQuestion", SqlDbType.Int);
                param[0].Value = idQuestion;
                dataQuestion = connection.Read_Data("getDataCurrentQuestionToGuiExam", param);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }
        }

        public DataTable getDataAnswerByIdQuestionToQuestion(int idQuestion)
        {
            DataTable dataAnswer = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idQuestion", SqlDbType.Int);
                param[0].Value = idQuestion;
                dataAnswer = connection.Read_Data("getDataAnswerByIdQuestionToQuestion", param);
                connection.cloes();
                return dataAnswer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataAnswer;
            }
        }
        //==> 2 Get Data Calculate Question Mark
        public DataTable getDataCalculateQuestionMark(int idExam)
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idExam", SqlDbType.Int);
                param[0].Value = idExam;
                dataQuestion = connection.Read_Data("getDataCalculateQuestionMark", param);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }
        }
        //==> 2  delete Question
        public void deleteQuestion(int idQuestion)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idQuestion", SqlDbType.Int);
                param[0].Value = idQuestion;
                connection.process("deleteQuestion", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //==> 2  Insert Question To Exam
        public void insertQuestionToExam(int idQ, int idExam, float grade, DateTime addedDate)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@idQ", SqlDbType.Int);
                param[0].Value = idQ;
                param[1] = new SqlParameter("@idExam", SqlDbType.Int);
                param[1].Value = idExam;
                param[2] = new SqlParameter("@grade", SqlDbType.Float);
                param[2].Value = grade;
                param[3] = new SqlParameter("@AddedDate", SqlDbType.Date);
                param[3].Value = addedDate;

                connection.process("insertQuestionToExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void insertAnswersQuesToExam( int idPreviousQuestion, int idQuestion)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@idPreviousQuestion", SqlDbType.Int);
                param[0].Value = idPreviousQuestion;
                param[1] = new SqlParameter("@idQuestion", SqlDbType.Int);
                param[1].Value = idQuestion;
                connection.process("insertAnswersQuesToExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public DataTable getDataQuestionByExam(int idExam)
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idExam", SqlDbType.Int);
                param[0].Value = idExam;
                dataQuestion = connection.Read_Data("getDataQuestionByExam", param);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }
        }
        //==> 7 Get CheckIsDelete
        public DataTable getDataIsCanDeleteQuestion(int id)
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataQuestion = connection.Read_Data("getDataIsCanDeleteQuestion", param);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }
        }
    }
}
