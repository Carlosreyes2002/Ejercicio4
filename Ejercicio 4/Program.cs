using System;
class Program {
    static double Calculadora(string operacion, double numero1, double numero2) {
        double resultado = 0;
        
        try {
            switch (operacion) {
                case "SUMA":
                    resultado = numero1 + numero2;
                    break;
                case "RESTA":
                    resultado = numero1 - numero2;
                    break;
                case "MULTIPLICACION":
                    resultado = numero1 * numero2;
                    break;
                case "DIVISION":
                    if (numero2 == 0) {
                        resultado = -1;
                    } else {
                        resultado = numero1 / numero2;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
        } catch (Exception e) {
            Console.WriteLine("Ha ocurrido un error: " + e.Message);
        }
        
        return resultado;
    }
    
    static void Main(string[] args) {
        Console.WriteLine(Calculadora("SUMA", 4, 3)); 
        Console.WriteLine(Calculadora("RESTA", 7, 5)); 
        Console.WriteLine(Calculadora("MULTIPLICACION", 4, 6));
        Console.WriteLine(Calculadora("DIVISION", 10, 2)); 
        Console.WriteLine(Calculadora("DIVISION", 8, 0)); 
    }
}
