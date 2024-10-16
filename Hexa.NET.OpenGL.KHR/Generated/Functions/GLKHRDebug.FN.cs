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

namespace Hexa.NET.OpenGL.KHR
{
	public unsafe partial class GLKHRDebug
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_KHR_debug";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 22);
			funcTable.Load(0, "glDebugMessageCallback");
			funcTable.Load(1, "glDebugMessageCallbackKHR");
			funcTable.Load(2, "glDebugMessageControl");
			funcTable.Load(3, "glDebugMessageControlKHR");
			funcTable.Load(4, "glDebugMessageInsert");
			funcTable.Load(5, "glDebugMessageInsertKHR");
			funcTable.Load(6, "glGetDebugMessageLog");
			funcTable.Load(7, "glGetDebugMessageLogKHR");
			funcTable.Load(8, "glGetObjectLabel");
			funcTable.Load(9, "glGetObjectLabelKHR");
			funcTable.Load(10, "glGetObjectPtrLabel");
			funcTable.Load(11, "glGetObjectPtrLabelKHR");
			funcTable.Load(12, "glGetPointerv");
			funcTable.Load(13, "glGetPointervKHR");
			funcTable.Load(14, "glObjectLabel");
			funcTable.Load(15, "glObjectLabelKHR");
			funcTable.Load(16, "glObjectPtrLabel");
			funcTable.Load(17, "glObjectPtrLabelKHR");
			funcTable.Load(18, "glPopDebugGroup");
			funcTable.Load(19, "glPopDebugGroupKHR");
			funcTable.Load(20, "glPushDebugGroup");
			funcTable.Load(21, "glPushDebugGroupKHR");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
