/******************************************************************************
Autor:           any michelle arango
fecha:            2024-05-22
descripcion:    programa de decisiones para
                determinar el sexo de un usuario
*******************************************************************************/

using System;
class programa {
  static void Main() {
      //variables 
      bool sexoMasculino;
      // capturar información del usuario
      Console.Write("digite true si es hombre  ");
      sexoMasculino =  Convert.ToBoolean(Console.ReadLine());
      //validacion
    if (sexoMasculino == true)
    {
         Console.WriteLine("Felicidades, es hombre"); 
    }
    else{
        Console.WriteLine("Felicidades, es mujer");
    }
    Console.WriteLine("finalizada la ejecucion");
  }
}
  
