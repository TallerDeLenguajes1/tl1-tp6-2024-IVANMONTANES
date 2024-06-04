﻿// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);*/

int numero;
Console.WriteLine("ingrese un numero");
string numeroCadena = Console.ReadLine();
if(int.TryParse(numeroCadena,out numero)){
    int resto;
    int resultado = numero;
    int numeroInvertido = 0;
    while(resultado != 0){
        resto = resultado % 10;
        resultado /= 10;
        numeroInvertido = numeroInvertido * 10 + resto;
    }
    Console.WriteLine("numero invertido "+numeroInvertido);
}
else{
    Console.WriteLine("no se ingreso un numero valido");
}