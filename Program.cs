// See https://aka.ms/new-console-template for more information
string cadenaNumero;
int numero;
Console.WriteLine("ingrese un numero:");
cadenaNumero = Console.ReadLine();
if(int.TryParse(cadenaNumero, out numero)){
    int ultimoDigito;
    int cociente = numero;
    int invertido = 0;
    while(cociente != 0){
        ultimoDigito = cociente % 10;
        cociente = cociente / 10;
        invertido = invertido * 10 + ultimoDigito;
    }
    Console.WriteLine("numero invertido "+invertido);
}
else{
    Console.WriteLine("no es un numero");
}