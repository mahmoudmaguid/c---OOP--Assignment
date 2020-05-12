using System;

namespace Polymorphism
{


    class Buyer
    {
        private string buyername;
        private string price;
        public string Mybuyername
        {
            get
            {
                return buyername;
            }
            set
            {
                buyername = value;
            }
        }
        public string Myprice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        class Painting
        {
            public virtual void Name()
            {
                Console.WriteLine("Insert PAINT Name");
            }
            public virtual void Artist()
            {
                Console.WriteLine("Insert Artist Name");
            }
            public virtual void Medium()
            {
                Console.WriteLine("Insert Medium");
            }

            public virtual void Year()
            {
                Console.WriteLine("Insert Year");
            }
        }

        class CoffeeLake : Painting
        {
            public override void Name()
            {
                Console.WriteLine("Coffee Lake");
            }
            public override void Artist()
            {
                Console.WriteLine("Panyet");
            }
            public override void Medium()
            {
                Console.WriteLine("oil");
            }
            public override void Year()
            {
                Console.WriteLine("1981");
            }
        }
        class Havanna : Painting
        {
            public override void Name()
            {
                Console.WriteLine("Havanna");
            }
            public override void Artist()
            {
                Console.WriteLine("La TOWE");
            }
            public override void Medium()
            {
                Console.WriteLine("oil");
            }
            public override void Year()
            {
                Console.WriteLine("1900");
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Painting myPaiting = new Painting();
                Painting myCoffeeLake = new CoffeeLake();
                Painting myHavanna = new Havanna();

                myCoffeeLake.Artist();
                myHavanna.Year();
                myCoffeeLake.Year();
                myCoffeeLake.Name();
                myHavanna.Name();

                Buyer mybuyer = new Buyer();


                mybuyer.Mybuyername = "David";
                mybuyer.Myprice = "20000$";
                Console.WriteLine("buyername: " + mybuyer.Mybuyername);
                string mysellLog = mybuyer.Myprice;
                Console.WriteLine(mysellLog);
                Console.WriteLine("PRICE " + mybuyer.Myprice);

            }
        }
    }
}