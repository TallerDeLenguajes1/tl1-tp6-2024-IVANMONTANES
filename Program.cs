int seguir = 0;
do{
Console.WriteLine("ingrese el primer numero:");
string cadenaNumero1 = Console.ReadLine();
Console.WriteLine("ingrese el segundo numero:");
string cadenaNumero2 = Console.ReadLine();
int numero1 = 0,numero2 = 0,sonValidos = 0;
if(int.TryParse(cadenaNumero1, out numero1) && int.TryParse(cadenaNumero2, out numero2)){
    sonValidos = 1;
}
if(sonValidos == 1){
    string operacionCadena;
    int resultado,operacion;
    Console.WriteLine("----------CALCULADORAV1----------");
    Console.WriteLine("1: suma");
    Console.WriteLine("2: resta");
    Console.WriteLine("3: producto");
    Console.WriteLine("4: division");
    Console.WriteLine("eliga una operacion");
    operacionCadena = Console.ReadLine();
    int.TryParse(operacionCadena, out operacion);
    switch(operacion){
        case 1: 
        resultado = numero1 + numero2; 
        Console.WriteLine("la suma de "+numero1.ToString()+"+"+numero2.ToString()+" es igual a "+resultado.ToString());
        break;
        case 2:
        resultado = numero1 - numero2; 
        Console.WriteLine("la resta de "+numero1.ToString()+"-"+numero2.ToString()+" es igual a "+resultado.ToString());
        break;
        case 3:
        resultado = numero1 * numero2; 
        Console.WriteLine("el producto de "+numero1.ToString()+"*"+numero2.ToString()+" es igual a "+resultado.ToString());
        break;
        case 4:
        if(numero2 != 0){
            resultado = numero1 / numero2;
            Console.WriteLine("el cociente de "+numero1.ToString()+"/"+numero2.ToString()+" es igual a "+resultado.ToString());
        }
        else{
            Console.WriteLine("No se puede dividir en 0");
        }
        break;
        default: Console.WriteLine("no se ingreso una operacion valida"); break;
    }
}
else{
    Console.WriteLine("no se ingresaron numeros validos");
}
    Console.WriteLine("1 para seguir");
    string cadenaSeguir = Console.ReadLine();
    int.TryParse(cadenaSeguir, out seguir);
}while(seguir == 1);

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