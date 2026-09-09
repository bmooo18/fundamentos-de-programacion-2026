# Guia de programacion

## 1. Entrada y salida por consola

 Los dos son comandos

* `Console.Write` --> No agrega un salto de linea
* `Console.WriteLine` --> Agrega un salto de linea
* `Console.ReadLine()` --> Para solicitar información

```casharp
Console.WriteLine("¿Cual es tu nombre?");
string nombre = Console.ReadLine();
Console.Write("Hola ");
Console.Write( nombre + "!");
Console.WriteLine(" :)");
```

* `Console.Read()` --> Leer las teclas

* `Console.ReadKey()` --> leer un stream de texto

```casharp
// Solicitamos información al usuario
Console.WriteLine("Dame tu nombre: ");

// Leemos de forma infinita
// Ctrl + z o F6 también termina el programa
while (true)
{
    // Intercepta y muestra la tecla
    // var key = Console. ReadKey();
    // Intercepta y NO muestra la tecla
    var key = Console.ReadKey(true);

    // Si presiona Enter, salimos del bucle
    if(key.Key == ConsoleKey. Enter)
    {
        break;
    }

    // Mostramos la tecla presionada
    Console. Write(key.KeyChar);
}
```

## 2. Secuencia de escape
Utilizando dentro de la cadena, es posible hacer que tanto Console. Write como Console. WriteLine muestren caracteres que de otra forma no son posibles.

* `\n (Salto de Línea)`: Agrega una salto de línea ("Enter") al texto.
* `\t (Tabulación)`: Permite alinear bloques de texto en columnas
* `\" (Comillas Dobles)`: Si se quiere insertar una " , es necesario agregar una \ antes para distinguirla del inicio y fin.
* `\\ (Barra Invertida)`: La \ es el carácter inicial de todas las secuencias, у se utiliza para "escapar", quedando como (I cuando se quiere mostrar

```casharp
Console.WriteLine("n\n\n");
//Crear un programa que muestre atributos en forma de tabla con un bader
Console.WriteLine("Estadisticas en forma de tabla");
Console.WriteLine("/ Greg \"El Mago\" /");
Console.WriteLine("\\----------------\\");
Console.WriteLine("/ HP \t100      /");
Console.WriteLine("\\ MP \t50       \\");
Console.WriteLine("/ Gold \t2,500    /");
Console.WriteLine("\\ Exp \t150      \\");
```

## 3. Colores de fondo y texto en consola
La consola utiliza colores por defecto, por lo general:
* Fondo: Negro
* Texto: Blanco

 Es posible configurar la consola utilizando los siguientes métodos:

* `Console. ForegroundColor`: Permite asignar un color al texto
* `Console. BackgroundColor`: Permite asignar un color al fondo
  Es importante regresar los colores a los valores por defecto al terminar:
* `Console. ResetColor()`: Regresa los colores a valores por defecto

```casharp
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
```

## 4. Variables y tipos de Dato

 Variable: Guarda informacion que puede cambiar
* variable nameMe
 Constante: Fuarda informacion que NO puede cambiar
* const variable NAME_ME

### Obtener y mostrar los valores min y max de un tipo de dato

```casharp
sbyte minValorSbyte = SByte.MinValue;
sbyte maxValorSbyte = SByte.MaxValue;

Console.WriteLine("SByte");
Console.WriteLine("Minimo: " + minValorSbyte);
Console.WriteLine("Maximo: " + maxValorSbyte);
```

### Operadores aritméticos, de comparación y lógicos.
* Simbolo de la suma (+)
* Simbolo de la resta (-)
* Simbolo de la multiplicacion (*)
* Simbolo de la division (/)
* Módulo o residuo (%)

### Operadores especificos
* Simbolo de la suma (++) suma 1 al valor (num1++)
* Simbolo de la resta (--) resta 1 al valor (num1--)
* Simbolo de la multiplicacion (+) devuelve el valor sin significado (+num1)
* Simbolo de la division (-) devuelve el valor negado del valor (-num1)
```casharp
  //Operaciones Unarias: + y
// Dependiendo de si es sufijo o prefijo, el resultado cambia
//El ejemplo siguiente aplica tanto para la suma (++) como para la resta (-)

var original = 10;            // Comenzamos con 10 entero
// ++ o -- como SUFIJO
// 1. Se guarda el valor de la operación 5 + 10 en 'num2' (Original = 10)
// 2. Se incrementa el valor de 'original' en 1, y se guarda en 'original'
// Resultado: num2 = 5 + 10 = 15 y original = 10 + 1 = 11
var num2     = 5 + original; // num2 = 15

//Original vale 11 ahora
// * -- como PREFIJO
// 1. Se incrementa el valor de 'original' en 1, y se guarda en 'original'
// 2. Se guarda el valor de la operación 5 + 12 en 'num3' (Oriğinal = 12)
// Resultado: original = 12 + 1 = 13 y num3 = 5 + 12 = 17
var num3 = 5 + original; // num3 = 17

// Original vale 12 ahora
// Sugerencia: No utilizar + o -- como parte de una operación aritmética
//             Realiza en incremento/decremento antes o después de form explícita
```

### Tipo de datos

### Numeros
Los números se pueden separar con guion bajo para facilitar la lectura

* sbyte sbyteVal = -127; // Valores positivos y negativos
* byte byteVal = +255; // Solo valores positivos 
* short shortVal = -32_767; // Valores positivos y negativos 
* ushort ushortVal = +65_535; // Solo valores positivos 
* int intVal -2_147_483_647; // Valores positivos y negativos 
* uint uintVal = +4_294_967_295; // Solo valores positivos, u o U 
* long longVal = -9_223_372_036_854_775_807; //Valores positivos y negativos, l o L
* ulong ulongVal = +18_446_744_073_709_551_615; // Solo valores positivos, u o U, l o L
* int randomDash = +1_23_456_7890_1234567_4_54; // Los guiones no tienen orden especial
  
Para decimales, es necesario utilizar un sufijo 

* float = 3.141_159_265F; // Float debe llevar f o F 
* double = 3.141_159_265; // Double puede no llevar sufijo 
* double doubleVal2 = 3.141_159_265D; // o se puede utilizar D o d 
* decimal decimalVal = 3.141_159_265M; // Decimal debe llevar M o m
  
Se puede utilizar notación científica/exponencial para facilitar la lectura

* float floatValExp = 8.148_484_599e12F; // e o E denota notacion cientifica 
* double doubleValExp = 8.148_484_599E-12; // e o E soporta valores negativos
  
Existen constantes para los valores mínimos y máximos de los tipos de dato numéricos

* sbyte sbyteMin = sbyte.MinValue; // -128
* double doubleMax = double.MaxValue; // 1.79769E+

Existen una variable para valores implictos que no necesitan especificarse
* var name 

### Obtener tipo de dato
* variable.GetType()
- byte --> System.Byte
- int --> System.Int32
- float --> System.Single

```casharp
sbyte SbyteValue = 1;

Console.WriteLine("SByteValue.GetType());
```


### Texto
* string: cadenas de texto (" ")

#### Metodos de las cadenas
* Length Longitud de la cadena (No lleva paréntesis)
* Contains() Verifica si una cadena contiene a otra
* EndsWith(cadena_a_comparar) Verifica si una cadena termina con otra
* StartsWith(cadena_a_comparar) Verifica si una cadena inicia con otra
* Replace(búsqueda, reemplazo) Reemplaza todas las ocurrencias de la cadena de búsqueda por la
cadena de reemplazo
* Split(separador) Regresa un arreglo de cadenas, separadas por el separador
* SubString(inicio) Regresa una cadena de caracteres desde el índice indicado hasta el final
* SubString(inicio, fin) Regresa una cadena de caracteres desde el índice indicado hasta fin
* ToLower() Regresa la cadena con todas las letras en minúsculas
* ToUpper() Regresa la cadena con todas las letras en mayúsculas
* Trim() Elimina los espacios en blanco al inicio y fin de la cadena

```casharp
string cadena = " Esta es una cadena separada por espacios. ";

// Obtiene la longitud de la cadena
int longitud = cadena.Length;
Console.WriteLine("longitud: " + longitud); // 43 (Los espacios cuentan)

Console.WriteLine();

// Verifica si "Por" existe en la cadena
bool contienePorMayuscula = cadena.Contains("Por");
Console.WriteLine("contiene por mayuscula: " + contienePorMayuscula); // False, es sencible

Console.WriteLine();

// Verifica si "por" existe en la cadena
bool contienePorMinuscula = cadena.Contains("por");
Console.WriteLine("contiene por minuscula: " + contienePorMinuscula); // True, por existe ve

Console.WriteLine();

// Verifica si la cadena termina con un espacio en blanco
bool terminaConEspacio = cadena.EndsWith(" ");
Console.WriteLine("termina con un espacio: " + terminaConEspacio); // True (Termina con un e

Console.WriteLine();

// Verifica si la cadena empieza con la palabra "Esta"
bool comienzaConEsta = cadena.StartsWith("Esta");
Console.WriteLine("comiene con la palabra Esta: " + comienzaConEsta); // "na separada por es

Console.WriteLine();

// Separa la cadena en un arreglo de cadenas por espacios
string[] palabras = cadena.Split(' '); // ["Esta", "es", "una", "cadena", "separada", "por"
for (int i = 0; i < palabras.Length; ++i)
{
Console.WriteLine("palabra " + i + ": " + palabras[i]);
}

Console.WriteLine();

// Obtiene la cadena a partir del índice 10
string subcadena = cadena.Substring(10);
Console.WriteLine("subcadena: " + subcadena); // E (El primer caracter es un espacio)

Console.WriteLine();

// Obtiene la cadena a partir del índice 1 hasta el 2
string primerCaracter = cadena.Substring(1, 2);
Console.WriteLine("Primer caracter: " + primerCaracter); // E (El primer caracter es un espa

Console.WriteLine();

// Obtiene la cadena a partir del índice 42 (longitud - 1)
string ultimoCaracter = cadena.Substring(cadena.Length - 2, 1);
Console.WriteLine("Último caracter: " + ultimoCaracter); // . (El último caracter es un espa

Console.WriteLine();

// Reemplaza los espacios por guiones
string espaciosPorGuiones = cadena.Replace(" ", "-");
Console.WriteLine("espacios por guiones: " + espaciosPorGuiones); // "-Esta-es-una-cadena-se

Console.WriteLine();

// Convierte la cadena a minusculas
string minusculas = cadena.ToLower();
Console.WriteLine("minusculas: " + minusculas); // " esta es una cadena separada por espacio

Console.WriteLine();

// Convierte la cadena a mayusculas
string mayusculas = cadena.ToUpper();
Console.WriteLine("mayusculas: " + mayusculas); // " ESTA ES UNA CADENA SEPARADA POR ESPACIO

Console.WriteLine();

// Elimina los espacios al inicio y al final
string eliminarEspacioInicoFin = cadena.Trim();
Console.WriteLine("eliminar espacios al inicio y al final: " + eliminarEspacioInicoFin); 
```

* char: cadenas de caracteres  (' ')
* bool: true o false

### Operadores para booleanos relacionales
* Igual (==) Determina si dos valores son iguales 
* Diferente (!=) Determina si dos valores son diferentes
* Mayor que (>) Determina si un valor es mayor que otro 
* Menor que (<) etermina si un valor es menor que otro 
* Mayor o igaul que (>=) Determina si un valor es mayoro igual que otro 
* Menor o igual que (<=) Determina si un valor es menor o igual que otro

### Operadores para booleanos logicos
* Negacion, NOT (!) Convierte un booleano a su negacion (!true) = false
* Y, AND (&&) Determina si dos valores son verdaderos (true && true) = true
* O, OR (||) Determina si uno de dos valores es verdadero (true || false) = true

### 5. Mostrar valores en una cadenas

* CONCATENACION - Utiliza el signo + para concatenar
```casharp
var sentencias = 6;
var cadena1    = "Hola";
var cadena2    = "mundo";

Console. WriteLine(cadena1 + " " + cadena2 + "!" );
Console.WriteLine("Este programa tiene " + sentencias + " sentencias." );
```

* INTERPOLACIÓN - Utiliza el signo $ para denotarlo y los valores encerrados en llaves { }
```casharp
var sentencias = 6;
var cadena1 = "Hola";
var cadena2 = "mundo";

Console.WriteLine($"{cadena1} {cadena2}");
Console. WriteLine($"Este programa tiene {sentencias} sentencias.");
```

### 6. Conversiones entre tipos de dato, incluyendo parsing
* Parse --> realizar una conversion
* 
```casharpe
// De string a entero
string intStr = "123";
int numVal = int.Parse(intStr);

// Genera un error, el valor no se puede convertir
// HOLA → No tiene sentido convertirla a un número
string str = "Hola";
int    strval = int. Parse(str);

// Podemos convertir la entrada del usuario
Console.Write("Dame un número: ");
string input = Console.ReadLine();
float  floatVal = float.Parse(input);
```
* TryParse --> 

```casharpe
// 1. De string a entero de forma segura
string intStr = "123";

// Usamos "out int runval" para capturar el resultado
if (int. TryParse(intStr, out int numVal)) {
    Console.WriteLine($"Conversión exitosa: (numVal)");
}
else {
    Console.WriteLine("No se pudo convertir a enterto");
}

// 2. Manejo seguro de un valor inválido (como "No)
// Esto ya NO genera una excepción que rompa el pri la")
String str = "Hola";
if (int. TryParse(str, out int strval))
    {
        Console.WriteLine($"Conversión exitosas: (strVal)");
    }
    else
    {
        // "Hola" no es un número válido
        Console.WriteLine($"Error '(str)' no es válido");
    }
```

### 7. Condicionales: `if`, `else`, `else if` y `switch`

* If --> El if evalúa una condición booleana. Si es falso, el programa salta ese bloque
* Else --> se colcoa despues del if, se ejecuta cuando la condicion if es falsa

```casharpe
// Si la calificacion es aprobatoria o no 

Random rnd = new Random();
int calificacion = rnd.Next(0,10);
Console.WriteLine(calificacion);
if (calificacion > 5) {Console.WriteLine("es aprobatoria");}
else {Console.WriteLine("no es aprobatoria");}


Console.Write("\n\n");

Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("El número que ingresaste es: " + numero);

if (calificacion > 5) {Console.WriteLine("es aprobatoria");}
else {Console.WriteLine("no es aprobatoria");}
```

```casharpe
// Programa que pida 1 entero y imprima la vida de un jugador

Console.WriteLine("Dame su vida");
int vidaJugador  = int.Parse(Console.ReadLine());

// Programa pide el nombre y apodo del jugador 
Console.WriteLine("Dame el nombre");
String nombre  = Console.ReadLine();

Console.WriteLine("Dame el apodo");
String apodo  = Console.ReadLine();

//Pedir MP
int mana;
Console.WriteLine("Dame su MP");
var manaStr = Console.ReadLine();
//validar que sea entero
bool manaValido = int.TryParse(manaStr, out mana);
//mostrar tabla, sino mostrar error
if (manaValido == true)
{
    Console.Write("Nombre: " + nombre);
    Console.WriteLine(" \" " + apodo + " \" ");
    Console.WriteLine("HP: " + vidaJugador);
    Console.WriteLine("MP: " + mana);
}

else {Console.WriteLine("error");}
```
* else if --> Sirve para comprobar una nueva condición en secuencia si la primera condición del if fue falsa

```casharp
int calificacion = 8;
if (calificacion == 10) {
Console.WriteLine("Excelente.");
} else if (calificacion >= 7) {
Console.WriteLine("Aprobado.");
} else {
Console.WriteLine("Reprobado.");
}
```

* switch --> Permite seleccionar una accion entre multiples alternativas concretas de un mismo valor
  - case --> un posible valor
  - break --> Termina ese caso
  - default --> Ningun caso coincide

```casharp
int opcion = 1;
switch (opcion) 
{
    case 1:
        Console.WriteLine("Nueva partida");
        break;
    case 2:
        Console.WriteLine("Cargar partida");
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}
```
  - es posible combinar casos

```casharp
switch (opcion) {
case OPCION1:
    case OPCION1:
    // Se ejecuta para opción 1 
        break;
    case OPCION2:
    case OPCION3:
    // Se ejecuta para opción 2 o para opción 3  
        break;
    default:
    // Se ejecuta para cualquier otra opción  
        break;
        
      
        
char calificacion = 'B';
switch (calificacion)
{
    case 'A':
        Console.WriteLine(" ¡Excelente!");
        break;
    case 'B':
    case 'C':
        Console.WriteLine("Aprobado con buen nivel.' break");
    case 'D':
    case 'F':
        Console.WriteLine("Reprobado o en riesgo.");
        break;
    default:
        Console.WriteLine("Calificación no válida.");
        break;
}
```

### 8. Un flujo breve para analizar y resolver problemas

* Analizar el problema
* Escribir el algoritmo
* Probar y arreglar

### 9. Una referencia breve para debugging, es decir, qué hacer si mi programa no funciona.

* Lee el mensaje de error en consola
* Busca por colores donde se encuentra el problema
