using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Cards.Application.Cards.Commands.DeleteCard
{
    public class DeleteCardCommand:IRequest
    {
        public Guid Id { get; set; }
    }
}
