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
using Hexa.NET.OpenGLES;

namespace Hexa.NET.OpenGLES.EXT
{
	public unsafe partial class GLEXTTessellationShader : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_tessellation_shader";

		public GLEXTTessellationShader() : base(1)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glPatchParameteriEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
