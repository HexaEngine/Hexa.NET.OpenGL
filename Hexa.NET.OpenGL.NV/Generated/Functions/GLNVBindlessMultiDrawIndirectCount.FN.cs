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

namespace Hexa.NET.OpenGL.NV
{
	public unsafe partial class GLNVBindlessMultiDrawIndirectCount : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_NV_bindless_multi_draw_indirect_count";

		public GLNVBindlessMultiDrawIndirectCount() : base(2)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glMultiDrawArraysIndirectBindlessCountNV");
			funcTable.Load(1, "glMultiDrawElementsIndirectBindlessCountNV");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
