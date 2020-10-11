using BackEnd.Domain.IRepositories;
using BackEnd.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Persistence.Repositories
{
    public class RespuestaCuestionarioRepository: IRespuestaCuestionarioRepository
    {
        private readonly AplicationDbContext _context;
        public RespuestaCuestionarioRepository(AplicationDbContext context)
        {
            _context = context;
        }
    }
}
