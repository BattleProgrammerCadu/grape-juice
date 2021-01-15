using System;

namespace grapeJuice
{
    public class main
    {
        // Função do dado, returna um numero aleatorio de 1 a 6
         private static int Dado(){
                Random rnd = new Random();
                return rnd.Next(1,6);  
        }
        //Função Combat, executa as duas rodadas do combate
        //1ª rodada = atacante joga os dados para atacar e o defensor escolhe entre defender e evadir
        //O dano é calculado após os dois jogarem o dado
        //Condição para o dano se defesa: se atk > def o dano é = atk - def, se def > atk o dano é = 1
        //Condição para o dano se evasão: se atk > evs o dano é = atk , se evs > atk o dano é = 0
       static void Combat(Personagem atacante, Personagem defensor){
            int neymar,zeRoberto,hulk=0;
            Console.WriteLine($"O {atacante.GETname()} está atacando..\nAções Disponiveis:\n1- Atacar");
            int opAtk = Convert.ToInt32(Console.ReadLine());
             neymar = atk(atacante);
            Console.WriteLine($"{atacante.GETname()} tirou {neymar}\n");
            Console.WriteLine($"O {defensor.GETname()} está escolhendo uma ação..\nAções Disponiveis:\n1- Defender\n2- Evasiva");
            int opDef = Convert.ToInt32(Console.ReadLine());
            zeRoberto = def(opDef,defensor);
            Console.WriteLine($"{defensor.GETname()} tirou {zeRoberto}\n");
            switch(opDef){
                case 1:
                    if(neymar > zeRoberto){
                        hulk =  neymar - zeRoberto;
                        Console.WriteLine($"Dano = {neymar - zeRoberto}");
                        defensor.SEThp(neymar - zeRoberto);
                    }else{
                        hulk = 1;
                        Console.WriteLine("Dano = 1");
                        defensor.SEThp(1);
                    }
                break;
                case 2:
                    if(neymar > zeRoberto){
                        hulk = neymar;
                        Console.WriteLine($"Dano = {neymar}");
                        defensor.SEThp(neymar);
                    }else{
                        hulk = 0;
                        Console.WriteLine("Dano = 0");
                        defensor.SEThp(0);
                    }
                break;
                default:
                break;
            }
           
        }
        static int atk(Personagem atacante){
           return atacante.GETatk() + Dado();
        }
        static int def(int opcao, Personagem defensor){
            if(opcao==1){
                return defensor.GETdef() + Dado();
            }else if(opcao== 2){
                return defensor.GETevs() + Dado();
            }else{
                return 0;
            }
        }
        static void Main(string[] args){
              //instancia dos personagens
        Personagem Wallace = new Personagem("Wallace",5,2,0,1);
        Personagem Eu = new Personagem("Eu",3,1,1,1);
        Console.WriteLine("Pré combate");
        Console.WriteLine($"{Wallace.GETname()} - Hp: {Wallace.GEThp()} ");
        Console.WriteLine($"{Eu.GETname()} - Hp: {Eu.GEThp()} ");
        Combat(Wallace,Eu);
        Console.WriteLine($"{Wallace.GETname()} - Hp: {Wallace.GEThp()} ");
        Console.WriteLine($"{Eu.GETname()} - Hp: {Eu.GEThp()} ");
        Console.WriteLine("Pós combate");
        }
    }
}