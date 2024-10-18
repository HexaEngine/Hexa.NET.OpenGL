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

namespace Hexa.NET.OpenGL
{
	public enum GLUseProgramStageMask : uint
	{
		/// <summary>
		/// Indicates vertex shader usage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_separate_shader_objects</remarks>
		VertexShaderBit = unchecked((uint)0x00000001),

		/// <summary>
		/// Vertex shader bit for extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_separate_shader_objects</remarks>
		VertexShaderBitExt = unchecked((uint)0x00000001),

		/// <summary>
		/// Indicates fragment shader usage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_separate_shader_objects</remarks>
		FragmentShaderBit = unchecked((uint)0x00000002),

		/// <summary>
		/// Fragment shader bit for extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_separate_shader_objects</remarks>
		FragmentShaderBitExt = unchecked((uint)0x00000002),

		/// <summary>
		/// Indicates geometry shader usage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_separate_shader_objects</remarks>
		GeometryShaderBit = unchecked((uint)0x00000004),

		/// <summary>
		/// Geometry shader bit for extensions.
		/// </summary>
		/// <remarks></remarks>
		GeometryShaderBitExt = unchecked((uint)0x00000004),

		/// <summary>
		/// Geometry shader bit for OES extensions.
		/// </summary>
		/// <remarks></remarks>
		GeometryShaderBitOes = unchecked((uint)0x00000004),

		/// <summary>
		/// Indicates tessellation control shader usage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_separate_shader_objects</remarks>
		TessControlShaderBit = unchecked((uint)0x00000008),

		/// <summary>
		/// Tessellation control shader bit for extensions.
		/// </summary>
		/// <remarks></remarks>
		TessControlShaderBitExt = unchecked((uint)0x00000008),

		/// <summary>
		/// Tessellation control shader bit for OES extensions.
		/// </summary>
		/// <remarks></remarks>
		TessControlShaderBitOes = unchecked((uint)0x00000008),

		/// <summary>
		/// Indicates tessellation evaluation shader usage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_separate_shader_objects</remarks>
		TessEvaluationShaderBit = unchecked((uint)0x00000010),

		/// <summary>
		/// Tessellation evaluation shader bit for extensions.
		/// </summary>
		/// <remarks></remarks>
		TessEvaluationShaderBitExt = unchecked((uint)0x00000010),

		/// <summary>
		/// Tessellation evaluation shader bit for OES extensions.
		/// </summary>
		/// <remarks></remarks>
		TessEvaluationShaderBitOes = unchecked((uint)0x00000010),

		/// <summary>
		/// Indicates compute shader usage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_compute_shader</remarks>
		ComputeShaderBit = unchecked((uint)0x00000020),

		/// <summary>
		/// Indicates mesh shader usage (NV).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_mesh_shader</remarks>
		MeshShaderBitNv = unchecked((uint)0x00000040),

		/// <summary>
		/// Indicates task shader usage (NV).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_mesh_shader</remarks>
		TaskShaderBitNv = unchecked((uint)0x00000080),

		/// <summary>
		/// Indicates all shader bits.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_separate_shader_objects</remarks>
		AllShaderBits = unchecked((uint)0xFFFFFFFF),

		/// <summary>
		/// All shader bits for extensions.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_separate_shader_objects</remarks>
		AllShaderBitsExt = unchecked((uint)0xFFFFFFFF),
	}
}
