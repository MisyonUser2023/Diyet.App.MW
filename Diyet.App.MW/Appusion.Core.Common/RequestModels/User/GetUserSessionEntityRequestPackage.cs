﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appusion.Core.Common.RequestModels.User
{
    public class GetUserSessionEntityRequestPackage
    {
        public long UserId { get; set; }

        public string JwtToken { get; set; }
    }
}
