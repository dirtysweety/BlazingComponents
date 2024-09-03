namespace BlazingComponents.Styling
{
    public class StyleString
    {
        private string _style = "";

        public string this[string name]
        {
            set => _style += name + ":" + value + ";";
        }

        public static implicit operator string(StyleString s) => s._style;
    }
}
