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
        //public static string GetIpAddress()
        //{
        //    var request = HttpContext.Current.Request;
        //    // Look for a proxy address first
        //    var ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        //    // If there is no proxy, get the standard remote address
        //    if (string.IsNullOrWhiteSpace(ip)
        //        || string.Equals(ip, "unknown", StringComparison.OrdinalIgnoreCase))
        //        ip = request.ServerVariables["REMOTE_ADDR"];
        //    else
        //    {
        //        //extract first IP
        //        var index = ip.IndexOf(',');
        //        if (index > 0)
        //            ip = ip.Substring(0, index);

        //        //remove port
        //        index = ip.IndexOf(':');
        //        if (index > 0)
        //            ip = ip.Substring(0, index);
        //    }

        //    return ip;
        //}
        public static void AddLog(int ProcessType, string TableName, int ProcessID)
        {
            Log_Table log_Table = new Log_Table();
            log_Table.UserID = UserStatic.UserID;
            log_Table.ProcessType = ProcessType;
            log_Table.ProcessID = ProcessID;
            log_Table.ProcessCategoryType = TableName;
            log_Table.ProccessDate = DateTime.Now;
            //var context = System.Web.HttpContext.Current;
            //log_Table.IPAdress = context.Request.UserHostAddress;
            log_Table.IPAdress = "Unknown";
            db.Log_Table.Add(log_Table);
            db.SaveChanges();
        }
    }
}
