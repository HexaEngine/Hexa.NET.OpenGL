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
	public static unsafe partial class GLARBFragmentProgram
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindProgramARBNative(GLProgramTarget target, uint program)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, void>)funcTable[0])(target, program);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, void>)funcTable[0])(target, program);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void BindProgramARB(GLProgramTarget target, uint program)
		{
			BindProgramARBNative(target, program);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteProgramsARBNative(int n, uint* programs)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(n, programs);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)programs);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void DeleteProgramsARB(int n, uint* programs)
		{
			DeleteProgramsARBNative(n, programs);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void DeleteProgramsAR(uint program)
		{
			DeleteProgramsARBNative(1, &program);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void DeleteProgramsARB(int n, Span<uint> programs)
		{
			fixed (uint* pprograms0 = programs)
			{
				DeleteProgramsARBNative(n, pprograms0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void DeleteProgramsARB(int n, ref uint programs)
		{
			fixed (uint* pprograms0 = &programs)
			{
				DeleteProgramsARBNative(n, pprograms0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenProgramsARBNative(int n, uint* programs)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(n, programs);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(n, (nint)programs);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GenProgramsARB(int n, uint* programs)
		{
			GenProgramsARBNative(n, programs);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static uint GenProgramsAR()
		{
			uint result;
			GenProgramsARBNative(1, &result);
			return result;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GenProgramsARB(int n, Span<uint> programs)
		{
			fixed (uint* pprograms0 = programs)
			{
				GenProgramsARBNative(n, pprograms0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GenProgramsARB(int n, ref uint programs)
		{
			fixed (uint* pprograms0 = &programs)
			{
				GenProgramsARBNative(n, pprograms0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramEnvParameterdvARBNative(GLProgramTarget target, uint index, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double*, void>)funcTable[3])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[3])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramEnvParameterdvARB(GLProgramTarget target, uint index, double* @params)
		{
			GetProgramEnvParameterdvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramEnvParameterdvARB(GLProgramTarget target, uint index, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				GetProgramEnvParameterdvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramEnvParameterdvARB(GLProgramTarget target, uint index, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				GetProgramEnvParameterdvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramEnvParameterfvARBNative(GLProgramTarget target, uint index, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float*, void>)funcTable[4])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[4])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramEnvParameterfvARB(GLProgramTarget target, uint index, float* @params)
		{
			GetProgramEnvParameterfvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramEnvParameterfvARB(GLProgramTarget target, uint index, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				GetProgramEnvParameterfvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramEnvParameterfvARB(GLProgramTarget target, uint index, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetProgramEnvParameterfvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramLocalParameterdvARBNative(GLProgramTarget target, uint index, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double*, void>)funcTable[5])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[5])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramLocalParameterdvARB(GLProgramTarget target, uint index, double* @params)
		{
			GetProgramLocalParameterdvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramLocalParameterdvARB(GLProgramTarget target, uint index, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				GetProgramLocalParameterdvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramLocalParameterdvARB(GLProgramTarget target, uint index, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				GetProgramLocalParameterdvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramLocalParameterfvARBNative(GLProgramTarget target, uint index, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float*, void>)funcTable[6])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[6])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramLocalParameterfvARB(GLProgramTarget target, uint index, float* @params)
		{
			GetProgramLocalParameterfvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramLocalParameterfvARB(GLProgramTarget target, uint index, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				GetProgramLocalParameterfvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramLocalParameterfvARB(GLProgramTarget target, uint index, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetProgramLocalParameterfvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramStringARBNative(GLProgramTarget target, GLProgramStringProperty pname, void* str)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, GLProgramStringProperty, void*, void>)funcTable[7])(target, pname, str);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, GLProgramStringProperty, nint, void>)funcTable[7])(target, pname, (nint)str);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramStringARB(GLProgramTarget target, GLProgramStringProperty pname, void* str)
		{
			GetProgramStringARBNative(target, pname, str);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramStringARB(GLProgramTarget target, GLProgramStringProperty pname, nint str)
		{
			GetProgramStringARBNative(target, pname, (void*)str);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramStringARB<TStr>(GLProgramTarget target, GLProgramStringProperty pname, Span<TStr> str) where TStr : unmanaged
		{
			fixed (TStr* pstr0 = str)
			{
				GetProgramStringARBNative(target, pname, pstr0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramivARBNative(GLProgramTarget target, GLProgramPropertyARB pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, GLProgramPropertyARB, int*, void>)funcTable[8])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, GLProgramPropertyARB, nint, void>)funcTable[8])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramivARB(GLProgramTarget target, GLProgramPropertyARB pname, int* @params)
		{
			GetProgramivARBNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramivARB(GLProgramTarget target, GLProgramPropertyARB pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetProgramivARBNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void GetProgramivARB(GLProgramTarget target, GLProgramPropertyARB pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetProgramivARBNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsProgramARBNative(uint program)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[9])(program);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[9])(program);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static bool IsProgramARB(uint program)
		{
			byte ret = IsProgramARBNative(program);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramEnvParameter4dARBNative(GLProgramTarget target, uint index, double x, double y, double z, double w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double, double, double, double, void>)funcTable[10])(target, index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double, double, double, double, void>)funcTable[10])(target, index, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4dARB(GLProgramTarget target, uint index, double x, double y, double z, double w)
		{
			ProgramEnvParameter4dARBNative(target, index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramEnvParameter4dvARBNative(GLProgramTarget target, uint index, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double*, void>)funcTable[11])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[11])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4dvARB(GLProgramTarget target, uint index, double* @params)
		{
			ProgramEnvParameter4dvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4dvARB(GLProgramTarget target, uint index, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				ProgramEnvParameter4dvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4dvARB(GLProgramTarget target, uint index, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				ProgramEnvParameter4dvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramEnvParameter4fARBNative(GLProgramTarget target, uint index, float x, float y, float z, float w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float, float, float, float, void>)funcTable[12])(target, index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float, float, float, float, void>)funcTable[12])(target, index, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4fARB(GLProgramTarget target, uint index, float x, float y, float z, float w)
		{
			ProgramEnvParameter4fARBNative(target, index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramEnvParameter4fvARBNative(GLProgramTarget target, uint index, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float*, void>)funcTable[13])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[13])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4fvARB(GLProgramTarget target, uint index, float* @params)
		{
			ProgramEnvParameter4fvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4fvARB(GLProgramTarget target, uint index, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				ProgramEnvParameter4fvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramEnvParameter4fvARB(GLProgramTarget target, uint index, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				ProgramEnvParameter4fvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramLocalParameter4dARBNative(GLProgramTarget target, uint index, double x, double y, double z, double w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double, double, double, double, void>)funcTable[14])(target, index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double, double, double, double, void>)funcTable[14])(target, index, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4dARB(GLProgramTarget target, uint index, double x, double y, double z, double w)
		{
			ProgramLocalParameter4dARBNative(target, index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramLocalParameter4dvARBNative(GLProgramTarget target, uint index, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, double*, void>)funcTable[15])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[15])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4dvARB(GLProgramTarget target, uint index, double* @params)
		{
			ProgramLocalParameter4dvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4dvARB(GLProgramTarget target, uint index, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				ProgramLocalParameter4dvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4dvARB(GLProgramTarget target, uint index, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				ProgramLocalParameter4dvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramLocalParameter4fARBNative(GLProgramTarget target, uint index, float x, float y, float z, float w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float, float, float, float, void>)funcTable[16])(target, index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float, float, float, float, void>)funcTable[16])(target, index, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4fARB(GLProgramTarget target, uint index, float x, float y, float z, float w)
		{
			ProgramLocalParameter4fARBNative(target, index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramLocalParameter4fvARBNative(GLProgramTarget target, uint index, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, float*, void>)funcTable[17])(target, index, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, nint, void>)funcTable[17])(target, index, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4fvARB(GLProgramTarget target, uint index, float* @params)
		{
			ProgramLocalParameter4fvARBNative(target, index, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4fvARB(GLProgramTarget target, uint index, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				ProgramLocalParameter4fvARBNative(target, index, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramLocalParameter4fvARB(GLProgramTarget target, uint index, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				ProgramLocalParameter4fvARBNative(target, index, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramStringARBNative(GLProgramTarget target, GLProgramFormat format, int len, void* str)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, GLProgramFormat, int, void*, void>)funcTable[18])(target, format, len, str);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, GLProgramFormat, int, nint, void>)funcTable[18])(target, format, len, (nint)str);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramStringARB(GLProgramTarget target, GLProgramFormat format, int len, void* str)
		{
			ProgramStringARBNative(target, format, len, str);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramStringARB(GLProgramTarget target, GLProgramFormat format, int len, nint str)
		{
			ProgramStringARBNative(target, format, len, (void*)str);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_fragment_program<br/>GL_ARB_vertex_program</remarks>
		public static void ProgramStringARB<TStr>(GLProgramTarget target, GLProgramFormat format, int len, Span<TStr> str) where TStr : unmanaged
		{
			fixed (TStr* pstr0 = str)
			{
				ProgramStringARBNative(target, format, len, pstr0);
			}
		}

	}
}
