using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noots
{
    public static class Session
    {
        public static UserInfo CurrentUser { get; set; } = new UserInfo();
    }
}
