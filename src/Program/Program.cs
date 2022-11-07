using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jorge = new Person("Jorge",70);
            Person Teresa = new Person("Teresa",10);
            Person Maria = new Person("Maria",50);
            Person Andres = new Person("Andres",45);
            Person Lucia = new Person("Lucia",40);
            Person Tomas = new Person("Tomas",19);
            Person Belen = new Person("Belen",20);
            Person Sebastian = new Person("Sebastian",13);
            Node n1 = new Node(Jorge);
            Node n2 = new Node(Maria);
            Node n3 = new Node(Andres);
            Node n4 = new Node(Lucia);
            Node n5 = new Node(Tomas);
            Node n6 = new Node(Belen);
            Node n7 = new Node(Teresa);
            Node n8 = new Node(Sebastian);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            n2.AddChildren(n5);
            n2.AddChildren(n6);

            n3.AddChildren(n7);

            n4.AddChildren(n8);
            Visitor v = new Visitor();
            v.VisitTotalAge(n1);
            Console.WriteLine(v.edadTotal);

            Visitor v2 = new Visitor();
            v2.VisitOlderSon(n1);
            Console.WriteLine(v2.olderPerson.Name);

            Visitor v3 = new Visitor();
            v3.VisitLongerName(n1);
            Console.WriteLine(v3.LongerNamePerson.Name);

            
        }
    }
}
