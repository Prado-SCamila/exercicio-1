using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idade para votar");

          
            int idade;

            Console.WriteLine("Digite seu ano de nascimento");
            int an = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ano atual");
            int aa = int.Parse(Console.ReadLine());

            idade = aa- an;

            Console.WriteLine(idade);

            if(idade<18){
                Console.WriteLine("Você não pode votar ainda.");

            }else{
                Console.WriteLine("Você pode votar.");
            }
        }
    }
}
