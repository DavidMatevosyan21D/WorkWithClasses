using Zadanie2_Classes;

Music[] musics = new Music[5];


for (int i = 0; i < musics.Length; i++)
{
    Console.WriteLine("Имя артиста:");
    string artistName = Console.ReadLine();
    Console.WriteLine("Название песни:");
    string songTitle = Console.ReadLine();
    Console.WriteLine("Год выхода:");
    long releaseDate = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine("\n");
    musics[i] = new Music(artistName, songTitle, releaseDate);
}
for (int i = 0; i < musics.Length; i++)
{
    Console.WriteLine(musics[i]);
}