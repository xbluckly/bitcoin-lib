﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hashstream.bitcoin_lib.P2P
{
    public class GetData : Inv
    {
        public new string Command => "getdata";
    }
}
