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

namespace Hexa.NET.OpenGL
{
	public unsafe partial class GL
	{
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, call before you access any function.
		/// </summary>
		public static void InitApi(INativeContext context)
		{
			funcTable = new FunctionTable(context, 551);
			funcTable.Load(0, "glAccum");
			funcTable.Load(1, "glActiveTexture");
			funcTable.Load(2, "glAlphaFunc");
			funcTable.Load(3, "glAreTexturesResident");
			funcTable.Load(4, "glArrayElement");
			funcTable.Load(5, "glAttachShader");
			funcTable.Load(6, "glBegin");
			funcTable.Load(7, "glBeginQuery");
			funcTable.Load(8, "glBindAttribLocation");
			funcTable.Load(9, "glBindBuffer");
			funcTable.Load(10, "glBindTexture");
			funcTable.Load(11, "glBitmap");
			funcTable.Load(12, "glBlendColor");
			funcTable.Load(13, "glBlendEquation");
			funcTable.Load(14, "glBlendEquationSeparate");
			funcTable.Load(15, "glBlendFunc");
			funcTable.Load(16, "glBlendFuncSeparate");
			funcTable.Load(17, "glBufferData");
			funcTable.Load(18, "glBufferSubData");
			funcTable.Load(19, "glCallList");
			funcTable.Load(20, "glCallLists");
			funcTable.Load(21, "glClear");
			funcTable.Load(22, "glClearAccum");
			funcTable.Load(23, "glClearColor");
			funcTable.Load(24, "glClearDepth");
			funcTable.Load(25, "glClearIndex");
			funcTable.Load(26, "glClearStencil");
			funcTable.Load(27, "glClientActiveTexture");
			funcTable.Load(28, "glClipPlane");
			funcTable.Load(29, "glColor3b");
			funcTable.Load(30, "glColor3bv");
			funcTable.Load(31, "glColor3d");
			funcTable.Load(32, "glColor3dv");
			funcTable.Load(33, "glColor3f");
			funcTable.Load(34, "glColor3fv");
			funcTable.Load(35, "glColor3i");
			funcTable.Load(36, "glColor3iv");
			funcTable.Load(37, "glColor3s");
			funcTable.Load(38, "glColor3sv");
			funcTable.Load(39, "glColor3ub");
			funcTable.Load(40, "glColor3ubv");
			funcTable.Load(41, "glColor3ui");
			funcTable.Load(42, "glColor3uiv");
			funcTable.Load(43, "glColor3us");
			funcTable.Load(44, "glColor3usv");
			funcTable.Load(45, "glColor4b");
			funcTable.Load(46, "glColor4bv");
			funcTable.Load(47, "glColor4d");
			funcTable.Load(48, "glColor4dv");
			funcTable.Load(49, "glColor4f");
			funcTable.Load(50, "glColor4fv");
			funcTable.Load(51, "glColor4i");
			funcTable.Load(52, "glColor4iv");
			funcTable.Load(53, "glColor4s");
			funcTable.Load(54, "glColor4sv");
			funcTable.Load(55, "glColor4ub");
			funcTable.Load(56, "glColor4ubv");
			funcTable.Load(57, "glColor4ui");
			funcTable.Load(58, "glColor4uiv");
			funcTable.Load(59, "glColor4us");
			funcTable.Load(60, "glColor4usv");
			funcTable.Load(61, "glColorMask");
			funcTable.Load(62, "glColorMaterial");
			funcTable.Load(63, "glColorPointer");
			funcTable.Load(64, "glCompileShader");
			funcTable.Load(65, "glCompressedTexImage1D");
			funcTable.Load(66, "glCompressedTexImage2D");
			funcTable.Load(67, "glCompressedTexImage3D");
			funcTable.Load(68, "glCompressedTexSubImage1D");
			funcTable.Load(69, "glCompressedTexSubImage2D");
			funcTable.Load(70, "glCompressedTexSubImage3D");
			funcTable.Load(71, "glCopyPixels");
			funcTable.Load(72, "glCopyTexImage1D");
			funcTable.Load(73, "glCopyTexImage2D");
			funcTable.Load(74, "glCopyTexSubImage1D");
			funcTable.Load(75, "glCopyTexSubImage2D");
			funcTable.Load(76, "glCopyTexSubImage3D");
			funcTable.Load(77, "glCreateProgram");
			funcTable.Load(78, "glCreateShader");
			funcTable.Load(79, "glCullFace");
			funcTable.Load(80, "glDeleteBuffers");
			funcTable.Load(81, "glDeleteLists");
			funcTable.Load(82, "glDeleteProgram");
			funcTable.Load(83, "glDeleteQueries");
			funcTable.Load(84, "glDeleteShader");
			funcTable.Load(85, "glDeleteTextures");
			funcTable.Load(86, "glDepthFunc");
			funcTable.Load(87, "glDepthMask");
			funcTable.Load(88, "glDepthRange");
			funcTable.Load(89, "glDetachShader");
			funcTable.Load(90, "glDisable");
			funcTable.Load(91, "glDisableClientState");
			funcTable.Load(92, "glDisableVertexAttribArray");
			funcTable.Load(93, "glDrawArrays");
			funcTable.Load(94, "glDrawBuffer");
			funcTable.Load(95, "glDrawBuffers");
			funcTable.Load(96, "glDrawElements");
			funcTable.Load(97, "glDrawPixels");
			funcTable.Load(98, "glDrawRangeElements");
			funcTable.Load(99, "glEdgeFlag");
			funcTable.Load(100, "glEdgeFlagPointer");
			funcTable.Load(101, "glEdgeFlagv");
			funcTable.Load(102, "glEnable");
			funcTable.Load(103, "glEnableClientState");
			funcTable.Load(104, "glEnableVertexAttribArray");
			funcTable.Load(105, "glEnd");
			funcTable.Load(106, "glEndList");
			funcTable.Load(107, "glEndQuery");
			funcTable.Load(108, "glEvalCoord1d");
			funcTable.Load(109, "glEvalCoord1dv");
			funcTable.Load(110, "glEvalCoord1f");
			funcTable.Load(111, "glEvalCoord1fv");
			funcTable.Load(112, "glEvalCoord2d");
			funcTable.Load(113, "glEvalCoord2dv");
			funcTable.Load(114, "glEvalCoord2f");
			funcTable.Load(115, "glEvalCoord2fv");
			funcTable.Load(116, "glEvalMesh1");
			funcTable.Load(117, "glEvalMesh2");
			funcTable.Load(118, "glEvalPoint1");
			funcTable.Load(119, "glEvalPoint2");
			funcTable.Load(120, "glFeedbackBuffer");
			funcTable.Load(121, "glFinish");
			funcTable.Load(122, "glFlush");
			funcTable.Load(123, "glFogCoordPointer");
			funcTable.Load(124, "glFogCoordd");
			funcTable.Load(125, "glFogCoorddv");
			funcTable.Load(126, "glFogCoordf");
			funcTable.Load(127, "glFogCoordfv");
			funcTable.Load(128, "glFogf");
			funcTable.Load(129, "glFogfv");
			funcTable.Load(130, "glFogi");
			funcTable.Load(131, "glFogiv");
			funcTable.Load(132, "glFrontFace");
			funcTable.Load(133, "glFrustum");
			funcTable.Load(134, "glGenBuffers");
			funcTable.Load(135, "glGenLists");
			funcTable.Load(136, "glGenQueries");
			funcTable.Load(137, "glGenTextures");
			funcTable.Load(138, "glGetActiveAttrib");
			funcTable.Load(139, "glGetActiveUniform");
			funcTable.Load(140, "glGetAttachedShaders");
			funcTable.Load(141, "glGetAttribLocation");
			funcTable.Load(142, "glGetBooleanv");
			funcTable.Load(143, "glGetBufferParameteriv");
			funcTable.Load(144, "glGetBufferPointerv");
			funcTable.Load(145, "glGetBufferSubData");
			funcTable.Load(146, "glGetClipPlane");
			funcTable.Load(147, "glGetCompressedTexImage");
			funcTable.Load(148, "glGetDoublev");
			funcTable.Load(149, "glGetError");
			funcTable.Load(150, "glGetFloatv");
			funcTable.Load(151, "glGetIntegerv");
			funcTable.Load(152, "glGetLightfv");
			funcTable.Load(153, "glGetLightiv");
			funcTable.Load(154, "glGetMapdv");
			funcTable.Load(155, "glGetMapfv");
			funcTable.Load(156, "glGetMapiv");
			funcTable.Load(157, "glGetMaterialfv");
			funcTable.Load(158, "glGetMaterialiv");
			funcTable.Load(159, "glGetPixelMapfv");
			funcTable.Load(160, "glGetPixelMapuiv");
			funcTable.Load(161, "glGetPixelMapusv");
			funcTable.Load(162, "glGetPointerv");
			funcTable.Load(163, "glGetPolygonStipple");
			funcTable.Load(164, "glGetProgramInfoLog");
			funcTable.Load(165, "glGetProgramiv");
			funcTable.Load(166, "glGetQueryObjectiv");
			funcTable.Load(167, "glGetQueryObjectuiv");
			funcTable.Load(168, "glGetQueryiv");
			funcTable.Load(169, "glGetShaderInfoLog");
			funcTable.Load(170, "glGetShaderSource");
			funcTable.Load(171, "glGetShaderiv");
			funcTable.Load(172, "glGetString");
			funcTable.Load(173, "glGetTexEnvfv");
			funcTable.Load(174, "glGetTexEnviv");
			funcTable.Load(175, "glGetTexGendv");
			funcTable.Load(176, "glGetTexGenfv");
			funcTable.Load(177, "glGetTexGeniv");
			funcTable.Load(178, "glGetTexImage");
			funcTable.Load(179, "glGetTexLevelParameterfv");
			funcTable.Load(180, "glGetTexLevelParameteriv");
			funcTable.Load(181, "glGetTexParameterfv");
			funcTable.Load(182, "glGetTexParameteriv");
			funcTable.Load(183, "glGetUniformLocation");
			funcTable.Load(184, "glGetUniformfv");
			funcTable.Load(185, "glGetUniformiv");
			funcTable.Load(186, "glGetVertexAttribPointerv");
			funcTable.Load(187, "glGetVertexAttribdv");
			funcTable.Load(188, "glGetVertexAttribfv");
			funcTable.Load(189, "glGetVertexAttribiv");
			funcTable.Load(190, "glHint");
			funcTable.Load(191, "glIndexMask");
			funcTable.Load(192, "glIndexPointer");
			funcTable.Load(193, "glIndexd");
			funcTable.Load(194, "glIndexdv");
			funcTable.Load(195, "glIndexf");
			funcTable.Load(196, "glIndexfv");
			funcTable.Load(197, "glIndexi");
			funcTable.Load(198, "glIndexiv");
			funcTable.Load(199, "glIndexs");
			funcTable.Load(200, "glIndexsv");
			funcTable.Load(201, "glIndexub");
			funcTable.Load(202, "glIndexubv");
			funcTable.Load(203, "glInitNames");
			funcTable.Load(204, "glInterleavedArrays");
			funcTable.Load(205, "glIsBuffer");
			funcTable.Load(206, "glIsEnabled");
			funcTable.Load(207, "glIsList");
			funcTable.Load(208, "glIsProgram");
			funcTable.Load(209, "glIsQuery");
			funcTable.Load(210, "glIsShader");
			funcTable.Load(211, "glIsTexture");
			funcTable.Load(212, "glLightModelf");
			funcTable.Load(213, "glLightModelfv");
			funcTable.Load(214, "glLightModeli");
			funcTable.Load(215, "glLightModeliv");
			funcTable.Load(216, "glLightf");
			funcTable.Load(217, "glLightfv");
			funcTable.Load(218, "glLighti");
			funcTable.Load(219, "glLightiv");
			funcTable.Load(220, "glLineStipple");
			funcTable.Load(221, "glLineWidth");
			funcTable.Load(222, "glLinkProgram");
			funcTable.Load(223, "glListBase");
			funcTable.Load(224, "glLoadIdentity");
			funcTable.Load(225, "glLoadMatrixd");
			funcTable.Load(226, "glLoadMatrixf");
			funcTable.Load(227, "glLoadName");
			funcTable.Load(228, "glLoadTransposeMatrixd");
			funcTable.Load(229, "glLoadTransposeMatrixf");
			funcTable.Load(230, "glLogicOp");
			funcTable.Load(231, "glMap1d");
			funcTable.Load(232, "glMap1f");
			funcTable.Load(233, "glMap2d");
			funcTable.Load(234, "glMap2f");
			funcTable.Load(235, "glMapBuffer");
			funcTable.Load(236, "glMapGrid1d");
			funcTable.Load(237, "glMapGrid1f");
			funcTable.Load(238, "glMapGrid2d");
			funcTable.Load(239, "glMapGrid2f");
			funcTable.Load(240, "glMaterialf");
			funcTable.Load(241, "glMaterialfv");
			funcTable.Load(242, "glMateriali");
			funcTable.Load(243, "glMaterialiv");
			funcTable.Load(244, "glMatrixMode");
			funcTable.Load(245, "glMultMatrixd");
			funcTable.Load(246, "glMultMatrixf");
			funcTable.Load(247, "glMultTransposeMatrixd");
			funcTable.Load(248, "glMultTransposeMatrixf");
			funcTable.Load(249, "glMultiDrawArrays");
			funcTable.Load(250, "glMultiDrawElements");
			funcTable.Load(251, "glMultiTexCoord1d");
			funcTable.Load(252, "glMultiTexCoord1dv");
			funcTable.Load(253, "glMultiTexCoord1f");
			funcTable.Load(254, "glMultiTexCoord1fv");
			funcTable.Load(255, "glMultiTexCoord1i");
			funcTable.Load(256, "glMultiTexCoord1iv");
			funcTable.Load(257, "glMultiTexCoord1s");
			funcTable.Load(258, "glMultiTexCoord1sv");
			funcTable.Load(259, "glMultiTexCoord2d");
			funcTable.Load(260, "glMultiTexCoord2dv");
			funcTable.Load(261, "glMultiTexCoord2f");
			funcTable.Load(262, "glMultiTexCoord2fv");
			funcTable.Load(263, "glMultiTexCoord2i");
			funcTable.Load(264, "glMultiTexCoord2iv");
			funcTable.Load(265, "glMultiTexCoord2s");
			funcTable.Load(266, "glMultiTexCoord2sv");
			funcTable.Load(267, "glMultiTexCoord3d");
			funcTable.Load(268, "glMultiTexCoord3dv");
			funcTable.Load(269, "glMultiTexCoord3f");
			funcTable.Load(270, "glMultiTexCoord3fv");
			funcTable.Load(271, "glMultiTexCoord3i");
			funcTable.Load(272, "glMultiTexCoord3iv");
			funcTable.Load(273, "glMultiTexCoord3s");
			funcTable.Load(274, "glMultiTexCoord3sv");
			funcTable.Load(275, "glMultiTexCoord4d");
			funcTable.Load(276, "glMultiTexCoord4dv");
			funcTable.Load(277, "glMultiTexCoord4f");
			funcTable.Load(278, "glMultiTexCoord4fv");
			funcTable.Load(279, "glMultiTexCoord4i");
			funcTable.Load(280, "glMultiTexCoord4iv");
			funcTable.Load(281, "glMultiTexCoord4s");
			funcTable.Load(282, "glMultiTexCoord4sv");
			funcTable.Load(283, "glNewList");
			funcTable.Load(284, "glNormal3b");
			funcTable.Load(285, "glNormal3bv");
			funcTable.Load(286, "glNormal3d");
			funcTable.Load(287, "glNormal3dv");
			funcTable.Load(288, "glNormal3f");
			funcTable.Load(289, "glNormal3fv");
			funcTable.Load(290, "glNormal3i");
			funcTable.Load(291, "glNormal3iv");
			funcTable.Load(292, "glNormal3s");
			funcTable.Load(293, "glNormal3sv");
			funcTable.Load(294, "glNormalPointer");
			funcTable.Load(295, "glOrtho");
			funcTable.Load(296, "glPassThrough");
			funcTable.Load(297, "glPixelMapfv");
			funcTable.Load(298, "glPixelMapuiv");
			funcTable.Load(299, "glPixelMapusv");
			funcTable.Load(300, "glPixelStoref");
			funcTable.Load(301, "glPixelStorei");
			funcTable.Load(302, "glPixelTransferf");
			funcTable.Load(303, "glPixelTransferi");
			funcTable.Load(304, "glPixelZoom");
			funcTable.Load(305, "glPointParameterf");
			funcTable.Load(306, "glPointParameterfv");
			funcTable.Load(307, "glPointParameteri");
			funcTable.Load(308, "glPointParameteriv");
			funcTable.Load(309, "glPointSize");
			funcTable.Load(310, "glPolygonMode");
			funcTable.Load(311, "glPolygonOffset");
			funcTable.Load(312, "glPolygonStipple");
			funcTable.Load(313, "glPopAttrib");
			funcTable.Load(314, "glPopClientAttrib");
			funcTable.Load(315, "glPopMatrix");
			funcTable.Load(316, "glPopName");
			funcTable.Load(317, "glPrioritizeTextures");
			funcTable.Load(318, "glPushAttrib");
			funcTable.Load(319, "glPushClientAttrib");
			funcTable.Load(320, "glPushMatrix");
			funcTable.Load(321, "glPushName");
			funcTable.Load(322, "glRasterPos2d");
			funcTable.Load(323, "glRasterPos2dv");
			funcTable.Load(324, "glRasterPos2f");
			funcTable.Load(325, "glRasterPos2fv");
			funcTable.Load(326, "glRasterPos2i");
			funcTable.Load(327, "glRasterPos2iv");
			funcTable.Load(328, "glRasterPos2s");
			funcTable.Load(329, "glRasterPos2sv");
			funcTable.Load(330, "glRasterPos3d");
			funcTable.Load(331, "glRasterPos3dv");
			funcTable.Load(332, "glRasterPos3f");
			funcTable.Load(333, "glRasterPos3fv");
			funcTable.Load(334, "glRasterPos3i");
			funcTable.Load(335, "glRasterPos3iv");
			funcTable.Load(336, "glRasterPos3s");
			funcTable.Load(337, "glRasterPos3sv");
			funcTable.Load(338, "glRasterPos4d");
			funcTable.Load(339, "glRasterPos4dv");
			funcTable.Load(340, "glRasterPos4f");
			funcTable.Load(341, "glRasterPos4fv");
			funcTable.Load(342, "glRasterPos4i");
			funcTable.Load(343, "glRasterPos4iv");
			funcTable.Load(344, "glRasterPos4s");
			funcTable.Load(345, "glRasterPos4sv");
			funcTable.Load(346, "glReadBuffer");
			funcTable.Load(347, "glReadPixels");
			funcTable.Load(348, "glRectd");
			funcTable.Load(349, "glRectdv");
			funcTable.Load(350, "glRectf");
			funcTable.Load(351, "glRectfv");
			funcTable.Load(352, "glRecti");
			funcTable.Load(353, "glRectiv");
			funcTable.Load(354, "glRects");
			funcTable.Load(355, "glRectsv");
			funcTable.Load(356, "glRenderMode");
			funcTable.Load(357, "glRotated");
			funcTable.Load(358, "glRotatef");
			funcTable.Load(359, "glSampleCoverage");
			funcTable.Load(360, "glScaled");
			funcTable.Load(361, "glScalef");
			funcTable.Load(362, "glScissor");
			funcTable.Load(363, "glSecondaryColor3b");
			funcTable.Load(364, "glSecondaryColor3bv");
			funcTable.Load(365, "glSecondaryColor3d");
			funcTable.Load(366, "glSecondaryColor3dv");
			funcTable.Load(367, "glSecondaryColor3f");
			funcTable.Load(368, "glSecondaryColor3fv");
			funcTable.Load(369, "glSecondaryColor3i");
			funcTable.Load(370, "glSecondaryColor3iv");
			funcTable.Load(371, "glSecondaryColor3s");
			funcTable.Load(372, "glSecondaryColor3sv");
			funcTable.Load(373, "glSecondaryColor3ub");
			funcTable.Load(374, "glSecondaryColor3ubv");
			funcTable.Load(375, "glSecondaryColor3ui");
			funcTable.Load(376, "glSecondaryColor3uiv");
			funcTable.Load(377, "glSecondaryColor3us");
			funcTable.Load(378, "glSecondaryColor3usv");
			funcTable.Load(379, "glSecondaryColorPointer");
			funcTable.Load(380, "glSelectBuffer");
			funcTable.Load(381, "glShadeModel");
			funcTable.Load(382, "glShaderSource");
			funcTable.Load(383, "glStencilFunc");
			funcTable.Load(384, "glStencilFuncSeparate");
			funcTable.Load(385, "glStencilMask");
			funcTable.Load(386, "glStencilMaskSeparate");
			funcTable.Load(387, "glStencilOp");
			funcTable.Load(388, "glStencilOpSeparate");
			funcTable.Load(389, "glTexCoord1d");
			funcTable.Load(390, "glTexCoord1dv");
			funcTable.Load(391, "glTexCoord1f");
			funcTable.Load(392, "glTexCoord1fv");
			funcTable.Load(393, "glTexCoord1i");
			funcTable.Load(394, "glTexCoord1iv");
			funcTable.Load(395, "glTexCoord1s");
			funcTable.Load(396, "glTexCoord1sv");
			funcTable.Load(397, "glTexCoord2d");
			funcTable.Load(398, "glTexCoord2dv");
			funcTable.Load(399, "glTexCoord2f");
			funcTable.Load(400, "glTexCoord2fv");
			funcTable.Load(401, "glTexCoord2i");
			funcTable.Load(402, "glTexCoord2iv");
			funcTable.Load(403, "glTexCoord2s");
			funcTable.Load(404, "glTexCoord2sv");
			funcTable.Load(405, "glTexCoord3d");
			funcTable.Load(406, "glTexCoord3dv");
			funcTable.Load(407, "glTexCoord3f");
			funcTable.Load(408, "glTexCoord3fv");
			funcTable.Load(409, "glTexCoord3i");
			funcTable.Load(410, "glTexCoord3iv");
			funcTable.Load(411, "glTexCoord3s");
			funcTable.Load(412, "glTexCoord3sv");
			funcTable.Load(413, "glTexCoord4d");
			funcTable.Load(414, "glTexCoord4dv");
			funcTable.Load(415, "glTexCoord4f");
			funcTable.Load(416, "glTexCoord4fv");
			funcTable.Load(417, "glTexCoord4i");
			funcTable.Load(418, "glTexCoord4iv");
			funcTable.Load(419, "glTexCoord4s");
			funcTable.Load(420, "glTexCoord4sv");
			funcTable.Load(421, "glTexCoordPointer");
			funcTable.Load(422, "glTexEnvf");
			funcTable.Load(423, "glTexEnvfv");
			funcTable.Load(424, "glTexEnvi");
			funcTable.Load(425, "glTexEnviv");
			funcTable.Load(426, "glTexGend");
			funcTable.Load(427, "glTexGendv");
			funcTable.Load(428, "glTexGenf");
			funcTable.Load(429, "glTexGenfv");
			funcTable.Load(430, "glTexGeni");
			funcTable.Load(431, "glTexGeniv");
			funcTable.Load(432, "glTexImage1D");
			funcTable.Load(433, "glTexImage2D");
			funcTable.Load(434, "glTexImage3D");
			funcTable.Load(435, "glTexParameterf");
			funcTable.Load(436, "glTexParameterfv");
			funcTable.Load(437, "glTexParameteri");
			funcTable.Load(438, "glTexParameteriv");
			funcTable.Load(439, "glTexSubImage1D");
			funcTable.Load(440, "glTexSubImage2D");
			funcTable.Load(441, "glTexSubImage3D");
			funcTable.Load(442, "glTranslated");
			funcTable.Load(443, "glTranslatef");
			funcTable.Load(444, "glUniform1f");
			funcTable.Load(445, "glUniform1fv");
			funcTable.Load(446, "glUniform1i");
			funcTable.Load(447, "glUniform1iv");
			funcTable.Load(448, "glUniform2f");
			funcTable.Load(449, "glUniform2fv");
			funcTable.Load(450, "glUniform2i");
			funcTable.Load(451, "glUniform2iv");
			funcTable.Load(452, "glUniform3f");
			funcTable.Load(453, "glUniform3fv");
			funcTable.Load(454, "glUniform3i");
			funcTable.Load(455, "glUniform3iv");
			funcTable.Load(456, "glUniform4f");
			funcTable.Load(457, "glUniform4fv");
			funcTable.Load(458, "glUniform4i");
			funcTable.Load(459, "glUniform4iv");
			funcTable.Load(460, "glUniformMatrix2fv");
			funcTable.Load(461, "glUniformMatrix2x3fv");
			funcTable.Load(462, "glUniformMatrix2x4fv");
			funcTable.Load(463, "glUniformMatrix3fv");
			funcTable.Load(464, "glUniformMatrix3x2fv");
			funcTable.Load(465, "glUniformMatrix3x4fv");
			funcTable.Load(466, "glUniformMatrix4fv");
			funcTable.Load(467, "glUniformMatrix4x2fv");
			funcTable.Load(468, "glUniformMatrix4x3fv");
			funcTable.Load(469, "glUnmapBuffer");
			funcTable.Load(470, "glUseProgram");
			funcTable.Load(471, "glValidateProgram");
			funcTable.Load(472, "glVertex2d");
			funcTable.Load(473, "glVertex2dv");
			funcTable.Load(474, "glVertex2f");
			funcTable.Load(475, "glVertex2fv");
			funcTable.Load(476, "glVertex2i");
			funcTable.Load(477, "glVertex2iv");
			funcTable.Load(478, "glVertex2s");
			funcTable.Load(479, "glVertex2sv");
			funcTable.Load(480, "glVertex3d");
			funcTable.Load(481, "glVertex3dv");
			funcTable.Load(482, "glVertex3f");
			funcTable.Load(483, "glVertex3fv");
			funcTable.Load(484, "glVertex3i");
			funcTable.Load(485, "glVertex3iv");
			funcTable.Load(486, "glVertex3s");
			funcTable.Load(487, "glVertex3sv");
			funcTable.Load(488, "glVertex4d");
			funcTable.Load(489, "glVertex4dv");
			funcTable.Load(490, "glVertex4f");
			funcTable.Load(491, "glVertex4fv");
			funcTable.Load(492, "glVertex4i");
			funcTable.Load(493, "glVertex4iv");
			funcTable.Load(494, "glVertex4s");
			funcTable.Load(495, "glVertex4sv");
			funcTable.Load(496, "glVertexAttrib1d");
			funcTable.Load(497, "glVertexAttrib1dv");
			funcTable.Load(498, "glVertexAttrib1f");
			funcTable.Load(499, "glVertexAttrib1fv");
			funcTable.Load(500, "glVertexAttrib1s");
			funcTable.Load(501, "glVertexAttrib1sv");
			funcTable.Load(502, "glVertexAttrib2d");
			funcTable.Load(503, "glVertexAttrib2dv");
			funcTable.Load(504, "glVertexAttrib2f");
			funcTable.Load(505, "glVertexAttrib2fv");
			funcTable.Load(506, "glVertexAttrib2s");
			funcTable.Load(507, "glVertexAttrib2sv");
			funcTable.Load(508, "glVertexAttrib3d");
			funcTable.Load(509, "glVertexAttrib3dv");
			funcTable.Load(510, "glVertexAttrib3f");
			funcTable.Load(511, "glVertexAttrib3fv");
			funcTable.Load(512, "glVertexAttrib3s");
			funcTable.Load(513, "glVertexAttrib3sv");
			funcTable.Load(514, "glVertexAttrib4Nbv");
			funcTable.Load(515, "glVertexAttrib4Niv");
			funcTable.Load(516, "glVertexAttrib4Nsv");
			funcTable.Load(517, "glVertexAttrib4Nub");
			funcTable.Load(518, "glVertexAttrib4Nubv");
			funcTable.Load(519, "glVertexAttrib4Nuiv");
			funcTable.Load(520, "glVertexAttrib4Nusv");
			funcTable.Load(521, "glVertexAttrib4bv");
			funcTable.Load(522, "glVertexAttrib4d");
			funcTable.Load(523, "glVertexAttrib4dv");
			funcTable.Load(524, "glVertexAttrib4f");
			funcTable.Load(525, "glVertexAttrib4fv");
			funcTable.Load(526, "glVertexAttrib4iv");
			funcTable.Load(527, "glVertexAttrib4s");
			funcTable.Load(528, "glVertexAttrib4sv");
			funcTable.Load(529, "glVertexAttrib4ubv");
			funcTable.Load(530, "glVertexAttrib4uiv");
			funcTable.Load(531, "glVertexAttrib4usv");
			funcTable.Load(532, "glVertexAttribPointer");
			funcTable.Load(533, "glVertexPointer");
			funcTable.Load(534, "glViewport");
			funcTable.Load(535, "glWindowPos2d");
			funcTable.Load(536, "glWindowPos2dv");
			funcTable.Load(537, "glWindowPos2f");
			funcTable.Load(538, "glWindowPos2fv");
			funcTable.Load(539, "glWindowPos2i");
			funcTable.Load(540, "glWindowPos2iv");
			funcTable.Load(541, "glWindowPos2s");
			funcTable.Load(542, "glWindowPos2sv");
			funcTable.Load(543, "glWindowPos3d");
			funcTable.Load(544, "glWindowPos3dv");
			funcTable.Load(545, "glWindowPos3f");
			funcTable.Load(546, "glWindowPos3fv");
			funcTable.Load(547, "glWindowPos3i");
			funcTable.Load(548, "glWindowPos3iv");
			funcTable.Load(549, "glWindowPos3s");
			funcTable.Load(550, "glWindowPos3sv");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}
