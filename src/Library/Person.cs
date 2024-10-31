namespace Library;

public class Person
{
    // Atributos
    private string nombre;
    private int edad;
    
    // Getters
    public string Nombre
    {
        get
        {
            return this.nombre;
        }
    }
    public int Edad
    {
        get
        {
            return this.edad;
        }
    }

    // Constructor
    public Person (string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
}