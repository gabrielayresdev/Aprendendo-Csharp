using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.curso2
{
    internal class Music
    {
        string name;
        string artist;
        string album;
        string duration;
        bool available;

        public void printMusicData()
        {
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Artista: {artist}");
            Console.WriteLine($"album: {album}");
            Console.WriteLine($"duração: {duration}s");
            if(available)
            {
                Console.WriteLine("Disponível no plano");
            } else
            {
                Console.WriteLine("Adquira o plano plus+");
            }
        }
    }
}
