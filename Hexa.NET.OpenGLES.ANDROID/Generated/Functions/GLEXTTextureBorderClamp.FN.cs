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

namespace Hexa.NET.OpenGLES.ANDROID
{
	public unsafe partial class GLEXTTextureBorderClamp
	{
		[ThreadStatic]
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_EXT_texture_border_clamp";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 8);
			funcTable.Load(0, "glGetSamplerParameterIivEXT");
			funcTable.Load(1, "glGetSamplerParameterIuivEXT");
			funcTable.Load(2, "glGetTexParameterIivEXT");
			funcTable.Load(3, "glGetTexParameterIuivEXT");
			funcTable.Load(4, "glSamplerParameterIivEXT");
			funcTable.Load(5, "glSamplerParameterIuivEXT");
			funcTable.Load(6, "glTexParameterIivEXT");
			funcTable.Load(7, "glTexParameterIuivEXT");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
