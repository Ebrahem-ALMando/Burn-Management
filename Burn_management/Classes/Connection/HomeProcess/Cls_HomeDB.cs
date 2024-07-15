using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.HomeProcess
{
    internal class Cls_HomeDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Home Forms

        //    <=============== Method ======================>

        //==> 1 Get Data Count Users
        public DataTable getDataCountUser()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataCountUser", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }
        }

        //==>2 Get Data Count Branchs
        public DataTable getDataCountBranchs()
        {
            DataTable dataBranchs = new DataTable();
            try
            {
                connection.open();
                dataBranchs = connection.Read_Data("getDataCountBranchs", null);
                connection.cloes();
                return dataBranchs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataBranchs;
            }
        }

        //==>3 Get Data Count Exams
        public DataTable getDataCountActiveExams()
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                dataExams = connection.Read_Data("getDataCountActiveExams", null);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }

        //==>4 Get Data Count Courses
        public DataTable getDataCountCourses()
        {
            DataTable dataCourses = new DataTable();
            try
            {
                connection.open();
                dataCourses = connection.Read_Data("getDataCountCourses", null);
                connection.cloes();
                return dataCourses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourses;
            }
        }

        //==>5 Get Data Count Exams
        public DataTable getDataCountExams()
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                dataExams = connection.Read_Data("getDataCountExams", null);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        //==>6 Get Data Count Question
        public DataTable getDataCountQuestion()
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                dataQuestion = connection.Read_Data("getDataCountQuestion", null);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }
        }

        //==>7 Get Data Count Question To Teachers
        public DataTable getDataCountQuestionToTeachers(int idTeacher)
        {
            DataTable dataQuestion = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = idTeacher;
                dataQuestion = connection.Read_Data("getDataCountQuestionToTeachers", param);
                connection.cloes();
                return dataQuestion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataQuestion;
            }
        }

        //==>8 Get Data Count Active Exams To Teachers
        public DataTable getDataCountActiveExamsToTeachers(int idTeacher)
        {
            DataTable dataActiveExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = idTeacher;
                dataActiveExams = connection.Read_Data("getDataCountActiveExamsToTeachers", param);
                connection.cloes();
                return dataActiveExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataActiveExams;
            }
        }

        //==>9 Get Data Count  Exams To Teachers
        public DataTable getDataCountExamsToTeachers(int idTeacher)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = idTeacher;
                dataExams = connection.Read_Data("getDataCountExamsToTeachers", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        //==>10 Get Data Count  Courses To Teachers
        public DataTable getDataCountCoursesToTeachers(int idTeacher)
        {
            DataTable dataCourses = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = idTeacher;
                dataCourses = connection.Read_Data("getDataCountCoursesToTeachers", param);
                connection.cloes();
                return dataCourses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourses;
            }
        }
    }
}
