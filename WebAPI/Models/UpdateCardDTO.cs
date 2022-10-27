using AutoMapper;
using Cards.Application.Cards.Commands.CreateCard;
using Cards.Application.Cards.Commands.UpdateCard;
using Cards.Application.Common.Mappings;

namespace WebAPI.Models
{
    public class UpdateCardDTO : IMapWith<UpdateCardCommand>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateCardDTO, UpdateCardCommand>()
                .ForMember(cardCommand => cardCommand.Name, opt => opt.MapFrom(cardDTO => cardDTO.Name))
                .ForMember(cardCommand => cardCommand.Id, opt => opt.MapFrom(cardDTO => cardDTO.Id));
        }
    }
}
