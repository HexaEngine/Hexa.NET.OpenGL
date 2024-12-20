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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVInternalformatSampleQuery
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetInternalformatSampleivNVNative(GLTextureTarget target, GLInternalFormat internalformat, int samples, GLInternalFormatPName pname, int count, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLInternalFormat, int, GLInternalFormatPName, int, int*, void>)funcTable[0])(target, internalformat, samples, pname, count, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLInternalFormat, int, GLInternalFormatPName, int, nint, void>)funcTable[0])(target, internalformat, samples, pname, count, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_internalformat_sample_query</remarks>
		public void GetInternalformatSampleivNV(GLTextureTarget target, GLInternalFormat internalformat, int samples, GLInternalFormatPName pname, int count, int* @params)
		{
			GetInternalformatSampleivNVNative(target, internalformat, samples, pname, count, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_internalformat_sample_query</remarks>
		public void GetInternalformatSampleivNV(GLTextureTarget target, GLInternalFormat internalformat, int samples, GLInternalFormatPName pname, int count, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetInternalformatSampleivNVNative(target, internalformat, samples, pname, count, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_internalformat_sample_query</remarks>
		public void GetInternalformatSampleivNV(GLTextureTarget target, GLInternalFormat internalformat, int samples, GLInternalFormatPName pname, int count, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetInternalformatSampleivNVNative(target, internalformat, samples, pname, count, pparams0);
			}
		}

	}
}
