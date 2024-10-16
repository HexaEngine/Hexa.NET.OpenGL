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
	public unsafe partial class GLNVGpuProgram4
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_NV_gpu_program4";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 16);
			funcTable.Load(0, "glGetProgramEnvParameterIivNV");
			funcTable.Load(1, "glGetProgramEnvParameterIuivNV");
			funcTable.Load(2, "glGetProgramLocalParameterIivNV");
			funcTable.Load(3, "glGetProgramLocalParameterIuivNV");
			funcTable.Load(4, "glProgramEnvParameterI4iNV");
			funcTable.Load(5, "glProgramEnvParameterI4ivNV");
			funcTable.Load(6, "glProgramEnvParameterI4uiNV");
			funcTable.Load(7, "glProgramEnvParameterI4uivNV");
			funcTable.Load(8, "glProgramEnvParametersI4ivNV");
			funcTable.Load(9, "glProgramEnvParametersI4uivNV");
			funcTable.Load(10, "glProgramLocalParameterI4iNV");
			funcTable.Load(11, "glProgramLocalParameterI4ivNV");
			funcTable.Load(12, "glProgramLocalParameterI4uiNV");
			funcTable.Load(13, "glProgramLocalParameterI4uivNV");
			funcTable.Load(14, "glProgramLocalParametersI4ivNV");
			funcTable.Load(15, "glProgramLocalParametersI4uivNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
