<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AllaBolagScrubber.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="mindiv" style="font-size: 40px"  runat="server" > </div>

        <div style="font-size:30px">Mata in ett organisations nummer:</div>

        <input id="Text1" type="text" runat="server"  /> <asp:DropDownList ID="DropDownList1" runat="server">
                                                             
            <asp:ListItem Text="Allabolag.se" Value="Allabolag.se"></asp:ListItem>
            <asp:ListItem Text="Hitta.se" Value="Hitta.se"></asp:ListItem>
            <asp:ListItem Text="Eniro.se" Value="Eniro.se"></asp:ListItem>
                        <asp:ListItem Text="Upplysning.se" Value="Upplysning.se"></asp:ListItem>

                                                         </asp:DropDownList>

        <asp:Button ID="Button1" runat="server" Text="Sök" OnClientClick="knappKlickad" OnClick="Button1_Click"/>
    
    </div>
    </form>
</body>
</html>
