<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUsingRepeater.aspx.cs" Inherits="WebApplication5.EmployeeUsingRepeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
            width: 1153px;
        }
        .auto-style2 {
            width: 208px;
        }
        .auto-style3 {
            height: 31px;
            width: 208px;
        }
        .auto-style4 {
            width: 1153px;
        }
        .auto-style5 {
            width: 56%;
            margin-left: 264px;
            margin-top: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="rp1" runat="server">
            <HeaderTemplate>
                <table style="background-color:aqua;width:300px;text-align:center;padding-top:2px;font-size:20px"></table>
                <tr>
                    <td>
                        Employee Details
                    </td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                 <table class="auto-style5" style="background-color:aqua">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="EmpID"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("EmpID") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="EmpName"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("EmpName") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="EmpEmailID"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("EmpEmailID") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="EmpMobileNo"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label10" runat="server" Text='<%#Eval("EmpMobileNo") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="EmpImage"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Image ID="img1" runat="server" Width="100px" ImageUrl='<%#"~/Pictures/"+Eval("EmpImage") %>' />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="EmpGender"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="Label11" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
               
                
            </ItemTemplate>
            <FooterTemplate>
                <table>
                    <tr>
                        <td>@@Developed by ABC<br /> @@2020 all copyrights reserved</td>
                    </tr>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeConnectionString %>" SelectCommand="SELECT * FROM [Employee]"></asp:SqlDataSource>

    </form>
</body>
</html>