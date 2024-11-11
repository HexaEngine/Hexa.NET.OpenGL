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
	public unsafe partial class GLEXTBindableUniform : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_bindable_uniform";

		public GLEXTBindableUniform() : base(3)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glGetUniformBufferSizeEXT");
			funcTable.Load(1, "glGetUniformOffsetEXT");
			funcTable.Load(2, "glUniformBufferEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
