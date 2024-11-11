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
	public unsafe partial class GLEXTEGLImageStorage : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_EGL_image_storage";

		public GLEXTEGLImageStorage() : base(2)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glEGLImageTargetTexStorageEXT");
			funcTable.Load(1, "glEGLImageTargetTextureStorageEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
