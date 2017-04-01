using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/94832/yes-of-course-im-an-adult
  class YesOfCourseImAnAdult
  {
    public string y(string p){int a;return int.TryParse(p,out a)?a>17?p:"18":double.Parse(p)<1.4?"1.4":p;}
  }
}
