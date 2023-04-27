using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReady
{
    public class Employee : person
    {
        private int id;
        public const double tax = 0.1;
        public const int overtimeHR = 20;
        public const int normalHR = 15;
        private string department;
        private int workinghours;
        public int WorkingHours { get { return workinghours; } set { workinghours = value; } }
        public int Id { get { return id; } set { id = value; } }
        public string Department { get { return department; } set { department = value; } }
        public Employee(int id, string department, string name, int age, int nationalid, string address, string gender, int workinghours) : base(name, age, nationalid, address, gender)
        {
            Id = id;
            Department = department;            
            WorkingHours = workinghours;
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nDepartment : {Department}  \nPrice per hour ( Normal ) : {normalHR} \nPrice per hour ( Overtime ) : {overtimeHR} \nSalary: {this.salary()}";
        }
        public double salary()
        {
            if (WorkingHours <= 160)
            {
                return WorkingHours * normalHR;
            }
            else
            {
                return ((WorkingHours - 160) * overtimeHR) + (160 * normalHR);
            }
        }
    }
}
