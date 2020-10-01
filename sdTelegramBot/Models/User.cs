using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sdTelegramBot.Models
{
    public class User
    {
        public long id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string forestName { get; set; }
        public string password { get; set; }
        public int siteRoleId { get; set; }
        public string jwtToken { get; set; }
        public string homeAdress { get; set; }
        public string school { get; set; }
        public string phoneNumber { get; set; }
        public string passport { get; set; }

        public string lastSignIn { get; set; }
        public string lastEvent { get; set; }
        public string telegramId { get; set; }
    }
}
