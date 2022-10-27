using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cards.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Queries.GetCardsList
{
    public class GetCardsListQueryHandler:IRequestHandler<GetCardsListQuery,CardsListVM>
    {
        private readonly ICardsDBContext _dbContext;
        private readonly IMapper _mapper;
        public GetCardsListQueryHandler(ICardsDBContext dBContext, IMapper mapper) => (_dbContext, _mapper) = (dBContext, mapper);

        public async Task<CardsListVM> Handle(GetCardsListQuery request,CancellationToken cancellationToken)
        {
            var noteQuery = await _dbContext.Cards.ProjectTo<CardsLookupDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

            return new CardsListVM {Cards=noteQuery};
        }
    }
}
