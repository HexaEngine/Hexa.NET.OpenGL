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

namespace Hexa.NET.OpenGLES.OES
{
	public unsafe partial class GLOESFixedPoint
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_OES_fixed_point";

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
			funcTable = new FunctionTable(GLBase.NativeContext, 107);
			funcTable.Load(0, "glAccumxOES");
			funcTable.Load(1, "glAlphaFuncxOES");
			funcTable.Load(2, "glBitmapxOES");
			funcTable.Load(3, "glBlendColorxOES");
			funcTable.Load(4, "glClearAccumxOES");
			funcTable.Load(5, "glClearColorxOES");
			funcTable.Load(6, "glClearDepthxOES");
			funcTable.Load(7, "glClipPlanexOES");
			funcTable.Load(8, "glColor3xOES");
			funcTable.Load(9, "glColor3xvOES");
			funcTable.Load(10, "glColor4xOES");
			funcTable.Load(11, "glColor4xvOES");
			funcTable.Load(12, "glConvolutionParameterxOES");
			funcTable.Load(13, "glConvolutionParameterxvOES");
			funcTable.Load(14, "glDepthRangexOES");
			funcTable.Load(15, "glEvalCoord1xOES");
			funcTable.Load(16, "glEvalCoord1xvOES");
			funcTable.Load(17, "glEvalCoord2xOES");
			funcTable.Load(18, "glEvalCoord2xvOES");
			funcTable.Load(19, "glFeedbackBufferxOES");
			funcTable.Load(20, "glFogxOES");
			funcTable.Load(21, "glFogxvOES");
			funcTable.Load(22, "glFrustumxOES");
			funcTable.Load(23, "glGetClipPlanexOES");
			funcTable.Load(24, "glGetConvolutionParameterxvOES");
			funcTable.Load(25, "glGetFixedvOES");
			funcTable.Load(26, "glGetHistogramParameterxvOES");
			funcTable.Load(27, "glGetLightxOES");
			funcTable.Load(28, "glGetLightxvOES");
			funcTable.Load(29, "glGetMapxvOES");
			funcTable.Load(30, "glGetMaterialxOES");
			funcTable.Load(31, "glGetMaterialxvOES");
			funcTable.Load(32, "glGetPixelMapxv");
			funcTable.Load(33, "glGetTexEnvxvOES");
			funcTable.Load(34, "glGetTexGenxvOES");
			funcTable.Load(35, "glGetTexLevelParameterxvOES");
			funcTable.Load(36, "glGetTexParameterxvOES");
			funcTable.Load(37, "glIndexxOES");
			funcTable.Load(38, "glIndexxvOES");
			funcTable.Load(39, "glLightModelxOES");
			funcTable.Load(40, "glLightModelxvOES");
			funcTable.Load(41, "glLightxOES");
			funcTable.Load(42, "glLightxvOES");
			funcTable.Load(43, "glLineWidthxOES");
			funcTable.Load(44, "glLoadMatrixxOES");
			funcTable.Load(45, "glLoadTransposeMatrixxOES");
			funcTable.Load(46, "glMap1xOES");
			funcTable.Load(47, "glMap2xOES");
			funcTable.Load(48, "glMapGrid1xOES");
			funcTable.Load(49, "glMapGrid2xOES");
			funcTable.Load(50, "glMaterialxOES");
			funcTable.Load(51, "glMaterialxvOES");
			funcTable.Load(52, "glMultMatrixxOES");
			funcTable.Load(53, "glMultTransposeMatrixxOES");
			funcTable.Load(54, "glMultiTexCoord1xOES");
			funcTable.Load(55, "glMultiTexCoord1xvOES");
			funcTable.Load(56, "glMultiTexCoord2xOES");
			funcTable.Load(57, "glMultiTexCoord2xvOES");
			funcTable.Load(58, "glMultiTexCoord3xOES");
			funcTable.Load(59, "glMultiTexCoord3xvOES");
			funcTable.Load(60, "glMultiTexCoord4xOES");
			funcTable.Load(61, "glMultiTexCoord4xvOES");
			funcTable.Load(62, "glNormal3xOES");
			funcTable.Load(63, "glNormal3xvOES");
			funcTable.Load(64, "glOrthoxOES");
			funcTable.Load(65, "glPassThroughxOES");
			funcTable.Load(66, "glPixelMapx");
			funcTable.Load(67, "glPixelStorex");
			funcTable.Load(68, "glPixelTransferxOES");
			funcTable.Load(69, "glPixelZoomxOES");
			funcTable.Load(70, "glPointParameterxOES");
			funcTable.Load(71, "glPointParameterxvOES");
			funcTable.Load(72, "glPointSizexOES");
			funcTable.Load(73, "glPolygonOffsetxOES");
			funcTable.Load(74, "glPrioritizeTexturesxOES");
			funcTable.Load(75, "glRasterPos2xOES");
			funcTable.Load(76, "glRasterPos2xvOES");
			funcTable.Load(77, "glRasterPos3xOES");
			funcTable.Load(78, "glRasterPos3xvOES");
			funcTable.Load(79, "glRasterPos4xOES");
			funcTable.Load(80, "glRasterPos4xvOES");
			funcTable.Load(81, "glRectxOES");
			funcTable.Load(82, "glRectxvOES");
			funcTable.Load(83, "glRotatexOES");
			funcTable.Load(84, "glSampleCoveragexOES");
			funcTable.Load(85, "glScalexOES");
			funcTable.Load(86, "glTexCoord1xOES");
			funcTable.Load(87, "glTexCoord1xvOES");
			funcTable.Load(88, "glTexCoord2xOES");
			funcTable.Load(89, "glTexCoord2xvOES");
			funcTable.Load(90, "glTexCoord3xOES");
			funcTable.Load(91, "glTexCoord3xvOES");
			funcTable.Load(92, "glTexCoord4xOES");
			funcTable.Load(93, "glTexCoord4xvOES");
			funcTable.Load(94, "glTexEnvxOES");
			funcTable.Load(95, "glTexEnvxvOES");
			funcTable.Load(96, "glTexGenxOES");
			funcTable.Load(97, "glTexGenxvOES");
			funcTable.Load(98, "glTexParameterxOES");
			funcTable.Load(99, "glTexParameterxvOES");
			funcTable.Load(100, "glTranslatexOES");
			funcTable.Load(101, "glVertex2xOES");
			funcTable.Load(102, "glVertex2xvOES");
			funcTable.Load(103, "glVertex3xOES");
			funcTable.Load(104, "glVertex3xvOES");
			funcTable.Load(105, "glVertex4xOES");
			funcTable.Load(106, "glVertex4xvOES");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}