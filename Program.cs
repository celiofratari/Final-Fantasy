using System;
using POO_mentoria.src.Entities;

namespace POO_mentoria
{

    class program
    {

        static void Main(string[] args)
        {
           Heroi arus = new Heroi("Arus", "Guerreiro");
           Mago wedge = new Mago("Wedge", "Mago Negro");
           Inimigo kingMummy = new Inimigo("King Mummy", "Zumbi");
           
            Console.WriteLine(kingMummy.Atacar());
            Console.WriteLine(arus.Atacar());

           if(arus.ValorUltimoAtaque == kingMummy.ValorUltimoAtaque ){
               Console.WriteLine("Empates , ambos deram dano de "+ arus.ValorUltimoAtaque);

           }else if(arus.ValorUltimoAtaque > kingMummy.ValorUltimoAtaque){
                kingMummy.ReceberDano(arus.ValorUltimoAtaque - kingMummy.ValorUltimoAtaque);
                Console.WriteLine(arus.Nome + " venceu esse round");

           }else{
               arus.ReceberDano(kingMummy.ValorUltimoAtaque - arus.ValorUltimoAtaque);
               Console.WriteLine(kingMummy + " venceu esse round");
           }

           Console.WriteLine(arus.ValorUltimoAtaque);
           Console.WriteLine(kingMummy.ValorUltimoAtaque);
        }
    }
}

