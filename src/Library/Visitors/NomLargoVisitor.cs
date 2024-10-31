namespace Library;

public class NomLargoVisitor: IVisitor
{
 private Node nombreMasLargo;
 private int tamañoDeNombre = 0;
 public string nombre;
 
 public Node NombreMasLargo
 {
  get { return this.nombreMasLargo; }
 }

 public string GetNombre()
 {
  return nombreMasLargo.ConocerNombre();
 }
 public void Visit(Node node)
 {
  
  if (node.Persona != null && tamañoDeNombre<node.Persona.GetLengthName())
  {
   nombreMasLargo = node;
   tamañoDeNombre = node.Persona.GetLengthName();
   nombre = GetNombre();
  }
  
 }
}

