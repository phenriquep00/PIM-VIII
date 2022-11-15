<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <header class="header"> Gerenciamento de usuarios PIM VIII </header>

        <main class="content">
            <div class="search-container">
                <asp:TextBox CssClass="search" runat="server" placeholder="Buscar usuario"> </asp:TextBox>
            </div>

            <asp:Button CssClass="add-user-buttom" runat="server" Text="Cadastrar usuario" />

            <div class="divisor">
                <div class="resultados"> Resultados </div>
            </div>

            <div class="table-container">
                <asp:Table CssClass="table" runat="server">
                    <asp:TableHeaderRow BorderWidth="1">
                        <asp:TableHeaderCell> Id </asp:TableHeaderCell>
                        <asp:TableHeaderCell> Nome </asp:TableHeaderCell>
                        <asp:TableHeaderCell> Cpf </asp:TableHeaderCell>
                        <asp:TableHeaderCell> Endereço </asp:TableHeaderCell>
                        <asp:TableHeaderCell> Telefones </asp:TableHeaderCell>
                    </asp:TableHeaderRow>

                    <asp:TableRow CssClass="table-resultados" BorderWidth="1">
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>

            <div class="editar-remover">
                <asp:Button CssClass="edit-user-buttom" runat="server" Text="Editar usuario" />
                <asp:Button CssClass="remove-user-buttom" runat="server" Text="Remover usuario" />
            </div>
        </main>
    </div>
</asp:Content>
