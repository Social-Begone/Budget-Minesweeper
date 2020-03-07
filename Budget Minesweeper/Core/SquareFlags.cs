using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    [Flags]
    public enum SquareFlags
    {
        Bomb     = 0x1,
        Flagged  = 0x2,
        Dug      = 0x4,
        Exploded = 0x8,
    }
}
