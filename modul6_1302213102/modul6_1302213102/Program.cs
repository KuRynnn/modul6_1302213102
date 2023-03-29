using modul6_1302213102;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser Fahryan = new SayaTubeUser("Fahryan");

        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 1 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 2 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 3 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 4 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 5 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 6 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 7 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 8 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 9 oleh Fahryan"));
        Fahryan.AddVideo(new SayaTubeVideo("Review Film Avenger 10 oleh Fahryan"));

        Fahryan.PrintAllVideoPlaycount();
    }
}