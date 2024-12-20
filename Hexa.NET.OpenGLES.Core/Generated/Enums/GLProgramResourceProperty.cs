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

namespace Hexa.NET.OpenGLES
{
	public enum GLProgramResourceProperty : uint
	{
		/// <summary>
		/// Specifies the number of compatible subroutines.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query<br/>GL_ARB_shader_subroutine</remarks>
		NumCompatibleSubroutines = unchecked((uint)0x8E4A),

		/// <summary>
		/// Indicates that subroutines in a shader program are compatible with each other.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query<br/>GL_ARB_shader_subroutine</remarks>
		CompatibleSubroutines = unchecked((uint)0x8E4B),

		/// <summary>
		/// Specifies a uniform variable in a shader program.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		Uniform = unchecked((uint)0x92E1),

		/// <summary>
		/// Specifies whether a variable is per-patch.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		IsPerPatch = unchecked((uint)0x92E7),

		/// <summary>
		/// Specifies the length of a resource name.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		NameLength = unchecked((uint)0x92F9),

		/// <summary>
		/// Specifies the data type of a variable or attribute.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		Type = unchecked((uint)0x92FA),

		/// <summary>
		/// Specifies the size of an array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ArraySize = unchecked((uint)0x92FB),

		/// <summary>
		/// Specifies the offset of a variable within a block.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		Offset = unchecked((uint)0x92FC),

		/// <summary>
		/// Specifies the index of a block.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		BlockIndex = unchecked((uint)0x92FD),

		/// <summary>
		/// Specifies the stride between elements in an array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ArrayStride = unchecked((uint)0x92FE),

		/// <summary>
		/// Specifies the stride between columns in a matrix.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		MatrixStride = unchecked((uint)0x92FF),

		/// <summary>
		/// Indicates if a matrix is stored in row-major order.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		IsRowMajor = unchecked((uint)0x9300),

		/// <summary>
		/// Specifies the index of an atomic counter buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		AtomicCounterBufferIndex = unchecked((uint)0x9301),

		/// <summary>
		/// Specifies the binding point of a buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		BufferBinding = unchecked((uint)0x9302),

		/// <summary>
		/// Specifies the size of the data in a buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		BufferDataSize = unchecked((uint)0x9303),

		/// <summary>
		/// Specifies the number of active variables.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		NumActiveVariables = unchecked((uint)0x9304),

		/// <summary>
		/// Specifies the list of active variables.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ActiveVariables = unchecked((uint)0x9305),

		/// <summary>
		/// Indicates if a resource is referenced by the vertex shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ReferencedByVertexShader = unchecked((uint)0x9306),

		/// <summary>
		/// Indicates if a resource is referenced by the tessellation control shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ReferencedByTessControlShader = unchecked((uint)0x9307),

		/// <summary>
		/// Indicates if a resource is referenced by the tessellation evaluation shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ReferencedByTessEvaluationShader = unchecked((uint)0x9308),

		/// <summary>
		/// Indicates if a resource is referenced by the geometry shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ReferencedByGeometryShader = unchecked((uint)0x9309),

		/// <summary>
		/// Indicates if a resource is referenced by the fragment shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ReferencedByFragmentShader = unchecked((uint)0x930A),

		/// <summary>
		/// Indicates if a resource is referenced by the compute shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		ReferencedByComputeShader = unchecked((uint)0x930B),

		/// <summary>
		/// Specifies the size of a top-level array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		TopLevelArraySize = unchecked((uint)0x930C),

		/// <summary>
		/// Specifies the stride between elements in a top-level array.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		TopLevelArrayStride = unchecked((uint)0x930D),

		/// <summary>
		/// Specifies the location of a variable in a program.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		Location = unchecked((uint)0x930E),

		/// <summary>
		/// Specifies the location index of a variable.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_program_interface_query</remarks>
		LocationIndex = unchecked((uint)0x930F),

		/// <summary>
		/// Specifies the component of a location variable.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_enhanced_layouts</remarks>
		LocationComponent = unchecked((uint)0x934A),

		/// <summary>
		/// Specifies the buffer index for transform feedback.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_enhanced_layouts</remarks>
		TransformFeedbackBufferIndex = unchecked((uint)0x934B),

		/// <summary>
		/// Specifies the stride of a transform feedback buffer.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_enhanced_layouts</remarks>
		TransformFeedbackBufferStride = unchecked((uint)0x934C),
	}
}
