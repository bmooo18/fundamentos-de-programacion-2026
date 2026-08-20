// Ejemplo: Obtener y mostrar los valores minimos y maximos de un tipo de dato

sbyte minValorSbyte = SByte.MinValue;
sbyte maxValorSbyte = SByte.MaxValue;

Console.WriteLine("SByte:");
Console.WriteLine("Minimo: " + minValorSbyte);
Console.WriteLine("Maximo: " + maxValorSbyte);

// Simbolo de la suma +
// Simbolo de la resta -
// simbolo de la multiplicacion *
// simbolo de la division /

Console.WriteLine("\n\n\n");
// Ejercico: Utilizar dos tipos de datos diferentes al anterior
// uno entero y otro decimal, y mostrar sus valores maximos y minimos
//      1. mostrar los valores min y max
//      2. multiplicar el valor maximo por 10 y mostrar resultado
//      3. multiplicar el valor minimo por 10 y mostrar resultado

// sbyte, byte, short, ushort, int,, uint, long, ulong
// float, double, decimal

byte minValorByte = Byte.MinValue;
byte maxValorByte = Byte.MaxValue;

Console.WriteLine("Byte:");
Console.WriteLine("Minimo: " + minValorByte);
Console.WriteLine("Valor minimo * 10 = " + minValorByte * 10);
Console.WriteLine("Maximo: " + maxValorByte);
Console.WriteLine("Valor maximo * 10 = " + maxValorByte * 10);


Console.WriteLine("\n\n");
float minValorFloat = float.MinValue;
float maxValorFloat = float.MaxValue;

Console.WriteLine("Float:");
Console.WriteLine("Minimo: " + minValorFloat);
Console.WriteLine("Valor minimo * 10 = " + minValorFloat * 10);
Console.WriteLine("Maximo: " + maxValorFloat);
Console.WriteLine("Valor maximo * 10 = " + maxValorFloat * 10);


Console.WriteLine("\n\n\n");
// Genera un programa en donde utilices 5 variables
// Utiliza una mezcla de:
// - Asignacion
// - Declaracion
// - Asignacion + Declaracion
// Imprime los valores de las variables y constantes

Console.WriteLine("variables:");
int    anos   = 18;
Console.WriteLine("años: " + anos);
string nombre = "Ivan";
Console.WriteLine("nombre: " + nombre);
char   genero = 'M';
Console.WriteLine("genero: " + genero);
bool   esUniversitario = true;
Console.WriteLine("es universitario: " + esUniversitario);
float  altura = 1.75f;
Console.WriteLine("altura: " + altura);
double salario = 4790;
Console.WriteLine("salario: " + salario);

Console.WriteLine("\n\n");
Console.WriteLine("constantes:");
const int    ANOS   = 18;
Console.WriteLine("años: " + ANOS);
const string NOMBRE = "Ivan";
Console.WriteLine("nombre: " + NOMBRE);
const char   GENERO = 'M';
Console.WriteLine("genero: " + GENERO);
const bool   ES_UNIVERSITARIO = true;
Console.WriteLine("es universitario: " + ES_UNIVERSITARIO);
const float  ALTURA = 1.74f;
Console.WriteLine("altura: " + ALTURA);
const double SALARIO = 4790;
Console.WriteLine("salario: " + SALARIO);
