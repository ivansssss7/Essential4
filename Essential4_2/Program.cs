namespace Essential4_2;

//Створіть 2 інтерфейси IPlayable та IRecodable.
//У кожному з інтерфейсів створіть по 3 методи void Play() / void Pause() / void Stop()
//та void Record() / void Pause() / void Stop() відповідно.
//Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable. 
//Написати програму, яка виконує програвання та запис.

class Program
{
    static void Main()
    {
        Player player = new Player();

        // Відтворення
        Console.WriteLine("Playback:");
        player.Play();
        ((IPlayable)player).Pause(); // Виклик методу Pause з IPlayable
        ((IPlayable)player).Stop();// Виклик методу Stop з IPlayable
        Console.WriteLine();
        // Запис
        Console.WriteLine("Recording:");
        player.Record();
        ((IRecodable)player).Pause(); // Виклик методу Pause з IRecodable
        ((IRecodable)player).Stop();  // Виклик методу Stop з IRecodable
    }
}