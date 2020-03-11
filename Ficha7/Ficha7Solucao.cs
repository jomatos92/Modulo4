using System;

namespace Ficha7
{
    public class Ficha7Solucao
    {
        #region Ex1
        public static void Exercicio1()
        {

            Console.WriteLine("Nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            if (nota1 >= 9.44)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Passou");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Chumbou");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }


        #endregion

        public static void Exercicio2()
        {
            double altura, peso, bmi;
            Console.WriteLine("Diga a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Diga o peso: ");
            peso = double.Parse(Console.ReadLine());
            bmi = peso / (altura * altura);

            if (bmi < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if ((bmi >= 18.5) && (bmi <= 24.9))
            {
                Console.WriteLine("Normal");

            }
            else if ((bmi >= 25) && (bmi <= 29.99))
            {
                Console.WriteLine("Está acima do peso");
            }
            else if (bmi > 30)
            {
                Console.WriteLine("É obeso");
            }
            Console.WriteLine("O seu BMI é " + bmi);
            Console.ReadLine();


        }
        #region
        public static void Exercicio3()
        {


            int num;
            Console.WriteLine("Diga um número: ");
            num = int.Parse(Console.ReadLine());

            if(num % 3 == 0 && num % 3 == 0)
            {
                Console.WriteLine("É múltiplo de 3 e 7 ");
            }
            else if( num % 3 == 0)
            {
                Console.WriteLine("É múltiplo apenas de 3");
            }
            else if( num % 7 == 0)
            {
                Console.WriteLine("É múltiplo apenas de 7");
               
            }
            else
            {
                Console.WriteLine("Não é múltiplo nem de 3 nem de 7");
                Console.ReadKey();
            }

            

          

            
        }
        #endregion

        #region Exercise4
        public static void Exercise4()
        {
            Console.WriteLine("Diga um número: ");
            int a = int.Parse(Console.ReadLine());

            if ((a >= 30 && a <= 50))
            {
                Console.WriteLine("O número está entre 30 e 50 ");
                Console.ReadLine();




            }
            else if (a < 30)
            {
                Console.WriteLine("O número é menor que 30 ");
                Console.ReadLine();
            }

            if (a > 50)
            {
                Console.WriteLine("O número é maior que 50 ");
                Console.ReadLine();
            }



    

}
        #endregion

        public static void Exercise5()
        {
            Console.WriteLine("Diga um número: ");
            int a = int.Parse(Console.ReadLine());
            if ((a >= 10 && a < 20))
            {
                Console.WriteLine("O valor está entre 10 e 20");
                Console.ReadLine();
            }
            else if (a < 10)
            {
                Console.WriteLine("O valor é menor que 10");
                Console.ReadLine();
            }
            if (a > 20)
            {
                Console.WriteLine("O valor é maior que 20");
                Console.ReadLine();
            }
        }
        public static void Exercise6()
        {
            Console.WriteLine("Diga o andar: ");
            int floor = int.Parse(Console.ReadLine());
             if ((floor >= -2 && floor < 6) == true)
            {
                Console.WriteLine("Piso disponivel");
                Console.ReadLine();
            }

           
            


        }
    }
}





