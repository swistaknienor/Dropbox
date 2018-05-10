using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_farm_yard_class
{
    class Program
    {     
        public class Yard
        {
            public Animal[] animals = new Animal[10];
            public void Add(Animal pAnimal)
           /* public void Remove(Animal pAnimal) */
            {
                for (int i = 0; i < animals.Length; i++)
                {
                    if (animals[i] == null)
                    {
                        animals[i] = pAnimal;
                        break;
                    }
                }
              /*  for (int i <= animal.Length -1; i--)
                {
                    if (animals[i] != null)
                    {
                        animals[i] = pAnimal;
                        break;
                    } 
                } */
            }
        }
        public class Animal
        {
        }     
        public class Dog:Animal
        {
        }
        public class Koi:Animal
        {
        }
        static void Main(string[] args)
        {
            Yard yard = new Yard();
            Dog kekso = new Dog();
            Dog riusa = new Dog();
            Koi zlty = new Koi();
            Koi cerveny = new Koi();
            yard.Add(kekso);
            yard.Add(riusa);
            yard.Add(zlty);
            yard.Add(cerveny);
           /* yard.Remove(cerveny);   */     }
    } 
}
