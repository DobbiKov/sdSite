using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sdTelegramBot.Models
{
    public class Events
    {
        public long id { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string date { get; set; }
    }
}
