using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace FinalProject3.Webforms
{
    public partial class CreateTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TopicNametxt.Text != "")
            {
                string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("Insert INTO Topic(Topic) VALUES (@Topic)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Topic", TopicNametxt.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery();
            }
            else {
                Response.Write("Please enter a Topic Name");
            }
        }
    }
}