using AutoMapper;
using Cards.Application.Common.Mappings;
using Cards.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Application.Cards.Queries.GetCardDetails
{
    public class CardDetailsVM:IMapWith<Card>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid PictureId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Card, CardDetailsVM>()
                .ForMember(cardVM => cardVM.Id, opt => opt.MapFrom(card => card.Id))
                .ForMember(cardVM => cardVM.Name, opt => opt.MapFrom(card => card.Name))
                .ForMember(cardVM => cardVM.PictureId, opt => opt.MapFrom(card => card.PictureId));
        }
    }
}
