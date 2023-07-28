using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class LogDAL:PostContext
    {
        public static void AddLog(int ProcessType, string TableName, int ProcessID)
        {
            Log_Table log_Table = new Log_Table();
            log_Table.UserID = UserStatic.UserID;
            log_Table.ProcessType = ProcessType;
            log_Table.ProcessID = ProcessID;
            log_Table.ProcessCategoryType = TableName;
            log_Table.ProccessDate = DateTime.Now;
            //log_Table.IPAdress = HttpContext.Current.Request.UserHostAddress;
            log_Table.IPAdress = "Unknown";
            db.Log_Table.Add(log_Table);
            db.SaveChanges();
        }
    }
}
