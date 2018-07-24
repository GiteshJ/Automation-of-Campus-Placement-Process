using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace WebApplication5
{
    public partial class login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["authentication"]="employer_login";
        }
         protected void login_btn_Click(object sender, EventArgs e)
        {
            string con = "server=localhost;user id=root;password=root;database=placement_drive";




            string t = "select * from " + Session["authentication"].ToString() + " where user_id=@id and pswd=@psd";

            MySqlConnection dbcon = new MySqlConnection(con);
            dbcon.Open();

            MySqlCommand cdb = new MySqlCommand(t, dbcon);






            try
            {


                cdb.Parameters.AddWithValue("@id", int.Parse(user_id.Text));
                cdb.Parameters.AddWithValue("@psd", int.Parse(ps_wd.Text));
           




                MySqlDataReader r = cdb.ExecuteReader();
                if (r.Read())
                {
                    if (Session["authentication"].ToString()=="student_login")
                    {
                        Session["userid"] = user_id.Text;
                        Response.Redirect("student_login_first_page.aspx");
              
                    }
                    else if (Session["authentication"].ToString()=="employer_login")
                    {
                        Session["userid"] = user_id.Text;
                        Response.Redirect("employer_firstpage.aspx");
                    }
                    else if (Session["authentication"].ToString()=="college_login")
                    {
                        Session["userid"] = user_id.Text;
                        Response.Redirect("college_startup_page.aspx");
                    }


                }
                else
                {
                    //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(),"err_msg","alert('Dispatch assignment saved, but you forgot to click Confirm or Cancel!)');",true);
                    error_msg.Visible = true;
                    user_id.Text = "";
                    ps_wd.Text = "";

                }
                dbcon.Close();
            }
            catch (Exception)
            {
                user_id.Text = "";
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('PLEASE ENTER VALID DETAILS!');", true);
                //Response.Redirect("login_page.aspx");
               
            }
        }

         protected void home_btn_Click(object sender, EventArgs e)
         {
             Session["authentication"]="";
             Response.Redirect("home_page.aspx");
         }
    }
    
}