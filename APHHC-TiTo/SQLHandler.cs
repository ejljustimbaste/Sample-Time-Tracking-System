using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace APHHC_TiTo
{
    public class SQLHandler : ISQLHandler
    {
        public int checkIfTimedIn(int employeeNo)
        {
            SqlCommand cmd = new SqlCommand("usp_CheckIfTimedIn");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeNo", employeeNo);

            return Convert.ToInt32(Database.GetSingleFromDatabase(cmd));
        }

        public int getBreakID(int dailyLogID)
        {
            SqlCommand cmd = new SqlCommand("usp_GetBreakId");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);

            return Convert.ToInt32(Database.GetSingleFromDatabase(cmd));
        }

        public DateTime getDateTime()
        {
            SqlCommand cmd = new SqlCommand("usp_GetDateTime");
            cmd.CommandType = CommandType.StoredProcedure;

            return Convert.ToDateTime(Database.GetSingleFromDatabase(cmd));
        }

        public int getEmployeeNumber(string employeeName)
        {
            SqlCommand cmd = new SqlCommand("usp_GetEmployeeNumber");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeName", employeeName);

            return Convert.ToInt32(Database.GetSingleFromDatabase(cmd));
        }

        public string getLunchStatus(int dailyLogID)
        {
            SqlCommand cmd = new SqlCommand("usp_GetLunchStatus");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);

            return Convert.ToString(Database.GetSingleFromDatabase(cmd));
        }

        public string getStatus(int dailyLogID)
        {
            SqlCommand cmd = new SqlCommand("usp_GetStatus");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);

            return Convert.ToString(Database.GetSingleFromDatabase(cmd));
        }

        public void insertBreakOut(int dailyLogID, DateTime breakOut)
        {
            SqlCommand cmd = new SqlCommand("usp_InsertBreakOut");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);
            cmd.Parameters.AddWithValue("@BreakOut", breakOut);

            Database.RunStoredProcedure(cmd);
        }

        public void insertTimeInAM(int employeeNo, DateTime timeInAm)
        {
            SqlCommand cmd = new SqlCommand("usp_InsertTimeInAM");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeNo", employeeNo);
            cmd.Parameters.AddWithValue("@TimeIn", timeInAm);

            Database.RunStoredProcedure(cmd);
        }

        public void updateBreakIn(int dailyLogID, DateTime breakIn, int breakID)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateBreakIn");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);
            cmd.Parameters.AddWithValue("@BreakIn", breakIn);
            cmd.Parameters.AddWithValue("@BreakID", breakID);

            Database.RunStoredProcedure(cmd);
        }

        public void updateLunch(int dailyLogID, string lunchTimeUsed)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateLunch");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);
            cmd.Parameters.AddWithValue("@LunchTimeUsed", lunchTimeUsed);

            Database.RunStoredProcedure(cmd);
        }

        public void updateStatus(int dailyLogID, string status)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateStatus");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);
            cmd.Parameters.AddWithValue("@Status", status);

            Database.RunStoredProcedure(cmd);
        }

        public void updateTimeInPM(int dailyLogID, DateTime timeInPm)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateTimeInPM");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);
            cmd.Parameters.AddWithValue("@TimeInPM", timeInPm);

            Database.RunStoredProcedure(cmd);
        }

        public void updateTimeOutAM(int dailyLogID, DateTime timeOutAm)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateTimeOutAM");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);
            cmd.Parameters.AddWithValue("@TimeOutAM", timeOutAm);

            Database.RunStoredProcedure(cmd);
        }

        public void updateTimeOutPM(int dailyLogID, DateTime timeOutPm)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateTimeOutPM");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DailyLogId", dailyLogID);
            cmd.Parameters.AddWithValue("@TimeOutPM", timeOutPm);

            Database.RunStoredProcedure(cmd);
        }
    }
}
