<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <header class="header">
            PIM VIII crud web interface
        </header>

        <main class="content">
            <div class="search-container">
                <asp:TextBox CssClass="search" runat="server" placeholder="Buscar usuario">
                </asp:TextBox>
                
                <div>
                    magnifying glass
                </div>
            </div>

            <asp:Button CssClass="add-user-buttom" runat="server" Text="Cadastrar usuario"/>
            
        </main>
    </div>

</asp:Content>
