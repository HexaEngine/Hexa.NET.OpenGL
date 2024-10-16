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
using Hexa.NET.OpenGLES;

namespace Hexa.NET.OpenGLES.KHR
{
	public unsafe partial class GLKHRRobustness
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_KHR_robustness";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 10);
			funcTable.Load(0, "glGetGraphicsResetStatus");
			funcTable.Load(1, "glGetGraphicsResetStatusKHR");
			funcTable.Load(2, "glGetnUniformfv");
			funcTable.Load(3, "glGetnUniformfvKHR");
			funcTable.Load(4, "glGetnUniformiv");
			funcTable.Load(5, "glGetnUniformivKHR");
			funcTable.Load(6, "glGetnUniformuiv");
			funcTable.Load(7, "glGetnUniformuivKHR");
			funcTable.Load(8, "glReadnPixels");
			funcTable.Load(9, "glReadnPixelsKHR");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
