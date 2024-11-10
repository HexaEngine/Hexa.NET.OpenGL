namespace Hexa.NET.OpenGL
{
    using HexaGen.Runtime;

    public class GLBase
    {
        [ThreadStatic]
        public static INativeContext NativeContext = null!;
    }
}