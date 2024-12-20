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
	public unsafe partial class GLARBFramebufferObject : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_framebuffer_object";

		public GLARBFramebufferObject() : base(20)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glBindFramebuffer");
			funcTable.Load(1, "glBindRenderbuffer");
			funcTable.Load(2, "glBlitFramebuffer");
			funcTable.Load(3, "glCheckFramebufferStatus");
			funcTable.Load(4, "glDeleteFramebuffers");
			funcTable.Load(5, "glDeleteRenderbuffers");
			funcTable.Load(6, "glFramebufferRenderbuffer");
			funcTable.Load(7, "glFramebufferTexture1D");
			funcTable.Load(8, "glFramebufferTexture2D");
			funcTable.Load(9, "glFramebufferTexture3D");
			funcTable.Load(10, "glFramebufferTextureLayer");
			funcTable.Load(11, "glGenFramebuffers");
			funcTable.Load(12, "glGenRenderbuffers");
			funcTable.Load(13, "glGenerateMipmap");
			funcTable.Load(14, "glGetFramebufferAttachmentParameteriv");
			funcTable.Load(15, "glGetRenderbufferParameteriv");
			funcTable.Load(16, "glIsFramebuffer");
			funcTable.Load(17, "glIsRenderbuffer");
			funcTable.Load(18, "glRenderbufferStorage");
			funcTable.Load(19, "glRenderbufferStorageMultisample");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
