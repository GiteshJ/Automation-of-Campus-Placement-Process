<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_login_second_page.aspx.cs" Inherits="WebApplication5.student_login_second_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
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
        .login_field {
             border:medium dashed #ffffff;
            color:#ffffff;
            font-family: 'Exo', sans-serif;
            font-size: 30px;
            margin-top:20px;
            background:none;
        }
        .error_field {
           
            color:lime;
            font-family: 'Exo', sans-serif;
            font-size: 30px;
            margin-top:20px;
            background:none;
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
    <div  style="margin-left:180px;width:1000px;background:none;" >
    <form id="form1" runat="server">
        <br />

    <div style="margin-left:145px;">
    
        <asp:Image ID="Image1" runat="server" Height="200px"  ImageUrl="~/Images/bosch-tools-logo.jpg" Width="700px" ImageAlign="Middle" />
    
    </div>
        <br />
        <div style="margin-left: 410px">
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              <asp:Button ID="home_btn" runat="server" CssClass="button button4" Text="HOME" OnClick="home_btn_Click" />

            </div>
        <br />
        <br />
        <div style="margin-left: 165px">
             <asp:Label ID="Name" runat="server" CssClass="login_field" Text="NAME" BorderStyle="None"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
             <asp:TextBox ID="na_me" CssClass="login_field" runat="server" Enabled="False"></asp:TextBox>
             <br />

             
             </div>
            
         <div style="margin-left: 165px">
             <asp:Label ID="Branch" runat="server" CssClass="login_field" Text="BRANCH" BorderStyle="None"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
             <asp:TextBox ID="b_ranch" CssClass="login_field" runat="server" Enabled="False"></asp:TextBox>
             <br />

             
             </div>
            <div style="margin-left: 165px">
             <asp:Label ID="contact" runat="server" CssClass="login_field" Text="CONTACT" BorderStyle="None"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="c_ontact" CssClass="login_field" runat="server" Enabled="False" ></asp:TextBox>
             <br />

             
             </div>
            <div style="margin-left: 165px">
             <asp:Label ID="Email" runat="server" CssClass="login_field" Text="EMAIL" BorderStyle="None"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
             <asp:TextBox ID="e_mail" CssClass="login_field" runat="server" Enabled="False" ></asp:TextBox>
             <br />

             
             </div>
            <div style="margin-left:165px">
             <asp:Label ID="Avg_gpa" runat="server" CssClass="login_field" Text="AVERAGE GPA" BorderStyle="None" Width="219px"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="avg__gpa" CssClass="login_field" runat="server" Enabled="False" ></asp:TextBox>
           </div>
      

        <div style="margin-left: 165px; margin-top:10px;">
            <asp:FileUpload ID="FileUpload1"  runat="server" CssClass="login_field" ToolTip="File should be in .pdf format with max size 1MB" Width="400px" />
            &nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Label ID="file_upload_error" runat="server" CssClass="error_field" Visible="False"></asp:Label>
        </div>
        
        <div style="margin-left: 410px; margin-top:40px;">
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="apply" runat="server" CssClass="button button4" Text="APPLY" OnClick="apply_Click" Width="149px" />
        </div>
        
        <div style="margin-left: 165px; margin-top:20px;">
             <asp:Label ID="applicationstatus" runat="server" CssClass="login_field" Text="APPLICATION STATUS" BorderStyle="None"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="application_status" CssClass="login_field" runat="server" Enabled="False"  Width="250px" ></asp:TextBox>
             <br />

             
             </div>
        <br />
        <br />

        <div style="margin-left: 165px">
             <asp:Button ID="test_btn" runat="server" CssClass="button button4" Text="Take Aptitude Test" Visible="False" OnClick="test_btn_Click"></asp:Button>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="last_date" CssClass="login_field" runat="server" Visible="False" Enabled="False" ></asp:Label>
             <br />
            
            <br />
            </div>
        <div style="margin-left:85px;">
             <asp:Label ID="interview_date" CssClass="login_field" runat="server" Visible="False" BorderColor="#33CCFF" ForeColor="#33CCFF" BorderStyle="Solid" ></asp:Label>

            </div>
        <br />
        <br />

    </form>
        </div>
</body>
</html>
