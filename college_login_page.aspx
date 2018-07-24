<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="college_login_page.aspx.cs" Inherits="WebApplication5.college_login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        @import url("https://fonts.googleapis.com/css?family=Exo");
        .login_field {
            border:medium dashed #526052;
            color:#707c70;
            font-family: 'Exo', sans-serif;
            font-size: 30px;
            margin-top:20px;
        }
        .error_field {
            border:medium dashed red;
            color:red;
            font-family: 'Exo', sans-serif;
            font-size: 30px;
            margin-top:20px;
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
    
        <asp:Image ID="Image1" runat="server" Height="234px" ImageUrl="~/Images/login_banner.jpg" Width="113%" />
    
    </div>
      
        <br />
        <div style="margin-left: 480px">
        <asp:Label ID="userid" runat="server" CssClass="login_field" Text="User ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="user_id" CssClass="login_field" runat="server" ></asp:TextBox>
        </div>
           
      
        <br />
         <div style="margin-left: 480px">
             <asp:Label ID="pswd" runat="server" CssClass="login_field" Text="Password"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="ps_wd" CssClass="login_field" runat="server" TextMode="Password"></asp:TextBox>
             <br />

             <br />
             <br />
             </div>

              <div style="margin-left: 440px">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="login_btn" runat="server" CssClass="button button4" Text="LOGIN" OnClick="login_btn_Click"  />
             </div>
        &nbsp;&nbsp;&nbsp;<br />
        <br />
        <div style="margin-left: 520px">
            <asp:TextBox ID="error_msg" CssClass="error_field" runat="server" Width="422px" Visible="False">*PLEASE ENTER VALID DETAILS</asp:TextBox>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
