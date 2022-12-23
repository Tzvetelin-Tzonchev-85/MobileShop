namespace MobileShop.Infrastructure.Data.Repositories
{
    using MobileShop.Infrastructure.Data.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ApplicationDbRepository : Repository, IApplicationDbRepository
    {
        public ApplicationDbRepository(MobileShopDbContext context)
        {
            this.Context = context;
        }
    }
}
