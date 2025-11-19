using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {

     public int Nivelvolume = 0;
     public int VolumeMaximo = 30;



        public void AumentarVolume()
        {
        
          if(Nivelvolume == VolumeMaximo)
             

            Nivelvolume++;
            Console.WriteLine($"Volume Maxímo atingido: {Nivelvolume}");
            return;    
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV ...");
        }

        public void DiminuirVolume()
        {

             if(Nivelvolume == 0) 
             {
                Console.WriteLine($"Volume ja está no Mínimo : {Nivelvolume}");
                return;
             }

            Nivelvolume--;
            Console.WriteLine($"Volume: {Nivelvolume}");
        }
        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV ...");
        }
    }
}