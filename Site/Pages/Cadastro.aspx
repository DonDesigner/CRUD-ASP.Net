<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
     <link type="text/css" href="../Content/bootstrap.css" rel="stylesheet" />
</head>
    <script src="../scripts/jquery-1.9.1.min.js"></script>
    <script src="../scripts/bootstrap.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Cadastro de Cliente</h3>
                <br />
                
                Nome do Cliente: <br />
                <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control" />
                <br /><br />

                Endereço do Cliente: <br />
                <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%" CssClass="form-control" />
                <br /><br />

                E-mail do Cliente: <br />
                <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail Válido" Width="25%" CssClass="form-control" />
               
                <br /><br />
                
                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrarCliente"/>

                <a href="Default.aspx" class="btn btn-default" >Voltar</a>

            </div>

        </div>

    </div>
    </form>
</body>
</html>
