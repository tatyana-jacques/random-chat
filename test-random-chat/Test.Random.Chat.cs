

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

    [TestCase(100)]
    public void Test1(int qtd)
    {

        for (int i = 0; i < qtd; i++)
        {
            chat.ToTalk();
        }

        for (int i = 1; i < chat.HiBye.Count; i++)
        {
            Assert.AreNotEqual(chat.HiBye[i], chat.HiBye[i - 1]);
        }

    }

    //[Test]




}