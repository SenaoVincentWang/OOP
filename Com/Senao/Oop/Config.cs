namespace Com.Senao.Oop
{
    /// <summary>
    /// 設定
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 資料庫連接字串
        /// </summary>
        private string connectionString;

        /// <summary>
        /// 儲存目的地
        /// </summary>
        private string destination;

        /// <summary>
        /// 處理後的目錄
        /// </summary>
        private string dir;

        /// <summary>
        /// 檔案格式
        /// </summary>
        private string ext;

        /// <summary>
        /// 處理方式
        /// </summary>
        private string handler;

        /// <summary>
        /// 備份檔案的目錄
        /// </summary>
        private string location;

        /// <summary>
        /// 處理完是否刪除檔案
        /// </summary>
        private bool remove;

        /// <summary>
        /// 是否處理子目錄
        /// </summary>
        private bool subDirectory;

        /// <summary>
        /// 備份單位
        /// </summary>
        private string unit;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ext">檔案格式</param>
        /// <param name="location">備份檔案的目錄</param>
        /// <param name="subDirectory">是否處理子目錄</param>
        /// <param name="unit">備份單位</param>
        /// <param name="remove">處理完是否刪除檔案</param>
        /// <param name="handler">處理方式</param>
        /// <param name="destination">儲存目的地</param>
        /// <param name="dir">處理後的目錄</param>
        /// <param name="connectionString">資料庫連接字串</param>
        public Config(string ext, string location, bool subDirectory, string unit,
                      bool remove, string handler, string destination,
                      string dir, string connectionString)
        {
            this.ext = ext;
            this.location = location;
            this.subDirectory = subDirectory;
            this.unit = unit;
            this.remove = remove;
            this.handler = handler;
            this.destination = destination;
            this.dir = dir;
            this.connectionString = connectionString;
        }

        /// <summary>
        /// 資料庫連接字串
        /// </summary>
        public string ConnectionString
        {
            get { return this.connectionString; }
        }

        /// <summary>
        /// 儲存目的地
        /// </summary>
        public string Destination
        {
            get { return this.destination; }
        }

        /// <summary>
        /// 處理後的目錄
        /// </summary>
        public string Dir
        {
            get { return this.dir; }
        }

        /// <summary>
        /// 檔案格式
        /// </summary>
        public string Ext
        {
            get { return this.ext; }
        }

        /// <summary>
        /// 處理方式
        /// </summary>
        public string Handler
        {
            get { return this.handler; }
        }

        /// <summary>
        /// 備份檔案的目錄
        /// </summary>
        public string Location
        {
            get { return this.location; }
        }

        /// <summary>
        /// 處理完是否刪除檔案
        /// </summary>
        public bool Remove
        {
            get { return this.remove; }
        }

        /// <summary>
        /// 是否處理子目錄
        /// </summary>
        public bool SubDirectory
        {
            get { return this.subDirectory; }
        }

        /// <summary>
        /// 備份單位
        /// </summary>
        public string Unit
        {
            get { return this.unit; }
        }
    }
}