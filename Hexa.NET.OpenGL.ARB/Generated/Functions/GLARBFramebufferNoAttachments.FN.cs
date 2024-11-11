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
	public unsafe partial class GLARBFramebufferNoAttachments : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_framebuffer_no_attachments";

		public GLARBFramebufferNoAttachments() : base(2)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glFramebufferParameteri");
			funcTable.Load(1, "glGetFramebufferParameteriv");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
