<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalist.aspx.cs" Inherits="cookie.datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <p>Datalist shows the date of the datatable</p>
        <div style="height: 28px; width: 264px; margin-left: 0px">
            <asp:DataList ID="datalist1" runat="server">
                <ItemTemplate>
                    <asp:Table runat="server" ID="table1" cellpadding="2" cellspacing="0" border="1" Style="width:100px; height:50px"/>
                        <tr>
                            <td>
                                <strong>FirstName : </strong><span class="firstname"><%#Eval("FirstName")%></span><br />
                                <strong>SecondName : </strong><span class="secondname"><%#Eval("SecondName")%></span><br />
                                <strong>Designation : </strong><span class="country"><%#Eval("Designation")%></span><br />
                                <strong>Location : </strong><span class="country"><%#Eval("Location")%></span><br />
                                <strong>Country : </strong><span class="country"><%#Eval("Country")%></span><br />
                            </td>
                       </tr>
                   
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>