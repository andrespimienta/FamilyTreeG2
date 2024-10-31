namespace Library;

public class SumVisitor : IVisitor
{
    // Atributos
    private int sumaNumeros = 0;
    private int sumaEdades = 0;

    // Getters
    public int SumaNumeros
    {
        get { return this.sumaNumeros; }
    }
    public int SumaEdades
    {
        get { return this.sumaEdades; }
    }
    
    // Métodos
    public void Visit(Node unNodo)
    {
        if (unNodo.Number != 0)
        {
            sumaNumeros += unNodo.Number;
        }
        else
        {
            sumaEdades += unNodo.ConocerEdad();
        }
    }
}
