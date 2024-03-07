using Microsoft.EntityFrameworkCore;
using Pluto.Application.Dtos;
using Pluto.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto.Application.Services
{
    public class MemberService : IMemberService
    {
        private IAppDbContext _context;

        public MemberService(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MemberDto>> GetAll()
        {
            var data =await _context.Members.ToListAsync();

            return data.Select(s=>new MemberDto { Id=s.Id, Name=s.Name})
                .AsEnumerable();
        }
    }
}
