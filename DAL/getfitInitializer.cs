using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace getfitEF.DAL
{
    public class getfitInitializer : DropCreateDatabaseIfModelChanges<getfitContext>
    {
        protected override void Seed(getfitContext context)
        {

            context.SaveChanges();
        }
    }
}