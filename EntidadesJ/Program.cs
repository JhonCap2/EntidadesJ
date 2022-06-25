// See https://aka.ms/new-console-template for more information
using EntidadesJ.Clases;

string ID = string.Empty;
string Nombre = string.Empty;
string Nacionalidad = string.Empty;
string FechaDeNacimiento = string.Empty;
string LugarNacimiento = string.Empty;
string ISR = string.Empty;

Console.WriteLine("Número de identificación");
ID = Console.ReadLine();
Console.WriteLine("Nombre");
Nombre = Console.ReadLine();
Console.WriteLine("Nacionalidad");
Nacionalidad = Console.ReadLine();
Console.WriteLine("FechaDeNacimiento");
FechaDeNacimiento = Console.ReadLine();
Console.WriteLine("LugarNacimiento");
LugarNacimiento = Console.ReadLine();
Console.WriteLine("ISR");
ISR = Console.ReadLine();

string DatosPrin = ID + " " + Nombre + " " + Nacionalidad + " " + FechaDeNacimiento + " " + LugarNacimiento + " " + ISR;

Console.WriteLine("Que tipo de entidad es: Persona Dom(0), Persona Ext(1)");
int Entidad = Convert.ToInt32( Console.ReadLine());
if (Convert.ToBoolean( Entidad = 0)) 
{
    Console.WriteLine("Que tipo de entidad es: Persona Dom(0),Empresa Dom(1)");
    int EntidadD = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToBoolean(EntidadD = 0))
    {
        Console.WriteLine("Coloca: Apellido, TelefonoResidencial, TelefonoCelular, Email, CodigoPostal");

        Creator ApellidoM = new ConcretCreatorPersona();


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine());
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    else 
    {
        Console.WriteLine("Coloca: Apellido, TelefonoResidencial, TelefonoCelular, Email, CodigoPostal");

        Creator ApellidoM = new ConcretCreatorEmpresaLocal();


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine());
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");


    }  

}
else
{
    Console.WriteLine("Que tipo de entidad es: Persona Ext(0),Empresa Ext(1)");
    int EntidadD = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToBoolean(EntidadD = 0))
    {
        Console.WriteLine("Coloca: Apellido, TelefonoResidencial, TelefonoCelular, Email, POBox");

        Creator ApellidoM = new ConcretCreatorPersonaExtranjera();


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine());
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    else 
    {
        Console.WriteLine("Coloca: TelefonoResidencial, TelefonoCelular, Email, POBox");

        Creator ApellidoM = new ConcretCreatorEmpresaExtranjera();


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine(),
        Console.ReadLine());
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    
}


    Console.ReadKey();