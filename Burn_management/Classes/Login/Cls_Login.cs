using Burn_management.Classes.Connection;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Burn_management
{
    class Cls_Login:Cls_AccessLayer_DB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Suppliers Forms

        //    <=============== Method ======================>
        public bool isLoogin(string User_Name, string Pass)
        {
            using (var conction = GetConction())
            {
                conction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conction;
                    command.CommandText = @"select * from Users_TB 
                                            where userName = @User_N
                                            and Password = @User_Pass";
                    command.Parameters.AddWithValue("@User_N", User_Name);
                    command.Parameters.AddWithValue("@User_Pass", Pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                     
                        return true;
                    }
                    else
                    {
                       
                        return false;
                    }

                }
                
            }
        }
        //==> 1 Get Data Type User 
        public DataTable getDataTypeUser(string userN)
        {
            DataTable typeUser = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@userName", SqlDbType.NVarChar);
                param[0].Value = userN;
                typeUser = connection.Read_Data("getDataTypeUser", param);
                connection.cloes();
                return typeUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return typeUser;
            }

        }
        //==> 2 Get Data Name User 
        public DataTable getDataNameUser(string userN)
        {
            DataTable nameUser = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@userName", SqlDbType.NVarChar);
                param[0].Value = userN;
                nameUser = connection.Read_Data("getDataNameUser", param);
                connection.cloes();
                return nameUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return nameUser;
            }

        }
        //==> 3 Get Data Id User 
        public DataTable getDataIdUser(string userN)
        {
            DataTable idUser = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@userName", SqlDbType.NVarChar);
                param[0].Value = userN;
                idUser = connection.Read_Data("getDataIdUser", param);
                connection.cloes();
                return idUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return idUser;
            }

        }
       

    }
}
