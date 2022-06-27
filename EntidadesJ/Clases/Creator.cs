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
        public abstract productPersonaExtranjera MostrarX();

    }

    public abstract class CreatorExEmp
    {
        public abstract productEmpresaExtranjera MostrarEM();

    }

    public abstract class CreatorEmp
    {
        public abstract productEmpresaLocal MostrarE();

    }
}
