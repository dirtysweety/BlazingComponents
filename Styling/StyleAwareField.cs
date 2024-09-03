namespace BlazingComponents.Styling
{
    /// <summary>
    /// An StyleAwareField object is simply a field in your code, with the difference that
    /// when the field is changed, it notifies a style object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StyleAwareField<T>
    {
        private T? _t;
        private readonly List<Style> _styles = new();

        public StyleAwareField(T? t, params Style[] styles)
        {
            _t = t;
            if (!styles.Any()) return;
            _styles.AddRange(styles);
        }

        public void Set(T? t)
        {
            _t = t;
            foreach (var s in _styles) s.OnStyleAwareFieldSet();
        }

        public T? Get() => _t;

        public static implicit operator T?(StyleAwareField<T> field) => field.Get();
    }
}
