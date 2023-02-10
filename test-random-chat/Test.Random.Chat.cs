

namespace test_random_chat;

public class Tests
{
    Chat chat = new Chat();
    List<string> chatList = new List<string>();
    // [SetUp]
    // public void Setup()
    // {
    // }
    // [Test]

    [TestCase(1000)]
    public void Test1(int qtd)
    {
        for (int i = 0; i < qtd; i++)
        {
            chatList.Add(chat.ToTalk());
        }
        bool containsNonsense = chatList.Any(x => x != "Hi" && x != "Bye");

        Assert.False(containsNonsense);
    }
}