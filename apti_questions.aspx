<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="apti_questions.aspx.cs" Inherits="WebApplication5.apti_questions" %>

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

.button4:hover {background-color: #526052;
                color:white;
}

        </style>
</head>
<body>
    <form id="form1" runat="server">
        
    <div >
    <asp:Image ID="Image1" style="margin-left:300px;" runat="server" Height="234px" ImageAlign="Middle" ImageUrl="~/Images/aptitude test banner image.jpg" Width="60%" BackColor="#0099FF" />
    </div>
        
        <p>
            &nbsp;</p>
        <div style="margin-left:300px;">



            <asp:Label ID="question_no_indicator" runat="server" BorderStyle="None" Height="50px" Width="300px" Font-Size="X-Large" ForeColor="White"></asp:Label>



        </div>
        <p>
            &nbsp;</p>
        <div>
        <asp:TextBox ID="question_box" style="margin-left:260px;background:none;" runat="server" Height="60px" Width="65%" BorderColor="White" BorderStyle="Solid" Enabled="False" ForeColor="White"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <div style="margin-left:300px;">

            <asp:RadioButtonList ID="option_list" runat="server" BorderColor="White" BorderStyle="Solid" CellPadding="4" CellSpacing="20" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="White"  RepeatDirection="Horizontal" Width="77.5%">
            </asp:RadioButtonList>

        </div>
        <p>
            &nbsp;</p>
        <div style="margin-left:600px">
                  <asp:Button ID="start_submit_btn" runat="server" CssClass="button button4" Text="START TEST" OnClick="start_submit_btn_Click" />

        </div>
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
