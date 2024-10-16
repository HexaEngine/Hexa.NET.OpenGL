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
	public unsafe partial class GLEXTGpuShader4
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_EXT_gpu_shader4";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 34);
			funcTable.Load(0, "glBindFragDataLocationEXT");
			funcTable.Load(1, "glGetFragDataLocationEXT");
			funcTable.Load(2, "glGetUniformuivEXT");
			funcTable.Load(3, "glGetVertexAttribIivEXT");
			funcTable.Load(4, "glGetVertexAttribIuivEXT");
			funcTable.Load(5, "glUniform1uiEXT");
			funcTable.Load(6, "glUniform1uivEXT");
			funcTable.Load(7, "glUniform2uiEXT");
			funcTable.Load(8, "glUniform2uivEXT");
			funcTable.Load(9, "glUniform3uiEXT");
			funcTable.Load(10, "glUniform3uivEXT");
			funcTable.Load(11, "glUniform4uiEXT");
			funcTable.Load(12, "glUniform4uivEXT");
			funcTable.Load(13, "glVertexAttribI1iEXT");
			funcTable.Load(14, "glVertexAttribI1ivEXT");
			funcTable.Load(15, "glVertexAttribI1uiEXT");
			funcTable.Load(16, "glVertexAttribI1uivEXT");
			funcTable.Load(17, "glVertexAttribI2iEXT");
			funcTable.Load(18, "glVertexAttribI2ivEXT");
			funcTable.Load(19, "glVertexAttribI2uiEXT");
			funcTable.Load(20, "glVertexAttribI2uivEXT");
			funcTable.Load(21, "glVertexAttribI3iEXT");
			funcTable.Load(22, "glVertexAttribI3ivEXT");
			funcTable.Load(23, "glVertexAttribI3uiEXT");
			funcTable.Load(24, "glVertexAttribI3uivEXT");
			funcTable.Load(25, "glVertexAttribI4bvEXT");
			funcTable.Load(26, "glVertexAttribI4iEXT");
			funcTable.Load(27, "glVertexAttribI4ivEXT");
			funcTable.Load(28, "glVertexAttribI4svEXT");
			funcTable.Load(29, "glVertexAttribI4ubvEXT");
			funcTable.Load(30, "glVertexAttribI4uiEXT");
			funcTable.Load(31, "glVertexAttribI4uivEXT");
			funcTable.Load(32, "glVertexAttribI4usvEXT");
			funcTable.Load(33, "glVertexAttribIPointerEXT");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
