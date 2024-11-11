namespace Hexa.NET.OpenGL
{
    public interface IGLContext : HexaGen.Runtime.INativeContext
    {
        nint Handle { get; }

        bool IsCurrent { get; }

        void MakeCurrent();

        void SwapBuffers();

        void SwapInterval(int interval);
    }
}