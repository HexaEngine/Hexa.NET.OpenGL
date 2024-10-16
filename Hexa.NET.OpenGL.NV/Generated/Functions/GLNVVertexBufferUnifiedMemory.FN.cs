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
	public unsafe partial class GLNVVertexBufferUnifiedMemory
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		/// <summary>
		/// Initializes the function table of the extension, call before you access any function.
		/// </summary>
		public static void InitExtension()
		{
			if (funcTable != null) return;
			if (GLBase.NativeContext == null) throw new InvalidOperationException("OpenGL is not initialized, call GL.InitApi.");
			funcTable = new FunctionTable(GLBase.NativeContext, 12);
			funcTable.Load(0, "glBufferAddressRangeNV");
			funcTable.Load(1, "glColorFormatNV");
			funcTable.Load(2, "glEdgeFlagFormatNV");
			funcTable.Load(3, "glFogCoordFormatNV");
			funcTable.Load(4, "glGetIntegerui64i_vNV");
			funcTable.Load(5, "glIndexFormatNV");
			funcTable.Load(6, "glNormalFormatNV");
			funcTable.Load(7, "glSecondaryColorFormatNV");
			funcTable.Load(8, "glTexCoordFormatNV");
			funcTable.Load(9, "glVertexAttribFormatNV");
			funcTable.Load(10, "glVertexAttribIFormatNV");
			funcTable.Load(11, "glVertexFormatNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
