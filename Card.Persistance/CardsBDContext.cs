using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards.Application.Interfaces;
using Cards.Domain;
using Cards.Persistance.EntityTypeConfigurations;

namespace Cards.Persistance
{
    public class CardsBDContext:DbContext, ICardsDBContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardsBDContext(DbContextOptions<CardsBDContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CardConfiguration());
            base.OnModelCreating(builder);
        }

        public Task<int> SaveChangesAsynk(CancellationToken cancellationToken)
        {
           return base.SaveChangesAsync(cancellationToken);
        }
    }
}
