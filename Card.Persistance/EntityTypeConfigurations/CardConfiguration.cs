using Cards.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cards.Persistance.EntityTypeConfigurations
{
    internal class CardConfiguration:IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder) 
        {
            builder.HasKey(card => card.Id);
            builder.HasIndex(card =>card.Id).IsUnique();
            builder.Property(card => card.Name).HasMaxLength(250);
        }
    }
}
