using System;
using System.Collections.Generic;
using System.Linq;

public class DirReduction
{

    public static string[] dirReduc(String[] arr)
    {
        // {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"}
        var opposites = new Dictionary<string, string>();
        opposites.Add("NORTH", "SOUTH");
        opposites.Add("SOUTH", "NORTH");
        opposites.Add("EAST", "WEST");
        opposites.Add("WEST", "EAST");
        var list = arr.ToList();

        for (int index = 0; index < list.Count; index++)
        {
            if (index + 1 >= list.Count)
            {
                break;
            }
            var current = list[index];
            var opp = opposites[list[index]];
            var next = list[index + 1];


            if (opp == next)
            {
                list.Remove(list[index]);
                list.Remove(list[index]);
                index -= 1;
            }
            else
            {
                if (index - 1 >= 0)
                {
                    var prev = list[index - 1];
                    if (opp == prev)
                    {
                        list.Remove(list[index - 1]);
                        list.Remove(list[index - 1]);
                        index -= 1;
                    }
                }
            }
        }
        return list.ToArray();
    }
}