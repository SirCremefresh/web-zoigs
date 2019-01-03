<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="web_zoigs._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    here comes dsome text
    
    <%= TheNumber %>

    <asp:ListView ID="categoryList"
                  ItemType="Dorflaedali.Models.Product"
                  runat="server"
                  SelectMethod="GetProducts">
        <ItemTemplate>
            <b style="font-size: large; font-style: normal">
                <a href="/Product?productId=<%#: Item.Id %>">
                    <%#: Item.ImageName %>
                    <asp:Image runat="server" ImageUrl='<%# "~/img/" + Item.ImageName %>' BorderStyle="None"/>
                     
                </a>
            </b>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>