using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class college_startup_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fetch_details.Visible = false;
            type_list.Visible = false;
            company_list.Visible = false;
            GridView1.Visible = false;

        }

        protected void student_wise_details_Click(object sender, EventArgs e)
        {
            fetch_details.Visible = false;
            type_list.Visible = false;
            company_list.Visible = false;
            GridView1.Visible = true;
            GridView1.DataSourceID = "student_details";
            GridView1.DataBind();


        }

        protected void comapny_wise_details_Click(object sender, EventArgs e)
        {
            fetch_details.Visible = true;
            type_list.Visible = true;
            company_list.Visible = true;


        }

        protected void fetch_details_Click(object sender, EventArgs e)
        {
            if (type_list.SelectedValue == "1")
            {
                if (company_list.SelectedValue == "3")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "amazon_applied";
                    GridView1.DataBind();
                }
                if (company_list.SelectedValue == "2")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "bosch_applied";
                    GridView1.DataBind();
                }
                if (company_list.SelectedValue == "1")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "google_applied";
                    GridView1.DataBind();
                }
            }
            if (type_list.SelectedValue == "2")
            {
                if (company_list.SelectedValue == "3")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "amazon_apti_cleared";
                    GridView1.DataBind();
                }
                if (company_list.SelectedValue == "2")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "bosch_apti_cleared";
                    GridView1.DataBind();
                }
                if (company_list.SelectedValue == "1")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "google_apti_cleared";
                    GridView1.DataBind();
                }
            }
            if (type_list.SelectedValue == "3")
            {
                if (company_list.SelectedValue == "3")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "amazon_selected";
                    GridView1.DataBind();
                }
                if (company_list.SelectedValue == "2")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "bosch_selected";
                    GridView1.DataBind();
                }
                if (company_list.SelectedValue == "1")
                {
                    fetch_details.Visible = true;
                    type_list.Visible = true;
                    company_list.Visible = true;
                    GridView1.Visible = true;
                    GridView1.DataSourceID = "google_selected";
                    GridView1.DataBind();
                }
            }

      }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["userid"] = "";
            Session["company"] = "";
            Session["company_apti_cleared"] = "";
            Session["company_selected"] = "";
            Session["authentication"] = "";
            Response.Redirect("home_page.aspx");
        }

      

          
    }

        
    }
