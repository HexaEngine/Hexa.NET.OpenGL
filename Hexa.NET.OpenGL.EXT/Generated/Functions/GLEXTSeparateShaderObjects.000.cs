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

namespace Hexa.NET.OpenGL.EXT
{
	public static unsafe partial class GLEXTSeparateShaderObjects
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ActiveProgramEXTNative(uint program)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(program);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(program);
			#endif
		}

		public static void ActiveProgramEXT(uint program)
		{
			ActiveProgramEXTNative(program);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ActiveShaderProgramEXTNative(uint pipeline, uint program)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[1])(pipeline, program);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[1])(pipeline, program);
			#endif
		}

		public static void ActiveShaderProgramEXT(uint pipeline, uint program)
		{
			ActiveShaderProgramEXTNative(pipeline, program);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindProgramPipelineEXTNative(uint pipeline)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[2])(pipeline);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[2])(pipeline);
			#endif
		}

		public static void BindProgramPipelineEXT(uint pipeline)
		{
			BindProgramPipelineEXTNative(pipeline);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint CreateShaderProgramEXTNative(GLShaderType type, byte* str)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLShaderType, byte*, uint>)funcTable[3])(type, str);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<GLShaderType, nint, uint>)funcTable[3])(type, (nint)str);
			#endif
		}

		public static uint CreateShaderProgramEXT(GLShaderType type, byte* str)
		{
			uint ret = CreateShaderProgramEXTNative(type, str);
			return ret;
		}

		public static uint CreateShaderProgramEXT(GLShaderType type, string str)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (str != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(str);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(str, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			uint ret = CreateShaderProgramEXTNative(type, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static uint CreateShaderProgramEXT(GLShaderType type, ReadOnlySpan<byte> str)
		{
			fixed (byte* pstr0 = str)
			{
				uint ret = CreateShaderProgramEXTNative(type, pstr0);
				return ret;
			}
		}

		public static uint CreateShaderProgramEXT(GLShaderType type, ref byte str)
		{
			fixed (byte* pstr0 = &str)
			{
				uint ret = CreateShaderProgramEXTNative(type, pstr0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint CreateShaderProgramvEXTNative(GLShaderType type, int count, byte** strings)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLShaderType, int, byte**, uint>)funcTable[4])(type, count, strings);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<GLShaderType, int, nint, uint>)funcTable[4])(type, count, (nint)strings);
			#endif
		}

		public static uint CreateShaderProgramvEXT(GLShaderType type, int count, byte** strings)
		{
			uint ret = CreateShaderProgramvEXTNative(type, count, strings);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteProgramPipelinesEXTNative(int n, uint* pipelines)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[5])(n, pipelines);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[5])(n, (nint)pipelines);
			#endif
		}

		public static void DeleteProgramPipelinesEXT(int n, uint* pipelines)
		{
			DeleteProgramPipelinesEXTNative(n, pipelines);
		}

		public static void DeleteProgramPipelinesEXT(int n, ref uint pipelines)
		{
			fixed (uint* ppipelines0 = &pipelines)
			{
				DeleteProgramPipelinesEXTNative(n, ppipelines0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenProgramPipelinesEXTNative(int n, uint* pipelines)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[6])(n, pipelines);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[6])(n, (nint)pipelines);
			#endif
		}

		public static void GenProgramPipelinesEXT(int n, uint* pipelines)
		{
			GenProgramPipelinesEXTNative(n, pipelines);
		}

		public static void GenProgramPipelinesEXT(int n, ref uint pipelines)
		{
			fixed (uint* ppipelines0 = &pipelines)
			{
				GenProgramPipelinesEXTNative(n, ppipelines0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramPipelineInfoLogEXTNative(uint pipeline, int bufSize, int* length, byte* infoLog)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, byte*, void>)funcTable[7])(pipeline, bufSize, length, infoLog);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[7])(pipeline, bufSize, (nint)length, (nint)infoLog);
			#endif
		}

		public static void GetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, int* length, byte* infoLog)
		{
			GetProgramPipelineInfoLogEXTNative(pipeline, bufSize, length, infoLog);
		}

		public static void GetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, ref int length, byte* infoLog)
		{
			fixed (int* plength0 = &length)
			{
				GetProgramPipelineInfoLogEXTNative(pipeline, bufSize, plength0, infoLog);
			}
		}

		public static void GetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, int* length, string infoLog)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (infoLog != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(infoLog);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(infoLog, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetProgramPipelineInfoLogEXTNative(pipeline, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, int* length, ReadOnlySpan<byte> infoLog)
		{
			fixed (byte* pinfoLog0 = infoLog)
			{
				GetProgramPipelineInfoLogEXTNative(pipeline, bufSize, length, pinfoLog0);
			}
		}

		public static void GetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, int* length, ref byte infoLog)
		{
			fixed (byte* pinfoLog0 = &infoLog)
			{
				GetProgramPipelineInfoLogEXTNative(pipeline, bufSize, length, pinfoLog0);
			}
		}

		public static void GetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, ref int length, ref byte infoLog)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pinfoLog1 = &infoLog)
				{
					GetProgramPipelineInfoLogEXTNative(pipeline, bufSize, plength0, pinfoLog1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetProgramPipelineivEXTNative(uint pipeline, GLPipelineParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLPipelineParameterName, int*, void>)funcTable[8])(pipeline, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLPipelineParameterName, nint, void>)funcTable[8])(pipeline, pname, (nint)@params);
			#endif
		}

		public static void GetProgramPipelineivEXT(uint pipeline, GLPipelineParameterName pname, int* @params)
		{
			GetProgramPipelineivEXTNative(pipeline, pname, @params);
		}

		public static void GetProgramPipelineivEXT(uint pipeline, GLPipelineParameterName pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetProgramPipelineivEXTNative(pipeline, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsProgramPipelineEXTNative(uint pipeline)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[9])(pipeline);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[9])(pipeline);
			#endif
		}

		public static bool IsProgramPipelineEXT(uint pipeline)
		{
			byte ret = IsProgramPipelineEXTNative(pipeline);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramParameteriEXTNative(uint program, GLProgramParameterPName pname, int value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLProgramParameterPName, int, void>)funcTable[10])(program, pname, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLProgramParameterPName, int, void>)funcTable[10])(program, pname, value);
			#endif
		}

		public static void ProgramParameteriEXT(uint program, GLProgramParameterPName pname, int value)
		{
			ProgramParameteriEXTNative(program, pname, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform1fEXTNative(uint program, int location, float v0)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float, void>)funcTable[11])(program, location, v0);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, float, void>)funcTable[11])(program, location, v0);
			#endif
		}

		public static void ProgramUniform1fEXT(uint program, int location, float v0)
		{
			ProgramUniform1fEXTNative(program, location, v0);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform1fvEXTNative(uint program, int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, float*, void>)funcTable[12])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[12])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform1fvEXT(uint program, int location, int count, float* value)
		{
			ProgramUniform1fvEXTNative(program, location, count, value);
		}

		public static void ProgramUniform1fvEXT(uint program, int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniform1fvEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform1iEXTNative(uint program, int location, int v0)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, void>)funcTable[13])(program, location, v0);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, void>)funcTable[13])(program, location, v0);
			#endif
		}

		public static void ProgramUniform1iEXT(uint program, int location, int v0)
		{
			ProgramUniform1iEXTNative(program, location, v0);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform1ivEXTNative(uint program, int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int*, void>)funcTable[14])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[14])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform1ivEXT(uint program, int location, int count, int* value)
		{
			ProgramUniform1ivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform1ivEXT(uint program, int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				ProgramUniform1ivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform1uiEXTNative(uint program, int location, uint v0)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint, void>)funcTable[15])(program, location, v0);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, uint, void>)funcTable[15])(program, location, v0);
			#endif
		}

		public static void ProgramUniform1uiEXT(uint program, int location, uint v0)
		{
			ProgramUniform1uiEXTNative(program, location, v0);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform1uivEXTNative(uint program, int location, int count, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, uint*, void>)funcTable[16])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[16])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform1uivEXT(uint program, int location, int count, uint* value)
		{
			ProgramUniform1uivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform1uivEXT(uint program, int location, int count, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				ProgramUniform1uivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform2fEXTNative(uint program, int location, float v0, float v1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float, float, void>)funcTable[17])(program, location, v0, v1);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, float, float, void>)funcTable[17])(program, location, v0, v1);
			#endif
		}

		public static void ProgramUniform2fEXT(uint program, int location, float v0, float v1)
		{
			ProgramUniform2fEXTNative(program, location, v0, v1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform2fvEXTNative(uint program, int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, float*, void>)funcTable[18])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[18])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform2fvEXT(uint program, int location, int count, float* value)
		{
			ProgramUniform2fvEXTNative(program, location, count, value);
		}

		public static void ProgramUniform2fvEXT(uint program, int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniform2fvEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform2iEXTNative(uint program, int location, int v0, int v1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, void>)funcTable[19])(program, location, v0, v1);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, void>)funcTable[19])(program, location, v0, v1);
			#endif
		}

		public static void ProgramUniform2iEXT(uint program, int location, int v0, int v1)
		{
			ProgramUniform2iEXTNative(program, location, v0, v1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform2ivEXTNative(uint program, int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int*, void>)funcTable[20])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[20])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform2ivEXT(uint program, int location, int count, int* value)
		{
			ProgramUniform2ivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform2ivEXT(uint program, int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				ProgramUniform2ivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform2uiEXTNative(uint program, int location, uint v0, uint v1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint, uint, void>)funcTable[21])(program, location, v0, v1);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, uint, uint, void>)funcTable[21])(program, location, v0, v1);
			#endif
		}

		public static void ProgramUniform2uiEXT(uint program, int location, uint v0, uint v1)
		{
			ProgramUniform2uiEXTNative(program, location, v0, v1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform2uivEXTNative(uint program, int location, int count, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, uint*, void>)funcTable[22])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[22])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform2uivEXT(uint program, int location, int count, uint* value)
		{
			ProgramUniform2uivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform2uivEXT(uint program, int location, int count, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				ProgramUniform2uivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform3fEXTNative(uint program, int location, float v0, float v1, float v2)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float, float, float, void>)funcTable[23])(program, location, v0, v1, v2);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, float, float, float, void>)funcTable[23])(program, location, v0, v1, v2);
			#endif
		}

		public static void ProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2)
		{
			ProgramUniform3fEXTNative(program, location, v0, v1, v2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform3fvEXTNative(uint program, int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, float*, void>)funcTable[24])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[24])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform3fvEXT(uint program, int location, int count, float* value)
		{
			ProgramUniform3fvEXTNative(program, location, count, value);
		}

		public static void ProgramUniform3fvEXT(uint program, int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniform3fvEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform3iEXTNative(uint program, int location, int v0, int v1, int v2)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[25])(program, location, v0, v1, v2);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[25])(program, location, v0, v1, v2);
			#endif
		}

		public static void ProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2)
		{
			ProgramUniform3iEXTNative(program, location, v0, v1, v2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform3ivEXTNative(uint program, int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int*, void>)funcTable[26])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[26])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform3ivEXT(uint program, int location, int count, int* value)
		{
			ProgramUniform3ivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform3ivEXT(uint program, int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				ProgramUniform3ivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform3uiEXTNative(uint program, int location, uint v0, uint v1, uint v2)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint, uint, uint, void>)funcTable[27])(program, location, v0, v1, v2);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, uint, uint, uint, void>)funcTable[27])(program, location, v0, v1, v2);
			#endif
		}

		public static void ProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2)
		{
			ProgramUniform3uiEXTNative(program, location, v0, v1, v2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform3uivEXTNative(uint program, int location, int count, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, uint*, void>)funcTable[28])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[28])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform3uivEXT(uint program, int location, int count, uint* value)
		{
			ProgramUniform3uivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform3uivEXT(uint program, int location, int count, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				ProgramUniform3uivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform4fEXTNative(uint program, int location, float v0, float v1, float v2, float v3)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float, float, float, float, void>)funcTable[29])(program, location, v0, v1, v2, v3);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, float, float, float, float, void>)funcTable[29])(program, location, v0, v1, v2, v3);
			#endif
		}

		public static void ProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3)
		{
			ProgramUniform4fEXTNative(program, location, v0, v1, v2, v3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform4fvEXTNative(uint program, int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, float*, void>)funcTable[30])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[30])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform4fvEXT(uint program, int location, int count, float* value)
		{
			ProgramUniform4fvEXTNative(program, location, count, value);
		}

		public static void ProgramUniform4fvEXT(uint program, int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniform4fvEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform4iEXTNative(uint program, int location, int v0, int v1, int v2, int v3)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, int, void>)funcTable[31])(program, location, v0, v1, v2, v3);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, int, void>)funcTable[31])(program, location, v0, v1, v2, v3);
			#endif
		}

		public static void ProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3)
		{
			ProgramUniform4iEXTNative(program, location, v0, v1, v2, v3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform4ivEXTNative(uint program, int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int*, void>)funcTable[32])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[32])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform4ivEXT(uint program, int location, int count, int* value)
		{
			ProgramUniform4ivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform4ivEXT(uint program, int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				ProgramUniform4ivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform4uiEXTNative(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint, uint, uint, uint, void>)funcTable[33])(program, location, v0, v1, v2, v3);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, uint, uint, uint, uint, void>)funcTable[33])(program, location, v0, v1, v2, v3);
			#endif
		}

		public static void ProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			ProgramUniform4uiEXTNative(program, location, v0, v1, v2, v3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniform4uivEXTNative(uint program, int location, int count, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, uint*, void>)funcTable[34])(program, location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[34])(program, location, count, (nint)value);
			#endif
		}

		public static void ProgramUniform4uivEXT(uint program, int location, int count, uint* value)
		{
			ProgramUniform4uivEXTNative(program, location, count, value);
		}

		public static void ProgramUniform4uivEXT(uint program, int location, int count, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				ProgramUniform4uivEXTNative(program, location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix2fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[35])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[35])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix2fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix2fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix2fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix2fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix2x3fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[36])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[36])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix2x3fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix2x3fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix2x3fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix2x3fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix2x4fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[37])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[37])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix2x4fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix2x4fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix2x4fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix2x4fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix3fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[38])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[38])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix3fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix3fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix3fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix3fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix3x2fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[39])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[39])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix3x2fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix3x2fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix3x2fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix3x2fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix3x4fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[40])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[40])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix3x4fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix3x4fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix3x4fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix3x4fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix4fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[41])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[41])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix4fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix4fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix4fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix4fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix4x2fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[42])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[42])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix4x2fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix4x2fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix4x2fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix4x2fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramUniformMatrix4x3fvEXTNative(uint program, int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, float*, void>)funcTable[43])(program, location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, byte, nint, void>)funcTable[43])(program, location, count, transpose, (nint)value);
			#endif
		}

		public static void ProgramUniformMatrix4x3fvEXT(uint program, int location, int count, byte transpose, float* value)
		{
			ProgramUniformMatrix4x3fvEXTNative(program, location, count, transpose, value);
		}

		public static void ProgramUniformMatrix4x3fvEXT(uint program, int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				ProgramUniformMatrix4x3fvEXTNative(program, location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UseProgramStagesEXTNative(uint pipeline, GLUseProgramStageMask stages, uint program)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLUseProgramStageMask, uint, void>)funcTable[44])(pipeline, stages, program);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLUseProgramStageMask, uint, void>)funcTable[44])(pipeline, stages, program);
			#endif
		}

		public static void UseProgramStagesEXT(uint pipeline, GLUseProgramStageMask stages, uint program)
		{
			UseProgramStagesEXTNative(pipeline, stages, program);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UseShaderProgramEXTNative(GLEnum type, uint program)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, void>)funcTable[45])(type, program);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, void>)funcTable[45])(type, program);
			#endif
		}

		public static void UseShaderProgramEXT(GLEnum type, uint program)
		{
			UseShaderProgramEXTNative(type, program);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ValidateProgramPipelineEXTNative(uint pipeline)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[46])(pipeline);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[46])(pipeline);
			#endif
		}

		public static void ValidateProgramPipelineEXT(uint pipeline)
		{
			ValidateProgramPipelineEXTNative(pipeline);
		}

	}
}