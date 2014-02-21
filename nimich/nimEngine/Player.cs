using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nimEngine
{
    public abstract class Player
    {
        public abstract int Turn(int currentStickCount);
    }
}
