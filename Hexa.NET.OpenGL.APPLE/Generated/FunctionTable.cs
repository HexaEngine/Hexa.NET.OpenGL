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

namespace Hexa.NET.OpenGL.APPLE
{
	public unsafe partial class GLAPPLE
	{
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, call before you access any function.
		/// </summary>
		public static void InitApi(INativeContext context)
		{
			funcTable = new FunctionTable(context, 34);
			funcTable.Load(0, "glBindVertexArrayAPPLE");
			funcTable.Load(1, "glBufferParameteriAPPLE");
			funcTable.Load(2, "glDeleteFencesAPPLE");
			funcTable.Load(3, "glDeleteVertexArraysAPPLE");
			funcTable.Load(4, "glDisableVertexAttribAPPLE");
			funcTable.Load(5, "glDrawElementArrayAPPLE");
			funcTable.Load(6, "glDrawRangeElementArrayAPPLE");
			funcTable.Load(7, "glElementPointerAPPLE");
			funcTable.Load(8, "glEnableVertexAttribAPPLE");
			funcTable.Load(9, "glFinishFenceAPPLE");
			funcTable.Load(10, "glFinishObjectAPPLE");
			funcTable.Load(11, "glFlushMappedBufferRangeAPPLE");
			funcTable.Load(12, "glFlushVertexArrayRangeAPPLE");
			funcTable.Load(13, "glGenFencesAPPLE");
			funcTable.Load(14, "glGenVertexArraysAPPLE");
			funcTable.Load(15, "glGetObjectParameterivAPPLE");
			funcTable.Load(16, "glGetTexParameterPointervAPPLE");
			funcTable.Load(17, "glIsFenceAPPLE");
			funcTable.Load(18, "glIsVertexArrayAPPLE");
			funcTable.Load(19, "glIsVertexAttribEnabledAPPLE");
			funcTable.Load(20, "glMapVertexAttrib1dAPPLE");
			funcTable.Load(21, "glMapVertexAttrib1fAPPLE");
			funcTable.Load(22, "glMapVertexAttrib2dAPPLE");
			funcTable.Load(23, "glMapVertexAttrib2fAPPLE");
			funcTable.Load(24, "glMultiDrawElementArrayAPPLE");
			funcTable.Load(25, "glMultiDrawRangeElementArrayAPPLE");
			funcTable.Load(26, "glObjectPurgeableAPPLE");
			funcTable.Load(27, "glObjectUnpurgeableAPPLE");
			funcTable.Load(28, "glSetFenceAPPLE");
			funcTable.Load(29, "glTestFenceAPPLE");
			funcTable.Load(30, "glTestObjectAPPLE");
			funcTable.Load(31, "glTextureRangeAPPLE");
			funcTable.Load(32, "glVertexArrayParameteriAPPLE");
			funcTable.Load(33, "glVertexArrayRangeAPPLE");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}