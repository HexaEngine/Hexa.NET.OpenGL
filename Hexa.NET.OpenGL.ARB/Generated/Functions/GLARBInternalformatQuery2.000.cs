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

namespace Hexa.NET.OpenGL.ARB
{
	public static unsafe partial class GLARBInternalformatQuery2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetInternalformati64vNative(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, long* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLInternalFormat, GLInternalFormatPName, int, long*, void>)funcTable[0])(target, internalformat, pname, count, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLInternalFormat, GLInternalFormatPName, int, nint, void>)funcTable[0])(target, internalformat, pname, count, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		public static void GetInternalformati64v(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, long* @params)
		{
			GetInternalformati64vNative(target, internalformat, pname, count, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		public static void GetInternalformati64v(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, out long @params)
		{
			long pparams;
			GetInternalformati64vNative(target, internalformat, pname, count, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_internalformat_query2</remarks>
		public static void GetInternalformati64v(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, Span<long> @params)
		{
			fixed (long* pparams = @params)
			{
				GetInternalformati64vNative(target, internalformat, pname, count, pparams);
			}
		}

	}
}
