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
    public partial class TopicsMaster : System.Web.UI.Page
    {
        bool i = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void TopicGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //test for selection changed not working
            i = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
  
            if (i == true)
            {
                String id = (TopicGridView.SelectedRow.Cells[2].Text);
                Response.Write(id);
                Response.Redirect("Comment.aspx?id=" + id);
            }
            else {
                Response.Write("Please Select a Topic");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (i == true)
            {
                String id = (TopicGridView.SelectedRow.Cells[2].Text);
                string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("Delete FROM Topic WHERE Id =" + id, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                int i = cmd.ExecuteNonQuery();
            }
            else
            {
                Response.Write("Please Select a Topic");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (i == true)
            {
                if (TextBox1.Text != "")
                {
                    String id = (TopicGridView.SelectedRow.Cells[2].Text);
                    String NewTopicName = TextBox1.Text;
                    string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);

                    SqlCommand cmd = new SqlCommand("Update Topic SET Topic=@Topic WHERE Id =" + id, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Topic", TextBox1.Text);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                }
                else
                {
                    Response.Write("Please Enter New Topic Name");
                }
            }
            else
            {
                Response.Write("Please Select a Topic");
            }
        }
    }
}