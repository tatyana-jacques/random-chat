using random_chat.Models;

namespace random_chat
{

    public class ContactsManager
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void ContactsAdd(string name, string email)
        {
            Contact contato = new Contact
            {
                Name = name,
                Email = email
            };

            Contacts.Add(contato);

        }
        public void ContactsRemove(string name, string email)
        {

            Contact contact = Contacts.Find(e => e.Name == name && e.Email == email);

            if (contact is not null)
            {
                Contacts.Remove(contact);
            }

            else
            {
                throw new Exception("Non-existent contact!");
            }

        }

        public List<Contact> ContactsGet()
        {
            return Contacts;
        }

        public Contact ContactsGetOne(string name, string email)
        {

            Contact contact = Contacts.Find(e => e.Name == name && e.Email == email);

            return contact;
        }

    }

}