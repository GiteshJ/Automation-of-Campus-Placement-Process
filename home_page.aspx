<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home_page.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Placement Portal</title>
    <style>
 
@import url("https://fonts.googleapis.com/css?family=Varela+Round");
@import url("https://fonts.googleapis.com/css?family=Roboto+Mono");
        body {
            background-image: url('Images/1.jpg');
            margin: 0;
            background-color: #fff;
        }
.button {
  width: 24vw;
  height: 6vw;
  margin-top:50px;
  transform: translate(-50%, -80%);
  font-family: 'Varela Round', sans-serif;
  font-size: 2vw;
  letter-spacing: 0.1em;
  color: #e8e8e8;
  border: none;
  border-radius: 10px;
  outline: none;
  background: linear-gradient(45deg, #d350db, teal, #d350db);
  background-size: 400% 400%;
  box-shadow: 1vw 1vw 0 lightcoral;
  cursor: pointer;
  transition: all 0.3s ease;
}
.button:hover {
  animation: gradient 10s ease infinite;
  font-size: 2.05vw;
  box-shadow: 0.2vw 0.2vw 0 lightcoral;
}

        @keyframes gradient {
            50% {
                background-position: 100% 0;
            }
        }
        .welcome {
            text-align:center;
            color: #009179;
            font-family: 'Roboto Mono', monospace;
            font-size: 50px;
            
        }

    </style>
</head>
<body >
    
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="234px" width="100%" ImageUrl="~/Images/banner002uk.png"  />

        <div  class="welcome">
            <h1>Welcome</h1>
        </div>
        <p style="margin-left: 230px">
            <asp:Button ID="student_login" runat="server" Text="Login As Student" CssClass="button" style="vertical-align:middle" OnClick="student_login_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="employer_login" runat="server" Text="Login As Employer" CssClass="button" style="vertical-align:middle" OnClick="employer_login_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="college_login" runat="server" Text="Login As College" CssClass="button" style="vertical-align:middle" OnClick="college_login_Click" />

            </p>
     
    </form>
    
</body>
</html>
