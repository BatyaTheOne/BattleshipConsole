using System;
using System.Collections.Generic;
using System.Linq;

namespace BS
{
    class Program
    {
            
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
        string[,] seaboat = new string[9, 9]; //{ { '1', '2', '3', '4', '5', '6', '7' }};//'■'
            string[,] sea = new string[9, 9];//'■'
            string[,] seaiiboat = new string[9, 9];//'■'
            string[,] seaii = new string[9, 9];//'■'
            for (int i = 1; i != 8; i++)
            {
                for (int j = 1; j != 8; j++)
                {
                    sea[i, j] = "■";
                    seaboat[i, j] = "■";
                    seaii[i, j] = "■";
                    seaiiboat[i, j] = "■";
                }
            }
            for (int i = 1; i != 8; i++)
            {
                sea[0, i] = i.ToString();
                seaii[0, i] = i.ToString();
                seaboat[0, i] = i.ToString();
                seaiiboat[0, i] = i.ToString();
            }
            sea[0, 0] = " ";
            seaii[0, 0] = " ";
            seaboat[0, 0] = " ";
            seaiiboat[0, 0] = " ";
            sea[1, 0] = "a";
            sea[2, 0] = "b";
            sea[3, 0] = "c";
            sea[4, 0] = "d";
            sea[5, 0] = "e";
            sea[6, 0] = "f";
            sea[7, 0] = "g";

            seaii[1, 0] = "a";
            seaii[2, 0] = "b";
            seaii[3, 0] = "c";
            seaii[4, 0] = "d";
            seaii[5, 0] = "e";
            seaii[6, 0] = "f";
            seaii[7, 0] = "g";

            seaboat[1, 0] = "a";
            seaboat[2, 0] = "b";
            seaboat[3, 0] = "c";
            seaboat[4, 0] = "d";
            seaboat[5, 0] = "e";
            seaboat[6, 0] = "f";
            seaboat[7, 0] = "g";

            seaiiboat[1, 0] = "a";
            seaiiboat[2, 0] = "b";
            seaiiboat[3, 0] = "c";
            seaiiboat[4, 0] = "d";
            seaiiboat[5, 0] = "e";
            seaiiboat[6, 0] = "f";
            seaiiboat[7, 0] = "g";
           
            bool hod = false;
            int SmallShip = 4;
            bool h = true, doo = false, wasd = false;
            int RegularShip = 2;
            string Letter = "0";

            SmallShip = 4;
                int  x = 2, y = 2, boat = 6, boatii = 6, xx = 0, yy = 0;

            for (int i = 0; SmallShip != 0; i++)
            {
                for (int ii = 0; ii != 8; ii++)
                {
                    for (int j = 0; j != 8; j++)
                    {
                        Console.Write(seaboat[ii, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($" You have {RegularShip} big ships");
                try
                {
                    Console.WriteLine("Letter");
                    Letter = Console.ReadLine();
                    Console.WriteLine(  "number");
                    y = int.Parse(Console.ReadLine());
                    switch (Letter)
                    {
                        case "a":
                            {
                                x = 1;
                                break;
                            }
                        case "b":
                            {
                                x = 2;
                                break;
                            }
                        case "c":
                            {
                                x = 3;
                                break;
                            }
                        case "d":
                            {
                                x = 4;
                                break;
                            }
                        case "e":
                            {
                                x = 5;
                                break;
                            }
                        case "f":
                            {
                                x = 6;
                                break;
                            }
                        case "g":
                            {
                                x = 7;
                                break;
                            }
                    }

                    if (seaboat[x, y] != "&" && seaboat[(x + 1), y] != "&" && seaboat[(x - 1), y] != "&" && seaboat[x, (y + 1)] != "&" && seaboat[x, (y - 1)] != "&" && seaboat[(x + 1), (y + 1)] != "&" && seaboat[(x + 1), (y - 1)] != "&" && seaboat[(x - 1), (y + 1)] != "&" && seaboat[(x - 1), (y - 1)] != "&")
                    {
                        seaboat[x, y] = "&";

                        for (int ii = 0; ii != 8; ii++)
                        {
                            for (int j = 0; j != 8; j++)
                            {
                                Console.Write(seaboat[ii, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        do
                        {
                            Console.WriteLine("w a s d");
                            Letter = Console.ReadLine();
                            if (Letter == "w")
                            {
                                Letter = "q";
                                x--;
                                if (seaboat[x, y] != "&" && seaboat[(x - 1), y] != "&" && seaboat[x, (y + 1)] != "&" && seaboat[x, (y - 1)] != "&" && seaboat[(x + 1), (y + 1)] != "&" && seaboat[(x + 1), (y - 1)] != "&" && seaboat[(x - 1), (y + 1)] != "&" && seaboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "w";
                                }
                                x++;
                            }
                            else if (Letter == "a")
                            {
                                Letter = "e";
                                y--;
                                if (seaboat[x, y] != "&" && seaboat[(x + 1), y] != "&" && seaboat[(x - 1), y] != "&" && seaboat[x, (y - 1)] != "&" && seaboat[(x + 1), (y + 1)] != "&" && seaboat[(x + 1), (y - 1)] != "&" && seaboat[(x - 1), (y + 1)] != "&" && seaboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "a";
                                }
                                y++;
                            }
                            else if (Letter == "s")
                            {
                                Letter = "r";
                                x++;
                                if (seaboat[x, y] != "&" && seaboat[(x + 1), y] != "&" && seaboat[x, (y + 1)] != "&" && seaboat[x, (y - 1)] != "&" && seaboat[(x + 1), (y + 1)] != "&" && seaboat[(x + 1), (y - 1)] != "&" && seaboat[(x - 1), (y + 1)] != "&" && seaboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "s";
                                }
                                x--;
                            }
                            else if (Letter == "d")
                            {
                                Letter = "t";
                                y++;
                                if (seaboat[x, y] != "&" && seaboat[(x + 1), y] != "&" && seaboat[(x - 1), y] != "&" && seaboat[x, (y + 1)] != "&" && seaboat[(x + 1), (y + 1)] != "&" && seaboat[(x + 1), (y - 1)] != "&" && seaboat[(x - 1), (y + 1)] != "&" && seaboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "d";
                                }
                                y--;
                            }
                            else
                            {
                                Console.WriteLine("eror wasd");
                            }
                            if (Letter == "w" || Letter == "a" || Letter == "s" || Letter == "d")
                            {
                                h = false;
                            }

                        } while (h);
                        h = true;
                    }
                }
                catch
                {
                    Console.WriteLine("eror");
                    if (Letter == "e")
                    {
                        y++;
                        seaboat[x, y] = "■";
                    }
                    else if (Letter == "q")
                    {
                        x++;
                        seaboat[x, y] = "■";
                    }
                    else if (Letter == "r")
                    {
                        x--;
                        seaboat[x, y] = "■";
                    }
                    else if (Letter == "t")
                    {
                        y--;
                        seaboat[x, y] = "■";
                    }
                }
            }
            for (int ii = 0; ii != 8; ii++)
            {
                for (int j = 0; j != 8; j++)
                {
                    Console.Write(seaboat[ii, j] + " ");
                }
                Console.WriteLine();
            }
            for (int ii = 0; ii != 8; ii++)
            {
                for (int j = 0; j != 8; j++)
                {
                    Console.Write(seaboat[ii, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; SmallShip != 0; i++)
            {
                Console.WriteLine($"   You have {SmallShip} big ships");
                try
                {
                    Console.WriteLine("Letter");
                    Letter = Console.ReadLine();
                    Console.WriteLine("number");
                    y = int.Parse(Console.ReadLine());
                    switch (Letter)
                    {
                        case "a":
                            {
                                x = 1;
                                break;
                            }
                        case "b":
                            {
                                x = 2;
                                break;
                            }
                        case "c":
                            {
                                x = 3;
                                break;
                            }
                        case "d":
                            {
                                x = 4;
                                break;
                            }
                        case "e":
                            {
                                x = 5;
                                break;
                            }
                        case "f":
                            {
                                x = 6;
                                break;
                            }
                        case "g":
                            {
                                x = 7;
                                break;
                            }
                    }

                    if (seaboat[x, y] != "&" && seaboat[(x + 1), y] != "&" && seaboat[(x - 1), y] != "&" && seaboat[x, (y + 1)] != "&" && seaboat[x, (y - 1)] != "&" && seaboat[(x + 1), (y + 1)] != "&" && seaboat[(x + 1), (y - 1)] != "&" && seaboat[(x - 1), (y + 1)] != "&" && seaboat[(x - 1), (y - 1)] != "&")
                    {
                        seaboat[x, y] = "&";
                        SmallShip--;
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
                catch
                {
                    Console.WriteLine("eror2");
                }
                for (int ii = 0; ii != 8; ii++)
                {
                    for (int j = 0; j != 8; j++)
                    {
                        Console.Write(seaboat[ii, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            SmallShip = 4;
            RegularShip = 2;
            for (int i = 0; SmallShip != 0; i++)
            {
                y = rnd.Next(1, 8);//a 1
                x = rnd.Next(1, 8);
                if (seaiiboat[x, y] != "&" && seaiiboat[(x + 1), y] != "&" && seaiiboat[(x - 1), y] != "&" && seaiiboat[x, (y + 1)] != "&" && seaiiboat[x, (y - 1)] != "&" && seaiiboat[(x + 1), (y + 1)] != "&" && seaiiboat[(x + 1), (y - 1)] != "&" && seaiiboat[(x - 1), (y + 1)] != "&" && seaiiboat[(x - 1), (y - 1)] != "&")
                {
                    seaiiboat[x, y] = "&";
                    string[] mas = { "w", "a", "s", "d" };
                    do
                    {
                        try
                        {
                            Letter = mas[rnd.Next(0, 4)];
                            if (Letter == "w")
                            {
                                Letter = "q";
                                x = x - 1;
                                if (seaiiboat[x, y] != "&" && seaiiboat[(x - 1), y] != "&" && seaiiboat[x, (y + 1)] != "&" && seaiiboat[x, (y - 1)] != "&" && seaiiboat[(x + 1), (y + 1)] != "&" && seaiiboat[(x + 1), (y - 1)] != "&" && seaiiboat[(x - 1), (y + 1)] != "&" && seaiiboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaiiboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "w";
                                }
                                x++;
                            }
                            else if (Letter == "a")
                            {
                                Letter = "q";
                                y = y - 1;
                                if (seaiiboat[x, y] != "&" && seaiiboat[(x + 1), y] != "&" && seaiiboat[(x - 1), y] != "&" && seaiiboat[x, (y - 1)] != "&" && seaiiboat[(x + 1), (y + 1)] != "&" && seaiiboat[(x + 1), (y - 1)] != "&" && seaiiboat[(x - 1), (y + 1)] != "&" && seaiiboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaiiboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "a";
                                }
                                y++;
                            }
                            else if (Letter == "s")
                            {
                                Letter = "q";
                                x++;
                                if (seaiiboat[x, y] != "&" && seaiiboat[(x + 1), y] != "&" && seaiiboat[x, (y + 1)] != "&" && seaiiboat[x, (y - 1)] != "&" && seaiiboat[(x + 1), (y + 1)] != "&" && seaiiboat[(x + 1), (y - 1)] != "&" && seaiiboat[(x - 1), (y + 1)] != "&" && seaiiboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaiiboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "s";
                                }
                                x--;
                            }
                            else if (Letter == "d")
                            {
                                Letter = "q";
                                y++;
                                if (seaiiboat[x, y] != "&" && seaiiboat[(x + 1), y] != "&" && seaiiboat[(x - 1), y] != "&" && seaiiboat[x, (y + 1)] != "&" && seaiiboat[(x + 1), (y + 1)] != "&" && seaiiboat[(x + 1), (y - 1)] != "&" && seaiiboat[(x - 1), (y + 1)] != "&" && seaiiboat[(x - 1), (y - 1)] != "&")
                                {
                                    seaiiboat[x, y] = "&";
                                    SmallShip--;
                                    Letter = "d";
                                }
                                y--;
                            }
                            else
                            {
                                Console.WriteLine("eror wasd");
                            }
                            if (Letter == "w" || Letter == "a" || Letter == "s" || Letter == "d")
                            {
                                h = false;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("erorii");
                        }
                    } while (h);
                    h = true;
                }
            }
           
            for (int i = 0; SmallShip != 0; i++)
            {
                x = rnd.Next(1, 8);
                y = rnd.Next(1, 8);//a 1
                if (seaiiboat[x, y] != "&" && seaiiboat[(x + 1), y] != "&" && seaiiboat[(x - 1), y] != "&" && seaiiboat[x, (y + 1)] != "&" && seaiiboat[x, (y - 1)] != "&" && seaiiboat[(x + 1), (y + 1)] != "&" && seaiiboat[(x + 1), (y - 1)] != "&" && seaiiboat[(x - 1), (y + 1)] != "&" && seaiiboat[(x - 1), (y - 1)] != "&")
                {
                    seaiiboat[x, y] = "&";
                    SmallShip--;
                }
                else
                {
                    Console.WriteLine("no");
                }
               
            }

            Console.ReadKey();
            Console.WriteLine("the bot is ready to play");
            for (bool i = false; i != true; i = false)
            {
                if (boat == 0)
                {
                    Console.WriteLine("win bot");
                }
                else if (boatii == 0)
                {
                    Console.WriteLine("you win");
                }
                else
                {
                    for (int my = 1; my != 0; my--)
                    {
                        try
                        {
                            Letter = Console.ReadLine();
                            y = int.Parse(Console.ReadLine());//a 1
                            switch (Letter)
                            {
                                case "a":
                                    {
                                        x = 1;
                                        break;
                                    }
                                case "b":
                                    {
                                        x = 2;
                                        break;
                                    }
                                case "c":
                                    {
                                        x = 3;
                                        break;
                                    }
                                case "d":
                                    {
                                        x = 4;
                                        break;
                                    }
                                case "e":
                                    {
                                        x = 5;
                                        break;
                                    }
                                case "f":
                                    {
                                        x = 6;
                                        break;
                                    }
                                case "g":
                                    {
                                        x = 7;
                                        break;
                                    }
                                default:
                                    {
                                        x = 9;
                                        Console.WriteLine("eror xy");
                                        break;
                                    }
                            }
                        }
                        catch
                        {
                            x = 9;
                            Console.WriteLine("eror xy");
                        }
                        if (y > 0 && y < 8 && x > 0 && x < 8 && sea[x, y] == "■")
                        {
                            hod = true;
                            for (int ii = 1; ii != 0; ii--)
                            {
                                if (seaiiboat[x, y] == "■")
                                {
                                    seaiiboat[x, y] = "0";
                                    sea[x, y] = "0";
                                    Console.WriteLine("noooo");
                                }
                                else if (seaiiboat[x, y] == "&")
                                {
                                    if (seaiiboat[(x + 1), y] != "&" && seaiiboat[(x - 1), y] != "&" && seaiiboat[x, (y + 1)] != "&" && seaiiboat[x, (y - 1)] != "&" && seaiiboat[(x + 1), (y + 1)] != "&" && seaiiboat[(x + 1), (y - 1)] != "&" && seaiiboat[(x - 1), (y + 1)] != "&" && seaiiboat[(x - 1), (y - 1)] != "&")
                                    {
                                        if (seaiiboat[(x + 1), y] != "#" && seaiiboat[(x - 1), y] != "#" && seaiiboat[x, (y + 1)] != "#" && seaiiboat[x, (y - 1)] != "#" && seaiiboat[(x + 1), (y + 1)] != "#" && seaiiboat[(x + 1), (y - 1)] != "#" && seaiiboat[(x - 1), (y + 1)] != "#" && seaiiboat[(x - 1), (y - 1)] != "#")
                                        {
                                            seaiiboat[x, y] = "@";
                                            sea[x, y] = "@";
                                            Console.WriteLine("yasss1");
                                            boatii--;
                                            my++;
                                        }
                                        else
                                        {
                                            seaiiboat[x, y] = "@";
                                            sea[x, y] = "@";
                                            Console.WriteLine("yasss2");
                                            boatii--;
                                            my++;
                                        }
                                    }
                                    else
                                    {
                                        seaiiboat[x, y] = "#";
                                        sea[x, y] = "#";
                                        Console.WriteLine("50%");
                                        my++;
                                    }
                                }
                                for (int iii = 0; iii != 8; iii++)
                                {
                                    for (int j = 0; j != 8; j++)
                                    {

                                        Console.Write(sea[iii, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                    if (y > 0 && y < 8 && x > 0 && x < 8 && hod)
                    {
                        hod = false;
                        for (int ii = 1; ii != 0; ii--)
                        {
                            if (wasd == true)
                            {
                                int rez = rnd.Next(1, 5);
                                x = xx;
                                y = yy;
                                switch (rez)
                                {
                                    case 1:
                                        {
                                            x = x + 1;
                                            break;
                                        }
                                    case 2:
                                        {
                                            x = x - 1;
                                            break;
                                        }
                                    case 3:
                                        {
                                            y = y - 1;
                                            break;
                                        }
                                    case 4:
                                        {
                                            y = y + 1;
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                x = rnd.Next(1, 8);
                                y = rnd.Next(1, 8);
                            }

                            if (seaboat[x, y] != "&" && seaboat[x, y] != "■" && seaboat[x, y] != "#")
                            {
                                ii++;
                            }
                            else
                            {
                                if (seaboat[x, y] == "■")
                                {
                                    seaboat[x, y] = "0";
                                    seaii[x, y] = "0";
                                    Console.WriteLine("noooo");
                                    doo = false;
                                }
                                else if (seaboat[x, y] == "&")
                                {
                                    if (seaboat[(x + 1), y] != "&" && seaboat[(x - 1), y] != "&" && seaboat[x, (y + 1)] != "&" && seaboat[x, (y - 1)] != "&" && seaboat[(x + 1), (y + 1)] != "&" && seaboat[(x + 1), (y - 1)] != "&" && seaboat[(x - 1), (y + 1)] != "&" && seaboat[(x - 1), (y - 1)] != "&")
                                    {
                                        if (seaboat[(x + 1), y] != "#" && seaboat[(x - 1), y] != "#" && seaboat[x, (y + 1)] != "#" && seaboat[x, (y - 1)] != "#" && seaboat[(x + 1), (y + 1)] != "#" && seaboat[(x + 1), (y - 1)] != "#" && seaboat[(x - 1), (y + 1)] != "#" && seaboat[(x - 1), (y - 1)] != "#")
                                        {
                                            seaboat[x, y] = "@";
                                            seaii[x, y] = "@";
                                            Console.WriteLine("yasss1");
                                            boat--;
                                            ii++;
                                            doo = false;///////
                                            seaboat[(x + 1), y] = "0";
                                            seaboat[(x - 1), y] = "0";
                                            seaboat[x, (y + 1)] = "0";
                                            seaboat[x, (y - 1)] = "0";
                                            seaboat[(x + 1), (y + 1)] = "0";
                                            seaboat[(x + 1), (y - 1)] = "0";
                                            seaboat[(x - 1), (y + 1)] = "0";
                                            seaboat[(x - 1), (y - 1)] = "0";

                                            seaii[(x + 1), y] = "0";
                                            seaii[(x - 1), y] = "0";
                                            seaii[x, (y + 1)] = "0";
                                            seaii[x, (y - 1)] = "0";
                                            seaii[(x + 1), (y + 1)] = "0";
                                            seaii[(x + 1), (y - 1)] = "0";
                                            seaii[(x - 1), (y + 1)] = "0";
                                            seaii[(x - 1), (y - 1)] = "0";

                                            for (int a = 1; a != 8; a++)
                                            {
                                                seaii[0, a] = a.ToString();
                                                seaboat[0, a] = a.ToString();

                                            }
                                            seaii[0, 0] = " ";
                                            seaboat[0, 0] = " ";
                                            seaboat[1, 0] = "a";
                                            seaboat[2, 0] = "b";
                                            seaboat[3, 0] = "c";
                                            seaboat[4, 0] = "d";
                                            seaboat[5, 0] = "e";
                                            seaboat[6, 0] = "f";
                                            seaboat[7, 0] = "g";
                                            seaii[1, 0] = "a";
                                            seaii[2, 0] = "b";
                                            seaii[3, 0] = "c";
                                            seaii[4, 0] = "d";
                                            seaii[5, 0] = "e";
                                            seaii[6, 0] = "f";
                                            seaii[7, 0] = "g";
                                        }
                                        else
                                        {
                                            wasd = false;
                                            seaboat[x, y] = "@";
                                            seaii[x, y] = "@";
                                            Console.WriteLine("yasss2");
                                            boat--;
                                            ii++;
                                            seaboat[(x + 1), y] = "0";
                                            seaboat[(x - 1), y] = "0";
                                            seaboat[x, (y + 1)] = "0";
                                            seaboat[x, (y - 1)] = "0";
                                            seaboat[(x + 1), (y + 1)] = "0";
                                            seaboat[(x + 1), (y - 1)] = "0";
                                            seaboat[(x - 1), (y + 1)] = "0";
                                            seaboat[(x - 1), (y - 1)] = "0";

                                            seaii[(x + 1), y] = "0";
                                            seaii[(x - 1), y] = "0";
                                            seaii[x, (y + 1)] = "0";
                                            seaii[x, (y - 1)] = "0";
                                            seaii[(x + 1), (y + 1)] = "0";
                                            seaii[(x + 1), (y - 1)] = "0";
                                            seaii[(x - 1), (y + 1)] = "0";
                                            seaii[(x - 1), (y - 1)] = "0";

                                            for (int a = 1; a != 8; a++)
                                            {
                                                seaii[0, a] = a.ToString();
                                                seaboat[0, a] = a.ToString();

                                            }
                                            seaii[0, 0] = " ";
                                            seaboat[0, 0] = " ";

                                            seaboat[1, 0] = "a";
                                            seaboat[2, 0] = "b";
                                            seaboat[3, 0] = "c";
                                            seaboat[4, 0] = "d";
                                            seaboat[5, 0] = "e";
                                            seaboat[6, 0] = "f";
                                            seaboat[7, 0] = "g";
                                            seaii[1, 0] = "a";
                                            seaii[2, 0] = "b";
                                            seaii[3, 0] = "c";
                                            seaii[4, 0] = "d";
                                            seaii[5, 0] = "e";
                                            seaii[6, 0] = "f";
                                            seaii[7, 0] = "g";
                                        }
                                    }

                                    else
                                    {
                                        seaboat[x, y] = "#";
                                        seaii[x, y] = "#";
                                        Console.WriteLine("50%");
                                        ii++;
                                        wasd = true;
                                        xx = x;
                                        yy = y;
                                    }
                                }
                                for (int iiii = 0; iiii != 8; iiii++)
                                {
                                    for (int j = 0; j != 8; j++)
                                    {
                                        Console.Write(seaii[iiii, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("eror 0");
                    }
                }
            }
        }
    }
}
