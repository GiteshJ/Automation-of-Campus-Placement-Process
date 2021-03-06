﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class student_login_first_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void amazon_Click(object sender, ImageClickEventArgs e)
        {
            Session["company"] = "amazon_applied";
            Session["company_apti_cleared"] = "amazon_apti_passed";
            Session["company_selected"] = "amazon_selected_student";
            Response.Redirect("student_login_second_page.aspx");
        }

        protected void google_Click(object sender, ImageClickEventArgs e)
        {
            Session["company"] = "google_applied";
            Session["company_apti_cleared"] = "google_apti_passed";
            Session["company_selected"] = "google_selected_student";
            Response.Redirect("student_login_second_page.aspx");
        }

        protected void bosch_Click(object sender, ImageClickEventArgs e)
        {
            Session["company"] = "bosch_applied";
            Session["company_apti_cleared"] = "bosch_apti_passed";
            Session["company_selected"] = "bosch_selected_student";
            Response.Redirect("student_login_second_page.aspx");
        }

        protected void logout_btn_Click(object sender, EventArgs e)
        {
            Session["userid"]="";
            Session["company"] = "";
            Session["company_apti_cleared"] = "";
            Session["company_selected"] = "";
            Session["authentication"]="";
            Response.Redirect("home_page.aspx");
        }

       
    }
}