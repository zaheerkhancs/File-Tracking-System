using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using IOM.IECFMS.DAL;

namespace FMS
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FMSDB objdb = new FMSDB();
            
            DataTable dt = objdb.tblCurrencyCollection.GetAllAsDataTable();
            GridView1.DataSource = dt;
            GridView1.DataBind();
            objdb.Dispose();
            objdb.Close();
        }
    }
}
