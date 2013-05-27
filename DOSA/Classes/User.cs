﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSA
{
    [Serializable]
    public class User
    {
        public string Name;
        public Server HomeServer; // TODO: create DOSA Server Object
        public int LocalID; // PK
    }
}