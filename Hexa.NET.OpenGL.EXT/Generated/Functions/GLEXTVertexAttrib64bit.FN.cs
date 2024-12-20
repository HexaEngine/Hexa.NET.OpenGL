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
	public unsafe partial class GLEXTVertexAttrib64bit : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_vertex_attrib_64bit";

		public GLEXTVertexAttrib64bit() : base(10)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glGetVertexAttribLdvEXT");
			funcTable.Load(1, "glVertexAttribL1dEXT");
			funcTable.Load(2, "glVertexAttribL1dvEXT");
			funcTable.Load(3, "glVertexAttribL2dEXT");
			funcTable.Load(4, "glVertexAttribL2dvEXT");
			funcTable.Load(5, "glVertexAttribL3dEXT");
			funcTable.Load(6, "glVertexAttribL3dvEXT");
			funcTable.Load(7, "glVertexAttribL4dEXT");
			funcTable.Load(8, "glVertexAttribL4dvEXT");
			funcTable.Load(9, "glVertexAttribLPointerEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
