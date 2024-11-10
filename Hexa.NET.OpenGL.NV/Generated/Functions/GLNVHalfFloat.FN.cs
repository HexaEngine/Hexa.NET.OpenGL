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
	public unsafe partial class GLNVHalfFloat
	{
		[ThreadStatic]
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_NV_half_float";

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
			funcTable.Load(0, "glColor3hNV");
			funcTable.Load(1, "glColor3hvNV");
			funcTable.Load(2, "glColor4hNV");
			funcTable.Load(3, "glColor4hvNV");
			funcTable.Load(4, "glFogCoordhNV");
			funcTable.Load(5, "glFogCoordhvNV");
			funcTable.Load(6, "glMultiTexCoord1hNV");
			funcTable.Load(7, "glMultiTexCoord1hvNV");
			funcTable.Load(8, "glMultiTexCoord2hNV");
			funcTable.Load(9, "glMultiTexCoord2hvNV");
			funcTable.Load(10, "glMultiTexCoord3hNV");
			funcTable.Load(11, "glMultiTexCoord3hvNV");
			funcTable.Load(12, "glMultiTexCoord4hNV");
			funcTable.Load(13, "glMultiTexCoord4hvNV");
			funcTable.Load(14, "glNormal3hNV");
			funcTable.Load(15, "glNormal3hvNV");
			funcTable.Load(16, "glSecondaryColor3hNV");
			funcTable.Load(17, "glSecondaryColor3hvNV");
			funcTable.Load(18, "glTexCoord1hNV");
			funcTable.Load(19, "glTexCoord1hvNV");
			funcTable.Load(20, "glTexCoord2hNV");
			funcTable.Load(21, "glTexCoord2hvNV");
			funcTable.Load(22, "glTexCoord3hNV");
			funcTable.Load(23, "glTexCoord3hvNV");
			funcTable.Load(24, "glTexCoord4hNV");
			funcTable.Load(25, "glTexCoord4hvNV");
			funcTable.Load(26, "glVertex2hNV");
			funcTable.Load(27, "glVertex2hvNV");
			funcTable.Load(28, "glVertex3hNV");
			funcTable.Load(29, "glVertex3hvNV");
			funcTable.Load(30, "glVertex4hNV");
			funcTable.Load(31, "glVertex4hvNV");
			funcTable.Load(32, "glVertexAttrib1hNV");
			funcTable.Load(33, "glVertexAttrib1hvNV");
			funcTable.Load(34, "glVertexAttrib2hNV");
			funcTable.Load(35, "glVertexAttrib2hvNV");
			funcTable.Load(36, "glVertexAttrib3hNV");
			funcTable.Load(37, "glVertexAttrib3hvNV");
			funcTable.Load(38, "glVertexAttrib4hNV");
			funcTable.Load(39, "glVertexAttrib4hvNV");
			funcTable.Load(40, "glVertexAttribs1hvNV");
			funcTable.Load(41, "glVertexAttribs2hvNV");
			funcTable.Load(42, "glVertexAttribs3hvNV");
			funcTable.Load(43, "glVertexAttribs4hvNV");
			funcTable.Load(44, "glVertexWeighthNV");
			funcTable.Load(45, "glVertexWeighthvNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
