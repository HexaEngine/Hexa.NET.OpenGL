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

namespace Hexa.NET.OpenGLES.OES
{
	public unsafe partial class GLOESDrawBuffersIndexed : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_OES_draw_buffers_indexed";

		public GLOESDrawBuffersIndexed() : base(8)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glBlendEquationSeparateiOES");
			funcTable.Load(1, "glBlendEquationiOES");
			funcTable.Load(2, "glBlendFuncSeparateiOES");
			funcTable.Load(3, "glBlendFunciOES");
			funcTable.Load(4, "glColorMaskiOES");
			funcTable.Load(5, "glDisableiOES");
			funcTable.Load(6, "glEnableiOES");
			funcTable.Load(7, "glIsEnablediOES");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
