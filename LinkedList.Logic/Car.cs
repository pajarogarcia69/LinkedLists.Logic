using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Logic
{
    public class Car
    {
       

        public string? Brand { get;set;}
        public string? Model { get;set;}
        
        public int Year { get;set;}

        public string? Color { get;set;}

        public decimal Price { get;set;}

        public override string ToString()
        {
            return $"{Brand} - {Model} - {Year} - {Color} - {Price:C2}";
        }

    }
}
