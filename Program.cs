using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Variáveis em C#");
        
        //Integral assinado
        sbyte num1 = 10; //8 bits, de -128 a 127
        short num2 = 20; // 16 bits, de -32.768 a 32.767
        int num3 = 30; // 32 bits, de -2.147.483.648 a 2.147.483.647
        long num4 = 40L; // 64 bits, de -9.223.372.036.775.808 a 9.223.372.036.854.775.807

        //Integral não assinado
        byte num5 = 10; // 8 bits, intervalo de 0 a 255
        ushort num6 = 20; //16 bits, de 0 a 65.535
        uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
        ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

        //Strings

        string PC = "Computador";
        double Tamanho = 1.2;
        float Peso = 10.5f;
        bool Ligado = false;
        var Nome = "Daniel"; //Variáveis que não se sabe o valor
        
        //Casos especiais
        const int DescobrimentoBrasil = 1500;
        object LetraInicial = 'B';
        Console.ReadKey();
    }
}
