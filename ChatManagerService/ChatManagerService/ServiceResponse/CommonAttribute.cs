using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatManagerService.ServiceResponse
{
    public abstract class CommonAttribute
    {
        public object Message { get; set; }
        public object Response { get; set; }
    }
}