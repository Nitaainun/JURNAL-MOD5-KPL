using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace modul5_1302200019
{
    internal class Program
    {
        public static SayaTubeVideo SayaTubeVideo { get; private set; }

        static void Main(string[] args)
        {
            SayaTubeVideo sayaTubeVideo = new SayaTubeVideo;
            SayaTubeVideo = sayaTubeVideo;
            Console.WriteLine("Review Film Mariposa oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film Dragon oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film The Maze Runner oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film Harry Potter oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film The Hunger Games oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film Stand By ME oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film Frozen oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film Raya oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film Tangled oleh Nita Ainun Nisa");
            Console.WriteLine("Review Film Baby Boss oleh Nita Ainun Nisa");
        }
    }
    class SayaTubeUser
    {
        private const string V = "Judul 1: ";
        int id;
        string username;
        List <SayaTubeVideo> uploadedVidio = new List <SayaTubeVideo> ();

        public SayaTubeUser(string username)
        {
            this.username = username;
            
        }

        public int GetTotalVideoPlayCount()
        {
            return PlayAcount();
        }

        private int PlayAcount()
        {
            throw new NotImplementedException();
        }

        public void SayaTubeVideo private string title;

        public bool PlayCount { get; private set; }
        public int PlayCountV { get; private set; }

        public void addVideo()
        {
            SayaTubeVideo.Add(" ");
        }

        public object GetUsername()
        {
            return username;
        }

        public void PrintAllVideoPlayAcount(object username)
        {
            Console.WriteLine(id + "ID: ");
            Console.WriteLine("Username: " username);
            Console.WriteLine("Judul 1" PlayCountV);
            Console.WriteLine("Judul 2" PlayCountV);
        }
    }
    
    class SayaTubeVideo
    {
        int id;
        string title;
        int PlayAcount;

        public static int ID { get; private set; }
        public bool PlayCount { get; private set; }

        static SayaTubeVideo(string title)
        {
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);
            
            this.title = title;
            id = Random.Next(0, 1000);
            PlayAcount = 0;
        }
        public void int IncreasePlayCount()
        {

        }

        public void PrintVideoDetail()
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine(PlayCount);
        }
    }
}

