﻿using System;

namespace Zalgo
{
    [Flags]
    public enum FuckUpPosition
    {
        Up = 1,
        Middle = 2,
        Bot = 4,

        UpAndMiddle = 3,
        UpAndBot = 5,
        MiddleAndBot = 6,

        All = 7
    }
}
