// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// utlizando 3 lineas de codigo
// muestra el mensaje "Hola <NOMBRE>!"

Console.Write("Hola ");
Console.Write("Ivan");
Console.WriteLine("!");

Console.WriteLine("\n\n\n");
//Crear un programa que muestre atributos en forma de tabla con un bader
Console.WriteLine("Estadisticas en forma de tabla");
Console.WriteLine("/ Greg \"El Mago\" /");
Console.WriteLine("\\----------------\\");
Console.WriteLine("/ HP \t100      /");
Console.WriteLine("\\ MP \t50       \\");
Console.WriteLine("/ Gold \t2,500    /");
Console.WriteLine("\\ Exp \t150      \\");

Console.WriteLine("\n\n\n");
// Bnadera de Mexico en texto y color
Console.WriteLine("Bandera de México Texto");

Console. ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("MÉ");
Console. ForegroundColor = ConsoleColor.White;
Console. Write("XI");
Console. ForegroundColor = ConsoleColor.Red;
Console. Write("CO");

Console. ResetColor(); // Reiniciamos los colores
Console. WriteLine(); // Salto de línea

Console.WriteLine("Bandera de México Fondo");

// Texto en negro para el contraste
Console. ForegroundColor = ConsoleColor.Black;

Console. BackgroundColor = ConsoleColor. DarkGreen;
Console. Write("MÉ");
Console. BackgroundColor = ConsoleColor. White;
Console.Write("XI");
Console. BackgroundColor = ConsoleColor.Red;
Console. Write("CO");

Console. ResetColor(); // Reiniciamos los colores

