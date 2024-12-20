// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;
using Hexa.NET.OpenGL;

namespace Hexa.NET.OpenGL.ARB
{
	public unsafe partial class GLARBShaderSubroutine : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_shader_subroutine";

		public GLARBShaderSubroutine() : base(8)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glGetActiveSubroutineName");
			funcTable.Load(1, "glGetActiveSubroutineUniformName");
			funcTable.Load(2, "glGetActiveSubroutineUniformiv");
			funcTable.Load(3, "glGetProgramStageiv");
			funcTable.Load(4, "glGetSubroutineIndex");
			funcTable.Load(5, "glGetSubroutineUniformLocation");
			funcTable.Load(6, "glGetUniformSubroutineuiv");
			funcTable.Load(7, "glUniformSubroutinesuiv");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
