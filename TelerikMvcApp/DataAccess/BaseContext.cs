using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace TelerikMvcApp.DataAccess
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        protected BaseContext()
            : base(nameOrConnectionString: "CardnoDB")
        {
           
        }
    }
}
