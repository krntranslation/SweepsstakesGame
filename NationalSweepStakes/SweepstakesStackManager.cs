using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalSweepStakes.Stack
{
    public class SweepstakesStackManager : SweepstakesManager
    {
        public void PushToStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(001);
            stack.Push(002);
            stack.Push(003);
        }
    }
}
