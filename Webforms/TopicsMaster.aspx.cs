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

        protected void TopicGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //checks if there is a row selected
                if (TopicGridView.SelectedRow != null)
                {
                    //grabs Topic id and goes to comment page bringing Topic id with
                    String id = (TopicGridView.SelectedRow.Cells[2].Text);
                    Response.Redirect("Comment.aspx?id=" + id);

                }
            }
            catch
            {
                //if user does not select a topic they are asked to
                Response.Write("Please Select a Topic");
            }
        }
    }
}