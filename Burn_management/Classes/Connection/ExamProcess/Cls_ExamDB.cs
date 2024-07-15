using System;
using System.Data.SqlClient;
using System.Data;

namespace Burn_management.Classes.Connection.ExamProcess
{
    internal class Cls_ExamDB
    {
        public static bool isUpdateTime { get; set; } = false;
        public static string newTime { get; set; }
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
      

        //==> Process Exam Forms

        //    <=============== Method ======================>

        //==> 1 Get Data Exams To Teacher


        //==> 1 getData To Exams
        public DataTable getDataExams()
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                dataExams = connection.Read_Data("getDataExams", null);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }

        }
        public DataTable getDataToTeacherExams(int id)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataExams = connection.Read_Data("GetDataToTeacherExams", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }

        public DataTable getDataExamsToActiveFilterByYear(int id,string academicYear)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@AcademicYear", SqlDbType.NVarChar);
                param[1].Value = academicYear;
                dataExams = connection.Read_Data("getDataExamsToActiveFilterByYear", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        //==> 2  Insert Exam
        public void insertExam(int idTeacher, int idBranch, int idCourse, string year, string season, string dateExam, string nameExam, int countQuExam, float finalGradeExam, string note, DateTime addedDate)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[11];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTeacher;
                param[1] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[1].Value = idBranch;
                param[2] = new SqlParameter("@idCourse", SqlDbType.Int);
                param[2].Value = idCourse;
                param[3] = new SqlParameter("@Year", SqlDbType.NVarChar);
                param[3].Value = year;
                param[4] = new SqlParameter("@Season", SqlDbType.NVarChar);
                param[4].Value = season;
                param[5] = new SqlParameter("@DateExam", SqlDbType.NVarChar);
                param[5].Value = dateExam;
                param[6] = new SqlParameter("@NameExam", SqlDbType.NVarChar);
                param[6].Value = nameExam;
                param[7] = new SqlParameter("@CountQuExam", SqlDbType.Int);
                param[7].Value = countQuExam;
                param[8] = new SqlParameter("@FinalGradeExam", SqlDbType.Float);
                param[8].Value = finalGradeExam;
                param[9] = new SqlParameter("@note", SqlDbType.Text);
                param[9].Value = note;
                param[10] = new SqlParameter("@AddedDate", SqlDbType.Date);
                param[10].Value = addedDate;

                connection.process("insertExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 2  Update Exam
        public void updateExam(int id,int idTeacher, int idBranch, int idCourse, string year, string season, string dateExam, string nameExam, int countQuExam, float finalGradeExam, string note)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[11];
                param[0] = new SqlParameter("@idTeacher", SqlDbType.Int);
                param[0].Value = idTeacher;
                param[1] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[1].Value = idBranch;
                param[2] = new SqlParameter("@idCourse", SqlDbType.Int);
                param[2].Value = idCourse;
                param[3] = new SqlParameter("@Year", SqlDbType.NVarChar);
                param[3].Value = year;
                param[4] = new SqlParameter("@Season", SqlDbType.NVarChar);
                param[4].Value = season;
                param[5] = new SqlParameter("@DateExam", SqlDbType.NVarChar);
                param[5].Value = dateExam;
                param[6] = new SqlParameter("@NameExam", SqlDbType.NVarChar);
                param[6].Value = nameExam;
                param[7] = new SqlParameter("@CountQuExam", SqlDbType.Int);
                param[7].Value = countQuExam;
                param[8] = new SqlParameter("@FinalGradeExam", SqlDbType.Float);
                param[8].Value = finalGradeExam;
                param[9] = new SqlParameter("@note", SqlDbType.Text);
                param[9].Value = note;
                param[10] = new SqlParameter("@id", SqlDbType.Int);
                param[10].Value = id;

                connection.process("UpdateExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 3 Delete Exam
        public void deleteExam(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteExam", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public DataTable getDtatYearNumberExam(int idBranch,string yearName,string semesterCourse,int idCourse)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@YearName", SqlDbType.NVarChar);
                param[0].Value = yearName;
                param[1] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[1].Value = idBranch;
                param[2] = new SqlParameter("@semesterCourse", SqlDbType.NVarChar);
                param[2].Value = semesterCourse;
                param[3] = new SqlParameter("@idCourse", SqlDbType.Int);
                param[3].Value = idCourse;
                dataExams = connection.Read_Data("getDtatYearNumberExam", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        public DataTable getDtatExamFromYearNumberExam(int idBranch, string yearName, string semesterCourse, int idCourse,string yearNumberExam)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@YearName", SqlDbType.NVarChar);
                param[0].Value = yearName;
                param[1] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[1].Value = idBranch;
                param[2] = new SqlParameter("@semesterCourse", SqlDbType.NVarChar);
                param[2].Value = semesterCourse;
                param[3] = new SqlParameter("@idCourse", SqlDbType.Int);
                param[3].Value = idCourse;
                param[4] = new SqlParameter("@yearNumberExam", SqlDbType.NVarChar);
                param[4].Value = yearNumberExam;
                dataExams = connection.Read_Data("getDtatExamFromYearNumberExam", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        public DataTable getDataActiveExamFromToStudents(int idForm)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idForm", SqlDbType.Int);
                param[0].Value = idForm;
                dataExams = connection.Read_Data("getDataActiveExamFromToStudents", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        public DataTable getDataExamsToAddQuestionFilterByYear (int id, string academicYear)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@AcademicYear", SqlDbType.NVarChar);
                param[1].Value = academicYear;
                dataExams = connection.Read_Data("getDataExamsToAddQuestionFilterByYear", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        public DataTable getQuestionToExam(int idForm)
        {
            DataTable dataExams = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idExam", SqlDbType.Int);
                param[0].Value = idForm;
                dataExams = connection.Read_Data("getQuestionToExam", param);
                connection.cloes();
                return dataExams;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExams;
            }
        }
        //==> 7 Get CheckIsDelete
        public DataTable getDataIsCanDeleteExam(int id)
        {
            DataTable dataExam = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataExam = connection.Read_Data("getDataIsCanDeleteExam", param);
                connection.cloes();
                return dataExam;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataExam;
            }
        }
    }
}
