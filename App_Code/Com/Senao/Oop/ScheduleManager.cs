using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Web;
using System.IO;

namespace Com.Senao.Oop
{
    /// <summary>
    /// 排程管理
    /// </summary>
    public class ScheduleManager
    {
        /// <summary>
        /// 排程
        /// </summary>
        private List<Schedule> schedules;

        public Schedule this[int index]
        {
            get
            {
                return schedules[index];
            }
        }

        /// <summary>
        /// 筆數
        /// </summary>
        /// <returns>排程筆數</returns>
        public int Count()
        {
            return schedules.Count;
        }

        public void ProcessSchedules()
        {
            JObject scheduleData = JObject.Parse(File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/Schedule.json")));
            JArray scheduleDataArray = (JArray)scheduleData["schedules"];
            this.schedules = scheduleDataArray.ToObject<List<Schedule>>();
        }
    }
}