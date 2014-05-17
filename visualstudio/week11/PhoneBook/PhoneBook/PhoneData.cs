using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook
    {
        public List<PhoneData> phoneList;

        public string GetAllData()
        {
            string ret = "";
            foreach(PhoneData p in phoneList)
            {
                ret += string.Format("{0} | {1} | {2}\r\n", p.mGroup, p.mName, p.mPhone);
            }
            return ret;
        }
        public PhoneBook()
        {
            phoneList = new List<PhoneData>();
        }
        public void Add(string name, string phone, string group)
        {
            PhoneData p = new PhoneData(name, phone, group);
            phoneList.Add(p);
        }
        public PhoneData FindPeople(string name)
        {
            foreach(PhoneData p in phoneList)
            {
                if (p.mName == name)
                    return p;
            }
            return null;
        }
    }
    public class PhoneData
    {
        public string mName;
        public string mPhone;
        public string mGroup;

        public PhoneData()
        {
            mName = "Jhon Doe";
            mPhone = "000-000-0000";
            mGroup = "test";
        }
        public PhoneData(string name, string phone, string group)
        {
            mName = name;
            mPhone = phone;
            mGroup = group;
        }
    }
}
