﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Cards.Application.Cards.Commands.UpdateCard
{
    public class UpdateCardCommand:IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
