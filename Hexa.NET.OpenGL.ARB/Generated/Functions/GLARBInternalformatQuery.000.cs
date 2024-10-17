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
	public static unsafe partial class GLARBInternalformatQuery
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetInternalformativNative(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLInternalFormat, GLInternalFormatPName, int, int*, void>)funcTable[0])(target, internalformat, pname, count, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLInternalFormat, GLInternalFormatPName, int, nint, void>)funcTable[0])(target, internalformat, pname, count, (nint)@params);
			#endif
		}

		public static void GetInternalformativ(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, int* @params)
		{
			GetInternalformativNative(target, internalformat, pname, count, @params);
		}

		public static void GetInternalformativ(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, out int @params)
		{
			int pparams;
			GetInternalformativNative(target, internalformat, pname, count, &pparams);
			@params = pparams;
		}

		public static void GetInternalformativ(GLTextureTarget target, GLInternalFormat internalformat, GLInternalFormatPName pname, int count, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetInternalformativNative(target, internalformat, pname, count, pparams);
			}
		}

	}
}
