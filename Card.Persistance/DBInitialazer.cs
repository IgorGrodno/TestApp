using Cards.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Persistance
{
    public class DBInitialazer
    {
        public static void Initialize(CardsBDContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
