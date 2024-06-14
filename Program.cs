﻿float numero;
Console.WriteLine("ingrese el numero:");
string numeroCadena = Console.ReadLine();
if(float.TryParse(numeroCadena,out numero)){
    string opcionCadena;
    int opcion;
    Console.WriteLine("----------CALCULADORA V2----------");
    Console.WriteLine("1: valor absoluto");
    Console.WriteLine("2: cuadrado");
    Console.WriteLine("3: raiz cuadrada");
    Console.WriteLine("4: seno");
    Console.WriteLine("5: coseno");
    Console.WriteLine("6: parte entera");
    Console.WriteLine("eliga una opcion:");
    opcionCadena = Console.ReadLine();
    if(int.TryParse(opcionCadena,out opcion)){
        switch(opcion){
            case 1:
            float valorAbsoluto = Math.Abs(numero);
            Console.WriteLine("valor absoluto "+valorAbsoluto);
            break;

            case 2:
            float cuadrado = (float)Math.Pow(numero,2);
            Console.WriteLine("cuadrado "+cuadrado);
            break;

            case 3:
            if(numero >= 0){
            float raizCuadrada = (float)Math.Sqrt(numero);
            Console.WriteLine("raiz cuadrada "+raizCuadrada);
            }
            else{
                Console.WriteLine("no se puede calcular la raiz cuadrada de un numero negativo");
            }
            break;

            case 4:
            float seno = (float)Math.Sin(numero);
            Console.WriteLine("seno "+seno);
            break;

            case 5:
            float coseno = (float)Math.Cos(numero);
            Console.WriteLine("coseno "+coseno);
            break;

            case 6:
            int parteEntera = (int)numero;
            Console.WriteLine("parte entera "+parteEntera);
            break;

            default:
            Console.WriteLine("no se eligio una opcion valida");
            break;
        }
    }
}
else{
    Console.WriteLine("no se ingreso un numero valido");
}

float numero1,numero2;
Console.WriteLine("ingrese el primer numero:");
string cadenaNumero1 = Console.ReadLine();
Console.WriteLine("ingrese el segundo numero:");
string cadenaNumero2 = Console.ReadLine();
if(float.TryParse(cadenaNumero1,out numero1) && float.TryParse(cadenaNumero2, out numero2)){
    float maximo = Math.Max(numero1,numero2);
    float minimo = Math.Min(numero1,numero2);
    Console.WriteLine("maximo "+maximo);
    Console.WriteLine("minimo "+minimo);
}
else{
    Console.WriteLine("no se ingresaron numeros validos");
}