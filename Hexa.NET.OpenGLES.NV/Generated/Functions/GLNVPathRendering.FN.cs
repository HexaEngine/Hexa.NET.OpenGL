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
using System.Numerics;
using Hexa.NET.OpenGLES;

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVPathRendering
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_NV_path_rendering";

		/// <summary>
		/// Tries to initialize the function table of the extension, call before you access any function.
		/// </summary>
		/// <returns>Returns <c>true</c> if successful, <c>false</c> if extension is not supported.</returns>
		public static bool TryInitExtension()
		{
			if (!IsSupported) return false;
			InitExtension();
			return true;
		}

		/// <summary>
		/// Initializes the function table of the extension, call before you access any function.
		/// </summary>
		public static void InitExtension()
		{
			if (funcTable != null) return;
			if (GLBase.NativeContext == null) throw new InvalidOperationException("OpenGL is not initialized, call GL.InitApi.");
			funcTable = new FunctionTable(GLBase.NativeContext, 83);
			funcTable.Load(0, "glCopyPathNV");
			funcTable.Load(1, "glCoverFillPathInstancedNV");
			funcTable.Load(2, "glCoverFillPathNV");
			funcTable.Load(3, "glCoverStrokePathInstancedNV");
			funcTable.Load(4, "glCoverStrokePathNV");
			funcTable.Load(5, "glDeletePathsNV");
			funcTable.Load(6, "glGenPathsNV");
			funcTable.Load(7, "glGetPathColorGenfvNV");
			funcTable.Load(8, "glGetPathColorGenivNV");
			funcTable.Load(9, "glGetPathCommandsNV");
			funcTable.Load(10, "glGetPathCoordsNV");
			funcTable.Load(11, "glGetPathDashArrayNV");
			funcTable.Load(12, "glGetPathLengthNV");
			funcTable.Load(13, "glGetPathMetricRangeNV");
			funcTable.Load(14, "glGetPathMetricsNV");
			funcTable.Load(15, "glGetPathParameterfvNV");
			funcTable.Load(16, "glGetPathParameterivNV");
			funcTable.Load(17, "glGetPathSpacingNV");
			funcTable.Load(18, "glGetPathTexGenfvNV");
			funcTable.Load(19, "glGetPathTexGenivNV");
			funcTable.Load(20, "glGetProgramResourcefvNV");
			funcTable.Load(21, "glInterpolatePathsNV");
			funcTable.Load(22, "glIsPathNV");
			funcTable.Load(23, "glIsPointInFillPathNV");
			funcTable.Load(24, "glIsPointInStrokePathNV");
			funcTable.Load(25, "glMatrixFrustumEXT");
			funcTable.Load(26, "glMatrixLoad3x2fNV");
			funcTable.Load(27, "glMatrixLoad3x3fNV");
			funcTable.Load(28, "glMatrixLoadIdentityEXT");
			funcTable.Load(29, "glMatrixLoadTranspose3x3fNV");
			funcTable.Load(30, "glMatrixLoadTransposedEXT");
			funcTable.Load(31, "glMatrixLoadTransposefEXT");
			funcTable.Load(32, "glMatrixLoaddEXT");
			funcTable.Load(33, "glMatrixLoadfEXT");
			funcTable.Load(34, "glMatrixMult3x2fNV");
			funcTable.Load(35, "glMatrixMult3x3fNV");
			funcTable.Load(36, "glMatrixMultTranspose3x3fNV");
			funcTable.Load(37, "glMatrixMultTransposedEXT");
			funcTable.Load(38, "glMatrixMultTransposefEXT");
			funcTable.Load(39, "glMatrixMultdEXT");
			funcTable.Load(40, "glMatrixMultfEXT");
			funcTable.Load(41, "glMatrixOrthoEXT");
			funcTable.Load(42, "glMatrixPopEXT");
			funcTable.Load(43, "glMatrixPushEXT");
			funcTable.Load(44, "glMatrixRotatedEXT");
			funcTable.Load(45, "glMatrixRotatefEXT");
			funcTable.Load(46, "glMatrixScaledEXT");
			funcTable.Load(47, "glMatrixScalefEXT");
			funcTable.Load(48, "glMatrixTranslatedEXT");
			funcTable.Load(49, "glMatrixTranslatefEXT");
			funcTable.Load(50, "glPathColorGenNV");
			funcTable.Load(51, "glPathCommandsNV");
			funcTable.Load(52, "glPathCoordsNV");
			funcTable.Load(53, "glPathCoverDepthFuncNV");
			funcTable.Load(54, "glPathDashArrayNV");
			funcTable.Load(55, "glPathFogGenNV");
			funcTable.Load(56, "glPathGlyphIndexArrayNV");
			funcTable.Load(57, "glPathGlyphIndexRangeNV");
			funcTable.Load(58, "glPathGlyphRangeNV");
			funcTable.Load(59, "glPathGlyphsNV");
			funcTable.Load(60, "glPathMemoryGlyphIndexArrayNV");
			funcTable.Load(61, "glPathParameterfNV");
			funcTable.Load(62, "glPathParameterfvNV");
			funcTable.Load(63, "glPathParameteriNV");
			funcTable.Load(64, "glPathParameterivNV");
			funcTable.Load(65, "glPathStencilDepthOffsetNV");
			funcTable.Load(66, "glPathStencilFuncNV");
			funcTable.Load(67, "glPathStringNV");
			funcTable.Load(68, "glPathSubCommandsNV");
			funcTable.Load(69, "glPathSubCoordsNV");
			funcTable.Load(70, "glPathTexGenNV");
			funcTable.Load(71, "glPointAlongPathNV");
			funcTable.Load(72, "glProgramPathFragmentInputGenNV");
			funcTable.Load(73, "glStencilFillPathInstancedNV");
			funcTable.Load(74, "glStencilFillPathNV");
			funcTable.Load(75, "glStencilStrokePathInstancedNV");
			funcTable.Load(76, "glStencilStrokePathNV");
			funcTable.Load(77, "glStencilThenCoverFillPathInstancedNV");
			funcTable.Load(78, "glStencilThenCoverFillPathNV");
			funcTable.Load(79, "glStencilThenCoverStrokePathInstancedNV");
			funcTable.Load(80, "glStencilThenCoverStrokePathNV");
			funcTable.Load(81, "glTransformPathNV");
			funcTable.Load(82, "glWeightPathsNV");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
