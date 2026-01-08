////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                             STRINGS                                                //
////////////////////////////////////////////////////////////////////////////////////////////////////////


/*INTERPOLACIÓN DE CADENAS
 * 
 * Se trata de concatenar variables y texto de una manera más legible y sencilla 
 * utilizando el símbolo $ antes de la cadena y cualquier expresión de C# que devuelva 
 * un valor dentro de llaves { }.
*/

string name;
int age;
name = "Danny";
age = 19;
Console.WriteLine($"Hola, mi nombre es {name} y tengo {age} años.");

/*CARÁCTERES DE ESCAPE
 * Salto de línea: \n
 *      Añade un salto de línea en la cadena.
 * Tabulación: \t
 *      Añade una tabulación en la cadena.
 * Ignorar el siguiente carácter: \\
 *      Ignora el carácter especial siguiente, permitiendo incluir comillas dobles o barras invertidas.
*/
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("She said, \"Hello!\"");
Console.WriteLine("c:\\source\\repos");

/*CADENAS TEXTUAL
 *Conservan todos los espacios en blanco, saltos, tabulaciones y los caracteres sin necesidad de usar 
 *una secuencia de escape para la barra diagonal inversa. 
 *Para crear una cadena textual, use la directiva @ antes de la cadena literal.
*/
string textualLiteralString = @"Generating invoices for customer ""Contoso Corp"" ...

Invoice: 1021           Complete!
Invoice: 1022           Complete!

Output Directory:   c:\invoices";
Console.WriteLine(textualLiteralString);

/*CARACTERES UNICODE
 * Agrega caracteres codificados en cadenas literales mediante la secuencia de escape \u y, 
 * después, un código de cuatro caracteres que represente algún carácter en Unicode (UTF-16).
 * Un ejemplo de uso, es imprimir un mensaje en japonés o ruso.
 * Es importante mencionar que no todas las consolas muestran estos carácteres.
*/

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

/*COMBINACIÓN DE INTERPOLACIÓN Y CADENAS TEXTUALES
 *Es posibleusar el símbolo @ de prefijo literal textual y el símbolo de interpolación de $ cadenas juntos.
*/

string projectName = "First-Project", developmentName = "Daniela";

Console.WriteLine(@$"Hola, mi nombre es {developmentName} y mi proyecto se llama {projectName}.
La ruta del proyecto es:
C:\Output\{projectName}\Data");


/*MÉTODOS COMUNES DE LA CLASE STRING
 * Trim(): Elimina los espacios en blanco al inicio y al final de una cadena
 * TrimStart(): Elimina los espacios en blanco al inicio de una cadena
 * TrimEnd(): Elimina los espacios en blanco al final de una cadena
*/

string textoPrueba = "      Hola        ";
Console.WriteLine('[' + textoPrueba + ']');
Console.WriteLine('[' + textoPrueba.Trim() + ']');
Console.WriteLine('[' + textoPrueba.TrimStart() + ']');
Console.WriteLine('[' + textoPrueba.TrimEnd() + ']');
//Nota: Este método solo es temporal, para modificar permanentemente una cadena se debe reasignar el valor de su variable
textoPrueba = textoPrueba.Trim();
Console.WriteLine('[' + textoPrueba + ']');

/* ToUpper(): Convierte todos los caracteres de una cadena a mayúsculas
 * ToLower(): Convierte todos los caracteres de una cadena a minúsculas
 * Nota: Al igual que Trim(), estos métodos no modifican la cadena original
*/
string texto = "Hola Mundo";
Console.WriteLine(texto.ToLower());
Console.WriteLine(texto.ToUpper());
Console.WriteLine(texto);

/* Replace(): Reemplaza todas las apariciones de un carácter o una subcadena por otro carácter o subcadena
 * Utiliza dos parámetros: el primero es el carácter o subcadena a buscar, y el segundo es el carácter o subcadena por el cual se reemplazará
 * Nota: Al igual que Trim(), estos métodos no modifican la cadena original a menos que se reasigne su valor en la variable
 */
string frase = "El gato se subió al tejado del gato";
Console.WriteLine(frase.Replace("gato", "perro"));
Console.WriteLine(frase);
frase = frase.Replace("gato", "perro");
Console.WriteLine(frase);

/* Contains(): Verifica si una cadena contiene una subcadena específica
 * Devuelve un valor booleano (true o false)
 */
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
Console.WriteLine(songLyrics.Contains("goodbye      "));

/*StartsWith(): Booleano que verifica si una cadena comienza con una subcadena específica
 *EndsWith(): Booleano que verifica si una cadena termina con una subcadena específica
*/
Console.WriteLine(songLyrics.StartsWith("You say"));
Console.WriteLine(songLyrics.EndsWith("hello"));