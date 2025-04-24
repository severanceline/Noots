using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noots
{
    public  class UserInfo
    {
        public Guid userId { get; set; }
        public string UserName { get; set; }
        public string Firstname { get; set; }   
        public string Lastname { get; set; }    
        public string Email {  get; set; }  
        public string Password { get; set; }
        public DateTime Dateofbirth { get; set; }
        public DateTime Dateofsignup { get; set; }
    }
}
