namespace BlazingComponents.Styling
{
    public class Style
    {
        private string _lastStr = "";
        private readonly StyleManager _manager;
        private readonly Func<string> _builder;
        private readonly Action<string> _setter;

        /// <summary>
        /// Creates a new style and automatically adds it to the manager.
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="setter"></param>
        /// <param name="builder"></param>
        internal Style(StyleManager manager, Action<string> setter, Func<string> builder)
        {
            _builder = builder;
            _setter = setter;
            _manager = manager;
        }


        private string Build()
        {
            return _builder.Invoke();
        }

        internal void OnStyleAwareFieldSet()
        {
            var current = Build();
            if (current == _lastStr)
            {
                return; // No actual change.
            }

            _lastStr = current;
            _setter(current);
            _manager.OnChange();
        }
        

        /// <summary>
        /// Used by the style manager to update style strings after a render.
        /// </summary>
        internal void Set()
        {
            var current = Build();
            _lastStr = current;
            _setter(current);
        }
    }
}
