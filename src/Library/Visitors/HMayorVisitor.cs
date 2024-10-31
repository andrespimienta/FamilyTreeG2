namespace Library;

public class HMayorVisitor : IVisitor
{
    // Atributos
    private Node hijoMayor = new Node(new Person("Nadie",0));   // Se inicia con alguien de edad 0

    // Métodos
    public Person GetHijoMayor()
    {
        return this.hijoMayor.Persona;
    }

    public void Visit(Node nodoVisitado)
    {
        if (nodoVisitado.Children.Count == 0)      
            // Si la persona visitada no tiene otros hijos, es una "hoja" (hijo) 
        {
            if (nodoVisitado.ConocerEdad() > hijoMayor.ConocerEdad())
                // Si la edad de la persona visitada es mayor la del hijo ya guardado, esta persona pasa a ser el nuevo "hijoMayor"
            {
                this.hijoMayor = nodoVisitado;
            }
        }
    }
}