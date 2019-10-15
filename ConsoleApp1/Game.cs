using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Game
    {

        #region Properties

        private readonly string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        protected decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; }
        #endregion Properties

        #region Constructors

        public Game(string name, decimal price, DateTime releasedate)

        public Game(string  name, decimal price)

        public Game() : this("", 0) { }

        public override string ToString()
        {
            return string.Format($"{Name} {Price:c} {ReleaseDate.ToShortDateString}");
        }

        public abstract void UpdatePrice(decimal percentageIncrease);
        {

        }


    }//end of class

    public class ComputerGame : Game
    {

    }
}
