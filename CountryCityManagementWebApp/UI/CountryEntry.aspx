<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" Inherits="CountryCityManagementWebApp.CountryEntry" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        
            
                <asp:label runat="server" text="Name        "></asp:label>
                <asp:TextBox ID="nameTextBox" runat="server" Width="168px"></asp:TextBox>
               
            
        
        <br />
        <asp:Label ID="Label1" runat="server" Text="About"></asp:Label>
    <CKEditor:CKEditorControl ID="aboutCKEditorControl" runat="server" style="margin-left: 66px" Width="899px"></CKEditor:CKEditorControl>
    
    
    
        
            
                &nbsp;&nbsp;&nbsp;
        <br />
            <asp:Button ID="saveButton" runat="server" Text="Save" Width="100px" OnClick="saveButton_Click" />
                <asp:Button ID="cancelButton" runat="server" Text="Cancel" Width="101px" />
           
        <br />
        
    
        <br />
                <asp:GridView ID="CountryEntryGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="About" HeaderText="About" SortExpression="About" />
                    </Columns>
                </asp:GridView>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CountryManagementDBConnectionString %>" SelectCommand="SELECT * FROM [Countries]"></asp:SqlDataSource>
                
    </div>
    </form>
</body>
</html>
