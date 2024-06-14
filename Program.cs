// See https://aka.ms/new-console-template for more information
int seguir = 1;
string seguirCadena;
do{
int numero1,numero2;
Console.WriteLine("ingrese el primero numero:");
string cadenaNumero1 = Console.ReadLine();
Console.WriteLine("ingrese el segundo numero:");
string cadenaNumero2 = Console.ReadLine();
if(int.TryParse(cadenaNumero1, out numero1) && int.TryParse(cadenaNumero2,out numero2)){
    int operacion;
    string cadena;
    Console.WriteLine("1: suma");
    Console.WriteLine("2: resta");
    Console.WriteLine("3: producto");
    Console.WriteLine("4: division");
    Console.WriteLine("eliga una operacion:");
    cadena = Console.ReadLine();
    if(int.TryParse(cadena,out operacion)){
        switch(operacion){
            case 1:
            int suma = numero1+numero2;
            Console.WriteLine("resultado "+suma);
            break;

            case 2:
            int resta = numero1-numero2;
            Console.WriteLine("resultado "+resta);
            break;

            case 3:
            int producto = numero1*numero2;
            Console.WriteLine("resultado "+producto);
            break;

            case 4:
            if(numero2 != 0){
                float cociente = (float)numero1/(float)numero2;
                Console.WriteLine("resultado "+cociente);
            }
            else{
                Console.WriteLine("no se puede dividir por 0");
            }
            break;
    }
    
}
else{
    Console.WriteLine("No se eligio una opcion valida");
}
}
else{
    Console.WriteLine("uno o ambos numeros no son validos");
}
Console.WriteLine("1 para realizar otra operacion");
seguirCadena = Console.ReadLine();
int.TryParse(seguirCadena,out seguir);
}while(seguir == 1);