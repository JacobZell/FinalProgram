using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject3.Webforms
{
    public partial class HomeMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //(Page.Master.FindControl("LoginName1").Text) = Login1.UserName;
            //(Label)Page.Master.FindControl("lblUserName") = Login1.UserName;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateAccount.aspx");
        }
    }
}