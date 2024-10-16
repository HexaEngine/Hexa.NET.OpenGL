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
	public static unsafe partial class GLNVXGpuMulticast2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint AsyncCopyBufferSubDataNVXNative(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<int, uint*, ulong*, uint, uint, uint, uint, nint, nint, nint, int, uint*, ulong*, uint>)funcTable[0])(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<int, nint, nint, uint, uint, uint, uint, nint, nint, nint, int, nint, nint, uint>)funcTable[0])(waitSemaphoreCount, (nint)waitSemaphoreArray, (nint)fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, (nint)signalSemaphoreArray, (nint)signalValueArray);
			#endif
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
			return ret;
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
				return ret;
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (ulong* pfenceValueArray0 = &fenceValueArray)
			{
				uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pfenceValueArray0, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
				return ret;
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pfenceValueArray1 = &fenceValueArray)
				{
					uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pfenceValueArray1, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
					return ret;
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* psignalSemaphoreArray0 = &signalSemaphoreArray)
			{
				uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray0, signalValueArray);
				return ret;
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray1, signalValueArray);
					return ret;
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (ulong* pfenceValueArray0 = &fenceValueArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pfenceValueArray0, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray1, signalValueArray);
					return ret;
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pfenceValueArray1 = &fenceValueArray)
				{
					fixed (uint* psignalSemaphoreArray2 = &signalSemaphoreArray)
					{
						uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pfenceValueArray1, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray2, signalValueArray);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (ulong* psignalValueArray0 = &signalValueArray)
			{
				uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray0);
				return ret;
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* psignalValueArray1 = &signalValueArray)
				{
					uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray1);
					return ret;
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (ulong* pfenceValueArray0 = &fenceValueArray)
			{
				fixed (ulong* psignalValueArray1 = &signalValueArray)
				{
					uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pfenceValueArray0, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray1);
					return ret;
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pfenceValueArray1 = &fenceValueArray)
				{
					fixed (ulong* psignalValueArray2 = &signalValueArray)
					{
						uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pfenceValueArray1, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray2);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* psignalSemaphoreArray0 = &signalSemaphoreArray)
			{
				fixed (ulong* psignalValueArray1 = &signalValueArray)
				{
					uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray0, psignalValueArray1);
					return ret;
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					fixed (ulong* psignalValueArray2 = &signalValueArray)
					{
						uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray1, psignalValueArray2);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (ulong* pfenceValueArray0 = &fenceValueArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					fixed (ulong* psignalValueArray2 = &signalValueArray)
					{
						uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pfenceValueArray0, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray1, psignalValueArray2);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pfenceValueArray1 = &fenceValueArray)
				{
					fixed (uint* psignalSemaphoreArray2 = &signalSemaphoreArray)
					{
						fixed (ulong* psignalValueArray3 = &signalValueArray)
						{
							uint ret = AsyncCopyBufferSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pfenceValueArray1, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreCount, psignalSemaphoreArray2, psignalValueArray3);
							return ret;
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint AsyncCopyImageSubDataNVXNative(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<int, uint*, ulong*, uint, uint, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, int, uint*, ulong*, uint>)funcTable[1])(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<int, nint, nint, uint, uint, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, int, nint, nint, uint>)funcTable[1])(waitSemaphoreCount, (nint)waitSemaphoreArray, (nint)waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, (nint)signalSemaphoreArray, (nint)signalValueArray);
			#endif
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
			return ret;
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
				return ret;
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (ulong* pwaitValueArray0 = &waitValueArray)
			{
				uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pwaitValueArray0, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
				return ret;
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pwaitValueArray1 = &waitValueArray)
				{
					uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pwaitValueArray1, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
					return ret;
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* psignalSemaphoreArray0 = &signalSemaphoreArray)
			{
				uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray0, signalValueArray);
				return ret;
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray1, signalValueArray);
					return ret;
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (ulong* pwaitValueArray0 = &waitValueArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pwaitValueArray0, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray1, signalValueArray);
					return ret;
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ulong* signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pwaitValueArray1 = &waitValueArray)
				{
					fixed (uint* psignalSemaphoreArray2 = &signalSemaphoreArray)
					{
						uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pwaitValueArray1, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray2, signalValueArray);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (ulong* psignalValueArray0 = &signalValueArray)
			{
				uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray0);
				return ret;
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* psignalValueArray1 = &signalValueArray)
				{
					uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray1);
					return ret;
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (ulong* pwaitValueArray0 = &waitValueArray)
			{
				fixed (ulong* psignalValueArray1 = &signalValueArray)
				{
					uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pwaitValueArray0, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray1);
					return ret;
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pwaitValueArray1 = &waitValueArray)
				{
					fixed (ulong* psignalValueArray2 = &signalValueArray)
					{
						uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pwaitValueArray1, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, signalSemaphoreArray, psignalValueArray2);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* psignalSemaphoreArray0 = &signalSemaphoreArray)
			{
				fixed (ulong* psignalValueArray1 = &signalValueArray)
				{
					uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray0, psignalValueArray1);
					return ret;
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					fixed (ulong* psignalValueArray2 = &signalValueArray)
					{
						uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray1, psignalValueArray2);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (ulong* pwaitValueArray0 = &waitValueArray)
			{
				fixed (uint* psignalSemaphoreArray1 = &signalSemaphoreArray)
				{
					fixed (ulong* psignalValueArray2 = &signalValueArray)
					{
						uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, waitSemaphoreArray, pwaitValueArray0, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray1, psignalValueArray2);
						return ret;
					}
				}
			}
		}

		public static uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount, ref uint waitSemaphoreArray, ref ulong waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, ref uint signalSemaphoreArray, ref ulong signalValueArray)
		{
			fixed (uint* pwaitSemaphoreArray0 = &waitSemaphoreArray)
			{
				fixed (ulong* pwaitValueArray1 = &waitValueArray)
				{
					fixed (uint* psignalSemaphoreArray2 = &signalSemaphoreArray)
					{
						fixed (ulong* psignalValueArray3 = &signalValueArray)
						{
							uint ret = AsyncCopyImageSubDataNVXNative(waitSemaphoreCount, pwaitSemaphoreArray0, pwaitValueArray1, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreCount, psignalSemaphoreArray2, psignalValueArray3);
							return ret;
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastScissorArrayvNVXNative(uint gpu, uint first, int count, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, int*, void>)funcTable[2])(gpu, first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, nint, void>)funcTable[2])(gpu, first, count, (nint)v);
			#endif
		}

		public static void MulticastScissorArrayvNVX(uint gpu, uint first, int count, int* v)
		{
			MulticastScissorArrayvNVXNative(gpu, first, count, v);
		}

		public static void MulticastScissorArrayvNVX(uint gpu, uint first, int count, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				MulticastScissorArrayvNVXNative(gpu, first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastViewportArrayvNVXNative(uint gpu, uint first, int count, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, float*, void>)funcTable[3])(gpu, first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, nint, void>)funcTable[3])(gpu, first, count, (nint)v);
			#endif
		}

		public static void MulticastViewportArrayvNVX(uint gpu, uint first, int count, float* v)
		{
			MulticastViewportArrayvNVXNative(gpu, first, count, v);
		}

		public static void MulticastViewportArrayvNVX(uint gpu, uint first, int count, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				MulticastViewportArrayvNVXNative(gpu, first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastViewportPositionWScaleNVXNative(uint gpu, uint index, float xcoeff, float ycoeff)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, void>)funcTable[4])(gpu, index, xcoeff, ycoeff);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, float, float, void>)funcTable[4])(gpu, index, xcoeff, ycoeff);
			#endif
		}

		public static void MulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff)
		{
			MulticastViewportPositionWScaleNVXNative(gpu, index, xcoeff, ycoeff);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UploadGpuMaskNVXNative(uint mask)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[5])(mask);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[5])(mask);
			#endif
		}

		public static void UploadGpuMaskNVX(uint mask)
		{
			UploadGpuMaskNVXNative(mask);
		}

	}
}