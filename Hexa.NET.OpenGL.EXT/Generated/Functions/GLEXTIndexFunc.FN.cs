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
	public unsafe partial class GLEXTIndexFunc : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_index_func";

		public GLEXTIndexFunc() : base(1)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glIndexFuncEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
