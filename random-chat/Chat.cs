using random_chat;

var contactTester = new ContactsManager();
contactTester.ContactsRemove("carla", "blabla");
public class Chat
{

    public List<string> Conversation = new List<string>();
    public List<string> HiBye = new List<string>();


    public void ToTalk()
    {
        Dictionary<int, string> HiByeText = new Dictionary<int, string> { { 1, "Hi" }, { 2, "Bye" } };


        Random rand = new Random();
        int choice = rand.Next(1, 3);

        if (HiBye.Count() == 0)
        {
            HiBye.Add(HiByeText[choice]);
        }

        while (HiBye[HiBye.Count - 1] == HiByeText[choice])
        {
            choice = rand.Next(1, 3);
        }
        HiBye.Add(HiByeText[choice]);

    }


    public void RandomicTalk()
    {
        Dictionary<int, string> randomicText =
            new Dictionary<int, string> {
                { 1, "Parrot." },
                { 2, "Saturday" },
                { 3, "Maybe tomorrow."},
                { 4, "No."} };

        Random rand = new Random();
        int choice = rand.Next(1, 5);

        if (Conversation.Count() == 0)
        {
            Conversation.Add(randomicText[choice]);
        }

        while (Conversation[Conversation.Count - 1] == randomicText[choice])
        {
            choice = rand.Next(1, 5);
        }
        Conversation.Add(randomicText[choice]);

    }

}

