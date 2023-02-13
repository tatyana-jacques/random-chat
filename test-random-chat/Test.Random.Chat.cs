using random_chat;
using random_chat.Models;
namespace test_random_chat;

public class Tests
{
    Chat chat = new Chat();
    ContactsManager contacts = new ContactsManager();

    List<Contact> contactListTester = new List<Contact>{
        new Contact {
            Name = "contact01",
            Email = "email01"
        },
        new Contact {
            Name = "contact02",
            Email = "email02"
        },
        new Contact {
            Name = "contact03",
            Email = "email03"
        },

    };

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

    [TestCase("contact01", "email01")]
    public void TestContactRemoveDelete(string name, string email)
    {

        contacts.Contacts = contactListTester;
        contacts.ContactsRemove(name, email);
        bool verifyDelete = contacts.Contacts.Any(n => n.Name == name && n.Email == email);

        Assert.False(verifyDelete);

    }

    [Test]
    public void TestContactsGet()
    {
        Assert.AreEqual(contacts.Contacts, contacts.ContactsGet());
    }


    [TestCase("contact02", "email02")]
    public void TestContactsGetOne(string name, string email)
    {
        contacts.Contacts = contactListTester;
        Contact contact = contacts.ContactsGetOne(name, email);
        Assert.AreEqual(name, contact.Name);
        Assert.AreEqual(email, contact.Email);

    }

}