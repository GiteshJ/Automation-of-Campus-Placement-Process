using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace WebApplication5
{
    public partial class student_login_second_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["userid"] = "130401";
            //Session["company"] = "amazon_applied";
            Session["lastdate"] = "Last Date For Test : 20-07-2016";
            Session["interviewdate"]="Reach Your Campus on 27-07-2017 by 9:00 AM For Interview";
            if (Session["company"] == null)
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
            else
            {
                Image1.ImageUrl = "~/Images/bosch-tools-logo.jpg";
            }
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
            
            string con = "server=localhost;user id=root;password=root;database=placement_drive";




            string t = "select * from student_details where enroll_number=@id";
            string t1 = "select * from "+Session["company"].ToString()+" where enroll_number=@id";
            MySqlConnection dbcon = new MySqlConnection(con);
            dbcon.Open();
            MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
           // MySqlCommand cdb = new MySqlCommand(t, dbcon);
            cdb1.Parameters.AddWithValue("@id",(Session["userid"]));
           // cdb.Parameters.AddWithValue("@name", textBox3.Text);
           // cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




            MySqlDataReader r1 = cdb1.ExecuteReader();
            
            if (r1.Read())
            {
                apply.Visible = false;
                FileUpload1.Visible = false;
                application_status.Text = r1.GetValue(8).ToString();
                int marks = int.Parse(r1.GetValue(7).ToString());
                if (marks == -1)
                {
                    test_btn.Visible = true;
                    last_date.Visible = true;
                    last_date.Text = Session["lastdate"].ToString();
                }
                else if (r1.GetValue(8).ToString() == "Aptitude Cleared")
                {
                    interview_date.Visible = true;
                    interview_date.Text= Session["interviewdate"].ToString();
                }

            }
            else
            {
                application_status.Text = "Not Applied";
                //MessageBox.Show("error");
            }
            dbcon.Close();
            dbcon.Open();
           // MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
            MySqlCommand cdb = new MySqlCommand(t, dbcon);
            cdb.Parameters.AddWithValue("@id", (Session["userid"]));
            // cdb.Parameters.AddWithValue("@name", textBox3.Text);
            // cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




            MySqlDataReader r = cdb.ExecuteReader();
            if (r.Read())
            {
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

        protected void apply_Click(object sender, EventArgs e)
        {


            
            
            
            
            
            
            
            
            
            
            
            
            
            
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExtension.ToLower() != ".pdf")
                {
                    //string errorText = "rwrwrw";
                    file_upload_error.Visible = true;

                    file_upload_error.Text = "Only pdf files allowed";
                    
                    //Response.Write(@"<SCRIPT LANGUAGE=""JavaScript"">alert('" + errorText + "')</SCRIPT>");

                }
                else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize > 1048576)
                    {
                        file_upload_error.Visible = true;
                        file_upload_error.Text = "file size max 1MB";
                       

                    }
                    else
                    {
                        string fil = Convert.ToString(Session["userid"]);
                        string ext = ".pdf";
                        fil = string.Concat(fil, ext);
                        FileUpload1.SaveAs(Server.MapPath("~/amazon/" + fil));
                        file_upload_error.Text = "file uploaded";
                        
                        string con = "server=localhost;user id=root;password=root;database=placement_drive";
                        string t = "insert into " + Session["company"].ToString() + "  (enroll_number, name, branch, contact, email, avg_gpa) SELECT enroll_number, name, branch, contact, email, avg_gpa FROM student_details WHERE enroll_number=@id ";
                       
                        MySqlConnection dbcon = new MySqlConnection(con);
                        dbcon.Open();
                        MySqlCommand cdb = new MySqlCommand(t, dbcon);
                        // MySqlCommand cdb = new MySqlCommand(t, dbcon);
                        cdb.Parameters.AddWithValue("@id", (Session["userid"]));
                        
                        // cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));
                       // MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
                        //cdb1.Parameters.AddWithValue("@id", (Session["userid"]));
                        //cdb1.Parameters.AddWithValue("@resume", fil);

                        int r = cdb.ExecuteNonQuery();

                        if (r != 0)
                        {
                            apply.Visible = false;
                            FileUpload1.Visible = false;
                            application_status.Text = "Applied";
                            test_btn.Visible = true;
                            last_date.Visible = true;
                            last_date.Text = Session["lastdate"].ToString();

                        }
                        else
                        {
                            application_status.Text = "Not Applied";
                            //MessageBox.Show("error");
                        }
                        dbcon.Close();
                        dbcon.Open();
                        string t1 = "update " + Session["company"].ToString() + "  set resume=@resume where enroll_number=@id";
                        MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
                       
                        cdb1.Parameters.AddWithValue("@id", (Session["userid"]));

                       
                        cdb1.Parameters.AddWithValue("@resume", fil);

                        int r1 = cdb1.ExecuteNonQuery();

                        if (r1 != 0)
                        {
                            apply.Visible = false;
                            FileUpload1.Visible = false;
                            application_status.Text = "Applied";

                        }
                        else
                        {
                            application_status.Text = "Not Applied";
                            //MessageBox.Show("error");
                        }
                        dbcon.Close();
            
                        file_upload_error.Visible=false;

                    }
                }
            }
            else
            {
                file_upload_error.Visible = true;

                file_upload_error.Text = "select a file to upload";
                
            }
        }

        protected void home_btn_Click(object sender, EventArgs e)
        {
            Session["company"] = "";
            Session["company_apti_cleared"] = "";
            Session["company_selected"] = "";
            Response.Redirect("student_login_first_page.aspx");
        }

        protected void test_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("apti_questions.aspx");
        }

       
        }
    }
