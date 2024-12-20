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
	public unsafe partial class GLNVGpuShader5
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetUniformi64vNVNative(uint program, int location, long* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, long*, void>)funcTable[0])(program, location, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[0])(program, location, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void GetUniformi64vNV(uint program, int location, long* @params)
		{
			GetUniformi64vNVNative(program, location, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void GetUniformi64vNV(uint program, int location, Span<long> @params)
		{
			fixed (long* pparams0 = @params)
			{
				GetUniformi64vNVNative(program, location, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void GetUniformi64vNV(uint program, int location, ref long @params)
		{
			fixed (long* pparams0 = &@params)
			{
				GetUniformi64vNVNative(program, location, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform1i64NVNative(uint program, int location, long x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, long, void>)funcTable[1])(program, location, x);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, long, void>)funcTable[1])(program, location, x);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1i64NV(uint program, int location, long x)
		{
			ProgramUniform1i64NVNative(program, location, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform1i64vNVNative(uint program, int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, long*, void>)funcTable[2])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[2])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1i64vNV(uint program, int location, int count, long* value)
		{
			ProgramUniform1i64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1i64vNV(uint program, int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				ProgramUniform1i64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1i64vNV(uint program, int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				ProgramUniform1i64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform1ui64NVNative(uint program, int location, ulong x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, ulong, void>)funcTable[3])(program, location, x);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, ulong, void>)funcTable[3])(program, location, x);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1ui64NV(uint program, int location, ulong x)
		{
			ProgramUniform1ui64NVNative(program, location, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform1ui64vNVNative(uint program, int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, ulong*, void>)funcTable[4])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[4])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1ui64vNV(uint program, int location, int count, ulong* value)
		{
			ProgramUniform1ui64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1ui64vNV(uint program, int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				ProgramUniform1ui64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform1ui64vNV(uint program, int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				ProgramUniform1ui64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform2i64NVNative(uint program, int location, long x, long y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, long, long, void>)funcTable[5])(program, location, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, long, long, void>)funcTable[5])(program, location, x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2i64NV(uint program, int location, long x, long y)
		{
			ProgramUniform2i64NVNative(program, location, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform2i64vNVNative(uint program, int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, long*, void>)funcTable[6])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[6])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2i64vNV(uint program, int location, int count, long* value)
		{
			ProgramUniform2i64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2i64vNV(uint program, int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				ProgramUniform2i64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2i64vNV(uint program, int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				ProgramUniform2i64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform2ui64NVNative(uint program, int location, ulong x, ulong y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, ulong, ulong, void>)funcTable[7])(program, location, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, ulong, ulong, void>)funcTable[7])(program, location, x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2ui64NV(uint program, int location, ulong x, ulong y)
		{
			ProgramUniform2ui64NVNative(program, location, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform2ui64vNVNative(uint program, int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, ulong*, void>)funcTable[8])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[8])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2ui64vNV(uint program, int location, int count, ulong* value)
		{
			ProgramUniform2ui64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2ui64vNV(uint program, int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				ProgramUniform2ui64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform2ui64vNV(uint program, int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				ProgramUniform2ui64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform3i64NVNative(uint program, int location, long x, long y, long z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, long, long, long, void>)funcTable[9])(program, location, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, long, long, long, void>)funcTable[9])(program, location, x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3i64NV(uint program, int location, long x, long y, long z)
		{
			ProgramUniform3i64NVNative(program, location, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform3i64vNVNative(uint program, int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, long*, void>)funcTable[10])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[10])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3i64vNV(uint program, int location, int count, long* value)
		{
			ProgramUniform3i64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3i64vNV(uint program, int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				ProgramUniform3i64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3i64vNV(uint program, int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				ProgramUniform3i64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform3ui64NVNative(uint program, int location, ulong x, ulong y, ulong z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, ulong, ulong, ulong, void>)funcTable[11])(program, location, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, ulong, ulong, ulong, void>)funcTable[11])(program, location, x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3ui64NV(uint program, int location, ulong x, ulong y, ulong z)
		{
			ProgramUniform3ui64NVNative(program, location, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform3ui64vNVNative(uint program, int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, ulong*, void>)funcTable[12])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[12])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3ui64vNV(uint program, int location, int count, ulong* value)
		{
			ProgramUniform3ui64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3ui64vNV(uint program, int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				ProgramUniform3ui64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform3ui64vNV(uint program, int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				ProgramUniform3ui64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform4i64NVNative(uint program, int location, long x, long y, long z, long w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, long, long, long, long, void>)funcTable[13])(program, location, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, long, long, long, long, void>)funcTable[13])(program, location, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4i64NV(uint program, int location, long x, long y, long z, long w)
		{
			ProgramUniform4i64NVNative(program, location, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform4i64vNVNative(uint program, int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, long*, void>)funcTable[14])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[14])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4i64vNV(uint program, int location, int count, long* value)
		{
			ProgramUniform4i64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4i64vNV(uint program, int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				ProgramUniform4i64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4i64vNV(uint program, int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				ProgramUniform4i64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform4ui64NVNative(uint program, int location, ulong x, ulong y, ulong z, ulong w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, ulong, ulong, ulong, ulong, void>)funcTable[15])(program, location, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, ulong, ulong, ulong, ulong, void>)funcTable[15])(program, location, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4ui64NV(uint program, int location, ulong x, ulong y, ulong z, ulong w)
		{
			ProgramUniform4ui64NVNative(program, location, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniform4ui64vNVNative(uint program, int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, ulong*, void>)funcTable[16])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[16])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4ui64vNV(uint program, int location, int count, ulong* value)
		{
			ProgramUniform4ui64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4ui64vNV(uint program, int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				ProgramUniform4ui64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void ProgramUniform4ui64vNV(uint program, int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				ProgramUniform4ui64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform1i64NVNative(int location, long x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, long, void>)funcTable[17])(location, x);
			#else
			((delegate* unmanaged[Cdecl]<int, long, void>)funcTable[17])(location, x);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1i64NV(int location, long x)
		{
			Uniform1i64NVNative(location, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform1i64vNVNative(int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, long*, void>)funcTable[18])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[18])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1i64vNV(int location, int count, long* value)
		{
			Uniform1i64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1i64vNV(int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				Uniform1i64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1i64vNV(int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				Uniform1i64vNVNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform1ui64NVNative(int location, ulong x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, ulong, void>)funcTable[19])(location, x);
			#else
			((delegate* unmanaged[Cdecl]<int, ulong, void>)funcTable[19])(location, x);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1ui64NV(int location, ulong x)
		{
			Uniform1ui64NVNative(location, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform1ui64vNVNative(int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)funcTable[20])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[20])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1ui64vNV(int location, int count, ulong* value)
		{
			Uniform1ui64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1ui64vNV(int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				Uniform1ui64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform1ui64vNV(int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				Uniform1ui64vNVNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform2i64NVNative(int location, long x, long y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, long, long, void>)funcTable[21])(location, x, y);
			#else
			((delegate* unmanaged[Cdecl]<int, long, long, void>)funcTable[21])(location, x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2i64NV(int location, long x, long y)
		{
			Uniform2i64NVNative(location, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform2i64vNVNative(int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, long*, void>)funcTable[22])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[22])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2i64vNV(int location, int count, long* value)
		{
			Uniform2i64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2i64vNV(int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				Uniform2i64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2i64vNV(int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				Uniform2i64vNVNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform2ui64NVNative(int location, ulong x, ulong y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, ulong, ulong, void>)funcTable[23])(location, x, y);
			#else
			((delegate* unmanaged[Cdecl]<int, ulong, ulong, void>)funcTable[23])(location, x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2ui64NV(int location, ulong x, ulong y)
		{
			Uniform2ui64NVNative(location, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform2ui64vNVNative(int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)funcTable[24])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[24])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2ui64vNV(int location, int count, ulong* value)
		{
			Uniform2ui64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2ui64vNV(int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				Uniform2ui64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform2ui64vNV(int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				Uniform2ui64vNVNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform3i64NVNative(int location, long x, long y, long z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, long, long, long, void>)funcTable[25])(location, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<int, long, long, long, void>)funcTable[25])(location, x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3i64NV(int location, long x, long y, long z)
		{
			Uniform3i64NVNative(location, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform3i64vNVNative(int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, long*, void>)funcTable[26])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[26])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3i64vNV(int location, int count, long* value)
		{
			Uniform3i64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3i64vNV(int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				Uniform3i64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3i64vNV(int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				Uniform3i64vNVNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform3ui64NVNative(int location, ulong x, ulong y, ulong z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, ulong, ulong, ulong, void>)funcTable[27])(location, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<int, ulong, ulong, ulong, void>)funcTable[27])(location, x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3ui64NV(int location, ulong x, ulong y, ulong z)
		{
			Uniform3ui64NVNative(location, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform3ui64vNVNative(int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)funcTable[28])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[28])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3ui64vNV(int location, int count, ulong* value)
		{
			Uniform3ui64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3ui64vNV(int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				Uniform3ui64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform3ui64vNV(int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				Uniform3ui64vNVNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform4i64NVNative(int location, long x, long y, long z, long w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, long, long, long, long, void>)funcTable[29])(location, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<int, long, long, long, long, void>)funcTable[29])(location, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4i64NV(int location, long x, long y, long z, long w)
		{
			Uniform4i64NVNative(location, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform4i64vNVNative(int location, int count, long* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, long*, void>)funcTable[30])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[30])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4i64vNV(int location, int count, long* value)
		{
			Uniform4i64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4i64vNV(int location, int count, Span<long> value)
		{
			fixed (long* pvalue0 = value)
			{
				Uniform4i64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4i64vNV(int location, int count, ref long value)
		{
			fixed (long* pvalue0 = &value)
			{
				Uniform4i64vNVNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform4ui64NVNative(int location, ulong x, ulong y, ulong z, ulong w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, ulong, ulong, ulong, ulong, void>)funcTable[31])(location, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<int, ulong, ulong, ulong, ulong, void>)funcTable[31])(location, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4ui64NV(int location, ulong x, ulong y, ulong z, ulong w)
		{
			Uniform4ui64NVNative(location, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniform4ui64vNVNative(int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)funcTable[32])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[32])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4ui64vNV(int location, int count, ulong* value)
		{
			Uniform4ui64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4ui64vNV(int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				Uniform4ui64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_shader5<br/>GL_AMD_gpu_shader_int64</remarks>
		public void Uniform4ui64vNV(int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				Uniform4ui64vNVNative(location, count, pvalue0);
			}
		}

	}
}
