namespace BlazingComponents.Styling
{
    /// <summary>
    /// The StylesManager should be scoped to the component it is being used in.
    /// </summary>
    public class StyleManager
    {
        private readonly List<Style> _styles = new();
        private bool _anyChange;
        

        /// <summary>
        /// Notifies the style manager that a style has changed.
        /// </summary>
        public void OnChange()
        {
            _anyChange = true;
        }

        /// <summary>
        /// Must run inside the OnParametersSet lifecycle method. It automatically builds the styles when needed.
        /// </summary>
        public void OnParametersSet()
        {
            if (_anyChange)
            {
                _anyChange = false;
                //The re-render is caused by changes in some styles. The styles have already run their setters. Nothing to do here.
            }
            else
            {
                //The re-render is caused by the parent component. Lets rebuild all the styles.
                foreach (var style in _styles)
                {
                    style.Set();
                }
            }
        }

        public Style CreateStyle(Action<string> setter, Func<string> builder)
        {
            Style s = new Style(this, setter, builder);
            _styles.Add(s);
            return s;
        }
    }
}
