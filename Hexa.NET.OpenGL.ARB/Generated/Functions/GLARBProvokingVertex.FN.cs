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
	public unsafe partial class GLARBProvokingVertex : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_provoking_vertex";

		public GLARBProvokingVertex() : base(1)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glProvokingVertex");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
