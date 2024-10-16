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
	public unsafe partial class GLNVShaderBufferLoad
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_NV_shader_buffer_load";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 14);
			funcTable.Load(0, "glGetBufferParameterui64vNV");
			funcTable.Load(1, "glGetIntegerui64vNV");
			funcTable.Load(2, "glGetNamedBufferParameterui64vNV");
			funcTable.Load(3, "glGetUniformui64vNV");
			funcTable.Load(4, "glIsBufferResidentNV");
			funcTable.Load(5, "glIsNamedBufferResidentNV");
			funcTable.Load(6, "glMakeBufferNonResidentNV");
			funcTable.Load(7, "glMakeBufferResidentNV");
			funcTable.Load(8, "glMakeNamedBufferNonResidentNV");
			funcTable.Load(9, "glMakeNamedBufferResidentNV");
			funcTable.Load(10, "glProgramUniformui64NV");
			funcTable.Load(11, "glProgramUniformui64vNV");
			funcTable.Load(12, "glUniformui64NV");
			funcTable.Load(13, "glUniformui64vNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
