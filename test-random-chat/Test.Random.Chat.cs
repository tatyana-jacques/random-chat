using random_chat;
using random_chat.Models;
namespace test_random_chat;

public class Tests
{
    Chat chat = new Chat();
    ContactsManager contacts = new ContactsManager();

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

    [TestCase("testName", "testEmail")]
    public void TestContactsAdd(string name, string email)
    {
        contacts.ContactsAdd(name, email);

        Assert.AreEqual(contacts.Contacts[contacts.Contacts.Count - 1].Name, name);
        Assert.AreEqual(contacts.Contacts[contacts.Contacts.Count - 1].Email, email);

    }

    [Test]
    public void TestContactRemoveCatch()
    {

        Assert.Catch(() =>
        { contacts.ContactsRemove("testName04", "testEmail04"); });

    }





}