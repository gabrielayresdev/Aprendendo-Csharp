using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.curso2
{
    internal class Artist
    {
        public Artist(string name)
        {
            Name = name;   
        }
        public List<Album> albums = new List<Album>();
        public string Name { get; }

        public void PrintDiscography()
        {
            Console.WriteLine($"Discografia da banda {Name}");
            foreach (var album in albums)
            {
                Console.WriteLine(album.Name);
            }
        }
    }
}
