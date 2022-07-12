using System;

namespace DesignPattern.Builder.Fluent
{
    public class Person
    {
        public string Name;
        public string Postion;

        public class Builder : PersonjobBuilder<Builder>
        {
        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Postion)}: {Postion}";
        }
    }

    public abstract class PersonBuilder
    {
        protected Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }
    
    public class PersonInfoBuilder<SELF>
        : PersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called( string name)
        {
            Person.Name = name;
            return (SELF)this;
        }
    }

    public class PersonjobBuilder<SELF> : PersonInfoBuilder<PersonjobBuilder<SELF>>
        where SELF : PersonjobBuilder<SELF>
    {
        public SELF WorkAsA (string position)
        {
            Person.Postion = position;
            return (SELF)this;
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Person me = Person.New
                .Called("dmitri")
                .WorkAsA("quant")
                .Build();

            Console.WriteLine(me);
            //builder.Called("dmitri").WorkAt("dev"); // This will fail if uncomment.
        }
    }
}
