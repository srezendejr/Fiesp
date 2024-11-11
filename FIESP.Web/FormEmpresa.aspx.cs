using FIESP.Negocio;
using FIESP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Policy;

namespace FIESP.Web
{
    public partial class FormEmpresa : System.Web.UI.Page
    {
        EmpresaNegocio _empresaNegocio;
        Model.Empresa _empresa;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnSave_click(Object sender,  EventArgs e)
        {
            _empresa = new Empresa { Nome = txtNome.Text };
            _empresaNegocio = new EmpresaNegocio();
            _empresaNegocio.Salvar(_empresa);
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            
        }
        //protected void Salvar(FIESP.Model.Empresa empresa)
        //{
        //    _empresaNegocio = new EmpresaNegocio();
        //    _empresaNegocio.Salvar(empresa);
        //}
    }
}