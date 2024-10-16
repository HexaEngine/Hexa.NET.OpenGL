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
			funcTable = new FunctionTable(context, 657);
			funcTable.Load(0, "glActiveShaderProgram");
			funcTable.Load(1, "glActiveTexture");
			funcTable.Load(2, "glAttachShader");
			funcTable.Load(3, "glBeginConditionalRender");
			funcTable.Load(4, "glBeginQuery");
			funcTable.Load(5, "glBeginQueryIndexed");
			funcTable.Load(6, "glBeginTransformFeedback");
			funcTable.Load(7, "glBindAttribLocation");
			funcTable.Load(8, "glBindBuffer");
			funcTable.Load(9, "glBindBufferBase");
			funcTable.Load(10, "glBindBufferRange");
			funcTable.Load(11, "glBindBuffersBase");
			funcTable.Load(12, "glBindBuffersRange");
			funcTable.Load(13, "glBindFragDataLocation");
			funcTable.Load(14, "glBindFragDataLocationIndexed");
			funcTable.Load(15, "glBindFramebuffer");
			funcTable.Load(16, "glBindImageTexture");
			funcTable.Load(17, "glBindImageTextures");
			funcTable.Load(18, "glBindProgramPipeline");
			funcTable.Load(19, "glBindRenderbuffer");
			funcTable.Load(20, "glBindSampler");
			funcTable.Load(21, "glBindSamplers");
			funcTable.Load(22, "glBindTexture");
			funcTable.Load(23, "glBindTextureUnit");
			funcTable.Load(24, "glBindTextures");
			funcTable.Load(25, "glBindTransformFeedback");
			funcTable.Load(26, "glBindVertexArray");
			funcTable.Load(27, "glBindVertexBuffer");
			funcTable.Load(28, "glBindVertexBuffers");
			funcTable.Load(29, "glBlendColor");
			funcTable.Load(30, "glBlendEquation");
			funcTable.Load(31, "glBlendEquationSeparate");
			funcTable.Load(32, "glBlendEquationSeparatei");
			funcTable.Load(33, "glBlendEquationi");
			funcTable.Load(34, "glBlendFunc");
			funcTable.Load(35, "glBlendFuncSeparate");
			funcTable.Load(36, "glBlendFuncSeparatei");
			funcTable.Load(37, "glBlendFunci");
			funcTable.Load(38, "glBlitFramebuffer");
			funcTable.Load(39, "glBlitNamedFramebuffer");
			funcTable.Load(40, "glBufferData");
			funcTable.Load(41, "glBufferStorage");
			funcTable.Load(42, "glBufferSubData");
			funcTable.Load(43, "glCheckFramebufferStatus");
			funcTable.Load(44, "glCheckNamedFramebufferStatus");
			funcTable.Load(45, "glClampColor");
			funcTable.Load(46, "glClear");
			funcTable.Load(47, "glClearBufferData");
			funcTable.Load(48, "glClearBufferSubData");
			funcTable.Load(49, "glClearBufferfi");
			funcTable.Load(50, "glClearBufferfv");
			funcTable.Load(51, "glClearBufferiv");
			funcTable.Load(52, "glClearBufferuiv");
			funcTable.Load(53, "glClearColor");
			funcTable.Load(54, "glClearDepth");
			funcTable.Load(55, "glClearDepthf");
			funcTable.Load(56, "glClearNamedBufferData");
			funcTable.Load(57, "glClearNamedBufferSubData");
			funcTable.Load(58, "glClearNamedFramebufferfi");
			funcTable.Load(59, "glClearNamedFramebufferfv");
			funcTable.Load(60, "glClearNamedFramebufferiv");
			funcTable.Load(61, "glClearNamedFramebufferuiv");
			funcTable.Load(62, "glClearStencil");
			funcTable.Load(63, "glClearTexImage");
			funcTable.Load(64, "glClearTexSubImage");
			funcTable.Load(65, "glClientWaitSync");
			funcTable.Load(66, "glClipControl");
			funcTable.Load(67, "glColorMask");
			funcTable.Load(68, "glColorMaski");
			funcTable.Load(69, "glCompileShader");
			funcTable.Load(70, "glCompressedTexImage1D");
			funcTable.Load(71, "glCompressedTexImage2D");
			funcTable.Load(72, "glCompressedTexImage3D");
			funcTable.Load(73, "glCompressedTexSubImage1D");
			funcTable.Load(74, "glCompressedTexSubImage2D");
			funcTable.Load(75, "glCompressedTexSubImage3D");
			funcTable.Load(76, "glCompressedTextureSubImage1D");
			funcTable.Load(77, "glCompressedTextureSubImage2D");
			funcTable.Load(78, "glCompressedTextureSubImage3D");
			funcTable.Load(79, "glCopyBufferSubData");
			funcTable.Load(80, "glCopyImageSubData");
			funcTable.Load(81, "glCopyNamedBufferSubData");
			funcTable.Load(82, "glCopyTexImage1D");
			funcTable.Load(83, "glCopyTexImage2D");
			funcTable.Load(84, "glCopyTexSubImage1D");
			funcTable.Load(85, "glCopyTexSubImage2D");
			funcTable.Load(86, "glCopyTexSubImage3D");
			funcTable.Load(87, "glCopyTextureSubImage1D");
			funcTable.Load(88, "glCopyTextureSubImage2D");
			funcTable.Load(89, "glCopyTextureSubImage3D");
			funcTable.Load(90, "glCreateBuffers");
			funcTable.Load(91, "glCreateFramebuffers");
			funcTable.Load(92, "glCreateProgram");
			funcTable.Load(93, "glCreateProgramPipelines");
			funcTable.Load(94, "glCreateQueries");
			funcTable.Load(95, "glCreateRenderbuffers");
			funcTable.Load(96, "glCreateSamplers");
			funcTable.Load(97, "glCreateShader");
			funcTable.Load(98, "glCreateShaderProgramv");
			funcTable.Load(99, "glCreateTextures");
			funcTable.Load(100, "glCreateTransformFeedbacks");
			funcTable.Load(101, "glCreateVertexArrays");
			funcTable.Load(102, "glCullFace");
			funcTable.Load(103, "glDebugMessageCallback");
			funcTable.Load(104, "glDebugMessageControl");
			funcTable.Load(105, "glDebugMessageInsert");
			funcTable.Load(106, "glDeleteBuffers");
			funcTable.Load(107, "glDeleteFramebuffers");
			funcTable.Load(108, "glDeleteProgram");
			funcTable.Load(109, "glDeleteProgramPipelines");
			funcTable.Load(110, "glDeleteQueries");
			funcTable.Load(111, "glDeleteRenderbuffers");
			funcTable.Load(112, "glDeleteSamplers");
			funcTable.Load(113, "glDeleteShader");
			funcTable.Load(114, "glDeleteSync");
			funcTable.Load(115, "glDeleteTextures");
			funcTable.Load(116, "glDeleteTransformFeedbacks");
			funcTable.Load(117, "glDeleteVertexArrays");
			funcTable.Load(118, "glDepthFunc");
			funcTable.Load(119, "glDepthMask");
			funcTable.Load(120, "glDepthRange");
			funcTable.Load(121, "glDepthRangeArrayv");
			funcTable.Load(122, "glDepthRangeIndexed");
			funcTable.Load(123, "glDepthRangef");
			funcTable.Load(124, "glDetachShader");
			funcTable.Load(125, "glDisable");
			funcTable.Load(126, "glDisableVertexArrayAttrib");
			funcTable.Load(127, "glDisableVertexAttribArray");
			funcTable.Load(128, "glDisablei");
			funcTable.Load(129, "glDispatchCompute");
			funcTable.Load(130, "glDispatchComputeIndirect");
			funcTable.Load(131, "glDrawArrays");
			funcTable.Load(132, "glDrawArraysIndirect");
			funcTable.Load(133, "glDrawArraysInstanced");
			funcTable.Load(134, "glDrawArraysInstancedBaseInstance");
			funcTable.Load(135, "glDrawBuffer");
			funcTable.Load(136, "glDrawBuffers");
			funcTable.Load(137, "glDrawElements");
			funcTable.Load(138, "glDrawElementsBaseVertex");
			funcTable.Load(139, "glDrawElementsIndirect");
			funcTable.Load(140, "glDrawElementsInstanced");
			funcTable.Load(141, "glDrawElementsInstancedBaseInstance");
			funcTable.Load(142, "glDrawElementsInstancedBaseVertex");
			funcTable.Load(143, "glDrawElementsInstancedBaseVertexBaseInstance");
			funcTable.Load(144, "glDrawRangeElements");
			funcTable.Load(145, "glDrawRangeElementsBaseVertex");
			funcTable.Load(146, "glDrawTransformFeedback");
			funcTable.Load(147, "glDrawTransformFeedbackInstanced");
			funcTable.Load(148, "glDrawTransformFeedbackStream");
			funcTable.Load(149, "glDrawTransformFeedbackStreamInstanced");
			funcTable.Load(150, "glEnable");
			funcTable.Load(151, "glEnableVertexArrayAttrib");
			funcTable.Load(152, "glEnableVertexAttribArray");
			funcTable.Load(153, "glEnablei");
			funcTable.Load(154, "glEndConditionalRender");
			funcTable.Load(155, "glEndQuery");
			funcTable.Load(156, "glEndQueryIndexed");
			funcTable.Load(157, "glEndTransformFeedback");
			funcTable.Load(158, "glFenceSync");
			funcTable.Load(159, "glFinish");
			funcTable.Load(160, "glFlush");
			funcTable.Load(161, "glFlushMappedBufferRange");
			funcTable.Load(162, "glFlushMappedNamedBufferRange");
			funcTable.Load(163, "glFramebufferParameteri");
			funcTable.Load(164, "glFramebufferRenderbuffer");
			funcTable.Load(165, "glFramebufferTexture");
			funcTable.Load(166, "glFramebufferTexture1D");
			funcTable.Load(167, "glFramebufferTexture2D");
			funcTable.Load(168, "glFramebufferTexture3D");
			funcTable.Load(169, "glFramebufferTextureLayer");
			funcTable.Load(170, "glFrontFace");
			funcTable.Load(171, "glGenBuffers");
			funcTable.Load(172, "glGenFramebuffers");
			funcTable.Load(173, "glGenProgramPipelines");
			funcTable.Load(174, "glGenQueries");
			funcTable.Load(175, "glGenRenderbuffers");
			funcTable.Load(176, "glGenSamplers");
			funcTable.Load(177, "glGenTextures");
			funcTable.Load(178, "glGenTransformFeedbacks");
			funcTable.Load(179, "glGenVertexArrays");
			funcTable.Load(180, "glGenerateMipmap");
			funcTable.Load(181, "glGenerateTextureMipmap");
			funcTable.Load(182, "glGetActiveAtomicCounterBufferiv");
			funcTable.Load(183, "glGetActiveAttrib");
			funcTable.Load(184, "glGetActiveSubroutineName");
			funcTable.Load(185, "glGetActiveSubroutineUniformName");
			funcTable.Load(186, "glGetActiveSubroutineUniformiv");
			funcTable.Load(187, "glGetActiveUniform");
			funcTable.Load(188, "glGetActiveUniformBlockName");
			funcTable.Load(189, "glGetActiveUniformBlockiv");
			funcTable.Load(190, "glGetActiveUniformName");
			funcTable.Load(191, "glGetActiveUniformsiv");
			funcTable.Load(192, "glGetAttachedShaders");
			funcTable.Load(193, "glGetAttribLocation");
			funcTable.Load(194, "glGetBooleani_v");
			funcTable.Load(195, "glGetBooleanv");
			funcTable.Load(196, "glGetBufferParameteri64v");
			funcTable.Load(197, "glGetBufferParameteriv");
			funcTable.Load(198, "glGetBufferPointerv");
			funcTable.Load(199, "glGetBufferSubData");
			funcTable.Load(200, "glGetCompressedTexImage");
			funcTable.Load(201, "glGetCompressedTextureImage");
			funcTable.Load(202, "glGetCompressedTextureSubImage");
			funcTable.Load(203, "glGetDebugMessageLog");
			funcTable.Load(204, "glGetDoublei_v");
			funcTable.Load(205, "glGetDoublev");
			funcTable.Load(206, "glGetError");
			funcTable.Load(207, "glGetFloati_v");
			funcTable.Load(208, "glGetFloatv");
			funcTable.Load(209, "glGetFragDataIndex");
			funcTable.Load(210, "glGetFragDataLocation");
			funcTable.Load(211, "glGetFramebufferAttachmentParameteriv");
			funcTable.Load(212, "glGetFramebufferParameteriv");
			funcTable.Load(213, "glGetGraphicsResetStatus");
			funcTable.Load(214, "glGetInteger64i_v");
			funcTable.Load(215, "glGetInteger64v");
			funcTable.Load(216, "glGetIntegeri_v");
			funcTable.Load(217, "glGetIntegerv");
			funcTable.Load(218, "glGetInternalformati64v");
			funcTable.Load(219, "glGetInternalformativ");
			funcTable.Load(220, "glGetMultisamplefv");
			funcTable.Load(221, "glGetNamedBufferParameteri64v");
			funcTable.Load(222, "glGetNamedBufferParameteriv");
			funcTable.Load(223, "glGetNamedBufferPointerv");
			funcTable.Load(224, "glGetNamedBufferSubData");
			funcTable.Load(225, "glGetNamedFramebufferAttachmentParameteriv");
			funcTable.Load(226, "glGetNamedFramebufferParameteriv");
			funcTable.Load(227, "glGetNamedRenderbufferParameteriv");
			funcTable.Load(228, "glGetObjectLabel");
			funcTable.Load(229, "glGetObjectPtrLabel");
			funcTable.Load(230, "glGetPointerv");
			funcTable.Load(231, "glGetProgramBinary");
			funcTable.Load(232, "glGetProgramInfoLog");
			funcTable.Load(233, "glGetProgramInterfaceiv");
			funcTable.Load(234, "glGetProgramPipelineInfoLog");
			funcTable.Load(235, "glGetProgramPipelineiv");
			funcTable.Load(236, "glGetProgramResourceIndex");
			funcTable.Load(237, "glGetProgramResourceLocation");
			funcTable.Load(238, "glGetProgramResourceLocationIndex");
			funcTable.Load(239, "glGetProgramResourceName");
			funcTable.Load(240, "glGetProgramResourceiv");
			funcTable.Load(241, "glGetProgramStageiv");
			funcTable.Load(242, "glGetProgramiv");
			funcTable.Load(243, "glGetQueryBufferObjecti64v");
			funcTable.Load(244, "glGetQueryBufferObjectiv");
			funcTable.Load(245, "glGetQueryBufferObjectui64v");
			funcTable.Load(246, "glGetQueryBufferObjectuiv");
			funcTable.Load(247, "glGetQueryIndexediv");
			funcTable.Load(248, "glGetQueryObjecti64v");
			funcTable.Load(249, "glGetQueryObjectiv");
			funcTable.Load(250, "glGetQueryObjectui64v");
			funcTable.Load(251, "glGetQueryObjectuiv");
			funcTable.Load(252, "glGetQueryiv");
			funcTable.Load(253, "glGetRenderbufferParameteriv");
			funcTable.Load(254, "glGetSamplerParameterIiv");
			funcTable.Load(255, "glGetSamplerParameterIuiv");
			funcTable.Load(256, "glGetSamplerParameterfv");
			funcTable.Load(257, "glGetSamplerParameteriv");
			funcTable.Load(258, "glGetShaderInfoLog");
			funcTable.Load(259, "glGetShaderPrecisionFormat");
			funcTable.Load(260, "glGetShaderSource");
			funcTable.Load(261, "glGetShaderiv");
			funcTable.Load(262, "glGetString");
			funcTable.Load(263, "glGetStringi");
			funcTable.Load(264, "glGetSubroutineIndex");
			funcTable.Load(265, "glGetSubroutineUniformLocation");
			funcTable.Load(266, "glGetSynciv");
			funcTable.Load(267, "glGetTexImage");
			funcTable.Load(268, "glGetTexLevelParameterfv");
			funcTable.Load(269, "glGetTexLevelParameteriv");
			funcTable.Load(270, "glGetTexParameterIiv");
			funcTable.Load(271, "glGetTexParameterIuiv");
			funcTable.Load(272, "glGetTexParameterfv");
			funcTable.Load(273, "glGetTexParameteriv");
			funcTable.Load(274, "glGetTextureImage");
			funcTable.Load(275, "glGetTextureLevelParameterfv");
			funcTable.Load(276, "glGetTextureLevelParameteriv");
			funcTable.Load(277, "glGetTextureParameterIiv");
			funcTable.Load(278, "glGetTextureParameterIuiv");
			funcTable.Load(279, "glGetTextureParameterfv");
			funcTable.Load(280, "glGetTextureParameteriv");
			funcTable.Load(281, "glGetTextureSubImage");
			funcTable.Load(282, "glGetTransformFeedbackVarying");
			funcTable.Load(283, "glGetTransformFeedbacki64_v");
			funcTable.Load(284, "glGetTransformFeedbacki_v");
			funcTable.Load(285, "glGetTransformFeedbackiv");
			funcTable.Load(286, "glGetUniformBlockIndex");
			funcTable.Load(287, "glGetUniformIndices");
			funcTable.Load(288, "glGetUniformLocation");
			funcTable.Load(289, "glGetUniformSubroutineuiv");
			funcTable.Load(290, "glGetUniformdv");
			funcTable.Load(291, "glGetUniformfv");
			funcTable.Load(292, "glGetUniformiv");
			funcTable.Load(293, "glGetUniformuiv");
			funcTable.Load(294, "glGetVertexArrayIndexed64iv");
			funcTable.Load(295, "glGetVertexArrayIndexediv");
			funcTable.Load(296, "glGetVertexArrayiv");
			funcTable.Load(297, "glGetVertexAttribIiv");
			funcTable.Load(298, "glGetVertexAttribIuiv");
			funcTable.Load(299, "glGetVertexAttribLdv");
			funcTable.Load(300, "glGetVertexAttribPointerv");
			funcTable.Load(301, "glGetVertexAttribdv");
			funcTable.Load(302, "glGetVertexAttribfv");
			funcTable.Load(303, "glGetVertexAttribiv");
			funcTable.Load(304, "glGetnCompressedTexImage");
			funcTable.Load(305, "glGetnTexImage");
			funcTable.Load(306, "glGetnUniformdv");
			funcTable.Load(307, "glGetnUniformfv");
			funcTable.Load(308, "glGetnUniformiv");
			funcTable.Load(309, "glGetnUniformuiv");
			funcTable.Load(310, "glHint");
			funcTable.Load(311, "glInvalidateBufferData");
			funcTable.Load(312, "glInvalidateBufferSubData");
			funcTable.Load(313, "glInvalidateFramebuffer");
			funcTable.Load(314, "glInvalidateNamedFramebufferData");
			funcTable.Load(315, "glInvalidateNamedFramebufferSubData");
			funcTable.Load(316, "glInvalidateSubFramebuffer");
			funcTable.Load(317, "glInvalidateTexImage");
			funcTable.Load(318, "glInvalidateTexSubImage");
			funcTable.Load(319, "glIsBuffer");
			funcTable.Load(320, "glIsEnabled");
			funcTable.Load(321, "glIsEnabledi");
			funcTable.Load(322, "glIsFramebuffer");
			funcTable.Load(323, "glIsProgram");
			funcTable.Load(324, "glIsProgramPipeline");
			funcTable.Load(325, "glIsQuery");
			funcTable.Load(326, "glIsRenderbuffer");
			funcTable.Load(327, "glIsSampler");
			funcTable.Load(328, "glIsShader");
			funcTable.Load(329, "glIsSync");
			funcTable.Load(330, "glIsTexture");
			funcTable.Load(331, "glIsTransformFeedback");
			funcTable.Load(332, "glIsVertexArray");
			funcTable.Load(333, "glLineWidth");
			funcTable.Load(334, "glLinkProgram");
			funcTable.Load(335, "glLogicOp");
			funcTable.Load(336, "glMapBuffer");
			funcTable.Load(337, "glMapBufferRange");
			funcTable.Load(338, "glMapNamedBuffer");
			funcTable.Load(339, "glMapNamedBufferRange");
			funcTable.Load(340, "glMemoryBarrier");
			funcTable.Load(341, "glMemoryBarrierByRegion");
			funcTable.Load(342, "glMinSampleShading");
			funcTable.Load(343, "glMultiDrawArrays");
			funcTable.Load(344, "glMultiDrawArraysIndirect");
			funcTable.Load(345, "glMultiDrawArraysIndirectCount");
			funcTable.Load(346, "glMultiDrawElements");
			funcTable.Load(347, "glMultiDrawElementsBaseVertex");
			funcTable.Load(348, "glMultiDrawElementsIndirect");
			funcTable.Load(349, "glMultiDrawElementsIndirectCount");
			funcTable.Load(350, "glNamedBufferData");
			funcTable.Load(351, "glNamedBufferStorage");
			funcTable.Load(352, "glNamedBufferSubData");
			funcTable.Load(353, "glNamedFramebufferDrawBuffer");
			funcTable.Load(354, "glNamedFramebufferDrawBuffers");
			funcTable.Load(355, "glNamedFramebufferParameteri");
			funcTable.Load(356, "glNamedFramebufferReadBuffer");
			funcTable.Load(357, "glNamedFramebufferRenderbuffer");
			funcTable.Load(358, "glNamedFramebufferTexture");
			funcTable.Load(359, "glNamedFramebufferTextureLayer");
			funcTable.Load(360, "glNamedRenderbufferStorage");
			funcTable.Load(361, "glNamedRenderbufferStorageMultisample");
			funcTable.Load(362, "glObjectLabel");
			funcTable.Load(363, "glObjectPtrLabel");
			funcTable.Load(364, "glPatchParameterfv");
			funcTable.Load(365, "glPatchParameteri");
			funcTable.Load(366, "glPauseTransformFeedback");
			funcTable.Load(367, "glPixelStoref");
			funcTable.Load(368, "glPixelStorei");
			funcTable.Load(369, "glPointParameterf");
			funcTable.Load(370, "glPointParameterfv");
			funcTable.Load(371, "glPointParameteri");
			funcTable.Load(372, "glPointParameteriv");
			funcTable.Load(373, "glPointSize");
			funcTable.Load(374, "glPolygonMode");
			funcTable.Load(375, "glPolygonOffset");
			funcTable.Load(376, "glPolygonOffsetClamp");
			funcTable.Load(377, "glPopDebugGroup");
			funcTable.Load(378, "glPrimitiveRestartIndex");
			funcTable.Load(379, "glProgramBinary");
			funcTable.Load(380, "glProgramParameteri");
			funcTable.Load(381, "glProgramUniform1d");
			funcTable.Load(382, "glProgramUniform1dv");
			funcTable.Load(383, "glProgramUniform1f");
			funcTable.Load(384, "glProgramUniform1fv");
			funcTable.Load(385, "glProgramUniform1i");
			funcTable.Load(386, "glProgramUniform1iv");
			funcTable.Load(387, "glProgramUniform1ui");
			funcTable.Load(388, "glProgramUniform1uiv");
			funcTable.Load(389, "glProgramUniform2d");
			funcTable.Load(390, "glProgramUniform2dv");
			funcTable.Load(391, "glProgramUniform2f");
			funcTable.Load(392, "glProgramUniform2fv");
			funcTable.Load(393, "glProgramUniform2i");
			funcTable.Load(394, "glProgramUniform2iv");
			funcTable.Load(395, "glProgramUniform2ui");
			funcTable.Load(396, "glProgramUniform2uiv");
			funcTable.Load(397, "glProgramUniform3d");
			funcTable.Load(398, "glProgramUniform3dv");
			funcTable.Load(399, "glProgramUniform3f");
			funcTable.Load(400, "glProgramUniform3fv");
			funcTable.Load(401, "glProgramUniform3i");
			funcTable.Load(402, "glProgramUniform3iv");
			funcTable.Load(403, "glProgramUniform3ui");
			funcTable.Load(404, "glProgramUniform3uiv");
			funcTable.Load(405, "glProgramUniform4d");
			funcTable.Load(406, "glProgramUniform4dv");
			funcTable.Load(407, "glProgramUniform4f");
			funcTable.Load(408, "glProgramUniform4fv");
			funcTable.Load(409, "glProgramUniform4i");
			funcTable.Load(410, "glProgramUniform4iv");
			funcTable.Load(411, "glProgramUniform4ui");
			funcTable.Load(412, "glProgramUniform4uiv");
			funcTable.Load(413, "glProgramUniformMatrix2dv");
			funcTable.Load(414, "glProgramUniformMatrix2fv");
			funcTable.Load(415, "glProgramUniformMatrix2x3dv");
			funcTable.Load(416, "glProgramUniformMatrix2x3fv");
			funcTable.Load(417, "glProgramUniformMatrix2x4dv");
			funcTable.Load(418, "glProgramUniformMatrix2x4fv");
			funcTable.Load(419, "glProgramUniformMatrix3dv");
			funcTable.Load(420, "glProgramUniformMatrix3fv");
			funcTable.Load(421, "glProgramUniformMatrix3x2dv");
			funcTable.Load(422, "glProgramUniformMatrix3x2fv");
			funcTable.Load(423, "glProgramUniformMatrix3x4dv");
			funcTable.Load(424, "glProgramUniformMatrix3x4fv");
			funcTable.Load(425, "glProgramUniformMatrix4dv");
			funcTable.Load(426, "glProgramUniformMatrix4fv");
			funcTable.Load(427, "glProgramUniformMatrix4x2dv");
			funcTable.Load(428, "glProgramUniformMatrix4x2fv");
			funcTable.Load(429, "glProgramUniformMatrix4x3dv");
			funcTable.Load(430, "glProgramUniformMatrix4x3fv");
			funcTable.Load(431, "glProvokingVertex");
			funcTable.Load(432, "glPushDebugGroup");
			funcTable.Load(433, "glQueryCounter");
			funcTable.Load(434, "glReadBuffer");
			funcTable.Load(435, "glReadPixels");
			funcTable.Load(436, "glReadnPixels");
			funcTable.Load(437, "glReleaseShaderCompiler");
			funcTable.Load(438, "glRenderbufferStorage");
			funcTable.Load(439, "glRenderbufferStorageMultisample");
			funcTable.Load(440, "glResumeTransformFeedback");
			funcTable.Load(441, "glSampleCoverage");
			funcTable.Load(442, "glSampleMaski");
			funcTable.Load(443, "glSamplerParameterIiv");
			funcTable.Load(444, "glSamplerParameterIuiv");
			funcTable.Load(445, "glSamplerParameterf");
			funcTable.Load(446, "glSamplerParameterfv");
			funcTable.Load(447, "glSamplerParameteri");
			funcTable.Load(448, "glSamplerParameteriv");
			funcTable.Load(449, "glScissor");
			funcTable.Load(450, "glScissorArrayv");
			funcTable.Load(451, "glScissorIndexed");
			funcTable.Load(452, "glScissorIndexedv");
			funcTable.Load(453, "glShaderBinary");
			funcTable.Load(454, "glShaderSource");
			funcTable.Load(455, "glShaderStorageBlockBinding");
			funcTable.Load(456, "glSpecializeShader");
			funcTable.Load(457, "glStencilFunc");
			funcTable.Load(458, "glStencilFuncSeparate");
			funcTable.Load(459, "glStencilMask");
			funcTable.Load(460, "glStencilMaskSeparate");
			funcTable.Load(461, "glStencilOp");
			funcTable.Load(462, "glStencilOpSeparate");
			funcTable.Load(463, "glTexBuffer");
			funcTable.Load(464, "glTexBufferRange");
			funcTable.Load(465, "glTexImage1D");
			funcTable.Load(466, "glTexImage2D");
			funcTable.Load(467, "glTexImage2DMultisample");
			funcTable.Load(468, "glTexImage3D");
			funcTable.Load(469, "glTexImage3DMultisample");
			funcTable.Load(470, "glTexParameterIiv");
			funcTable.Load(471, "glTexParameterIuiv");
			funcTable.Load(472, "glTexParameterf");
			funcTable.Load(473, "glTexParameterfv");
			funcTable.Load(474, "glTexParameteri");
			funcTable.Load(475, "glTexParameteriv");
			funcTable.Load(476, "glTexStorage1D");
			funcTable.Load(477, "glTexStorage2D");
			funcTable.Load(478, "glTexStorage2DMultisample");
			funcTable.Load(479, "glTexStorage3D");
			funcTable.Load(480, "glTexStorage3DMultisample");
			funcTable.Load(481, "glTexSubImage1D");
			funcTable.Load(482, "glTexSubImage2D");
			funcTable.Load(483, "glTexSubImage3D");
			funcTable.Load(484, "glTextureBarrier");
			funcTable.Load(485, "glTextureBuffer");
			funcTable.Load(486, "glTextureBufferRange");
			funcTable.Load(487, "glTextureParameterIiv");
			funcTable.Load(488, "glTextureParameterIuiv");
			funcTable.Load(489, "glTextureParameterf");
			funcTable.Load(490, "glTextureParameterfv");
			funcTable.Load(491, "glTextureParameteri");
			funcTable.Load(492, "glTextureParameteriv");
			funcTable.Load(493, "glTextureStorage1D");
			funcTable.Load(494, "glTextureStorage2D");
			funcTable.Load(495, "glTextureStorage2DMultisample");
			funcTable.Load(496, "glTextureStorage3D");
			funcTable.Load(497, "glTextureStorage3DMultisample");
			funcTable.Load(498, "glTextureSubImage1D");
			funcTable.Load(499, "glTextureSubImage2D");
			funcTable.Load(500, "glTextureSubImage3D");
			funcTable.Load(501, "glTextureView");
			funcTable.Load(502, "glTransformFeedbackBufferBase");
			funcTable.Load(503, "glTransformFeedbackBufferRange");
			funcTable.Load(504, "glTransformFeedbackVaryings");
			funcTable.Load(505, "glUniform1d");
			funcTable.Load(506, "glUniform1dv");
			funcTable.Load(507, "glUniform1f");
			funcTable.Load(508, "glUniform1fv");
			funcTable.Load(509, "glUniform1i");
			funcTable.Load(510, "glUniform1iv");
			funcTable.Load(511, "glUniform1ui");
			funcTable.Load(512, "glUniform1uiv");
			funcTable.Load(513, "glUniform2d");
			funcTable.Load(514, "glUniform2dv");
			funcTable.Load(515, "glUniform2f");
			funcTable.Load(516, "glUniform2fv");
			funcTable.Load(517, "glUniform2i");
			funcTable.Load(518, "glUniform2iv");
			funcTable.Load(519, "glUniform2ui");
			funcTable.Load(520, "glUniform2uiv");
			funcTable.Load(521, "glUniform3d");
			funcTable.Load(522, "glUniform3dv");
			funcTable.Load(523, "glUniform3f");
			funcTable.Load(524, "glUniform3fv");
			funcTable.Load(525, "glUniform3i");
			funcTable.Load(526, "glUniform3iv");
			funcTable.Load(527, "glUniform3ui");
			funcTable.Load(528, "glUniform3uiv");
			funcTable.Load(529, "glUniform4d");
			funcTable.Load(530, "glUniform4dv");
			funcTable.Load(531, "glUniform4f");
			funcTable.Load(532, "glUniform4fv");
			funcTable.Load(533, "glUniform4i");
			funcTable.Load(534, "glUniform4iv");
			funcTable.Load(535, "glUniform4ui");
			funcTable.Load(536, "glUniform4uiv");
			funcTable.Load(537, "glUniformBlockBinding");
			funcTable.Load(538, "glUniformMatrix2dv");
			funcTable.Load(539, "glUniformMatrix2fv");
			funcTable.Load(540, "glUniformMatrix2x3dv");
			funcTable.Load(541, "glUniformMatrix2x3fv");
			funcTable.Load(542, "glUniformMatrix2x4dv");
			funcTable.Load(543, "glUniformMatrix2x4fv");
			funcTable.Load(544, "glUniformMatrix3dv");
			funcTable.Load(545, "glUniformMatrix3fv");
			funcTable.Load(546, "glUniformMatrix3x2dv");
			funcTable.Load(547, "glUniformMatrix3x2fv");
			funcTable.Load(548, "glUniformMatrix3x4dv");
			funcTable.Load(549, "glUniformMatrix3x4fv");
			funcTable.Load(550, "glUniformMatrix4dv");
			funcTable.Load(551, "glUniformMatrix4fv");
			funcTable.Load(552, "glUniformMatrix4x2dv");
			funcTable.Load(553, "glUniformMatrix4x2fv");
			funcTable.Load(554, "glUniformMatrix4x3dv");
			funcTable.Load(555, "glUniformMatrix4x3fv");
			funcTable.Load(556, "glUniformSubroutinesuiv");
			funcTable.Load(557, "glUnmapBuffer");
			funcTable.Load(558, "glUnmapNamedBuffer");
			funcTable.Load(559, "glUseProgram");
			funcTable.Load(560, "glUseProgramStages");
			funcTable.Load(561, "glValidateProgram");
			funcTable.Load(562, "glValidateProgramPipeline");
			funcTable.Load(563, "glVertexArrayAttribBinding");
			funcTable.Load(564, "glVertexArrayAttribFormat");
			funcTable.Load(565, "glVertexArrayAttribIFormat");
			funcTable.Load(566, "glVertexArrayAttribLFormat");
			funcTable.Load(567, "glVertexArrayBindingDivisor");
			funcTable.Load(568, "glVertexArrayElementBuffer");
			funcTable.Load(569, "glVertexArrayVertexBuffer");
			funcTable.Load(570, "glVertexArrayVertexBuffers");
			funcTable.Load(571, "glVertexAttrib1d");
			funcTable.Load(572, "glVertexAttrib1dv");
			funcTable.Load(573, "glVertexAttrib1f");
			funcTable.Load(574, "glVertexAttrib1fv");
			funcTable.Load(575, "glVertexAttrib1s");
			funcTable.Load(576, "glVertexAttrib1sv");
			funcTable.Load(577, "glVertexAttrib2d");
			funcTable.Load(578, "glVertexAttrib2dv");
			funcTable.Load(579, "glVertexAttrib2f");
			funcTable.Load(580, "glVertexAttrib2fv");
			funcTable.Load(581, "glVertexAttrib2s");
			funcTable.Load(582, "glVertexAttrib2sv");
			funcTable.Load(583, "glVertexAttrib3d");
			funcTable.Load(584, "glVertexAttrib3dv");
			funcTable.Load(585, "glVertexAttrib3f");
			funcTable.Load(586, "glVertexAttrib3fv");
			funcTable.Load(587, "glVertexAttrib3s");
			funcTable.Load(588, "glVertexAttrib3sv");
			funcTable.Load(589, "glVertexAttrib4Nbv");
			funcTable.Load(590, "glVertexAttrib4Niv");
			funcTable.Load(591, "glVertexAttrib4Nsv");
			funcTable.Load(592, "glVertexAttrib4Nub");
			funcTable.Load(593, "glVertexAttrib4Nubv");
			funcTable.Load(594, "glVertexAttrib4Nuiv");
			funcTable.Load(595, "glVertexAttrib4Nusv");
			funcTable.Load(596, "glVertexAttrib4bv");
			funcTable.Load(597, "glVertexAttrib4d");
			funcTable.Load(598, "glVertexAttrib4dv");
			funcTable.Load(599, "glVertexAttrib4f");
			funcTable.Load(600, "glVertexAttrib4fv");
			funcTable.Load(601, "glVertexAttrib4iv");
			funcTable.Load(602, "glVertexAttrib4s");
			funcTable.Load(603, "glVertexAttrib4sv");
			funcTable.Load(604, "glVertexAttrib4ubv");
			funcTable.Load(605, "glVertexAttrib4uiv");
			funcTable.Load(606, "glVertexAttrib4usv");
			funcTable.Load(607, "glVertexAttribBinding");
			funcTable.Load(608, "glVertexAttribDivisor");
			funcTable.Load(609, "glVertexAttribFormat");
			funcTable.Load(610, "glVertexAttribI1i");
			funcTable.Load(611, "glVertexAttribI1iv");
			funcTable.Load(612, "glVertexAttribI1ui");
			funcTable.Load(613, "glVertexAttribI1uiv");
			funcTable.Load(614, "glVertexAttribI2i");
			funcTable.Load(615, "glVertexAttribI2iv");
			funcTable.Load(616, "glVertexAttribI2ui");
			funcTable.Load(617, "glVertexAttribI2uiv");
			funcTable.Load(618, "glVertexAttribI3i");
			funcTable.Load(619, "glVertexAttribI3iv");
			funcTable.Load(620, "glVertexAttribI3ui");
			funcTable.Load(621, "glVertexAttribI3uiv");
			funcTable.Load(622, "glVertexAttribI4bv");
			funcTable.Load(623, "glVertexAttribI4i");
			funcTable.Load(624, "glVertexAttribI4iv");
			funcTable.Load(625, "glVertexAttribI4sv");
			funcTable.Load(626, "glVertexAttribI4ubv");
			funcTable.Load(627, "glVertexAttribI4ui");
			funcTable.Load(628, "glVertexAttribI4uiv");
			funcTable.Load(629, "glVertexAttribI4usv");
			funcTable.Load(630, "glVertexAttribIFormat");
			funcTable.Load(631, "glVertexAttribIPointer");
			funcTable.Load(632, "glVertexAttribL1d");
			funcTable.Load(633, "glVertexAttribL1dv");
			funcTable.Load(634, "glVertexAttribL2d");
			funcTable.Load(635, "glVertexAttribL2dv");
			funcTable.Load(636, "glVertexAttribL3d");
			funcTable.Load(637, "glVertexAttribL3dv");
			funcTable.Load(638, "glVertexAttribL4d");
			funcTable.Load(639, "glVertexAttribL4dv");
			funcTable.Load(640, "glVertexAttribLFormat");
			funcTable.Load(641, "glVertexAttribLPointer");
			funcTable.Load(642, "glVertexAttribP1ui");
			funcTable.Load(643, "glVertexAttribP1uiv");
			funcTable.Load(644, "glVertexAttribP2ui");
			funcTable.Load(645, "glVertexAttribP2uiv");
			funcTable.Load(646, "glVertexAttribP3ui");
			funcTable.Load(647, "glVertexAttribP3uiv");
			funcTable.Load(648, "glVertexAttribP4ui");
			funcTable.Load(649, "glVertexAttribP4uiv");
			funcTable.Load(650, "glVertexAttribPointer");
			funcTable.Load(651, "glVertexBindingDivisor");
			funcTable.Load(652, "glViewport");
			funcTable.Load(653, "glViewportArrayv");
			funcTable.Load(654, "glViewportIndexedf");
			funcTable.Load(655, "glViewportIndexedfv");
			funcTable.Load(656, "glWaitSync");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}