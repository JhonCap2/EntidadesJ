using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJ.Clases
{
    public interface productPersona
    {
        public string Mostrar(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string CodigoPostal);
    }

    public interface productPersonaExtranjera
    {
        public string Mostrar(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string POBox);
    }

    public interface productEmpresaExtranjera
    {
        public string Mostrar(string TelefonoResidencial, string TelefonoCelular, string Email, string POBox);
    }

    public interface productEmpresaLocal
    {
        public string Mostrar(string TelefonoResidencial, string TelefonoCelular, string Email, string POBox);
    }


}
