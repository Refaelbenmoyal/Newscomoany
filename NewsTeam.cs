using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal abstract class NewsTeam
    {
        protected string _story;
        internal abstract void CreateStory();
        internal string GetStory()
        {
            return this._story;
        }
        internal virtual void AddStyle()
        {
            Console.WriteLine("The paper adds style");
        }

        public override string ToString()
        {
            return $" NewsTeam: story:{_story}";
        }
    }
}
