using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class CatHouse
    {
        public Cat[] Cats { get; set; }
        public int CatCount { get; set; }
        public string CatHouseName { get; set; }

        public void AddCat(Cat newcat)
        {
            int newcount = CatCount + 1;
            Cat[] newCats = new Cat[newcount];

            for (int i = 0; i < CatCount; i++)
            {
                newCats[i] = Cats[i];
            }
            newCats[CatCount] = newcat;
            CatCount = newcount;
            Cats = newCats;
        }

        public void RemoveByNickanme(string nickname)
        {
            if (nickname == " ")
            {
                Console.WriteLine("Nickname is NUll");
                System.Environment.Exit(1);
            }
            int newcount = CatCount - 1;
            Cat[] newCats = new Cat[newcount];

            for (int i = 0; i < CatCount; i++)
            {
                if (Cats[i].nickname == nickname)
                {
                    for (int k = 0,j=0; j < CatCount; j++)
                    {
                        if (j != i) newCats[k++] = Cats[j];
                    }
                    Cats = newCats;
                    CatCount = newcount;
                }
               
            }
            CatCount = newcount;
            Cats = newCats;
        }

        public void ShowCatHouse()
        {
            Console.WriteLine($"----------- {CatHouseName} ------------");
            foreach (var cat in Cats)
            {
                cat.ShowCat();
            }
        }
    }
}
