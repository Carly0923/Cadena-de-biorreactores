namespace Dominio_Fermentación.Entities;
using Dominio_Fermentación.Types;

 public class Comunication_Node
 {
  #region Properties
  /// <summary> Posición del registro inicial a leer </summary>
  public int RegisterPosition { set; get; }
  /// <summary> Cantidad de registros a leer </summary>
  public int RegisterLength { set; get; }
  #endregion
  /// <summary> Constructor </summary>
   public Comunication_Node(int registerposition, int registerlength)
   {
    RegisterPosition = registerposition;
    RegisterLength = registerlength;
   }
 }