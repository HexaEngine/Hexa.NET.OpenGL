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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVGpuShader5 : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_NV_gpu_shader5";

		public GLNVGpuShader5() : base(33)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glGetUniformi64vNV");
			funcTable.Load(1, "glProgramUniform1i64NV");
			funcTable.Load(2, "glProgramUniform1i64vNV");
			funcTable.Load(3, "glProgramUniform1ui64NV");
			funcTable.Load(4, "glProgramUniform1ui64vNV");
			funcTable.Load(5, "glProgramUniform2i64NV");
			funcTable.Load(6, "glProgramUniform2i64vNV");
			funcTable.Load(7, "glProgramUniform2ui64NV");
			funcTable.Load(8, "glProgramUniform2ui64vNV");
			funcTable.Load(9, "glProgramUniform3i64NV");
			funcTable.Load(10, "glProgramUniform3i64vNV");
			funcTable.Load(11, "glProgramUniform3ui64NV");
			funcTable.Load(12, "glProgramUniform3ui64vNV");
			funcTable.Load(13, "glProgramUniform4i64NV");
			funcTable.Load(14, "glProgramUniform4i64vNV");
			funcTable.Load(15, "glProgramUniform4ui64NV");
			funcTable.Load(16, "glProgramUniform4ui64vNV");
			funcTable.Load(17, "glUniform1i64NV");
			funcTable.Load(18, "glUniform1i64vNV");
			funcTable.Load(19, "glUniform1ui64NV");
			funcTable.Load(20, "glUniform1ui64vNV");
			funcTable.Load(21, "glUniform2i64NV");
			funcTable.Load(22, "glUniform2i64vNV");
			funcTable.Load(23, "glUniform2ui64NV");
			funcTable.Load(24, "glUniform2ui64vNV");
			funcTable.Load(25, "glUniform3i64NV");
			funcTable.Load(26, "glUniform3i64vNV");
			funcTable.Load(27, "glUniform3ui64NV");
			funcTable.Load(28, "glUniform3ui64vNV");
			funcTable.Load(29, "glUniform4i64NV");
			funcTable.Load(30, "glUniform4i64vNV");
			funcTable.Load(31, "glUniform4ui64NV");
			funcTable.Load(32, "glUniform4ui64vNV");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
