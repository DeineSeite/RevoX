﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevoProjectX.Models
{
    public interface IDirty
    {
        bool IsDirty
        {
            get;
            set;
        }
    }
}
