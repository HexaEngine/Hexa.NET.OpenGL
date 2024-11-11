namespace Hexa.NET.OpenGLES
{
    using HexaGen.Runtime;
    using System.Collections.Concurrent;

    public class GLBase
    {
        private static readonly ConcurrentDictionary<INativeContext, GLContext> contexts = [];

        [ThreadStatic]
        public static GLContext NativeContext = null!;

        public static event Action<GLContext?, GLContext?>? ContextChanged;

        public static void SetGLContext(GLContext? context)
        {
            var old = NativeContext;
            ContextChanged?.Invoke(old, context);
            NativeContext = context!;
        }

        public static GLContext GetGLContext(INativeContext nativeContext)
        {
            return contexts.GetOrAdd(nativeContext, c => new(c));
        }

        public static void DeleteGLContext(GLContext nativeContext)
        {
            if (contexts.TryRemove(nativeContext.Context, out var gl))
            {
                gl.Dispose();
            }
        }

        public static void DeleteGLContext(INativeContext nativeContext)
        {
            if (contexts.TryRemove(nativeContext, out var gl))
            {
                gl.Dispose();
            }
        }
    }
}