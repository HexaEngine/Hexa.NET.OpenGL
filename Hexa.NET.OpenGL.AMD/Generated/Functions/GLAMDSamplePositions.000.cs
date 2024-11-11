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
using System.Runtime.CompilerServices;
using System.Numerics;

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDSamplePositions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SetMultisamplefvAMDNative(GLEnum pname, uint index, float* val)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, float*, void>)funcTable[0])(pname, index, val);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, nint, void>)funcTable[0])(pname, index, (nint)val);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_sample_positions</remarks>
		public void SetMultisamplefvAMD(GLEnum pname, uint index, float* val)
		{
			SetMultisamplefvAMDNative(pname, index, val);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_sample_positions</remarks>
		public void SetMultisamplefvAMD(GLEnum pname, uint index, Span<float> val)
		{
			fixed (float* pval0 = val)
			{
				SetMultisamplefvAMDNative(pname, index, pval0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_sample_positions</remarks>
		public void SetMultisamplefvAMD(GLEnum pname, uint index, ref float val)
		{
			fixed (float* pval0 = &val)
			{
				SetMultisamplefvAMDNative(pname, index, pval0);
			}
		}

	}
}
