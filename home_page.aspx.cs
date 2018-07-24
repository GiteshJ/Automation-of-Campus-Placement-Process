using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void student_login_Click(object sender, EventArgs e)
        {
            Session["authentication"] = "student_login";
            Response.Redirect("login_page.aspx");
        }

        protected void employer_login_Click(object sender, EventArgs e)
        {
            Session["authentication"] = "employer_login";
            Response.Redirect("employer_pre_login_page.aspx");
        }

        protected void college_login_Click(object sender, EventArgs e)
        {
            Session["authentication"] = "college_login";
            Response.Redirect("login_page.aspx");
        }

        

       

        

        
    }
}