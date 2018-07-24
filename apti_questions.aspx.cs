using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace WebApplication5
{
    public partial class apti_questions : System.Web.UI.Page
    {
        public static int marks;
        public static int question_count;
        public static string correct_answer;
        public static string given_answer;
        public static string qn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                question_box.Visible = false;
                option_list.Visible = false;
                question_no_indicator.Visible = false;
                start_submit_btn.Text = "START TEST";
                marks = 0;
                question_count = -1;
                //Session["userid"] = "130401";
                //Session["company"] = "amazon_applied";
            }
        }

        protected void start_submit_btn_Click(object sender, EventArgs e)
        {
            start_submit_btn.Text = "Click to submit";
            if (question_count == -1)
            {
                question_count += 2 ;
                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                string t = "select * from apti_questions order by rand() limit 1";
                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();

                MySqlCommand cdb = new MySqlCommand(t, dbcon);
                //cdb.Parameters.AddWithValue("@id", Session["userid"]);
                // cdb.Parameters.AddWithValue("@name", textBox3.Text);
                // cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




                MySqlDataReader r = cdb.ExecuteReader();
                if (r.Read())
                {
                    question_box.Visible = true;
                    option_list.Visible = true;
                    question_no_indicator.Visible = true;
                    question_box.Text = r.GetValue(1).ToString();
                    string qc = (question_count).ToString();
                    string qci = string.Concat("Question ",qc, " of 5");
                    question_no_indicator.Text = qci;
                    //option_list.Items.RemoveAt(0);
                    //option_list.Items.RemoveAt(1);
                    //option_list.Items.RemoveAt(2);

                    //option_list.Items.RemoveAt(3);
                    option_list.Items.Add(new ListItem(r.GetValue(2).ToString(), "1"));
                    option_list.Items.Add(new ListItem(r.GetValue(3).ToString(), "2"));
                    option_list.Items.Add(new ListItem(r.GetValue(4).ToString(), "3"));
                    option_list.Items.Add(new ListItem(r.GetValue(5).ToString(), "4"));

                    correct_answer =(r.GetValue(6).ToString());
                    //given_answer = option_list.SelectedItem.Value;
                    //string t1 = "insert into apti_question_posted (question_number) select question_number fron apti_questions where question_number=@qn";
                    //MySqlConnection dbcon = new MySqlConnection(con);
                    //dbcon.Open();

                    //MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
                    //cdb1.Parameters.AddWithValue("@qn", r.GetValue(0).ToString());

                    //int r1 = cdb1.ExecuteNonQuery();
                    qn = r.GetValue(0).ToString();

                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
                string t1 = "insert into apti_question_posted (question_number) select question_number from apti_questions where question_number=@qn";
                //MySqlConnection dbcon = new MySqlConnection(con);
                //dbcon.Open();
                dbcon.Open();
                MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
                cdb1.Parameters.AddWithValue("@qn", int.Parse(qn));

                int r1 = cdb1.ExecuteNonQuery();
                if (r1 != 0)
                {

                }
                else
                {
 
                }
                dbcon.Close();
                //int r1 = cdb1.ExecuteNonQuery();

               
 
            }
            else if (question_count >= 5)
            {

                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                string t = "update " + Session["company"].ToString() + " set apti_marks=@marks where enroll_number=@id";
                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();

                MySqlCommand cdb = new MySqlCommand(t, dbcon);
                cdb.Parameters.AddWithValue("@id", (Session["userid"]));
                cdb.Parameters.AddWithValue("@marks", marks);
                int r = cdb.ExecuteNonQuery();
                if (r != 0)
                {
                    //textBox3.Text = r.GetValue(1).ToString();
                    //textBox2.Text = r.GetValue(2).ToString();

                }
                else
                {
                    //MessageBox.Show("error");
                }
                string t1 = "delete from apti_question_posted";

                MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
                //cdb.Parameters.AddWithValue("@id", (Session["userid"]));
                //cdb.Parameters.AddWithValue("@marks", marks);
                int r1 = cdb1.ExecuteNonQuery();
                if (r1 != 0)
                {
                    

                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
                Response.Redirect("student_login_first_page.aspx");


            }
            else
            {

                if (option_list.SelectedValue != null)
                {
                    given_answer = option_list.SelectedValue;
                    if (given_answer == correct_answer)
                    {
                        marks += 1;

                    }
                }
                question_count += 1;
                string con = "server=localhost;user id=root;password=root;database=placement_drive";
                string t = "select * from apti_questions where question_number not in (select question_number from apti_question_posted) order by rand() limit 1";
                MySqlConnection dbcon = new MySqlConnection(con);
                dbcon.Open();

                MySqlCommand cdb = new MySqlCommand(t, dbcon);
                //cdb.Parameters.AddWithValue("@id", Session["userid"]);
                // cdb.Parameters.AddWithValue("@name", textBox3.Text);
                // cdb.Parameters.AddWithValue("@marks", int.Parse(textBox2.Text));




                MySqlDataReader r = cdb.ExecuteReader();
                if (r.Read())
                {
                    question_box.Visible = true;
                    option_list.Visible = true;
                    question_no_indicator.Visible = true;
                    question_box.Text = r.GetValue(1).ToString();
                    string qc = (question_count).ToString();
                    string qci = string.Concat("Question ", qc, " of 5");
                    question_no_indicator.Text = qci;
                    //option_list.Items.RemoveAt(0);
                    //option_list.Items.RemoveAt(1);
                    //option_list.Items.RemoveAt(2);
                    option_list.Items.Clear();
                    //option_list.Items.RemoveAt(3);
                    option_list.Items.Add(new ListItem(r.GetValue(2).ToString(), "1"));
                    option_list.Items.Add(new ListItem(r.GetValue(3).ToString(), "2"));
                    option_list.Items.Add(new ListItem(r.GetValue(4).ToString(), "3"));
                    option_list.Items.Add(new ListItem(r.GetValue(5).ToString(), "4"));

                    correct_answer = (r.GetValue(6).ToString());
                    //string t1 = "insert into apti_question_posted (question_number) select question_number fron apti_questions where question_number=@qn";
                    //MySqlConnection dbcon = new MySqlConnection(con);
                    //dbcon.Open();

                    //MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
                    qn = r.GetValue(0).ToString();

                    //int r1 = cdb1.ExecuteNonQuery();


                }
                else
                {
                    //MessageBox.Show("error");
                }
                dbcon.Close();
                string t1 = "insert into apti_question_posted (question_number) select question_number from apti_questions where question_number=@qn";
                //MySqlConnection dbcon = new MySqlConnection(con);
                //dbcon.Open();
                dbcon.Open();
                MySqlCommand cdb1 = new MySqlCommand(t1, dbcon);
                cdb1.Parameters.AddWithValue("@qn", int.Parse(qn));

                int r1 = cdb1.ExecuteNonQuery();
                if (r1 != 0)
                {

                }
                else
                {

                }
                dbcon.Close();

 
            }
        }

        


    }
}