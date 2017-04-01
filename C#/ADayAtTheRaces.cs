using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/98309/a-day-at-the-horse-races
  class ADayAtTheRaces
  {
    public string R(string f)
    {
      //Generate Race Lane
      var row = "_|";

      row += string.Join("", Enumerable.Repeat("_", 50));
      
      //Read all lines, get horse info
      var horses = System.IO.File.ReadAllLines(f).Select(h => new
      {
        Horse = h.Split(',')[0], Time = h.Split(',')[1],
        T = h.Split(',')[1].Contains("R") ? new DateTime() :
        new DateTime(2016, 11, 3, 0, int.Parse(h.Split(',')[1].Split('.')[0]), int.Parse(h.Split(',')[1].Split('.')[1]),  100 * int.Parse(h.Split(',')[1].Split('.')[2])),
        R = h.Split(',')[1].Contains("R")
      }).ToList();

      //Order by time order
      var timeOrder = horses.OrderBy(h => h.T);

      //Then order by original order again
      var horses2 = timeOrder.Select(h => new
      {
        Horse = h.Horse,
        Time = h.T,
        Order = h.R ? horses.Count : timeOrder.ToList().IndexOf(h) - 1,
        Retired = h.R
      }).OrderBy(o => o.Horse);

      var output = new List<string>();

      foreach (var horse in horses2.ToList())
      {
        //output = row.Substring()
        //Currently, eg 1
        string itemToAdd = horse.Horse;
        //Currently, eg 1_
        itemToAdd += "_";

        if (horse.Order == 0)
        {
          //Currently, eg 1_1
          itemToAdd += horse.Order + 1;
          itemToAdd += "(" + horse.Time.Minute + "." + horse.Time.Second + "." + horse.Time.Millisecond.ToString().TrimEnd('0') + ")";
          itemToAdd = itemToAdd.PadRight(50, '_');
          output.Add(itemToAdd);
        }
        else if (horse.Retired)
        {
          itemToAdd += "|";
          itemToAdd = itemToAdd.PadRight(50, '_');
          itemToAdd += "R";
          output.Add(itemToAdd);
        }
        else
        {
          var horse2 = horses2.Where(h => h.Order == 0).FirstOrDefault();

          if (horse2 == null)
          {
            continue;
          }

          var millisecondsDifference = (int)horse.Time.Subtract(horse2.Time).TotalMilliseconds / 100;

          itemToAdd += "|";
          itemToAdd = itemToAdd.PadRight(itemToAdd.Length + millisecondsDifference < 50 ? itemToAdd.Length + millisecondsDifference : 50, '_');
          itemToAdd += horse.Order + 1;
          itemToAdd += "(" + horse.Time.Minute + "." + horse.Time.Second + "." + horse.Time.Millisecond.ToString().TrimEnd('0') + ")";
          itemToAdd = itemToAdd.PadRight(50, '_');
          output.Add(itemToAdd);
        }
      }

      return string.Join("\r\n", output);
    }
  }
}