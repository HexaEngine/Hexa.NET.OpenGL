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

namespace Hexa.NET.OpenGLES.AMD
{
	public unsafe partial class GLAMDFramebufferMultisampleAdvanced : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_AMD_framebuffer_multisample_advanced";

		public GLAMDFramebufferMultisampleAdvanced() : base(2)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glNamedRenderbufferStorageMultisampleAdvancedAMD");
			funcTable.Load(1, "glRenderbufferStorageMultisampleAdvancedAMD");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
