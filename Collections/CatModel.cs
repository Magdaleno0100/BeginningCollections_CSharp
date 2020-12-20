using System;

namespace Collections{


    public class CatModel
    {
        //private Guid _id;
        public Guid Id 
        {
            get { return Guid.NewGuid(); }
        }
        public string Name {get;set;}
        public int Year {get;set;}
    }


}