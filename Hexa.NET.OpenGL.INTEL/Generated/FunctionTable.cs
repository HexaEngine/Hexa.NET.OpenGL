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

namespace Hexa.NET.OpenGL.INTEL
{
	public unsafe partial class GLINTEL
	{
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, call before you access any function.
		/// </summary>
		public static void InitApi(INativeContext context)
		{
			funcTable = new FunctionTable(context, 18);
			funcTable.Load(0, "glApplyFramebufferAttachmentCMAAINTEL");
			funcTable.Load(1, "glBeginPerfQueryINTEL");
			funcTable.Load(2, "glColorPointervINTEL");
			funcTable.Load(3, "glCreatePerfQueryINTEL");
			funcTable.Load(4, "glDeletePerfQueryINTEL");
			funcTable.Load(5, "glEndPerfQueryINTEL");
			funcTable.Load(6, "glGetFirstPerfQueryIdINTEL");
			funcTable.Load(7, "glGetNextPerfQueryIdINTEL");
			funcTable.Load(8, "glGetPerfCounterInfoINTEL");
			funcTable.Load(9, "glGetPerfQueryDataINTEL");
			funcTable.Load(10, "glGetPerfQueryIdByNameINTEL");
			funcTable.Load(11, "glGetPerfQueryInfoINTEL");
			funcTable.Load(12, "glMapTexture2DINTEL");
			funcTable.Load(13, "glNormalPointervINTEL");
			funcTable.Load(14, "glSyncTextureINTEL");
			funcTable.Load(15, "glTexCoordPointervINTEL");
			funcTable.Load(16, "glUnmapTexture2DINTEL");
			funcTable.Load(17, "glVertexPointervINTEL");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}
