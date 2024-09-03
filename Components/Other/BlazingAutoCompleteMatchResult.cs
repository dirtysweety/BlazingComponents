namespace BlazingComponents.Components.Other
{
    public class BlazingAutoCompleteMatchResult<T>
    {
        public string Left { get; set; }
        public string Center { get; set; }
        public string Right { get; set; }

        public T Item { get; set; }

        public BlazingAutoCompleteMatchResult(string left, string center, string right, T item)
        {
            Left = left;
            Center = center;
            Right = right;
            Item = item;
        }
    }
}
