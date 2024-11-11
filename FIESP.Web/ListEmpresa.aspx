<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListEmpresa.aspx.cs" Inherits="FIESP.Web.ListEmpresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="gidEmpresa" AutoGenerateColumns="false"
                OnRowEditing="EmployeeGridView_RowEditing"
                OnRowDeleting="EmployeeGridView_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="Código">
                        <ItemTemplate><%#Eval("Codigo") %>  </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="true" ButtonType="Button" EditText="Editar"
                         HeaderText="Editar" />
                    <asp:CommandField ShowDeleteButton="true" ButtonType="Button" DeleteText="Excluir"
     HeaderText="Excluir" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
