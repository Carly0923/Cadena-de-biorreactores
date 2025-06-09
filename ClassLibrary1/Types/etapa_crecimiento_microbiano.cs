namespace Dominio_Fermentación.Types
{
  /// <summary> Definiendo etapas del crecimiento microbiano porque aquí si se aprendió ing genética </summary>
  public enum etapa_crecimiento_microbiano
  {
   #region
   /// <summary> Adaptación: Cambio en fuentes de carbono, el elemento de expresión se adapta a la nueva fuente de carbono y a los elementos traza.
   /// Metabolismo lento, peso húmedo bajo, pH alto, nivel de oxígeno disuelto bajo
   /// Primera Etapa </summary>
   Adaptacion,
   /// <summary> Crecimiento exponencial: Ya ocurrió la adaptación a la fuente de carbono, la levadura empieza a metabolizar dicha fuente
   /// Metabolismo rápido, aumenta el peso húmedo, empieza a bajar el pH, aumenta el nivel de oxigeno disuelto
   /// Segunda Etapa </summary>
   Crecimiento_Exponencial,
   /// <summary> Meseta: El crecimiento exponencial cesa cuando la levadura se adapta completamente a la fuente de carbono y la metaboliza constantemente
   /// Al crecer la población microbiana de la muestra, deja de haber la suficiente cantidad de fuente de carbono para seguir metabolizando
   /// En el medio de cultivo comienza a escasear el alcohol y esto provoca una meseta de crecimiento, teniendo variables estandar constantes o con poca variación
   /// Tercera Etapa </summary>
   Meseta,
   /// <summary> Muerte celular: Ya ocurrió la fermentación, las células empiezan a morir de hambre, el ph baja aún más, volviendo al medio de cultivo completamente ácido
   /// Es necesario terminar la fermentación al llegar a esta etapa para evitar la pérdida del medio fermentado
   /// Cuarta Etapa </summary>
   Muerte_Celular,
   #endregion
  }
}
