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
	public unsafe partial class GLARBViewportArray
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_ARB_viewport_array";

		/// <summary>
		/// Tries to initialize the function table of the extension, call before you access any function.
		/// </summary>
		/// <returns>Returns <c>true</c> if successful, <c>false</c> if extension is not supported.</returns>
		public static bool TryInitExtension()
		{
			if (!IsSupported) return false;
			InitExtension();
			return true;
		}

		/// <summary>
		/// Initializes the function table of the extension, call before you access any function.
		/// </summary>
		public static void InitExtension()
		{
			if (funcTable != null) return;
			if (GLBase.NativeContext == null) throw new InvalidOperationException("OpenGL is not initialized, call GL.InitApi.");
			funcTable = new FunctionTable(GLBase.NativeContext, 12);
			funcTable.Load(0, "glDepthRangeArraydvNV");
			funcTable.Load(1, "glDepthRangeArrayv");
			funcTable.Load(2, "glDepthRangeIndexed");
			funcTable.Load(3, "glDepthRangeIndexeddNV");
			funcTable.Load(4, "glGetDoublei_v");
			funcTable.Load(5, "glGetFloati_v");
			funcTable.Load(6, "glScissorArrayv");
			funcTable.Load(7, "glScissorIndexed");
			funcTable.Load(8, "glScissorIndexedv");
			funcTable.Load(9, "glViewportArrayv");
			funcTable.Load(10, "glViewportIndexedf");
			funcTable.Load(11, "glViewportIndexedfv");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
