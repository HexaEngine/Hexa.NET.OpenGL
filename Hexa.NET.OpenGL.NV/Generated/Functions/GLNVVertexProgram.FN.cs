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
	public unsafe partial class GLNVVertexProgram
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		/// <summary>
		/// Initializes the function table of the extension, call before you access any function.
		/// </summary>
		public static void InitExtension()
		{
			if (funcTable != null) return;
			if (GLBase.NativeContext == null) throw new InvalidOperationException("OpenGL is not initialized, call GL.InitApi.");
			funcTable = new FunctionTable(GLBase.NativeContext, 64);
			funcTable.Load(0, "glAreProgramsResidentNV");
			funcTable.Load(1, "glBindProgramNV");
			funcTable.Load(2, "glDeleteProgramsNV");
			funcTable.Load(3, "glExecuteProgramNV");
			funcTable.Load(4, "glGenProgramsNV");
			funcTable.Load(5, "glGetProgramParameterdvNV");
			funcTable.Load(6, "glGetProgramParameterfvNV");
			funcTable.Load(7, "glGetProgramStringNV");
			funcTable.Load(8, "glGetProgramivNV");
			funcTable.Load(9, "glGetTrackMatrixivNV");
			funcTable.Load(10, "glGetVertexAttribPointervNV");
			funcTable.Load(11, "glGetVertexAttribdvNV");
			funcTable.Load(12, "glGetVertexAttribfvNV");
			funcTable.Load(13, "glGetVertexAttribivNV");
			funcTable.Load(14, "glIsProgramNV");
			funcTable.Load(15, "glLoadProgramNV");
			funcTable.Load(16, "glProgramParameter4dNV");
			funcTable.Load(17, "glProgramParameter4dvNV");
			funcTable.Load(18, "glProgramParameter4fNV");
			funcTable.Load(19, "glProgramParameter4fvNV");
			funcTable.Load(20, "glProgramParameters4dvNV");
			funcTable.Load(21, "glProgramParameters4fvNV");
			funcTable.Load(22, "glRequestResidentProgramsNV");
			funcTable.Load(23, "glTrackMatrixNV");
			funcTable.Load(24, "glVertexAttrib1dNV");
			funcTable.Load(25, "glVertexAttrib1dvNV");
			funcTable.Load(26, "glVertexAttrib1fNV");
			funcTable.Load(27, "glVertexAttrib1fvNV");
			funcTable.Load(28, "glVertexAttrib1sNV");
			funcTable.Load(29, "glVertexAttrib1svNV");
			funcTable.Load(30, "glVertexAttrib2dNV");
			funcTable.Load(31, "glVertexAttrib2dvNV");
			funcTable.Load(32, "glVertexAttrib2fNV");
			funcTable.Load(33, "glVertexAttrib2fvNV");
			funcTable.Load(34, "glVertexAttrib2sNV");
			funcTable.Load(35, "glVertexAttrib2svNV");
			funcTable.Load(36, "glVertexAttrib3dNV");
			funcTable.Load(37, "glVertexAttrib3dvNV");
			funcTable.Load(38, "glVertexAttrib3fNV");
			funcTable.Load(39, "glVertexAttrib3fvNV");
			funcTable.Load(40, "glVertexAttrib3sNV");
			funcTable.Load(41, "glVertexAttrib3svNV");
			funcTable.Load(42, "glVertexAttrib4dNV");
			funcTable.Load(43, "glVertexAttrib4dvNV");
			funcTable.Load(44, "glVertexAttrib4fNV");
			funcTable.Load(45, "glVertexAttrib4fvNV");
			funcTable.Load(46, "glVertexAttrib4sNV");
			funcTable.Load(47, "glVertexAttrib4svNV");
			funcTable.Load(48, "glVertexAttrib4ubNV");
			funcTable.Load(49, "glVertexAttrib4ubvNV");
			funcTable.Load(50, "glVertexAttribPointerNV");
			funcTable.Load(51, "glVertexAttribs1dvNV");
			funcTable.Load(52, "glVertexAttribs1fvNV");
			funcTable.Load(53, "glVertexAttribs1svNV");
			funcTable.Load(54, "glVertexAttribs2dvNV");
			funcTable.Load(55, "glVertexAttribs2fvNV");
			funcTable.Load(56, "glVertexAttribs2svNV");
			funcTable.Load(57, "glVertexAttribs3dvNV");
			funcTable.Load(58, "glVertexAttribs3fvNV");
			funcTable.Load(59, "glVertexAttribs3svNV");
			funcTable.Load(60, "glVertexAttribs4dvNV");
			funcTable.Load(61, "glVertexAttribs4fvNV");
			funcTable.Load(62, "glVertexAttribs4svNV");
			funcTable.Load(63, "glVertexAttribs4ubvNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
