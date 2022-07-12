using System;

namespace DesignPattern.Builder.Fluent
{
    public class Person
    {
        public string Name;
        public string Postion;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Postion)}: {Postion}";
        }
    }

    public class PersonInfoBuilder
    {
        protected Person Person = new Person();

        public PersonInfoBuilder Called( string name)
        {
            Person.Name = name;
            return this;
        }
    }

    public class PersonjobBuilder : PersonInfoBuilder
    {
        public PersonjobBuilder WorkAt (string position)
        {
            Person.Postion = position;
            return this;
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            var builder = new PersonjobBuilder();
            //builder.Called("dmitri").WorkAt("dev"); // This will fail if uncomment.
        }
    }
}
