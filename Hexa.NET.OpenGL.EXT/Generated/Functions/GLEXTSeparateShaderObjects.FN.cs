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
	public unsafe partial class GLEXTSeparateShaderObjects : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_EXT_separate_shader_objects";

		public GLEXTSeparateShaderObjects() : base(47)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glActiveProgramEXT");
			funcTable.Load(1, "glActiveShaderProgramEXT");
			funcTable.Load(2, "glBindProgramPipelineEXT");
			funcTable.Load(3, "glCreateShaderProgramEXT");
			funcTable.Load(4, "glCreateShaderProgramvEXT");
			funcTable.Load(5, "glDeleteProgramPipelinesEXT");
			funcTable.Load(6, "glGenProgramPipelinesEXT");
			funcTable.Load(7, "glGetProgramPipelineInfoLogEXT");
			funcTable.Load(8, "glGetProgramPipelineivEXT");
			funcTable.Load(9, "glIsProgramPipelineEXT");
			funcTable.Load(10, "glProgramParameteriEXT");
			funcTable.Load(11, "glProgramUniform1fEXT");
			funcTable.Load(12, "glProgramUniform1fvEXT");
			funcTable.Load(13, "glProgramUniform1iEXT");
			funcTable.Load(14, "glProgramUniform1ivEXT");
			funcTable.Load(15, "glProgramUniform1uiEXT");
			funcTable.Load(16, "glProgramUniform1uivEXT");
			funcTable.Load(17, "glProgramUniform2fEXT");
			funcTable.Load(18, "glProgramUniform2fvEXT");
			funcTable.Load(19, "glProgramUniform2iEXT");
			funcTable.Load(20, "glProgramUniform2ivEXT");
			funcTable.Load(21, "glProgramUniform2uiEXT");
			funcTable.Load(22, "glProgramUniform2uivEXT");
			funcTable.Load(23, "glProgramUniform3fEXT");
			funcTable.Load(24, "glProgramUniform3fvEXT");
			funcTable.Load(25, "glProgramUniform3iEXT");
			funcTable.Load(26, "glProgramUniform3ivEXT");
			funcTable.Load(27, "glProgramUniform3uiEXT");
			funcTable.Load(28, "glProgramUniform3uivEXT");
			funcTable.Load(29, "glProgramUniform4fEXT");
			funcTable.Load(30, "glProgramUniform4fvEXT");
			funcTable.Load(31, "glProgramUniform4iEXT");
			funcTable.Load(32, "glProgramUniform4ivEXT");
			funcTable.Load(33, "glProgramUniform4uiEXT");
			funcTable.Load(34, "glProgramUniform4uivEXT");
			funcTable.Load(35, "glProgramUniformMatrix2fvEXT");
			funcTable.Load(36, "glProgramUniformMatrix2x3fvEXT");
			funcTable.Load(37, "glProgramUniformMatrix2x4fvEXT");
			funcTable.Load(38, "glProgramUniformMatrix3fvEXT");
			funcTable.Load(39, "glProgramUniformMatrix3x2fvEXT");
			funcTable.Load(40, "glProgramUniformMatrix3x4fvEXT");
			funcTable.Load(41, "glProgramUniformMatrix4fvEXT");
			funcTable.Load(42, "glProgramUniformMatrix4x2fvEXT");
			funcTable.Load(43, "glProgramUniformMatrix4x3fvEXT");
			funcTable.Load(44, "glUseProgramStagesEXT");
			funcTable.Load(45, "glUseShaderProgramEXT");
			funcTable.Load(46, "glValidateProgramPipelineEXT");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
