using Lernkartei.Domain.Abstraction;
using Lernkartei.Domain.Entities;
using Lernkartei.InfraStructure.Concrete.Repository;
using Swish.InfraStructure.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernkartei.Infrastructure.Concrete
{
    public class CardHouseRepository : Repository<CardHouse>, ICardHouseRepository
    {
        private readonly LernkarteiContext _context;
        public CardHouseRepository(LernkarteiContext context) : base(context)
        {
            _context = context;
        }
    }
}
