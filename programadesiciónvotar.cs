Autor:           any michelle arango
fecha:            2024-05-22
descripcion:    programa de decisiones para
                habilitar votación de personas
                y descuento matricula estudio.

*******************************************************************************/
using System;
class programa {
  static void Main() {
      // variables 
      int edad;
      int valorMatricula;
      
      // peticion de datos 
    Console.WriteLine("Diguite la edad :");
    edad = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite su valor de matricula: ");
    valorMatricula = Int32.Parse(Console.ReadLine());
    
    //validacion
    if(edad >= 18 ){
        Console.WriteLine("Felicidades,usted puede votar");
        Console.WriteLine("Usted pagara de matricula : " + (valorMatricula * 0.85));
    }
  }
}
