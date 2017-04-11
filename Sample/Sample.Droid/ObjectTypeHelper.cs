using Java.IO;

namespace Sample.Droid
{
    public static class ObjectTypeHelper
    {
        public static T Cast<T>(this Java.Lang.Object obj) where T : class
        {
            var propertyInfo = obj.GetType().GetProperty("Instance");
            return propertyInfo == null ? null : propertyInfo.GetValue(obj, null) as T;
        }
    }

    public class JavaObjectWrapper<T> : Java.Lang.Object, ISerializable
    {
        public T Obj { get; set; }
    }
}