using eComerce.Data.Base;
using eComerce.Models;

namespace eComerce.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>, IProducerService
    {
        public ProducerService(AppDbContext context) : base(context)
        {
        }
    }
}
