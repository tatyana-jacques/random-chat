public static class Chat
{
    public static Dictionary<int, string> Text = new Dictionary<int, string> { { 1, "Hi" }, { 2, "Bye" } };
    public static void ToTalk()
    {
        Random rand = new Random();
        int choice = rand.Next(1, 3);

        Console.WriteLine(Text[choice]);
    }

}