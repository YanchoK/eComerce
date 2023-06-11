using eComerce.Data.Base;
using eComerce.Models;

namespace eComerce.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(AppDbContext context) : base(context)
        {
        }
    }
}
