using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.curso2
{
    internal class Music
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album {  get; set; }
        public string Duration { get; set; }
        public bool Available { get; set; }
        public string Description { 
            get
            {
                return $"A música {Name}, duração {Duration} e pertencente ao album {Album} é cantada por {Artist}.";
            }
        }


       



        public void printMusicData()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Artista: {Artist}");
            Console.WriteLine($"album: {Album}");
            Console.WriteLine($"duração: {Duration}s");
            if(Available)
            {
                Console.WriteLine("Disponível no plano");
            } else
            {
                Console.WriteLine("Adquira o plano plus+");
            }
        }
    }
}
