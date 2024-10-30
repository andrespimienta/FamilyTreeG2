namespace Library;

public class SumVisitor : IVisitor
{
    private int sumaNodes = 0;
    private int sumaEdades = 0;

    public int SumaNodes
    {
        get { return this.sumaNodes; }
    }
    
    public int SumaEdades
    {
        get { return this.sumaEdades; }
    }
    

    public void Visit(Node node)
    {
        if (node.Number != 0)
        {
            sumaNodes += node.Number;
        }
        else
        {
            sumaEdades += node.ConocerEdad(node);
        }
    }
}
