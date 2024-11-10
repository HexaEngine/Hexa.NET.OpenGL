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
	public unsafe partial class GLEXTSemaphore
	{
		[ThreadStatic]
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_EXT_semaphore";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 9);
			funcTable.Load(0, "glDeleteSemaphoresEXT");
			funcTable.Load(1, "glGenSemaphoresEXT");
			funcTable.Load(2, "glGetSemaphoreParameterui64vEXT");
			funcTable.Load(3, "glGetUnsignedBytevEXT");
			funcTable.Load(4, "glGetUnsignedBytei_vEXT");
			funcTable.Load(5, "glIsSemaphoreEXT");
			funcTable.Load(6, "glSemaphoreParameterui64vEXT");
			funcTable.Load(7, "glSignalSemaphoreEXT");
			funcTable.Load(8, "glWaitSemaphoreEXT");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
