﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Practica_8
{
  public  interface ISQLAzure
    {
        Task<bool> Authenticate();
    }
}
