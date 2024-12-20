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
	public unsafe partial class GLOESDrawTexture : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_OES_draw_texture";

		public GLOESDrawTexture() : base(8)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glDrawTexfOES");
			funcTable.Load(1, "glDrawTexfvOES");
			funcTable.Load(2, "glDrawTexiOES");
			funcTable.Load(3, "glDrawTexivOES");
			funcTable.Load(4, "glDrawTexsOES");
			funcTable.Load(5, "glDrawTexsvOES");
			funcTable.Load(6, "glDrawTexxOES");
			funcTable.Load(7, "glDrawTexxvOES");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
