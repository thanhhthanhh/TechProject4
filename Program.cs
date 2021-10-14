/*
    Author: Thanh Nguyen
    Date: 10/12/2021
    Comment: This C# Console Application code use to determine 
                and output the number of points in the Bela Kattis Problem.
 */

using System;
using System.Collections.Generic;

namespace TechProject4
{
    class Program
    {
        private static readonly char dominant;
        private static object pair0;

        public static char Dominant => dominant;

        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter the Input the Value:");

        
                var input = Console.ReadLine();
                var dominantmap = MapDominant();
                var notDominantMap = MapNotDominant();

             
                while (input != null)
                {
                    var line = input.Split(' ');
                    int count = int.Parse(line[0]);
                    int output = 0;

                    string dominantvalue = line[1];
                    for (int i = 0; i < count * 4; i++)
                    {
                        string pair = Console.ReadLine();
                        if (!pair.EndsWith(dominant))
                        {
                            output += notDominantMap[pair[0].ToString()];
                        }
                        else
                        {
                            output += dominantmap[pair[0].ToString()];
                        } // End of String
                    } // End of FOR

                    static Dictionary<string, int> MapDominant()
                    {
                        var map = new Dictionary<string, int>();
                        map.Add("A", 11);
                        map.Add("K", 4);
                        map.Add("Q", 3);
                        map.Add("J", 20);
                        map.Add("T", 10);
                        map.Add("9", 14);
                        map.Add("8", 0);
                        map.Add("7", 0);
                       return map;
                    } // End of Static

                    static Dictionary<string, int> MapNotDominant()
                {
                    var map = new Dictionary<string, int>();
                    map.Add("A", 11);
                    map.Add("K", 4);
                    map.Add("Q", 3);
                    map.Add("J", 2);
                    map.Add("T", 10);
                    map.Add("9", 0);
                    map.Add("8", 0);
                    map.Add("7", 0);
                    return map;
                }
                catch
                {
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                } // End of Catch
            } // End of WHILE
        } // End of Main

        private static object MapNotDominant()
        {
            throw new NotImplementedException();
        }

        private static object MapDominant()
        {
            throw new NotImplementedException();
        }
    } // End of class
} // End of namespace
