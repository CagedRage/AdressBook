using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookBinaryLibrary
{
    public class AdressBookHolder
    {
        public List<Contact> contacts = new List<Contact>();
        public AdressBookHolder()
        {
           
        }
        public bool AddContact(Contact c)
        {
            contacts.Add(c);
            return true;
            
        }
        public List<Contact> GetContacts()
        {
            return contacts;
        }
        public void InitilizeContacts(List<Contact> cList)
        {
            contacts = cList.ToList();
        }

        
        
        
    }
}
