using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Queries.GetCardDetails
{
    public class GetCardDetailsQuery:IRequest<CardDetailsVM>
    {
        public Guid Id { get; set; }
    }
}
