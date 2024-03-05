using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto.Domain.Entity
{
    public class Member : BaseEntity
    {
        public string? Name {  get; set; }
        public string? PasswordSalt { get; set; }
        public string? PasswordHash { get; set; }
        public string? Email { get; set; }
    }
}
