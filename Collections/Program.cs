using System;
using System.Collections.Generic;

namespace Collections
{

    public class ClaseArray
    {
        //Declarando arrays
        int[] a0;
        int[] a1 = new int[2];
        int[] a2 = new int[2] 
        {
            1,2
        };
        int[] a3 = new int[]{
            1,2,3,4,5
        };

        //Collection Generic : List<T>
        List<int> lista = new List<int>();
        

    }

    

    class Program
    {
        static void Main(string[] args)
        {

            string  texto = "'Egypt, Arab Rep.',EGY,Africa,97553151";
            string[] partes  = texto.Split(new char[]{','});
            Console.WriteLine(partes.Length);

            List<CatModel> listaGato  = new List<CatModel>();
            listaGato.Add(
                new CatModel {Name = "Cat1", Year=1}
            );
            listaGato.Add(
                new CatModel {Name = "Cat2", Year=1}
            );
            listaGato.Add(
                new CatModel {Name = "Cat3", Year=1}
            );

            var valorGato = listaGato.Find(x=>x.Name == "Cat2");
        
            System.Console.WriteLine(valorGato.Id);

            //Ejercicio de permutación
            

 
            
        }
    }
}
