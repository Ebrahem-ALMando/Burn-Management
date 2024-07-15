using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn_management.Classes.Connection.BranchProcess
{
    internal class Cls_BranchDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Branchs Forms

        //    <=============== Method ======================>

        //==> 1 getData To Branchs
        public DataTable getDataBranch()
        {
            DataTable dataBranchs = new DataTable();
            try
            {
                connection.open();
                dataBranchs = connection.Read_Data("getDataBranchs", null);
                connection.cloes();
                return dataBranchs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataBranchs;
            }

        }
        //==> 2 Insert To Branch
        public void insertBranch(string name, string place, int yearCount, string note, DateTime date)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[0].Value = name;
                param[1] = new SqlParameter("@place", SqlDbType.NVarChar);
                param[1].Value = place;
                param[2] = new SqlParameter("@yearCount", SqlDbType.Int);
                param[2].Value = yearCount;
                param[3] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[3].Value = note;
                param[4] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[4].Value = date;
                connection.process("insertBranch", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 3 Update To Branch
        public void updateBranch(int id,string name, string place, int yearCount, string note)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[1].Value = name;
                param[2] = new SqlParameter("@place", SqlDbType.NVarChar);
                param[2].Value = place;
                param[3] = new SqlParameter("@yearCount", SqlDbType.Int);
                param[3].Value = yearCount;
                param[4] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[4].Value = note;
                connection.process("updateBranch", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Delete To Branch
        public void deleteBranch(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteBranch", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 5 Serach To Branch
        public DataTable serachDataBranch(string text)
        {
            DataTable dataBranch = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataBranch = connection.Read_Data("serachDataBranch", param);
                connection.cloes();
                return dataBranch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataBranch;
            }
        }
        //==> 6 Get Data Type User 
        public DataTable getYearCountOfBranchUser(int idBranch)
        {
            DataTable dataBranch = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idBranch", SqlDbType.Int);
                param[0].Value = idBranch;
                dataBranch = connection.Read_Data("getYearCountOfBranchUser", param);
                connection.cloes();
                return dataBranch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataBranch;
            }

        }
        //==> 7 Get CheckIsDelete
        public DataTable getDataIsCanDeleteBranch(int id)
        {
            DataTable dataBranch = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataBranch = connection.Read_Data("getDataIsCanDeleteBranch", param);
                connection.cloes();
                return dataBranch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataBranch;
            }
        }
    }
  
   
}

