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
	public static unsafe partial class GLNVBindlessTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong GetImageHandleNVNative(uint texture, int level, bool layered, int layer, GLPixelFormat format)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, int, byte, int, GLPixelFormat, ulong>)funcTable[0])(texture, level, *((byte*)(&layered)), layer, format);
			#else
			return (ulong)((delegate* unmanaged[Cdecl]<uint, int, byte, int, GLPixelFormat, ulong>)funcTable[0])(texture, level, *((byte*)(&layered)), layer, format);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static ulong GetImageHandleNV(uint texture, int level, bool layered, int layer, GLPixelFormat format)
		{
			ulong ret = GetImageHandleNVNative(texture, level, layered, layer, format);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong GetTextureHandleNVNative(uint texture)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, ulong>)funcTable[1])(texture);
			#else
			return (ulong)((delegate* unmanaged[Cdecl]<uint, ulong>)funcTable[1])(texture);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static ulong GetTextureHandleNV(uint texture)
		{
			ulong ret = GetTextureHandleNVNative(texture);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong GetTextureSamplerHandleNVNative(uint texture, uint sampler)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, uint, ulong>)funcTable[2])(texture, sampler);
			#else
			return (ulong)((delegate* unmanaged[Cdecl]<uint, uint, ulong>)funcTable[2])(texture, sampler);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static ulong GetTextureSamplerHandleNV(uint texture, uint sampler)
		{
			ulong ret = GetTextureSamplerHandleNVNative(texture, sampler);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsImageHandleResidentNVNative(ulong handle)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ulong, byte>)funcTable[3])(handle);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<ulong, byte>)funcTable[3])(handle);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static bool IsImageHandleResidentNV(ulong handle)
		{
			byte ret = IsImageHandleResidentNVNative(handle);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsTextureHandleResidentNVNative(ulong handle)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ulong, byte>)funcTable[4])(handle);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<ulong, byte>)funcTable[4])(handle);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static bool IsTextureHandleResidentNV(ulong handle)
		{
			byte ret = IsTextureHandleResidentNVNative(handle);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MakeImageHandleNonResidentNVNative(ulong handle)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ulong, void>)funcTable[5])(handle);
			#else
			((delegate* unmanaged[Cdecl]<ulong, void>)funcTable[5])(handle);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void MakeImageHandleNonResidentNV(ulong handle)
		{
			MakeImageHandleNonResidentNVNative(handle);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MakeImageHandleResidentNVNative(ulong handle, GLEnum access)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ulong, GLEnum, void>)funcTable[6])(handle, access);
			#else
			((delegate* unmanaged[Cdecl]<ulong, GLEnum, void>)funcTable[6])(handle, access);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void MakeImageHandleResidentNV(ulong handle, GLEnum access)
		{
			MakeImageHandleResidentNVNative(handle, access);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MakeTextureHandleNonResidentNVNative(ulong handle)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ulong, void>)funcTable[7])(handle);
			#else
			((delegate* unmanaged[Cdecl]<ulong, void>)funcTable[7])(handle);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void MakeTextureHandleNonResidentNV(ulong handle)
		{
			MakeTextureHandleNonResidentNVNative(handle);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MakeTextureHandleResidentNVNative(ulong handle)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ulong, void>)funcTable[8])(handle);
			#else
			((delegate* unmanaged[Cdecl]<ulong, void>)funcTable[8])(handle);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void MakeTextureHandleResidentNV(ulong handle)
		{
			MakeTextureHandleResidentNVNative(handle);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformHandleui64NVNative(uint program, int location, ulong value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, ulong, void>)funcTable[9])(program, location, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, ulong, void>)funcTable[9])(program, location, value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void ProgramUniformHandleui64NV(uint program, int location, ulong value)
		{
			ProgramUniformHandleui64NVNative(program, location, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformHandleui64vNVNative(uint program, int location, int count, ulong* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, ulong*, void>)funcTable[10])(program, location, count, values);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[10])(program, location, count, (nint)values);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void ProgramUniformHandleui64vNV(uint program, int location, int count, ulong* values)
		{
			ProgramUniformHandleui64vNVNative(program, location, count, values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void ProgramUniformHandleui64vNV(uint program, int location, int count, Span<ulong> values)
		{
			fixed (ulong* pvalues0 = values)
			{
				ProgramUniformHandleui64vNVNative(program, location, count, pvalues0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void ProgramUniformHandleui64vNV(uint program, int location, int count, ref ulong values)
		{
			fixed (ulong* pvalues0 = &values)
			{
				ProgramUniformHandleui64vNVNative(program, location, count, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformHandleui64NVNative(int location, ulong value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, ulong, void>)funcTable[11])(location, value);
			#else
			((delegate* unmanaged[Cdecl]<int, ulong, void>)funcTable[11])(location, value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void UniformHandleui64NV(int location, ulong value)
		{
			UniformHandleui64NVNative(location, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformHandleui64vNVNative(int location, int count, ulong* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, ulong*, void>)funcTable[12])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[12])(location, count, (nint)value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void UniformHandleui64vNV(int location, int count, ulong* value)
		{
			UniformHandleui64vNVNative(location, count, value);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void UniformHandleui64vNV(int location, int count, Span<ulong> value)
		{
			fixed (ulong* pvalue0 = value)
			{
				UniformHandleui64vNVNative(location, count, pvalue0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_bindless_texture</remarks>
		public static void UniformHandleui64vNV(int location, int count, ref ulong value)
		{
			fixed (ulong* pvalue0 = &value)
			{
				UniformHandleui64vNVNative(location, count, pvalue0);
			}
		}

	}
}
