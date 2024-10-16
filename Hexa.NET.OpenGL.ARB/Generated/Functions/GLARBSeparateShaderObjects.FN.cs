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
	public unsafe partial class GLARBSeparateShaderObjects
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_ARB_separate_shader_objects";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 61);
			funcTable.Load(0, "glActiveShaderProgram");
			funcTable.Load(1, "glBindProgramPipeline");
			funcTable.Load(2, "glCreateShaderProgramv");
			funcTable.Load(3, "glDeleteProgramPipelines");
			funcTable.Load(4, "glGenProgramPipelines");
			funcTable.Load(5, "glGetProgramPipelineInfoLog");
			funcTable.Load(6, "glGetProgramPipelineiv");
			funcTable.Load(7, "glIsProgramPipeline");
			funcTable.Load(8, "glProgramParameteri");
			funcTable.Load(9, "glProgramUniform1d");
			funcTable.Load(10, "glProgramUniform1dv");
			funcTable.Load(11, "glProgramUniform1f");
			funcTable.Load(12, "glProgramUniform1fv");
			funcTable.Load(13, "glProgramUniform1i");
			funcTable.Load(14, "glProgramUniform1iv");
			funcTable.Load(15, "glProgramUniform1ui");
			funcTable.Load(16, "glProgramUniform1uiv");
			funcTable.Load(17, "glProgramUniform2d");
			funcTable.Load(18, "glProgramUniform2dv");
			funcTable.Load(19, "glProgramUniform2f");
			funcTable.Load(20, "glProgramUniform2fv");
			funcTable.Load(21, "glProgramUniform2i");
			funcTable.Load(22, "glProgramUniform2iv");
			funcTable.Load(23, "glProgramUniform2ui");
			funcTable.Load(24, "glProgramUniform2uiv");
			funcTable.Load(25, "glProgramUniform3d");
			funcTable.Load(26, "glProgramUniform3dv");
			funcTable.Load(27, "glProgramUniform3f");
			funcTable.Load(28, "glProgramUniform3fv");
			funcTable.Load(29, "glProgramUniform3i");
			funcTable.Load(30, "glProgramUniform3iv");
			funcTable.Load(31, "glProgramUniform3ui");
			funcTable.Load(32, "glProgramUniform3uiv");
			funcTable.Load(33, "glProgramUniform4d");
			funcTable.Load(34, "glProgramUniform4dv");
			funcTable.Load(35, "glProgramUniform4f");
			funcTable.Load(36, "glProgramUniform4fv");
			funcTable.Load(37, "glProgramUniform4i");
			funcTable.Load(38, "glProgramUniform4iv");
			funcTable.Load(39, "glProgramUniform4ui");
			funcTable.Load(40, "glProgramUniform4uiv");
			funcTable.Load(41, "glProgramUniformMatrix2dv");
			funcTable.Load(42, "glProgramUniformMatrix2fv");
			funcTable.Load(43, "glProgramUniformMatrix2x3dv");
			funcTable.Load(44, "glProgramUniformMatrix2x3fv");
			funcTable.Load(45, "glProgramUniformMatrix2x4dv");
			funcTable.Load(46, "glProgramUniformMatrix2x4fv");
			funcTable.Load(47, "glProgramUniformMatrix3dv");
			funcTable.Load(48, "glProgramUniformMatrix3fv");
			funcTable.Load(49, "glProgramUniformMatrix3x2dv");
			funcTable.Load(50, "glProgramUniformMatrix3x2fv");
			funcTable.Load(51, "glProgramUniformMatrix3x4dv");
			funcTable.Load(52, "glProgramUniformMatrix3x4fv");
			funcTable.Load(53, "glProgramUniformMatrix4dv");
			funcTable.Load(54, "glProgramUniformMatrix4fv");
			funcTable.Load(55, "glProgramUniformMatrix4x2dv");
			funcTable.Load(56, "glProgramUniformMatrix4x2fv");
			funcTable.Load(57, "glProgramUniformMatrix4x3dv");
			funcTable.Load(58, "glProgramUniformMatrix4x3fv");
			funcTable.Load(59, "glUseProgramStages");
			funcTable.Load(60, "glValidateProgramPipeline");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
