namespace BlazingComponents.Components.EventArgs
{
    public class BlazingAutoCompleteItemSelectedEventArgs<T> : System.EventArgs
    {
        public T SelectedItem { get; set; }

        public BlazingAutoCompleteItemSelectedEventArgs(T selectedItem)
        {
            SelectedItem = selectedItem;
        }
    }
}
