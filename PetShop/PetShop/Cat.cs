using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Cat
    {
        public Cat(string nickname, double age, string gender,double price, double meal_quantity)
        {
            this.nickname = nickname;
            this.age = age;
            this.gender = gender;
            this.price = price;
            this.meal_quantity = meal_quantity;
            energy = 100;
        }

       
        public string nickname { get; set; }
        public double age { get; set; }
        public string  gender { get; set; }
        public double energy { get; set; }
        public double price { get; set; }
        public double meal_quantity { get; set; }
       

        public void Eat(double mealquantity)
        {
            
            if (mealquantity > meal_quantity)
            {
                Console.WriteLine("Meal quantity greater than  this cat standart meal quantity");
                System.Environment.Exit(1);
            }
            Console.WriteLine("\nCat is eating...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Cat is finished eating");

            
            energy +=15;
            if (energy >= 100)
            {
                energy = 100;
            }
            Console.WriteLine($"\nCat Energy:{energy}");
            price = (mealquantity / meal_quantity) * 10 + price;
            Console.WriteLine($"Cat Price:{price}");

        }
        public void Play()
        {
            Console.WriteLine("\nCat is Playing...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Cat finished Playing");

            
            energy -= 20;
            if (energy == 0)
            {
                Console.WriteLine("Cat energy over");
                Sleep();
            }
            else
            Console.WriteLine($"\nCat Energy:{energy}");
            
        }
        public void Sleep()
        {
            Console.WriteLine("\nCat is sleeping...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Cat woke up");

            
            energy += 30;
            if (energy >=100)
            {
                energy = 100;
            }
            Console.WriteLine($"\nCat Energy:{energy}");
        }
        public void ShowCat()
        {
            Console.WriteLine($"Nickname->{nickname}");
            Console.WriteLine($"Age->{age}");
            Console.WriteLine($"Gender->{gender}");
            Console.WriteLine($"Price->{price} Azn");
            Console.WriteLine($"Meal Quantity->{meal_quantity} gram");
            Console.WriteLine($"Energy->{energy} %");
            Console.WriteLine("\n");
        }
    }

}
