namespace RootBeerFresh
{
    public class RootItemResult
    {
        public string Text { get; private set; }
        public bool IsSuspicious { get; private set; }
        public RootItemResult(string text, bool isSuspicious)
        {
            Text = text;
            IsSuspicious = isSuspicious;
        }
    }
}
