namespace SequenceGameServer
{
    public interface IDeck
    {
        void Shuffle();
        void AddCard(ICard card);
        ICard Draw();
        int CardsRemaining { get; }
    }
}