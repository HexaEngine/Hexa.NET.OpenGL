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
			funcTable = new FunctionTable(context, 344);
			funcTable.Load(0, "glActiveTexture");
			funcTable.Load(1, "glAttachShader");
			funcTable.Load(2, "glBeginConditionalRender");
			funcTable.Load(3, "glBeginQuery");
			funcTable.Load(4, "glBeginTransformFeedback");
			funcTable.Load(5, "glBindAttribLocation");
			funcTable.Load(6, "glBindBuffer");
			funcTable.Load(7, "glBindBufferBase");
			funcTable.Load(8, "glBindBufferRange");
			funcTable.Load(9, "glBindFragDataLocation");
			funcTable.Load(10, "glBindFragDataLocationIndexed");
			funcTable.Load(11, "glBindFramebuffer");
			funcTable.Load(12, "glBindRenderbuffer");
			funcTable.Load(13, "glBindSampler");
			funcTable.Load(14, "glBindTexture");
			funcTable.Load(15, "glBindVertexArray");
			funcTable.Load(16, "glBlendColor");
			funcTable.Load(17, "glBlendEquation");
			funcTable.Load(18, "glBlendEquationSeparate");
			funcTable.Load(19, "glBlendFunc");
			funcTable.Load(20, "glBlendFuncSeparate");
			funcTable.Load(21, "glBlitFramebuffer");
			funcTable.Load(22, "glBufferData");
			funcTable.Load(23, "glBufferSubData");
			funcTable.Load(24, "glCheckFramebufferStatus");
			funcTable.Load(25, "glClampColor");
			funcTable.Load(26, "glClear");
			funcTable.Load(27, "glClearBufferfi");
			funcTable.Load(28, "glClearBufferfv");
			funcTable.Load(29, "glClearBufferiv");
			funcTable.Load(30, "glClearBufferuiv");
			funcTable.Load(31, "glClearColor");
			funcTable.Load(32, "glClearDepth");
			funcTable.Load(33, "glClearStencil");
			funcTable.Load(34, "glClientWaitSync");
			funcTable.Load(35, "glColorMask");
			funcTable.Load(36, "glColorMaski");
			funcTable.Load(37, "glCompileShader");
			funcTable.Load(38, "glCompressedTexImage1D");
			funcTable.Load(39, "glCompressedTexImage2D");
			funcTable.Load(40, "glCompressedTexImage3D");
			funcTable.Load(41, "glCompressedTexSubImage1D");
			funcTable.Load(42, "glCompressedTexSubImage2D");
			funcTable.Load(43, "glCompressedTexSubImage3D");
			funcTable.Load(44, "glCopyBufferSubData");
			funcTable.Load(45, "glCopyTexImage1D");
			funcTable.Load(46, "glCopyTexImage2D");
			funcTable.Load(47, "glCopyTexSubImage1D");
			funcTable.Load(48, "glCopyTexSubImage2D");
			funcTable.Load(49, "glCopyTexSubImage3D");
			funcTable.Load(50, "glCreateProgram");
			funcTable.Load(51, "glCreateShader");
			funcTable.Load(52, "glCullFace");
			funcTable.Load(53, "glDeleteBuffers");
			funcTable.Load(54, "glDeleteFramebuffers");
			funcTable.Load(55, "glDeleteProgram");
			funcTable.Load(56, "glDeleteQueries");
			funcTable.Load(57, "glDeleteRenderbuffers");
			funcTable.Load(58, "glDeleteSamplers");
			funcTable.Load(59, "glDeleteShader");
			funcTable.Load(60, "glDeleteSync");
			funcTable.Load(61, "glDeleteTextures");
			funcTable.Load(62, "glDeleteVertexArrays");
			funcTable.Load(63, "glDepthFunc");
			funcTable.Load(64, "glDepthMask");
			funcTable.Load(65, "glDepthRange");
			funcTable.Load(66, "glDetachShader");
			funcTable.Load(67, "glDisable");
			funcTable.Load(68, "glDisableVertexAttribArray");
			funcTable.Load(69, "glDisablei");
			funcTable.Load(70, "glDrawArrays");
			funcTable.Load(71, "glDrawArraysInstanced");
			funcTable.Load(72, "glDrawBuffer");
			funcTable.Load(73, "glDrawBuffers");
			funcTable.Load(74, "glDrawElements");
			funcTable.Load(75, "glDrawElementsBaseVertex");
			funcTable.Load(76, "glDrawElementsInstanced");
			funcTable.Load(77, "glDrawElementsInstancedBaseVertex");
			funcTable.Load(78, "glDrawRangeElements");
			funcTable.Load(79, "glDrawRangeElementsBaseVertex");
			funcTable.Load(80, "glEnable");
			funcTable.Load(81, "glEnableVertexAttribArray");
			funcTable.Load(82, "glEnablei");
			funcTable.Load(83, "glEndConditionalRender");
			funcTable.Load(84, "glEndQuery");
			funcTable.Load(85, "glEndTransformFeedback");
			funcTable.Load(86, "glFenceSync");
			funcTable.Load(87, "glFinish");
			funcTable.Load(88, "glFlush");
			funcTable.Load(89, "glFlushMappedBufferRange");
			funcTable.Load(90, "glFramebufferRenderbuffer");
			funcTable.Load(91, "glFramebufferTexture");
			funcTable.Load(92, "glFramebufferTexture1D");
			funcTable.Load(93, "glFramebufferTexture2D");
			funcTable.Load(94, "glFramebufferTexture3D");
			funcTable.Load(95, "glFramebufferTextureLayer");
			funcTable.Load(96, "glFrontFace");
			funcTable.Load(97, "glGenBuffers");
			funcTable.Load(98, "glGenFramebuffers");
			funcTable.Load(99, "glGenQueries");
			funcTable.Load(100, "glGenRenderbuffers");
			funcTable.Load(101, "glGenSamplers");
			funcTable.Load(102, "glGenTextures");
			funcTable.Load(103, "glGenVertexArrays");
			funcTable.Load(104, "glGenerateMipmap");
			funcTable.Load(105, "glGetActiveAttrib");
			funcTable.Load(106, "glGetActiveUniform");
			funcTable.Load(107, "glGetActiveUniformBlockName");
			funcTable.Load(108, "glGetActiveUniformBlockiv");
			funcTable.Load(109, "glGetActiveUniformName");
			funcTable.Load(110, "glGetActiveUniformsiv");
			funcTable.Load(111, "glGetAttachedShaders");
			funcTable.Load(112, "glGetAttribLocation");
			funcTable.Load(113, "glGetBooleani_v");
			funcTable.Load(114, "glGetBooleanv");
			funcTable.Load(115, "glGetBufferParameteri64v");
			funcTable.Load(116, "glGetBufferParameteriv");
			funcTable.Load(117, "glGetBufferPointerv");
			funcTable.Load(118, "glGetBufferSubData");
			funcTable.Load(119, "glGetCompressedTexImage");
			funcTable.Load(120, "glGetDoublev");
			funcTable.Load(121, "glGetError");
			funcTable.Load(122, "glGetFloatv");
			funcTable.Load(123, "glGetFragDataIndex");
			funcTable.Load(124, "glGetFragDataLocation");
			funcTable.Load(125, "glGetFramebufferAttachmentParameteriv");
			funcTable.Load(126, "glGetInteger64i_v");
			funcTable.Load(127, "glGetInteger64v");
			funcTable.Load(128, "glGetIntegeri_v");
			funcTable.Load(129, "glGetIntegerv");
			funcTable.Load(130, "glGetMultisamplefv");
			funcTable.Load(131, "glGetProgramInfoLog");
			funcTable.Load(132, "glGetProgramiv");
			funcTable.Load(133, "glGetQueryObjecti64v");
			funcTable.Load(134, "glGetQueryObjectiv");
			funcTable.Load(135, "glGetQueryObjectui64v");
			funcTable.Load(136, "glGetQueryObjectuiv");
			funcTable.Load(137, "glGetQueryiv");
			funcTable.Load(138, "glGetRenderbufferParameteriv");
			funcTable.Load(139, "glGetSamplerParameterIiv");
			funcTable.Load(140, "glGetSamplerParameterIuiv");
			funcTable.Load(141, "glGetSamplerParameterfv");
			funcTable.Load(142, "glGetSamplerParameteriv");
			funcTable.Load(143, "glGetShaderInfoLog");
			funcTable.Load(144, "glGetShaderSource");
			funcTable.Load(145, "glGetShaderiv");
			funcTable.Load(146, "glGetString");
			funcTable.Load(147, "glGetStringi");
			funcTable.Load(148, "glGetSynciv");
			funcTable.Load(149, "glGetTexImage");
			funcTable.Load(150, "glGetTexLevelParameterfv");
			funcTable.Load(151, "glGetTexLevelParameteriv");
			funcTable.Load(152, "glGetTexParameterIiv");
			funcTable.Load(153, "glGetTexParameterIuiv");
			funcTable.Load(154, "glGetTexParameterfv");
			funcTable.Load(155, "glGetTexParameteriv");
			funcTable.Load(156, "glGetTransformFeedbackVarying");
			funcTable.Load(157, "glGetUniformBlockIndex");
			funcTable.Load(158, "glGetUniformIndices");
			funcTable.Load(159, "glGetUniformLocation");
			funcTable.Load(160, "glGetUniformfv");
			funcTable.Load(161, "glGetUniformiv");
			funcTable.Load(162, "glGetUniformuiv");
			funcTable.Load(163, "glGetVertexAttribIiv");
			funcTable.Load(164, "glGetVertexAttribIuiv");
			funcTable.Load(165, "glGetVertexAttribPointerv");
			funcTable.Load(166, "glGetVertexAttribdv");
			funcTable.Load(167, "glGetVertexAttribfv");
			funcTable.Load(168, "glGetVertexAttribiv");
			funcTable.Load(169, "glHint");
			funcTable.Load(170, "glIsBuffer");
			funcTable.Load(171, "glIsEnabled");
			funcTable.Load(172, "glIsEnabledi");
			funcTable.Load(173, "glIsFramebuffer");
			funcTable.Load(174, "glIsProgram");
			funcTable.Load(175, "glIsQuery");
			funcTable.Load(176, "glIsRenderbuffer");
			funcTable.Load(177, "glIsSampler");
			funcTable.Load(178, "glIsShader");
			funcTable.Load(179, "glIsSync");
			funcTable.Load(180, "glIsTexture");
			funcTable.Load(181, "glIsVertexArray");
			funcTable.Load(182, "glLineWidth");
			funcTable.Load(183, "glLinkProgram");
			funcTable.Load(184, "glLogicOp");
			funcTable.Load(185, "glMapBuffer");
			funcTable.Load(186, "glMapBufferRange");
			funcTable.Load(187, "glMultiDrawArrays");
			funcTable.Load(188, "glMultiDrawElements");
			funcTable.Load(189, "glMultiDrawElementsBaseVertex");
			funcTable.Load(190, "glPixelStoref");
			funcTable.Load(191, "glPixelStorei");
			funcTable.Load(192, "glPointParameterf");
			funcTable.Load(193, "glPointParameterfv");
			funcTable.Load(194, "glPointParameteri");
			funcTable.Load(195, "glPointParameteriv");
			funcTable.Load(196, "glPointSize");
			funcTable.Load(197, "glPolygonMode");
			funcTable.Load(198, "glPolygonOffset");
			funcTable.Load(199, "glPrimitiveRestartIndex");
			funcTable.Load(200, "glProvokingVertex");
			funcTable.Load(201, "glQueryCounter");
			funcTable.Load(202, "glReadBuffer");
			funcTable.Load(203, "glReadPixels");
			funcTable.Load(204, "glRenderbufferStorage");
			funcTable.Load(205, "glRenderbufferStorageMultisample");
			funcTable.Load(206, "glSampleCoverage");
			funcTable.Load(207, "glSampleMaski");
			funcTable.Load(208, "glSamplerParameterIiv");
			funcTable.Load(209, "glSamplerParameterIuiv");
			funcTable.Load(210, "glSamplerParameterf");
			funcTable.Load(211, "glSamplerParameterfv");
			funcTable.Load(212, "glSamplerParameteri");
			funcTable.Load(213, "glSamplerParameteriv");
			funcTable.Load(214, "glScissor");
			funcTable.Load(215, "glShaderSource");
			funcTable.Load(216, "glStencilFunc");
			funcTable.Load(217, "glStencilFuncSeparate");
			funcTable.Load(218, "glStencilMask");
			funcTable.Load(219, "glStencilMaskSeparate");
			funcTable.Load(220, "glStencilOp");
			funcTable.Load(221, "glStencilOpSeparate");
			funcTable.Load(222, "glTexBuffer");
			funcTable.Load(223, "glTexImage1D");
			funcTable.Load(224, "glTexImage2D");
			funcTable.Load(225, "glTexImage2DMultisample");
			funcTable.Load(226, "glTexImage3D");
			funcTable.Load(227, "glTexImage3DMultisample");
			funcTable.Load(228, "glTexParameterIiv");
			funcTable.Load(229, "glTexParameterIuiv");
			funcTable.Load(230, "glTexParameterf");
			funcTable.Load(231, "glTexParameterfv");
			funcTable.Load(232, "glTexParameteri");
			funcTable.Load(233, "glTexParameteriv");
			funcTable.Load(234, "glTexSubImage1D");
			funcTable.Load(235, "glTexSubImage2D");
			funcTable.Load(236, "glTexSubImage3D");
			funcTable.Load(237, "glTransformFeedbackVaryings");
			funcTable.Load(238, "glUniform1f");
			funcTable.Load(239, "glUniform1fv");
			funcTable.Load(240, "glUniform1i");
			funcTable.Load(241, "glUniform1iv");
			funcTable.Load(242, "glUniform1ui");
			funcTable.Load(243, "glUniform1uiv");
			funcTable.Load(244, "glUniform2f");
			funcTable.Load(245, "glUniform2fv");
			funcTable.Load(246, "glUniform2i");
			funcTable.Load(247, "glUniform2iv");
			funcTable.Load(248, "glUniform2ui");
			funcTable.Load(249, "glUniform2uiv");
			funcTable.Load(250, "glUniform3f");
			funcTable.Load(251, "glUniform3fv");
			funcTable.Load(252, "glUniform3i");
			funcTable.Load(253, "glUniform3iv");
			funcTable.Load(254, "glUniform3ui");
			funcTable.Load(255, "glUniform3uiv");
			funcTable.Load(256, "glUniform4f");
			funcTable.Load(257, "glUniform4fv");
			funcTable.Load(258, "glUniform4i");
			funcTable.Load(259, "glUniform4iv");
			funcTable.Load(260, "glUniform4ui");
			funcTable.Load(261, "glUniform4uiv");
			funcTable.Load(262, "glUniformBlockBinding");
			funcTable.Load(263, "glUniformMatrix2fv");
			funcTable.Load(264, "glUniformMatrix2x3fv");
			funcTable.Load(265, "glUniformMatrix2x4fv");
			funcTable.Load(266, "glUniformMatrix3fv");
			funcTable.Load(267, "glUniformMatrix3x2fv");
			funcTable.Load(268, "glUniformMatrix3x4fv");
			funcTable.Load(269, "glUniformMatrix4fv");
			funcTable.Load(270, "glUniformMatrix4x2fv");
			funcTable.Load(271, "glUniformMatrix4x3fv");
			funcTable.Load(272, "glUnmapBuffer");
			funcTable.Load(273, "glUseProgram");
			funcTable.Load(274, "glValidateProgram");
			funcTable.Load(275, "glVertexAttrib1d");
			funcTable.Load(276, "glVertexAttrib1dv");
			funcTable.Load(277, "glVertexAttrib1f");
			funcTable.Load(278, "glVertexAttrib1fv");
			funcTable.Load(279, "glVertexAttrib1s");
			funcTable.Load(280, "glVertexAttrib1sv");
			funcTable.Load(281, "glVertexAttrib2d");
			funcTable.Load(282, "glVertexAttrib2dv");
			funcTable.Load(283, "glVertexAttrib2f");
			funcTable.Load(284, "glVertexAttrib2fv");
			funcTable.Load(285, "glVertexAttrib2s");
			funcTable.Load(286, "glVertexAttrib2sv");
			funcTable.Load(287, "glVertexAttrib3d");
			funcTable.Load(288, "glVertexAttrib3dv");
			funcTable.Load(289, "glVertexAttrib3f");
			funcTable.Load(290, "glVertexAttrib3fv");
			funcTable.Load(291, "glVertexAttrib3s");
			funcTable.Load(292, "glVertexAttrib3sv");
			funcTable.Load(293, "glVertexAttrib4Nbv");
			funcTable.Load(294, "glVertexAttrib4Niv");
			funcTable.Load(295, "glVertexAttrib4Nsv");
			funcTable.Load(296, "glVertexAttrib4Nub");
			funcTable.Load(297, "glVertexAttrib4Nubv");
			funcTable.Load(298, "glVertexAttrib4Nuiv");
			funcTable.Load(299, "glVertexAttrib4Nusv");
			funcTable.Load(300, "glVertexAttrib4bv");
			funcTable.Load(301, "glVertexAttrib4d");
			funcTable.Load(302, "glVertexAttrib4dv");
			funcTable.Load(303, "glVertexAttrib4f");
			funcTable.Load(304, "glVertexAttrib4fv");
			funcTable.Load(305, "glVertexAttrib4iv");
			funcTable.Load(306, "glVertexAttrib4s");
			funcTable.Load(307, "glVertexAttrib4sv");
			funcTable.Load(308, "glVertexAttrib4ubv");
			funcTable.Load(309, "glVertexAttrib4uiv");
			funcTable.Load(310, "glVertexAttrib4usv");
			funcTable.Load(311, "glVertexAttribDivisor");
			funcTable.Load(312, "glVertexAttribI1i");
			funcTable.Load(313, "glVertexAttribI1iv");
			funcTable.Load(314, "glVertexAttribI1ui");
			funcTable.Load(315, "glVertexAttribI1uiv");
			funcTable.Load(316, "glVertexAttribI2i");
			funcTable.Load(317, "glVertexAttribI2iv");
			funcTable.Load(318, "glVertexAttribI2ui");
			funcTable.Load(319, "glVertexAttribI2uiv");
			funcTable.Load(320, "glVertexAttribI3i");
			funcTable.Load(321, "glVertexAttribI3iv");
			funcTable.Load(322, "glVertexAttribI3ui");
			funcTable.Load(323, "glVertexAttribI3uiv");
			funcTable.Load(324, "glVertexAttribI4bv");
			funcTable.Load(325, "glVertexAttribI4i");
			funcTable.Load(326, "glVertexAttribI4iv");
			funcTable.Load(327, "glVertexAttribI4sv");
			funcTable.Load(328, "glVertexAttribI4ubv");
			funcTable.Load(329, "glVertexAttribI4ui");
			funcTable.Load(330, "glVertexAttribI4uiv");
			funcTable.Load(331, "glVertexAttribI4usv");
			funcTable.Load(332, "glVertexAttribIPointer");
			funcTable.Load(333, "glVertexAttribP1ui");
			funcTable.Load(334, "glVertexAttribP1uiv");
			funcTable.Load(335, "glVertexAttribP2ui");
			funcTable.Load(336, "glVertexAttribP2uiv");
			funcTable.Load(337, "glVertexAttribP3ui");
			funcTable.Load(338, "glVertexAttribP3uiv");
			funcTable.Load(339, "glVertexAttribP4ui");
			funcTable.Load(340, "glVertexAttribP4uiv");
			funcTable.Load(341, "glVertexAttribPointer");
			funcTable.Load(342, "glViewport");
			funcTable.Load(343, "glWaitSync");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}