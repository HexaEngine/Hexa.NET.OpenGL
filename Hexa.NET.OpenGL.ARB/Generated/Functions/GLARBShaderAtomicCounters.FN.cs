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
	public unsafe partial class GLARBShaderAtomicCounters : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_shader_atomic_counters";

		public GLARBShaderAtomicCounters() : base(1)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glGetActiveAtomicCounterBufferiv");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
