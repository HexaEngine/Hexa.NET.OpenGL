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
	public unsafe partial class GLNVHalfFloat
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Color3hNVNative(Half red, Half green, Half blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[0])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[0])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color3hNV(Half red, Half green, Half blue)
		{
			Color3hNVNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Color3hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[1])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[1])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color3hvNV(Half* v)
		{
			Color3hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color3hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				Color3hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color3hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				Color3hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Color4hNVNative(Half red, Half green, Half blue, Half alpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, Half, void>)funcTable[2])(red, green, blue, alpha);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, Half, void>)funcTable[2])(red, green, blue, alpha);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color4hNV(Half red, Half green, Half blue, Half alpha)
		{
			Color4hNVNative(red, green, blue, alpha);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Color4hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[3])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[3])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color4hvNV(Half* v)
		{
			Color4hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color4hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				Color4hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Color4hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				Color4hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FogCoordhNVNative(Half fog)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, void>)funcTable[4])(fog);
			#else
			((delegate* unmanaged[Cdecl]<Half, void>)funcTable[4])(fog);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void FogCoordhNV(Half fog)
		{
			FogCoordhNVNative(fog);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FogCoordhvNVNative(Half* fog)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[5])(fog);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[5])((nint)fog);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void FogCoordhvNV(Half* fog)
		{
			FogCoordhvNVNative(fog);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void FogCoordhvNV(Span<Half> fog)
		{
			fixed (Half* pfog0 = fog)
			{
				FogCoordhvNVNative(pfog0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void FogCoordhvNV(ref Half fog)
		{
			fixed (Half* pfog0 = &fog)
			{
				FogCoordhvNVNative(pfog0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord1hNVNative(GLTextureUnit target, Half s)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, void>)funcTable[6])(target, s);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, void>)funcTable[6])(target, s);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord1hNV(GLTextureUnit target, Half s)
		{
			MultiTexCoord1hNVNative(target, s);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord1hvNVNative(GLTextureUnit target, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half*, void>)funcTable[7])(target, v);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, nint, void>)funcTable[7])(target, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord1hvNV(GLTextureUnit target, Half* v)
		{
			MultiTexCoord1hvNVNative(target, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord1hvNV(GLTextureUnit target, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				MultiTexCoord1hvNVNative(target, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord1hvNV(GLTextureUnit target, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				MultiTexCoord1hvNVNative(target, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord2hNVNative(GLTextureUnit target, Half s, Half t)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, Half, void>)funcTable[8])(target, s, t);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, Half, void>)funcTable[8])(target, s, t);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord2hNV(GLTextureUnit target, Half s, Half t)
		{
			MultiTexCoord2hNVNative(target, s, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord2hvNVNative(GLTextureUnit target, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half*, void>)funcTable[9])(target, v);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, nint, void>)funcTable[9])(target, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord2hvNV(GLTextureUnit target, Half* v)
		{
			MultiTexCoord2hvNVNative(target, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord2hvNV(GLTextureUnit target, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				MultiTexCoord2hvNVNative(target, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord2hvNV(GLTextureUnit target, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				MultiTexCoord2hvNVNative(target, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord3hNVNative(GLTextureUnit target, Half s, Half t, Half r)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, Half, Half, void>)funcTable[10])(target, s, t, r);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, Half, Half, void>)funcTable[10])(target, s, t, r);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord3hNV(GLTextureUnit target, Half s, Half t, Half r)
		{
			MultiTexCoord3hNVNative(target, s, t, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord3hvNVNative(GLTextureUnit target, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half*, void>)funcTable[11])(target, v);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, nint, void>)funcTable[11])(target, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord3hvNV(GLTextureUnit target, Half* v)
		{
			MultiTexCoord3hvNVNative(target, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord3hvNV(GLTextureUnit target, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				MultiTexCoord3hvNVNative(target, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord3hvNV(GLTextureUnit target, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				MultiTexCoord3hvNVNative(target, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord4hNVNative(GLTextureUnit target, Half s, Half t, Half r, Half q)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, Half, Half, Half, void>)funcTable[12])(target, s, t, r, q);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half, Half, Half, Half, void>)funcTable[12])(target, s, t, r, q);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord4hNV(GLTextureUnit target, Half s, Half t, Half r, Half q)
		{
			MultiTexCoord4hNVNative(target, s, t, r, q);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MultiTexCoord4hvNVNative(GLTextureUnit target, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureUnit, Half*, void>)funcTable[13])(target, v);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureUnit, nint, void>)funcTable[13])(target, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord4hvNV(GLTextureUnit target, Half* v)
		{
			MultiTexCoord4hvNVNative(target, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord4hvNV(GLTextureUnit target, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				MultiTexCoord4hvNVNative(target, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void MultiTexCoord4hvNV(GLTextureUnit target, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				MultiTexCoord4hvNVNative(target, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Normal3hNVNative(Half nx, Half ny, Half nz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[14])(nx, ny, nz);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[14])(nx, ny, nz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Normal3hNV(Half nx, Half ny, Half nz)
		{
			Normal3hNVNative(nx, ny, nz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Normal3hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[15])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[15])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Normal3hvNV(Half* v)
		{
			Normal3hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Normal3hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				Normal3hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Normal3hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				Normal3hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3hNVNative(Half red, Half green, Half blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[16])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[16])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void SecondaryColor3hNV(Half red, Half green, Half blue)
		{
			SecondaryColor3hNVNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[17])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[17])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void SecondaryColor3hvNV(Half* v)
		{
			SecondaryColor3hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void SecondaryColor3hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				SecondaryColor3hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void SecondaryColor3hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				SecondaryColor3hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord1hNVNative(Half s)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, void>)funcTable[18])(s);
			#else
			((delegate* unmanaged[Cdecl]<Half, void>)funcTable[18])(s);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord1hNV(Half s)
		{
			TexCoord1hNVNative(s);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord1hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[19])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[19])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord1hvNV(Half* v)
		{
			TexCoord1hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord1hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				TexCoord1hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord1hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				TexCoord1hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord2hNVNative(Half s, Half t)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, void>)funcTable[20])(s, t);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, void>)funcTable[20])(s, t);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord2hNV(Half s, Half t)
		{
			TexCoord2hNVNative(s, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord2hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[21])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[21])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord2hvNV(Half* v)
		{
			TexCoord2hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord2hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				TexCoord2hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord2hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				TexCoord2hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord3hNVNative(Half s, Half t, Half r)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[22])(s, t, r);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[22])(s, t, r);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord3hNV(Half s, Half t, Half r)
		{
			TexCoord3hNVNative(s, t, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord3hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[23])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[23])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord3hvNV(Half* v)
		{
			TexCoord3hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord3hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				TexCoord3hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord3hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				TexCoord3hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord4hNVNative(Half s, Half t, Half r, Half q)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, Half, void>)funcTable[24])(s, t, r, q);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, Half, void>)funcTable[24])(s, t, r, q);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord4hNV(Half s, Half t, Half r, Half q)
		{
			TexCoord4hNVNative(s, t, r, q);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexCoord4hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[25])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[25])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord4hvNV(Half* v)
		{
			TexCoord4hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord4hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				TexCoord4hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void TexCoord4hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				TexCoord4hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Vertex2hNVNative(Half x, Half y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, void>)funcTable[26])(x, y);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, void>)funcTable[26])(x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex2hNV(Half x, Half y)
		{
			Vertex2hNVNative(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Vertex2hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[27])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[27])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex2hvNV(Half* v)
		{
			Vertex2hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex2hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				Vertex2hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex2hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				Vertex2hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Vertex3hNVNative(Half x, Half y, Half z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[28])(x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, void>)funcTable[28])(x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex3hNV(Half x, Half y, Half z)
		{
			Vertex3hNVNative(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Vertex3hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[29])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[29])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex3hvNV(Half* v)
		{
			Vertex3hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex3hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				Vertex3hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex3hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				Vertex3hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Vertex4hNVNative(Half x, Half y, Half z, Half w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, Half, Half, Half, void>)funcTable[30])(x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<Half, Half, Half, Half, void>)funcTable[30])(x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex4hNV(Half x, Half y, Half z, Half w)
		{
			Vertex4hNVNative(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Vertex4hvNVNative(Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[31])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[31])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex4hvNV(Half* v)
		{
			Vertex4hvNVNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex4hvNV(Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				Vertex4hvNVNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void Vertex4hvNV(ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				Vertex4hvNVNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib1hNVNative(uint index, Half x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half, void>)funcTable[32])(index, x);
			#else
			((delegate* unmanaged[Cdecl]<uint, Half, void>)funcTable[32])(index, x);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib1hNV(uint index, Half x)
		{
			VertexAttrib1hNVNative(index, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib1hvNVNative(uint index, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half*, void>)funcTable[33])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[33])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib1hvNV(uint index, Half* v)
		{
			VertexAttrib1hvNVNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib1hvNV(uint index, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttrib1hvNVNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib1hvNV(uint index, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttrib1hvNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib2hNVNative(uint index, Half x, Half y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half, Half, void>)funcTable[34])(index, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, Half, Half, void>)funcTable[34])(index, x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib2hNV(uint index, Half x, Half y)
		{
			VertexAttrib2hNVNative(index, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib2hvNVNative(uint index, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half*, void>)funcTable[35])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[35])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib2hvNV(uint index, Half* v)
		{
			VertexAttrib2hvNVNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib2hvNV(uint index, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttrib2hvNVNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib2hvNV(uint index, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttrib2hvNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib3hNVNative(uint index, Half x, Half y, Half z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half, Half, Half, void>)funcTable[36])(index, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, Half, Half, Half, void>)funcTable[36])(index, x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib3hNV(uint index, Half x, Half y, Half z)
		{
			VertexAttrib3hNVNative(index, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib3hvNVNative(uint index, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half*, void>)funcTable[37])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[37])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib3hvNV(uint index, Half* v)
		{
			VertexAttrib3hvNVNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib3hvNV(uint index, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttrib3hvNVNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib3hvNV(uint index, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttrib3hvNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib4hNVNative(uint index, Half x, Half y, Half z, Half w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half, Half, Half, Half, void>)funcTable[38])(index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, Half, Half, Half, Half, void>)funcTable[38])(index, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib4hNV(uint index, Half x, Half y, Half z, Half w)
		{
			VertexAttrib4hNVNative(index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttrib4hvNVNative(uint index, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, Half*, void>)funcTable[39])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[39])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib4hvNV(uint index, Half* v)
		{
			VertexAttrib4hvNVNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib4hvNV(uint index, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttrib4hvNVNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttrib4hvNV(uint index, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttrib4hvNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttribs1hvNVNative(uint index, int n, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, Half*, void>)funcTable[40])(index, n, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[40])(index, n, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs1hvNV(uint index, int n, Half* v)
		{
			VertexAttribs1hvNVNative(index, n, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs1hvNV(uint index, int n, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttribs1hvNVNative(index, n, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs1hvNV(uint index, int n, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttribs1hvNVNative(index, n, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttribs2hvNVNative(uint index, int n, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, Half*, void>)funcTable[41])(index, n, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[41])(index, n, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs2hvNV(uint index, int n, Half* v)
		{
			VertexAttribs2hvNVNative(index, n, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs2hvNV(uint index, int n, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttribs2hvNVNative(index, n, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs2hvNV(uint index, int n, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttribs2hvNVNative(index, n, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttribs3hvNVNative(uint index, int n, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, Half*, void>)funcTable[42])(index, n, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[42])(index, n, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs3hvNV(uint index, int n, Half* v)
		{
			VertexAttribs3hvNVNative(index, n, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs3hvNV(uint index, int n, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttribs3hvNVNative(index, n, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs3hvNV(uint index, int n, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttribs3hvNVNative(index, n, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttribs4hvNVNative(uint index, int n, Half* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, Half*, void>)funcTable[43])(index, n, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[43])(index, n, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs4hvNV(uint index, int n, Half* v)
		{
			VertexAttribs4hvNVNative(index, n, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs4hvNV(uint index, int n, Span<Half> v)
		{
			fixed (Half* pv0 = v)
			{
				VertexAttribs4hvNVNative(index, n, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexAttribs4hvNV(uint index, int n, ref Half v)
		{
			fixed (Half* pv0 = &v)
			{
				VertexAttribs4hvNVNative(index, n, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexWeighthNVNative(Half weight)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half, void>)funcTable[44])(weight);
			#else
			((delegate* unmanaged[Cdecl]<Half, void>)funcTable[44])(weight);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexWeighthNV(Half weight)
		{
			VertexWeighthNVNative(weight);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexWeighthvNVNative(Half* weight)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<Half*, void>)funcTable[45])(weight);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[45])((nint)weight);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexWeighthvNV(Half* weight)
		{
			VertexWeighthvNVNative(weight);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexWeighthvNV(Span<Half> weight)
		{
			fixed (Half* pweight0 = weight)
			{
				VertexWeighthvNVNative(pweight0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_half_float</remarks>
		public void VertexWeighthvNV(ref Half weight)
		{
			fixed (Half* pweight0 = &weight)
			{
				VertexWeighthvNVNative(pweight0);
			}
		}

	}
}
