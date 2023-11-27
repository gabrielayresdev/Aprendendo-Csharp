using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.curso2
{
    internal class Album
    {
        public Album(string name)
        {
            Name = name;
        }

        private List<Music> musicList;
        public string Name { get; }
        public int Duration => musicList.Sum(m => m.Duration);
        public void AddMusic(Music music)
        {
            musicList.Add(music);
        }

        public void printfMusicList()
        {
            Console.WriteLine($"Músicas do álbum {Name}: ");
            foreach (var music in musicList)
            {
                Console.WriteLine(music.Name);
            }
            Console.WriteLine($"Duração total: {Duration}");
        }
    }
}
