// See https://aka.ms/new-console-template for more information

using Hexa.NET.GLFW;
using Hexa.NET.OpenGL;
using HexaGen.Runtime;

GLFW.Init();
GLFW.WindowHint(GLFW.GLFW_CONTEXT_VERSION_MAJOR, 3);
GLFW.WindowHint(GLFW.GLFW_CONTEXT_VERSION_MINOR, 3);
GLFW.WindowHint(GLFW.GLFW_OPENGL_PROFILE, GLFW.GLFW_OPENGL_CORE_PROFILE);  // 3.2+ only

GLFWwindowPtr window = GLFW.CreateWindow(800, 600, "GL Triangle Example", null, null);
if (window.IsNull)
{
    Console.WriteLine("Failed to create GLFW window.");
    GLFW.Terminate();
    return;
}

GLFW.MakeContextCurrent(window);

GL.InitApi(new BindingsContext());

uint _vertexArrayObject;
uint _vertexBufferObject;
uint _shaderProgram;

Vertex[] _vertices =
[
    new Vertex(new(0.0f,0.5f,0.0f), new(0,0,1,1)),
    new Vertex(new(-0.5f,-0.5f,0.0f), new(0,1,0,1)),
    new Vertex(new(0.5f,-0.5f,0.0f), new(1,0,0,1))
];

GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);

// Generate and bind a Vertex Array Object (VAO)
_vertexArrayObject = GL.GenVertexArray();
GL.BindVertexArray(_vertexArrayObject);

// Generate and bind a Vertex Buffer Object (VBO)
_vertexBufferObject = GL.GenBuffer();
GL.BindBuffer(GLBufferTargetARB.ArrayBuffer, _vertexBufferObject);

GL.BufferData<Vertex>(GLBufferTargetARB.ArrayBuffer, _vertices.Length * Vertex.Size, _vertices, GLBufferUsageARB.StaticDraw);

// Link the vertex data with the shader attributes
GL.VertexAttribPointer(0, 3, GLVertexAttribPointerType.Float, false, Vertex.Size, 0);
GL.EnableVertexAttribArray(0);
GL.VertexAttribPointer(1, 4, GLVertexAttribPointerType.Float, false, Vertex.Size, 3 * sizeof(float));
GL.EnableVertexAttribArray(1);

// Compile shaders and link them into a program
_shaderProgram = CompileShaders();

while (GLFW.WindowShouldClose(window) == 0)
{
    GLFW.PollEvents();

    // Clear the color buffer
    GL.Clear(GLClearBufferMask.ColorBufferBit);

    // Use the shader program and bind the VAO
    GL.UseProgram(_shaderProgram);
    GL.BindVertexArray(_vertexArrayObject);

    // Draw the triangle
    GL.DrawArrays(GLPrimitiveType.Triangles, 0, 3);

    // Swap buffers
    GLFW.SwapBuffers(window);
}

GL.DeleteBuffer(_vertexBufferObject);
GL.DeleteVertexArray(_vertexArrayObject);
GL.DeleteProgram(_shaderProgram);

GLFW.DestroyWindow(window);

GLFW.Terminate();

uint CompileShaders()
{
    // Vertex shader
    const string VertexShaderSource = @"
        #version 330 core
        layout (location = 0) in vec3 aPosition;
        layout (location = 1) in vec4 aColor;

        out vec4 vertexColor;

        void main()
        {
            gl_Position = vec4(aPosition, 1.0);
            vertexColor = aColor;
        }";

    // Fragment shader
    const string FragmentShaderSource = @"
        #version 330 core
        in vec4 vertexColor;

        out vec4 FragColor;
        void main()
        {
            FragColor = vertexColor;
        }";

    // Compile vertex shader
    uint vertexShader = GL.CreateShader(GLShaderType.VertexShader);
    GL.ShaderSource(vertexShader, VertexShaderSource);
    GL.CompileShader(vertexShader);
    CheckShaderCompilation(vertexShader);

    // Compile fragment shader
    uint fragmentShader = GL.CreateShader(GLShaderType.FragmentShader);
    GL.ShaderSource(fragmentShader, FragmentShaderSource);
    GL.CompileShader(fragmentShader);
    CheckShaderCompilation(fragmentShader);

    // Link shaders into a shader program
    uint shaderProgram = GL.CreateProgram();
    GL.AttachShader(shaderProgram, vertexShader);
    GL.AttachShader(shaderProgram, fragmentShader);
    GL.LinkProgram(shaderProgram);
    CheckProgramLinking(shaderProgram);

    // Delete shaders as they're linked into the program now
    GL.DeleteShader(vertexShader);
    GL.DeleteShader(fragmentShader);

    return shaderProgram;
}
void CheckShaderCompilation(uint shader)
{
    GL.GetShaderiv(shader, GLShaderParameterName.CompileStatus, out int success);
    if (success == 0)
    {
        string infoLog = GL.GetShaderInfoLog(shader);
        throw new Exception($"Shader compilation error: {infoLog}");
    }
}

void CheckProgramLinking(uint program)
{
    GL.GetProgramiv(program, GLProgramPropertyARB.LinkStatus, out int success);
    if (success == 0)
    {
        string infoLog = GL.GetProgramInfoLog(program);
        throw new Exception($"Shader program linking error: {infoLog}");
    }
}

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