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
	public static unsafe partial class GLNVTransformFeedback
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ActiveVaryingNVNative(uint program, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, byte*, void>)funcTable[0])(program, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[0])(program, (nint)name);
			#endif
		}

		public static void ActiveVaryingNV(uint program, byte* name)
		{
			ActiveVaryingNVNative(program, name);
		}

		public static void ActiveVaryingNV(uint program, string name)
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
			ActiveVaryingNVNative(program, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void ActiveVaryingNV(uint program, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				ActiveVaryingNVNative(program, pname0);
			}
		}

		public static void ActiveVaryingNV(uint program, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				ActiveVaryingNVNative(program, pname0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BeginTransformFeedbackNVNative(GLPrimitiveType primitiveMode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void>)funcTable[1])(primitiveMode);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void>)funcTable[1])(primitiveMode);
			#endif
		}

		public static void BeginTransformFeedbackNV(GLPrimitiveType primitiveMode)
		{
			BeginTransformFeedbackNVNative(primitiveMode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindBufferBaseNVNative(GLBufferTargetARB target, uint index, uint buffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, void>)funcTable[2])(target, index, buffer);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, void>)funcTable[2])(target, index, buffer);
			#endif
		}

		public static void BindBufferBaseNV(GLBufferTargetARB target, uint index, uint buffer)
		{
			BindBufferBaseNVNative(target, index, buffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindBufferOffsetNVNative(GLBufferTargetARB target, uint index, uint buffer, nint offset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, void>)funcTable[3])(target, index, buffer, offset);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, void>)funcTable[3])(target, index, buffer, offset);
			#endif
		}

		public static void BindBufferOffsetNV(GLBufferTargetARB target, uint index, uint buffer, nint offset)
		{
			BindBufferOffsetNVNative(target, index, buffer, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindBufferRangeNVNative(GLBufferTargetARB target, uint index, uint buffer, nint offset, nint size)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, nint, void>)funcTable[4])(target, index, buffer, offset, size);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, nint, void>)funcTable[4])(target, index, buffer, offset, size);
			#endif
		}

		public static void BindBufferRangeNV(GLBufferTargetARB target, uint index, uint buffer, nint offset, nint size)
		{
			BindBufferRangeNVNative(target, index, buffer, offset, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EndTransformFeedbackNVNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[5])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[5])();
			#endif
		}

		public static void EndTransformFeedbackNV()
		{
			EndTransformFeedbackNVNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetActiveVaryingNVNative(uint program, uint index, int bufSize, int* length, int* size, GLEnum* type, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, int*, int*, GLEnum*, byte*, void>)funcTable[6])(program, index, bufSize, length, size, type, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, nint, nint, nint, nint, void>)funcTable[6])(program, index, bufSize, (nint)length, (nint)size, (nint)type, (nint)name);
			#endif
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, GLEnum* type, byte* name)
		{
			GetActiveVaryingNVNative(program, index, bufSize, length, size, type, name);
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, int* size, GLEnum* type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				GetActiveVaryingNVNative(program, index, bufSize, plength0, size, type, name);
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, ref int size, GLEnum* type, byte* name)
		{
			fixed (int* psize0 = &size)
			{
				GetActiveVaryingNVNative(program, index, bufSize, length, psize0, type, name);
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, ref int size, GLEnum* type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					GetActiveVaryingNVNative(program, index, bufSize, plength0, psize1, type, name);
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, ref GLEnum type, byte* name)
		{
			fixed (GLEnum* ptype0 = &type)
			{
				GetActiveVaryingNVNative(program, index, bufSize, length, size, ptype0, name);
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, int* size, ref GLEnum type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (GLEnum* ptype1 = &type)
				{
					GetActiveVaryingNVNative(program, index, bufSize, plength0, size, ptype1, name);
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, ref int size, ref GLEnum type, byte* name)
		{
			fixed (int* psize0 = &size)
			{
				fixed (GLEnum* ptype1 = &type)
				{
					GetActiveVaryingNVNative(program, index, bufSize, length, psize0, ptype1, name);
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, ref int size, ref GLEnum type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					fixed (GLEnum* ptype2 = &type)
					{
						GetActiveVaryingNVNative(program, index, bufSize, plength0, psize1, ptype2, name);
					}
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, GLEnum* type, string name)
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
			GetActiveVaryingNVNative(program, index, bufSize, length, size, type, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, GLEnum* type, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				GetActiveVaryingNVNative(program, index, bufSize, length, size, type, pname0);
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, GLEnum* type, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				GetActiveVaryingNVNative(program, index, bufSize, length, size, type, pname0);
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, int* size, GLEnum* type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pname1 = &name)
				{
					GetActiveVaryingNVNative(program, index, bufSize, plength0, size, type, pname1);
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, ref int size, GLEnum* type, ref byte name)
		{
			fixed (int* psize0 = &size)
			{
				fixed (byte* pname1 = &name)
				{
					GetActiveVaryingNVNative(program, index, bufSize, length, psize0, type, pname1);
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, ref int size, GLEnum* type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					fixed (byte* pname2 = &name)
					{
						GetActiveVaryingNVNative(program, index, bufSize, plength0, psize1, type, pname2);
					}
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, ref GLEnum type, ref byte name)
		{
			fixed (GLEnum* ptype0 = &type)
			{
				fixed (byte* pname1 = &name)
				{
					GetActiveVaryingNVNative(program, index, bufSize, length, size, ptype0, pname1);
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, int* size, ref GLEnum type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (GLEnum* ptype1 = &type)
				{
					fixed (byte* pname2 = &name)
					{
						GetActiveVaryingNVNative(program, index, bufSize, plength0, size, ptype1, pname2);
					}
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, int* length, ref int size, ref GLEnum type, ref byte name)
		{
			fixed (int* psize0 = &size)
			{
				fixed (GLEnum* ptype1 = &type)
				{
					fixed (byte* pname2 = &name)
					{
						GetActiveVaryingNVNative(program, index, bufSize, length, psize0, ptype1, pname2);
					}
				}
			}
		}

		public static void GetActiveVaryingNV(uint program, uint index, int bufSize, ref int length, ref int size, ref GLEnum type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					fixed (GLEnum* ptype2 = &type)
					{
						fixed (byte* pname3 = &name)
						{
							GetActiveVaryingNVNative(program, index, bufSize, plength0, psize1, ptype2, pname3);
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetTransformFeedbackVaryingNVNative(uint program, uint index, int* location)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int*, void>)funcTable[7])(program, index, location);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, nint, void>)funcTable[7])(program, index, (nint)location);
			#endif
		}

		public static void GetTransformFeedbackVaryingNV(uint program, uint index, int* location)
		{
			GetTransformFeedbackVaryingNVNative(program, index, location);
		}

		public static void GetTransformFeedbackVaryingNV(uint program, uint index, ref int location)
		{
			fixed (int* plocation0 = &location)
			{
				GetTransformFeedbackVaryingNVNative(program, index, plocation0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetVaryingLocationNVNative(uint program, byte* name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte*, int>)funcTable[8])(program, name);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, nint, int>)funcTable[8])(program, (nint)name);
			#endif
		}

		public static int GetVaryingLocationNV(uint program, byte* name)
		{
			int ret = GetVaryingLocationNVNative(program, name);
			return ret;
		}

		public static int GetVaryingLocationNV(uint program, string name)
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
			int ret = GetVaryingLocationNVNative(program, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		public static int GetVaryingLocationNV(uint program, ReadOnlySpan<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				int ret = GetVaryingLocationNVNative(program, pname0);
				return ret;
			}
		}

		public static int GetVaryingLocationNV(uint program, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				int ret = GetVaryingLocationNVNative(program, pname0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TransformFeedbackAttribsNVNative(int count, int* attribs, GLEnum bufferMode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int*, GLEnum, void>)funcTable[9])(count, attribs, bufferMode);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, GLEnum, void>)funcTable[9])(count, (nint)attribs, bufferMode);
			#endif
		}

		public static void TransformFeedbackAttribsNV(int count, int* attribs, GLEnum bufferMode)
		{
			TransformFeedbackAttribsNVNative(count, attribs, bufferMode);
		}

		public static void TransformFeedbackAttribsNV(int count, ref int attribs, GLEnum bufferMode)
		{
			fixed (int* pattribs0 = &attribs)
			{
				TransformFeedbackAttribsNVNative(count, pattribs0, bufferMode);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TransformFeedbackStreamAttribsNVNative(int count, int* attribs, int nbuffers, int* bufstreams, GLEnum bufferMode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int*, int, int*, GLEnum, void>)funcTable[10])(count, attribs, nbuffers, bufstreams, bufferMode);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, int, nint, GLEnum, void>)funcTable[10])(count, (nint)attribs, nbuffers, (nint)bufstreams, bufferMode);
			#endif
		}

		public static void TransformFeedbackStreamAttribsNV(int count, int* attribs, int nbuffers, int* bufstreams, GLEnum bufferMode)
		{
			TransformFeedbackStreamAttribsNVNative(count, attribs, nbuffers, bufstreams, bufferMode);
		}

		public static void TransformFeedbackStreamAttribsNV(int count, ref int attribs, int nbuffers, int* bufstreams, GLEnum bufferMode)
		{
			fixed (int* pattribs0 = &attribs)
			{
				TransformFeedbackStreamAttribsNVNative(count, pattribs0, nbuffers, bufstreams, bufferMode);
			}
		}

		public static void TransformFeedbackStreamAttribsNV(int count, int* attribs, int nbuffers, ref int bufstreams, GLEnum bufferMode)
		{
			fixed (int* pbufstreams0 = &bufstreams)
			{
				TransformFeedbackStreamAttribsNVNative(count, attribs, nbuffers, pbufstreams0, bufferMode);
			}
		}

		public static void TransformFeedbackStreamAttribsNV(int count, ref int attribs, int nbuffers, ref int bufstreams, GLEnum bufferMode)
		{
			fixed (int* pattribs0 = &attribs)
			{
				fixed (int* pbufstreams1 = &bufstreams)
				{
					TransformFeedbackStreamAttribsNVNative(count, pattribs0, nbuffers, pbufstreams1, bufferMode);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TransformFeedbackVaryingsNVNative(uint program, int count, GLTransformFeedbackTokenNV locations, GLTransformFeedbackBufferMode bufferMode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLTransformFeedbackTokenNV, GLTransformFeedbackBufferMode, void>)funcTable[11])(program, count, locations, bufferMode);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLTransformFeedbackTokenNV, GLTransformFeedbackBufferMode, void>)funcTable[11])(program, count, locations, bufferMode);
			#endif
		}

		public static void TransformFeedbackVaryingsNV(uint program, int count, GLTransformFeedbackTokenNV locations, GLTransformFeedbackBufferMode bufferMode)
		{
			TransformFeedbackVaryingsNVNative(program, count, locations, bufferMode);
		}

	}
}
