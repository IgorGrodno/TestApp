using AutoMapper;
using Cards.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Queries.GetCardDetails
{
    public class GetPictureDetailsQueryHandler:IRequestHandler<GetCardDetailsQuery, CardDetailsVM>
    {
        private readonly ICardsDBContext _dbContext;
        private readonly IMapper _mapper;
        public GetPictureDetailsQueryHandler(ICardsDBContext dBContext, IMapper mapper) =>( _dbContext,_mapper) = (dBContext,mapper);
        public async Task<CardDetailsVM> Handle(GetCardDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cards.FirstOrDefaultAsync(card => card.Id == request.Id,cancellationToken);
            return _mapper.Map<CardDetailsVM>(entity);
        }
    }
}
