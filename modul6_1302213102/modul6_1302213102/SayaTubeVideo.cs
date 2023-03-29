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
            Debug.Assert(judul != null && judul.Length <= 200, "Judul tidak sesuai syarat");
            title = judul;
            id = rnd.Next(00000,99999);
            playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            try
            {
                Debug.Assert(playCount <= 25000000 && playCount >= 0, "Jumlah penayangan tidak sesuai syarat");
                this.playCount = checked(this.playCount + playCount);
            }
            catch
            {
                Console.WriteLine("Overflow nih...");
            }
            
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Film = " + id);
            Console.WriteLine("Judul FIlm = " + title);
            Console.WriteLine("Jumlah diputar = " + playCount);
        }
    }
}
