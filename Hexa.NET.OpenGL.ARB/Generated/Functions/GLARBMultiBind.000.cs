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
	public static unsafe partial class GLARBMultiBind
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindBuffersBaseNative(GLBufferTargetARB target, uint first, int count, uint* buffers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, int, uint*, void>)funcTable[0])(target, first, count, buffers);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, int, nint, void>)funcTable[0])(target, first, count, (nint)buffers);
			#endif
		}

		public static void BindBuffersBase(GLBufferTargetARB target, uint first, int count, uint* buffers)
		{
			BindBuffersBaseNative(target, first, count, buffers);
		}

		public static void BindBuffersBase(GLBufferTargetARB target, uint first, int count, Span<uint> buffers)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				BindBuffersBaseNative(target, first, count, pbuffers0);
			}
		}

		public static void BindBuffersBase(GLBufferTargetARB target, uint first, int count, ref uint buffers)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				BindBuffersBaseNative(target, first, count, pbuffers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindBuffersRangeNative(GLBufferTargetARB target, uint first, int count, uint* buffers, nint* offsets, nint* sizes)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, int, uint*, nint*, nint*, void>)funcTable[1])(target, first, count, buffers, offsets, sizes);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, int, nint, nint, nint, void>)funcTable[1])(target, first, count, (nint)buffers, (nint)offsets, (nint)sizes);
			#endif
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, uint* buffers, nint* offsets, nint* sizes)
		{
			BindBuffersRangeNative(target, first, count, buffers, offsets, sizes);
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, Span<uint> buffers, nint* offsets, nint* sizes)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				BindBuffersRangeNative(target, first, count, pbuffers0, offsets, sizes);
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, ref uint buffers, nint* offsets, nint* sizes)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				BindBuffersRangeNative(target, first, count, pbuffers0, offsets, sizes);
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, uint* buffers, Span<nint> offsets, nint* sizes)
		{
			fixed (nint* poffsets0 = offsets)
			{
				BindBuffersRangeNative(target, first, count, buffers, poffsets0, sizes);
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, uint* buffers, ref nint offsets, nint* sizes)
		{
			fixed (nint* poffsets0 = &offsets)
			{
				BindBuffersRangeNative(target, first, count, buffers, poffsets0, sizes);
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, Span<uint> buffers, Span<nint> offsets, nint* sizes)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				fixed (nint* poffsets1 = offsets)
				{
					BindBuffersRangeNative(target, first, count, pbuffers0, poffsets1, sizes);
				}
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, ref uint buffers, ref nint offsets, nint* sizes)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (nint* poffsets1 = &offsets)
				{
					BindBuffersRangeNative(target, first, count, pbuffers0, poffsets1, sizes);
				}
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, uint* buffers, nint* offsets, Span<nint> sizes)
		{
			fixed (nint* psizes0 = sizes)
			{
				BindBuffersRangeNative(target, first, count, buffers, offsets, psizes0);
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, uint* buffers, nint* offsets, ref nint sizes)
		{
			fixed (nint* psizes0 = &sizes)
			{
				BindBuffersRangeNative(target, first, count, buffers, offsets, psizes0);
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, Span<uint> buffers, nint* offsets, Span<nint> sizes)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				fixed (nint* psizes1 = sizes)
				{
					BindBuffersRangeNative(target, first, count, pbuffers0, offsets, psizes1);
				}
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, ref uint buffers, nint* offsets, ref nint sizes)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (nint* psizes1 = &sizes)
				{
					BindBuffersRangeNative(target, first, count, pbuffers0, offsets, psizes1);
				}
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, uint* buffers, Span<nint> offsets, Span<nint> sizes)
		{
			fixed (nint* poffsets0 = offsets)
			{
				fixed (nint* psizes1 = sizes)
				{
					BindBuffersRangeNative(target, first, count, buffers, poffsets0, psizes1);
				}
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, uint* buffers, ref nint offsets, ref nint sizes)
		{
			fixed (nint* poffsets0 = &offsets)
			{
				fixed (nint* psizes1 = &sizes)
				{
					BindBuffersRangeNative(target, first, count, buffers, poffsets0, psizes1);
				}
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, Span<uint> buffers, Span<nint> offsets, Span<nint> sizes)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				fixed (nint* poffsets1 = offsets)
				{
					fixed (nint* psizes2 = sizes)
					{
						BindBuffersRangeNative(target, first, count, pbuffers0, poffsets1, psizes2);
					}
				}
			}
		}

		public static void BindBuffersRange(GLBufferTargetARB target, uint first, int count, ref uint buffers, ref nint offsets, ref nint sizes)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (nint* poffsets1 = &offsets)
				{
					fixed (nint* psizes2 = &sizes)
					{
						BindBuffersRangeNative(target, first, count, pbuffers0, poffsets1, psizes2);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindImageTexturesNative(uint first, int count, uint* textures)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint*, void>)funcTable[2])(first, count, textures);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[2])(first, count, (nint)textures);
			#endif
		}

		public static void BindImageTextures(uint first, int count, uint* textures)
		{
			BindImageTexturesNative(first, count, textures);
		}

		public static void BindImageTextures(uint first, int count, Span<uint> textures)
		{
			fixed (uint* ptextures0 = textures)
			{
				BindImageTexturesNative(first, count, ptextures0);
			}
		}

		public static void BindImageTextures(uint first, int count, ref uint textures)
		{
			fixed (uint* ptextures0 = &textures)
			{
				BindImageTexturesNative(first, count, ptextures0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindSamplersNative(uint first, int count, uint* samplers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint*, void>)funcTable[3])(first, count, samplers);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[3])(first, count, (nint)samplers);
			#endif
		}

		public static void BindSamplers(uint first, int count, uint* samplers)
		{
			BindSamplersNative(first, count, samplers);
		}

		public static void BindSamplers(uint first, int count, Span<uint> samplers)
		{
			fixed (uint* psamplers0 = samplers)
			{
				BindSamplersNative(first, count, psamplers0);
			}
		}

		public static void BindSamplers(uint first, int count, ref uint samplers)
		{
			fixed (uint* psamplers0 = &samplers)
			{
				BindSamplersNative(first, count, psamplers0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindTexturesNative(uint first, int count, uint* textures)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint*, void>)funcTable[4])(first, count, textures);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[4])(first, count, (nint)textures);
			#endif
		}

		public static void BindTextures(uint first, int count, uint* textures)
		{
			BindTexturesNative(first, count, textures);
		}

		public static void BindTextures(uint first, int count, Span<uint> textures)
		{
			fixed (uint* ptextures0 = textures)
			{
				BindTexturesNative(first, count, ptextures0);
			}
		}

		public static void BindTextures(uint first, int count, ref uint textures)
		{
			fixed (uint* ptextures0 = &textures)
			{
				BindTexturesNative(first, count, ptextures0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindVertexBuffersNative(uint first, int count, uint* buffers, nint* offsets, int* strides)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint*, nint*, int*, void>)funcTable[5])(first, count, buffers, offsets, strides);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, nint, void>)funcTable[5])(first, count, (nint)buffers, (nint)offsets, (nint)strides);
			#endif
		}

		public static void BindVertexBuffers(uint first, int count, uint* buffers, nint* offsets, int* strides)
		{
			BindVertexBuffersNative(first, count, buffers, offsets, strides);
		}

		public static void BindVertexBuffers(uint first, int count, Span<uint> buffers, nint* offsets, int* strides)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				BindVertexBuffersNative(first, count, pbuffers0, offsets, strides);
			}
		}

		public static void BindVertexBuffers(uint first, int count, ref uint buffers, nint* offsets, int* strides)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				BindVertexBuffersNative(first, count, pbuffers0, offsets, strides);
			}
		}

		public static void BindVertexBuffers(uint first, int count, uint* buffers, Span<nint> offsets, int* strides)
		{
			fixed (nint* poffsets0 = offsets)
			{
				BindVertexBuffersNative(first, count, buffers, poffsets0, strides);
			}
		}

		public static void BindVertexBuffers(uint first, int count, uint* buffers, ref nint offsets, int* strides)
		{
			fixed (nint* poffsets0 = &offsets)
			{
				BindVertexBuffersNative(first, count, buffers, poffsets0, strides);
			}
		}

		public static void BindVertexBuffers(uint first, int count, Span<uint> buffers, Span<nint> offsets, int* strides)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				fixed (nint* poffsets1 = offsets)
				{
					BindVertexBuffersNative(first, count, pbuffers0, poffsets1, strides);
				}
			}
		}

		public static void BindVertexBuffers(uint first, int count, ref uint buffers, ref nint offsets, int* strides)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (nint* poffsets1 = &offsets)
				{
					BindVertexBuffersNative(first, count, pbuffers0, poffsets1, strides);
				}
			}
		}

		public static void BindVertexBuffers(uint first, int count, uint* buffers, nint* offsets, Span<int> strides)
		{
			fixed (int* pstrides0 = strides)
			{
				BindVertexBuffersNative(first, count, buffers, offsets, pstrides0);
			}
		}

		public static void BindVertexBuffers(uint first, int count, uint* buffers, nint* offsets, ref int strides)
		{
			fixed (int* pstrides0 = &strides)
			{
				BindVertexBuffersNative(first, count, buffers, offsets, pstrides0);
			}
		}

		public static void BindVertexBuffers(uint first, int count, Span<uint> buffers, nint* offsets, Span<int> strides)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				fixed (int* pstrides1 = strides)
				{
					BindVertexBuffersNative(first, count, pbuffers0, offsets, pstrides1);
				}
			}
		}

		public static void BindVertexBuffers(uint first, int count, ref uint buffers, nint* offsets, ref int strides)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (int* pstrides1 = &strides)
				{
					BindVertexBuffersNative(first, count, pbuffers0, offsets, pstrides1);
				}
			}
		}

		public static void BindVertexBuffers(uint first, int count, uint* buffers, Span<nint> offsets, Span<int> strides)
		{
			fixed (nint* poffsets0 = offsets)
			{
				fixed (int* pstrides1 = strides)
				{
					BindVertexBuffersNative(first, count, buffers, poffsets0, pstrides1);
				}
			}
		}

		public static void BindVertexBuffers(uint first, int count, uint* buffers, ref nint offsets, ref int strides)
		{
			fixed (nint* poffsets0 = &offsets)
			{
				fixed (int* pstrides1 = &strides)
				{
					BindVertexBuffersNative(first, count, buffers, poffsets0, pstrides1);
				}
			}
		}

		public static void BindVertexBuffers(uint first, int count, Span<uint> buffers, Span<nint> offsets, Span<int> strides)
		{
			fixed (uint* pbuffers0 = buffers)
			{
				fixed (nint* poffsets1 = offsets)
				{
					fixed (int* pstrides2 = strides)
					{
						BindVertexBuffersNative(first, count, pbuffers0, poffsets1, pstrides2);
					}
				}
			}
		}

		public static void BindVertexBuffers(uint first, int count, ref uint buffers, ref nint offsets, ref int strides)
		{
			fixed (uint* pbuffers0 = &buffers)
			{
				fixed (nint* poffsets1 = &offsets)
				{
					fixed (int* pstrides2 = &strides)
					{
						BindVertexBuffersNative(first, count, pbuffers0, poffsets1, pstrides2);
					}
				}
			}
		}

	}
}
