using Microsoft.AspNetCore.Mvc;
using AuctionProject.API.UseCases.Auctions.GetCurrent;
using AuctionProject.API.Entities;

namespace AuctionProject.API.Controllers
{
    public class AuctionController : AuctionProjectBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
        {
            var result = useCase.Execute();

            if (result is null)
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}