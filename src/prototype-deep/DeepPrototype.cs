using System.Text.Json;

namespace prototype_deep
{
    public class DeepPrototype<T> : ICloneable where T : class
    {
        private T DeepClone()
        {
            if (this is T source)
            {
                var json = JsonSerializer.Serialize(source);

                return JsonSerializer.Deserialize<T>(json);
            }

            throw new NotSupportedException();
        }

        public object Clone() =>
             DeepClone();
    }
}
