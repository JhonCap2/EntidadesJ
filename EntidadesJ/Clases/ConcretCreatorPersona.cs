using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJ.Clases
{
    public class ConcretCreatorPersona : Creator
    {
        private string _id;
        private string _nombre;
        private string _nacionalidad;
        private string _fechadenacimiento;
        private string _lugarnacimiento;
        private string _isr;


        public ConcretCreatorPersona(string ID, string Nombre, string Nacionalidad, string FechaDeNacimiento, string LugarNacimiento, string ISR)
        {
            _id = ID;
            _nombre = Nombre;
            _nacionalidad = Nacionalidad;
            _fechadenacimiento = FechaDeNacimiento;
            _lugarnacimiento = LugarNacimiento;
            _isr = ISR;
        }
        public override productPersona Mostrar()
        {
            return new Persona(_id, _nombre, _nacionalidad, _fechadenacimiento, _lugarnacimiento, _isr);
        }
    }
}
