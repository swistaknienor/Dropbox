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
            public Animal[] animals = new Animal[5];
            public void Add(Animal pAnimal)
            {
                for (int i = 0; i < animals.Length; i++)
                {
                    if (animals[i] == null)
                    {
                        animals[i] = pAnimal;
                        break;
                    }
                }
            }/*
            public void Remove(Animal this.Animal)
            {
                for (int i = animals.Length -1; i >= 1; i--)
                {
                    if (animals[i] != null) /* neviem ako inak to vydefinovat */
                   /* {
                        animals[i] = this.Animal;
                        break;
                    }

                }
            } */
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
            Koi biely = new Koi();
            yard.Add(kekso);
            yard.Add(riusa);
            yard.Add(zlty);
            yard.Add(cerveny);
            /*yard.Add(biely); /* malo by zhucat na chybe, ze 5-ho do pola animal uz neumiestni*/
            /*yard.Remove(cerveny); /* malo by odobrat cerveneho z animal pola */
            /*yard.Add(biely); /* malo by pridat bieleho do pola animal */
        }
    } 
}
