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
if (Convert.ToBoolean( Entidad == 0)) 
{
    Console.WriteLine("Que tipo de entidad es: Persona Dom(0),Empresa Dom(1)");
    int EntidadD = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToBoolean(EntidadD == 0))
    {
        
        Console.WriteLine("Apellido");
        string A = Console.ReadLine();
        Console.WriteLine("TelefonoResidencial");
        string TR = Console.ReadLine();
        Console.WriteLine("TelefonoCelular");
        string TC = Console.ReadLine();
        Console.WriteLine("Email");
        string E = Console.ReadLine();
        Console.WriteLine("CodigoPostal");
        string C = Console.ReadLine();


        Creator ApellidoM = new ConcretCreatorPersona(A,TR,TC,E,C);


        productPersona AMAdd = ApellidoM.Mostrar();
        string apellidom = AMAdd.Mostrar(A, TR, TC, E, C);
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    else 
    {
        Console.WriteLine("TelefonoResidencial");
        string TR = Console.ReadLine();
        Console.WriteLine("TelefonoCelular");
        string TC = Console.ReadLine();
        Console.WriteLine("Email");
        string E = Console.ReadLine();
        Console.WriteLine("CodigoPostal");
        string C = Console.ReadLine();

        CreatorEmp ApellidoM = new ConcretCreatorEmpresaLocal(TR,TC,E,C);


        productEmpresaLocal AMAdd = ApellidoM.MostrarE();
        string apellidom = AMAdd.MostrarE(TR, TC, E, C);
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
        Console.WriteLine("Apellido");
        string A = Console.ReadLine();
        Console.WriteLine("TelefonoResidencial");
        string TR = Console.ReadLine();
        Console.WriteLine("TelefonoCelular");
        string TC = Console.ReadLine();
        Console.WriteLine("Email");
        string E = Console.ReadLine();
        Console.WriteLine("CodigoPostal");
        string B = Console.ReadLine();


        CreatorEx ApellidoM = new ConcretCreatorPersonaExtranjera(A,TR,TC,E,B);


        productPersonaExtranjera AMAdd = ApellidoM.MostrarX();
        string apellidom = AMAdd.MostrarX(A, TR, TC, E, B);
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    else 
    {
        Console.WriteLine("TelefonoResidencial");
        string TR = Console.ReadLine();
        Console.WriteLine("TelefonoCelular");
        string TC = Console.ReadLine();
        Console.WriteLine("Email");
        string E = Console.ReadLine();
        Console.WriteLine("CodigoPostal");
        string B = Console.ReadLine();

        CreatorExEmp ApellidoM = new ConcretCreatorEmpresaExtranjera(TR,TC,E,B);


        productEmpresaExtranjera AMAdd = ApellidoM.MostrarEM();
        string apellidom = AMAdd.MostrarEM(TR, TC, E, B);
        Console.WriteLine(DatosPrin);
        Console.WriteLine($"{apellidom}");

    }
    
}


    Console.ReadKey();