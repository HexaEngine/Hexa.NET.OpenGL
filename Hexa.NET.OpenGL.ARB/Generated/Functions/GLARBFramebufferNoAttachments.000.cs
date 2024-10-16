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
	public static unsafe partial class GLARBFramebufferNoAttachments
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FramebufferParameteriNative(GLFramebufferTarget target, GLFramebufferParameterName pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferParameterName, int, void>)funcTable[0])(target, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferParameterName, int, void>)funcTable[0])(target, pname, param);
			#endif
		}

		/// <summary>
		/// Set a named parameter of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_no_attachments</remarks>
		public static void FramebufferParameteri(GLFramebufferTarget target, GLFramebufferParameterName pname, int param)
		{
			FramebufferParameteriNative(target, pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetFramebufferParameterivNative(GLFramebufferTarget target, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachmentParameterName, int*, void>)funcTable[1])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachmentParameterName, nint, void>)funcTable[1])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// Query a named parameter of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_no_attachments</remarks>
		public static void GetFramebufferParameteriv(GLFramebufferTarget target, GLFramebufferAttachmentParameterName pname, int* @params)
		{
			GetFramebufferParameterivNative(target, pname, @params);
		}

		/// <summary>
		/// Query a named parameter of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_no_attachments</remarks>
		public static void GetFramebufferParameteriv(GLFramebufferTarget target, GLFramebufferAttachmentParameterName pname, out int @params)
		{
			int pparams;
			GetFramebufferParameterivNative(target, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// Query a named parameter of a framebuffer object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_framebuffer_no_attachments</remarks>
		public static void GetFramebufferParameteriv(GLFramebufferTarget target, GLFramebufferAttachmentParameterName pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetFramebufferParameterivNative(target, pname, pparams);
			}
		}

	}
}
