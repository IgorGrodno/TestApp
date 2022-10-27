using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Cards.Application.Cards.Commands.CreateCard
{
    public class CreateCardCommand:IRequest<Guid>
    {
        public string Name { get; set; }
        public Guid PictureId { get; set; }
    }
}
