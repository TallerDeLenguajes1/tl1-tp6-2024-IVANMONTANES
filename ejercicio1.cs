int numero = leerNumero();
int numeroInvertido = 0;
invertirNumero(ref numero, ref numeroInvertido);

static int leerNumero()
{
    string edadCadena;
    int numero;

    do{
        Console.WriteLine("Ingrese su edad:");
        edadCadena = Console.ReadLine();

        if(!int.TryParse(edadCadena, out numero)){
            Console.WriteLine("no es un numero valido");
        }

    }while(!int.TryParse(edadCadena,out numero));

    return numero;
}

static void invertirNumero(ref int numero, ref int numeroInvertido)
{
    if (numero != 0)
    {
        while (numero != 0)
        {
            int digito = numero % 10;
            numeroInvertido = numeroInvertido * 10 + digito;
            numero /= 10;
        }
        Console.WriteLine("numero invertido: " + numeroInvertido);
    }
    else
    {
        Console.WriteLine("numero invertido: " + numeroInvertido);
    }
}