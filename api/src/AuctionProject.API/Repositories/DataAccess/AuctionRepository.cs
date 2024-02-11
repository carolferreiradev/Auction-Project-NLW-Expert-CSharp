using AuctionProject.API.Contracts;
using AuctionProject.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionProject.API.Repositories.DataAccess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AuctionProjectDbContext _dbContext;
        public AuctionRepository(AuctionProjectDbContext dbContext) => _dbContext = dbContext;

        public Auction? GetCurrent()
        {
            var today = DateTime.Now;

            return _dbContext
               .Auctions
               .Include(auction => auction.Items)
               .First();
            // .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Starts );
        }
    }
}