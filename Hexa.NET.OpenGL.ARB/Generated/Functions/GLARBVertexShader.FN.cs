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
	public unsafe partial class GLARBVertexShader
	{
		[ThreadStatic]
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_ARB_vertex_shader";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 46);
			funcTable.Load(0, "glBindAttribLocationARB");
			funcTable.Load(1, "glDisableVertexAttribArrayARB");
			funcTable.Load(2, "glEnableVertexAttribArrayARB");
			funcTable.Load(3, "glGetActiveAttribARB");
			funcTable.Load(4, "glGetAttribLocationARB");
			funcTable.Load(5, "glGetVertexAttribPointervARB");
			funcTable.Load(6, "glGetVertexAttribdvARB");
			funcTable.Load(7, "glGetVertexAttribfvARB");
			funcTable.Load(8, "glGetVertexAttribivARB");
			funcTable.Load(9, "glVertexAttrib1dARB");
			funcTable.Load(10, "glVertexAttrib1dvARB");
			funcTable.Load(11, "glVertexAttrib1fARB");
			funcTable.Load(12, "glVertexAttrib1fvARB");
			funcTable.Load(13, "glVertexAttrib1sARB");
			funcTable.Load(14, "glVertexAttrib1svARB");
			funcTable.Load(15, "glVertexAttrib2dARB");
			funcTable.Load(16, "glVertexAttrib2dvARB");
			funcTable.Load(17, "glVertexAttrib2fARB");
			funcTable.Load(18, "glVertexAttrib2fvARB");
			funcTable.Load(19, "glVertexAttrib2sARB");
			funcTable.Load(20, "glVertexAttrib2svARB");
			funcTable.Load(21, "glVertexAttrib3dARB");
			funcTable.Load(22, "glVertexAttrib3dvARB");
			funcTable.Load(23, "glVertexAttrib3fARB");
			funcTable.Load(24, "glVertexAttrib3fvARB");
			funcTable.Load(25, "glVertexAttrib3sARB");
			funcTable.Load(26, "glVertexAttrib3svARB");
			funcTable.Load(27, "glVertexAttrib4NbvARB");
			funcTable.Load(28, "glVertexAttrib4NivARB");
			funcTable.Load(29, "glVertexAttrib4NsvARB");
			funcTable.Load(30, "glVertexAttrib4NubARB");
			funcTable.Load(31, "glVertexAttrib4NubvARB");
			funcTable.Load(32, "glVertexAttrib4NuivARB");
			funcTable.Load(33, "glVertexAttrib4NusvARB");
			funcTable.Load(34, "glVertexAttrib4bvARB");
			funcTable.Load(35, "glVertexAttrib4dARB");
			funcTable.Load(36, "glVertexAttrib4dvARB");
			funcTable.Load(37, "glVertexAttrib4fARB");
			funcTable.Load(38, "glVertexAttrib4fvARB");
			funcTable.Load(39, "glVertexAttrib4ivARB");
			funcTable.Load(40, "glVertexAttrib4sARB");
			funcTable.Load(41, "glVertexAttrib4svARB");
			funcTable.Load(42, "glVertexAttrib4ubvARB");
			funcTable.Load(43, "glVertexAttrib4uivARB");
			funcTable.Load(44, "glVertexAttrib4usvARB");
			funcTable.Load(45, "glVertexAttribPointerARB");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
