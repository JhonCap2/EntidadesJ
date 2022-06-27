using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJ.Clases
{
    public class Persona : productPersona
    {
        private string _apellido;
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _codigoPostal;

        public Persona(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string CodigoPostal)
        {
            _apellido = Apellido;
            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _codigoPostal = CodigoPostal;
        }

        public string Mostrar(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string CodigoPostal)
        {
            return Apellido + " " + TelefonoResidencial + " " + TelefonoCelular + " " + Email + " " + CodigoPostal;
        }
    }
    public class PersonaExtranjera : productPersonaExtranjera
    {
        private string _apellido;
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _pobox;

        public PersonaExtranjera(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string POBox)
        {
            _apellido = Apellido;
            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _pobox = POBox;
        }

        public string MostrarX(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string POBox)
        {
            return Apellido + " " + TelefonoResidencial + " " + TelefonoCelular + " " + Email + " " + POBox;
        }
    }

    public class EmpresaExtranjera : productEmpresaExtranjera
    {
       
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _pobox;

        public EmpresaExtranjera( string TelefonoResidencial, string TelefonoCelular, string Email, string POBox)
        {
            
            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _pobox = POBox;
        }

        public string MostrarEM( string TelefonoResidencial, string TelefonoCelular, string Email, string POBox)
        {
            return TelefonoResidencial + " " + TelefonoCelular + " " + Email + " " + POBox;
        }
    }


    public class EmpresaLocal : productEmpresaLocal
    {

        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _codigoPostal;

        public EmpresaLocal(string TelefonoResidencial, string TelefonoCelular, string Email, string CodigoPostal)
        {

            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _codigoPostal = CodigoPostal;
        }

        public string MostrarE(string TelefonoResidencial, string TelefonoCelular, string Email, string CodigoPostal)
        {
            return TelefonoResidencial + " " + TelefonoCelular + " " + Email + " " + CodigoPostal;
        }
    }
}
