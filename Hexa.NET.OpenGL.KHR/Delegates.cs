﻿namespace Hexa.NET.OpenGL.KHR
{
    public unsafe delegate void GLDebugProcKHR(GLEnum source, GLEnum type, uint id, GLEnum severity, int length, byte* message, void* userParam);
}