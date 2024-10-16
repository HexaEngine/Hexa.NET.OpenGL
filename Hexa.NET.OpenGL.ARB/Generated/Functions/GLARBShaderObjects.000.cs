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
	public static unsafe partial class GLARBShaderObjects
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void AttachObjectARBNative(uint containerObj, uint obj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(containerObj, obj);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(containerObj, obj);
			#endif
		}

		public static void AttachObjectARB(uint containerObj, uint obj)
		{
			AttachObjectARBNative(containerObj, obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CompileShaderARBNative(uint shaderObj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[1])(shaderObj);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[1])(shaderObj);
			#endif
		}

		public static void CompileShaderARB(uint shaderObj)
		{
			CompileShaderARBNative(shaderObj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint CreateProgramObjectARBNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint>)funcTable[2])();
			#else
			return (uint)((delegate* unmanaged[Cdecl]<uint>)funcTable[2])();
			#endif
		}

		public static uint CreateProgramObjectARB()
		{
			uint ret = CreateProgramObjectARBNative();
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint CreateShaderObjectARBNative(GLShaderType shaderType)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLShaderType, uint>)funcTable[3])(shaderType);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<GLShaderType, uint>)funcTable[3])(shaderType);
			#endif
		}

		public static uint CreateShaderObjectARB(GLShaderType shaderType)
		{
			uint ret = CreateShaderObjectARBNative(shaderType);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteObjectARBNative(uint obj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[4])(obj);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[4])(obj);
			#endif
		}

		public static void DeleteObjectARB(uint obj)
		{
			DeleteObjectARBNative(obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DetachObjectARBNative(uint containerObj, uint attachedObj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[5])(containerObj, attachedObj);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[5])(containerObj, attachedObj);
			#endif
		}

		public static void DetachObjectARB(uint containerObj, uint attachedObj)
		{
			DetachObjectARBNative(containerObj, attachedObj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetActiveUniformARBNative(uint programObj, uint index, int maxLength, int* length, int* size, GLUniformType type, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, int*, int*, GLUniformType, byte*, void>)funcTable[6])(programObj, index, maxLength, length, size, type, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, nint, nint, GLUniformType, nint, void>)funcTable[6])(programObj, index, maxLength, (nint)length, (nint)size, type, (nint)name);
			#endif
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, GLUniformType type, byte* name)
		{
			GetActiveUniformARBNative(programObj, index, maxLength, length, size, type, name);
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, ref int length, int* size, GLUniformType type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				GetActiveUniformARBNative(programObj, index, maxLength, plength0, size, type, name);
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, ref int size, GLUniformType type, byte* name)
		{
			fixed (int* psize0 = &size)
			{
				GetActiveUniformARBNative(programObj, index, maxLength, length, psize0, type, name);
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, ref int length, ref int size, GLUniformType type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					GetActiveUniformARBNative(programObj, index, maxLength, plength0, psize1, type, name);
				}
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, GLUniformType type, string name)
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
			GetActiveUniformARBNative(programObj, index, maxLength, length, size, type, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, GLUniformType type, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				GetActiveUniformARBNative(programObj, index, maxLength, length, size, type, pname0);
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, GLUniformType type, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				GetActiveUniformARBNative(programObj, index, maxLength, length, size, type, pname0);
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, ref int length, int* size, GLUniformType type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pname1 = &name)
				{
					GetActiveUniformARBNative(programObj, index, maxLength, plength0, size, type, pname1);
				}
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, ref int size, GLUniformType type, ref byte name)
		{
			fixed (int* psize0 = &size)
			{
				fixed (byte* pname1 = &name)
				{
					GetActiveUniformARBNative(programObj, index, maxLength, length, psize0, type, pname1);
				}
			}
		}

		public static void GetActiveUniformARB(uint programObj, uint index, int maxLength, ref int length, ref int size, GLUniformType type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					fixed (byte* pname2 = &name)
					{
						GetActiveUniformARBNative(programObj, index, maxLength, plength0, psize1, type, pname2);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetAttachedObjectsARBNative(uint containerObj, int maxCount, int* count, uint* obj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, uint*, void>)funcTable[7])(containerObj, maxCount, count, obj);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[7])(containerObj, maxCount, (nint)count, (nint)obj);
			#endif
		}

		public static void GetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj)
		{
			GetAttachedObjectsARBNative(containerObj, maxCount, count, obj);
		}

		public static void GetAttachedObjectsARB(uint containerObj, int maxCount, ref int count, uint* obj)
		{
			fixed (int* pcount0 = &count)
			{
				GetAttachedObjectsARBNative(containerObj, maxCount, pcount0, obj);
			}
		}

		public static void GetAttachedObjectsARB(uint containerObj, int maxCount, int* count, ref uint obj)
		{
			fixed (uint* pobj0 = &obj)
			{
				GetAttachedObjectsARBNative(containerObj, maxCount, count, pobj0);
			}
		}

		public static void GetAttachedObjectsARB(uint containerObj, int maxCount, ref int count, ref uint obj)
		{
			fixed (int* pcount0 = &count)
			{
				fixed (uint* pobj1 = &obj)
				{
					GetAttachedObjectsARBNative(containerObj, maxCount, pcount0, pobj1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint GetHandleARBNative(GLContainerType pname)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLContainerType, uint>)funcTable[8])(pname);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<GLContainerType, uint>)funcTable[8])(pname);
			#endif
		}

		public static uint GetHandleARB(GLContainerType pname)
		{
			uint ret = GetHandleARBNative(pname);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetInfoLogARBNative(uint obj, int maxLength, int* length, byte* infoLog)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, byte*, void>)funcTable[9])(obj, maxLength, length, infoLog);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[9])(obj, maxLength, (nint)length, (nint)infoLog);
			#endif
		}

		public static void GetInfoLogARB(uint obj, int maxLength, int* length, byte* infoLog)
		{
			GetInfoLogARBNative(obj, maxLength, length, infoLog);
		}

		public static void GetInfoLogARB(uint obj, int maxLength, ref int length, byte* infoLog)
		{
			fixed (int* plength0 = &length)
			{
				GetInfoLogARBNative(obj, maxLength, plength0, infoLog);
			}
		}

		public static void GetInfoLogARB(uint obj, int maxLength, int* length, string infoLog)
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
			GetInfoLogARBNative(obj, maxLength, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetInfoLogARB(uint obj, int maxLength, int* length, ReadOnlySpan<byte> infoLog)
		{
			fixed (byte* pinfoLog0 = infoLog)
			{
				GetInfoLogARBNative(obj, maxLength, length, pinfoLog0);
			}
		}

		public static void GetInfoLogARB(uint obj, int maxLength, int* length, ref byte infoLog)
		{
			fixed (byte* pinfoLog0 = &infoLog)
			{
				GetInfoLogARBNative(obj, maxLength, length, pinfoLog0);
			}
		}

		public static void GetInfoLogARB(uint obj, int maxLength, ref int length, ref byte infoLog)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pinfoLog1 = &infoLog)
				{
					GetInfoLogARBNative(obj, maxLength, plength0, pinfoLog1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetObjectParameterfvARBNative(uint obj, GLEnum pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, float*, void>)funcTable[10])(obj, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, void>)funcTable[10])(obj, pname, (nint)@params);
			#endif
		}

		public static void GetObjectParameterfvARB(uint obj, GLEnum pname, float* @params)
		{
			GetObjectParameterfvARBNative(obj, pname, @params);
		}

		public static void GetObjectParameterfvARB(uint obj, GLEnum pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetObjectParameterfvARBNative(obj, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetObjectParameterivARBNative(uint obj, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int*, void>)funcTable[11])(obj, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, void>)funcTable[11])(obj, pname, (nint)@params);
			#endif
		}

		public static void GetObjectParameterivARB(uint obj, GLEnum pname, int* @params)
		{
			GetObjectParameterivARBNative(obj, pname, @params);
		}

		public static void GetObjectParameterivARB(uint obj, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetObjectParameterivARBNative(obj, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetShaderSourceARBNative(uint obj, int maxLength, int* length, byte* source)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, byte*, void>)funcTable[12])(obj, maxLength, length, source);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[12])(obj, maxLength, (nint)length, (nint)source);
			#endif
		}

		public static void GetShaderSourceARB(uint obj, int maxLength, int* length, byte* source)
		{
			GetShaderSourceARBNative(obj, maxLength, length, source);
		}

		public static void GetShaderSourceARB(uint obj, int maxLength, ref int length, byte* source)
		{
			fixed (int* plength0 = &length)
			{
				GetShaderSourceARBNative(obj, maxLength, plength0, source);
			}
		}

		public static void GetShaderSourceARB(uint obj, int maxLength, int* length, string source)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (source != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(source);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(source, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetShaderSourceARBNative(obj, maxLength, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetShaderSourceARB(uint obj, int maxLength, int* length, ReadOnlySpan<byte> source)
		{
			fixed (byte* psource0 = source)
			{
				GetShaderSourceARBNative(obj, maxLength, length, psource0);
			}
		}

		public static void GetShaderSourceARB(uint obj, int maxLength, int* length, ref byte source)
		{
			fixed (byte* psource0 = &source)
			{
				GetShaderSourceARBNative(obj, maxLength, length, psource0);
			}
		}

		public static void GetShaderSourceARB(uint obj, int maxLength, ref int length, ref byte source)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* psource1 = &source)
				{
					GetShaderSourceARBNative(obj, maxLength, plength0, psource1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetUniformLocationARBNative(uint programObj, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte*, int>)funcTable[13])(programObj, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, nint, int>)funcTable[13])(programObj, (nint)name);
			#endif
		}

		public static int GetUniformLocationARB(uint programObj, byte* name)
		{
			int ret = GetUniformLocationARBNative(programObj, name);
			return ret;
		}

		public static int GetUniformLocationARB(uint programObj, string name)
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
			int ret = GetUniformLocationARBNative(programObj, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static int GetUniformLocationARB(uint programObj, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetUniformLocationARBNative(programObj, pname0);
				return ret;
			}
		}

		public static int GetUniformLocationARB(uint programObj, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetUniformLocationARBNative(programObj, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetUniformfvARBNative(uint programObj, int location, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float*, void>)funcTable[14])(programObj, location, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[14])(programObj, location, (nint)@params);
			#endif
		}

		public static void GetUniformfvARB(uint programObj, int location, float* @params)
		{
			GetUniformfvARBNative(programObj, location, @params);
		}

		public static void GetUniformfvARB(uint programObj, int location, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetUniformfvARBNative(programObj, location, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetUniformivARBNative(uint programObj, int location, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, void>)funcTable[15])(programObj, location, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[15])(programObj, location, (nint)@params);
			#endif
		}

		public static void GetUniformivARB(uint programObj, int location, int* @params)
		{
			GetUniformivARBNative(programObj, location, @params);
		}

		public static void GetUniformivARB(uint programObj, int location, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetUniformivARBNative(programObj, location, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void LinkProgramARBNative(uint programObj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[16])(programObj);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[16])(programObj);
			#endif
		}

		public static void LinkProgramARB(uint programObj)
		{
			LinkProgramARBNative(programObj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ShaderSourceARBNative(uint shaderObj, int count, byte** str, int* length)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, byte**, int*, void>)funcTable[17])(shaderObj, count, str, length);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[17])(shaderObj, count, (nint)str, (nint)length);
			#endif
		}

		public static void ShaderSourceARB(uint shaderObj, int count, byte** str, int* length)
		{
			ShaderSourceARBNative(shaderObj, count, str, length);
		}

		public static void ShaderSourceARB(uint shaderObj, int count, byte** str, ref int length)
		{
			fixed (int* plength0 = &length)
			{
				ShaderSourceARBNative(shaderObj, count, str, plength0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform1fARBNative(int location, float v0)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, float, void>)funcTable[18])(location, v0);
			#else
			((delegate* unmanaged[Cdecl]<int, float, void>)funcTable[18])(location, v0);
			#endif
		}

		public static void Uniform1fARB(int location, float v0)
		{
			Uniform1fARBNative(location, v0);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform1fvARBNative(int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, float*, void>)funcTable[19])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[19])(location, count, (nint)value);
			#endif
		}

		public static void Uniform1fvARB(int location, int count, float* value)
		{
			Uniform1fvARBNative(location, count, value);
		}

		public static void Uniform1fvARB(int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				Uniform1fvARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform1iARBNative(int location, int v0)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, void>)funcTable[20])(location, v0);
			#else
			((delegate* unmanaged[Cdecl]<int, int, void>)funcTable[20])(location, v0);
			#endif
		}

		public static void Uniform1iARB(int location, int v0)
		{
			Uniform1iARBNative(location, v0);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform1ivARBNative(int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int*, void>)funcTable[21])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[21])(location, count, (nint)value);
			#endif
		}

		public static void Uniform1ivARB(int location, int count, int* value)
		{
			Uniform1ivARBNative(location, count, value);
		}

		public static void Uniform1ivARB(int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				Uniform1ivARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform2fARBNative(int location, float v0, float v1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, float, float, void>)funcTable[22])(location, v0, v1);
			#else
			((delegate* unmanaged[Cdecl]<int, float, float, void>)funcTable[22])(location, v0, v1);
			#endif
		}

		public static void Uniform2fARB(int location, float v0, float v1)
		{
			Uniform2fARBNative(location, v0, v1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform2fvARBNative(int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, float*, void>)funcTable[23])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[23])(location, count, (nint)value);
			#endif
		}

		public static void Uniform2fvARB(int location, int count, float* value)
		{
			Uniform2fvARBNative(location, count, value);
		}

		public static void Uniform2fvARB(int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				Uniform2fvARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform2iARBNative(int location, int v0, int v1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[24])(location, v0, v1);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[24])(location, v0, v1);
			#endif
		}

		public static void Uniform2iARB(int location, int v0, int v1)
		{
			Uniform2iARBNative(location, v0, v1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform2ivARBNative(int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int*, void>)funcTable[25])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[25])(location, count, (nint)value);
			#endif
		}

		public static void Uniform2ivARB(int location, int count, int* value)
		{
			Uniform2ivARBNative(location, count, value);
		}

		public static void Uniform2ivARB(int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				Uniform2ivARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform3fARBNative(int location, float v0, float v1, float v2)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, float, float, float, void>)funcTable[26])(location, v0, v1, v2);
			#else
			((delegate* unmanaged[Cdecl]<int, float, float, float, void>)funcTable[26])(location, v0, v1, v2);
			#endif
		}

		public static void Uniform3fARB(int location, float v0, float v1, float v2)
		{
			Uniform3fARBNative(location, v0, v1, v2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform3fvARBNative(int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, float*, void>)funcTable[27])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[27])(location, count, (nint)value);
			#endif
		}

		public static void Uniform3fvARB(int location, int count, float* value)
		{
			Uniform3fvARBNative(location, count, value);
		}

		public static void Uniform3fvARB(int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				Uniform3fvARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform3iARBNative(int location, int v0, int v1, int v2)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[28])(location, v0, v1, v2);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[28])(location, v0, v1, v2);
			#endif
		}

		public static void Uniform3iARB(int location, int v0, int v1, int v2)
		{
			Uniform3iARBNative(location, v0, v1, v2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform3ivARBNative(int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int*, void>)funcTable[29])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[29])(location, count, (nint)value);
			#endif
		}

		public static void Uniform3ivARB(int location, int count, int* value)
		{
			Uniform3ivARBNative(location, count, value);
		}

		public static void Uniform3ivARB(int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				Uniform3ivARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform4fARBNative(int location, float v0, float v1, float v2, float v3)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, float, float, float, float, void>)funcTable[30])(location, v0, v1, v2, v3);
			#else
			((delegate* unmanaged[Cdecl]<int, float, float, float, float, void>)funcTable[30])(location, v0, v1, v2, v3);
			#endif
		}

		public static void Uniform4fARB(int location, float v0, float v1, float v2, float v3)
		{
			Uniform4fARBNative(location, v0, v1, v2, v3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform4fvARBNative(int location, int count, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, float*, void>)funcTable[31])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[31])(location, count, (nint)value);
			#endif
		}

		public static void Uniform4fvARB(int location, int count, float* value)
		{
			Uniform4fvARBNative(location, count, value);
		}

		public static void Uniform4fvARB(int location, int count, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				Uniform4fvARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform4iARBNative(int location, int v0, int v1, int v2, int v3)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, void>)funcTable[32])(location, v0, v1, v2, v3);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, void>)funcTable[32])(location, v0, v1, v2, v3);
			#endif
		}

		public static void Uniform4iARB(int location, int v0, int v1, int v2, int v3)
		{
			Uniform4iARBNative(location, v0, v1, v2, v3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Uniform4ivARBNative(int location, int count, int* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int*, void>)funcTable[33])(location, count, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, void>)funcTable[33])(location, count, (nint)value);
			#endif
		}

		public static void Uniform4ivARB(int location, int count, int* value)
		{
			Uniform4ivARBNative(location, count, value);
		}

		public static void Uniform4ivARB(int location, int count, ref int value)
		{
			fixed (int* pvalue0 = &value)
			{
				Uniform4ivARBNative(location, count, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix2fvARBNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[34])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[34])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix2fvARB(int location, int count, byte transpose, float* value)
		{
			UniformMatrix2fvARBNative(location, count, transpose, value);
		}

		public static void UniformMatrix2fvARB(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix2fvARBNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix3fvARBNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[35])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[35])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix3fvARB(int location, int count, byte transpose, float* value)
		{
			UniformMatrix3fvARBNative(location, count, transpose, value);
		}

		public static void UniformMatrix3fvARB(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix3fvARBNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UniformMatrix4fvARBNative(int location, int count, byte transpose, float* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, byte, float*, void>)funcTable[36])(location, count, transpose, value);
			#else
			((delegate* unmanaged[Cdecl]<int, int, byte, nint, void>)funcTable[36])(location, count, transpose, (nint)value);
			#endif
		}

		public static void UniformMatrix4fvARB(int location, int count, byte transpose, float* value)
		{
			UniformMatrix4fvARBNative(location, count, transpose, value);
		}

		public static void UniformMatrix4fvARB(int location, int count, byte transpose, ref float value)
		{
			fixed (float* pvalue0 = &value)
			{
				UniformMatrix4fvARBNative(location, count, transpose, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UseProgramObjectARBNative(uint programObj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[37])(programObj);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[37])(programObj);
			#endif
		}

		public static void UseProgramObjectARB(uint programObj)
		{
			UseProgramObjectARBNative(programObj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ValidateProgramARBNative(uint programObj)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[38])(programObj);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[38])(programObj);
			#endif
		}

		public static void ValidateProgramARB(uint programObj)
		{
			ValidateProgramARBNative(programObj);
		}

	}
}