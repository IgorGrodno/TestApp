using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Queries.GetCardsList
{
    public class GetCardsListQuery : IRequest<CardsListVM>
    {
        public Guid? Id { get; set; }
    }
}
