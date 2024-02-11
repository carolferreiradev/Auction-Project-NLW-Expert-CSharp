using AuctionProject.API.Contracts;
using AuctionProject.API.Entities;
using AuctionProject.API.Enums;
using AuctionProject.API.UseCases.Auctions.GetCurrent;
using Bogus;
using FluentAssertions;
using Moq;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCaseTest
    {
        [Fact]
        public void Success()
        {
             // AAA - ARRANGE ACT ASSERT
            var entity = new Faker<Auction>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(10, 700))
                .RuleFor(auction => auction.Name, f => f.Lorem.Word())
                .RuleFor(auction => auction.Starts, f => f.Date.Past())
                .RuleFor(auction => auction.Ends, f => f.Date.Future())
                .RuleFor(auction => auction.Items, (f, auction) => new List<Item>{
                    new Item{
                        Id = f.Random.Number(10, 700),
                        Name = f.Commerce.ProductName(),
                        Brand=f.Commerce.Department(),
                        BasePrice = f.Random.Decimal(50, 5000),
                        Condition= f.PickRandom<Condition>(),
                        AuctionId = auction.Id,
                    }
                }).Generate();

            var mock = new Mock<IAuctionRepository>();
            mock.Setup(inter => inter.GetCurrent()).Returns(entity);
           
            var useCase = new GetCurrentAuctionUseCase(mock.Object);

            //ACT
            var auction = useCase.Execute();

            // ASSERT
            auction.Should().NotBeNull();
            auction.Id.Should().Be(entity.Id);
            auction.Name.Should().Be(entity.Name);
        }
    }
}