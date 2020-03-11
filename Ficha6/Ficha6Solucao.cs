using System;

namespace Ficha6
{
    public class Ficha6Solucao
    {
        //    #region Exercicio1
        //    public static void Exercicio1()
        //    {
        //        Console.WriteLine("Qual é o nome? ");
        //        var nome = Console.ReadLine();
        //        OlaNome(nome);
        //    }

        //    private static void OlaNome(string nome)
        //    {
        //        Console.WriteLine("Olá " + nome);

        //    }
        //}
        //#endregion
        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);

        }
        public static int ConverterStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            if (parseOk)
            {
                return parsedNum;
            }
            return 0;
        }
        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
        }
        public static int LerNumEConverter()
        {
            Console.WriteLine("Numero?");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;




        }
        public static void Exercicio3()
        {
            var acumulador = LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            Console.WriteLine(acumulador);
        }
        //#region
        ////public void Exercicio4()
        ////{
        ////    Console.WriteLine("Primeiro número: ");
        ////     int.TryParse(Console.ReadLine(), out int num1);
        ////    Console.WriteLine("Segundo número: ");
        ////    int.TryParse(Console.ReadLine(), out int num2);
        ////    var aux = 0;
        ////    aux = num1;
        ////    num1 = num2;
        ////    num2 = aux;
        ////    Console.WriteLine("Primeiro número" + num1 + "\nSegundo Número" + num2);
        //}
        //#endregion
        public static void Exercicio5a()
        {
            Console.WriteLine("Primeiro número: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro número: ");
            var num3 = int.Parse(Console.ReadLine());
        }
        private static void CalcNum(int num1, int num2, int num3)
        {
            var r = num1 + num2 * num3;
            Console.WriteLine("O resultado é", r);


        }

    public static void Exercicio5b()
        {
            Console.WriteLine("Primeiro número: ");
            var num1 =ConverterStringParaNumero(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            var num2 =int.Parse (Console.ReadLine());
            Console.WriteLine("Terceiro número: ");
            var num3 = ConverterStringParaNumero(Console.ReadLine());
            var calc = (num1 + num2) % num3;
            Console.WriteLine(num1 + " + " + num2 + " % " + num3 + " = " + calc);
        }
        #endregion
        #region
        public static void Exercicio5C()
        {
           Console.WriteLine("Primeiro número: ");
            var num1 = ~int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro número: ");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quarto número: ");
            var num4 = int.Parse(Console.ReadLine());
            var calcular = num1 + num2 * num3 / num4;
            Console.WriteLine(num1 + " + " + num2 + " * "  + num3 + "/" + num4 + " = " + calcular);
        }

        public static void Exercicio5d()
        {
            Console.WriteLine("Primeiro número: ");
            var num1 = ~int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro número: ");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quarto número: ");
            var num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quinto número: ");
            var num5= int.Parse(Console.ReadLine());

            var calcular = num1 + num2 / num3 - num4 % num5;
            Console.WriteLine(num1 + " + " + num2 + " / " + num3 + " - " + num4 + "%"+ num5 +" = " + calcular);
        }
        public static void Exercicio7()
        {

            Console.WriteLine("Número 1: ");
            var num1 = Console.ReadLine();
            Console.WriteLine("Número 2: ");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarMedia(num1Conv, num2Conv);

        }
        public static void ApresentarMedia(int num1, int num2)

        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }

        public static void Exercicio8()
        {
            Console.WriteLine("Número 1: ");
            var num1 = Console.ReadLine();
            Console.WriteLine("Número 2: ");
            var num2 = Console.ReadLine();
            Console.WriteLine("Número 3:");
            var num3 = Console.ReadLine();
            Console.WriteLine("Número 4: ");
            var num4 = Console.ReadLine();
            Console.WriteLine("Número 5: ");
            var num5 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            var num3Conv = ConverterStringParaNumero(num3);
            var num4Conv = ConverterStringParaNumero(num4);
            var num5Conv = ConverterStringParaNumero(num5);
            ApresentarMedia2(num1Conv, num2Conv, num3Conv, num4Conv, num5Conv);




        }
        public static void ApresentarMedia2(int num1, int num2, int num3, int num4, int num5)
        {
            Console.WriteLine(num1 + " / " + num2 + " / " + num3 + " / " + num4 + " / " + num5 + " = " + (num1 / num2 / num3 / num4 / num5));
        }

        public static void Exercicio9()
        {
            Console.WriteLine("Número 1: ");
            var num1 = Console.ReadLine();
            Console.WriteLine("Número 2: ");
            var num2 = Console.ReadLine();
            Console.WriteLine("Número 3:");
            var num3 = Console.ReadLine();
            Console.WriteLine("Número 4: ");
            var num4 = Console.ReadLine();
            Console.WriteLine("Número 5: ");
            var num5 = Console.ReadLine();
            Console.WriteLine("Número 6: ");
            var num6 = Console.ReadLine();
            Console.WriteLine("Número 7: ");
            var num7 = Console.ReadLine();
            Console.WriteLine("Número 8:");
            var num8 = Console.ReadLine();
            Console.WriteLine("Número 9: ");
            var num9 = Console.ReadLine();
            Console.WriteLine("Número 10: ");
            var num10 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            var num3Conv = ConverterStringParaNumero(num3);
            var num4Conv = ConverterStringParaNumero(num4);
            var num5Conv = ConverterStringParaNumero(num5);
            var num6Conv = ConverterStringParaNumero(num6);
            var num7Conv = ConverterStringParaNumero(num7);
            var num8Conv = ConverterStringParaNumero(num8);
            var num9Conv = ConverterStringParaNumero(num9);
            var num10Conv = ConverterStringParaNumero(num10);
            ApresentarMedia3(num1Conv, num2Conv, num3Conv, num4Conv, num5Conv, num6Conv, num7Conv, num8Conv, num9Conv, num10Conv);


            #endregion
        }
        public static void ApresentarMedia3(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10)
        {
            Console.WriteLine(num1 + " / " + num2 + " / " + num3 + " / " + num4 + " / " + num5 +" / " +  num6 + " / " + num7 + " / " + num8 + "/ " + num9 + " / " + num10 + " = "  + (num1 / num2 / num3 / num4 / num5/ num6 / num7 / num8 / num9 / num10));


        }
        public static void Exercicio10()
        {
            Console.WriteLine("Digite um caracter");
            var c = Console.ReadLine();

            Console.WriteLine(c + c + c);
            Console.WriteLine(c + c + c);
            Console.WriteLine(c + c + c);
        }
        public static void Exercicio11()
        {
           // int quantidade = 0;
            int quant1 = 0;
            int quant2 = 0;
            double total = 0;

            Console.WriteLine("Diga o nome do primeiro produto: ");
            var prod1 = (Console.ReadLine());
            Console.WriteLine("Diga o preço do produto: ");
            var preco1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga a quantidade desejada: ");
            quant1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Diga o nome do segundo produto: ");
            var prod2 = (Console.ReadLine());
            Console.WriteLine("Diga o preço do segundo produto: ");
            var preco2 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Diga a quantidade desejada do segundo produto: ");
             quant2 = int.Parse(Console.ReadLine());
            ValorTotal(total);



            
        }
        private static void ValorTotal(double preco1 = 0, double preco2 = 0, int quantidade = 0, double preco_total=0, int quant1 = 0, int quant2=0, double total=0)
        {
             preco_total = preco1 + preco2;
            quantidade = quant1 + quant2 * 2;
            total = preco_total * quantidade;
            Console.WriteLine("O valor total é: ", total);

            Console.ReadKey();
        }



    }
}



