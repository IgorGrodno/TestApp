using Cards.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Cards.Application.Cards.Commands.DeleteCard
{
    public class DeleteCardCommandHandler:IRequestHandler<DeleteCardCommand>
    {
        private readonly ICardsDBContext _dbContext;

        public DeleteCardCommandHandler(ICardsDBContext dBContext) => _dbContext = dBContext;

        public async Task<Unit> Handle(DeleteCardCommand request,CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cards.FindAsync(new object[] { request.Id}, cancellationToken);
            _dbContext.Cards.Remove(entity);
            await _dbContext.SaveChangesAsynk(cancellationToken);
            return Unit.Value;
        }
    }
}
