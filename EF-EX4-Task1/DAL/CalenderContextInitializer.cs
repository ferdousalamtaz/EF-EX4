using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EF_EX4_Task1.DAL
{
    class CalenderContextInitializer: DropCreateDatabaseAlways<CalenderContext>
    {
        protected override void Seed(CalenderContext context)
        {
            base.Seed(context);
        }
    }
}
