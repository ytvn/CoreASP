using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreASP.Entity
{
    public class UserEntity : BaseEnity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public override int getId()
        {
            return this.UserId;
        }
        public override void setId(int id)
        {
            this.UserId = id;
        }
    }
}
