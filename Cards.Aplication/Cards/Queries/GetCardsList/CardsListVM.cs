using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Queries.GetCardsList
{
    public  class CardsListVM
    {
        public IList<CardsLookupDTO> Cards { get; set; }
    }
}
