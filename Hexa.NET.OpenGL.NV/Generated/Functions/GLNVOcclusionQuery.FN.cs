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
	public unsafe partial class GLNVOcclusionQuery
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
			funcTable = new FunctionTable(GLBase.NativeContext, 7);
			funcTable.Load(0, "glBeginOcclusionQueryNV");
			funcTable.Load(1, "glDeleteOcclusionQueriesNV");
			funcTable.Load(2, "glEndOcclusionQueryNV");
			funcTable.Load(3, "glGenOcclusionQueriesNV");
			funcTable.Load(4, "glGetOcclusionQueryivNV");
			funcTable.Load(5, "glGetOcclusionQueryuivNV");
			funcTable.Load(6, "glIsOcclusionQueryNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
