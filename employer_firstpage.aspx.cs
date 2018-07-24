using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
namespace WebApplication5
{
    public partial class employer_firstpage : System.Web.UI.Page

    {
        //static string con = "server=localhost;user id=root;password=root;database=placement_drive";
        //string t = "select * from student where id=@id";

        //MySqlConnection dbcon = new MySqlConnection(con);
       
        public static int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                
                GridView1.Visible = false;
                cut_off.Visible = false;
                cutoff.Visible = false;
                generate_btn.Visible = false;
                interview_id.Visible = false;
                interview_mark.Visible = false;
                update_btn.Visible = false;
                interviewmark.Visible = false;
                intervieid.Visible = false;
                Name.Visible = false;
                //error_msg.Visible = false;
                na_me.Visible = false;
                Branch.Visible = false;
                reset_selection.Visible = false;
                b_ranch.Visible = false;
                Email.Visible = false;
                e_mail.Visible = false;
                contact.Visible = false;
                c_ontact.Visible = false;
                avg__gpa.Visible = false;
                Avg_gpa.Visible = false;
                //Session["userid"] = "120401";
                //Session["company"] = "amazon_applied";
                //Session["company_apti_cleared"] = "amazon_apti_passed";
                //Session["company_selected"] = "amazon_selected_student";
                if (Session["company"]== null)
                {
                    Response.Redirect("home_page.aspx");
                }
                if (Session["company"].ToString() == "amazon_applied")
                {
                    Image1.ImageUrl = "~/Images/amazon-logo2-1920.png";
                }
                else if (Session["company"].ToString() == "google_applied")
                {
                    Image1.ImageUrl = "~/Images/Google.png";

                }
                else if (Session["company"].ToString() == "bosch_applied")
                {
                    Image1.ImageUrl = "~/Images/bosch-tools-logo.jpg";
                }
               

            }
            //error_msg.Visible = false;
            if (flag == 0)
            {
                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                //string t = "select * from student where id=@id";

                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();
                //string up = "update student set name=@name,marks=@marks where id=@id";
                string t = "select * from " + Session["company_apti_cleared"].ToString() + " ";
                MySqlCommand cdb = new MySqlCommand(t, dbcon);
                //cdb.Parameters.AddWithValue("@limit", int.Parse(cut_off.Text));
                //cdb.Parameters.AddWithValue("@name", textBox3.Text);
                //cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




                //string status_update1 = "update " + Session["company"].ToString() + "  set application_status='Selected' where enroll_number in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                //MySqlCommand cdb1 = new MySqlCommand(status_update1, dbcon);
                //string status1 = "Aptitude Cleared";
                //cdb1.Parameters.AddWithValue("@appli_status1", status1);

                //string status_update2 = "update " + Session["company"].ToString() + "  set application_status='Not selected' where enroll_number not in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                //MySqlCommand cdb2 = new MySqlCommand(status_update2, dbcon);
                //string status2 = "Aptitude Not Cleared";
                //cdb2.Parameters.AddWithValue("@appli_status2", status2);

                MySqlDataReader r = cdb.ExecuteReader();
                //int r1 = cdb1.ExecuteNonQuery();
                //int r2 = cdb2.ExecuteNonQuery();


                if (r.Read())
                {
                    //cut_off.Enabled = false;
                    //generate_btn.Enabled = false;
                    //error_msg.Visible = true;
                }
                else
                {
                    //cut_off.Enabled = true;
                    //generate_btn.Enabled = true;
                    //error_msg.Visible = false;
                }
                dbcon.Close();
 
            }
            else if (flag == 1)
            {
                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                //string t = "select * from student where id=@id";

                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();
                //string up = "update student set name=@name,marks=@marks where id=@id";
                string t = "select * from " + Session["company_selected"].ToString() + " ";
                MySqlCommand cdb = new MySqlCommand(t, dbcon);


                MySqlDataReader r = cdb.ExecuteReader();
                //int r1 = cdb1.ExecuteNonQuery();
                //int r2 = cdb2.ExecuteNonQuery();


                if (r.Read())
                {
                    //cut_off.Enabled = false;
                    //generate_btn.Enabled = false;
                   // error_msg.Visible = true;
                }
                else
                {
                    //cut_off.Enabled = true;
                    //generate_btn.Enabled = true;
                  //  error_msg.Visible = false;
                }
                dbcon.Close();
 
 
            }
        }

        protected void generate_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (flag == 1)
                {
                    string con = "server=localhost;user id=root;password=root;database=placement_drive";
                    //string t = "select * from student where id=@id";

                    MySqlConnection dbcon = new MySqlConnection(con);
                    dbcon.Open();
                    //string up = "update student set name=@name,marks=@marks where id=@id";
                    string transfer = "INSERT INTO " + Session["company_selected"].ToString() + "  (enroll_number, name, branch, contact, email, avg_gpa, resume, apti_marks ,interview_marks, final_marks) (select * from " + Session["company_apti_cleared"].ToString() + "  order by final_marks desc limit @limit) ";
                    MySqlCommand cdb = new MySqlCommand(transfer, dbcon);
                    cdb.Parameters.AddWithValue("@limit", int.Parse(cut_off.Text));
                    //cdb.Parameters.AddWithValue("@name", textBox3.Text);
                    //cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




                    string status_update1 = "update " + Session["company"].ToString() + "  set application_status='Selected' where enroll_number in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                    MySqlCommand cdb1 = new MySqlCommand(status_update1, dbcon);
                    //string status1 = "Aptitude Cleared";
                    //cdb1.Parameters.AddWithValue("@appli_status1", status1);

                    string status_update2 = "update " + Session["company"].ToString() + "  set application_status='Not selected' where enroll_number not in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                    MySqlCommand cdb2 = new MySqlCommand(status_update2, dbcon);
                    //string status2 = "Aptitude Not Cleared";
                    //cdb2.Parameters.AddWithValue("@appli_status2", status2);

                    int r = cdb.ExecuteNonQuery();
                    int r1 = cdb1.ExecuteNonQuery();
                    int r2 = cdb2.ExecuteNonQuery();


                    if (r != 0)
                    {
                        //cut_off.Enabled = false;
                        //generate_btn.Enabled =false;
                        //error_msg.Visible = true;
                    }
                    else
                    {
                        //cut_off.Enabled = true;
                        //generate_btn.Enabled = true;
                        //error_msg.Visible = false;


                    }
                    dbcon.Close();
                    flag = 1;
                    GridView1.Visible = true;
                    //GridView1.DataSourceID = "applicant_interview_list";
                    if (Session["company"].ToString() == "amazon_applied")
                    {
                        GridView1.DataSourceID = "applicant_interview_list";
                    }
                    else if (Session["company"].ToString() == "google_applied")
                    {
                        GridView1.DataSourceID = "google_interview";

                    }
                    else
                    {
                        GridView1.DataSourceID = "bosch_interview";
                    }
                    GridView1.DataBind();
                    cut_off.Visible = true;
                    cut_off.Text = "";
                    cutoff.Visible = true;
                    cutoff.Text = "Enter Number Of Candidates To Be Selected";
                    generate_btn.Visible = true;
                    enrollment_number.Visible = true;
                    enrollmentnumber.Visible = true;
                    interview_id.Visible = true;
                    interview_id.Text = "";
                    interview_mark.Text = "";
                    interview_mark.Visible = true;
                    update_btn.Visible = true;
                    interviewmark.Visible = true;
                    details_btn.Visible = true;
                    intervieid.Visible = true;
                    Name.Visible = false;

                    na_me.Visible = false;
                    Branch.Visible = false;

                    b_ranch.Visible = false;
                    Email.Visible = false;
                    e_mail.Visible = false;
                    contact.Visible = false;
                    c_ontact.Visible = false;
                    avg__gpa.Visible = false;
                    Avg_gpa.Visible = false;

                }
                else
                {
                    string con = "server=localhost;user id=root;password=root;database=placement_drive";
                    //string t = "select * from student where id=@id";

                    MySqlConnection dbcon = new MySqlConnection(con);
                    dbcon.Open();
                    //string up = "update student set name=@name,marks=@marks where id=@id";
                    string transfer = "INSERT INTO " + Session["company_apti_cleared"].ToString() + " (enroll_number, name, branch, contact, email, avg_gpa, resume, apti_marks) (SELECT enroll_number, name, branch, contact, email, avg_gpa, resume, apti_marks FROM " + Session["company"].ToString() + " where apti_marks>=@marks order by apti_marks desc) ";
                    MySqlCommand cdb = new MySqlCommand(transfer, dbcon);
                    cdb.Parameters.AddWithValue("@marks", int.Parse(cut_off.Text));
                    //cdb.Parameters.AddWithValue("@name", textBox3.Text);
                    //cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));
                    string status_update1 = "update " + Session["company"].ToString() + "  set application_status='Aptitude Cleared' where enroll_number in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                    MySqlCommand cdb1 = new MySqlCommand(status_update1, dbcon);
                    //string status1 = "Aptitude Cleared";
                    //cdb1.Parameters.AddWithValue("@appli_status1", status1);

                    string status_update2 = "update " + Session["company"].ToString() + "  set application_status='Not Selected' where enroll_number not in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                    MySqlCommand cdb2 = new MySqlCommand(status_update2, dbcon);
                    //string status2 = "Aptitude Not Cleared";
                    //cdb2.Parameters.AddWithValue("@appli_status2", status2);

                    int r = cdb.ExecuteNonQuery();
                    int r1 = cdb1.ExecuteNonQuery();
                    int r2 = cdb2.ExecuteNonQuery();
                    if (r != 0)
                    {
                        //cut_off.Enabled = false;
                        // generate_btn.Enabled = false;
                        // error_msg.Visible = true;
                    }
                    else
                    {
                        //cut_off.Enabled = true;
                        //generate_btn.Enabled = true;
                        //error_msg.Visible = false;
                    }
                    dbcon.Close();
                    flag = 0;
                    enrollment_number.Visible = true;
                    enrollmentnumber.Visible = true;
                    GridView1.Visible = true;
                    if (Session["company"].ToString() == "amazon_applied")
                    {
                        GridView1.DataSourceID = "SqlDataSource2";
                    }
                    else if (Session["company"].ToString() == "google_applied")
                    {
                        GridView1.DataSourceID = "google_applicant";

                    }
                    else
                    {
                        GridView1.DataSourceID = "bosch_applicant";
                    }
                    cut_off.Visible = true;
                    cutoff.Visible = true;
                    cutoff.Text = "Enter Aptitude Test Cutoff";
                    generate_btn.Visible = true;
                    cut_off.Text = "";
                    details_btn.Visible = true;
                    Name.Visible = false;

                    na_me.Visible = false;
                    Branch.Visible = false;

                    b_ranch.Visible = false;
                    Email.Visible = false;
                    e_mail.Visible = false;
                    contact.Visible = false;
                    c_ontact.Visible = false;
                    avg__gpa.Visible = false;
                    Avg_gpa.Visible = false;
                }
            }
            catch (Exception)
            {
                cut_off.Text = "";
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('PLEASE ENTER VALID DATA OR TRY RE-SETTING LAST SELECTION');", true);

            }
        }


        protected void list_applicant_Click(object sender, EventArgs e)
        {
            flag = 0;
            GridView1.Visible = true;
            enrollment_number.Visible = true;
            enrollmentnumber.Visible = true;
            details_btn.Visible = true;
            if (Session["company"].ToString() == "amazon_applied")
            {
                GridView1.DataSourceID = "SqlDataSource2";
            }
            else if (Session["company"].ToString() == "google_applied")
            {
                GridView1.DataSourceID = "google_applicant";

            }
            else 
            {
                GridView1.DataSourceID = "bosch_applicant";
            }
            cut_off.Visible = true;
            cutoff.Visible = true;
            cutoff.Text = "Enter Aptitude Test Cutoff";
            generate_btn.Visible = true;
            cut_off.Text = "";
            Name.Visible = false;
            enrollment_number.Text = "";
            na_me.Visible = false;
            Branch.Visible = false;
            reset_selection.Visible = true;
            b_ranch.Visible = false;
            Email.Visible = false;
            e_mail.Visible = false;
            contact.Visible = false;
            c_ontact.Visible = false;
            avg__gpa.Visible = false;
            Avg_gpa.Visible = false;
            intervieid.Visible = false;
            interview_id.Visible = false;
            interview_mark.Visible = false;
            interviewmark.Visible = false;
            update_btn.Visible = false;
        }
       
        protected void applicant_interview_Click(object sender, EventArgs e)
        {
            flag = 1;
            enrollment_number.Visible = true;
            enrollmentnumber.Visible = true;
            GridView1.Visible = true;
            if (Session["company"].ToString() == "amazon_applied")
            {
                GridView1.DataSourceID = "applicant_interview_list";
            }
            else if (Session["company"].ToString() == "google_applied")
            {
                GridView1.DataSourceID = "google_interview";

            }
            else
            {
                GridView1.DataSourceID = "bosch_interview";
            }
            GridView1.DataBind();
            cut_off.Visible = true;
            cut_off.Text = "";
            cutoff.Visible = true;
            cutoff.Text = "Enter Number Of Candidates To Be Selected";
            generate_btn.Visible = true;
            details_btn.Visible = true;
            interview_id.Visible = true;
            interview_id.Text = "";
            interview_mark.Text = "";
            interview_mark.Visible = true;
            update_btn.Visible = true;
            interviewmark.Visible = true;
            intervieid.Visible = true;
            Name.Visible = false;
            reset_selection.Visible = true;
            na_me.Visible = false;
            Branch.Visible = false;
            enrollment_number.Text = "";
            b_ranch.Visible = false;
            Email.Visible = false;
            e_mail.Visible = false;
            contact.Visible = false;
            c_ontact.Visible = false;
            avg__gpa.Visible = false;
            Avg_gpa.Visible = false;
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                //string t = "select * from student where id=@id";

                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();
                //string up = "update student set name=@name,marks=@marks where id=@id";
                string transfer = "update " + Session["company_apti_cleared"].ToString() + "  set interview_marks=@marks, final_marks=(40*apti_marks+60*@marks) where enroll_number=@id ";
                MySqlCommand cdb = new MySqlCommand(transfer, dbcon);
                cdb.Parameters.AddWithValue("@id", int.Parse(interview_id.Text));
                cdb.Parameters.AddWithValue("@marks", int.Parse(interview_mark.Text));
                //cdb.Parameters.AddWithValue("@name", textBox3.Text);
                //cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




                int r = cdb.ExecuteNonQuery();

                if (r != 0)
                {
                    //MessageBox.Show("OK");
                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
                flag = 1;
                GridView1.Visible = true;
                GridView1.DataSourceID = "applicant_interview_list";
                GridView1.DataBind();
                cut_off.Visible = true;
                cut_off.Text = "";
                cutoff.Visible = true;
                cutoff.Text = "Enter Number Of Candidates To Be Selected";
                generate_btn.Visible = true;
                enrollment_number.Visible = true;
                enrollmentnumber.Visible = true;
                interview_id.Visible = true;
                interview_id.Text = "";
                interview_mark.Text = "";
                interview_mark.Visible = true;
                update_btn.Visible = true;
                interviewmark.Visible = true;
                intervieid.Visible = true;
                details_btn.Visible = true;
                Name.Visible = false;

                na_me.Visible = false;
                Branch.Visible = false;

                b_ranch.Visible = false;
                Email.Visible = false;
                e_mail.Visible = false;
                contact.Visible = false;
                c_ontact.Visible = false;
                avg__gpa.Visible = false;
                Avg_gpa.Visible = false;
            }
            catch (Exception)
            {
                interview_id.Text = "";
                interview_mark.Text = "";
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('PLEASE ENTER VALID DETAILS!');", true);

            }
        }

        protected void selected_applicant_list_Click(object sender, EventArgs e)
        {
            enrollment_number.Visible = true;
            enrollmentnumber.Visible = true;
            details_btn.Visible = true;
            GridView1.Visible = true;
            //GridView1.DataSourceID = "selected_list";
            if (Session["company"].ToString() == "amazon_applied")
            {
                GridView1.DataSourceID = "selected_list";
            }
            else if (Session["company"].ToString() == "google_applied")
            {
                GridView1.DataSourceID = "google_select";

            }
            else
            {
                GridView1.DataSourceID = "bosch_select";
            }
            GridView1.DataBind();
            Name.Visible = false;
            enrollment_number.Text = "";
            na_me.Visible = false;
            Branch.Visible = false;
            reset_selection.Visible = false;
            b_ranch.Visible = false;
            Email.Visible = false;
            e_mail.Visible = false;
            contact.Visible = false;
            c_ontact.Visible = false;
            avg__gpa.Visible = false;
            Avg_gpa.Visible = false;
            intervieid.Visible = false;
            interview_id.Visible = false;
            interview_mark.Visible = false;
            interviewmark.Visible = false;
            update_btn.Visible = false;
            cut_off.Visible = false;
            cutoff.Visible = false;
            generate_btn.Visible = false;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "download")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string url = GridView1.Rows[index].Cells[1].Text;
                //System.IO.FileInfo file = new System.IO.FileInfo(url);
                string ext = ".pdf";
                url = string.Concat(url, ext);
                Response.Clear();
                Response.ContentType = "application/octect-Stream";
                Response.AppendHeader("content-disposition", "filename=" + url);
                Response.TransmitFile(Server.MapPath("~/amazon/") + url);
                Response.End();

            }
        }

        protected void details_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "server=localhost;user id=root;password=root;database=placement_drive";




                string t = "select * from " + Session["company"].ToString() + "  where enroll_number=@id";

                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();

                MySqlCommand cdb = new MySqlCommand(t, dbcon);
                cdb.Parameters.AddWithValue("@id", int.Parse(enrollment_number.Text));
                // cdb.Parameters.AddWithValue("@name", textBox3.Text);
                // cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




                MySqlDataReader r = cdb.ExecuteReader();
                if (r.Read())
                {
                    Name.Visible = true;

                    na_me.Visible = true;
                    Branch.Visible = true;

                    b_ranch.Visible = true;
                    Email.Visible = true;
                    e_mail.Visible = true;
                    contact.Visible = true;
                    c_ontact.Visible = true;
                    avg__gpa.Visible = true;
                    Avg_gpa.Visible = true;


                    na_me.Text = r.GetValue(1).ToString();
                    b_ranch.Text = r.GetValue(2).ToString();
                    c_ontact.Text = r.GetValue(3).ToString();
                    e_mail.Text = r.GetValue(4).ToString();
                    avg__gpa.Text = r.GetValue(5).ToString();

                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
            }
            catch (Exception)
            {
                enrollment_number.Text = "";
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "err_msg", "alert('PLEASE ENTER VALID ENROLLMENT NUMBER');", true);

            }
               
        }

        protected void reset_selection_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                string status_update1 = "update " + Session["company"].ToString() + "  set application_status='Applied' where enroll_number in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();
                MySqlCommand cdb1 = new MySqlCommand(status_update1, dbcon);
                //string status1 = "Aptitude Cleared";
                //cdb1.Parameters.AddWithValue("@appli_status1", status1);

                string status_update2 = "update " + Session["company"].ToString() + "  set application_status='Applied' where enroll_number not in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                MySqlCommand cdb2 = new MySqlCommand(status_update2, dbcon);
                //string status2 = "Aptitude Not Cleared";
                //cdb2.Parameters.AddWithValue("@appli_status2", status2);

                //int r = cdb.ExecuteNonQuery();
                int r1 = cdb1.ExecuteNonQuery();
                int r2 = cdb2.ExecuteNonQuery();
                if (r1 != 0)
                {
                    //MessageBox.Show("OK");
                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
                string t = "delete from " + Session["company_apti_cleared"].ToString() + " ";
                //MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();

                MySqlCommand cdb = new MySqlCommand(t, dbcon);
                //cdb.Parameters.AddWithValue("@id", (Session["userid"]));
                //cdb.Parameters.AddWithValue("@marks", marks);
                int r = cdb.ExecuteNonQuery();
                if (r != 0)
                {
                    //cut_off.Enabled = true;
                    //.Enabled = true;
                    //.Visible = false;
                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();

                //string con = "server=localhost;user id=root;password=root;database=placement_drive";
                //string t = "select * from student where id=@id";

                //MySqlConnection dbcon = new MySqlConnection(con);
               
                //string up = "update student set name=@name,marks=@marks where id=@id";
                //string transfer = "INSERT INTO " + Session["company_apti_cleared"].ToString() + " (enroll_number, name, branch, contact, email, avg_gpa, resume, apti_marks) (SELECT enroll_number, name, branch, contact, email, avg_gpa, resume, apti_marks FROM " + Session["company"].ToString() + " where apti_marks>=@marks order by apti_marks desc) ";
               // MySqlCommand cdb = new MySqlCommand(transfer, dbcon);
               // cdb.Parameters.AddWithValue("@marks", int.Parse(cut_off.Text));
                //cdb.Parameters.AddWithValue("@name", textBox3.Text);
                //cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));
                GridView1.Visible = true;
                //GridView1.DataSourceID = "applicant_interview_list";
                if (Session["company"].ToString() == "amazon_applied")
                {
                    GridView1.DataSourceID = "SqlDataSource2";
                }
                else if (Session["company"].ToString() == "google_applied")
                {
                    GridView1.DataSourceID = "google_applicant";

                }
                else
                {
                    GridView1.DataSourceID = "bosch_applicant";
                }
                















            }
            else
            {
                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();
                //string up = "update student set name=@name,marks=@marks where id=@id";
                //string transfer = "INSERT INTO " + Session["company_selected"].ToString() + "  (enroll_number, name, branch, contact, email, avg_gpa, resume, apti_marks ,interview_marks, final_marks) (select * from " + Session["company_apti_cleared"].ToString() + "  order by final_marks desc limit @limit) ";
                //MySqlCommand cdb = new MySqlCommand(transfer, dbcon);
               // cdb.Parameters.AddWithValue("@limit", int.Parse(cut_off.Text));
                //cdb.Parameters.AddWithValue("@name", textBox3.Text);
                //cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




                string status_update1 = "update " + Session["company"].ToString() + "  set application_status='Aptitude Cleared' where enroll_number in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                MySqlCommand cdb1 = new MySqlCommand(status_update1, dbcon);
                //string status1 = "Aptitude Cleared";
                //cdb1.Parameters.AddWithValue("@appli_status1", status1);

                //string status_update2 = "update " + Session["company"].ToString() + "  set application_status='Aptitude Cleared' where enroll_number not in (Select enroll_number from " + Session["company_apti_cleared"].ToString() + ")";
                //MySqlCommand cdb2 = new MySqlCommand(status_update2, dbcon);
                //string status2 = "Aptitude Not Cleared";
                //cdb2.Parameters.AddWithValue("@appli_status2", status2);

                //int r = cdb.ExecuteNonQuery();
                int r1 = cdb1.ExecuteNonQuery();
                //int r2 = cdb2.ExecuteNonQuery();


                if (r1 != 0)
                {
                    //MessageBox.Show("OK");
                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
                
                
                string t = "delete from " + Session["company_selected"].ToString() + " ";
                //MySqlConnection dbcon = new MySqlConnection(con);
                
                
                
                
                
                
                dbcon.Open();

                MySqlCommand cdb = new MySqlCommand(t, dbcon);
                //cdb.Parameters.AddWithValue("@id", (Session["userid"]));
                //cdb.Parameters.AddWithValue("@marks", marks);
                int r = cdb.ExecuteNonQuery();
                if (r != 0)
                {
                    //cut_off.Enabled = true;
//generate_btn.Enabled = true;
                    //error_msg.Visible = false;
                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
                GridView1.Visible = true;
                if (Session["company"].ToString() == "amazon_applied")
                {
                    GridView1.DataSourceID = "applicant_interview_list";
                }
                else if (Session["company"].ToString() == "google_applied")
                {
                    GridView1.DataSourceID = "google_interview";

                }
                else
                {
                    GridView1.DataSourceID = "bosch_interview";
                }
                
 
            }

        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["userid"] = "";
            Session["company"] = "";
            Session["company_apti_cleared"] = "";
            Session["company_selected"] = "";
            Session["authentication"]="";
            Response.Redirect("home_page.aspx");
                
        }

        
        }

       

        

       

       
        

       

        
       

        

        
        }

       


        

       

   