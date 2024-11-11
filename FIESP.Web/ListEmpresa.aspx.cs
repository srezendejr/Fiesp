using FIESP.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FIESP.Web
{
    public partial class ListEmpresa : System.Web.UI.Page
    {
        EmpresaNegocio _empresaNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            _empresaNegocio = new EmpresaNegocio();
            gidEmpresa.DataSource = _empresaNegocio.Lista();
        }

        protected void EmployeeGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void EmployeeGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            _empresaNegocio = new EmpresaNegocio();
            _empresaNegocio.Excluir(null);
        }
    }
}