// See https://aka.ms/new-console-template for more information
string seguirEjercicioC;
int seguirEjercicio;
do{
Console.WriteLine("1: ejercicio 1");
Console.WriteLine("2: ejercicio 2");
Console.WriteLine("3: ejercicio 3");
Console.WriteLine("4: ejercicio 4");
Console.WriteLine("eliga el ejercicio:");
string elegirEjercicioC = Console.ReadLine();
int elegirEjercicio;
if(int.TryParse(elegirEjercicioC,out elegirEjercicio)){
    switch(elegirEjercicio){
        case 1:
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
        break;

        case 2:
            int seguir = 0;
            do{
            Console.WriteLine("ingrese el primer numero:");
            string cadenaNumero1C1 = Console.ReadLine();
            Console.WriteLine("ingrese el segundo numero:");
            string cadenaNumero2C1 = Console.ReadLine();
            int numero1C1 = 0,numero2C1 = 0,sonValidos = 0;
            if(int.TryParse(cadenaNumero1C1, out numero1C1) && int.TryParse(cadenaNumero2C1, out numero2C1)){
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
                    resultado = numero1C1 + numero2C1; 
                    Console.WriteLine("la suma de "+numero1C1.ToString()+"+"+numero2C1.ToString()+" es igual a "+resultado.ToString());
                    break;
                    case 2:
                    resultado = numero1C1 - numero2C1; 
                    Console.WriteLine("la resta de "+numero1C1.ToString()+"-"+numero2C1.ToString()+" es igual a "+resultado.ToString());
                    break;
                    case 3:
                    resultado = numero1C1 * numero2C1; 
                    Console.WriteLine("el producto de "+numero1C1.ToString()+"*"+numero2C1.ToString()+" es igual a "+resultado.ToString());
                    break;
                    case 4:
                    if(numero2C1 != 0){
                        resultado = numero1C1 / numero2C1;
                        Console.WriteLine("el cociente de "+numero1C1.ToString()+"/"+numero2C1.ToString()+" es igual a "+resultado.ToString());
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
        break;

        case 3:
                float numeroC2;
                Console.WriteLine("ingrese el numero:");
                string numeroCadena = Console.ReadLine();
                if(float.TryParse(numeroCadena,out numeroC2)){
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
                            float valorAbsoluto = Math.Abs(numeroC2);
                            Console.WriteLine("valor absoluto "+valorAbsoluto);
                            break;

                            case 2:
                            float cuadrado = (float)Math.Pow(numeroC2,2);
                            Console.WriteLine("cuadrado "+cuadrado);
                            break;

                            case 3:
                            if(numeroC2 >= 0){
                            float raizCuadrada = (float)Math.Sqrt(numeroC2);
                            Console.WriteLine("raiz cuadrada "+raizCuadrada);
                            }
                            else{
                                Console.WriteLine("no se puede calcular la raiz cuadrada de un numero negativo");
                            }
                            break;

                            case 4:
                            float seno = (float)Math.Sin(numeroC2);
                            Console.WriteLine("seno "+seno);
                            break;

                            case 5:
                            float coseno = (float)Math.Cos(numeroC2);
                            Console.WriteLine("coseno "+coseno);
                            break;

                            case 6:
                            int parteEntera = (int)numeroC2;
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
        break;

        case 4:
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
            foreach(char letra in cadena){
            Console.WriteLine(letra);
            }
            Console.WriteLine("ingrese una cadena:");
            string cadenaNueva = Console.ReadLine();
            Console.WriteLine("ingrese una cadena para ver si hay ocurrencia:");
            string cadenaOcurrencia = Console.ReadLine();
            int indice2 = cadenaNueva.IndexOf(cadenaOcurrencia);
            if(indice2 != -1){
                Console.WriteLine("si se encuentra la cadena "+cadenaOcurrencia+" en el indice "+indice2);
            }
            else{
                Console.WriteLine("no se encuentra la cadena "+cadenaOcurrencia);
            }
            Console.WriteLine("ingrese la cadena");
            string cadenaAConvertir = Console.ReadLine();
            Console.WriteLine("cadena en miniscula "+cadenaAConvertir.ToLower());
            Console.WriteLine("cadena en miniscula "+cadenaAConvertir.ToUpper());
            Console.WriteLine("ingrese una cadena separada por espacios");
            string cadenaSeparadaEspacios = Console.ReadLine();
            string[] cadenaSinEspacios = cadenaSeparadaEspacios.Split(" ");
            foreach(string letra in cadenaSinEspacios){
                Console.WriteLine(letra);
            }
            break;
            default: Console.WriteLine("no se eligio una opcion valida"); break;
            }
        }
        Console.WriteLine("1 para seguir");
        seguirEjercicioC = Console.ReadLine();
        int.TryParse(seguirEjercicioC,out seguirEjercicio);
}while(seguirEjercicio == 1);







