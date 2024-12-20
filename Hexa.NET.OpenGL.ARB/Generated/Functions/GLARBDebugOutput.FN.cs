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
	public unsafe partial class GLARBDebugOutput : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_debug_output";

		public GLARBDebugOutput() : base(4)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glDebugMessageCallbackARB");
			funcTable.Load(1, "glDebugMessageControlARB");
			funcTable.Load(2, "glDebugMessageInsertARB");
			funcTable.Load(3, "glGetDebugMessageLogARB");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
