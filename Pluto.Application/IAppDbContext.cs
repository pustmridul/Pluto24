using Microsoft.EntityFrameworkCore;
using Pluto.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto.Application
{
    public interface IAppDbContext
    {
        DbSet<Member> Members { get; }
    }
}
