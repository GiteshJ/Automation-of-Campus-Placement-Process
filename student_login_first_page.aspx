<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_login_first_page.aspx.cs" Inherits="WebApplication5.student_login_first_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
  
  background-image:url('Images/1.jpg');
}
        .company_btns {
        width:300px;
        height:300px;
        border:double;
        border-color:gray;

        border-width:5px;
        
        
        
        }
        .button {
    background-color: #4CAF50; /* Green */
    border: none;
    color: white;
    padding: 16px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
    margin: 4px 2px;
    -webkit-transition-duration: 0.4s; /* Safari */
    transition-duration: 0.4s;
    cursor: pointer;
}
.button4 {
    background-color: white;
    color: black;
    border: 2px solid #526052;
}

.button4:hover {background-color: #526052;}


        </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="234px" ImageUrl="~/Images/training-campus.jpg" Width="100%" />
    
    </div>
        <br />
         <div style="margin-left: 40px">
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              <asp:Button ID="logout_btn" runat="server" CssClass="button button4" Text="LOGOUT" OnClick="logout_btn_Click" />

            </div>
        <br />
        <br />

        <div>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="amazon" runat="server" CssClass="company_btns" ImageUrl="~/Images/logo-amazon.jpg" OnClick="amazon_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="google" runat="server" CssClass="company_btns" ImageUrl="~/Images/Google.png" OnClick="google_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="bosch" runat="server" CssClass="company_btns" ImageUrl="~/Images/bosch-tools-logo.jpg" OnClick="bosch_Click" />

        </div>
    </form>
</body>
</html>
