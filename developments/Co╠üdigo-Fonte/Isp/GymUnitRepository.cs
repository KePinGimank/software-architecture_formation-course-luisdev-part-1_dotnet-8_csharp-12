using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.Isp
{
    public class GymUnitRepository : IReadOnlyRepository<GymUnit>
    {
        private readonly GymDbContext _context;
        
        // Talvez até utilizar um repositório genérico por composição aqui
        public GymUnitRepository(GymDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GymUnit> GetAll(Guid id)
        {
            return _context.Gyms;
        }

        public GymUnit GetById(Guid id)
        {
            return _context.Gyms.SingleOrDefault(g => g.Id == id);
        }
    }

    public class GymUnit {
        public GymUnit(Guid id, string name, string fullAddress, DateTime createdAt)
        {
            Id = id;
            Name = name;
            FullAddress = fullAddress;
            CreatedAt = createdAt;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string FullAddress { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }

    public class GymDbContext {
        public List<GymUnit> Gyms { get; set; }
    }
}