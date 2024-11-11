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

namespace Hexa.NET.OpenGL.EXT
{
	public unsafe partial class GLEXTTextureObject : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_texture_object";

		public GLEXTTextureObject() : base(6)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glAreTexturesResidentEXT");
			funcTable.Load(1, "glBindTextureEXT");
			funcTable.Load(2, "glDeleteTexturesEXT");
			funcTable.Load(3, "glGenTexturesEXT");
			funcTable.Load(4, "glIsTextureEXT");
			funcTable.Load(5, "glPrioritizeTexturesEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
