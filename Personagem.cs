using System;

namespace grapeJuice
{    
    //CLASS Personagem
    public class Personagem
    {
            //attributes
            int _hp;
            int _atk;
            int _def;
            int _evs;
            string _nome;

            //CONSTRUCT
            public Personagem(string nome, int hp, int atk, int def, int evs){
            _nome = nome;
            _hp = hp;
            _atk = atk;
            _def = def;
            _evs= evs;
            }
            public Personagem(){
                _hp= 3;
                _atk=1;
                _def=1;
                _evs=1;
            }
            //GET
            public int GEThp(){
                return _hp;            
            }
            public int GETatk(){
                return _atk;            
            }
            public int GETdef(){
                return _def;            
            }
            public int GETevs(){
                return _evs;            
            }
            public string GETname(){
                return _nome;
            }
            //SET
            public int SEThp(int dmg){
                return _hp -= dmg;
            }

    }
}