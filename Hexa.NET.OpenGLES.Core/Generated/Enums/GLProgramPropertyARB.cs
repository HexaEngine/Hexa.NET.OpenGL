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
	public enum GLProgramPropertyARB : uint
	{
		/// <summary>
		/// Specifies the work group size in compute shaders.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_compute_shader</remarks>
		ComputeWorkGroupSize = unchecked((uint)0x8267),

		/// <summary>
		/// Specifies the length of a program binary.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_get_program_binary</remarks>
		BinaryLength = unchecked((uint)0x8741),

		/// <summary>
		/// Specifies the output vertices of a geometry shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		GeometryVerticesOut = unchecked((uint)0x8916),

		/// <summary>
		/// Specifies the input type for a geometry shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		GeometryInputType = unchecked((uint)0x8917),

		/// <summary>
		/// Specifies the output type for a geometry shader.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		GeometryOutputType = unchecked((uint)0x8918),

		/// <summary>
		/// Specifies the maximum length of an active uniform block name.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_uniform_buffer_object</remarks>
		ActiveUniformBlockMaxNameLength = unchecked((uint)0x8A35),

		/// <summary>
		/// Specifies the number of active uniform blocks.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_uniform_buffer_object</remarks>
		ActiveUniformBlocks = unchecked((uint)0x8A36),

		/// <summary>
		/// Specifies the delete status of an OpenGL object.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		DeleteStatus = unchecked((uint)0x8B80),

		/// <summary>
		/// Specifies the link status of a program object.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		LinkStatus = unchecked((uint)0x8B82),

		/// <summary>
		/// Specifies the validation status of a program object.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ValidateStatus = unchecked((uint)0x8B83),

		/// <summary>
		/// Specifies the length of the information log for a shader or program object.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		InfoLogLength = unchecked((uint)0x8B84),

		/// <summary>
		/// Specifies the number of attached shaders to a program object.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		AttachedShaders = unchecked((uint)0x8B85),

		/// <summary>
		/// Specifies the number of active uniform variables for a program object.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ActiveUniforms = unchecked((uint)0x8B86),

		/// <summary>
		/// Specifies the maximum length of an active uniform variable's name.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ActiveUniformMaxLength = unchecked((uint)0x8B87),

		/// <summary>
		/// Specifies the number of active attribute variables for a program object.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ActiveAttributes = unchecked((uint)0x8B89),

		/// <summary>
		/// Specifies the maximum length of an active attribute variable's name.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		ActiveAttributeMaxLength = unchecked((uint)0x8B8A),

		/// <summary>
		/// Specifies the maximum length of varying variables for transform feedback.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TransformFeedbackVaryingMaxLength = unchecked((uint)0x8C76),

		/// <summary>
		/// Specifies the buffer mode for transform feedback.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TransformFeedbackBufferMode = unchecked((uint)0x8C7F),

		/// <summary>
		/// Specifies the transform feedback varyings.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.</remarks>
		TransformFeedbackVaryings = unchecked((uint)0x8C83),

		/// <summary>
		/// Specifies the number of active atomic counter buffers.
		/// </summary>
		/// <remarks>Supported Versions: All GL ES versions.<br/><br/>Used by Extensions:<br/>GL_ARB_shader_atomic_counters</remarks>
		ActiveAtomicCounterBuffers = unchecked((uint)0x92D9),
	}
}
