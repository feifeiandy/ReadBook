using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UserSection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stuList = ConfigurationManager.GetSection("students") as List<Student>;
            if (stuList != null)
            {
                foreach (Student stu in stuList)
                {
                    Console.WriteLine(stu.Name);
                    Console.WriteLine(stu.Age);
                    Console.WriteLine(stu.Gender);
                    Console.WriteLine(stu.Grade);
                    Console.WriteLine(stu.Hobby);
                    Console.WriteLine("-----------分割线------------");
                }
            }

            List<Machine> macList = ConfigurationManager.GetSection("machines") as List<Machine>;
            if (macList!=null)
            {
                foreach (Machine mac in macList)
                {
                    Console.WriteLine("设备号："+mac.ID);
                }
            }
            Console.Read();
        }
    }


    public enum Gender
    {
        Female,
        Male
    }
    public enum Grade
    {
        G1,
        G2,
        G3
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Grade Grade { get; set; }
        public string Hobby { get; set; }
    }

    class Machine
    {
        public int ID { get; set; }
    }

    class StudentSectionHandler : IConfigurationSectionHandler
    {

        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            List<Student> stuList = new List<Student>();
            foreach (XmlNode stuNode in section.ChildNodes)
            {
                Student stu = new Student();
                foreach (XmlNode node in stuNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "Name": stu.Name = node.InnerText; break;
                        case "Age": stu.Age = Convert.ToInt32(node.InnerText); break;
                        case "Gender": stu.Gender = (Gender)Enum.Parse(typeof(Gender), node.InnerText); break;
                        case "Grade": stu.Grade = (Grade)Enum.Parse(typeof(Grade), node.InnerText); break;
                        case "Hobby": stu.Hobby = node.InnerText; break;
                    }
                }
                stuList.Add(stu);
            }
            return stuList;
        }
    }

    class MachineSectionHandler:IConfigurationSectionHandler
    {

        public object Create(object parent, object configContext, XmlNode section)
        {
            List<Machine> macList = new List<Machine>();
            foreach (XmlNode macNode in section.ChildNodes)
            {
                Machine mac = new Machine();
                foreach (XmlNode node in macNode.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "ID": mac.ID = Convert.ToInt32(node.InnerText); break;
                    }
                }
                macList.Add(mac);
            }
            return macList;
        }
    }
}
