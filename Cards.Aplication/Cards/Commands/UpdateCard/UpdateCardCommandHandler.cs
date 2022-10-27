using Cards.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Commands.UpdateCard
{
    public class UpdateCardCommandHandler:IRequestHandler<UpdateCardCommand>
    {
        private readonly ICardsDBContext _dbContext;

        public UpdateCardCommandHandler(ICardsDBContext dBContext) => _dbContext = dBContext;

        public async Task<Unit> Handle(UpdateCardCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cards.FirstOrDefaultAsync(card => card.Id == request.Id, cancellationToken);

            entity.Name = request.Name;

            await _dbContext.SaveChangesAsynk(cancellationToken);

            return Unit.Value;
        }
    }
}
