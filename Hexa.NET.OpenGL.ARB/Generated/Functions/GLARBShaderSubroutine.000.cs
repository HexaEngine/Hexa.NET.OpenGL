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
	public static unsafe partial class GLARBShaderSubroutine
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetActiveSubroutineNameNative(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, uint, int, int*, byte*, void>)funcTable[0])(program, shadertype, index, bufSize, length, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, uint, int, nint, nint, void>)funcTable[0])(program, shadertype, index, bufSize, (nint)length, (nint)name);
			#endif
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, byte* name)
		{
			GetActiveSubroutineNameNative(program, shadertype, index, bufSize, length, name);
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, Span<int> length, byte* name)
		{
			fixed (int* plength0 = length)
			{
				GetActiveSubroutineNameNative(program, shadertype, index, bufSize, plength0, name);
			}
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, ref int length, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				GetActiveSubroutineNameNative(program, shadertype, index, bufSize, plength0, name);
			}
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetActiveSubroutineNameNative(program, shadertype, index, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				GetActiveSubroutineNameNative(program, shadertype, index, bufSize, length, pname0);
			}
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				GetActiveSubroutineNameNative(program, shadertype, index, bufSize, length, pname0);
			}
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, Span<int> length, Span<byte> name)
		{
			fixed (int* plength0 = length)
			{
				fixed (byte* pname1 = name)
				{
					GetActiveSubroutineNameNative(program, shadertype, index, bufSize, plength0, pname1);
				}
			}
		}

		public static void GetActiveSubroutineName(uint program, GLShaderType shadertype, uint index, int bufSize, ref int length, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pname1 = &name)
				{
					GetActiveSubroutineNameNative(program, shadertype, index, bufSize, plength0, pname1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetActiveSubroutineUniformNameNative(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, uint, int, int*, byte*, void>)funcTable[1])(program, shadertype, index, bufSize, length, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, uint, int, nint, nint, void>)funcTable[1])(program, shadertype, index, bufSize, (nint)length, (nint)name);
			#endif
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, byte* name)
		{
			GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, length, name);
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, Span<int> length, byte* name)
		{
			fixed (int* plength0 = length)
			{
				GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, plength0, name);
			}
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, ref int length, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, plength0, name);
			}
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, length, pname0);
			}
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, int* length, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, length, pname0);
			}
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, Span<int> length, Span<byte> name)
		{
			fixed (int* plength0 = length)
			{
				fixed (byte* pname1 = name)
				{
					GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, plength0, pname1);
				}
			}
		}

		public static void GetActiveSubroutineUniformName(uint program, GLShaderType shadertype, uint index, int bufSize, ref int length, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pname1 = &name)
				{
					GetActiveSubroutineUniformNameNative(program, shadertype, index, bufSize, plength0, pname1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetActiveSubroutineUniformivNative(uint program, GLShaderType shadertype, uint index, GLSubroutineParameterName pname, int* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, uint, GLSubroutineParameterName, int*, void>)funcTable[2])(program, shadertype, index, pname, values);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, uint, GLSubroutineParameterName, nint, void>)funcTable[2])(program, shadertype, index, pname, (nint)values);
			#endif
		}

		public static void GetActiveSubroutineUniformiv(uint program, GLShaderType shadertype, uint index, GLSubroutineParameterName pname, int* values)
		{
			GetActiveSubroutineUniformivNative(program, shadertype, index, pname, values);
		}

		public static void GetActiveSubroutineUniformiv(uint program, GLShaderType shadertype, uint index, GLSubroutineParameterName pname, Span<int> values)
		{
			fixed (int* pvalues0 = values)
			{
				GetActiveSubroutineUniformivNative(program, shadertype, index, pname, pvalues0);
			}
		}

		public static void GetActiveSubroutineUniformiv(uint program, GLShaderType shadertype, uint index, GLSubroutineParameterName pname, ref int values)
		{
			fixed (int* pvalues0 = &values)
			{
				GetActiveSubroutineUniformivNative(program, shadertype, index, pname, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramStageivNative(uint program, GLShaderType shadertype, GLProgramStagePName pname, int* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, GLProgramStagePName, int*, void>)funcTable[3])(program, shadertype, pname, values);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLShaderType, GLProgramStagePName, nint, void>)funcTable[3])(program, shadertype, pname, (nint)values);
			#endif
		}

		public static void GetProgramStageiv(uint program, GLShaderType shadertype, GLProgramStagePName pname, int* values)
		{
			GetProgramStageivNative(program, shadertype, pname, values);
		}

		public static void GetProgramStageiv(uint program, GLShaderType shadertype, GLProgramStagePName pname, Span<int> values)
		{
			fixed (int* pvalues0 = values)
			{
				GetProgramStageivNative(program, shadertype, pname, pvalues0);
			}
		}

		public static void GetProgramStageiv(uint program, GLShaderType shadertype, GLProgramStagePName pname, ref int values)
		{
			fixed (int* pvalues0 = &values)
			{
				GetProgramStageivNative(program, shadertype, pname, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint GetSubroutineIndexNative(uint program, GLShaderType shadertype, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLShaderType, byte*, uint>)funcTable[4])(program, shadertype, name);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<uint, GLShaderType, nint, uint>)funcTable[4])(program, shadertype, (nint)name);
			#endif
		}

		public static uint GetSubroutineIndex(uint program, GLShaderType shadertype, byte* name)
		{
			uint ret = GetSubroutineIndexNative(program, shadertype, name);
			return ret;
		}

		public static uint GetSubroutineIndex(uint program, GLShaderType shadertype, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			uint ret = GetSubroutineIndexNative(program, shadertype, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static uint GetSubroutineIndex(uint program, GLShaderType shadertype, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				uint ret = GetSubroutineIndexNative(program, shadertype, pname0);
				return ret;
			}
		}

		public static uint GetSubroutineIndex(uint program, GLShaderType shadertype, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				uint ret = GetSubroutineIndexNative(program, shadertype, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetSubroutineUniformLocationNative(uint program, GLShaderType shadertype, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLShaderType, byte*, int>)funcTable[5])(program, shadertype, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, GLShaderType, nint, int>)funcTable[5])(program, shadertype, (nint)name);
			#endif
		}

		public static int GetSubroutineUniformLocation(uint program, GLShaderType shadertype, byte* name)
		{
			int ret = GetSubroutineUniformLocationNative(program, shadertype, name);
			return ret;
		}

		public static int GetSubroutineUniformLocation(uint program, GLShaderType shadertype, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = GetSubroutineUniformLocationNative(program, shadertype, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static int GetSubroutineUniformLocation(uint program, GLShaderType shadertype, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetSubroutineUniformLocationNative(program, shadertype, pname0);
				return ret;
			}
		}

		public static int GetSubroutineUniformLocation(uint program, GLShaderType shadertype, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetSubroutineUniformLocationNative(program, shadertype, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetUniformSubroutineuivNative(GLShaderType shadertype, int location, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLShaderType, int, uint*, void>)funcTable[6])(shadertype, location, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLShaderType, int, nint, void>)funcTable[6])(shadertype, location, (nint)@params);
			#endif
		}

		public static void GetUniformSubroutineuiv(GLShaderType shadertype, int location, uint* @params)
		{
			GetUniformSubroutineuivNative(shadertype, location, @params);
		}

		public static void GetUniformSubroutineuiv(GLShaderType shadertype, int location, out uint @params)
		{
			uint pparams;
			GetUniformSubroutineuivNative(shadertype, location, &pparams);
			@params = pparams;
		}

		public static void GetUniformSubroutineuiv(GLShaderType shadertype, int location, Span<uint> @params)
		{
			fixed (uint* pparams = @params)
			{
				GetUniformSubroutineuivNative(shadertype, location, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformSubroutinesuivNative(GLShaderType shadertype, int count, uint* indices)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLShaderType, int, uint*, void>)funcTable[7])(shadertype, count, indices);
			#else
			((delegate* unmanaged[Cdecl]<GLShaderType, int, nint, void>)funcTable[7])(shadertype, count, (nint)indices);
			#endif
		}

		public static void UniformSubroutinesuiv(GLShaderType shadertype, int count, uint* indices)
		{
			UniformSubroutinesuivNative(shadertype, count, indices);
		}

		public static void UniformSubroutinesuiv(GLShaderType shadertype, int count, Span<uint> indices)
		{
			fixed (uint* pindices0 = indices)
			{
				UniformSubroutinesuivNative(shadertype, count, pindices0);
			}
		}

		public static void UniformSubroutinesuiv(GLShaderType shadertype, int count, ref uint indices)
		{
			fixed (uint* pindices0 = &indices)
			{
				UniformSubroutinesuivNative(shadertype, count, pindices0);
			}
		}

	}
}
