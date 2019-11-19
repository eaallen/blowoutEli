using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FavtoryMethod();
                Console.WriteLine("I created l{0}", product.GetType().Name);
            }
            Console.ReadKey();
        }
    }

    abstract class Product { }
    class ConcreteProductA : Product { }
    class ConcreteProductB : Product { }

    abstract class Creator
    {
        public abstract Product FavtoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FavtoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FavtoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
