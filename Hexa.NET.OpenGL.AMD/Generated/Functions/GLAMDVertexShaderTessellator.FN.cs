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

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDVertexShaderTessellator : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_AMD_vertex_shader_tessellator";

		public GLAMDVertexShaderTessellator() : base(2)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glTessellationFactorAMD");
			funcTable.Load(1, "glTessellationModeAMD");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
