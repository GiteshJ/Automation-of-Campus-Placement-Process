<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employer_firstpage.aspx.cs" Inherits="WebApplication5.employer_firstpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        @import url('https://fonts.googleapis.com/css?family=Cinzel');
         @import url("https://fonts.googleapis.com/css?family=Exo");
         body {
  
  background-image:url('Images/1.jpg');
}
        .button {
    background-color: #4CAF50; /* Green */
    border: none;
    color: white;
    padding: 16px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 20px;
    margin: 4px 2px;
    font-family: 'Cinzel', serif;
    -webkit-transition-duration: 0.4s; /* Safari */
    transition-duration: 0.4s;
    cursor: pointer;
}
     
.button1 {
    background-color: white; 
    color: black; 
    border: 2px solid #4CAF50;
}

.button1:hover {
    background-color: #4CAF50;
    color: white;
}
.cutoff_field {
            border:medium dashed #526052;
            color:#707c70;
            font-family: 'Exo', sans-serif;
            font-size: 30px;
            margin-top:20px;
        }
        .login_field {
             border:medium dashed #526052;
            color:#707c70;
            font-family: 'Exo', sans-serif;
            font-size: 30px;
            margin-top:20px;

        }

.button4 {
    background-color: white;
    color: black;
    border: 2px solid #526052;
}

.button4:hover {background-color: #526052;
                color:white;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="234px" Width="100%" />
    
    </div>
        <p>
            &nbsp; &nbsp; 
            <asp:Button ID="logout" runat="server" CssClass="button button1" Text="Logout" OnClick="logout_Click"  />
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="list_applicant" CssClass="button button1" runat="server" Text="List Of Applicants" OnClick="list_applicant_Click"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="applicant_interview" CssClass="button button1" runat="server" Text="Applicants Interview" OnClick="applicant_interview_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="selected_applicant_list" CssClass="button button1" runat="server" Text="Selected Applicants" OnClick="selected_applicant_list_Click"  />
        </p>
        <div style="margin-left: 200px">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" DataSourceID="SqlDataSource2" Height="16px"  Width="953px" ForeColor="Black" GridLines="Horizontal" OnRowCommand="GridView1_RowCommand" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
                <Columns>
                    <asp:ButtonField CommandName="download" HeaderText="Resume" ShowHeader="True" Text="Download" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="bosch_select" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM bosch_selected_student"></asp:SqlDataSource>
            <asp:SqlDataSource ID="bosch_interview" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM bosch_apti_passed"></asp:SqlDataSource>
            <asp:SqlDataSource ID="bosch_applicant" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM bosch_applied"></asp:SqlDataSource>
            <asp:SqlDataSource ID="google_select" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM google_selected_student"></asp:SqlDataSource>
            <asp:SqlDataSource ID="google_interview" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM google_apti_passed"></asp:SqlDataSource>
            <asp:SqlDataSource ID="google_applicant" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM google_applied"></asp:SqlDataSource>
            <asp:SqlDataSource ID="selected_list" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM amazon_selected_student"></asp:SqlDataSource>
            <asp:SqlDataSource ID="applicant_interview_list" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM amazon_apti_passed"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT * FROM amazon_applied"></asp:SqlDataSource>
        </div>
       





        <div style="margin-left: 40px">
        <div style="margin-left: 165px">
        <asp:Label ID="enrollmentnumber" runat="server" CssClass="login_field" Text="Enrollment Number" Visible="False" ForeColor="White" BorderStyle="None"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="enrollment_number" CssClass="login_field" runat="server" Visible="False" ></asp:TextBox>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Button ID="details_btn" runat="server" CssClass="button button4" Text="Fetch Details" OnClick="details_btn_Click" Visible="False"  />
        </div>
        
            <div style="margin-left: 165px;">
             <asp:Label ID="Name" runat="server" CssClass="login_field" Text="NAME" Visible="False" BorderStyle="None" ForeColor="White"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="na_me" CssClass="login_field" runat="server" Visible="False"></asp:TextBox>
             

             
             </div>
            
         <div style="margin-left: 165px;">
             <asp:Label ID="Branch" runat="server" CssClass="login_field" Text="BRANCH" Visible="False" BorderStyle="None" ForeColor="White"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="b_ranch" CssClass="login_field" runat="server" Visible="False"></asp:TextBox>
            

             
             </div>
            <div style="margin-left: 165px;">
             <asp:Label ID="contact" runat="server" CssClass="login_field" Text="CONTACT" Visible="False" BorderStyle="None" ForeColor="White"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="c_ontact" CssClass="login_field" runat="server" Visible="False" ></asp:TextBox>
             
             
             </div>
            <div style="margin-left: 165px;">
             <asp:Label ID="Email" runat="server" CssClass="login_field" Text="EMAIL" Visible="False" BorderStyle="None" ForeColor="White"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
             <asp:TextBox ID="e_mail" CssClass="login_field" runat="server" Visible="False" ></asp:TextBox>
             

             
             </div>
            <div style="margin-left: 165px;">
             <asp:Label ID="Avg_gpa" runat="server" CssClass="login_field" Text="AVERAGE GPA" Visible="False" BorderStyle="None" ForeColor="White"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="avg__gpa" CssClass="login_field" runat="server" Visible="False" ></asp:TextBox>
            

             
             </div>
            </div>



        






















         <div>
            
             <table style="margin-left: 380px;margin-top: 20px;">

            <tr>
                <td><asp:Label ID="intervieid" runat="server" CssClass="cutoff_field" Text="Enter Enrollment Number" BorderStyle="None" ForeColor="White"></asp:Label>
            </td>
                <td style="margin-left: 120px; "> &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
                       <asp:TextBox ID="interview_id" CssClass="cutoff_field" runat="server" Width="106px" ></asp:TextBox>
         </td>
       </tr>

          <tr>
              
       <td>       <asp:Label ID="interviewmark" runat="server" CssClass="cutoff_field" Text="Enter Interview Marks" BorderStyle="None" ForeColor="White"></asp:Label>
             </td>
              
          <td>   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;   &nbsp; <asp:TextBox ID="interview_mark" CssClass="cutoff_field" runat="server" Width="106px" ></asp:TextBox>
        </td>
          </tr>    
              </table>
            </div>

            
              















            
         <div style="margin-left: 440px;margin-top: 40px;">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="update_btn" runat="server" CssClass="button button4" Text="UPDATE" OnClick="update_btn_Click" UseSubmitBehavior="False"  />
             </div>
        
         <div style="margin-left: 270px;margin-top: 50px;">
        <asp:Label ID="cutoff" runat="server" CssClass="cutoff_field" Text="Enter Aptitude Test Cutoff" BorderStyle="None" ForeColor="White"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="cut_off" CssClass="cutoff_field" runat="server" Width="106px" ></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         
         </div>
        <div style="margin-left: 400px;margin-top: 40px;">
  <asp:Button ID="reset_selection" runat="server" CssClass="button button4" Text="Reset Selection" OnClick="reset_selection_Click"  />
            
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="generate_btn" runat="server" CssClass="button button4" Text="Generate" OnClick="generate_btn_Click"  />
             </div>
    </form>
</body>
</html>
