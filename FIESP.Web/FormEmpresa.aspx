<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormEmpresa.aspx.cs" Inherits="FIESP.Web.FormEmpresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="EmpresaForm" runat="server" >
        <div>
            Código
        </div>
        <div>
            <asp:TextBox ID="txtCodigo" Enabled="false" runat="server"></asp:TextBox>
        </div>
        <div>
            Nome
        </div>
        <div>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button name="btnSave" text="Salvar" onclick="btnSave_click" runat="server" />
            <asp:Button name="btnVoltar" text="Voltar" onclick="btnVoltar_Click" runat="server" />
        </div>
    </form>
</body>
</html>
