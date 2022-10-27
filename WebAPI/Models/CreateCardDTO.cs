using AutoMapper;
using Cards.Application.Cards.Commands.CreateCard;
using Cards.Application.Common.Mappings;

namespace WebAPI.Models
{
    public class CreateCardDTO: IMapWith<CreateCardCommand>
    {
        public string Name { get; set; }
        public Guid PictureId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateCardDTO, CreateCardCommand>()
                .ForMember(cardCommand => cardCommand.Name, opt => opt.MapFrom(cardDTO => cardDTO.Name))
                .ForMember(cardCommand => cardCommand.PictureId, opt => opt.MapFrom(cardDTO => cardDTO.PictureId));
        }
    }
}
