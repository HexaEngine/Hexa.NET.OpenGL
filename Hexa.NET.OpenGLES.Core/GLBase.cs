namespace Hexa.NET.OpenGLES
{
    using HexaGen.Runtime;

    public class GLBase
    {
        [ThreadStatic]
        public static INativeContext NativeContext = null!;
    }
}