using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFactoryMethodPrototypeSingletone
{

    //----------------------------------------------------Factory Method--------------------------------------------------------------


    //abstract class Creator
    //{
    //    public abstract IProduct FactoryMethod();

    //    public abstract string GetName();

    //    public string Print()
    //    {
    //        IProduct product = FactoryMethod();
    //        string result = GetName() + " prints with "
    //            + product.Operation();

    //        return result;
    //    }
    //}

    //class Canon : Creator
    //{
    //    public override IProduct FactoryMethod()
    //    {
    //        return new Perl();
    //    }

    //    public override string GetName()
    //    {
    //        return "Canon";
    //    }
    //}

    //class HP : Creator
    //{
    //    public override IProduct FactoryMethod()
    //    {
    //        return new Offset();
    //    }

    //    public override string GetName()
    //    {
    //        return "HP";
    //    }
    //}

    //public interface IProduct
    //{
    //    string Operation();
    //}

    //class Perl : IProduct
    //{
    //    public string Operation()
    //    {
    //        return "perl paper";
    //    }
    //}

    //class Offset : IProduct
    //{
    //    public string Operation()
    //    {
    //        return "offset paper";
    //    }
    //}

    //class Client
    //{
    //    public void Main()
    //    {
    //        Console.WriteLine("App: Launched with the ConcreteCreator1.");
    //        ClientCode(new Canon());

    //        Console.WriteLine("");

    //        Console.WriteLine("App: Launched with the ConcreteCreator2.");
    //        ClientCode(new HP());
    //    }

    //    public void ClientCode(Creator creator)
    //    {
    //        Console.WriteLine("Client: I'm not aware of the creator's class," +
    //            "but it still works.\n" + creator.Print());
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        new Client().Main();
    //    }
    //}

    //-------------------------------------------------Builder--------------------------------------------------------


    //public interface IBuilder
    //{
    //    void BuildMainboard();

    //    void BuildProcessor();

    //    void BuildSoundCard();

    //    void BuildVideoCard();

    //    void BuildTuner();
    //}

    //public class Dell : IBuilder
    //{
    //    private Product _product = new Product();

    //    public Dell()
    //    {
    //        this.Reset();
    //    }

    //    public void Reset()
    //    {
    //        this._product = new Product();
    //    }

    //    public void BuildMainboard()
    //    {
    //        this._product.Add("DellMainboard");
    //    }

    //    public void BuildProcessor()
    //    {
    //        this._product.Add("DellProcessor");
    //    }

    //    public void BuildSoundCard()
    //    {
    //        this._product.Add("DellSoundCard");
    //    }


    //    public void BuildVideoCard()
    //    {
    //        this._product.Add("DellVideoCard");
    //    }

    //    public void BuildTuner()
    //    {
    //        this._product.Add("DellTuner");
    //    }

    //    public Product GetProduct()
    //    {
    //        Product result = this._product;

    //        this.Reset();

    //        return result;
    //    }
    //}

    //public class Sony : IBuilder
    //{
    //    private Product _product = new Product();

    //    public Sony()
    //    {
    //        this.Reset();
    //    }

    //    public void Reset()
    //    {
    //        this._product = new Product();
    //    }

    //    public void BuildMainboard()
    //    {
    //        this._product.Add("SonyMainboard");
    //    }

    //    public void BuildProcessor()
    //    {
    //        this._product.Add("SonyProcessor");
    //    }

    //    public void BuildSoundCard()
    //    {
    //        this._product.Add("SonySoundCard");
    //    }

    //    public void BuildVideoCard()
    //    {
    //        this._product.Add("SonyVideoCard");
    //    }

    //    public void BuildTuner()
    //    {
    //        this._product.Add("SonyTuner");
    //    }

    //    public Product GetProduct()
    //    {
    //        Product result = this._product;

    //        this.Reset();

    //        return result;
    //    }
    //}


    //public class Product
    //{
    //    private List<object> _parts = new List<object>();

    //    public void Add(string part)
    //    {
    //        this._parts.Add(part);
    //    }

    //    public string ListParts()
    //    {
    //        string str = string.Empty;

    //        for (int i = 0; i < this._parts.Count; i++)
    //        {
    //            str += this._parts[i] + ", ";
    //        }

    //        str = str.Remove(str.Length - 2);

    //        return "Product parts: " + str + "\n";
    //    }
    //}

    //public class Director
    //{
    //    private IBuilder _builder;

    //    public IBuilder Builder
    //    {
    //        set { _builder = value; }
    //    }

    //    public void BuildBasic()
    //    {
    //        this._builder.BuildMainboard();
    //        this._builder.BuildProcessor();
    //    }

    //    public void BuildStandart()
    //    {
    //        this._builder.BuildMainboard();
    //        this._builder.BuildProcessor();
    //        this._builder.BuildVideoCard();
    //    }

    //    public void BuildStandartPlus()
    //    {
    //        this._builder.BuildMainboard();
    //        this._builder.BuildProcessor();
    //        this._builder.BuildVideoCard();
    //        this._builder.BuildSoundCard();
    //    }

    //    public void BuildLux()
    //    {
    //        this._builder.BuildMainboard();
    //        this._builder.BuildProcessor();
    //        this._builder.BuildVideoCard();
    //        this._builder.BuildSoundCard();
    //        this._builder.BuildTuner();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Director director = new Director();

    //        Dell dellBuilder = new Dell();
    //        director.Builder = dellBuilder;

    //        Console.WriteLine("Basic product:");
    //        director.BuildBasic();
    //        Console.WriteLine(dellBuilder.GetProduct().ListParts());

    //        Console.WriteLine("Standart product:");
    //        director.BuildStandart();
    //        Console.WriteLine(dellBuilder.GetProduct().ListParts());

    //        Console.WriteLine("StandartPlus product:");
    //        director.BuildStandartPlus();
    //        Console.WriteLine(dellBuilder.GetProduct().ListParts());

    //        Console.WriteLine("Lux product:");
    //        director.BuildLux();
    //        Console.WriteLine(dellBuilder.GetProduct().ListParts());

    //        Console.WriteLine("-----------------------------------");

    //        Sony sonyBuilder = new Sony();
    //        director.Builder = sonyBuilder;

    //        Console.WriteLine("Basic product:");
    //        director.BuildBasic();
    //        Console.WriteLine(sonyBuilder.GetProduct().ListParts());

    //        Console.WriteLine("Standart product:");
    //        director.BuildStandart();
    //        Console.WriteLine(sonyBuilder.GetProduct().ListParts());

    //        Console.WriteLine("StandartPlus product:");
    //        director.BuildStandartPlus();
    //        Console.WriteLine(sonyBuilder.GetProduct().ListParts());

    //        Console.WriteLine("Lux product:");
    //        director.BuildLux();
    //        Console.WriteLine(sonyBuilder.GetProduct().ListParts());

    //    }
    //}



    //------------------------------------------------------Prototype-------------------------------------------------------------

    //public interface IPerson
    //{
    //    IPerson Clone();
    //}  

    //public class Person : IPerson
    //{
    //    public int Age;
    //    public DateTime BirthDate;
    //    public string Name;
    //    public string SecondName;
    //    public IdInfo IdInfo;
    //    public Address Address;

    //    public Person ShallowCopy()
    //    {
    //        return (Person) this.MemberwiseClone();
    //    }

    //    public IPerson Clone()
    //    {
    //        Person clone = (Person)this.MemberwiseClone();
    //        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
    //        clone.Name = String.Copy(Name);
    //        clone.SecondName = String.Copy(SecondName);
    //        clone.Address = new Address(Address.Name, Address.Number);
    //        return clone;
    //    }
    //}

    //public class IdInfo
    //{
    //    public int IdNumber;

    //    public IdInfo(int idNumber)
    //    {
    //        this.IdNumber = idNumber;
    //    }
    //}

    //public class Address
    //{
    //    public int Number;
    //    public string Name;

    //    public Address(string name, int number)
    //    {
    //        this.Number = number;
    //        Name = name;
    //    }
    //}

    //    class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person p1 = new Person();
    //        p1.Age = 42;
    //        p1.BirthDate = Convert.ToDateTime("1977-01-01");
    //        p1.Name = "Jack";
    //        p1.SecondName = "Daniels";
    //        p1.IdInfo = new IdInfo(666);
    //        p1.Address = new Address("Kings Road", 15);

    //        Person p2 = p1.ShallowCopy();
    //        Person p3 = (Person)p1.Clone();

    //        Console.WriteLine("Original values of p1, p2, p3:");
    //        Console.WriteLine("   p1 instance values: ");
    //        DisplayValues(p1);
    //        Console.WriteLine("   p2 instance values:");
    //        DisplayValues(p2);
    //        Console.WriteLine("   p3 instance values:");
    //        DisplayValues(p3);

    //        p1.Age = 32;
    //        p1.BirthDate = Convert.ToDateTime("1900-01-01");
    //        p1.Name = "Frank";
    //        p1.SecondName = "Simpson";
    //        p1.IdInfo.IdNumber = 7878;
    //        p1.Address = new Address("Wall street", 10);
    //        Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
    //        Console.WriteLine("   p1 instance values: ");
    //        DisplayValues(p1);
    //        Console.WriteLine("   p2 instance values (reference values have changed):");
    //        DisplayValues(p2);
    //        Console.WriteLine("   p3 instance values (everything was kept the same):");
    //        DisplayValues(p3);
    //    }

    //    public static void DisplayValues(Person p)
    //    {
    //        Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
    //            p.Name, p.Age, p.BirthDate);
    //        Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
    //        Console.WriteLine("      Full Address: {0:d} {1:s}", p.Address.Number, p.Address.Name);
    //    }
    //}


    //---------------------------------------------------------Singletone------------------------------------------------------------------------

    class Singletone {

        private Singletone() { }

        private static Singletone _instance;

        public static Singletone GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singletone();
            }
            return _instance;
        }

    }

    class Program {
        static void Main(string[] args)
        {
            Singletone s1 = Singletone.GetInstance();
            Singletone s2 = Singletone.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singletone works");
            }
            else
            {
                Console.WriteLine("Singletone failed");
            }
        }
    }
}