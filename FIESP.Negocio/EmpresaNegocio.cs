using FIESP.Data.Context;
using FIESP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIESP.Negocio
{
    public class EmpresaNegocio
    {
        private Context _context;
        public void Salvar(Empresa empresa)
        {
            _context = new Context();
            try
            {
                if (empresa.Codigo == 0)
                    _context.Salvar<Empresa>(empresa);
                else
                    _context.Alterar<Empresa>(empresa);

                _context.Commit().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Excluir(Empresa empresa)
        {
            _context = new Context();
            try
            {
                _context.Excluir<Empresa>(empresa);
                _context.Commit().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empresa> Lista()
        {
            _context = new Context();
            return _context.Empresas.ToList();
        }
    }
}
