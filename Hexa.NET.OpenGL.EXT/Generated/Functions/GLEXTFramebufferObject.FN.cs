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
	public unsafe partial class GLEXTFramebufferObject
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_EXT_framebuffer_object";

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
			funcTable.Load(0, "glBindFramebufferEXT");
			funcTable.Load(1, "glBindRenderbufferEXT");
			funcTable.Load(2, "glCheckFramebufferStatusEXT");
			funcTable.Load(3, "glDeleteFramebuffersEXT");
			funcTable.Load(4, "glDeleteRenderbuffersEXT");
			funcTable.Load(5, "glFramebufferRenderbufferEXT");
			funcTable.Load(6, "glFramebufferTexture1DEXT");
			funcTable.Load(7, "glFramebufferTexture2DEXT");
			funcTable.Load(8, "glFramebufferTexture3DEXT");
			funcTable.Load(9, "glGenFramebuffersEXT");
			funcTable.Load(10, "glGenRenderbuffersEXT");
			funcTable.Load(11, "glGenerateMipmapEXT");
			funcTable.Load(12, "glGetFramebufferAttachmentParameterivEXT");
			funcTable.Load(13, "glGetRenderbufferParameterivEXT");
			funcTable.Load(14, "glIsFramebufferEXT");
			funcTable.Load(15, "glIsRenderbufferEXT");
			funcTable.Load(16, "glRenderbufferStorageEXT");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
