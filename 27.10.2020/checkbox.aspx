<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkboxcookie.aspx.cs" Inherits="cookie.checkboxcookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server" Text="select brand preferences" /><br /><br />
    <asp:CheckBox ID="checkbox1" runat="server" Text="iphone" OnCheckedChanged="checkbox1_CheckedChanged" /><br />
    <asp:CheckBox ID="checkbox2" runat="server" Text="samsung" /><br />
    <asp:CheckBox ID="checkbox3" runat="server" Text="Lenovo" /><br />
    <asp:CheckBox ID="checkbox4" runat="server" Text="Redmi" /><br />
    <asp:CheckBox ID="checkbox5" runat="server" Text="realme" /><br />
    <asp:CheckBox ID="checkbox6" runat="server" Text="Oppo" /><br />
    <asp:CheckBox ID="checkbox7" runat="server" Text="Vivo" /><br />
    <asp:CheckBox ID="checkbox8" runat="server" Text="infinix" /><br />
    <asp:CheckBox ID="checkbox9" runat="server" Text="Motrola" /><br />
    <asp:CheckBox ID="checkbox10" runat="server" Text="Nokia" /><br /><br />

        <asp:Button ID="btn1" runat="server" Text="checkon" />

        </div>
        <asp:Label ID="label2" runat="server" />
    </form>
</body>
</html>