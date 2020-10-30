<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="RapidApplication.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 196px;
		}
		.auto-style2 {
			width: 195px;
		}
		.auto-style3 {
			width: 195px;
			height: 21px;
		}
		.auto-style4 {
			height: 21px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
    	<table style="width:100%;" border="0">
			<tr>
				<td class="auto-style1">UserName</td>
				<td>
					<asp:TextBox ID="TextBox1" runat="server" Width="193px" Height="16px" OnTextChanged="TextBox1_TextChanged" ToolTip="Enter UserName"></asp:TextBox>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style1">Email</td>
				<td>
					<asp:TextBox ID="TextBox2" runat="server" Width="198px" Height="19px" TextMode="Email" ToolTip="Enter Email "></asp:TextBox>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style1">Paasword</td>
				<td>
					<asp:TextBox ID="TextBox3" runat="server" Width="193px" Height="16px" TextMode="Password" ToolTip="Enter Passwrod"></asp:TextBox>
				</td>
				<td>&nbsp;</td>
			</tr>
		</table>
		<table style="width:100%;">
			<tr>
				<td class="auto-style2">Confirm Password</td>
				<td>
					<asp:TextBox ID="TextBox4" runat="server" Width="190px" Height="16px" TextMode="Password" ToolTip="Confirm Password"></asp:TextBox>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td class="auto-style3">Gender</td>
				<td class="auto-style4">
					<asp:RadioButton ID="RadioButton1" runat="server" ForeColor="#66FF33" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:RadioButton ID="RadioButton2" runat="server" ForeColor="Red" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Female" />
				</td>
				<td class="auto-style4"></td>
			</tr>
			<tr>
				<td class="auto-style2">City</td>
				<td>
					<asp:DropDownList ID="DropDownList1" runat="server" Height="75px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="100px" ToolTip="Select City">
						<asp:ListItem>Hyderabad</asp:ListItem>
						<asp:ListItem>Visakhapatnam</asp:ListItem>
						<asp:ListItem>patna</asp:ListItem>
						<asp:ListItem>Vijaywada</asp:ListItem>
						<asp:ListItem>Banglore</asp:ListItem>
						<asp:ListItem>Mumbai</asp:ListItem>
						<asp:ListItem>Delhi</asp:ListItem>
						<asp:ListItem>Kolkata</asp:ListItem>
						<asp:ListItem>Pune</asp:ListItem>
						<asp:ListItem>Chennai</asp:ListItem>
					</asp:DropDownList>
				</td>
				<td>&nbsp;</td>
			</tr>
		</table>
		<p>
			<asp:Button ID="Button1" runat="server" BackColor="Red" BorderColor="Lime" ForeColor="#FFFFCC" Height="36px" OnClick="Button1_Click" Text="Register" Width="106px" />
		</p>
		<asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>