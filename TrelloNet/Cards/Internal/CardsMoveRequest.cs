using RestSharp;

namespace TrelloNet.Internal
{
	internal class CardsMoveRequest : CardRequest
	{
		public CardsMoveRequest(ICardId card, IListId list)
			: base(card, "idList", Method.PUT)
		{
			this.AddValue(list.GetListId());
		}
	}
}