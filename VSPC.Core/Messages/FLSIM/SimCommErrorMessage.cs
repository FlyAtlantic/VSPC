﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSPC.Core.Messages.FLSIM
{
    public class SimCommErrorMessage: AMessage
    {
        public string ErrorMessage { get; set; }
    }
}
