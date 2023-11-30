using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.curso2
{
    internal class Episodes
    {
        public int Duration { get; set; }
        public int Order { get; set; }
        public readonly List<string> Guest {  get; set; }
        public string Resume { get; set; }
        public string Title { get; set; }


        public void AddGuest(string guest)
        {
            Guest.Add(guest);
        }
    }
}
