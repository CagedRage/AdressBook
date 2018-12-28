using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookBinaryLibrary
{
    public class Contact
    {
        public string First_Name;
        public string Last_Name;
        public string Phone_Number;
        public string Company_Number;
        public string Fax;
        public string Company_Name;
        public string Company_Position;

        public Contact()
        {

        }
        public Contact(string name1, string name2, string personal_num, string com_num,
        string fax_num, string company_name, string company_pos)
        {
            First_Name = name1;
            Last_Name = name2;
            Phone_Number = personal_num;
            Company_Number = com_num;
            Fax = fax_num;
            Company_Name = company_name;
            Company_Position = company_pos;
        }
        public string GetRecord()
        {
            return First_Name + ", " + Last_Name + ", " + Phone_Number + ", " + Company_Number + ", " + Fax + ", " + Company_Name + ", " + Company_Position;
        }
        public void UpdateFirstName(string fname)
        {
           First_Name = fname;       
        }
        public void UpdateLastName(string lname)
        {
            Last_Name = lname;
        }
        public void UpdatePhoneNumber(string pnum)
        {
              Phone_Number = pnum;
        }
        public void UpdateCompanyNumber(string cnum)
        {
            Company_Number = cnum;
        }
        public void UpdateFax(string fax)
        {
            Fax = fax;
        }
        public void UpdateCompanyName(string cname)
        {
            Company_Name = cname;
        }
        public void UpdateCompanyPosition(string cpos)
        {
            Company_Position = cpos;
        }
        public string GetFirstName()
        {
            return First_Name;
        }
        public string GetLastName()
        {
            return Last_Name;
        }
        public string GetPhoneNumber()
        {
            return Phone_Number;
        }
        public string GetCompanyNumber()
        {
            return Company_Number;
        }
        public string GetFax()
        {
            return Fax;
        }
        public string GetCompanyName()
        {
            return Company_Name;
        }
        public string GetCompanyPosition()
        {
            return Company_Position;
        }
    }
}
