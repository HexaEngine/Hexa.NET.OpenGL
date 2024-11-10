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
	public unsafe partial class GLARBShaderObjects
	{
		[ThreadStatic]
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_ARB_shader_objects";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 39);
			funcTable.Load(0, "glAttachObjectARB");
			funcTable.Load(1, "glCompileShaderARB");
			funcTable.Load(2, "glCreateProgramObjectARB");
			funcTable.Load(3, "glCreateShaderObjectARB");
			funcTable.Load(4, "glDeleteObjectARB");
			funcTable.Load(5, "glDetachObjectARB");
			funcTable.Load(6, "glGetActiveUniformARB");
			funcTable.Load(7, "glGetAttachedObjectsARB");
			funcTable.Load(8, "glGetHandleARB");
			funcTable.Load(9, "glGetInfoLogARB");
			funcTable.Load(10, "glGetObjectParameterfvARB");
			funcTable.Load(11, "glGetObjectParameterivARB");
			funcTable.Load(12, "glGetShaderSourceARB");
			funcTable.Load(13, "glGetUniformLocationARB");
			funcTable.Load(14, "glGetUniformfvARB");
			funcTable.Load(15, "glGetUniformivARB");
			funcTable.Load(16, "glLinkProgramARB");
			funcTable.Load(17, "glShaderSourceARB");
			funcTable.Load(18, "glUniform1fARB");
			funcTable.Load(19, "glUniform1fvARB");
			funcTable.Load(20, "glUniform1iARB");
			funcTable.Load(21, "glUniform1ivARB");
			funcTable.Load(22, "glUniform2fARB");
			funcTable.Load(23, "glUniform2fvARB");
			funcTable.Load(24, "glUniform2iARB");
			funcTable.Load(25, "glUniform2ivARB");
			funcTable.Load(26, "glUniform3fARB");
			funcTable.Load(27, "glUniform3fvARB");
			funcTable.Load(28, "glUniform3iARB");
			funcTable.Load(29, "glUniform3ivARB");
			funcTable.Load(30, "glUniform4fARB");
			funcTable.Load(31, "glUniform4fvARB");
			funcTable.Load(32, "glUniform4iARB");
			funcTable.Load(33, "glUniform4ivARB");
			funcTable.Load(34, "glUniformMatrix2fvARB");
			funcTable.Load(35, "glUniformMatrix3fvARB");
			funcTable.Load(36, "glUniformMatrix4fvARB");
			funcTable.Load(37, "glUseProgramObjectARB");
			funcTable.Load(38, "glValidateProgramARB");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
