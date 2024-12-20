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

namespace Hexa.NET.OpenGL.NV
{
	public unsafe partial class GLNVShaderBufferLoad
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetBufferParameterui64vNVNative(GLBufferTargetARB target, GLEnum pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, GLEnum, ulong*, void>)funcTable[0])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, GLEnum, nint, void>)funcTable[0])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetBufferParameterui64vNV(GLBufferTargetARB target, GLEnum pname, ulong* @params)
		{
			GetBufferParameterui64vNVNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetBufferParameterui64vNV(GLBufferTargetARB target, GLEnum pname, Span<ulong> @params)
		{
			fixed (ulong* pparams0 = @params)
			{
				GetBufferParameterui64vNVNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetBufferParameterui64vNV(GLBufferTargetARB target, GLEnum pname, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				GetBufferParameterui64vNVNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetIntegerui64vNVNative(GLEnum value, ulong* result)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, ulong*, void>)funcTable[1])(value, result);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, nint, void>)funcTable[1])(value, (nint)result);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetIntegerui64vNV(GLEnum value, ulong* result)
		{
			GetIntegerui64vNVNative(value, result);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetIntegerui64vNV(GLEnum value, Span<ulong> result)
		{
			fixed (ulong* presult0 = result)
			{
				GetIntegerui64vNVNative(value, presult0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetIntegerui64vNV(GLEnum value, ref ulong result)
		{
			fixed (ulong* presult0 = &result)
			{
				GetIntegerui64vNVNative(value, presult0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetNamedBufferParameterui64vNVNative(uint buffer, GLBufferPNameARB pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBufferPNameARB, ulong*, void>)funcTable[2])(buffer, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBufferPNameARB, nint, void>)funcTable[2])(buffer, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetNamedBufferParameterui64vNV(uint buffer, GLBufferPNameARB pname, ulong* @params)
		{
			GetNamedBufferParameterui64vNVNative(buffer, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetNamedBufferParameterui64vNV(uint buffer, GLBufferPNameARB pname, Span<ulong> @params)
		{
			fixed (ulong* pparams0 = @params)
			{
				GetNamedBufferParameterui64vNVNative(buffer, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void GetNamedBufferParameterui64vNV(uint buffer, GLBufferPNameARB pname, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				GetNamedBufferParameterui64vNVNative(buffer, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetUniformui64vNVNative(uint program, int location, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, ulong*, void>)funcTable[3])(program, location, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[3])(program, location, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load<br/>GL_AMD_gpu_shader_int64</remarks>
		public void GetUniformui64vNV(uint program, int location, ulong* @params)
		{
			GetUniformui64vNVNative(program, location, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load<br/>GL_AMD_gpu_shader_int64</remarks>
		public void GetUniformui64vNV(uint program, int location, Span<ulong> @params)
		{
			fixed (ulong* pparams0 = @params)
			{
				GetUniformui64vNVNative(program, location, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load<br/>GL_AMD_gpu_shader_int64</remarks>
		public void GetUniformui64vNV(uint program, int location, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				GetUniformui64vNVNative(program, location, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsBufferResidentNVNative(GLEnum target)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum, byte>)funcTable[4])(target);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<GLEnum, byte>)funcTable[4])(target);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public bool IsBufferResidentNV(GLEnum target)
		{
			byte ret = IsBufferResidentNVNative(target);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsNamedBufferResidentNVNative(uint buffer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[5])(buffer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[5])(buffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public bool IsNamedBufferResidentNV(uint buffer)
		{
			byte ret = IsNamedBufferResidentNVNative(buffer);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MakeBufferNonResidentNVNative(GLEnum target)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[6])(target);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[6])(target);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void MakeBufferNonResidentNV(GLEnum target)
		{
			MakeBufferNonResidentNVNative(target);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MakeBufferResidentNVNative(GLEnum target, GLEnum access)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, void>)funcTable[7])(target, access);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, void>)funcTable[7])(target, access);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void MakeBufferResidentNV(GLEnum target, GLEnum access)
		{
			MakeBufferResidentNVNative(target, access);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MakeNamedBufferNonResidentNVNative(uint buffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[8])(buffer);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[8])(buffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void MakeNamedBufferNonResidentNV(uint buffer)
		{
			MakeNamedBufferNonResidentNVNative(buffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MakeNamedBufferResidentNVNative(uint buffer, GLEnum access)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[9])(buffer, access);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[9])(buffer, access);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void MakeNamedBufferResidentNV(uint buffer, GLEnum access)
		{
			MakeNamedBufferResidentNVNative(buffer, access);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniformui64NVNative(uint program, int location, ulong value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, ulong, void>)funcTable[10])(program, location, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, ulong, void>)funcTable[10])(program, location, value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void ProgramUniformui64NV(uint program, int location, ulong value)
		{
			ProgramUniformui64NVNative(program, location, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ProgramUniformui64vNVNative(uint program, int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, ulong*, void>)funcTable[11])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[11])(program, location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void ProgramUniformui64vNV(uint program, int location, int count, ulong* value)
		{
			ProgramUniformui64vNVNative(program, location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void ProgramUniformui64vNV(uint program, int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				ProgramUniformui64vNVNative(program, location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void ProgramUniformui64vNV(uint program, int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				ProgramUniformui64vNVNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniformui64NVNative(int location, ulong value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, ulong, void>)funcTable[12])(location, value);
			#else
			((delegate* unmanaged[Cdecl]<int, ulong, void>)funcTable[12])(location, value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void Uniformui64NV(int location, ulong value)
		{
			Uniformui64NVNative(location, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Uniformui64vNVNative(int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)funcTable[13])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[13])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void Uniformui64vNV(int location, int count, ulong* value)
		{
			Uniformui64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void Uniformui64vNV(int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				Uniformui64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_shader_buffer_load</remarks>
		public void Uniformui64vNV(int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				Uniformui64vNVNative(location, count, pvalue0);
			}
		}

	}
}
