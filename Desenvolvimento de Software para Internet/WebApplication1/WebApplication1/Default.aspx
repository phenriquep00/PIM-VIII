<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- Elemento conteiner --%>
    <div class="container">
        <%-- Header da pagina --%>
        <header class="header"> Gerenciamento de usuarios PIM VIII </header>

        <%-- Conteúdo da pagina --%>
        <main class="content">

            <%-- Sessão de pesquisa --%>
            <section class="search-container">
                <asp:TextBox CssClass="search" runat="server" placeholder="Buscar usuario"> </asp:TextBox>
                <asp:Button CssClass="search-button" runat="server" Text="Buscar"/>
            </section>

            <asp:Button CssClass="add-user-buttom" runat="server" Text="Cadastrar usuario" />

            <%-- Sessão de resultado --%>
            <section class="divisor">
                <div class="resultados"> Resultados </div>
            </section>

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
                        <asp:TableCell> 3 </asp:TableCell>
                        <asp:TableCell> Maria Santos Silva Souza </asp:TableCell>
                        <asp:TableCell> 11111111 </asp:TableCell>
                        <asp:TableCell> Rua Teste</asp:TableCell>
                        <asp:TableCell> +55 11111111 </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>

            <%-- Sessão dos botões editar/remover --%>
            <section class="editar-remover">
                <asp:Button CssClass="edit-user-buttom" runat="server" Text="Editar usuario" />
                <asp:Button CssClass="remove-user-buttom" runat="server" Text="Remover usuario" />
            </section>
        </main>
    </div>
</asp:Content>
