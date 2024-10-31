namespace Library;

public class SumVisitor : IVisitor
{
    private int sumaNumeros = 0;
    private int sumaEdades = 0;

    public int SumaNumeros
    {
        get { return this.sumaNumeros; }
    }
    
    public int SumaEdades
    {
        get { return this.sumaEdades; }
    }
    

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
