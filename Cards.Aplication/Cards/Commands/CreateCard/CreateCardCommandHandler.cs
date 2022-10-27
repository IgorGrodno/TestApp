using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Cards.Application.Interfaces;
using Cards.Domain;
using MediatR;

namespace Cards.Application.Cards.Commands.CreateCard
{
    public class CreateCardCommandHandler:IRequestHandler<CreateCardCommand,Guid>
    {
        private readonly ICardsDBContext _dbContext;

        public CreateCardCommandHandler(ICardsDBContext dBContext) => _dbContext = dBContext;
        public async Task<Guid> Handle(CreateCardCommand request, CancellationToken cancellationToken)
        {
            var card = new Card
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                PictureId = request.PictureId
            };

            await _dbContext.Cards.AddAsync(card,cancellationToken);
            await _dbContext.SaveChangesAsynk(cancellationToken);

        return card.Id;
        }
    }
}
