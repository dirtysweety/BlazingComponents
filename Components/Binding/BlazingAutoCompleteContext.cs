namespace BlazingComponents.Components.Binding
{
    public class BlazingAutoCompleteContext<T>
    {
        public string Text { get; set; }
        public bool WasSelection { get; internal set; }
        public T? SelectedItem { get; internal set; }

        public BlazingAutoCompleteContext(string text)
        {
            Text = text;
        }

        internal BlazingAutoCompleteContext(string text, bool wasSelection, T selectedItem)
        {
            Text = text;
            WasSelection = wasSelection;
            SelectedItem = selectedItem;
        }
    }
}
