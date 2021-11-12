using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculation.Controllers
{
    public class PostRequest
    {
        public string _operator { get; set; }

        public int left { get; set; }

        public int right { get; set; }
    }
}
