using AutoMapper;
using Cards.Application.Cards.Commands.CreateCard;
using Cards.Application.Cards.Commands.DeleteCard;
using Cards.Application.Cards.Commands.UpdateCard;
using Cards.Application.Cards.Queries.GetCardDetails;
using Cards.Application.Cards.Queries.GetCardsList;
using Cards.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route ("api/[controller]")]
    public class CardController : BaseController
    {
        private readonly IMapper _mapper;
        public CardController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<CardsListVM>> Get()
        {
            var query = new GetCardsListQuery { };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CardsListVM>> GetDetails(Guid id)
        {
            var query = new GetCardDetailsQuery
            {
                Id = id
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCardDTO createCardDTO)
        {
            var command = _mapper.Map<CreateCardCommand>(createCardDTO);
            var cardId = await Mediator.Send(command);
            return Ok(cardId);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCardDTO updateCardDTO)
        {
            var command = _mapper.Map<UpdateCardCommand>(updateCardDTO);
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteCardCommand { Id=id};
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
