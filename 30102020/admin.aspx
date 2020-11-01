<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="RapidApplication.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="312px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="494px">
				<AlternatingRowStyle BackColor="White" />
				<Columns>
					<asp:CommandField ShowSelectButton="True" />
					<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
					<asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
					<asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
					<asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
					<asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
				</Columns>
				<FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
				<HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
				<RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
				<SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
				<SortedAscendingCellStyle BackColor="#FDF5AC" />
				<SortedAscendingHeaderStyle BackColor="#4D0000" />
				<SortedDescendingCellStyle BackColor="#FCF6C0" />
				<SortedDescendingHeaderStyle BackColor="#820000" />
			</asp:GridView>
        </div>
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [RegistrationTable]"></asp:SqlDataSource>
        <p>
			<asp:Button ID="Button1" runat="server" BackColor="#FF33CC" ForeColor="#66FF33" Height="30px" OnClick="Button1_Click" Text="Submit" Width="120px" />
		</p>
    </form>
</body>
</html>