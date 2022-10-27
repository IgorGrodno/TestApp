using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cards.Domain;

namespace Cards.Application.Interfaces
{
    public interface ICardsDBContext
    {
        DbSet<Card> Cards { get; set; }
        Task<int> SaveChangesAsynk(CancellationToken cancellationToken);
    }
}
