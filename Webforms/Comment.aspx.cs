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
            }
            else
            {
                Response.Write("Please Enter the New Comment");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String f = GridView1.SelectedRow.Cells[3].Text;
            if (f != "")
            {
                    String id = (GridView1.SelectedRow.Cells[3].Text);
                    string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);

                    SqlCommand cmd = new SqlCommand("Delete FROM Comment WHERE Id = " + id, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                
            }
            else
            {
                Response.Write("Please Select a Comment");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String f = GridView1.SelectedRow.Cells[2].Text;
            if (f != "")
            {
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
                }
                else
                {
                    Response.Write("Please Enter the New Comment");
                }
            }
            else
            {
                Response.Write("Please Select a Comment");
            }
        }
    }
}