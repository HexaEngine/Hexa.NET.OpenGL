﻿// See https://aka.ms/new-console-template for more information
using Hexa.NET.GLFW;
using Hexa.NET.ImGui;
using Hexa.NET.ImGui.Backends.GLFW;
using Hexa.NET.ImGui.Backends.OpenGL3;
using Hexa.NET.OpenGL;
using HexaGen.Runtime;
using System.Runtime.CompilerServices;
using GLFWwindowPtr = Hexa.NET.GLFW.GLFWwindowPtr;

GLFW.Init();

string glslVersion = "#version 150";
GLFW.WindowHint(GLFW.GLFW_CONTEXT_VERSION_MAJOR, 3);
GLFW.WindowHint(GLFW.GLFW_CONTEXT_VERSION_MINOR, 2);
GLFW.WindowHint(GLFW.GLFW_OPENGL_PROFILE, GLFW.GLFW_OPENGL_CORE_PROFILE);  // 3.2+ only

GLFW.WindowHint(GLFW.GLFW_FOCUSED, 1);    // Make window focused on start
GLFW.WindowHint(GLFW.GLFW_RESIZABLE, 1);  // Make window resizable

GLFWwindowPtr window = GLFW.CreateWindow(800, 600, "GLFW Example", null, null);
if (window.IsNull)
{
    Console.WriteLine("Failed to create GLFW window.");
    GLFW.Terminate();
    return;
}

GLFW.MakeContextCurrent(window);

var guiContext = ImGui.CreateContext();
ImGui.SetCurrentContext(guiContext);

// Setup ImGui config.
var io = ImGui.GetIO();
io.ConfigFlags |= ImGuiConfigFlags.NavEnableKeyboard;     // Enable Keyboard Controls
io.ConfigFlags |= ImGuiConfigFlags.NavEnableGamepad;      // Enable Gamepad Controls
io.ConfigFlags |= ImGuiConfigFlags.DockingEnable;         // Enable Docking
io.ConfigFlags |= ImGuiConfigFlags.ViewportsEnable;       // Enable Multi-Viewport / Platform Windows
io.ConfigViewportsNoAutoMerge = false;
io.ConfigViewportsNoTaskBarIcon = false;

ImGuiImplGLFW.SetCurrentContext(guiContext);

if (!ImGuiImplGLFW.InitForOpenGL(Unsafe.BitCast<GLFWwindowPtr, Hexa.NET.ImGui.Backends.GLFW.GLFWwindowPtr>(window), true))
{
    Console.WriteLine("Failed to init ImGui Impl GLFW");
    GLFW.Terminate();
    return;
}

ImGuiImplOpenGL3.SetCurrentContext(guiContext);
if (!ImGuiImplOpenGL3.Init(glslVersion))
{
    Console.WriteLine("Failed to init ImGui Impl OpenGL3");
    GLFW.Terminate();
    return;
}

GL.InitApi(new BindingsContext());

// Main loop
while (GLFW.WindowShouldClose(window) == 0)
{
    // Poll for and process events
    GLFW.PollEvents();

    if (GLFW.GetKey(window, (int)GlfwKey.Escape) == GLFW.GLFW_PRESS)
    {
        GLFW.SetWindowShouldClose(window, 1); // Request to close the window
    }

    GLFW.MakeContextCurrent(window);
    GL.ClearColor(1, 0.8f, 0.75f, 1);
    GL.Clear(GLClearBufferMask.ColorBufferBit);

    ImGuiImplOpenGL3.NewFrame();
    ImGuiImplGLFW.NewFrame();
    ImGui.NewFrame();

    ImGui.ShowDemoWindow();

    ImGui.Render();
    ImGui.EndFrame();

    GLFW.MakeContextCurrent(window);
    ImGuiImplOpenGL3.RenderDrawData(ImGui.GetDrawData());

    if ((io.ConfigFlags & ImGuiConfigFlags.ViewportsEnable) != 0)
    {
        ImGui.UpdatePlatformWindows();
        ImGui.RenderPlatformWindowsDefault();
    }

    GLFW.MakeContextCurrent(window);

    // Swap front and back buffers (double buffering)
    GLFW.SwapBuffers(window);
}

// Clean up and terminate GLFW
GLFW.DestroyWindow(window);
GLFW.Terminate();

internal unsafe class BindingsContext : INativeContext
{
    public void Dispose()
    {
    }

    public nint GetProcAddress(string procName)
    {
        return (nint)GLFW.GetProcAddress(procName);
    }

    public bool IsExtensionSupported(string extensionName)
    {
        return GLFW.ExtensionSupported(extensionName) != 0;
    }

    public bool TryGetProcAddress(string procName, out nint procAddress)
    {
        procAddress = GetProcAddress(procName);
        return procAddress != 0;
    }
}