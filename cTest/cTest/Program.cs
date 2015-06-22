using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cTest
{
  class Program
  {
    private int T;

    static void Main(string[] args)
    {
      var obj = new Program();
      obj.T = 1;
      var list = new List<int>();
      list.AddRange(new int[] { 1, 2, 3 });

      var mainobj = new Program();
      mainobj.Test(list, obj);
      mainobj.Test2(ref list, ref obj);
    }

    private void Test(List<int> list, Program obj)
    {
      list = new List<int>();
      obj = new Program() { T = 2 };
    }

    private void Test2(ref List<int> list, ref Program obj)
    {
      list = new List<int>();
      obj = new Program() { T = 2 };
    }
  }
}
