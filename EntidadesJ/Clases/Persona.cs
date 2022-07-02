using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJ.Clases
{
    public class Persona : productPersona
    {
        private string _id;
        private string _nombre;
        private string _nacionalidad;
        private string _fechadenacimiento;
        private string _lugarnacimiento;
        private string _isr;

        public Persona(string ID, string Nombre, string Nacionalidad, string FechaDeNacimiento, string LugarNacimiento, string ISR)
        {
            _id = ID;
            _nombre = Nombre;
            _nacionalidad = Nacionalidad;
            _fechadenacimiento = FechaDeNacimiento;
            _lugarnacimiento = LugarNacimiento;
            _isr = ISR;
        }

        public string Mostrar(string ID, string Nombre, string Nacionalidad, string FechaDeNacimiento, string LugarNacimiento, string ISR)
        {
            return ID + " " + Nombre + " " + Nacionalidad + " " + FechaDeNacimiento + " " + LugarNacimiento + " " + ISR;
        }
    }
    
}
