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

    public class TopTenPops
    {
        string filePath = @"";
   
    }

    public class CatModel
    {
        //private Guid _id;
        public Guid Id 
        {
            //set { _id = value; }
            get { return Guid.NewGuid(); }
        }
        public string Name {get;set;}
        public int Year {get;set;}
    }

    class Program
    {
        static void Main(string[] args)
        {

            string  texto = "'Egypt, Arab Rep.',EGY,Africa,97553151";
            //string[] partes  = texto.Split(',');
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

 
            
        }
    }
}
