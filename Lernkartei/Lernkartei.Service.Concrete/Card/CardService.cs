using Lernkartei.Domain.Abstraction;
using Lernkartei.Dto.Card;
using Lernkartei.Service.Abstract.Card;
using Lernkartei.Common.AutoMapper;

namespace Lernkartei.Service.Concrete.Card
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public InsertDto Insert(InsertDto model) 
        {
            try
            {
                Domain.Entities.Card? result = _cardRepository.Add(entity: model.MapTo<InsertDto, Domain.Entities.Card>());
                return result.MapTo<Domain.Entities.Card, InsertDto>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
