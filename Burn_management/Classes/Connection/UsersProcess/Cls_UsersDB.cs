using System;
using System.Data.SqlClient;
using System.Data;

namespace Burn_management.Classes.Connection.UsersProcess
{
    internal class Cls_UsersDB
    {
        public static string userName { get; set; }
        public static string password { get; set; }
        public static int idUser { get; set; } = 0;
        public static string nameUser { get; set; }
        public static string typeUser { get; set; }
        public static bool isLogin { get; set; }

        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Users Forms

        //    <=============== Method ======================>

        //==> 1 getData To Users
        public DataTable getDataUsers()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsers", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 2 get Data To Users Admins
        public DataTable getDataUsersAdmins()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsersAdmins", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 3 getData To Users Treatment Supervisors
        public DataTable getDataUsersTreatmentSupervisors()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsersTreatmentSupervisors", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 4 get Data To Users Data Entryists
        public DataTable getDataUsersDataEntryists()
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                dataUsers = connection.Read_Data("getDataUsersDataEntryists", null);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }

        //==> 5 Insert To Users
        public void insertUser(string name, string age,string phone, string address
           , string userName, string password, string typeUser, DateTime date)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[0].Value = name;
                param[1] = new SqlParameter("@age", SqlDbType.NChar);
                param[1].Value = age;
                param[2] = new SqlParameter("@phone", SqlDbType.NVarChar);
                param[2].Value = phone;
                param[3] = new SqlParameter("@address", SqlDbType.NVarChar);
                param[3].Value = address;
                param[4] = new SqlParameter("@userName", SqlDbType.NVarChar);
                param[4].Value = userName;
                param[5] = new SqlParameter("@password", SqlDbType.NVarChar);
                param[5].Value = password;
                param[6] = new SqlParameter("@typeUser", SqlDbType.NChar);
                param[6].Value = typeUser;
                param[7] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[7].Value = date;
                connection.process("insertUsers", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 6 update To Users
        public void updateUser(int id,string name, string age, string phone, string address,
          string userName
         , string password, string typeUser)
        {
            try
            {
                connection.open();

                SqlParameter[] parameters = new SqlParameter[8];

                parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                parameters[0].Value = id;

                parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 40);
                parameters[1].Value = name;

                parameters[2] = new SqlParameter("@age", SqlDbType.NVarChar, 10);
                parameters[2].Value = age;

                parameters[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 40);
                parameters[3].Value = phone;

                parameters[4] = new SqlParameter("@address", SqlDbType.NVarChar, 200);
                parameters[4].Value = address;

                parameters[5] = new SqlParameter("@userName", SqlDbType.NVarChar, 40);
                parameters[5].Value = userName;

                parameters[6] = new SqlParameter("@password", SqlDbType.NVarChar, 40);
                parameters[6].Value = password;

                parameters[7] = new SqlParameter("@typeUser", SqlDbType.NVarChar, 40);
                parameters[7].Value = typeUser;

                connection.process("updateUsers", parameters);
                connection.cloes();

          
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        //==> 7 Delete To Users
        public void deleteUser(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteUser", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 8 Get Data Check User Name To Users
        public DataTable getDataCheckUserName(string userN)
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@userName", SqlDbType.NVarChar);
                param[0].Value = userN;
                dataUsers = connection.Read_Data("getDataCheckUserName", param);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUsers;
            }

        }
        //==> 9 Serach To Users
        public DataTable serachDataUsers(string text, string typeS)
        {
            DataTable dataUsers = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                param[1] = new SqlParameter("@typeSearch", SqlDbType.NVarChar);
                param[1].Value = typeS;
                dataUsers = connection.Read_Data("searchDataUsers", param);
                connection.cloes();
                return dataUsers;
            }
            catch (Exception ex)
            {
                return dataUsers;
            }
        }
        //==> 10 Get CheckIsDelete
        public DataTable getDataIsCanDeleteUser(int id)
        {
            DataTable dataUser = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataUser = connection.Read_Data("getDataIsCanDeleteUser", param);
                connection.cloes();
                return dataUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUser;
            }
        }
    }

}
