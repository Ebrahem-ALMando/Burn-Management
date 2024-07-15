using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.CoursesProcess
{
    internal class Cls_CoursesDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Course Forms

        //    <=============== Method ======================>

        //==> 1 getData To Course
        public DataTable getDataCourses()
        {
            DataTable dataCourse = new DataTable();
            try
            {
                connection.open();
                dataCourse = connection.Read_Data("getDataCourses", null);
                connection.cloes();
                return dataCourse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourse;
            }

        }
        //==> 2 Insert To Course
        public void insertCourse(int idTeacher,int idBranch,string name, string yearName, string season, string note, DateTime date)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTeacher;
                param[1] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[1].Value = idBranch;
                param[2] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[2].Value = name;
                param[3] = new SqlParameter("@yearName", SqlDbType.NVarChar);
                param[3].Value = yearName;
                param[4] = new SqlParameter("@season", SqlDbType.NVarChar);
                param[4].Value = season;
                param[5] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[5].Value = note;
                param[6] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[6].Value = date;
                connection.process("insertCourse", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 3 Update To Course
        public void updateCourse(int id, int idBranch, string name, string yearName, string season, string note)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[1].Value = idBranch;
                param[2] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[2].Value = name;
                param[3] = new SqlParameter("@yearName", SqlDbType.NVarChar);
                param[3].Value = yearName;
                param[4] = new SqlParameter("@season", SqlDbType.NVarChar);
                param[4].Value = season;
                param[5] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[5].Value = note;
                connection.process("updateCourse", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Delete To Course
        public void deleteCourse(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteCourse", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 5 Serach To Course
        public DataTable serachDataCourse(string text)
        {
            DataTable dataCourse = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataCourse = connection.Read_Data("serachDataCourse", param);
                connection.cloes();
                return dataCourse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourse;
            }
        }
        //==> 6 Get Data Courses To Teacher
        public DataTable getDataCoursesToTeacher(int idTrainer)
        {
            DataTable dataCourses = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTrainer;
                dataCourses = connection.Read_Data("getDataCoursesToTeacher", param);
                connection.cloes();
                return dataCourses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourses;
            }
        }
        //==> 7 Seaech To Courses To Teacher
        public DataTable serachDataCourseToTeacher(int idTeacher, string text)
        {
            DataTable dataTeacher = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                param[1] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[1].Value = idTeacher;
                dataTeacher = connection.Read_Data("serachDataCourseToTeacher", param);
                connection.cloes();
                return dataTeacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataTeacher;
            }
        }
        public DataTable getDataCourseFromIdTeacher(int idTeacher, string AcademicYear)
        {
            DataTable dataCourse = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@YearName", SqlDbType.NVarChar);
                param[0].Value = AcademicYear;
                param[1] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[1].Value = idTeacher;
                dataCourse = connection.Read_Data("getDataCourseFromIdTeacher", param);
                connection.cloes();
                return dataCourse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourse;
            }
        }
        public DataTable getDataCourseForGetExamGUI(int idBranch, string AcademicYear)
        {
            DataTable dataCourse = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@YearName", SqlDbType.NVarChar);
                param[0].Value = AcademicYear;
                param[1] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[1].Value = idBranch;
                dataCourse = connection.Read_Data("getDataCourseForGetExamGUI", param);
                connection.cloes();
                return dataCourse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCourse;
            }
        }
        //==> 7 Get CheckIsDelete
        public DataTable getDataIsCanDeleteCourses(int id)
        {
            DataTable dataCourses = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataCourses = connection.Read_Data("getDataIsCanDeleteCourses", param);
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
