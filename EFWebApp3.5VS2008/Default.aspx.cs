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

namespace EFWebApp3._5VS2008to2010
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
            Model1Container mc = new Model1Container();
            System.Collections.Generic.List<MusicGenres> ls = mc.MusicGenres.ToList();
            for (int i = 0; i < ls.Count; i++)
            {
                Response.Write(ls[i].GenreName+"<br>");
            }
        }
    }
}
