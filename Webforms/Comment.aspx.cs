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

namespace FinalProject3
{
    public partial class Comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
                foreach (GridViewRow Row in GridView1.Rows) {

                int check = Int32.Parse(Row.Cells[2].Text);
                if (check == id)
                {
                    
                }
                else {
                    Row.Visible = false;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("Insert INTO Comment(Comment, TopicId) VALUES (@Comment, @TopicId)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Comment", TextBox1.Text);
                cmd.Parameters.AddWithValue("@TopicId", id);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                
                Response.Redirect("Comment.aspx?id=" + id);
            }
            else
            {
                Response.Write("Please Enter the New Comment");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView1.SelectedRow != null)
                {
                    String id = (GridView1.SelectedRow.Cells[3].Text);
                    string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);

                    SqlCommand cmd = new SqlCommand("Delete FROM Comment WHERE Id = " + id, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    Response.Redirect("Comment.aspx?id=" + id);
                }
            }
            catch
            {
                Response.Write("Please Select a Comment");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView1.SelectedRow != null)
                    if (TextBox1.Text != "")
                {
                    String id = (GridView1.SelectedRow.Cells[3].Text);
                    string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);

                    SqlCommand cmd = new SqlCommand("Update Comment SET Comment=@Comment WHERE Id =" + id, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Comment", TextBox1.Text);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    Response.Redirect("Comment.aspx?id=" + id);
                }
                else
                {
                    Response.Write("Please Enter the New Comment");
                }
            }
            catch
            {
                Response.Write("Please Select a Comment");
            }
        }
    }
}