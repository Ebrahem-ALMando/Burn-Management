using System;
using System.Data.SqlClient;
using System.Data;

namespace Burn_management.Classes.Connection.DischargeProcess
{
    internal class Cls_DischargeDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Discharge Forms

        //    <=============== Method ======================>

        //==> 1 get Data To Discharge
        public DataTable getDataDischarge()
        {
            DataTable dataDischarge = new DataTable();
            try
            {
                connection.open();
                dataDischarge = connection.Read_Data("getDataDischarge", null);
                connection.cloes();
                return dataDischarge;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataDischarge;
            }

        }
        //==> 3  Insert Discharge
        public void insertDischarge(int idPatients, int idFollowUp, string note)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@idPatients", SqlDbType.Int);
                param[0].Value = idPatients;
                param[1] = new SqlParameter("@idFollowUp", SqlDbType.Int);
                param[1].Value = idFollowUp;
                param[2] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[2].Value = note??string.Empty;
                connection.process("insertDischarge", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Delete Discharge
        public void deleteDischarge(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idFollowUp", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteDischarge", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
    }
}
