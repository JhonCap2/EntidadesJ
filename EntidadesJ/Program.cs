// See https://aka.ms/new-console-template for more information
using EntidadesJ.Clases;


Console.WriteLine("Que tipo de entidad es: Persona Dom(0), Persona Ext(1)");
int Entidad = Convert.ToInt32( Console.ReadLine());
if (Convert.ToBoolean( Entidad == 0)) 
{
    Console.WriteLine("Que tipo de entidad es: Persona Dom(0),Empresa Dom(1)");
    int EntidadD = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToBoolean(EntidadD == 0))
    {

        Console.WriteLine("ID");
        string I = Console.ReadLine();
        Console.WriteLine("Nombre");
        string N = Console.ReadLine();
        Console.WriteLine("Nacionalidad");
        string ND = Console.ReadLine();
        Console.WriteLine("Fecha de Nacimiento");
        string F = Console.ReadLine();
        Console.WriteLine("Lugar de Nacimiento");
        string L = Console.ReadLine();
        Console.WriteLine("ISR");
        string IS = Console.ReadLine();

        Console.WriteLine("Apellido");
        string  Apellido = Console.ReadLine();
        Console.WriteLine("Telefono Residencial");
        string  TelefonoR = Console.ReadLine();
        Console.WriteLine("Telefono Celular");
        string  TelefonoC= Console.ReadLine();
        Console.WriteLine("Email");
        string  Email = Console.ReadLine();
        Console.WriteLine("Codigo Postal");
        string  CodigoP = Console.ReadLine();

        string DatosPrin = (Apellido + " " +TelefonoR + " " + TelefonoC + " " + Email + " " + CodigoP);

        Creator ApellidoM = new ConcretCreatorPersona(I,N,ND,F,L,IS);


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(I, N, ND, F, L, IS);
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    else 
    {
        Console.WriteLine("ID");
        string I = Console.ReadLine();
        Console.WriteLine("Nombre");
        string N = Console.ReadLine();
        Console.WriteLine("Nacionalidad");
        string ND = Console.ReadLine();
        Console.WriteLine("Fecha de Nacimiento");
        string F = Console.ReadLine();
        Console.WriteLine("Lugar de Nacimiento");
        string L = Console.ReadLine();
        Console.WriteLine("ISR");
        string IS = Console.ReadLine();

        Console.WriteLine("Telefono Residencial");
        string TelefonoR = Console.ReadLine();
        Console.WriteLine("Telefono Celular");
        string TelefonoC = Console.ReadLine();
        Console.WriteLine("Email");
        string Email = Console.ReadLine();
        Console.WriteLine("Codigo Postal");
        string CodigoP = Console.ReadLine();

        string DatosPrin = (TelefonoR + " " + TelefonoC + " " + Email + " " + CodigoP);

        Creator ApellidoM = new ConcretCreatorPersona(I, N, ND, F, L, IS);


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(I, N, ND, F, L, IS);
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");


    }  

}
else
{
    Console.WriteLine("Que tipo de entidad es: Persona Ext(0),Empresa Ext(1)");
    int EntidadD = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToBoolean(EntidadD == 0))
    {
        Console.WriteLine("ID");
        string I = Console.ReadLine();
        Console.WriteLine("Nombre");
        string N = Console.ReadLine();
        Console.WriteLine("Nacionalidad");
        string ND = Console.ReadLine();
        Console.WriteLine("Fecha de Nacimiento");
        string F = Console.ReadLine();
        Console.WriteLine("Lugar de Nacimiento");
        string L = Console.ReadLine();
        Console.WriteLine("ISR");
        string IS = Console.ReadLine();

        Console.WriteLine("Apellido");
        string Apellido = Console.ReadLine();
        Console.WriteLine("Telefono Residencial");
        string TelefonoR = Console.ReadLine();
        Console.WriteLine("Telefono Celular");
        string TelefonoC = Console.ReadLine();
        Console.WriteLine("Email");
        string Email = Console.ReadLine();
        Console.WriteLine("POBox");
        string POBox = Console.ReadLine();

        string DatosPrin = (Apellido + " " + TelefonoR + " " + TelefonoC + " " + Email + " " + POBox);

        Creator ApellidoM = new ConcretCreatorPersona(I, N, ND, F, L, IS);


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(I, N, ND, F, L, IS);
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    else 
    {
        Console.WriteLine("ID");
        string I = Console.ReadLine();
        Console.WriteLine("Nombre");
        string N = Console.ReadLine();
        Console.WriteLine("Nacionalidad");
        string ND = Console.ReadLine();
        Console.WriteLine("Fecha de Nacimiento");
        string F = Console.ReadLine();
        Console.WriteLine("Lugar de Nacimiento");
        string L = Console.ReadLine();
        Console.WriteLine("ISR");
        string IS = Console.ReadLine();

        Console.WriteLine("Telefono Residencial");
        string TelefonoR = Console.ReadLine();
        Console.WriteLine("Telefono Celular");
        string TelefonoC = Console.ReadLine();
        Console.WriteLine("Email");
        string Email = Console.ReadLine();
        Console.WriteLine("POBox");
        string POBox = Console.ReadLine();

        string DatosPrin = (TelefonoR + " " + TelefonoC + " " + Email + " " + POBox);

        Creator ApellidoM = new ConcretCreatorPersona(I, N, ND, F, L, IS);


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(I, N, ND, F, L, IS);
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");


    }

}


    Console.ReadKey();