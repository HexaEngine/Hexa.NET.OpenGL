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

namespace Hexa.NET.OpenGL.KHR
{
	public static unsafe partial class GLKHRRobustness
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum GetGraphicsResetStatusNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum>)funcTable[0])();
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLEnum>)funcTable[0])();
			#endif
		}

		/// <summary>
		/// Check if the rendering context has not been lost due to software or hardware issues
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static GLEnum GetGraphicsResetStatus()
		{
			GLEnum ret = GetGraphicsResetStatusNative();
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum GetGraphicsResetStatusKHRNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum>)funcTable[1])();
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLEnum>)funcTable[1])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static GLEnum GetGraphicsResetStatusKHR()
		{
			GLEnum ret = GetGraphicsResetStatusKHRNative();
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetnUniformfvNative(uint program, int location, int bufSize, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, float*, void>)funcTable[2])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[2])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformfv(uint program, int location, int bufSize, float* @params)
		{
			GetnUniformfvNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformfv(uint program, int location, int bufSize, out float @params)
		{
			float pparams;
			GetnUniformfvNative(program, location, bufSize, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformfv(uint program, int location, int bufSize, Span<float> @params)
		{
			fixed (float* pparams = @params)
			{
				GetnUniformfvNative(program, location, bufSize, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetnUniformfvKHRNative(uint program, int location, int bufSize, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, float*, void>)funcTable[3])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[3])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformfvKHR(uint program, int location, int bufSize, float* @params)
		{
			GetnUniformfvKHRNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformfvKHR(uint program, int location, int bufSize, out float @params)
		{
			float pparams;
			GetnUniformfvKHRNative(program, location, bufSize, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformfvKHR(uint program, int location, int bufSize, Span<float> @params)
		{
			fixed (float* pparams = @params)
			{
				GetnUniformfvKHRNative(program, location, bufSize, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetnUniformivNative(uint program, int location, int bufSize, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int*, void>)funcTable[4])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[4])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformiv(uint program, int location, int bufSize, int* @params)
		{
			GetnUniformivNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformiv(uint program, int location, int bufSize, out int @params)
		{
			int pparams;
			GetnUniformivNative(program, location, bufSize, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformiv(uint program, int location, int bufSize, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetnUniformivNative(program, location, bufSize, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetnUniformivKHRNative(uint program, int location, int bufSize, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int*, void>)funcTable[5])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[5])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformivKHR(uint program, int location, int bufSize, int* @params)
		{
			GetnUniformivKHRNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformivKHR(uint program, int location, int bufSize, out int @params)
		{
			int pparams;
			GetnUniformivKHRNative(program, location, bufSize, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformivKHR(uint program, int location, int bufSize, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetnUniformivKHRNative(program, location, bufSize, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetnUniformuivNative(uint program, int location, int bufSize, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, uint*, void>)funcTable[6])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[6])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformuiv(uint program, int location, int bufSize, uint* @params)
		{
			GetnUniformuivNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformuiv(uint program, int location, int bufSize, out uint @params)
		{
			uint pparams;
			GetnUniformuivNative(program, location, bufSize, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformuiv(uint program, int location, int bufSize, Span<uint> @params)
		{
			fixed (uint* pparams = @params)
			{
				GetnUniformuivNative(program, location, bufSize, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetnUniformuivKHRNative(uint program, int location, int bufSize, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, uint*, void>)funcTable[7])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[7])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformuivKHR(uint program, int location, int bufSize, uint* @params)
		{
			GetnUniformuivKHRNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformuivKHR(uint program, int location, int bufSize, out uint @params)
		{
			uint pparams;
			GetnUniformuivKHRNative(program, location, bufSize, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void GetnUniformuivKHR(uint program, int location, int bufSize, Span<uint> @params)
		{
			fixed (uint* pparams = @params)
			{
				GetnUniformuivKHRNative(program, location, bufSize, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ReadnPixelsNative(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[8])(x, y, width, height, format, type, bufSize, data);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[8])(x, y, width, height, format, type, bufSize, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void ReadnPixels(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, void* data)
		{
			ReadnPixelsNative(x, y, width, height, format, type, bufSize, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void ReadnPixels(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, nint data)
		{
			ReadnPixelsNative(x, y, width, height, format, type, bufSize, (void*)data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.5 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void ReadnPixels<TData>(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				ReadnPixelsNative(x, y, width, height, format, type, bufSize, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ReadnPixelsKHRNative(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[9])(x, y, width, height, format, type, bufSize, data);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[9])(x, y, width, height, format, type, bufSize, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void ReadnPixelsKHR(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, void* data)
		{
			ReadnPixelsKHRNative(x, y, width, height, format, type, bufSize, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void ReadnPixelsKHR(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, nint data)
		{
			ReadnPixelsKHRNative(x, y, width, height, format, type, bufSize, (void*)data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_KHR_robustness</remarks>
		public static void ReadnPixelsKHR<TData>(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				ReadnPixelsKHRNative(x, y, width, height, format, type, bufSize, pdata0);
			}
		}

	}
}
