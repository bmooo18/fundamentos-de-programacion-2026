// Variables de tipo explícito - agregar 2
sbyte sbyteVal = 1;

Console.WriteLine ("Tipo de sbyteVal: " + sbyteVal. GetType());

string texto = "Hola C#";
Console.WriteLine("Tipo de texto: " + texto.GetType());

int intVal = 42;
Console.WriteLine("Tipo de intVal: " + intVal.GetType());

// Variables de tipo implícito - agregar 2
var num1 = 1_000_000_000_000_000_000;

Console.WriteLine ("Tipo de num1: " + num1.GetType());

var precio = 19.99m;
Console.WriteLine("Tipo de precio: " + precio.GetType());

var esValido = true;
Console.WriteLine("Tipo de esValido: " + esValido.GetType());

// Constantes - agregar 2 más
const sbyte MIN_VALUE_SBYTE = -128;

Console.WriteLine("Tipo de MIN_VALUE_SBYTE: " + MIN_VALUE_SBYTE. GetType ());

const double PI = 3.141592653589793;
Console.WriteLine("Tipo de PI: " + PI.GetType());

const string NOMBRE_APLICACION = "MiPrograma";
Console.WriteLine("Tipo de NOMBRE_APLICACION: " + NOMBRE_APLICACION.GetType());
