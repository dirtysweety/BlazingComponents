namespace BlazingComponents.Components.Binding
{
    public enum BlazingSearchBoxEventSource
    {
        Input,
        TimedInput,
        Search
    }

    public class BlazingSearchBoxContext<T>
    {
        public string Text { get; set; }

        public BlazingSearchBoxEventSource EventSource { get; internal set; }

        public List<T> Matches { get; internal set; } = new();

        public bool ForceSearching { get; set; }

        public bool CancelCurrent { get; set; }

        public BlazingSearchBoxContext(string text, bool forceSearching, bool cancelCurrent)
        {
            Text = text;
            ForceSearching = forceSearching;
            CancelCurrent = cancelCurrent;
        }
    }
}
