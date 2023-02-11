
namespace test_random_chat;

public class Tests
{
    Chat chat = new Chat();
    List<string> chatList = new List<string>();
   
[TestCase(100)]
    public void TestHiBye(int qtd)
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
    [TestCase(100)]
    public void TestConversation(int qtd)
    {

        for (int i = 0; i < qtd; i++)
        {
            chat.RandomicTalk();
        }

        for (int i = 1; i < chat.Conversation.Count; i++)
        {
            Assert.AreNotEqual(chat.Conversation[i], chat.Conversation[i - 1]);
        }

    }





}