// See https://aka.ms/new-console-template for more information
//ejercicio longitud de cadena//
Console.WriteLine("ingrese una cadena");
string cadena = Console.ReadLine();
int longitud = cadena.Length;
Console.WriteLine("longitud "+longitud);
//ejercicio concatenar cadena//
Console.WriteLine("ingrese la segunda cadena:");
string cadena2 = Console.ReadLine();
string cadenaConcatenada = cadena+cadena2;
Console.WriteLine("cadena concatenada: "+cadenaConcatenada);
//extraer subcadena//
Console.WriteLine("indique el indice donde empezara la subcadena");
string indiceCadena = Console.ReadLine();
int indice;
if(int.TryParse(indiceCadena,out indice)){
    string subcadena = cadenaConcatenada.Substring(indice);
    Console.WriteLine("subcadena "+subcadena);
}


