
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_mentoria.src.Entities
{
    public class Heroi
    {

        public Heroi(string Nome, string ClasseFantastica){
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 50;
            this.PontoDeMagia = 50;
            

            

        }
        public string Nome { get; set; }

        public int Nivel {get; set;}

        public int PontosDeVida { get; set;}

        public int PontoDeMagia {get; set;}

        public string ClasseFantastica {get; set;}

        public int ValorUltimoAtaque {get; set;}


         public override string ToString(){
             return "Meu Nome è " + this.Nome + "\n" 
                   + "Classe: " + this.ClasseFantastica + "\n"
                   + "Nível: " + this.Nivel + "\n" 
                   + "Ponto de Vida: " + this.PontosDeVida + "\n" 
                   + "Ponto de Magia: "+ this.PontoDeMagia + "\n";
                   
         }

         public virtual string Atacar(){
             Random dado = new Random();
             int forcaDoAtaque = this.Nivel + dado.Next(1,20);
             this.ValorUltimoAtaque = forcaDoAtaque;
             return this.Nome + " Ataca com sua espada e dá " + forcaDoAtaque + " de danos";
         }

         public void ReceberDano(int danoRecebido){
            this.PontosDeVida -= danoRecebido;
        }
            
    }
}