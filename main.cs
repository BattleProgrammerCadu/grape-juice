using System;

namespace grapeJuice
{
    public class main
    {
        //instancia dos personagens
        Personagem Wallace = new Personagem("Wallace",5,2,0,1);
        Personagem Eu = new Personagem("Eu",3,1,1,1);
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
        void Combat(Personagem atacante, Personagem defensor){
            
        }
        int atk(Personagem atacante){
            return 0;
        }
        int def(Personagem defensor){
            return 0;
        }
    }
}