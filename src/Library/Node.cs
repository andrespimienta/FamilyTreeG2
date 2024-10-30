namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node
{
    private int number;
    private Person persona;

    private List<Node> children = new List<Node>();
    private List<Person> hijos = new List<Person>();


    public int Number {
        get
        {
            return this.number;
        }
    }

    public Person Persona { get; set; }


    public ReadOnlyCollection<Node> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Node(int number)
    {
        this.number = number;
    }
    
    public Node(Person Persona)
    {
        this.persona = Persona;
    }

    public int ConocerEdad(Node node)
    { 
        return node.persona.Edad;
    }


    public void AddChildren(Node n)
    {
        this.children.Add(n);
    }
    
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        foreach (Node hijo in this.children)
        {
            hijo.Accept(visitor);
        }
    }
}
