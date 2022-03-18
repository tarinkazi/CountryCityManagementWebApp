<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CountryCityManagementWebApp.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:RadioButtonList ID="rbtLstRating" runat="server" 
                RepeatDirection="Horizontal" RepeatLayout="Table">
                <asp:ListItem Text="City Name" Value="Excellent"></asp:ListItem>
                <asp:ListItem Text="Country" Value="Very Good"></asp:ListItem>
               
            </asp:RadioButtonList>            
            
    
    </div>
    </form>
</body>
</html>
