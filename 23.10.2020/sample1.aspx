<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
	protected void Button1_Click(object sender, EventArgs e)
	{
		Response.Write("This is fun");
	}
	protected void TextBox1_TextChanged(object sender, EventArgs e)
	{
		string m = "Hello" + TextBox1.Text;
		Response.Write(m);
	}
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
	
    <form id="form1" runat="server">
        <div>
			<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br /><br />

			<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

        </div>
    </form>
</body>
</html>