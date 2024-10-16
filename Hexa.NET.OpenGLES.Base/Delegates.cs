namespace Hexa.NET.OpenGLES
{
    public unsafe delegate void GLDebugProc(GLEnum source, GLEnum type, uint id, GLEnum severity, int length, byte* message, void* userParam);
}