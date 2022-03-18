<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryCityManagementWebApp.UI.CiewCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div>
            <br />
        </div>
        
        
        
     
        
    <td style="width: 226px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButtonList ID="rbtLstRating" runat="server" 
                RepeatDirection="Horizontal" RepeatLayout="Table" OnSelectedIndexChanged="rbtLstRatingButton_Click" Width="513px" Height="19px" style="margin-left: 173px">
                <asp:ListItem Text="City Name" Value="e"></asp:ListItem>
                <asp:ListItem Text="Country" Value="v"></asp:ListItem>
               
            </asp:RadioButtonList>  
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:TextBox ID="cityNameTextBox" runat="server" style="margin-left: 30px"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:DropDownList ID="countryDropDownList" runat="server" OnSelectedIndexChanged="countryDropDownList_SelectedIndexChanged" style="margin-left: 80px"> </asp:DropDownList>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <p
    <td style="width: 530px">
        

          
           
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Search" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="showGridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="SL">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CitySL") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="City Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CityName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CityAbout">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CityAbout") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="No of Dwellers">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CityNoofDwellers") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Location">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CityLocation") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Weather">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CityWeather") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="CountryName">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Country About">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("CountryAbout") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                </Columns>
            </asp:GridView>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
