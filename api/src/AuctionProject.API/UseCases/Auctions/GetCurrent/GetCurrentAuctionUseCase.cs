using AuctionProject.API.Contracts;
using AuctionProject.API.Entities;

namespace AuctionProject.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;
        
        public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;
        public Auction? Execute() => _repository.GetCurrent();
    }
}