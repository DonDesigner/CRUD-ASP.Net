<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Pages.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css" href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<script src="../scripts/jquery-1.9.1.min.js"></script>
<script src="../scripts/bootstrap.js"></script>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <div class="jumbotron">
                <h2>Projeto CRUD - Controle de Clientes</h2>
                Selecione a operação desejada:
        <asp:DropDownList ID="ddlMenu" runat="server">
            <asp:ListItem Value="0" Text="- Escolha uma Opção -" />
            <asp:ListItem Value="1" Text="Cadastrar Cliente" />
            <asp:ListItem Value="2" Text="Consultar Cliente" />
            <asp:ListItem Value="3" Text="Obter os Dados do Cliente" />

        </asp:DropDownList>
                <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" OnClick="btnAcessar" />

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>
            </div>
        </div>
    </form>
</body>
</html>
