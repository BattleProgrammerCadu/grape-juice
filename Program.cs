using System;

namespace grapeJuice
{
    class Program
    {
            // Função do dado, returna um numero aleatorio de 1 a 6
            private int Dado(){
                Random rnd = new Random();
                return rnd.Next(1,6);  
            }
            //Função Combat, retorna o resultado do opção escolhida
            int Combat(int opcao,Personagem atacante, Personagem denfensor){
                switch (opcao)
                {
                    //1-ATAQUE
                    case 1:
                     return atacante.SEThp(atacante.GETatk()-denfensor.GETdef());
                    
                    default: 
                    return 4;  
                {
                    
                }
                                 
                    
                }    
            }
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem(5,1,1,1);
            Personagem p2 = new Personagem(3,2,1,2);
            Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");
            Console.WriteLine($"Personagem 2 atacando Personagem 1....");
            Console.WriteLine($"-----------MENU COMBAT--------------");
            Console.WriteLine($"1-Atacar");
            Console.WriteLine($"2-Defender");
            Console.WriteLine($"3-Evasiva");
            string[] escolha = Console.ReadLine().Split(" ");
            int _op = int.Parse(escolha[0]);
            int resposta =Combat(_op,p2,p1);
            
            Console.WriteLine($"-----------------------------------------");
            /* 
               P1   |  P2
            hp=5    |hp=3
            atk=1   |atk=2
            def=1   |def=1
            evs=1   |evs=2
            */
            Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");
            Console.WriteLine($"-----------------------------------------");
            Console.WriteLine($"Personagem 1 atacando Personagem 2....");

            /* 
               P1   |  P2
            hp=4   |hp=3
            atk=1   |atk=2
            def=1   |def=1
            evs=1   |evs=2
            */
            //p2.SEThp(p1.GETatk() - p2.GETdef());
            //Console.WriteLine($"Vida do personagem 1= {p1.GEThp()}");
            //Console.WriteLine($"Vida do personagem 2= {p2.GEThp()}");

             
        }    
    }
}
