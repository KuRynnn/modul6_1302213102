using modul6_1302213102;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser Fahryan = new SayaTubeUser("Fahryan");
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Avenger 1 oleh Fahryan");
        Fahryan.AddVideo(video1);
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Avenger 2 oleh Fahryan");
        Fahryan.AddVideo(video2);
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Avenger 3 oleh Fahryan");
        Fahryan.AddVideo(video3);
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Avenger 4 oleh Fahryan");
        Fahryan.AddVideo(video4);
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Avenger 5 oleh Fahryan");
        Fahryan.AddVideo(video5);
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Avenger 6 oleh Fahryan");
        Fahryan.AddVideo(video6);
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Avenger 7 oleh Fahryan");
        Fahryan.AddVideo(video7);
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Avenger 8 oleh Fahryan");
        Fahryan.AddVideo(video8);
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Avenger 9 oleh Fahryan");
        Fahryan.AddVideo(video9);
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Avenger 10 oleh Fahryan");
        Fahryan.AddVideo(video10);

        Fahryan.PrintAllVideoPlaycount();
        Console.WriteLine();

        Console.WriteLine("Video ditonton 25.000.000");
        video1.IncreasePlayCount(25000000);
        Console.WriteLine("Video ditonton 25.000.000 bisa kl 25.000.001 gabisa");
        Console.WriteLine();

        Console.WriteLine("Video ditonton nyaris limit int");
        for (int i = 0; i < 84; i++)
        {
            video1.IncreasePlayCount(25000000);
        }
        video1.PrintVideoDetails();
        Console.WriteLine();
        Console.WriteLine("COBA DI OVRFLOWIN DENGAN DITAMBAH 25.000.000 lagi");
        video1.IncreasePlayCount(25000000);
        Console.WriteLine();

        Console.WriteLine("Harusnya print 8x");
        Fahryan.PrintAllVideoPlaycount();
    }
}