using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace WebApplication5
{
    public partial class college_login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            string con = "server=localhost;user id=root;password=root;database=placement_drive";




            string t = "select * from college_login where user_id=@id and pswd=@psd";

            MySqlConnection dbcon = new MySqlConnection(con);
            dbcon.Open();

            MySqlCommand cdb = new MySqlCommand(t, dbcon);
            cdb.Parameters.AddWithValue("@id", int.Parse(user_id.Text));
            cdb.Parameters.AddWithValue("@psd", int.Parse(ps_wd.Text));



            MySqlDataReader r = cdb.ExecuteReader();
            if (r.Read())
            {
                Response.Redirect("home_page.aspx");

            }
            else
            {
                error_msg.Visible = true;
                user_id.Text = "";
                ps_wd.Text = "";

            }
            dbcon.Close();
        }
    }
}