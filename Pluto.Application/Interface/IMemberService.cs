using Pluto.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto.Application.Interface
{
    public interface IMemberService
    {
        Task<IEnumerable<MemberDto>> GetAll();
    }
}
