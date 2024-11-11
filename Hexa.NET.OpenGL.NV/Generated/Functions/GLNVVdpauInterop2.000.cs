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
	public unsafe partial class GLNVVdpauInterop2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNVNative(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames, bool isFrameStructure)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, GLEnum, int, uint*, byte, GLvdpauSurfaceNV>)funcTable[0])(vdpSurface, target, numTextureNames, textureNames, *((byte*)(&isFrameStructure)));
			#else
			return (GLvdpauSurfaceNV)((delegate* unmanaged[Cdecl]<nint, GLEnum, int, nint, byte, GLvdpauSurfaceNV>)funcTable[0])((nint)vdpSurface, target, numTextureNames, (nint)textureNames, *((byte*)(&isFrameStructure)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop2</remarks>
		public GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, GLEnum target, int numTextureNames, uint* textureNames, bool isFrameStructure)
		{
			GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceWithPictureStructureNVNative(vdpSurface, target, numTextureNames, textureNames, isFrameStructure);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop2</remarks>
		public GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNV(nint vdpSurface, GLEnum target, int numTextureNames, uint* textureNames, bool isFrameStructure)
		{
			GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceWithPictureStructureNVNative((void*)vdpSurface, target, numTextureNames, textureNames, isFrameStructure);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop2</remarks>
		public GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNV<TVdpSurface>(Span<TVdpSurface> vdpSurface, GLEnum target, int numTextureNames, uint* textureNames, bool isFrameStructure) where TVdpSurface : unmanaged
		{
			fixed (TVdpSurface* pvdpSurface0 = vdpSurface)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceWithPictureStructureNVNative(pvdpSurface0, target, numTextureNames, textureNames, isFrameStructure);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop2</remarks>
		public GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, GLEnum target, int numTextureNames, Span<uint> textureNames, bool isFrameStructure)
		{
			fixed (uint* ptextureNames0 = textureNames)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceWithPictureStructureNVNative(vdpSurface, target, numTextureNames, ptextureNames0, isFrameStructure);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_vdpau_interop2</remarks>
		public GLvdpauSurfaceNV VDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, GLEnum target, int numTextureNames, ref uint textureNames, bool isFrameStructure)
		{
			fixed (uint* ptextureNames0 = &textureNames)
			{
				GLvdpauSurfaceNV ret = VDPAURegisterVideoSurfaceWithPictureStructureNVNative(vdpSurface, target, numTextureNames, ptextureNames0, isFrameStructure);
				return ret;
			}
		}

	}
}
