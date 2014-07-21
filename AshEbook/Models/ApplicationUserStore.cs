using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AshEbook.Models
{
    public class ApplicationUserStore<TUser> : UserStore<TUser> where TUser : ApplicationUser
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserStore(ApplicationDbContext context)
            : base((DbContext)context)
        {
            _context = context;
        }
    }
}