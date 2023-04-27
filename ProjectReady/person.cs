using System;
namespace ProjectReady
{
    public class person
    {
        private string name;
        private int age;
        private int nationalid;
        private string address;
        private string gender;
        public int NationalId { get { return nationalid; } set { nationalid = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public person(string name, int age, int nationalid, string address, string gender)
        {
            Name = name;
            Age = age;
            this.nationalid = nationalid;
            Address = address;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"Name : {Name}  \nAge : {Age}  \nAddress : {Address}  \nGender : {Gender}  \nNational ID : {NationalId}";
        }

    }
}