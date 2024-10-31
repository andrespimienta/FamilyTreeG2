namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node
{
    // Atributos del Nodo
    private int number = 0;     // (Por defecto inicia en 0, si el nodo contiene una Persona, number siempre va a ser 0)
    private Person persona;
    private List<Node> children = new List<Node>();
    
    //Getters
    public int Number {
        get
        {
            return this.number;
        }
    }
    public Person Persona
    {
        get
        {
            return this.persona;
        }
    }
    public ReadOnlyCollection<Node> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }
    
    // Constructores
    public Node(int unNumero)
    {
        this.number = unNumero;
    }
    
    public Node(Person unaPersona)
    {
        this.persona = unaPersona;
    }

    // Métodos
    public void AddChildren(Node n)
    {
        this.children.Add(n);
    }
    
    public int ConocerEdad()
    { 
        return this.persona.Edad;
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
