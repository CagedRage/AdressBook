using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AdressBookBinaryLibrary
{
    public class AdressBookWriter
    { 

    public void WriteWordsToFile(List<Contact> writers)
    {
        StreamWriter sr = new StreamWriter("kAdressBook.txt", false);
        foreach (Contact c in writers)
            {
                sr.WriteLine(c.GetRecord());
            }
        sr.Close();
           
    }
    public void DelWordsToFile(List<Contact> writers, Contact k)
    {
        StreamWriter sr = new StreamWriter("kAdressBook.txt", false);
        foreach (Contact j in writers)
        {
            if  (j.GetRecord() != k.GetRecord())
            {
                sr.WriteLine(j.GetRecord());
            }
        }
        sr.Close();
    }
        public List<Contact> ReadWordsFromFile()
        {

            List<Contact> ckList = new List<Contact>();
            string line;
            StreamReader sr = new StreamReader("kAdressBook.txt");
            while ((line = sr.ReadLine()) != null)
            {
                Contact new_contact = new Contact();
                string[] templist = Regex.Split(line, ", ");
                int i = 0;
                foreach (string contactline in templist)
                {

                    switch (i)
                    {
                        case 0:
                            new_contact.UpdateFirstName(contactline);
                            break;
                        case 1: //
                            new_contact.UpdateLastName(contactline);
                            break;
                        case 2:
                            new_contact.UpdatePhoneNumber(contactline);
                            break;
                        case 3:
                            new_contact.UpdateCompanyNumber(contactline);
                            break;
                        case 4:
                            new_contact.UpdateFax(contactline);
                            break;
                        case 5:
                            new_contact.UpdateCompanyName(contactline);
                            break;
                        case 6:
                            new_contact.UpdateCompanyPosition(contactline);
                            break;
                        default:
                            Console.WriteLine("U messed up somewhere in ur case statment breh");
                            break;

                    }
                    i = i + 1;



                }
                ckList.Add(new_contact);

            }
            sr.Close();
            return ckList;
        }

      
    }
}
