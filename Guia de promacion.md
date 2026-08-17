# Guia de programacion

## Console.Write y Console.WriteLine

 Los dos son comandos

* `Console.Write` --> No agrega un salto de linea
* `Console.WriteLine` --> Agrega un salto de linea

```casharp
Console.Write("Hola ");
Console.Write("Ivan!");
Console.WriteLine(":)");
```

## Secuencia de escape
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

## Colores de fondo y texto en consola
La consola utiliza colores por defecto, por lo general:
* Fondo: Negro
* Texto: Blanco

#### Es posible configurar la consola utilizando los siguientes métodos:

* `Console. ForegroundColor`: Permite asignar un color al texto
* `Console. BackgroundColor`: Permite asignar un color al fondo
  Es importante regresar los colores a los valores por defecto al terminar:
* `Console. ResetColor()`: Regresa los colores a valores por defecto