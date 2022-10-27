using AutoMapper;
using Cards.Application.Common.Mappings;
using Cards.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Queries.GetCardsList
{
    public class CardsLookupDTO:IMapWith<Card>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Card, CardsLookupDTO>()
                .ForMember(cardDTO => cardDTO.Id, opt => opt.MapFrom(card => card.Id))
                .ForMember(cardDTO => cardDTO.Name, opt => opt.MapFrom(card => card.Name));
        }
    }
}
