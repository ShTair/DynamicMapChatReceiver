using Jint.Native.Object;

namespace DynamicMapChatReceiver
{
    static class JintExtensions
    {
        public static dynamic GetObject(this ObjectInstance obj, string propertyName)
        {
            return obj.GetProperty(propertyName).Value.ToObject();
        }
    }
}
