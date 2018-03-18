﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybug
{
    class LadyBug
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            var ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).Where(i => i >= 0 && i < size).ToList();

            foreach(var index in ladybugIndexes)
            {
                field[index] = 1; 
            }

            while (true)
            {
                var line = Console.ReadLine();

                if (line.Equals("end"))
                {
                    break;
                }

                var commandParts = line.Split();

                var currentLadybugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLength = int.Parse(commandParts[2]);

                if (direction.Equals("left"))
                {
                    flyLength *= -1;
                }

                if (currentLadybugIndex < 0 || currentLadybugIndex >= size)
                {
                    continue;
                }

                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }

                field[currentLadybugIndex] = 0;

                var nextIndexToLand = currentLadybugIndex;

                while (true)
                {
                    nextIndexToLand += flyLength;

                    if(nextIndexToLand < 0 || nextIndexToLand >= size)
                    {
                        break;
                    }

                    if(field[nextIndexToLand] == 1)
                    {
                        continue;
                    }

                    field[nextIndexToLand] = 1;
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
