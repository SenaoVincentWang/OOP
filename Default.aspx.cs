using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Senao.Oop;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConfigManager cfr = new ConfigManager();
        //cfr.ProcessConfigs();
        Response.Write(cfr.iProcessConfigs().ToString());
    }
}