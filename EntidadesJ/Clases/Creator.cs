using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJ.Clases
{
    public abstract class Creator
    {
        public abstract productPersona Mostrar();

    }

    public abstract class CreatorEx 
    {
        public abstract productPersonaExtranjera Mostrar();

    }

    public abstract class CreatorExEmp
    {
        public abstract productEmpresaExtranjera Mostrar();

    }

    public abstract class CreatorEmp
    {
        public abstract productEmpresaLocal Mostrar();

    }
}
