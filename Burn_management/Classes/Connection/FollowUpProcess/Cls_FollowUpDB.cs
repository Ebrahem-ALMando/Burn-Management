using System;
using System.Data;
using System.Data.SqlClient;

namespace Burn_management.Classes.Connection.FollowUpProcess
{
    internal class Cls_FollowUpDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process FollowUp Forms

        //    <=============== Method ======================>

        //==> 1 getData To FollowUp
        public DataTable getDataFollowUp()
        {
            DataTable dataFollowUp = new DataTable();
            try
            {
                connection.open();
                dataFollowUp = connection.Read_Data("getDataFollowUp", null);
                connection.cloes();
                return dataFollowUp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataFollowUp;
            }

        }
        //==> 2 get Data Number Of Vist
        public DataTable getDataNumberOfVist(int idPatients)
        {
            DataTable dataNumberOfVist = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idPatients", SqlDbType.Int);
                param[0].Value = idPatients;
                dataNumberOfVist = connection.Read_Data("getDataNumberOfVist", param);
                connection.cloes();
                return dataNumberOfVist;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataNumberOfVist;
            }

        }
        //==> 3 Insert To FollowUp
        public void insertFollowUp(
                int idPatients, int idUser, string pressureMeasurement, string tissueMeasurement,
                string measureHeartRate, string temperatureMeasurement, string psychologicalEffects,
                string burnDrawer, string burnRate, string nerve_or_tendon_area, string typeExercise,
                string pharmaceutical, string numberVisit, string note, DateTime? dateNextVisit, DateTime dateAdd)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[16];

                param[0] = new SqlParameter("@idPatients", SqlDbType.Int);
                param[0].Value = idPatients;

                param[1] = new SqlParameter("@idUser", SqlDbType.Int);
                param[1].Value = idUser;

                param[2] = new SqlParameter("@pressureMeasurement", SqlDbType.NVarChar, 10);
                param[2].Value = pressureMeasurement;

                param[3] = new SqlParameter("@tissueMeasurement", SqlDbType.NVarChar, 10);
                param[3].Value = tissueMeasurement;

                param[4] = new SqlParameter("@measureHeartRate", SqlDbType.NVarChar, 10);
                param[4].Value = measureHeartRate;

                param[5] = new SqlParameter("@temperatureMeasurement", SqlDbType.NVarChar, 10);
                param[5].Value = temperatureMeasurement;

                param[6] = new SqlParameter("@psychologicalEffects", SqlDbType.NVarChar, 10);
                param[6].Value = psychologicalEffects;

                param[7] = new SqlParameter("@burnDrawer", SqlDbType.NVarChar, 2);
                param[7].Value = burnDrawer;

                param[8] = new SqlParameter("@burnRate", SqlDbType.NVarChar, 10);
                param[8].Value = burnRate;

                param[9] = new SqlParameter("@nerve_or_tendon_area", SqlDbType.NVarChar, 200);
                param[9].Value = nerve_or_tendon_area;

                param[10] = new SqlParameter("@typeExercise", SqlDbType.NVarChar, 100);
                param[10].Value = typeExercise;

                param[11] = new SqlParameter("@pharmaceutical", SqlDbType.NVarChar, 4);
                param[11].Value = pharmaceutical;

                param[12] = new SqlParameter("@numberVisit", SqlDbType.NChar, 10);
                param[12].Value = numberVisit;

                param[13] = new SqlParameter("@note", SqlDbType.NVarChar, 300);
                param[13].Value = note;

                param[14] = new SqlParameter("@dateNextVisit", SqlDbType.Date);
                param[14].Value = dateNextVisit;

                param[15] = new SqlParameter("@dateAdd", SqlDbType.Date);
                param[15].Value = dateAdd;

                connection.process("insertFollowUp", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //==> 4 Delete To FollowUp
        public void deleteFollowUp(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteFollowUp", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 5 get Data Id Current Follow Up
        public DataTable getDataIdCurrentFollowUp()
        {
            DataTable dataFollowUp = new DataTable();
            try
            {
                connection.open();
                dataFollowUp = connection.Read_Data("getDataIdCurrentFollowUp", null);
                connection.cloes();
                return dataFollowUp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataFollowUp;
            }

        }
        //==> 6 get Data FollowUp Discharge
        public DataTable getDataFollowUpDischarge()
        {
            DataTable dataFollowUp = new DataTable();
            try
            {
                connection.open();
                dataFollowUp = connection.Read_Data("getDataFollowUpDischarge", null);
                connection.cloes();
                return dataFollowUp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataFollowUp;
            }

        }
        //==> 7 get Data FollowUp Referral
        public DataTable getDataFollowUpReferral()
        {
            DataTable dataFollowUp = new DataTable();
            try
            {
                connection.open();
                dataFollowUp = connection.Read_Data("getDataFollowUpReferral", null);
                connection.cloes();
                return dataFollowUp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataFollowUp;
            }

        }
        //==> 8 get Data FollowUp Result Follow
        public DataTable getDataFollowUpResult_Follow()
        {
            DataTable dataFollowUp = new DataTable();
            try
            {
                connection.open();
                dataFollowUp = connection.Read_Data("getDataFollowUpResult_Follow", null);
                connection.cloes();
                return dataFollowUp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataFollowUp;
            }

        }
    }
}
