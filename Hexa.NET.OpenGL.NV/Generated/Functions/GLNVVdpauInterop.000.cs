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
	public static unsafe partial class GLNVVdpauInterop
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VDPAUFiniNVNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[0])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[0])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUFiniNV()
		{
			VDPAUFiniNVNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VDPAUGetSurfaceivNVNative(GLvdpauSurfaceNV surface, GLEnum pname, int count, int* length, int* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLEnum, int, int*, int*, void>)funcTable[1])(surface, pname, count, length, values);
			#else
			((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLEnum, int, nint, nint, void>)funcTable[1])(surface, pname, count, (nint)length, (nint)values);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLEnum pname, int count, int* length, int* values)
		{
			VDPAUGetSurfaceivNVNative(surface, pname, count, length, values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLEnum pname, int count, Span<int> length, int* values)
		{
			fixed (int* plength0 = length)
			{
				VDPAUGetSurfaceivNVNative(surface, pname, count, plength0, values);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLEnum pname, int count, ref int length, int* values)
		{
			fixed (int* plength0 = &length)
			{
				VDPAUGetSurfaceivNVNative(surface, pname, count, plength0, values);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLEnum pname, int count, int* length, Span<int> values)
		{
			fixed (int* pvalues0 = values)
			{
				VDPAUGetSurfaceivNVNative(surface, pname, count, length, pvalues0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLEnum pname, int count, int* length, ref int values)
		{
			fixed (int* pvalues0 = &values)
			{
				VDPAUGetSurfaceivNVNative(surface, pname, count, length, pvalues0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLEnum pname, int count, Span<int> length, Span<int> values)
		{
			fixed (int* plength0 = length)
			{
				fixed (int* pvalues1 = values)
				{
					VDPAUGetSurfaceivNVNative(surface, pname, count, plength0, pvalues1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUGetSurfaceivNV(GLvdpauSurfaceNV surface, GLEnum pname, int count, ref int length, ref int values)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* pvalues1 = &values)
				{
					VDPAUGetSurfaceivNVNative(surface, pname, count, plength0, pvalues1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VDPAUInitNVNative(void* vdpDevice, void* getProcAddress)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void*, void*, void>)funcTable[2])(vdpDevice, getProcAddress);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[2])((nint)vdpDevice, (nint)getProcAddress);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUInitNV(void* vdpDevice, void* getProcAddress)
		{
			VDPAUInitNVNative(vdpDevice, getProcAddress);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUInitNV(nint vdpDevice, void* getProcAddress)
		{
			VDPAUInitNVNative((void*)vdpDevice, getProcAddress);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUInitNV<TVdpDevice>(Span<TVdpDevice> vdpDevice, void* getProcAddress) where TVdpDevice : unmanaged
		{
			fixed (TVdpDevice* pvdpDevice0 = vdpDevice)
			{
				VDPAUInitNVNative(pvdpDevice0, getProcAddress);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUInitNV(void* vdpDevice, nint getProcAddress)
		{
			VDPAUInitNVNative(vdpDevice, (void*)getProcAddress);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUInitNV<TGetProcAddress>(void* vdpDevice, Span<TGetProcAddress> getProcAddress) where TGetProcAddress : unmanaged
		{
			fixed (TGetProcAddress* pgetProcAddress0 = getProcAddress)
			{
				VDPAUInitNVNative(vdpDevice, pgetProcAddress0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUInitNV(nint vdpDevice, nint getProcAddress)
		{
			VDPAUInitNVNative((void*)vdpDevice, (void*)getProcAddress);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUInitNV<TVdpDevice, TGetProcAddress>(Span<TVdpDevice> vdpDevice, Span<TGetProcAddress> getProcAddress) where TVdpDevice : unmanaged where TGetProcAddress : unmanaged
		{
			fixed (TVdpDevice* pvdpDevice0 = vdpDevice)
			{
				fixed (TGetProcAddress* pgetProcAddress1 = getProcAddress)
				{
					VDPAUInitNVNative(pvdpDevice0, pgetProcAddress1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte VDPAUIsSurfaceNVNative(GLvdpauSurfaceNV surface)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, byte>)funcTable[3])(surface);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, byte>)funcTable[3])(surface);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static bool VDPAUIsSurfaceNV(GLvdpauSurfaceNV surface)
		{
			byte ret = VDPAUIsSurfaceNVNative(surface);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VDPAUMapSurfacesNVNative(int numSurfaces, GLvdpauSurfaceNV* surfaces)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLvdpauSurfaceNV*, void>)funcTable[4])(numSurfaces, surfaces);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[4])(numSurfaces, (nint)surfaces);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUMapSurfacesNV(int numSurfaces, GLvdpauSurfaceNV* surfaces)
		{
			VDPAUMapSurfacesNVNative(numSurfaces, surfaces);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUMapSurfacesNV(int numSurfaces, Span<GLvdpauSurfaceNV> surfaces)
		{
			fixed (GLvdpauSurfaceNV* psurfaces0 = surfaces)
			{
				VDPAUMapSurfacesNVNative(numSurfaces, psurfaces0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUMapSurfacesNV(int numSurfaces, ref GLvdpauSurfaceNV surfaces)
		{
			fixed (GLvdpauSurfaceNV* psurfaces0 = &surfaces)
			{
				VDPAUMapSurfacesNVNative(numSurfaces, psurfaces0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLvdpauSurfaceNV VDPAURegisterOutputSurfaceNVNative(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, GLEnum, int, uint*, GLvdpauSurfaceNV>)funcTable[5])(vdpSurface, target, numTextureNames, textureNames);
			#else
			return (GLvdpauSurfaceNV)((delegate* unmanaged[Cdecl]<nint, GLEnum, int, nint, GLvdpauSurfaceNV>)funcTable[5])((nint)vdpSurface, target, numTextureNames, (nint)textureNames);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterOutputSurfaceNV(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames)
		{
			GLvdpauSurfaceNV ret = VDPAURegisterOutputSurfaceNVNative(vdpSurface, target, numTextureNames, textureNames);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterOutputSurfaceNV(nint vdpSurface, GLEnum target, int numTextureNames, uint* textureNames)
		{
			GLvdpauSurfaceNV ret = VDPAURegisterOutputSurfaceNVNative((void*)vdpSurface, target, numTextureNames, textureNames);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterOutputSurfaceNV<TVdpSurface>(Span<TVdpSurface> vdpSurface, GLEnum target, int numTextureNames, uint* textureNames) where TVdpSurface : unmanaged
		{
			fixed (TVdpSurface* pvdpSurface0 = vdpSurface)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterOutputSurfaceNVNative(pvdpSurface0, target, numTextureNames, textureNames);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterOutputSurfaceNV(void* vdpSurface, GLEnum target, int numTextureNames, Span<uint> textureNames)
		{
			fixed (uint* ptextureNames0 = textureNames)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterOutputSurfaceNVNative(vdpSurface, target, numTextureNames, ptextureNames0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterOutputSurfaceNV(void* vdpSurface, GLEnum target, int numTextureNames, ref uint textureNames)
		{
			fixed (uint* ptextureNames0 = &textureNames)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterOutputSurfaceNVNative(vdpSurface, target, numTextureNames, ptextureNames0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceNVNative(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, GLEnum, int, uint*, GLvdpauSurfaceNV>)funcTable[6])(vdpSurface, target, numTextureNames, textureNames);
			#else
			return (GLvdpauSurfaceNV)((delegate* unmanaged[Cdecl]<nint, GLEnum, int, nint, GLvdpauSurfaceNV>)funcTable[6])((nint)vdpSurface, target, numTextureNames, (nint)textureNames);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceNV(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames)
		{
			GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceNVNative(vdpSurface, target, numTextureNames, textureNames);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceNV(nint vdpSurface, GLEnum target, int numTextureNames, uint* textureNames)
		{
			GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceNVNative((void*)vdpSurface, target, numTextureNames, textureNames);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceNV<TVdpSurface>(Span<TVdpSurface> vdpSurface, GLEnum target, int numTextureNames, uint* textureNames) where TVdpSurface : unmanaged
		{
			fixed (TVdpSurface* pvdpSurface0 = vdpSurface)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceNVNative(pvdpSurface0, target, numTextureNames, textureNames);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceNV(void* vdpSurface, GLEnum target, int numTextureNames, Span<uint> textureNames)
		{
			fixed (uint* ptextureNames0 = textureNames)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceNVNative(vdpSurface, target, numTextureNames, ptextureNames0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static GLvdpauSurfaceNV VDPAURegisterVideoSurfaceNV(void* vdpSurface, GLEnum target, int numTextureNames, ref uint textureNames)
		{
			fixed (uint* ptextureNames0 = &textureNames)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceNVNative(vdpSurface, target, numTextureNames, ptextureNames0);
				return ret;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VDPAUSurfaceAccessNVNative(GLvdpauSurfaceNV surface, GLEnum access)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLEnum, void>)funcTable[7])(surface, access);
			#else
			((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, GLEnum, void>)funcTable[7])(surface, access);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUSurfaceAccessNV(GLvdpauSurfaceNV surface, GLEnum access)
		{
			VDPAUSurfaceAccessNVNative(surface, access);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VDPAUUnmapSurfacesNVNative(int numSurface, GLvdpauSurfaceNV* surfaces)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLvdpauSurfaceNV*, void>)funcTable[8])(numSurface, surfaces);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[8])(numSurface, (nint)surfaces);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUUnmapSurfacesNV(int numSurface, GLvdpauSurfaceNV* surfaces)
		{
			VDPAUUnmapSurfacesNVNative(numSurface, surfaces);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUUnmapSurfacesNV(int numSurface, Span<GLvdpauSurfaceNV> surfaces)
		{
			fixed (GLvdpauSurfaceNV* psurfaces0 = surfaces)
			{
				VDPAUUnmapSurfacesNVNative(numSurface, psurfaces0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUUnmapSurfacesNV(int numSurface, ref GLvdpauSurfaceNV surfaces)
		{
			fixed (GLvdpauSurfaceNV* psurfaces0 = &surfaces)
			{
				VDPAUUnmapSurfacesNVNative(numSurface, psurfaces0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VDPAUUnregisterSurfaceNVNative(GLvdpauSurfaceNV surface)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, void>)funcTable[9])(surface);
			#else
			((delegate* unmanaged[Cdecl]<GLvdpauSurfaceNV, void>)funcTable[9])(surface);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop</remarks>
		public static void VDPAUUnregisterSurfaceNV(GLvdpauSurfaceNV surface)
		{
			VDPAUUnregisterSurfaceNVNative(surface);
		}

	}
}
