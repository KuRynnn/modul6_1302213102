﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213102
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        Random rnd = new Random();

        public SayaTubeUser(string nama)
        {
            Username = nama;
            id = rnd.Next(00000, 99999);
            uploadedVideos= new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            for(int i = 0; i < uploadedVideos.Count; i++) {
                jumlah += uploadedVideos[i].playCount;
            }
            return jumlah;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i].title);
            }
        }
    }
}
