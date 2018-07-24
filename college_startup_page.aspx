<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="college_startup_page.aspx.cs" Inherits="WebApplication5.college_startup_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
         body {
            background-image: url('Images/1.jpg');
            
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
.dropdown_field {
             border:medium dashed #ffffff;
            color:#217a32;
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

        .button4:hover {
            background-color: #526052;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="234px" ImageUrl="~/Images/slider2.gif" Width="100%" />
    
    </div>
        <br />
        <br />

        <div>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="student_wise_details" runat="server" CssClass="button button1" Text="STUDENT DETAILS" OnClick="student_wise_details_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="comapny_wise_details" runat="server" CssClass="button button1" Text="COMPANY DETAILS" OnClick="comapny_wise_details_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="logout" runat="server" CssClass="button button1" Text="LOGOUT" OnClick="logout_Click" />

        </div>
        <br />
        <br />

        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="type_list" runat="server" CssClass="dropdown_field" Font-Bold="True" Height="66px" Width="380px">
                <asp:ListItem Value="1">Applied Candidates</asp:ListItem>
                <asp:ListItem Value="2">Interviewed Candidates</asp:ListItem>
                <asp:ListItem Value="3">Selected Candidates</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="company_list" runat="server" CssClass="dropdown_field" Font-Bold="True" Height="66px" Width="200px">
                <asp:ListItem Value="1">Google</asp:ListItem>
                <asp:ListItem Value="2">Bosch</asp:ListItem>
                <asp:ListItem Value="3">Amazon</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="fetch_details" runat="server" CssClass="button button4" Text="FETCH DETAILS" Height="66px" Width="240px" OnClick="fetch_details_Click" />
        </div>
        &nbsp;&nbsp;
        <br />
        <br />

        <div style="margin-left: 160px">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" DataSourceID="amazon_selected" ForeColor="Black" GridLines="Horizontal" Width="1050px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
            <asp:SqlDataSource ID="student_details" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa FROM student_details"></asp:SqlDataSource>
            <asp:SqlDataSource ID="bosch_selected" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email], avg_gpa, apti_marks, interview_marks, final_marks FROM bosch_selected_student"></asp:SqlDataSource>
            <asp:SqlDataSource ID="google_selected" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email], avg_gpa, apti_marks, interview_marks, final_marks FROM google_selected_student"></asp:SqlDataSource>
            <asp:SqlDataSource ID="amazon_selected" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa, apti_marks, interview_marks, final_marks FROM amazon_selected_student"></asp:SqlDataSource>
            <asp:SqlDataSource ID="bosch_apti_cleared" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa, apti_marks, interview_marks, final_marks FROM bosch_apti_passed"></asp:SqlDataSource>
            <asp:SqlDataSource ID="google_apti_cleared" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa, apti_marks, interview_marks, final_marks FROM google_apti_passed"></asp:SqlDataSource>
            <asp:SqlDataSource ID="amazon_apti_cleared" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa, apti_marks, interview_marks, final_marks FROM amazon_apti_passed"></asp:SqlDataSource>
            <asp:SqlDataSource ID="bosch_applied" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa, apti_marks, application_status FROM bosch_applied"></asp:SqlDataSource>
            <asp:SqlDataSource ID="google_applied" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa, apti_marks, application_status FROM google_applied"></asp:SqlDataSource>
            <asp:SqlDataSource ID="amazon_applied" runat="server" ConnectionString="<%$ ConnectionStrings:placement_driveConnectionString %>" ProviderName="<%$ ConnectionStrings:placement_driveConnectionString.ProviderName %>" SelectCommand="SELECT enroll_number, name, branch, contact, email, avg_gpa, apti_marks, application_status FROM amazon_applied"></asp:SqlDataSource>
           </div>
    </form>
</body>
</html>
