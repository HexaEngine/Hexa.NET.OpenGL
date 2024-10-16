namespace Hexa.NET.OpenGL.AMD
{
    public unsafe delegate void GLDebugProcAMD(GLEnum source, GLEnum type, uint id, GLEnum severity, int length, byte* message, void* userParam);
}