using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            SumVisitor visitor = new SumVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.SumaNodes);
            
            // codigo con personas
            Console.WriteLine("----------------------------");
            Console.WriteLine("Prueba con personas");
            Person p1 = new Person("Joaco", 22);
            Person p2 = new Person("Nico", 28);
            Person p3 = new Person("Esteban", 19);
            Person p4 = new Person("Andres", 21);
            Person p5 = new Person("Messi", 10);
            Person p6 = new Person("Nadal", 50);
            Person p7 = new Person("Jordan", 23);

            Node n11 = new Node(p1);
            Node n12 = new Node(p2);
            Node n13 = new Node(p3);
            Node n14 = new Node(p4);
            Node n15 = new Node(p5);
            Node n16 = new Node(p6);
            Node n17 = new Node(p7);
            
            n11.AddChildren(n12);
            n11.AddChildren(n13);

            n12.AddChildren(n14);
            n12.AddChildren(n15);

            n13.AddChildren(n16);
            n13.AddChildren(n17);
            
            // visitar el árbol de personas
            SumVisitor visitorEdad = new SumVisitor();
            n11.Accept(visitorEdad);
            Console.WriteLine(visitorEdad.SumaEdades);
        }
    }
}
