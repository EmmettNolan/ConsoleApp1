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
        {
            _name = name;
            Price = price;
            ReleaseDate = releasedate;
        }

        public Game(string name, decimal price)
            : this(name, price, DateTime.Now)
        {

        }


        public Game() : this("", 0) { }

        #endregion Constructors

        public override string ToString()
        {
            return string.Format($"{Name} {Price:c} {ReleaseDate.ToShortDateString()}");
        }

        public abstract void UpdatePrice(decimal percentageIncrease);
        //{
        //    Price *= (1 + percentageIncrease);
        //}
        


    } //end of class

    public class ComputerGame : Game
    {
        public string PEGI_Rating { get; set; }

        public ComputerGame(string name, decimal price, DateTime date, string pegi)
             : base(name, price, date)
        {
            PEGI_Rating = pegi;
        }

        public override string ToString()
        {
            return string.Format($"{Name} {Price:c} {ReleaseDate.ToShortDateString()}");
        }

        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }

        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating the price");
        }
    }
}
