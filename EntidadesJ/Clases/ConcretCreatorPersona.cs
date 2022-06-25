﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesJ.Clases
{
    public class ConcretCreatorPersona : Creator
    {
        private string _apellido;
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _codigoPostal;

        public ConcretCreatorPersona()
        {


        }

        public ConcretCreatorPersona(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string CodigoPostal)
        {
            _apellido = Apellido;
            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _codigoPostal = CodigoPostal;
        }
        public override productPersona Mostrar()
        {
            return new Persona(_apellido, _telefonoresidencial, _telefonocelular, _email, _codigoPostal);
        }
    }
    public class ConcretCreatorPersonaExtranjera : CreatorEx
    {
        private string _apellido;
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _pobox;

        public ConcretCreatorPersonaExtranjera()
        {

        }

        public ConcretCreatorPersonaExtranjera(string Apellido, string TelefonoResidencial, string TelefonoCelular, string Email, string POBox)
        {
            _apellido = Apellido;
            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _pobox = POBox;
        }
        public override productPersonaExtranjera Mostrar()
        {
            return new PersonaExtranjera(_apellido, _telefonoresidencial, _telefonocelular, _email, _pobox);
        }

    }

    public class ConcretCreatorEmpresaExtranjera : CreatorExEmp
    { 
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _pobox;

        public ConcretCreatorEmpresaExtranjera()
        {

        }

        public ConcretCreatorEmpresaExtranjera( string TelefonoResidencial, string TelefonoCelular, string Email, string POBox)
        {
            
            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _pobox = POBox;
        }
        public override productEmpresaExtranjera Mostrar()
        {
            return new EmpresaExtranjera(_telefonoresidencial, _telefonocelular, _email, _pobox);
        }

    }

    public class ConcretCreatorEmpresaLocal : CreatorEmp
    {
        private string _telefonoresidencial;
        private string _telefonocelular;
        private string _email;
        private string _pobox;

        public ConcretCreatorEmpresaLocal()
        {

        }

        public ConcretCreatorEmpresaLocal(string TelefonoResidencial, string TelefonoCelular, string Email, string POBox)
        {

            _telefonoresidencial = TelefonoResidencial;
            _telefonocelular = TelefonoCelular;
            _email = Email;
            _pobox = POBox;
        }
        public override productEmpresaLocal Mostrar()
        {
            return new EmpresaLocal(_telefonoresidencial, _telefonocelular, _email, _pobox);
        }

    }

}