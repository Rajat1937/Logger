﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Interfaces
{
    public interface IAppender
    {
        void Append(ILogable message);

        int Threshold { get; set; }
    }
}
