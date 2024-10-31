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
    public void Visit(Node nodoVisitado)
    {
        if (nodoVisitado.Number != 0)   // Si no vale 0, es un nodo de Número
        {
            sumaNumeros += nodoVisitado.Number;
        }
        else        // De lo contrario, es un nodo de Persona
        {
            sumaEdades += nodoVisitado.ConocerEdad();
        }
    }
}
