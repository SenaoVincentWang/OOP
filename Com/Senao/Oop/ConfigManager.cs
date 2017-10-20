using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace Com.Senao.Oop
{
    /// <summary>
    /// 設定管理
    /// </summary>
    public class ConfigManager
    {
        /// <summary>
        /// 設定
        /// </summary>
        private List<Config> configs;

        public Config this[int index]
        {
            get
            {
                return configs[index];
            }
        }

        /// <summary>
        /// 筆數
        /// </summary>
        /// <returns>設定筆數</returns>
        public int Count()
        {
            return configs.Count;
        }

        public void ProcessConfigs()
        {
            JObject configData = JObject.Parse(File.ReadAllText("Config.json"));
            JArray configDataArray = (JArray)configData["configs"];
            this.configs = configDataArray.ToObject<List<Config>>();
        }
    }
}