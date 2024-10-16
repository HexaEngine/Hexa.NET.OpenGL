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
	public unsafe partial class GLNVBindlessTexture
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_NV_bindless_texture";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 13);
			funcTable.Load(0, "glGetImageHandleNV");
			funcTable.Load(1, "glGetTextureHandleNV");
			funcTable.Load(2, "glGetTextureSamplerHandleNV");
			funcTable.Load(3, "glIsImageHandleResidentNV");
			funcTable.Load(4, "glIsTextureHandleResidentNV");
			funcTable.Load(5, "glMakeImageHandleNonResidentNV");
			funcTable.Load(6, "glMakeImageHandleResidentNV");
			funcTable.Load(7, "glMakeTextureHandleNonResidentNV");
			funcTable.Load(8, "glMakeTextureHandleResidentNV");
			funcTable.Load(9, "glProgramUniformHandleui64NV");
			funcTable.Load(10, "glProgramUniformHandleui64vNV");
			funcTable.Load(11, "glUniformHandleui64NV");
			funcTable.Load(12, "glUniformHandleui64vNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
