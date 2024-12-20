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

namespace Hexa.NET.OpenGLES.ANDROID
{
	public unsafe partial class GLEXTDrawBuffersIndexed : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_draw_buffers_indexed";

		public GLEXTDrawBuffersIndexed() : base(8)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glBlendEquationSeparateiEXT");
			funcTable.Load(1, "glBlendEquationiEXT");
			funcTable.Load(2, "glBlendFuncSeparateiEXT");
			funcTable.Load(3, "glBlendFunciEXT");
			funcTable.Load(4, "glColorMaskiEXT");
			funcTable.Load(5, "glDisableiEXT");
			funcTable.Load(6, "glEnableiEXT");
			funcTable.Load(7, "glIsEnablediEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
