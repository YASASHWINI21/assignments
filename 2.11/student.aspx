<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="ASPControls.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 184px;
		}
		.auto-style2 {
			width: 184px;
			height: 26px;
		}
		.auto-style3 {
			height: 26px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
		 <asp:Repeater ID="RP2" runat="server">
			<HeaderTemplate>
				<table style="font-size:20px;text-align:center;background-color:skyblue;width:100%" />
				<tr>
					<td style="font-size:20px;text-align:center;height:48px">
						 <asp:Label ID="Lb" runat="server" Text="Student Details"></asp:Label>
					</td>
				</tr>
				</table>

			</HeaderTemplate>

			 <ItemTemplate>
		        <table style="width:100%; border:solid 2px;background-color:lightpink">
			 <tr>
				<td class="auto-style1">
					<asp:Label ID="Label1" runat="server" Text="StudentID"></asp:Label>
				</td>
				<td>
					<asp:Label ID="Label9" runat="server" Text='<% # Eval("StudentID") %>'></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>

			<tr>
				<td class="auto-style1">
					<asp:Label ID="Label2" runat="server" Text="StudentName"></asp:Label>
				</td>
				<td>
					<asp:Label ID="Label10" runat="server" Text='<%#Eval("StudentName") %>'></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>

			<tr>
				<td class="auto-style1">
					<asp:Label ID="Label3" runat="server" Text="StudentEmailID"></asp:Label>
				</td>
				<td>
					<asp:Label ID="Label11" runat="server" Text='<% #Eval("StudentEmailID") %>'></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>

		
				

			<tr>
				<td class="auto-style1">
					<asp:Label ID="Label5" runat="server" Text="StudentGender"></asp:Label>
				</td>
				<td>
					<asp:Label ID="Label13" runat="server" Text='<% #Eval("StudentGender") %>'></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>

			<tr>
				<td class="auto-style1">
					<asp:Label ID="Label6" runat="server" Text="StudentRollNo"></asp:Label>
				</td>
				<td>
					<asp:Label ID="Label14" runat="server" Text='<% #Eval("StudentRollNo") %>'></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>

			<tr>
				<td class="auto-style1">
					<asp:Label ID="Label7" runat="server" Text="StudentCity"></asp:Label>
				</td>
				<td>
					<asp:Label ID="Label15" runat="server" Text='<% #Eval("StudentCity") %>'></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>

			<tr>
				<td class="auto-style1">
					<asp:Label ID="Label8" runat="server" Text="StudentAddress"></asp:Label>
				</td>
				<td>
					<asp:Label ID="Label16" runat="server" Text='<% #Eval("StudentAddress") %>'></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>

						<tr>
				<td class="auto-style2">
					<asp:Label ID="Label4" runat="server" Text="StudentImage"></asp:Label>
				</td>
				<td rowspan="5" class="auto-style1">
                        <asp:Image ID="img1" runat="server" Width="65px" ImageUrl='<%#"https://www.bing.com/th?id=OIP.rtaM-AfxZ9HSLOdFDeY5aAHaE8&w=158&h=106&c=8&rs=1&qlt=90&pid=3.1&rm=2"+ Eval("StudentImage")%>'></asp:Image>
  					</td>
			</tr>
		</table>
			 </ItemTemplate>
			 <FooterTemplate>
                    <table style="background-color:aqua;border:solid 2px;color:red;width:100%">
                        <tr>
                            <td>
                                 @developed by Yashu<br />
                                @All Copyrights reserved.
                            </td>
                        </tr>
                    </table>
                </FooterTemplate>
		</asp:Repeater>
			</div>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentTableConnectionString %>" SelectCommand="SELECT * FROM [StudentTable]"></asp:SqlDataSource>
    </form>
</body>
</html>