using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Program
    {
        static void Start()
        {
            Cat cat1 = new Cat("Tom", 1, "Female", 1200, 250);
            Cat cat2 = new Cat("Mestan", 1.5, "Male", 1600, 300);

            Cat[] cats = new Cat[2]
            {
                cat1,cat2
            };

            CatHouse cathouse1 = new CatHouse { CatCount = 2, Cats = cats, CatHouseName = "CatWorld" };


            Cat cat3 = new Cat("Black", 1, "Male", 1230, 180);
            Cat cat4 = new Cat("Muezza", 2, "Female", 1500, 220);
            Cat cat5 = new Cat("Mesi", 2.5, "Male", 2010, 170);


            Cat[] cats2 = new Cat[3]
            {
                cat3,cat4,cat5
            };

            CatHouse cathouse2 = new CatHouse { CatCount = 3, CatHouseName = "CatMiracle", Cats = cats2 };

            CatHouse[] catHouses = new CatHouse[2]
            {
                cathouse1,cathouse2
            };

            PetShop petShop = new PetShop { CatHouseCount = 2, CatHouses = catHouses, PetShopName = "Pet Shop" };

            ////  AddCat method /////
            //Cat newcat = new Cat("Snow",1,"Female",1300,230);
            //cathouse1.AddCat(newcat);

            ///// RemovebyNickname method /////

            //cathouse1.RemoveByNickanme("Mestan");

            //// Eat,Sleep,Play methods ////

            //cat2.Play();
            //cat2.Eat(120);
            //cat2.Sleep();

            /// PetShop Methods /////

            //petShop.ShowPetShop();
            //petShop.ShowAllCatsPrice();
            //petShop.ShowAllMealQuantity();

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Start();
        }
    }
}
