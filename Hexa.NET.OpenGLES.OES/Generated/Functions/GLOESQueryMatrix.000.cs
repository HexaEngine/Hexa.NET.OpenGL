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

namespace Hexa.NET.OpenGLES.OES
{
	public unsafe partial class GLOESQueryMatrix
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal uint QueryMatrixxOESNative(int* mantissa, int* exponent)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<int*, int*, uint>)funcTable[0])(mantissa, exponent);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<nint, nint, uint>)funcTable[0])((nint)mantissa, (nint)exponent);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_query_matrix</remarks>
		public uint QueryMatrixxOES(int* mantissa, int* exponent)
		{
			uint ret = QueryMatrixxOESNative(mantissa, exponent);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_query_matrix</remarks>
		public uint QueryMatrixxOES(Span<int> mantissa, int* exponent)
		{
			fixed (int* pmantissa0 = mantissa)
			{
				uint ret = QueryMatrixxOESNative(pmantissa0, exponent);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_query_matrix</remarks>
		public uint QueryMatrixxOES(ref int mantissa, int* exponent)
		{
			fixed (int* pmantissa0 = &mantissa)
			{
				uint ret = QueryMatrixxOESNative(pmantissa0, exponent);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_query_matrix</remarks>
		public uint QueryMatrixxOES(int* mantissa, Span<int> exponent)
		{
			fixed (int* pexponent0 = exponent)
			{
				uint ret = QueryMatrixxOESNative(mantissa, pexponent0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_query_matrix</remarks>
		public uint QueryMatrixxOES(int* mantissa, ref int exponent)
		{
			fixed (int* pexponent0 = &exponent)
			{
				uint ret = QueryMatrixxOESNative(mantissa, pexponent0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_query_matrix</remarks>
		public uint QueryMatrixxOES(Span<int> mantissa, Span<int> exponent)
		{
			fixed (int* pmantissa0 = mantissa)
			{
				fixed (int* pexponent1 = exponent)
				{
					uint ret = QueryMatrixxOESNative(pmantissa0, pexponent1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_query_matrix</remarks>
		public uint QueryMatrixxOES(ref int mantissa, ref int exponent)
		{
			fixed (int* pmantissa0 = &mantissa)
			{
				fixed (int* pexponent1 = &exponent)
				{
					uint ret = QueryMatrixxOESNative(pmantissa0, pexponent1);
					return ret;
				}
			}
		}

	}
}
