using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213102
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        public int playCount;
        Random rnd = new Random();

        public SayaTubeVideo(string judul)
        {
            title = judul;
            id = rnd.Next(00000,99999);
            playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            this.playCount = checked(this.playCount + playCount);
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Film = " + id);
            Console.WriteLine("Judul FIlm = " + title);
            Console.WriteLine("Jumlah diputar = " + playCount);
        }
    }
}
