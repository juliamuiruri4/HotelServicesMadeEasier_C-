using System;
using static System.Console;

namespace HotelServiceProject
{
    class Program
    {
        //declaring the public variables
        public static int Identity1 = 1;
        public static char SeatId='a';
        public static int Option;
        public static int SecondOption;
        public static int ThirdOption;
        public static int FourthOption;
        public static int FifthOption;
        public static int Total;

        //the main method
        static void Main(string[] args)
        {
            WriteLine("Hello, welcome to Cool Rivers Hotel");
            WriteLine("You are our esteemed guest at Table {0} Seat {1}", Identity1, SeatId);
            
            WriteLine(" ");
            WriteLine("What would you like to have?");
            WriteLine("1.African Dishes\t\t\t2.Main Dishes\n\n3.Snacks\t\t\t\t4.Hot Beverages\n\n5.Soft Drinks");
            OrderOfTheDay();
            ReadKey();
        }
        //method to carry out all calculations and make orders
        public static void OrderOfTheDay()
        {
            //solution to the first order (African,main,snacks,hot,soft)
            Option = Convert.ToInt16(ReadLine());
            switch (Option)
            {
                case 1://if african
                    Clear();
                    WriteLine("African Dish\t\t\t\t\t\t\tCost\n");
                    WriteLine("1.Mukimo and Beef stew\t\t\t\t\t\tKsh.160\n2.Mukimo and Vegetable Stew\t\t\t\t\t\tKsh.120\n3.Githeri Special\t\t\t\t\t\tKsh.60\n4.Matoke plain\t\t\t\t\t\tKsh.80");
                    //after choosing african, what meal(mukimo+beef,mukimo+veg,githeri+matoke)
                    SecondOption = Convert.ToInt16(ReadLine());
                    switch (SecondOption)
                    {
                        case 1://if mukimo+beef
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            //solution to whether or not you like any additionals
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)//if yes to additionals
                            {
                                Clear();
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                //solution to what additional(soft drink, hot,snack)
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1://if additional is soft
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        //solution to what exact soft additional
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption==1)//if alvaro
                                        {
                                            Total = 220;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if minute maid
                                        {
                                            Total = 225;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 3)//if soda
                                        {
                                            Total = 185;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if ribena
                                        {
                                            Total = 200;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                    case 2://if additional is hot
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        //solution to what exact hot additional
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption == 1)//if black coffee
                                        {
                                            Total = 195;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if white coffee
                                        {
                                            Total = 195;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 3)//if plain tea
                                        {
                                            Total = 185;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if uji
                                        {
                                            Total = 200;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                    case 3://if additional is a snack
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        //solution to what exact snack as an additional
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption == 1)//if andazi
                                        {
                                            Total = 180;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if kebab
                                        {
                                            Total = 230;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 3)//if sandwich
                                        {
                                            Total = 210;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if burger
                                        {
                                            Total = 210;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)//if no additional with mukimo+beef was required
                            {
                                Total = 160;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 2://if african meal is mukimo+veg
                            WriteLine("Would you like anything else:\n1.Yes\n2.No");
                            //solution to whether you would like an additional(yes,no)
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)//if yes to additional
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                //solution to exact additional is soft drink
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1://if soft drink
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption == 1)//if alvaro
                                        {
                                            Total = 180;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if minute maid
                                        {
                                            Total = 185;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 3)//if soda
                                        {
                                            Total = 145;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if ribena
                                        {
                                            Total = 160;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                    case 2://if hot 
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        //solution to exact hot drink
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption == 1)//if black coffee
                                        {
                                            Total = 155;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if white coffee
                                        {
                                            Total = 155;
                                            WriteLine("The total amount to pay is Ksh.{0}",Total);
                                        }
                                        else if (FifthOption == 3)//if plain tea
                                        {
                                            Total = 145;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if uji
                                        {
                                            Total = 160;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                    case 3://if snack
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        //solution to exact snack
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption == 1)//if andazi
                                        {
                                            Total = 140;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if kebab
                                        {
                                            Total = 190;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 3)//if sandwich
                                        {
                                            Total = 170;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if burger
                                        {
                                            Total = 170;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                }
                            }

                            else if (ThirdOption == 2)//if no addition with mukimo+veg
                            {
                                Total = 120;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                                        break;
                        case 3://if african dish is githeri special
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            //solution to additional with githeri special
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)//if yes to additional
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                //if additional is soft drink
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1://if soft drink
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption == 1)//if alvaro
                                        {
                                            Total = 120;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if minute maid
                                        {
                                            Total = 125;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 3)//if soda
                                        {
                                            Total = 85;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if ribena
                                        {
                                            Total = 100;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                    case 2://if additional is hot
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        //solution to specific hot drink
                                        FifthOption = Convert.ToInt16(ReadLine());
                                        if (FifthOption == 1)//if black coffee
                                        {
                                            Total = 95;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 2)//if white
                                        {
                                            Total = 95;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 3)//if plain tea
                                        {
                                            Total = 85;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        else if (FifthOption == 4)//if uji
                                        {
                                            Total = 100;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                                        //CONTINUE
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                                        else if (ThirdOption == 2)
                                        {
                                            Total = 60;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                        case 4
                        :
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                                        else if (ThirdOption == 2)
                                        {
                                            Total = 80;
                                            WriteLine("The total amount to pay is Ksh.{0}", Total);
                                        }
                                        break;
                    }
                    break;
                case 2:
                    Clear();
                    WriteLine("Main Dish\t\t\t\t\t\t\tCost\n");
                    WriteLine("1.Chips plain\t\t\t\t\t\tKsh.90\n2.Chips and 1/4Kuku\t\t\t\t\t\tKsh.300\n3.Bhajia\t\t\t\t\t\tKsh.60\n4.Chips Masala\t\t\t\t\t\tKsh.130");
                    SecondOption = Convert.ToInt16(ReadLine());
                    switch (SecondOption)
                    {
                        case 1:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                Clear();
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 90;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 2:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }

                            else if (ThirdOption == 2)
                            {
                                Total = 300;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 3:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 60;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 4
                        :
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 130;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                    }
                    break;
                case 3:
                    Clear();
                    WriteLine("Snack\t\t\t\t\t\t\tCost\n");
                    WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                    SecondOption = Convert.ToInt16(ReadLine());
                    switch (SecondOption)
                    {
                        case 1:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                Clear();
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 20;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 2:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }

                            else if (ThirdOption == 2)
                            {
                                Total = 70;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 3:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 50;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 4
                        :
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 50;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                    }
                    break;
                case 4:
                    Clear();
                    WriteLine("Hot beverage\t\t\t\t\t\t\tCost\n");
                    WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                    SecondOption = Convert.ToInt16(ReadLine());
                    switch (SecondOption)
                    {
                        case 1:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                Clear();
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 35;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 2:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }

                            else if (ThirdOption == 2)
                            {
                                Total = 35;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 3:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 25;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 4
                        :
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 40;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                    }
                    break;
                case 5:
                    Clear();
                    WriteLine("soft drink\t\t\t\t\t\t\tCost\n");
                    WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                    SecondOption = Convert.ToInt16(ReadLine());
                    switch (SecondOption)
                    {
                        case 1:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                Clear();
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 60;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 2:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }

                            else if (ThirdOption == 2)
                            {
                                Total = 65;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 3:
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 25;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                        case 4
                        :
                            WriteLine("Would you like anthing else:\n1.Yes\n2.No");
                            ThirdOption = Convert.ToInt16(ReadLine());
                            if (ThirdOption == 1)
                            {
                                WriteLine("1.Soft Drink\t\t2.Hot beverage\t\t\n3.Snack");
                                FourthOption = Convert.ToInt16(ReadLine());
                                switch (FourthOption)
                                {
                                    case 1:
                                        WriteLine("1.Alvaro\t\t\t\t\t\tKsh.60\n2.Minute Maid(300)ml\t\t\t\t\t\tKsh.65\n3.Soda(250ml)\t\t\t\t\t\tKsh.25\n4.Ribena\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 2:
                                        WriteLine("1.Black coffee\t\t\t\t\t\tKsh.35\n2.White coffee\t\t\t\t\t\tKsh.35\n3.Plain tea\t\t\t\t\t\tKsh.25\n4.Uji\t\t\t\t\t\tKsh.40");
                                        break;
                                    case 3:
                                        WriteLine("1.Andazi\t\t\t\t\t\tKsh.20\n2.Kebab\t\t\t\t\t\tKsh.70\n3.Sandwich\t\t\t\t\t\tKsh.50\n4.Burger\t\t\t\t\t\tKsh.50");
                                        break;
                                }
                            }
                            else if (ThirdOption == 2)
                            {
                                Total = 40;
                                WriteLine("The total amount to pay is Ksh.{0}", Total);
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
