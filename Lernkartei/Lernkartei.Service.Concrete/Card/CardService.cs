using Lernkartei.Domain.Abstraction;
using Lernkartei.Dto.Card;
using Lernkartei.Service.Abstract.Card;
using Lernkartei.Common.AutoMapper;

namespace Lernkartei.Service.Concrete.Card
{
    public class CardService : MainService<Domain.Entities.Card, CardDto>,ICardService
    {
        private readonly ICardRepository _cardRepository;
        public CardService(ICardRepository cardRepository):base(cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public CardDto Insert(CardDto model) 
        {
            try
            {
                Domain.Entities.Card? result = _cardRepository.Add(entity: model.MapTo<CardDto, Domain.Entities.Card>());
                return result.MapTo<Domain.Entities.Card, CardDto>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
