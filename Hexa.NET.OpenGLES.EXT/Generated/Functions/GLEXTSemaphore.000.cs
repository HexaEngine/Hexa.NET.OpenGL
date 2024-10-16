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

namespace Hexa.NET.OpenGLES.EXT
{
	public static unsafe partial class GLEXTSemaphore
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteSemaphoresEXTNative(int n, uint* semaphores)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[0])(n, semaphores);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[0])(n, (nint)semaphores);
			#endif
		}

		public static void DeleteSemaphoresEXT(int n, uint* semaphores)
		{
			DeleteSemaphoresEXTNative(n, semaphores);
		}

		public static void DeleteSemaphoresEXT(int n, ref uint semaphores)
		{
			fixed (uint* psemaphores0 = &semaphores)
			{
				DeleteSemaphoresEXTNative(n, psemaphores0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenSemaphoresEXTNative(int n, uint* semaphores)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(n, semaphores);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)semaphores);
			#endif
		}

		public static void GenSemaphoresEXT(int n, uint* semaphores)
		{
			GenSemaphoresEXTNative(n, semaphores);
		}

		public static void GenSemaphoresEXT(int n, ref uint semaphores)
		{
			fixed (uint* psemaphores0 = &semaphores)
			{
				GenSemaphoresEXTNative(n, psemaphores0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetSemaphoreParameterui64vEXTNative(uint semaphore, GLSemaphoreParameterName pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSemaphoreParameterName, ulong*, void>)funcTable[2])(semaphore, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSemaphoreParameterName, nint, void>)funcTable[2])(semaphore, pname, (nint)@params);
			#endif
		}

		public static void GetSemaphoreParameterui64vEXT(uint semaphore, GLSemaphoreParameterName pname, ulong* @params)
		{
			GetSemaphoreParameterui64vEXTNative(semaphore, pname, @params);
		}

		public static void GetSemaphoreParameterui64vEXT(uint semaphore, GLSemaphoreParameterName pname, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				GetSemaphoreParameterui64vEXTNative(semaphore, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetUnsignedBytevEXTNative(GLGetPName pname, byte* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetPName, byte*, void>)funcTable[3])(pname, data);
			#else
			((delegate* unmanaged[Cdecl]<GLGetPName, nint, void>)funcTable[3])(pname, (nint)data);
			#endif
		}

		public static void GetUnsignedBytevEXT(GLGetPName pname, byte* data)
		{
			GetUnsignedBytevEXTNative(pname, data);
		}

		public static void GetUnsignedBytevEXT(GLGetPName pname, string data)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (data != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(data);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(data, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetUnsignedBytevEXTNative(pname, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetUnsignedBytevEXT(GLGetPName pname, ReadOnlySpan<byte> data)
		{
			fixed (byte* pdata0 = data)
			{
				GetUnsignedBytevEXTNative(pname, pdata0);
			}
		}

		public static void GetUnsignedBytevEXT(GLGetPName pname, ref byte data)
		{
			fixed (byte* pdata0 = &data)
			{
				GetUnsignedBytevEXTNative(pname, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetUnsignedBytei_vEXTNative(GLEnum target, uint index, byte* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, byte*, void>)funcTable[4])(target, index, data);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, nint, void>)funcTable[4])(target, index, (nint)data);
			#endif
		}

		public static void GetUnsignedBytei_vEXT(GLEnum target, uint index, byte* data)
		{
			GetUnsignedBytei_vEXTNative(target, index, data);
		}

		public static void GetUnsignedBytei_vEXT(GLEnum target, uint index, string data)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (data != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(data);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(data, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetUnsignedBytei_vEXTNative(target, index, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetUnsignedBytei_vEXT(GLEnum target, uint index, ReadOnlySpan<byte> data)
		{
			fixed (byte* pdata0 = data)
			{
				GetUnsignedBytei_vEXTNative(target, index, pdata0);
			}
		}

		public static void GetUnsignedBytei_vEXT(GLEnum target, uint index, ref byte data)
		{
			fixed (byte* pdata0 = &data)
			{
				GetUnsignedBytei_vEXTNative(target, index, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsSemaphoreEXTNative(uint semaphore)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[5])(semaphore);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[5])(semaphore);
			#endif
		}

		public static bool IsSemaphoreEXT(uint semaphore)
		{
			byte ret = IsSemaphoreEXTNative(semaphore);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SemaphoreParameterui64vEXTNative(uint semaphore, GLSemaphoreParameterName pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLSemaphoreParameterName, ulong*, void>)funcTable[6])(semaphore, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLSemaphoreParameterName, nint, void>)funcTable[6])(semaphore, pname, (nint)@params);
			#endif
		}

		public static void SemaphoreParameterui64vEXT(uint semaphore, GLSemaphoreParameterName pname, ulong* @params)
		{
			SemaphoreParameterui64vEXTNative(semaphore, pname, @params);
		}

		public static void SemaphoreParameterui64vEXT(uint semaphore, GLSemaphoreParameterName pname, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				SemaphoreParameterui64vEXTNative(semaphore, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SignalSemaphoreEXTNative(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, GLTextureLayout dstLayouts)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint*, uint, uint*, GLTextureLayout, void>)funcTable[7])(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, nint, uint, nint, GLTextureLayout, void>)funcTable[7])(semaphore, numBufferBarriers, (nint)buffers, numTextureBarriers, (nint)textures, dstLayouts);
			#endif
		}

		public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, GLTextureLayout dstLayouts)
		{
			SignalSemaphoreEXTNative(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);
		}

		public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, ref uint buffers, uint numTextureBarriers, uint* textures, GLTextureLayout dstLayouts)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				SignalSemaphoreEXTNative(semaphore, numBufferBarriers, pbuffers0, numTextureBarriers, textures, dstLayouts);
			}
		}

		public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, ref uint textures, GLTextureLayout dstLayouts)
		{
			fixed (uint* ptextures0 = &textures)
			{
				SignalSemaphoreEXTNative(semaphore, numBufferBarriers, buffers, numTextureBarriers, ptextures0, dstLayouts);
			}
		}

		public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, ref uint buffers, uint numTextureBarriers, ref uint textures, GLTextureLayout dstLayouts)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (uint* ptextures1 = &textures)
				{
					SignalSemaphoreEXTNative(semaphore, numBufferBarriers, pbuffers0, numTextureBarriers, ptextures1, dstLayouts);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WaitSemaphoreEXTNative(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, GLTextureLayout srcLayouts)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint*, uint, uint*, GLTextureLayout, void>)funcTable[8])(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, nint, uint, nint, GLTextureLayout, void>)funcTable[8])(semaphore, numBufferBarriers, (nint)buffers, numTextureBarriers, (nint)textures, srcLayouts);
			#endif
		}

		public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, GLTextureLayout srcLayouts)
		{
			WaitSemaphoreEXTNative(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);
		}

		public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, ref uint buffers, uint numTextureBarriers, uint* textures, GLTextureLayout srcLayouts)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				WaitSemaphoreEXTNative(semaphore, numBufferBarriers, pbuffers0, numTextureBarriers, textures, srcLayouts);
			}
		}

		public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, ref uint textures, GLTextureLayout srcLayouts)
		{
			fixed (uint* ptextures0 = &textures)
			{
				WaitSemaphoreEXTNative(semaphore, numBufferBarriers, buffers, numTextureBarriers, ptextures0, srcLayouts);
			}
		}

		public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, ref uint buffers, uint numTextureBarriers, ref uint textures, GLTextureLayout srcLayouts)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (uint* ptextures1 = &textures)
				{
					WaitSemaphoreEXTNative(semaphore, numBufferBarriers, pbuffers0, numTextureBarriers, ptextures1, srcLayouts);
				}
			}
		}

	}
}
