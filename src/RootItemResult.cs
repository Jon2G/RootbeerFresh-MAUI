
namespace RootBeerFresh
{
    [Microsoft.Maui.Controls.Internals.Preserve(AllMembers = true)]
    public class RootItemResult
    {
        public string Text { get; set; }
        public bool IsSuspicious { get; set; }
        public RootItemResult(string text, bool isSuspicious)
        {
            Text = text;
            IsSuspicious = isSuspicious;
        }
    }
}
