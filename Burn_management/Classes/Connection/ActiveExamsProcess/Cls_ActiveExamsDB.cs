using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.ActiveExamsProcess
{
    internal class Cls_ActiveExamsDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process ActiveExams Forms

        //    <=============== Method ======================>

        //==> 1 getData To ActiveExams
        public DataTable getDataActiveExam()
        {
            DataTable dataActiveExam = new DataTable();
            try
            {
                connection.open();
                dataActiveExam = connection.Read_Data("getDataActiveExam", null);
                connection.cloes();
                return dataActiveExam;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataActiveExam;
            }
        }
        //==> 2 Get Data Active Exam To Teacher
        public DataTable getDataActiveExamToTeacher(int idTeacher)
        {
            DataTable dataActiveExam = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTeacher;
                dataActiveExam = connection.Read_Data("getDataActiveExamToTeacher", param);
                connection.cloes();
                return dataActiveExam;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataActiveExam;
            }
        }
        //==> 3 Insert To ActiveExams
        public void insertActiveExam(int idForm,string pass,int studentCount,string timePeriod,string viewGrade)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@idForm", SqlDbType.Int);
                param[0].Value = idForm;
                param[1] = new SqlParameter("@password", SqlDbType.NVarChar);
                param[1].Value = pass;
                param[2] = new SqlParameter("@studentCount", SqlDbType.Int);
                param[2].Value = studentCount;
                param[3] = new SqlParameter("@timePeriod", SqlDbType.NVarChar);
                param[3].Value = timePeriod;
                param[4] = new SqlParameter("@viewGrade", SqlDbType.NVarChar);
                param[4].Value = viewGrade;
                connection.process("insertActiveExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Upadre Time To ActiveExams
        public void updateTimeActiveExam(int id, string timePeriod)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@timePeriod", SqlDbType.NVarChar);
                param[1].Value = timePeriod;
                connection.process("updateTimeActiveExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 5 Delete To ActiveExams
        public void deleteActiveExams(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteActiveExams", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 5 Delete To ActiveExams
        public void insertNewRequestExam(int idActiveExam)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idActiveExam", SqlDbType.Int);
                param[0].Value = idActiveExam;
                connection.process("insertNewRequestExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 2 Get Data Active Exam To Teacher
        public DataTable getDataStudentAccessCountToExam(int idActiveExam)
        {
            DataTable dataActiveExam = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idActiveExam", SqlDbType.Int);
                param[0].Value = idActiveExam;
                dataActiveExam = connection.Read_Data("getDataStudentAccessCountToExam", param);
                connection.cloes();
                return dataActiveExam;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataActiveExam;
            }
        }

        public DataTable getDataviewGradeActiveExamToStudent(int idActiveExam)
        {
            DataTable dataActiveExam = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idActiveExam", SqlDbType.Int);
                param[0].Value = idActiveExam;
                dataActiveExam = connection.Read_Data("getDataviewGradeActiveExamToStudent", param);
                connection.cloes();
                return dataActiveExam;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataActiveExam;
            }
        }
        //==> 2 Get Data Active Exam To Teacher
        public DataTable getDataNewTimeToActiveExam(int idActiveExam)
        {
            DataTable dataActiveExam = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idActiveExam", SqlDbType.Int);
                param[0].Value = idActiveExam;
                dataActiveExam = connection.Read_Data("getDataNewTimeToActiveExam", param);
                connection.cloes();
                return dataActiveExam;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataActiveExam;
            }
        }
        //==> 7 Get CheckIsDelete
        public DataTable getDataIsCanDeleteActiveForm(int id)
        {
            DataTable dataActiveForm = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataActiveForm = connection.Read_Data("getDataIsCanDeleteActiveForm", param);
                connection.cloes();
                return dataActiveForm;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataActiveForm;
            }
        }
    }
}
