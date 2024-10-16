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

namespace Hexa.NET.OpenGLES
{
	public unsafe partial class GL
	{
		internal static FunctionTable funcTable;
		public static INativeContext NativeContext { get; internal set; }

		public static bool Initialized => funcTable != null;

		/// <summary>
		/// Initializes the function table, call before you access any function.
		/// </summary>
		public static void InitApi(INativeContext context)
		{
			if (funcTable != null) return;
			GLBase.NativeContext = context;
			funcTable = new FunctionTable(context, 738);
			funcTable.Load(0, "glActiveShaderProgram");
			funcTable.Load(1, "glActiveTexture");
			funcTable.Load(2, "glAlphaFunc");
			funcTable.Load(3, "glAlphaFuncx");
			funcTable.Load(4, "glAttachShader");
			funcTable.Load(5, "glBeginConditionalRender");
			funcTable.Load(6, "glBeginQuery");
			funcTable.Load(7, "glBeginQueryIndexed");
			funcTable.Load(8, "glBeginTransformFeedback");
			funcTable.Load(9, "glBindAttribLocation");
			funcTable.Load(10, "glBindBuffer");
			funcTable.Load(11, "glBindBufferBase");
			funcTable.Load(12, "glBindBufferRange");
			funcTable.Load(13, "glBindBuffersBase");
			funcTable.Load(14, "glBindBuffersRange");
			funcTable.Load(15, "glBindFragDataLocation");
			funcTable.Load(16, "glBindFragDataLocationIndexed");
			funcTable.Load(17, "glBindFramebuffer");
			funcTable.Load(18, "glBindImageTexture");
			funcTable.Load(19, "glBindImageTextures");
			funcTable.Load(20, "glBindProgramPipeline");
			funcTable.Load(21, "glBindRenderbuffer");
			funcTable.Load(22, "glBindSampler");
			funcTable.Load(23, "glBindSamplers");
			funcTable.Load(24, "glBindTexture");
			funcTable.Load(25, "glBindTextureUnit");
			funcTable.Load(26, "glBindTextures");
			funcTable.Load(27, "glBindTransformFeedback");
			funcTable.Load(28, "glBindVertexArray");
			funcTable.Load(29, "glBindVertexBuffer");
			funcTable.Load(30, "glBindVertexBuffers");
			funcTable.Load(31, "glBlendColor");
			funcTable.Load(32, "glBlendEquation");
			funcTable.Load(33, "glBlendEquationSeparate");
			funcTable.Load(34, "glBlendEquationSeparatei");
			funcTable.Load(35, "glBlendEquationi");
			funcTable.Load(36, "glBlendFunc");
			funcTable.Load(37, "glBlendFuncSeparate");
			funcTable.Load(38, "glBlendFuncSeparatei");
			funcTable.Load(39, "glBlendFunci");
			funcTable.Load(40, "glBlitFramebuffer");
			funcTable.Load(41, "glBlitNamedFramebuffer");
			funcTable.Load(42, "glBufferData");
			funcTable.Load(43, "glBufferStorage");
			funcTable.Load(44, "glBufferSubData");
			funcTable.Load(45, "glCheckFramebufferStatus");
			funcTable.Load(46, "glCheckNamedFramebufferStatus");
			funcTable.Load(47, "glClampColor");
			funcTable.Load(48, "glClear");
			funcTable.Load(49, "glClearBufferData");
			funcTable.Load(50, "glClearBufferSubData");
			funcTable.Load(51, "glClearBufferfi");
			funcTable.Load(52, "glClearBufferfv");
			funcTable.Load(53, "glClearBufferiv");
			funcTable.Load(54, "glClearBufferuiv");
			funcTable.Load(55, "glClearColor");
			funcTable.Load(56, "glClearColorx");
			funcTable.Load(57, "glClearDepth");
			funcTable.Load(58, "glClearDepthf");
			funcTable.Load(59, "glClearDepthx");
			funcTable.Load(60, "glClearNamedBufferData");
			funcTable.Load(61, "glClearNamedBufferSubData");
			funcTable.Load(62, "glClearNamedFramebufferfi");
			funcTable.Load(63, "glClearNamedFramebufferfv");
			funcTable.Load(64, "glClearNamedFramebufferiv");
			funcTable.Load(65, "glClearNamedFramebufferuiv");
			funcTable.Load(66, "glClearStencil");
			funcTable.Load(67, "glClearTexImage");
			funcTable.Load(68, "glClearTexSubImage");
			funcTable.Load(69, "glClientActiveTexture");
			funcTable.Load(70, "glClientWaitSync");
			funcTable.Load(71, "glClipControl");
			funcTable.Load(72, "glClipPlanef");
			funcTable.Load(73, "glClipPlanex");
			funcTable.Load(74, "glColor4f");
			funcTable.Load(75, "glColor4ub");
			funcTable.Load(76, "glColor4x");
			funcTable.Load(77, "glColorMask");
			funcTable.Load(78, "glColorMaski");
			funcTable.Load(79, "glColorPointer");
			funcTable.Load(80, "glCompileShader");
			funcTable.Load(81, "glCompressedTexImage1D");
			funcTable.Load(82, "glCompressedTexImage2D");
			funcTable.Load(83, "glCompressedTexImage3D");
			funcTable.Load(84, "glCompressedTexSubImage1D");
			funcTable.Load(85, "glCompressedTexSubImage2D");
			funcTable.Load(86, "glCompressedTexSubImage3D");
			funcTable.Load(87, "glCompressedTextureSubImage1D");
			funcTable.Load(88, "glCompressedTextureSubImage2D");
			funcTable.Load(89, "glCompressedTextureSubImage3D");
			funcTable.Load(90, "glCopyBufferSubData");
			funcTable.Load(91, "glCopyImageSubData");
			funcTable.Load(92, "glCopyNamedBufferSubData");
			funcTable.Load(93, "glCopyTexImage1D");
			funcTable.Load(94, "glCopyTexImage2D");
			funcTable.Load(95, "glCopyTexSubImage1D");
			funcTable.Load(96, "glCopyTexSubImage2D");
			funcTable.Load(97, "glCopyTexSubImage3D");
			funcTable.Load(98, "glCopyTextureSubImage1D");
			funcTable.Load(99, "glCopyTextureSubImage2D");
			funcTable.Load(100, "glCopyTextureSubImage3D");
			funcTable.Load(101, "glCreateBuffers");
			funcTable.Load(102, "glCreateFramebuffers");
			funcTable.Load(103, "glCreateProgram");
			funcTable.Load(104, "glCreateProgramPipelines");
			funcTable.Load(105, "glCreateQueries");
			funcTable.Load(106, "glCreateRenderbuffers");
			funcTable.Load(107, "glCreateSamplers");
			funcTable.Load(108, "glCreateShader");
			funcTable.Load(109, "glCreateShaderProgramv");
			funcTable.Load(110, "glCreateTextures");
			funcTable.Load(111, "glCreateTransformFeedbacks");
			funcTable.Load(112, "glCreateVertexArrays");
			funcTable.Load(113, "glCullFace");
			funcTable.Load(114, "glDebugMessageCallback");
			funcTable.Load(115, "glDebugMessageControl");
			funcTable.Load(116, "glDebugMessageInsert");
			funcTable.Load(117, "glDeleteBuffers");
			funcTable.Load(118, "glDeleteFramebuffers");
			funcTable.Load(119, "glDeleteProgram");
			funcTable.Load(120, "glDeleteProgramPipelines");
			funcTable.Load(121, "glDeleteQueries");
			funcTable.Load(122, "glDeleteRenderbuffers");
			funcTable.Load(123, "glDeleteSamplers");
			funcTable.Load(124, "glDeleteShader");
			funcTable.Load(125, "glDeleteSync");
			funcTable.Load(126, "glDeleteTextures");
			funcTable.Load(127, "glDeleteTransformFeedbacks");
			funcTable.Load(128, "glDeleteVertexArrays");
			funcTable.Load(129, "glDepthFunc");
			funcTable.Load(130, "glDepthMask");
			funcTable.Load(131, "glDepthRange");
			funcTable.Load(132, "glDepthRangeArrayv");
			funcTable.Load(133, "glDepthRangeIndexed");
			funcTable.Load(134, "glDepthRangef");
			funcTable.Load(135, "glDepthRangex");
			funcTable.Load(136, "glDetachShader");
			funcTable.Load(137, "glDisable");
			funcTable.Load(138, "glDisableClientState");
			funcTable.Load(139, "glDisableVertexArrayAttrib");
			funcTable.Load(140, "glDisableVertexAttribArray");
			funcTable.Load(141, "glDisablei");
			funcTable.Load(142, "glDispatchCompute");
			funcTable.Load(143, "glDispatchComputeIndirect");
			funcTable.Load(144, "glDrawArrays");
			funcTable.Load(145, "glDrawArraysIndirect");
			funcTable.Load(146, "glDrawArraysInstanced");
			funcTable.Load(147, "glDrawArraysInstancedBaseInstance");
			funcTable.Load(148, "glDrawBuffer");
			funcTable.Load(149, "glDrawBuffers");
			funcTable.Load(150, "glDrawElements");
			funcTable.Load(151, "glDrawElementsBaseVertex");
			funcTable.Load(152, "glDrawElementsIndirect");
			funcTable.Load(153, "glDrawElementsInstanced");
			funcTable.Load(154, "glDrawElementsInstancedBaseInstance");
			funcTable.Load(155, "glDrawElementsInstancedBaseVertex");
			funcTable.Load(156, "glDrawElementsInstancedBaseVertexBaseInstance");
			funcTable.Load(157, "glDrawRangeElements");
			funcTable.Load(158, "glDrawRangeElementsBaseVertex");
			funcTable.Load(159, "glDrawTransformFeedback");
			funcTable.Load(160, "glDrawTransformFeedbackInstanced");
			funcTable.Load(161, "glDrawTransformFeedbackStream");
			funcTable.Load(162, "glDrawTransformFeedbackStreamInstanced");
			funcTable.Load(163, "glEnable");
			funcTable.Load(164, "glEnableClientState");
			funcTable.Load(165, "glEnableVertexArrayAttrib");
			funcTable.Load(166, "glEnableVertexAttribArray");
			funcTable.Load(167, "glEnablei");
			funcTable.Load(168, "glEndConditionalRender");
			funcTable.Load(169, "glEndQuery");
			funcTable.Load(170, "glEndQueryIndexed");
			funcTable.Load(171, "glEndTransformFeedback");
			funcTable.Load(172, "glFenceSync");
			funcTable.Load(173, "glFinish");
			funcTable.Load(174, "glFlush");
			funcTable.Load(175, "glFlushMappedBufferRange");
			funcTable.Load(176, "glFlushMappedNamedBufferRange");
			funcTable.Load(177, "glFogf");
			funcTable.Load(178, "glFogfv");
			funcTable.Load(179, "glFogx");
			funcTable.Load(180, "glFogxv");
			funcTable.Load(181, "glFramebufferParameteri");
			funcTable.Load(182, "glFramebufferRenderbuffer");
			funcTable.Load(183, "glFramebufferTexture");
			funcTable.Load(184, "glFramebufferTexture1D");
			funcTable.Load(185, "glFramebufferTexture2D");
			funcTable.Load(186, "glFramebufferTexture3D");
			funcTable.Load(187, "glFramebufferTextureLayer");
			funcTable.Load(188, "glFrontFace");
			funcTable.Load(189, "glFrustumf");
			funcTable.Load(190, "glFrustumx");
			funcTable.Load(191, "glGenBuffers");
			funcTable.Load(192, "glGenFramebuffers");
			funcTable.Load(193, "glGenProgramPipelines");
			funcTable.Load(194, "glGenQueries");
			funcTable.Load(195, "glGenRenderbuffers");
			funcTable.Load(196, "glGenSamplers");
			funcTable.Load(197, "glGenTextures");
			funcTable.Load(198, "glGenTransformFeedbacks");
			funcTable.Load(199, "glGenVertexArrays");
			funcTable.Load(200, "glGenerateMipmap");
			funcTable.Load(201, "glGenerateTextureMipmap");
			funcTable.Load(202, "glGetActiveAtomicCounterBufferiv");
			funcTable.Load(203, "glGetActiveAttrib");
			funcTable.Load(204, "glGetActiveSubroutineName");
			funcTable.Load(205, "glGetActiveSubroutineUniformName");
			funcTable.Load(206, "glGetActiveSubroutineUniformiv");
			funcTable.Load(207, "glGetActiveUniform");
			funcTable.Load(208, "glGetActiveUniformBlockName");
			funcTable.Load(209, "glGetActiveUniformBlockiv");
			funcTable.Load(210, "glGetActiveUniformName");
			funcTable.Load(211, "glGetActiveUniformsiv");
			funcTable.Load(212, "glGetAttachedShaders");
			funcTable.Load(213, "glGetAttribLocation");
			funcTable.Load(214, "glGetBooleani_v");
			funcTable.Load(215, "glGetBooleanv");
			funcTable.Load(216, "glGetBufferParameteri64v");
			funcTable.Load(217, "glGetBufferParameteriv");
			funcTable.Load(218, "glGetBufferPointerv");
			funcTable.Load(219, "glGetBufferSubData");
			funcTable.Load(220, "glGetClipPlanef");
			funcTable.Load(221, "glGetClipPlanex");
			funcTable.Load(222, "glGetCompressedTexImage");
			funcTable.Load(223, "glGetCompressedTextureImage");
			funcTable.Load(224, "glGetCompressedTextureSubImage");
			funcTable.Load(225, "glGetDebugMessageLog");
			funcTable.Load(226, "glGetDoublei_v");
			funcTable.Load(227, "glGetDoublev");
			funcTable.Load(228, "glGetError");
			funcTable.Load(229, "glGetFixedv");
			funcTable.Load(230, "glGetFloati_v");
			funcTable.Load(231, "glGetFloatv");
			funcTable.Load(232, "glGetFragDataIndex");
			funcTable.Load(233, "glGetFragDataLocation");
			funcTable.Load(234, "glGetFramebufferAttachmentParameteriv");
			funcTable.Load(235, "glGetFramebufferParameteriv");
			funcTable.Load(236, "glGetGraphicsResetStatus");
			funcTable.Load(237, "glGetInteger64i_v");
			funcTable.Load(238, "glGetInteger64v");
			funcTable.Load(239, "glGetIntegeri_v");
			funcTable.Load(240, "glGetIntegerv");
			funcTable.Load(241, "glGetInternalformati64v");
			funcTable.Load(242, "glGetInternalformativ");
			funcTable.Load(243, "glGetLightfv");
			funcTable.Load(244, "glGetLightxv");
			funcTable.Load(245, "glGetMaterialfv");
			funcTable.Load(246, "glGetMaterialxv");
			funcTable.Load(247, "glGetMultisamplefv");
			funcTable.Load(248, "glGetNamedBufferParameteri64v");
			funcTable.Load(249, "glGetNamedBufferParameteriv");
			funcTable.Load(250, "glGetNamedBufferPointerv");
			funcTable.Load(251, "glGetNamedBufferSubData");
			funcTable.Load(252, "glGetNamedFramebufferAttachmentParameteriv");
			funcTable.Load(253, "glGetNamedFramebufferParameteriv");
			funcTable.Load(254, "glGetNamedRenderbufferParameteriv");
			funcTable.Load(255, "glGetObjectLabel");
			funcTable.Load(256, "glGetObjectPtrLabel");
			funcTable.Load(257, "glGetPointerv");
			funcTable.Load(258, "glGetProgramBinary");
			funcTable.Load(259, "glGetProgramInfoLog");
			funcTable.Load(260, "glGetProgramInterfaceiv");
			funcTable.Load(261, "glGetProgramPipelineInfoLog");
			funcTable.Load(262, "glGetProgramPipelineiv");
			funcTable.Load(263, "glGetProgramResourceIndex");
			funcTable.Load(264, "glGetProgramResourceLocation");
			funcTable.Load(265, "glGetProgramResourceLocationIndex");
			funcTable.Load(266, "glGetProgramResourceName");
			funcTable.Load(267, "glGetProgramResourceiv");
			funcTable.Load(268, "glGetProgramStageiv");
			funcTable.Load(269, "glGetProgramiv");
			funcTable.Load(270, "glGetQueryBufferObjecti64v");
			funcTable.Load(271, "glGetQueryBufferObjectiv");
			funcTable.Load(272, "glGetQueryBufferObjectui64v");
			funcTable.Load(273, "glGetQueryBufferObjectuiv");
			funcTable.Load(274, "glGetQueryIndexediv");
			funcTable.Load(275, "glGetQueryObjecti64v");
			funcTable.Load(276, "glGetQueryObjectiv");
			funcTable.Load(277, "glGetQueryObjectui64v");
			funcTable.Load(278, "glGetQueryObjectuiv");
			funcTable.Load(279, "glGetQueryiv");
			funcTable.Load(280, "glGetRenderbufferParameteriv");
			funcTable.Load(281, "glGetSamplerParameterIiv");
			funcTable.Load(282, "glGetSamplerParameterIuiv");
			funcTable.Load(283, "glGetSamplerParameterfv");
			funcTable.Load(284, "glGetSamplerParameteriv");
			funcTable.Load(285, "glGetShaderInfoLog");
			funcTable.Load(286, "glGetShaderPrecisionFormat");
			funcTable.Load(287, "glGetShaderSource");
			funcTable.Load(288, "glGetShaderiv");
			funcTable.Load(289, "glGetString");
			funcTable.Load(290, "glGetStringi");
			funcTable.Load(291, "glGetSubroutineIndex");
			funcTable.Load(292, "glGetSubroutineUniformLocation");
			funcTable.Load(293, "glGetSynciv");
			funcTable.Load(294, "glGetTexEnvfv");
			funcTable.Load(295, "glGetTexEnviv");
			funcTable.Load(296, "glGetTexEnvxv");
			funcTable.Load(297, "glGetTexImage");
			funcTable.Load(298, "glGetTexLevelParameterfv");
			funcTable.Load(299, "glGetTexLevelParameteriv");
			funcTable.Load(300, "glGetTexParameterIiv");
			funcTable.Load(301, "glGetTexParameterIuiv");
			funcTable.Load(302, "glGetTexParameterfv");
			funcTable.Load(303, "glGetTexParameteriv");
			funcTable.Load(304, "glGetTexParameterxv");
			funcTable.Load(305, "glGetTextureImage");
			funcTable.Load(306, "glGetTextureLevelParameterfv");
			funcTable.Load(307, "glGetTextureLevelParameteriv");
			funcTable.Load(308, "glGetTextureParameterIiv");
			funcTable.Load(309, "glGetTextureParameterIuiv");
			funcTable.Load(310, "glGetTextureParameterfv");
			funcTable.Load(311, "glGetTextureParameteriv");
			funcTable.Load(312, "glGetTextureSubImage");
			funcTable.Load(313, "glGetTransformFeedbackVarying");
			funcTable.Load(314, "glGetTransformFeedbacki64_v");
			funcTable.Load(315, "glGetTransformFeedbacki_v");
			funcTable.Load(316, "glGetTransformFeedbackiv");
			funcTable.Load(317, "glGetUniformBlockIndex");
			funcTable.Load(318, "glGetUniformIndices");
			funcTable.Load(319, "glGetUniformLocation");
			funcTable.Load(320, "glGetUniformSubroutineuiv");
			funcTable.Load(321, "glGetUniformdv");
			funcTable.Load(322, "glGetUniformfv");
			funcTable.Load(323, "glGetUniformiv");
			funcTable.Load(324, "glGetUniformuiv");
			funcTable.Load(325, "glGetVertexArrayIndexed64iv");
			funcTable.Load(326, "glGetVertexArrayIndexediv");
			funcTable.Load(327, "glGetVertexArrayiv");
			funcTable.Load(328, "glGetVertexAttribIiv");
			funcTable.Load(329, "glGetVertexAttribIuiv");
			funcTable.Load(330, "glGetVertexAttribLdv");
			funcTable.Load(331, "glGetVertexAttribPointerv");
			funcTable.Load(332, "glGetVertexAttribdv");
			funcTable.Load(333, "glGetVertexAttribfv");
			funcTable.Load(334, "glGetVertexAttribiv");
			funcTable.Load(335, "glGetnCompressedTexImage");
			funcTable.Load(336, "glGetnTexImage");
			funcTable.Load(337, "glGetnUniformdv");
			funcTable.Load(338, "glGetnUniformfv");
			funcTable.Load(339, "glGetnUniformiv");
			funcTable.Load(340, "glGetnUniformuiv");
			funcTable.Load(341, "glHint");
			funcTable.Load(342, "glInvalidateBufferData");
			funcTable.Load(343, "glInvalidateBufferSubData");
			funcTable.Load(344, "glInvalidateFramebuffer");
			funcTable.Load(345, "glInvalidateNamedFramebufferData");
			funcTable.Load(346, "glInvalidateNamedFramebufferSubData");
			funcTable.Load(347, "glInvalidateSubFramebuffer");
			funcTable.Load(348, "glInvalidateTexImage");
			funcTable.Load(349, "glInvalidateTexSubImage");
			funcTable.Load(350, "glIsBuffer");
			funcTable.Load(351, "glIsEnabled");
			funcTable.Load(352, "glIsEnabledi");
			funcTable.Load(353, "glIsFramebuffer");
			funcTable.Load(354, "glIsProgram");
			funcTable.Load(355, "glIsProgramPipeline");
			funcTable.Load(356, "glIsQuery");
			funcTable.Load(357, "glIsRenderbuffer");
			funcTable.Load(358, "glIsSampler");
			funcTable.Load(359, "glIsShader");
			funcTable.Load(360, "glIsSync");
			funcTable.Load(361, "glIsTexture");
			funcTable.Load(362, "glIsTransformFeedback");
			funcTable.Load(363, "glIsVertexArray");
			funcTable.Load(364, "glLightModelf");
			funcTable.Load(365, "glLightModelfv");
			funcTable.Load(366, "glLightModelx");
			funcTable.Load(367, "glLightModelxv");
			funcTable.Load(368, "glLightf");
			funcTable.Load(369, "glLightfv");
			funcTable.Load(370, "glLightx");
			funcTable.Load(371, "glLightxv");
			funcTable.Load(372, "glLineWidth");
			funcTable.Load(373, "glLineWidthx");
			funcTable.Load(374, "glLinkProgram");
			funcTable.Load(375, "glLoadIdentity");
			funcTable.Load(376, "glLoadMatrixf");
			funcTable.Load(377, "glLoadMatrixx");
			funcTable.Load(378, "glLogicOp");
			funcTable.Load(379, "glMapBuffer");
			funcTable.Load(380, "glMapBufferRange");
			funcTable.Load(381, "glMapNamedBuffer");
			funcTable.Load(382, "glMapNamedBufferRange");
			funcTable.Load(383, "glMaterialf");
			funcTable.Load(384, "glMaterialfv");
			funcTable.Load(385, "glMaterialx");
			funcTable.Load(386, "glMaterialxv");
			funcTable.Load(387, "glMatrixMode");
			funcTable.Load(388, "glMemoryBarrier");
			funcTable.Load(389, "glMemoryBarrierByRegion");
			funcTable.Load(390, "glMinSampleShading");
			funcTable.Load(391, "glMultMatrixf");
			funcTable.Load(392, "glMultMatrixx");
			funcTable.Load(393, "glMultiDrawArrays");
			funcTable.Load(394, "glMultiDrawArraysIndirect");
			funcTable.Load(395, "glMultiDrawArraysIndirectCount");
			funcTable.Load(396, "glMultiDrawElements");
			funcTable.Load(397, "glMultiDrawElementsBaseVertex");
			funcTable.Load(398, "glMultiDrawElementsIndirect");
			funcTable.Load(399, "glMultiDrawElementsIndirectCount");
			funcTable.Load(400, "glMultiTexCoord4f");
			funcTable.Load(401, "glMultiTexCoord4x");
			funcTable.Load(402, "glNamedBufferData");
			funcTable.Load(403, "glNamedBufferStorage");
			funcTable.Load(404, "glNamedBufferSubData");
			funcTable.Load(405, "glNamedFramebufferDrawBuffer");
			funcTable.Load(406, "glNamedFramebufferDrawBuffers");
			funcTable.Load(407, "glNamedFramebufferParameteri");
			funcTable.Load(408, "glNamedFramebufferReadBuffer");
			funcTable.Load(409, "glNamedFramebufferRenderbuffer");
			funcTable.Load(410, "glNamedFramebufferTexture");
			funcTable.Load(411, "glNamedFramebufferTextureLayer");
			funcTable.Load(412, "glNamedRenderbufferStorage");
			funcTable.Load(413, "glNamedRenderbufferStorageMultisample");
			funcTable.Load(414, "glNormal3f");
			funcTable.Load(415, "glNormal3x");
			funcTable.Load(416, "glNormalPointer");
			funcTable.Load(417, "glObjectLabel");
			funcTable.Load(418, "glObjectPtrLabel");
			funcTable.Load(419, "glOrthof");
			funcTable.Load(420, "glOrthox");
			funcTable.Load(421, "glPatchParameterfv");
			funcTable.Load(422, "glPatchParameteri");
			funcTable.Load(423, "glPauseTransformFeedback");
			funcTable.Load(424, "glPixelStoref");
			funcTable.Load(425, "glPixelStorei");
			funcTable.Load(426, "glPointParameterf");
			funcTable.Load(427, "glPointParameterfv");
			funcTable.Load(428, "glPointParameteri");
			funcTable.Load(429, "glPointParameteriv");
			funcTable.Load(430, "glPointParameterx");
			funcTable.Load(431, "glPointParameterxv");
			funcTable.Load(432, "glPointSize");
			funcTable.Load(433, "glPointSizex");
			funcTable.Load(434, "glPolygonMode");
			funcTable.Load(435, "glPolygonOffset");
			funcTable.Load(436, "glPolygonOffsetClamp");
			funcTable.Load(437, "glPolygonOffsetx");
			funcTable.Load(438, "glPopDebugGroup");
			funcTable.Load(439, "glPopMatrix");
			funcTable.Load(440, "glPrimitiveRestartIndex");
			funcTable.Load(441, "glProgramBinary");
			funcTable.Load(442, "glProgramParameteri");
			funcTable.Load(443, "glProgramUniform1d");
			funcTable.Load(444, "glProgramUniform1dv");
			funcTable.Load(445, "glProgramUniform1f");
			funcTable.Load(446, "glProgramUniform1fv");
			funcTable.Load(447, "glProgramUniform1i");
			funcTable.Load(448, "glProgramUniform1iv");
			funcTable.Load(449, "glProgramUniform1ui");
			funcTable.Load(450, "glProgramUniform1uiv");
			funcTable.Load(451, "glProgramUniform2d");
			funcTable.Load(452, "glProgramUniform2dv");
			funcTable.Load(453, "glProgramUniform2f");
			funcTable.Load(454, "glProgramUniform2fv");
			funcTable.Load(455, "glProgramUniform2i");
			funcTable.Load(456, "glProgramUniform2iv");
			funcTable.Load(457, "glProgramUniform2ui");
			funcTable.Load(458, "glProgramUniform2uiv");
			funcTable.Load(459, "glProgramUniform3d");
			funcTable.Load(460, "glProgramUniform3dv");
			funcTable.Load(461, "glProgramUniform3f");
			funcTable.Load(462, "glProgramUniform3fv");
			funcTable.Load(463, "glProgramUniform3i");
			funcTable.Load(464, "glProgramUniform3iv");
			funcTable.Load(465, "glProgramUniform3ui");
			funcTable.Load(466, "glProgramUniform3uiv");
			funcTable.Load(467, "glProgramUniform4d");
			funcTable.Load(468, "glProgramUniform4dv");
			funcTable.Load(469, "glProgramUniform4f");
			funcTable.Load(470, "glProgramUniform4fv");
			funcTable.Load(471, "glProgramUniform4i");
			funcTable.Load(472, "glProgramUniform4iv");
			funcTable.Load(473, "glProgramUniform4ui");
			funcTable.Load(474, "glProgramUniform4uiv");
			funcTable.Load(475, "glProgramUniformMatrix2dv");
			funcTable.Load(476, "glProgramUniformMatrix2fv");
			funcTable.Load(477, "glProgramUniformMatrix2x3dv");
			funcTable.Load(478, "glProgramUniformMatrix2x3fv");
			funcTable.Load(479, "glProgramUniformMatrix2x4dv");
			funcTable.Load(480, "glProgramUniformMatrix2x4fv");
			funcTable.Load(481, "glProgramUniformMatrix3dv");
			funcTable.Load(482, "glProgramUniformMatrix3fv");
			funcTable.Load(483, "glProgramUniformMatrix3x2dv");
			funcTable.Load(484, "glProgramUniformMatrix3x2fv");
			funcTable.Load(485, "glProgramUniformMatrix3x4dv");
			funcTable.Load(486, "glProgramUniformMatrix3x4fv");
			funcTable.Load(487, "glProgramUniformMatrix4dv");
			funcTable.Load(488, "glProgramUniformMatrix4fv");
			funcTable.Load(489, "glProgramUniformMatrix4x2dv");
			funcTable.Load(490, "glProgramUniformMatrix4x2fv");
			funcTable.Load(491, "glProgramUniformMatrix4x3dv");
			funcTable.Load(492, "glProgramUniformMatrix4x3fv");
			funcTable.Load(493, "glProvokingVertex");
			funcTable.Load(494, "glPushDebugGroup");
			funcTable.Load(495, "glPushMatrix");
			funcTable.Load(496, "glQueryCounter");
			funcTable.Load(497, "glReadBuffer");
			funcTable.Load(498, "glReadPixels");
			funcTable.Load(499, "glReadnPixels");
			funcTable.Load(500, "glReleaseShaderCompiler");
			funcTable.Load(501, "glRenderbufferStorage");
			funcTable.Load(502, "glRenderbufferStorageMultisample");
			funcTable.Load(503, "glResumeTransformFeedback");
			funcTable.Load(504, "glRotatef");
			funcTable.Load(505, "glRotatex");
			funcTable.Load(506, "glSampleCoverage");
			funcTable.Load(507, "glSampleCoveragex");
			funcTable.Load(508, "glSampleMaski");
			funcTable.Load(509, "glSamplerParameterIiv");
			funcTable.Load(510, "glSamplerParameterIuiv");
			funcTable.Load(511, "glSamplerParameterf");
			funcTable.Load(512, "glSamplerParameterfv");
			funcTable.Load(513, "glSamplerParameteri");
			funcTable.Load(514, "glSamplerParameteriv");
			funcTable.Load(515, "glScalef");
			funcTable.Load(516, "glScalex");
			funcTable.Load(517, "glScissor");
			funcTable.Load(518, "glScissorArrayv");
			funcTable.Load(519, "glScissorIndexed");
			funcTable.Load(520, "glScissorIndexedv");
			funcTable.Load(521, "glShadeModel");
			funcTable.Load(522, "glShaderBinary");
			funcTable.Load(523, "glShaderSource");
			funcTable.Load(524, "glShaderStorageBlockBinding");
			funcTable.Load(525, "glSpecializeShader");
			funcTable.Load(526, "glStencilFunc");
			funcTable.Load(527, "glStencilFuncSeparate");
			funcTable.Load(528, "glStencilMask");
			funcTable.Load(529, "glStencilMaskSeparate");
			funcTable.Load(530, "glStencilOp");
			funcTable.Load(531, "glStencilOpSeparate");
			funcTable.Load(532, "glTexBuffer");
			funcTable.Load(533, "glTexBufferRange");
			funcTable.Load(534, "glTexCoordPointer");
			funcTable.Load(535, "glTexEnvf");
			funcTable.Load(536, "glTexEnvfv");
			funcTable.Load(537, "glTexEnvi");
			funcTable.Load(538, "glTexEnviv");
			funcTable.Load(539, "glTexEnvx");
			funcTable.Load(540, "glTexEnvxv");
			funcTable.Load(541, "glTexImage1D");
			funcTable.Load(542, "glTexImage2D");
			funcTable.Load(543, "glTexImage2DMultisample");
			funcTable.Load(544, "glTexImage3D");
			funcTable.Load(545, "glTexImage3DMultisample");
			funcTable.Load(546, "glTexParameterIiv");
			funcTable.Load(547, "glTexParameterIuiv");
			funcTable.Load(548, "glTexParameterf");
			funcTable.Load(549, "glTexParameterfv");
			funcTable.Load(550, "glTexParameteri");
			funcTable.Load(551, "glTexParameteriv");
			funcTable.Load(552, "glTexParameterx");
			funcTable.Load(553, "glTexParameterxv");
			funcTable.Load(554, "glTexStorage1D");
			funcTable.Load(555, "glTexStorage2D");
			funcTable.Load(556, "glTexStorage2DMultisample");
			funcTable.Load(557, "glTexStorage3D");
			funcTable.Load(558, "glTexStorage3DMultisample");
			funcTable.Load(559, "glTexSubImage1D");
			funcTable.Load(560, "glTexSubImage2D");
			funcTable.Load(561, "glTexSubImage3D");
			funcTable.Load(562, "glTextureBarrier");
			funcTable.Load(563, "glTextureBuffer");
			funcTable.Load(564, "glTextureBufferRange");
			funcTable.Load(565, "glTextureParameterIiv");
			funcTable.Load(566, "glTextureParameterIuiv");
			funcTable.Load(567, "glTextureParameterf");
			funcTable.Load(568, "glTextureParameterfv");
			funcTable.Load(569, "glTextureParameteri");
			funcTable.Load(570, "glTextureParameteriv");
			funcTable.Load(571, "glTextureStorage1D");
			funcTable.Load(572, "glTextureStorage2D");
			funcTable.Load(573, "glTextureStorage2DMultisample");
			funcTable.Load(574, "glTextureStorage3D");
			funcTable.Load(575, "glTextureStorage3DMultisample");
			funcTable.Load(576, "glTextureSubImage1D");
			funcTable.Load(577, "glTextureSubImage2D");
			funcTable.Load(578, "glTextureSubImage3D");
			funcTable.Load(579, "glTextureView");
			funcTable.Load(580, "glTransformFeedbackBufferBase");
			funcTable.Load(581, "glTransformFeedbackBufferRange");
			funcTable.Load(582, "glTransformFeedbackVaryings");
			funcTable.Load(583, "glTranslatef");
			funcTable.Load(584, "glTranslatex");
			funcTable.Load(585, "glUniform1d");
			funcTable.Load(586, "glUniform1dv");
			funcTable.Load(587, "glUniform1f");
			funcTable.Load(588, "glUniform1fv");
			funcTable.Load(589, "glUniform1i");
			funcTable.Load(590, "glUniform1iv");
			funcTable.Load(591, "glUniform1ui");
			funcTable.Load(592, "glUniform1uiv");
			funcTable.Load(593, "glUniform2d");
			funcTable.Load(594, "glUniform2dv");
			funcTable.Load(595, "glUniform2f");
			funcTable.Load(596, "glUniform2fv");
			funcTable.Load(597, "glUniform2i");
			funcTable.Load(598, "glUniform2iv");
			funcTable.Load(599, "glUniform2ui");
			funcTable.Load(600, "glUniform2uiv");
			funcTable.Load(601, "glUniform3d");
			funcTable.Load(602, "glUniform3dv");
			funcTable.Load(603, "glUniform3f");
			funcTable.Load(604, "glUniform3fv");
			funcTable.Load(605, "glUniform3i");
			funcTable.Load(606, "glUniform3iv");
			funcTable.Load(607, "glUniform3ui");
			funcTable.Load(608, "glUniform3uiv");
			funcTable.Load(609, "glUniform4d");
			funcTable.Load(610, "glUniform4dv");
			funcTable.Load(611, "glUniform4f");
			funcTable.Load(612, "glUniform4fv");
			funcTable.Load(613, "glUniform4i");
			funcTable.Load(614, "glUniform4iv");
			funcTable.Load(615, "glUniform4ui");
			funcTable.Load(616, "glUniform4uiv");
			funcTable.Load(617, "glUniformBlockBinding");
			funcTable.Load(618, "glUniformMatrix2dv");
			funcTable.Load(619, "glUniformMatrix2fv");
			funcTable.Load(620, "glUniformMatrix2x3dv");
			funcTable.Load(621, "glUniformMatrix2x3fv");
			funcTable.Load(622, "glUniformMatrix2x4dv");
			funcTable.Load(623, "glUniformMatrix2x4fv");
			funcTable.Load(624, "glUniformMatrix3dv");
			funcTable.Load(625, "glUniformMatrix3fv");
			funcTable.Load(626, "glUniformMatrix3x2dv");
			funcTable.Load(627, "glUniformMatrix3x2fv");
			funcTable.Load(628, "glUniformMatrix3x4dv");
			funcTable.Load(629, "glUniformMatrix3x4fv");
			funcTable.Load(630, "glUniformMatrix4dv");
			funcTable.Load(631, "glUniformMatrix4fv");
			funcTable.Load(632, "glUniformMatrix4x2dv");
			funcTable.Load(633, "glUniformMatrix4x2fv");
			funcTable.Load(634, "glUniformMatrix4x3dv");
			funcTable.Load(635, "glUniformMatrix4x3fv");
			funcTable.Load(636, "glUniformSubroutinesuiv");
			funcTable.Load(637, "glUnmapBuffer");
			funcTable.Load(638, "glUnmapNamedBuffer");
			funcTable.Load(639, "glUseProgram");
			funcTable.Load(640, "glUseProgramStages");
			funcTable.Load(641, "glValidateProgram");
			funcTable.Load(642, "glValidateProgramPipeline");
			funcTable.Load(643, "glVertexArrayAttribBinding");
			funcTable.Load(644, "glVertexArrayAttribFormat");
			funcTable.Load(645, "glVertexArrayAttribIFormat");
			funcTable.Load(646, "glVertexArrayAttribLFormat");
			funcTable.Load(647, "glVertexArrayBindingDivisor");
			funcTable.Load(648, "glVertexArrayElementBuffer");
			funcTable.Load(649, "glVertexArrayVertexBuffer");
			funcTable.Load(650, "glVertexArrayVertexBuffers");
			funcTable.Load(651, "glVertexAttrib1d");
			funcTable.Load(652, "glVertexAttrib1dv");
			funcTable.Load(653, "glVertexAttrib1f");
			funcTable.Load(654, "glVertexAttrib1fv");
			funcTable.Load(655, "glVertexAttrib1s");
			funcTable.Load(656, "glVertexAttrib1sv");
			funcTable.Load(657, "glVertexAttrib2d");
			funcTable.Load(658, "glVertexAttrib2dv");
			funcTable.Load(659, "glVertexAttrib2f");
			funcTable.Load(660, "glVertexAttrib2fv");
			funcTable.Load(661, "glVertexAttrib2s");
			funcTable.Load(662, "glVertexAttrib2sv");
			funcTable.Load(663, "glVertexAttrib3d");
			funcTable.Load(664, "glVertexAttrib3dv");
			funcTable.Load(665, "glVertexAttrib3f");
			funcTable.Load(666, "glVertexAttrib3fv");
			funcTable.Load(667, "glVertexAttrib3s");
			funcTable.Load(668, "glVertexAttrib3sv");
			funcTable.Load(669, "glVertexAttrib4Nbv");
			funcTable.Load(670, "glVertexAttrib4Niv");
			funcTable.Load(671, "glVertexAttrib4Nsv");
			funcTable.Load(672, "glVertexAttrib4Nub");
			funcTable.Load(673, "glVertexAttrib4Nubv");
			funcTable.Load(674, "glVertexAttrib4Nuiv");
			funcTable.Load(675, "glVertexAttrib4Nusv");
			funcTable.Load(676, "glVertexAttrib4bv");
			funcTable.Load(677, "glVertexAttrib4d");
			funcTable.Load(678, "glVertexAttrib4dv");
			funcTable.Load(679, "glVertexAttrib4f");
			funcTable.Load(680, "glVertexAttrib4fv");
			funcTable.Load(681, "glVertexAttrib4iv");
			funcTable.Load(682, "glVertexAttrib4s");
			funcTable.Load(683, "glVertexAttrib4sv");
			funcTable.Load(684, "glVertexAttrib4ubv");
			funcTable.Load(685, "glVertexAttrib4uiv");
			funcTable.Load(686, "glVertexAttrib4usv");
			funcTable.Load(687, "glVertexAttribBinding");
			funcTable.Load(688, "glVertexAttribDivisor");
			funcTable.Load(689, "glVertexAttribFormat");
			funcTable.Load(690, "glVertexAttribI1i");
			funcTable.Load(691, "glVertexAttribI1iv");
			funcTable.Load(692, "glVertexAttribI1ui");
			funcTable.Load(693, "glVertexAttribI1uiv");
			funcTable.Load(694, "glVertexAttribI2i");
			funcTable.Load(695, "glVertexAttribI2iv");
			funcTable.Load(696, "glVertexAttribI2ui");
			funcTable.Load(697, "glVertexAttribI2uiv");
			funcTable.Load(698, "glVertexAttribI3i");
			funcTable.Load(699, "glVertexAttribI3iv");
			funcTable.Load(700, "glVertexAttribI3ui");
			funcTable.Load(701, "glVertexAttribI3uiv");
			funcTable.Load(702, "glVertexAttribI4bv");
			funcTable.Load(703, "glVertexAttribI4i");
			funcTable.Load(704, "glVertexAttribI4iv");
			funcTable.Load(705, "glVertexAttribI4sv");
			funcTable.Load(706, "glVertexAttribI4ubv");
			funcTable.Load(707, "glVertexAttribI4ui");
			funcTable.Load(708, "glVertexAttribI4uiv");
			funcTable.Load(709, "glVertexAttribI4usv");
			funcTable.Load(710, "glVertexAttribIFormat");
			funcTable.Load(711, "glVertexAttribIPointer");
			funcTable.Load(712, "glVertexAttribL1d");
			funcTable.Load(713, "glVertexAttribL1dv");
			funcTable.Load(714, "glVertexAttribL2d");
			funcTable.Load(715, "glVertexAttribL2dv");
			funcTable.Load(716, "glVertexAttribL3d");
			funcTable.Load(717, "glVertexAttribL3dv");
			funcTable.Load(718, "glVertexAttribL4d");
			funcTable.Load(719, "glVertexAttribL4dv");
			funcTable.Load(720, "glVertexAttribLFormat");
			funcTable.Load(721, "glVertexAttribLPointer");
			funcTable.Load(722, "glVertexAttribP1ui");
			funcTable.Load(723, "glVertexAttribP1uiv");
			funcTable.Load(724, "glVertexAttribP2ui");
			funcTable.Load(725, "glVertexAttribP2uiv");
			funcTable.Load(726, "glVertexAttribP3ui");
			funcTable.Load(727, "glVertexAttribP3uiv");
			funcTable.Load(728, "glVertexAttribP4ui");
			funcTable.Load(729, "glVertexAttribP4uiv");
			funcTable.Load(730, "glVertexAttribPointer");
			funcTable.Load(731, "glVertexBindingDivisor");
			funcTable.Load(732, "glVertexPointer");
			funcTable.Load(733, "glViewport");
			funcTable.Load(734, "glViewportArrayv");
			funcTable.Load(735, "glViewportIndexedf");
			funcTable.Load(736, "glViewportIndexedfv");
			funcTable.Load(737, "glWaitSync");
		}

		public static void FreeApi()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
			GLBase.NativeContext = null;
		}
	}
}
