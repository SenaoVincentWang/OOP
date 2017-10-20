namespace Com.Senao.Oop
{
    /// <summary>
    /// 排程
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// 排程所處理的檔案格式
        /// </summary>
        private string ext;

        /// <summary>
        /// 排程執行的間隔
        /// </summary>
        private string interval;

        /// <summary>
        /// 排程所處理的時間
        /// </summary>
        private string time;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ext">排程所處理的檔案格式</param>
        /// <param name="time">排程所處理的時間</param>
        /// <param name="interval">排程執行的間隔</param>
        public Schedule(string ext,
                        string time,
                        string interval)
        {
            this.ext = ext;
            this.time = time;
            this.interval = interval;
        }

        /// <summary>
        /// 排程所處理的檔案格式
        /// </summary>
        public string Ext
        {
            get { return this.ext; }
        }

        /// <summary>
        /// 排程執行的間隔
        /// </summary>
        public string Interval
        {
            get { return this.interval; }
        }

        /// <summary>
        /// 排程所處理的時間
        /// </summary>
        public string Time
        {
            get { return this.time; }
        }
    }
}