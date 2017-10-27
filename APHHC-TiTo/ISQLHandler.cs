using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APHHC_TiTo
{
    public interface ISQLHandler
    {
        DateTime getDateTime();

        int getBreakID(int dailyLogID);
        int checkIfTimedIn(int employeeNo);
        int getEmployeeNumber(string employeeName);

        string getStatus(int dailyLogID);
        string getLunchStatus(int dailyLogID);

        void insertBreakOut(int dailyLogID, DateTime breakOut);
        void insertTimeInAM(int employeeNo, DateTime timeInAm);
        void updateBreakIn(int dailyLogID, DateTime breakIn, int breakID);
        void updateTimeInPM(int dailyLogID, DateTime timeInPm);
        void updateTimeOutAM(int dailyLogID, DateTime timeOutAm);
        void updateTimeOutPM(int dailyLogID, DateTime timeOutPm);
        void updateStatus(int dailyLogID, string status);
        void updateLunch(int dailyLogID, string lunchTimeUsed);
    }
}
