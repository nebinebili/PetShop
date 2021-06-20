using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class PetShop
    {
        public CatHouse[] CatHouses { get; set; }
        public int CatHouseCount { get; set; }
        public string PetShopName { get; set; }

        public void ShowPetShop()
        {
            Console.WriteLine($"<<<<<<<<<<<<<<< {PetShopName} <<<<<<<<<<<<<<<");
            Console.WriteLine("\n\t\t--CatHouses--");
            Console.WriteLine("\n");
            foreach (var catHouse in CatHouses)
            {
                catHouse.ShowCatHouse();
            }
        }
        public void ShowAllCatsPrice()
        {
            double result = 0;
            foreach (var cathouse in CatHouses)
            {
                foreach (var cat in cathouse.Cats)
                {
                    result += cat.price;
                }
            }
            Console.WriteLine($"All Cats Price:{result}");
        }
        public void ShowAllMealQuantity()
        {
            double result = 0;
            foreach (var cathouse in CatHouses)
            {
                foreach (var cat in cathouse.Cats)
                {
                    result += cat.meal_quantity;
                }
            }
            Console.WriteLine($"All Cats Meal Quantity:{result}");
        }
    }
}
