using System;
using System.Text;

namespace Animals
{
    public class Animals
    {
        public Animals(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"{this.GetType().Name}")
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .AppendLine($"{ProduceSound()}");

            return sb.ToString().TrimEnd();



        }
    }
}