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
	public static unsafe partial class GLARBSamplerObjects
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindSamplerNative(uint unit, uint sampler)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(unit, sampler);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(unit, sampler);
			#endif
		}

		/// <summary>
		/// Bind a named sampler to a texturing target
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void BindSampler(uint unit, uint sampler)
		{
			BindSamplerNative(unit, sampler);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteSamplersNative(int count, uint* samplers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(count, samplers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(count, (nint)samplers);
			#endif
		}

		/// <summary>
		/// Delete named sampler objects
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void DeleteSamplers(int count, uint* samplers)
		{
			DeleteSamplersNative(count, samplers);
		}

		/// <summary>
		/// Delete named sampler objects
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void DeleteSampler(uint sampler)
		{
			DeleteSamplersNative(1, &sampler);
		}

		/// <summary>
		/// Delete named sampler objects
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void DeleteSamplers(int count, Span<uint> samplers)
		{
			fixed (uint* psamplers0 = samplers)
			{
				DeleteSamplersNative(count, psamplers0);
			}
		}

		/// <summary>
		/// Delete named sampler objects
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void DeleteSamplers(int count, ref uint samplers)
		{
			fixed (uint* psamplers0 = &samplers)
			{
				DeleteSamplersNative(count, psamplers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenSamplersNative(int count, uint* samplers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(count, samplers);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(count, (nint)samplers);
			#endif
		}

		/// <summary>
		/// Generate sampler object names
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GenSamplers(int count, uint* samplers)
		{
			GenSamplersNative(count, samplers);
		}

		/// <summary>
		/// Generate sampler object names
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static uint GenSampler()
		{
			uint result;
			GenSamplersNative(1, &result);
			return result;
		}

		/// <summary>
		/// Generate sampler object names
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GenSamplers(int count, Span<uint> samplers)
		{
			fixed (uint* psamplers0 = samplers)
			{
				GenSamplersNative(count, psamplers0);
			}
		}

		/// <summary>
		/// Generate sampler object names
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GenSamplers(int count, ref uint samplers)
		{
			fixed (uint* psamplers0 = &samplers)
			{
				GenSamplersNative(count, psamplers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetSamplerParameterIivNative(uint sampler, GLSamplerParameterI pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, int*, void>)funcTable[3])(sampler, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, nint, void>)funcTable[3])(sampler, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void GetSamplerParameterIiv(uint sampler, GLSamplerParameterI pname, int* @params)
		{
			GetSamplerParameterIivNative(sampler, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void GetSamplerParameterIiv(uint sampler, GLSamplerParameterI pname, out int @params)
		{
			int pparams;
			GetSamplerParameterIivNative(sampler, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void GetSamplerParameterIiv(uint sampler, GLSamplerParameterI pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetSamplerParameterIivNative(sampler, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetSamplerParameterIuivNative(uint sampler, GLSamplerParameterI pname, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, uint*, void>)funcTable[4])(sampler, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, nint, void>)funcTable[4])(sampler, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void GetSamplerParameterIuiv(uint sampler, GLSamplerParameterI pname, uint* @params)
		{
			GetSamplerParameterIuivNative(sampler, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void GetSamplerParameterIuiv(uint sampler, GLSamplerParameterI pname, out uint @params)
		{
			uint pparams;
			GetSamplerParameterIuivNative(sampler, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void GetSamplerParameterIuiv(uint sampler, GLSamplerParameterI pname, Span<uint> @params)
		{
			fixed (uint* pparams = @params)
			{
				GetSamplerParameterIuivNative(sampler, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetSamplerParameterfvNative(uint sampler, GLSamplerParameterF pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterF, float*, void>)funcTable[5])(sampler, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterF, nint, void>)funcTable[5])(sampler, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GetSamplerParameterfv(uint sampler, GLSamplerParameterF pname, float* @params)
		{
			GetSamplerParameterfvNative(sampler, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GetSamplerParameterfv(uint sampler, GLSamplerParameterF pname, out float @params)
		{
			float pparams;
			GetSamplerParameterfvNative(sampler, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GetSamplerParameterfv(uint sampler, GLSamplerParameterF pname, Span<float> @params)
		{
			fixed (float* pparams = @params)
			{
				GetSamplerParameterfvNative(sampler, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetSamplerParameterivNative(uint sampler, GLSamplerParameterI pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, int*, void>)funcTable[6])(sampler, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, nint, void>)funcTable[6])(sampler, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GetSamplerParameteriv(uint sampler, GLSamplerParameterI pname, int* @params)
		{
			GetSamplerParameterivNative(sampler, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GetSamplerParameteriv(uint sampler, GLSamplerParameterI pname, out int @params)
		{
			int pparams;
			GetSamplerParameterivNative(sampler, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void GetSamplerParameteriv(uint sampler, GLSamplerParameterI pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetSamplerParameterivNative(sampler, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsSamplerNative(uint sampler)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[7])(sampler);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[7])(sampler);
			#endif
		}

		/// <summary>
		/// Determine if a name corresponds to a sampler object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static bool IsSampler(uint sampler)
		{
			byte ret = IsSamplerNative(sampler);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SamplerParameterIivNative(uint sampler, GLSamplerParameterI pname, int* param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, int*, void>)funcTable[8])(sampler, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, nint, void>)funcTable[8])(sampler, pname, (nint)param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void SamplerParameterIiv(uint sampler, GLSamplerParameterI pname, int* param)
		{
			SamplerParameterIivNative(sampler, pname, param);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void SamplerParameterIiv(uint sampler, GLSamplerParameterI pname, out int param)
		{
			int pparam;
			SamplerParameterIivNative(sampler, pname, &pparam);
			param = pparam;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SamplerParameterIuivNative(uint sampler, GLSamplerParameterI pname, uint* param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, uint*, void>)funcTable[9])(sampler, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, nint, void>)funcTable[9])(sampler, pname, (nint)param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void SamplerParameterIuiv(uint sampler, GLSamplerParameterI pname, uint* param)
		{
			SamplerParameterIuivNative(sampler, pname, param);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects</remarks>
		public static void SamplerParameterIuiv(uint sampler, GLSamplerParameterI pname, out uint param)
		{
			uint pparam;
			SamplerParameterIuivNative(sampler, pname, &pparam);
			param = pparam;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SamplerParameterfNative(uint sampler, GLSamplerParameterF pname, float param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterF, float, void>)funcTable[10])(sampler, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterF, float, void>)funcTable[10])(sampler, pname, param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void SamplerParameterf(uint sampler, GLSamplerParameterF pname, float param)
		{
			SamplerParameterfNative(sampler, pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SamplerParameterfvNative(uint sampler, GLSamplerParameterF pname, float* param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterF, float*, void>)funcTable[11])(sampler, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterF, nint, void>)funcTable[11])(sampler, pname, (nint)param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void SamplerParameterfv(uint sampler, GLSamplerParameterF pname, float* param)
		{
			SamplerParameterfvNative(sampler, pname, param);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void SamplerParameterfv(uint sampler, GLSamplerParameterF pname, out float param)
		{
			float pparam;
			SamplerParameterfvNative(sampler, pname, &pparam);
			param = pparam;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SamplerParameteriNative(uint sampler, GLSamplerParameterI pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, int, void>)funcTable[12])(sampler, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, int, void>)funcTable[12])(sampler, pname, param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void SamplerParameteri(uint sampler, GLSamplerParameterI pname, int param)
		{
			SamplerParameteriNative(sampler, pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SamplerParameterivNative(uint sampler, GLSamplerParameterI pname, int* param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, int*, void>)funcTable[13])(sampler, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSamplerParameterI, nint, void>)funcTable[13])(sampler, pname, (nint)param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void SamplerParameteriv(uint sampler, GLSamplerParameterI pname, int* param)
		{
			SamplerParameterivNative(sampler, pname, param);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sampler_objects<br/>GL_MESA_sampler_objects</remarks>
		public static void SamplerParameteriv(uint sampler, GLSamplerParameterI pname, out int param)
		{
			int pparam;
			SamplerParameterivNative(sampler, pname, &pparam);
			param = pparam;
		}

	}
}
