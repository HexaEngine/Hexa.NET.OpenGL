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
	public unsafe partial class GLNVCommandList
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_NV_command_list";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 17);
			funcTable.Load(0, "glCallCommandListNV");
			funcTable.Load(1, "glCommandListSegmentsNV");
			funcTable.Load(2, "glCompileCommandListNV");
			funcTable.Load(3, "glCreateCommandListsNV");
			funcTable.Load(4, "glCreateStatesNV");
			funcTable.Load(5, "glDeleteCommandListsNV");
			funcTable.Load(6, "glDeleteStatesNV");
			funcTable.Load(7, "glDrawCommandsAddressNV");
			funcTable.Load(8, "glDrawCommandsNV");
			funcTable.Load(9, "glDrawCommandsStatesAddressNV");
			funcTable.Load(10, "glDrawCommandsStatesNV");
			funcTable.Load(11, "glGetCommandHeaderNV");
			funcTable.Load(12, "glGetStageIndexNV");
			funcTable.Load(13, "glIsCommandListNV");
			funcTable.Load(14, "glIsStateNV");
			funcTable.Load(15, "glListDrawCommandsStatesClientNV");
			funcTable.Load(16, "glStateCaptureNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
