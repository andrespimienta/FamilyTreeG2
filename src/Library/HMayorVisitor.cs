namespace Library;

public class HMayorVisitor : IVisitor
{
    // Atributos
    public Node hijoMayor;

    // Métodos
    public void Visit(Node node)
    {
        if (node.Children == null)
        {
            if (hijoMayor.ConocerEdad > node.ConocerEdad)

                sumaNodes += node.Number;
        }
        else
        {
             sumaEdades += node.ConocerEdad(node);
        }
    }
}