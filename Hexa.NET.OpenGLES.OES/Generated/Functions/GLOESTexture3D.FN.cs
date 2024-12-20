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
	public unsafe partial class GLOESTexture3D : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_OES_texture_3D";

		public GLOESTexture3D() : base(6)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glCompressedTexImage3DOES");
			funcTable.Load(1, "glCompressedTexSubImage3DOES");
			funcTable.Load(2, "glCopyTexSubImage3DOES");
			funcTable.Load(3, "glFramebufferTexture3DOES");
			funcTable.Load(4, "glTexImage3DOES");
			funcTable.Load(5, "glTexSubImage3DOES");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
