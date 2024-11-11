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
	public unsafe partial class GLARBMatrixPalette : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_matrix_palette";

		public GLARBMatrixPalette() : base(5)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glCurrentPaletteMatrixARB");
			funcTable.Load(1, "glMatrixIndexPointerARB");
			funcTable.Load(2, "glMatrixIndexubvARB");
			funcTable.Load(3, "glMatrixIndexuivARB");
			funcTable.Load(4, "glMatrixIndexusvARB");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
