using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Newspaper
    {
        private Story[] stories;
        private float price;

        public Story[] GetStories()
        {
            return stories;
        }
        public void Setstories(Story[] newstories)
        {
            this.stories = newstories;
        }
        public float GetPrice()
        {
            return price;
        }
        public void SetPrice(float newprice)
        {
            if(newprice > 0)
            {
                this.price = newprice;
            }
            else
            {
                Console.WriteLine("illegale price");
            }
           
        }
        public void Read()
        {
            Console.WriteLine($" The story in newspaper is {stories}");
        }

        public override string ToString()
        {
            return $" Newspaper: stories:{stories} price:{price}";
        }
    }
}
