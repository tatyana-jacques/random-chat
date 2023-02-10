var chat = new Chat();

Console.WriteLine(chat.ToTalk());
public class Chat
{
    public Dictionary<int, string> Text = new Dictionary<int, string> { { 1, "Hi" }, { 2, "Bye" } };
    public string ToTalk()
    {
        Random rand = new Random();
        int choice = rand.Next(1, 3);

        return Text[choice];
    }

}

