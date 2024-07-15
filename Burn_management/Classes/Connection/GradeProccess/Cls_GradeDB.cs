using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.GradeProccess
{
    internal class Cls_GradeDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();


        //==> Process Grade Forms

        //    <=============== Method ======================>

        //==> 1  insert Grade
        public void insertGrade(int idStudent, int idForm, int idActiveForm, float grade)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@idStudent", SqlDbType.Int);
                param[0].Value = idStudent;
                param[1] = new SqlParameter("@idForm", SqlDbType.Int);
                param[1].Value = idForm;
                param[2] = new SqlParameter("@idActiveForm", SqlDbType.Int);
                param[2].Value = idActiveForm;
                param[3] = new SqlParameter("@grade", SqlDbType.Float);
                param[3].Value = grade;
                connection.process("insertGrades", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //==> 2  get Data Check Grade To Student
        public DataTable getDataCheckGradeToStudent(int idStudent, int idActiveForm)
        {
            DataTable dataGrade = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@idStudent", SqlDbType.Int);
                param[0].Value = idStudent;
                param[1] = new SqlParameter("@idActiveForm", SqlDbType.Int);
                param[1].Value = idActiveForm;
                dataGrade = connection.Read_Data("getDataCheckGradeToStudent", param);
                connection.cloes();
                return dataGrade;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataGrade;
            }
        }
        //==> 2  get Data Check Grade To Student
        public DataTable getDataGradeToExam(int idExam)
        {
            DataTable dataGrade = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idExam ", SqlDbType.Int);
                param[0].Value = idExam;
                dataGrade = connection.Read_Data("getDataGradeToExam", param);
                connection.cloes();
                return dataGrade;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataGrade;
            }
        }
    }
}
