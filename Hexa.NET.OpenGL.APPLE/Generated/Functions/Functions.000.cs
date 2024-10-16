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

namespace Hexa.NET.OpenGL.APPLE
{
	public static unsafe partial class GLAPPLE
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindVertexArrayAPPLENative(uint array)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#endif
		}

		public static void BindVertexArrayAPPLE(uint array)
		{
			BindVertexArrayAPPLENative(array);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BufferParameteriAPPLENative(GLEnum target, GLEnum pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, int, void>)funcTable[1])(target, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, int, void>)funcTable[1])(target, pname, param);
			#endif
		}

		public static void BufferParameteriAPPLE(GLEnum target, GLEnum pname, int param)
		{
			BufferParameteriAPPLENative(target, pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteFencesAPPLENative(int n, uint* fences)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(n, fences);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(n, (nint)fences);
			#endif
		}

		public static void DeleteFencesAPPLE(int n, uint* fences)
		{
			DeleteFencesAPPLENative(n, fences);
		}

		public static void DeleteFencesAPPLE(int n, ref uint fences)
		{
			fixed (uint* pfences0 = &fences)
			{
				DeleteFencesAPPLENative(n, pfences0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteVertexArraysAPPLENative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[3])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[3])(n, (nint)arrays);
			#endif
		}

		public static void DeleteVertexArraysAPPLE(int n, uint* arrays)
		{
			DeleteVertexArraysAPPLENative(n, arrays);
		}

		public static void DeleteVertexArraysAPPLE(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				DeleteVertexArraysAPPLENative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DisableVertexAttribAPPLENative(uint index, GLEnum pname)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[4])(index, pname);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[4])(index, pname);
			#endif
		}

		public static void DisableVertexAttribAPPLE(uint index, GLEnum pname)
		{
			DisableVertexAttribAPPLENative(index, pname);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawElementArrayAPPLENative(GLPrimitiveType mode, int first, int count)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, void>)funcTable[5])(mode, first, count);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int, int, void>)funcTable[5])(mode, first, count);
			#endif
		}

		public static void DrawElementArrayAPPLE(GLPrimitiveType mode, int first, int count)
		{
			DrawElementArrayAPPLENative(mode, first, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawRangeElementArrayAPPLENative(GLPrimitiveType mode, uint start, uint end, int first, int count)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, int, int, void>)funcTable[6])(mode, start, end, first, count);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, int, int, void>)funcTable[6])(mode, start, end, first, count);
			#endif
		}

		public static void DrawRangeElementArrayAPPLE(GLPrimitiveType mode, uint start, uint end, int first, int count)
		{
			DrawRangeElementArrayAPPLENative(mode, start, end, first, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ElementPointerAPPLENative(GLElementPointerTypeATI type, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLElementPointerTypeATI, void*, void>)funcTable[7])(type, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLElementPointerTypeATI, nint, void>)funcTable[7])(type, (nint)pointer);
			#endif
		}

		public static void ElementPointerAPPLE(GLElementPointerTypeATI type, void* pointer)
		{
			ElementPointerAPPLENative(type, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EnableVertexAttribAPPLENative(uint index, GLEnum pname)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[8])(index, pname);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[8])(index, pname);
			#endif
		}

		public static void EnableVertexAttribAPPLE(uint index, GLEnum pname)
		{
			EnableVertexAttribAPPLENative(index, pname);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FinishFenceAPPLENative(uint fence)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[9])(fence);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[9])(fence);
			#endif
		}

		public static void FinishFenceAPPLE(uint fence)
		{
			FinishFenceAPPLENative(fence);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FinishObjectAPPLENative(GLObjectTypeAPPLE @object, int name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLObjectTypeAPPLE, int, void>)funcTable[10])(@object, name);
			#else
			((delegate* unmanaged[Cdecl]<GLObjectTypeAPPLE, int, void>)funcTable[10])(@object, name);
			#endif
		}

		public static void FinishObjectAPPLE(GLObjectTypeAPPLE @object, int name)
		{
			FinishObjectAPPLENative(@object, name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FlushMappedBufferRangeAPPLENative(GLBufferTargetARB target, nint offset, nint size)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, nint, nint, void>)funcTable[11])(target, offset, size);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, nint, nint, void>)funcTable[11])(target, offset, size);
			#endif
		}

		public static void FlushMappedBufferRangeAPPLE(GLBufferTargetARB target, nint offset, nint size)
		{
			FlushMappedBufferRangeAPPLENative(target, offset, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FlushVertexArrayRangeAPPLENative(int length, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, void*, void>)funcTable[12])(length, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[12])(length, (nint)pointer);
			#endif
		}

		public static void FlushVertexArrayRangeAPPLE(int length, void* pointer)
		{
			FlushVertexArrayRangeAPPLENative(length, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenFencesAPPLENative(int n, uint* fences)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[13])(n, fences);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[13])(n, (nint)fences);
			#endif
		}

		public static void GenFencesAPPLE(int n, uint* fences)
		{
			GenFencesAPPLENative(n, fences);
		}

		public static void GenFencesAPPLE(int n, ref uint fences)
		{
			fixed (uint* pfences0 = &fences)
			{
				GenFencesAPPLENative(n, pfences0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenVertexArraysAPPLENative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[14])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[14])(n, (nint)arrays);
			#endif
		}

		public static void GenVertexArraysAPPLE(int n, uint* arrays)
		{
			GenVertexArraysAPPLENative(n, arrays);
		}

		public static void GenVertexArraysAPPLE(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				GenVertexArraysAPPLENative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetObjectParameterivAPPLENative(GLEnum objectType, uint name, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, int*, void>)funcTable[15])(objectType, name, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, nint, void>)funcTable[15])(objectType, name, pname, (nint)@params);
			#endif
		}

		public static void GetObjectParameterivAPPLE(GLEnum objectType, uint name, GLEnum pname, int* @params)
		{
			GetObjectParameterivAPPLENative(objectType, name, pname, @params);
		}

		public static void GetObjectParameterivAPPLE(GLEnum objectType, uint name, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetObjectParameterivAPPLENative(objectType, name, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetTexParameterPointervAPPLENative(GLEnum target, GLEnum pname, void** @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, void**, void>)funcTable[16])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, nint, void>)funcTable[16])(target, pname, (nint)@params);
			#endif
		}

		public static void GetTexParameterPointervAPPLE(GLEnum target, GLEnum pname, void** @params)
		{
			GetTexParameterPointervAPPLENative(target, pname, @params);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsFenceAPPLENative(uint fence)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[17])(fence);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[17])(fence);
			#endif
		}

		public static bool IsFenceAPPLE(uint fence)
		{
			byte ret = IsFenceAPPLENative(fence);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsVertexArrayAPPLENative(uint array)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[18])(array);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[18])(array);
			#endif
		}

		public static bool IsVertexArrayAPPLE(uint array)
		{
			byte ret = IsVertexArrayAPPLENative(array);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsVertexAttribEnabledAPPLENative(uint index, GLEnum pname)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, GLEnum, byte>)funcTable[19])(index, pname);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, GLEnum, byte>)funcTable[19])(index, pname);
			#endif
		}

		public static bool IsVertexAttribEnabledAPPLE(uint index, GLEnum pname)
		{
			byte ret = IsVertexAttribEnabledAPPLENative(index, pname);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MapVertexAttrib1dAPPLENative(uint index, uint size, double u1, double u2, int stride, int order, double* points)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, double, double, int, int, double*, void>)funcTable[20])(index, size, u1, u2, stride, order, points);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, double, double, int, int, nint, void>)funcTable[20])(index, size, u1, u2, stride, order, (nint)points);
			#endif
		}

		public static void MapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double* points)
		{
			MapVertexAttrib1dAPPLENative(index, size, u1, u2, stride, order, points);
		}

		public static void MapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, ref double points)
		{
			fixed (double* ppoints0 = &points)
			{
				MapVertexAttrib1dAPPLENative(index, size, u1, u2, stride, order, ppoints0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MapVertexAttrib1fAPPLENative(uint index, uint size, float u1, float u2, int stride, int order, float* points)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, int, int, float*, void>)funcTable[21])(index, size, u1, u2, stride, order, points);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, int, int, nint, void>)funcTable[21])(index, size, u1, u2, stride, order, (nint)points);
			#endif
		}

		public static void MapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float* points)
		{
			MapVertexAttrib1fAPPLENative(index, size, u1, u2, stride, order, points);
		}

		public static void MapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, ref float points)
		{
			fixed (float* ppoints0 = &points)
			{
				MapVertexAttrib1fAPPLENative(index, size, u1, u2, stride, order, ppoints0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MapVertexAttrib2dAPPLENative(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, double, double, int, int, double, double, int, int, double*, void>)funcTable[22])(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, double, double, int, int, double, double, int, int, nint, void>)funcTable[22])(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (nint)points);
			#endif
		}

		public static void MapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points)
		{
			MapVertexAttrib2dAPPLENative(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}

		public static void MapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, ref double points)
		{
			fixed (double* ppoints0 = &points)
			{
				MapVertexAttrib2dAPPLENative(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ppoints0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MapVertexAttrib2fAPPLENative(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, int, int, float, float, int, int, float*, void>)funcTable[23])(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, int, int, float, float, int, int, nint, void>)funcTable[23])(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (nint)points);
			#endif
		}

		public static void MapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points)
		{
			MapVertexAttrib2fAPPLENative(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		}

		public static void MapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, ref float points)
		{
			fixed (float* ppoints0 = &points)
			{
				MapVertexAttrib2fAPPLENative(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ppoints0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawElementArrayAPPLENative(GLPrimitiveType mode, int* first, int* count, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, int*, int*, int, void>)funcTable[24])(mode, first, count, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, nint, nint, int, void>)funcTable[24])(mode, (nint)first, (nint)count, primcount);
			#endif
		}

		public static void MultiDrawElementArrayAPPLE(GLPrimitiveType mode, int* first, int* count, int primcount)
		{
			MultiDrawElementArrayAPPLENative(mode, first, count, primcount);
		}

		public static void MultiDrawElementArrayAPPLE(GLPrimitiveType mode, ref int first, int* count, int primcount)
		{
			fixed (int* pfirst0 = &first)
			{
				MultiDrawElementArrayAPPLENative(mode, pfirst0, count, primcount);
			}
		}

		public static void MultiDrawElementArrayAPPLE(GLPrimitiveType mode, int* first, ref int count, int primcount)
		{
			fixed (int* pcount0 = &count)
			{
				MultiDrawElementArrayAPPLENative(mode, first, pcount0, primcount);
			}
		}

		public static void MultiDrawElementArrayAPPLE(GLPrimitiveType mode, ref int first, ref int count, int primcount)
		{
			fixed (int* pfirst0 = &first)
			{
				fixed (int* pcount1 = &count)
				{
					MultiDrawElementArrayAPPLENative(mode, pfirst0, pcount1, primcount);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawRangeElementArrayAPPLENative(GLPrimitiveType mode, uint start, uint end, int* first, int* count, int primcount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, int*, int*, int, void>)funcTable[25])(mode, start, end, first, count, primcount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, nint, nint, int, void>)funcTable[25])(mode, start, end, (nint)first, (nint)count, primcount);
			#endif
		}

		public static void MultiDrawRangeElementArrayAPPLE(GLPrimitiveType mode, uint start, uint end, int* first, int* count, int primcount)
		{
			MultiDrawRangeElementArrayAPPLENative(mode, start, end, first, count, primcount);
		}

		public static void MultiDrawRangeElementArrayAPPLE(GLPrimitiveType mode, uint start, uint end, ref int first, int* count, int primcount)
		{
			fixed (int* pfirst0 = &first)
			{
				MultiDrawRangeElementArrayAPPLENative(mode, start, end, pfirst0, count, primcount);
			}
		}

		public static void MultiDrawRangeElementArrayAPPLE(GLPrimitiveType mode, uint start, uint end, int* first, ref int count, int primcount)
		{
			fixed (int* pcount0 = &count)
			{
				MultiDrawRangeElementArrayAPPLENative(mode, start, end, first, pcount0, primcount);
			}
		}

		public static void MultiDrawRangeElementArrayAPPLE(GLPrimitiveType mode, uint start, uint end, ref int first, ref int count, int primcount)
		{
			fixed (int* pfirst0 = &first)
			{
				fixed (int* pcount1 = &count)
				{
					MultiDrawRangeElementArrayAPPLENative(mode, start, end, pfirst0, pcount1, primcount);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum ObjectPurgeableAPPLENative(GLEnum objectType, uint name, GLEnum option)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[26])(objectType, name, option);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[26])(objectType, name, option);
			#endif
		}

		public static GLEnum ObjectPurgeableAPPLE(GLEnum objectType, uint name, GLEnum option)
		{
			GLEnum ret = ObjectPurgeableAPPLENative(objectType, name, option);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum ObjectUnpurgeableAPPLENative(GLEnum objectType, uint name, GLEnum option)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[27])(objectType, name, option);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[27])(objectType, name, option);
			#endif
		}

		public static GLEnum ObjectUnpurgeableAPPLE(GLEnum objectType, uint name, GLEnum option)
		{
			GLEnum ret = ObjectUnpurgeableAPPLENative(objectType, name, option);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetFenceAPPLENative(uint fence)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[28])(fence);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[28])(fence);
			#endif
		}

		public static void SetFenceAPPLE(uint fence)
		{
			SetFenceAPPLENative(fence);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte TestFenceAPPLENative(uint fence)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[29])(fence);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[29])(fence);
			#endif
		}

		public static bool TestFenceAPPLE(uint fence)
		{
			byte ret = TestFenceAPPLENative(fence);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte TestObjectAPPLENative(GLObjectTypeAPPLE @object, uint name)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLObjectTypeAPPLE, uint, byte>)funcTable[30])(@object, name);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<GLObjectTypeAPPLE, uint, byte>)funcTable[30])(@object, name);
			#endif
		}

		public static bool TestObjectAPPLE(GLObjectTypeAPPLE @object, uint name)
		{
			byte ret = TestObjectAPPLENative(@object, name);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureRangeAPPLENative(GLEnum target, int length, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void*, void>)funcTable[31])(target, length, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, nint, void>)funcTable[31])(target, length, (nint)pointer);
			#endif
		}

		public static void TextureRangeAPPLE(GLEnum target, int length, void* pointer)
		{
			TextureRangeAPPLENative(target, length, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexArrayParameteriAPPLENative(GLVertexArrayPNameAPPLE pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLVertexArrayPNameAPPLE, int, void>)funcTable[32])(pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLVertexArrayPNameAPPLE, int, void>)funcTable[32])(pname, param);
			#endif
		}

		public static void VertexArrayParameteriAPPLE(GLVertexArrayPNameAPPLE pname, int param)
		{
			VertexArrayParameteriAPPLENative(pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexArrayRangeAPPLENative(int length, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, void*, void>)funcTable[33])(length, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[33])(length, (nint)pointer);
			#endif
		}

		public static void VertexArrayRangeAPPLE(int length, void* pointer)
		{
			VertexArrayRangeAPPLENative(length, pointer);
		}

	}
}
