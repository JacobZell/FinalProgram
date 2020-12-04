using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Configuration;


namespace FinalProject3.Webforms
{
    public partial class TopicsMaster : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (TopicGridView.SelectedRow != null)
                {
                    String id = (TopicGridView.SelectedRow.Cells[2].Text);
                    Response.Write(id);
                    Response.Redirect("Comment.aspx?id=" + id);
                    
                }
            }
            catch {
                Response.Write("Please Select a Topic");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TopicGridView.SelectedRow != null)
                {
                    String id = (TopicGridView.SelectedRow.Cells[2].Text);
            string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("Delete FROM Topic WHERE Id =" + id, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            int i = cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                Response.Write("Please Select a Topic");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TopicGridView.SelectedRow != null)
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
                }
            }
            catch
            {
                Response.Write("Please Select a Topic");
            }
        }
    }
}