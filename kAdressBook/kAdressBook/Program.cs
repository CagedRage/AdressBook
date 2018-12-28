using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdressBookBinaryLibrary;
namespace kAdressBook
{
    class Program
    {
        static void Main(string[] args)
        {

            AdressBookHolder Book = new AdressBookHolder();
            AdressBookWriter Writer = new AdressBookWriter();
            foreach (Contact c in Book.GetContacts()) 
            {
                Console.WriteLine(c.GetRecord());
            }
            bool exitloop = false;
            while (exitloop == false)
            {
                //while loop starts here
                Console.WriteLine("Hello and thank you for using this adressbook!(Please Choose between the 5 options)");
                Console.WriteLine("[1] ----------> Create A New Contact\n[2] ----------> View All Contacts\n[3] ----------> Delete A Contact\n[4] ----------> Search A Contact\n[5] ---------> Save Changes and exit    \n");
                Console.WriteLine("If you cannot answer any field of any contact, please put N/A");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("What is your contacts first name?\n");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("What is your contacts last name\n");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("What is your contacts personal phone number?\n");
                    string personalphonenumber = Console.ReadLine();
                    Console.WriteLine("What is this persons company number?\n");
                    string companynumber = Console.ReadLine();
                    Console.WriteLine("What is this persons fax?");
                    string fax = Console.ReadLine();
                    Console.WriteLine("What is this persons company name?");
                    string company_name = Console.ReadLine();
                    Console.WriteLine("What is this persons company position?");
                    string companypos = Console.ReadLine();
                    Contact new_contact = new Contact(firstname, lastname, personalphonenumber, companynumber, fax, company_name, companypos);
           
                    Book.AddContact(new_contact);   
                    Console.WriteLine("Once you save changes, the contact will be added");
                }
                else if (response == "5")
                {
                    Writer.WriteWordsToFile(Book.GetContacts());
                    exitloop = true;
                }
                
                else if (response == "2")
                {   
                    Book.InitilizeContacts(Writer.ReadWordsFromFile());
                    foreach (Contact c in Book.GetContacts())
                    {
                        Console.WriteLine(c.GetRecord());
                    }
                }
                else if (response == "3")
                {
                    /*public Contact(string name1, string name2, string personal_num, string com_num,
                    string fax_num, string company_name, string company_pos)*/
                    Console.WriteLine("Please enter the contacts first name that your searching for\n");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Please enter the contacts last name that your searching for\n");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Please enter the contacts personal number\n");
                    string personal_num = Console.ReadLine();
                    Console.WriteLine("Please enter their company number\n");
                    string com_num = Console.ReadLine();
                    Console.WriteLine("Please enter their fax number\n");
                    string fax_num = Console.ReadLine();
                    Console.WriteLine("What company does this person work for?\n");
                    string company_name = Console.ReadLine();
                    Console.WriteLine("What is their position in this company?\n");
                    string compos = Console.ReadLine();

                    Book.InitilizeContacts(Writer.ReadWordsFromFile());
                    foreach (Contact c in Book.GetContacts())
                    {
                        string firstname = c.GetFirstName();
                        string lastname = c.GetLastName();
                        string personalnumber = c.GetPhoneNumber();
                        string companynumber = c.GetCompanyNumber();
                        string faxnumber = c.GetFax();
                        string companyname = c.GetCompanyName();
                        string companyposition = c.GetCompanyPosition();

                        if ((String.Compare(firstname, name1) == 0) && (String.Compare(lastname, name2) == 0) && (String.Compare(personal_num, personalnumber) == 0) && (String.Compare(com_num, companynumber) == 0) && (String.Compare(fax_num, faxnumber) == 0) && (String.Compare(companyname, companyname) == 0) && (String.Compare(companyposition, compos) == 0))
                        {
                            Console.WriteLine("The contact is found!\n");
                            Console.WriteLine("[1] ---------> Delete Contact\n[2] ----------> I made a mistake and I dont want to delete anything\n");
                            string conformation = Console.ReadLine();
                            bool loop = false;
                            while (loop == false)
                            {
                                if (conformation == "1")
                                {
                                    Book.InitilizeContacts(Writer.ReadWordsFromFile());
                                    List<Contact> DelList = Book.GetContacts();
                                    Writer.DelWordsToFile(DelList, c);
                                    loop = true;
                                }
                                if (conformation == "2")
                                {
                                    Console.WriteLine("Ok nothing will be deleted");
                                    loop = true;
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't an option!");
                                    Console.WriteLine("Please Choose Again");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("The Contact Could Not Be Found\n");
                        }
                    }
                

                    
                    

                }
                else if (response == "4")
                {
                    //Find contacts
                    Console.WriteLine("Please enter the contacts first name that your searching for");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Please enter the contacts last name that your searching for");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("-------------------------------------------------------------------");   
                    Book.InitilizeContacts(Writer.ReadWordsFromFile());
                    bool bFound = false;
                    foreach (Contact c in Book.GetContacts())
                    {
                        string firstname = c.GetFirstName();
                        string lastname = c.GetLastName();
                        if ((String.Compare(firstname, name1) == 0) && (String.Compare(lastname, name2) == 0))
                        {
                            Console.WriteLine("Found It!");
                            Console.WriteLine(c.GetRecord());
                            bFound = true;
                        }

                    }
                    if (!bFound)
                    {
                        Console.WriteLine("Sorry, that contact doesn't exist");
                    }
                }
                else
                {
                    Console.WriteLine("Ummmmm that wasnt one of the options so try again");
                }


            }
            Console.WriteLine("Your changes will be saved(Press Any Key To Exit)");
            Console.ReadKey();
        }       

    }
}
