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
	public enum GLSemaphoreParameterName : uint
	{
		/// <summary>
		/// Specifies a D3D12 fence value (EXT extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_semaphore_win32</remarks>
		D3D12FenceValueExt = unchecked((uint)0x9595),

		/// <summary>
		/// Specifies the value of a timeline semaphore (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_timeline_semaphore</remarks>
		TimelineSemaphoreValueNv = unchecked((uint)0x9595),

		/// <summary>
		/// Specifies the type of semaphore (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_timeline_semaphore</remarks>
		TypeNv = unchecked((uint)0x95B3),

		/// <summary>
		/// Specifies a binary semaphore type (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_timeline_semaphore</remarks>
		TypeBinaryNv = unchecked((uint)0x95B4),

		/// <summary>
		/// Specifies a timeline semaphore type (NV extension).
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_timeline_semaphore</remarks>
		TypeTimelineNv = unchecked((uint)0x95B5),
	}
}
