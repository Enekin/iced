﻿/*
    Copyright (C) 2018-2019 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class IntelFormatterTest64_NoMemSize_002 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, IntelFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_002.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_002.AllInfos_Length] {
			"vcvtpd2ps xmm2{k3}, xmm3",
			"vcvtpd2ps xmm2, xmmword ptr [rax+0x10]",
			"vcvtpd2ps xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvtpd2ps xmm2{k3}, ymm3",
			"vcvtpd2ps xmm2, ymmword ptr [rax+0x20]",
			"vcvtpd2ps xmm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvtpd2ps ymm2{k3}, zmm3",
			"vcvtpd2ps ymm2, zmmword ptr [rax+0x40]",
			"vcvtpd2ps ymm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"cvtss2sd xmm1, xmm5",
			"cvtss2sd xmm1, dword ptr [rax]",
			"vcvtss2sd xmm2, xmm6, xmm3",
			"vcvtss2sd xmm2, xmm6, dword ptr [rax]",
			"vcvtss2sd xmm2, xmm6, xmm3",
			"vcvtss2sd xmm2, xmm6, dword ptr [rax+4]",
			"cvtsd2ss xmm1, xmm5",
			"cvtsd2ss xmm1, qword ptr [rax]",
			"vcvtsd2ss xmm2, xmm6, xmm3",
			"vcvtsd2ss xmm2, xmm6, qword ptr [rax]",
			"vcvtsd2ss xmm2, xmm6, xmm3",
			"vcvtsd2ss xmm2, xmm6, qword ptr [rax+8]",
			"cvtdq2ps xmm1, xmm5",
			"cvtdq2ps xmm1, [rax]",
			"vcvtdq2ps xmm1, xmm5",
			"vcvtdq2ps xmm2, xmmword ptr [rax]",
			"vcvtdq2ps ymm1, ymm5",
			"vcvtdq2ps ymm2, ymmword ptr [rax]",
			"vcvtdq2ps xmm2{k3}, xmm3",
			"vcvtdq2ps xmm2, xmmword ptr [rax+0x10]",
			"vcvtdq2ps xmm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtdq2ps ymm2{k3}, ymm3",
			"vcvtdq2ps ymm2, ymmword ptr [rax+0x20]",
			"vcvtdq2ps ymm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvtdq2ps zmm2{k3}, zmm3",
			"vcvtdq2ps zmm2, zmmword ptr [rax+0x40]",
			"vcvtdq2ps zmm2{k3}{z}, dword ptr [rax+4]{1to16}",
			"vcvtqq2ps xmm2{k3}, xmm3",
			"vcvtqq2ps xmm2, xmmword ptr [rax+0x10]",
			"vcvtqq2ps xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvtqq2ps xmm2{k3}, ymm3",
			"vcvtqq2ps xmm2, ymmword ptr [rax+0x20]",
			"vcvtqq2ps xmm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvtqq2ps ymm2{k3}, zmm3",
			"vcvtqq2ps ymm2, zmmword ptr [rax+0x40]",
			"vcvtqq2ps ymm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"cvtps2dq xmm1, xmm5",
			"cvtps2dq xmm1, [rax]",
			"vcvtps2dq xmm1, xmm5",
			"vcvtps2dq xmm2, xmmword ptr [rax]",
			"vcvtps2dq ymm1, ymm5",
			"vcvtps2dq ymm2, ymmword ptr [rax]",
			"vcvtps2dq xmm2{k3}, xmm3",
			"vcvtps2dq xmm2, xmmword ptr [rax+0x10]",
			"vcvtps2dq xmm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtps2dq ymm2{k3}, ymm3",
			"vcvtps2dq ymm2, ymmword ptr [rax+0x20]",
			"vcvtps2dq ymm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvtps2dq zmm2{k3}, zmm3",
			"vcvtps2dq zmm2, zmmword ptr [rax+0x40]",
			"vcvtps2dq zmm2{k3}{z}, dword ptr [rax+4]{1to16}",
			"cvttps2dq xmm1, xmm5",
			"cvttps2dq xmm1, [rax]",
			"vcvttps2dq xmm1, xmm5",
			"vcvttps2dq xmm2, xmmword ptr [rax]",
			"vcvttps2dq ymm1, ymm5",
			"vcvttps2dq ymm2, ymmword ptr [rax]",
			"vcvttps2dq xmm2{k3}, xmm3",
			"vcvttps2dq xmm2, xmmword ptr [rax+0x10]",
			"vcvttps2dq xmm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvttps2dq ymm2{k3}, ymm3",
			"vcvttps2dq ymm2, ymmword ptr [rax+0x20]",
			"vcvttps2dq ymm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvttps2dq zmm2{k3}, zmm3",
			"vcvttps2dq zmm2, zmmword ptr [rax+0x40]",
			"vcvttps2dq zmm2{k3}{z}, dword ptr [rax+4]{1to16}",
			"subps xmm1, xmm5",
			"subps xmm1, [rax]",
			"vsubps xmm2, xmm6, xmm3",
			"vsubps xmm2, xmm6, [rax]",
			"vsubps ymm2, ymm6, ymm3",
			"vsubps ymm2, ymm6, [rax]",
			"vsubps xmm2{k3}, xmm6, xmm3",
			"vsubps xmm2{k3}, xmm6, [rax+0x10]",
			"vsubps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vsubps ymm2{k3}, ymm6, ymm3",
			"vsubps ymm2{k3}, ymm6, [rax+0x20]",
			"vsubps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vsubps zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vsubps zmm2{k3}, zmm6, [rax+0x40]",
			"vsubps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"subpd xmm1, xmm5",
			"subpd xmm1, [rax]",
			"vsubpd xmm2, xmm6, xmm3",
			"vsubpd xmm2, xmm6, [rax]",
			"vsubpd ymm2, ymm6, ymm3",
			"vsubpd ymm2, ymm6, [rax]",
			"vsubpd xmm2{k3}{z}, xmm6, xmm3",
			"vsubpd xmm2{k3}, xmm6, [rax+0x10]",
			"vsubpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vsubpd ymm2{k3}{z}, ymm6, ymm3",
			"vsubpd ymm2{k3}, ymm6, [rax+0x20]",
			"vsubpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vsubpd zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vsubpd zmm2{k3}, zmm6, [rax+0x40]",
			"vsubpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"subss xmm1, xmm5",
			"subss xmm1, dword ptr [rax]",
			"vsubss xmm2, xmm6, xmm3",
			"vsubss xmm2, xmm6, dword ptr [rax]",
			"vsubss xmm2{k3}, xmm6, xmm3",
			"vsubss xmm2{k3}, xmm6, dword ptr [rax+4]",
			"subsd xmm1, xmm5",
			"subsd xmm1, qword ptr [rax]",
			"vsubsd xmm2, xmm6, xmm3",
			"vsubsd xmm2, xmm6, qword ptr [rax]",
			"vsubsd xmm2{k3}{z}, xmm6, xmm3",
			"vsubsd xmm2{k3}, xmm6, qword ptr [rax+8]",
			"minps xmm1, xmm5",
			"minps xmm1, [rax]",
			"vminps xmm2, xmm6, xmm3",
			"vminps xmm2, xmm6, [rax]",
			"vminps ymm2, ymm6, ymm3",
			"vminps ymm2, ymm6, [rax]",
			"vminps xmm2{k3}, xmm6, xmm3",
			"vminps xmm2{k3}, xmm6, [rax+0x10]",
			"vminps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vminps ymm2{k3}, ymm6, ymm3",
			"vminps ymm2{k3}, ymm6, [rax+0x20]",
			"vminps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vminps zmm2{k3}{z}{sae}, zmm6, zmm3",
			"vminps zmm2{k3}, zmm6, [rax+0x40]",
			"vminps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"minpd xmm1, xmm5",
			"minpd xmm1, [rax]",
			"vminpd xmm2, xmm6, xmm3",
			"vminpd xmm2, xmm6, [rax]",
			"vminpd ymm2, ymm6, ymm3",
			"vminpd ymm2, ymm6, [rax]",
			"vminpd xmm2{k3}{z}, xmm6, xmm3",
			"vminpd xmm2{k3}, xmm6, [rax+0x10]",
			"vminpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vminpd ymm2{k3}{z}, ymm6, ymm3",
			"vminpd ymm2{k3}, ymm6, [rax+0x20]",
			"vminpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vminpd zmm2{k3}{z}{sae}, zmm6, zmm3",
			"vminpd zmm2{k3}, zmm6, [rax+0x40]",
			"vminpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"minss xmm1, xmm5",
			"minss xmm1, dword ptr [rax]",
			"vminss xmm2, xmm6, xmm3",
			"vminss xmm2, xmm6, dword ptr [rax]",
			"vminss xmm2{k3}, xmm6, xmm3",
			"vminss xmm2{k3}, xmm6, dword ptr [rax+4]",
			"minsd xmm1, xmm5",
			"minsd xmm1, qword ptr [rax]",
			"vminsd xmm2, xmm6, xmm3",
			"vminsd xmm2, xmm6, qword ptr [rax]",
			"vminsd xmm2{k3}{z}, xmm6, xmm3",
			"vminsd xmm2{k3}, xmm6, qword ptr [rax+8]",
			"divps xmm1, xmm5",
			"divps xmm1, [rax]",
			"vdivps xmm2, xmm6, xmm3",
			"vdivps xmm2, xmm6, [rax]",
			"vdivps ymm2, ymm6, ymm3",
			"vdivps ymm2, ymm6, [rax]",
			"vdivps xmm2{k3}, xmm6, xmm3",
			"vdivps xmm2{k3}, xmm6, [rax+0x10]",
			"vdivps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vdivps ymm2{k3}, ymm6, ymm3",
			"vdivps ymm2{k3}, ymm6, [rax+0x20]",
			"vdivps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vdivps zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vdivps zmm2{k3}, zmm6, [rax+0x40]",
			"vdivps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"divpd xmm1, xmm5",
			"divpd xmm1, [rax]",
			"vdivpd xmm2, xmm6, xmm3",
			"vdivpd xmm2, xmm6, [rax]",
			"vdivpd ymm2, ymm6, ymm3",
			"vdivpd ymm2, ymm6, [rax]",
			"vdivpd xmm2{k3}{z}, xmm6, xmm3",
			"vdivpd xmm2{k3}, xmm6, [rax+0x10]",
			"vdivpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vdivpd ymm2{k3}{z}, ymm6, ymm3",
			"vdivpd ymm2{k3}, ymm6, [rax+0x20]",
			"vdivpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vdivpd zmm2{k3}{z}{ru-sae}, zmm6, zmm3",
			"vdivpd zmm2{k3}, zmm6, [rax+0x40]",
			"vdivpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"divss xmm1, xmm5",
			"divss xmm1, dword ptr [rax]",
			"vdivss xmm2, xmm6, xmm3",
			"vdivss xmm2, xmm6, [rax]",
			"vdivss xmm2{k3}, xmm6, xmm3",
			"vdivss xmm2{k3}, xmm6, dword ptr [rax+4]",
			"divsd xmm1, xmm5",
			"divsd xmm1, qword ptr [rax]",
			"vdivsd xmm2, xmm6, xmm3",
			"vdivsd xmm2, xmm6, [rax]",
			"vdivsd xmm2{k3}{z}, xmm6, xmm3",
			"vdivsd xmm2{k3}, xmm6, qword ptr [rax+8]",
			"maxps xmm1, xmm5",
			"maxps xmm1, [rax]",
			"vmaxps xmm2, xmm6, xmm3",
			"vmaxps xmm2, xmm6, [rax]",
			"vmaxps ymm2, ymm6, ymm3",
			"vmaxps ymm2, ymm6, [rax]",
			"vmaxps xmm2{k3}, xmm6, xmm3",
			"vmaxps xmm2{k3}, xmm6, [rax+0x10]",
			"vmaxps xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vmaxps ymm2{k3}, ymm6, ymm3",
			"vmaxps ymm2{k3}, ymm6, [rax+0x20]",
			"vmaxps ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vmaxps zmm2{k3}{z}{sae}, zmm6, zmm3",
			"vmaxps zmm2{k3}, zmm6, [rax+0x40]",
			"vmaxps zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"maxpd xmm1, xmm5",
			"maxpd xmm1, [rax]",
			"vmaxpd xmm2, xmm6, xmm3",
			"vmaxpd xmm2, xmm6, [rax]",
			"vmaxpd ymm2, ymm6, ymm3",
			"vmaxpd ymm2, ymm6, [rax]",
			"vmaxpd xmm2{k3}{z}, xmm6, xmm3",
			"vmaxpd xmm2{k3}, xmm6, [rax+0x10]",
			"vmaxpd xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vmaxpd ymm2{k3}{z}, ymm6, ymm3",
			"vmaxpd ymm2{k3}, ymm6, [rax+0x20]",
			"vmaxpd ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vmaxpd zmm2{k3}{z}{sae}, zmm6, zmm3",
			"vmaxpd zmm2{k3}, zmm6, [rax+0x40]",
			"vmaxpd zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"maxss xmm1, xmm5",
			"maxss xmm1, dword ptr [rax]",
			"vmaxss xmm2, xmm6, xmm3",
			"vmaxss xmm2, xmm6, dword ptr [rax]",
			"vmaxss xmm2{k3}, xmm6, xmm3",
			"vmaxss xmm2{k3}, xmm6, dword ptr [rax+4]",
			"maxsd xmm1, xmm5",
			"maxsd xmm1, qword ptr [rax]",
			"vmaxsd xmm2, xmm6, xmm3",
			"vmaxsd xmm2, xmm6, qword ptr [rax]",
			"vmaxsd xmm2{k3}{z}, xmm6, xmm3",
			"vmaxsd xmm2{k3}, xmm6, qword ptr [rax+8]",
			"punpcklbw mmx1, mmx5",
			"punpcklbw mmx1, [rax]",
			"punpcklbw xmm1, xmm5",
			"punpcklbw xmm1, [rax]",
			"vpunpcklbw xmm2, xmm6, xmm3",
			"vpunpcklbw xmm2, xmm6, [rax]",
			"vpunpcklbw ymm2, ymm6, ymm3",
			"vpunpcklbw ymm2, ymm6, [rax]",
			"vpunpcklbw xmm2{k3}, xmm6, xmm3",
			"vpunpcklbw xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpcklbw ymm2{k3}, ymm6, ymm3",
			"vpunpcklbw ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpcklbw zmm2{k3}, zmm6, zmm3",
			"vpunpcklbw zmm2{k3}, zmm6, [rax+0x40]",
			"punpcklwd mmx1, mmx5",
			"punpcklwd mmx1, [rax]",
			"punpcklwd xmm1, xmm5",
			"punpcklwd xmm1, [rax]",
			"vpunpcklwd xmm2, xmm6, xmm3",
			"vpunpcklwd xmm2, xmm6, [rax]",
			"vpunpcklwd ymm2, ymm6, ymm3",
			"vpunpcklwd ymm2, ymm6, [rax]",
			"vpunpcklwd xmm2{k3}, xmm6, xmm3",
			"vpunpcklwd xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpcklwd ymm2{k3}, ymm6, ymm3",
			"vpunpcklwd ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpcklwd zmm2{k3}, zmm6, zmm3",
			"vpunpcklwd zmm2{k3}, zmm6, [rax+0x40]",
			"punpckldq mmx1, mmx5",
			"punpckldq mmx1, [rax]",
			"punpckldq xmm1, xmm5",
			"punpckldq xmm1, [rax]",
			"vpunpckldq xmm2, xmm6, xmm3",
			"vpunpckldq xmm2, xmm6, [rax]",
			"vpunpckldq ymm2, ymm6, ymm3",
			"vpunpckldq ymm2, ymm6, [rax]",
			"vpunpckldq xmm2{k3}{z}, xmm6, xmm3",
			"vpunpckldq xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpckldq xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vpunpckldq ymm2{k3}{z}, ymm6, ymm3",
			"vpunpckldq ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpckldq ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vpunpckldq zmm2{k3}{z}, zmm6, zmm3",
			"vpunpckldq zmm2{k3}, zmm6, [rax+0x40]",
			"vpunpckldq zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"packsswb mmx1, mmx5",
			"packsswb mmx1, [rax]",
			"packsswb xmm1, xmm5",
			"packsswb xmm1, [rax]",
			"vpacksswb xmm2, xmm6, xmm3",
			"vpacksswb xmm2, xmm6, [rax]",
			"vpacksswb ymm2, ymm6, ymm3",
			"vpacksswb ymm2, ymm6, [rax]",
			"vpacksswb xmm2{k3}, xmm6, xmm3",
			"vpacksswb xmm2{k3}, xmm6, [rax+0x10]",
			"vpacksswb ymm2{k3}, ymm6, ymm3",
			"vpacksswb ymm2{k3}, ymm6, [rax+0x20]",
			"vpacksswb zmm2{k3}, zmm6, zmm3",
			"vpacksswb zmm2{k3}, zmm6, [rax+0x40]",
			"pcmpgtb mmx1, mmx5",
			"pcmpgtb mmx1, [rax]",
			"pcmpgtb xmm1, xmm5",
			"pcmpgtb xmm1, [rax]",
			"vpcmpgtb xmm2, xmm6, xmm3",
			"vpcmpgtb xmm2, xmm6, [rax]",
			"vpcmpgtb ymm2, ymm6, ymm3",
			"vpcmpgtb ymm2, ymm6, [rax]",
			"vpcmpgtb k2{k3}, xmm6, xmm3",
			"vpcmpgtb k2{k3}, xmm6, [rax+0x10]",
			"vpcmpgtb k2{k3}, ymm6, ymm3",
			"vpcmpgtb k2{k3}, ymm6, [rax+0x20]",
			"vpcmpgtb k2{k3}, zmm6, zmm3",
			"vpcmpgtb k2{k3}, zmm6, [rax+0x40]",
			"pcmpgtw mmx1, mmx5",
			"pcmpgtw mmx1, [rax]",
			"pcmpgtw xmm1, xmm5",
			"pcmpgtw xmm1, [rax]",
			"vpcmpgtw xmm2, xmm6, xmm3",
			"vpcmpgtw xmm2, xmm6, [rax]",
			"vpcmpgtw ymm2, ymm6, ymm3",
			"vpcmpgtw ymm2, ymm6, [rax]",
			"vpcmpgtw k2{k3}, xmm6, xmm3",
			"vpcmpgtw k2{k3}, xmm6, [rax+0x10]",
			"vpcmpgtw k2{k3}, ymm6, ymm3",
			"vpcmpgtw k2{k3}, ymm6, [rax+0x20]",
			"vpcmpgtw k2{k3}, zmm6, zmm3",
			"vpcmpgtw k2{k3}, zmm6, [rax+0x40]",
			"pcmpgtd mmx1, mmx5",
			"pcmpgtd mmx1, [rax]",
			"pcmpgtd xmm1, xmm5",
			"pcmpgtd xmm1, [rax]",
			"vpcmpgtd xmm2, xmm6, xmm3",
			"vpcmpgtd xmm2, xmm6, [rax]",
			"vpcmpgtd ymm2, ymm6, ymm3",
			"vpcmpgtd ymm2, ymm6, [rax]",
			"vpcmpgtd k2{k3}, xmm6, xmm3",
			"vpcmpgtd k2{k3}, xmm6, [rax+0x10]",
			"vpcmpgtd k2{k5}, xmm6, dword ptr [rax+4]{1to4}",
			"vpcmpgtd k2{k3}, ymm6, ymm3",
			"vpcmpgtd k2{k3}, ymm6, [rax+0x20]",
			"vpcmpgtd k2{k5}, ymm6, dword ptr [rax+4]{1to8}",
			"vpcmpgtd k2{k3}, zmm6, zmm3",
			"vpcmpgtd k2{k3}, zmm6, [rax+0x40]",
			"vpcmpgtd k2{k5}, zmm6, dword ptr [rax+4]{1to16}",
			"packuswb mmx1, mmx5",
			"packuswb mmx1, [rax]",
			"packuswb xmm1, xmm5",
			"packuswb xmm1, [rax]",
			"vpackuswb xmm2, xmm6, xmm3",
			"vpackuswb xmm2, xmm6, [rax]",
			"vpackuswb ymm2, ymm6, ymm3",
			"vpackuswb ymm2, ymm6, [rax]",
			"vpackuswb xmm2{k3}, xmm6, xmm3",
			"vpackuswb xmm2{k3}, xmm6, [rax+0x10]",
			"vpackuswb ymm2{k3}, ymm6, ymm3",
			"vpackuswb ymm2{k3}, ymm6, [rax+0x20]",
			"vpackuswb zmm2{k3}, zmm6, zmm3",
			"vpackuswb zmm2{k3}, zmm6, [rax+0x40]",
			"punpckhbw mmx1, mmx5",
			"punpckhbw mmx1, [rax]",
			"punpckhbw xmm1, xmm5",
			"punpckhbw xmm1, [rax]",
			"vpunpckhbw xmm2, xmm6, xmm3",
			"vpunpckhbw xmm2, xmm6, [rax]",
			"vpunpckhbw ymm2, ymm6, ymm3",
			"vpunpckhbw ymm2, ymm6, [rax]",
			"vpunpckhbw xmm2{k3}, xmm6, xmm3",
			"vpunpckhbw xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpckhbw ymm2{k3}, ymm6, ymm3",
			"vpunpckhbw ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpckhbw zmm2{k3}, zmm6, zmm3",
			"vpunpckhbw zmm2{k3}, zmm6, [rax+0x40]",
			"punpckhwd mmx1, mmx5",
			"punpckhwd mmx1, [rax]",
			"punpckhwd xmm1, xmm5",
			"punpckhwd xmm1, [rax]",
			"vpunpckhwd xmm2, xmm6, xmm3",
			"vpunpckhwd xmm2, xmm6, [rax]",
			"vpunpckhwd ymm2, ymm6, ymm3",
			"vpunpckhwd ymm2, ymm6, [rax]",
			"vpunpckhwd xmm2{k3}, xmm6, xmm3",
			"vpunpckhwd xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpckhwd ymm2{k3}, ymm6, ymm3",
			"vpunpckhwd ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpckhwd zmm2{k3}, zmm6, zmm3",
			"vpunpckhwd zmm2{k3}, zmm6, [rax+0x40]",
			"punpckhdq mmx1, mmx5",
			"punpckhdq mmx1, [rax]",
			"punpckhdq xmm1, xmm5",
			"punpckhdq xmm1, [rax]",
			"vpunpckhdq xmm2, xmm6, xmm3",
			"vpunpckhdq xmm2, xmm6, [rax]",
			"vpunpckhdq ymm2, ymm6, ymm3",
			"vpunpckhdq ymm2, ymm6, [rax]",
			"vpunpckhdq xmm2{k3}{z}, xmm6, xmm3",
			"vpunpckhdq xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpckhdq xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vpunpckhdq ymm2{k3}{z}, ymm6, ymm3",
			"vpunpckhdq ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpckhdq ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vpunpckhdq zmm2{k3}{z}, zmm6, zmm3",
			"vpunpckhdq zmm2{k3}, zmm6, [rax+0x40]",
			"vpunpckhdq zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"packssdw mmx1, mmx5",
			"packssdw mmx1, [rax]",
			"packssdw xmm1, xmm5",
			"packssdw xmm1, [rax]",
			"vpackssdw xmm2, xmm6, xmm3",
			"vpackssdw xmm2, xmm6, [rax]",
			"vpackssdw ymm2, ymm6, ymm3",
			"vpackssdw ymm2, ymm6, [rax]",
			"vpackssdw xmm2{k3}{z}, xmm6, xmm3",
			"vpackssdw xmm2{k3}, xmm6, [rax+0x10]",
			"vpackssdw xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vpackssdw ymm2{k3}{z}, ymm6, ymm3",
			"vpackssdw ymm2{k3}, ymm6, [rax+0x20]",
			"vpackssdw ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vpackssdw zmm2{k3}{z}, zmm6, zmm3",
			"vpackssdw zmm2{k3}, zmm6, [rax+0x40]",
			"vpackssdw zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"punpcklqdq xmm1, xmm5",
			"punpcklqdq xmm1, [rax]",
			"vpunpcklqdq xmm2, xmm6, xmm3",
			"vpunpcklqdq xmm2, xmm6, [rax]",
			"vpunpcklqdq ymm2, ymm6, ymm3",
			"vpunpcklqdq ymm2, ymm6, [rax]",
			"vpunpcklqdq xmm2{k3}{z}, xmm6, xmm3",
			"vpunpcklqdq xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpcklqdq xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vpunpcklqdq ymm2{k3}{z}, ymm6, ymm3",
			"vpunpcklqdq ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpcklqdq ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vpunpcklqdq zmm2{k3}{z}, zmm6, zmm3",
			"vpunpcklqdq zmm2{k3}, zmm6, [rax+0x40]",
			"vpunpcklqdq zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"punpckhqdq xmm1, xmm5",
			"punpckhqdq xmm1, [rax]",
			"vpunpckhqdq xmm2, xmm6, xmm3",
			"vpunpckhqdq xmm2, xmm6, [rax]",
			"vpunpckhqdq ymm2, ymm6, ymm3",
			"vpunpckhqdq ymm2, ymm6, [rax]",
			"vpunpckhqdq xmm2{k3}{z}, xmm6, xmm3",
			"vpunpckhqdq xmm2{k3}, xmm6, [rax+0x10]",
			"vpunpckhqdq xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vpunpckhqdq ymm2{k3}{z}, ymm6, ymm3",
			"vpunpckhqdq ymm2{k3}, ymm6, [rax+0x20]",
			"vpunpckhqdq ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vpunpckhqdq zmm2{k3}{z}, zmm6, zmm3",
			"vpunpckhqdq zmm2{k3}, zmm6, [rax+0x40]",
			"vpunpckhqdq zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"movd mmx1, ebp",
			"movd mmx1, dword ptr [rax]",
			"movq mmx1, rbp",
			"movq mmx1, [rax]",
			"movd xmm1, ebp",
			"movd xmm1, dword ptr [rax]",
			"movq xmm1, rbp",
			"movq xmm1, qword ptr [rax]",
			"vmovd xmm1, ebp",
			"vmovd xmm1, dword ptr [rax]",
			"vmovq xmm1, rbp",
			"vmovq xmm1, qword ptr [rax]",
			"vmovd xmm2, ebx",
			"vmovd xmm2, dword ptr [rax+4]",
			"vmovq xmm2, rbx",
			"vmovq xmm2, qword ptr [rax+8]",
			"movq mmx1, mmx5",
			"movq mmx1, [rax]",
			"movdqa xmm1, xmm5",
			"movdqa xmm1, [rax]",
			"vmovdqa xmm1, xmm5",
			"vmovdqa xmm2, xmmword ptr [rax]",
			"vmovdqa ymm1, ymm5",
			"vmovdqa ymm2, ymmword ptr [rax]",
			"vmovdqa32 xmm2, xmm3",
			"vmovdqa32 xmm2, [rax+0x10]",
			"vmovdqa32 ymm2, ymm3",
			"vmovdqa32 ymm2, [rax+0x20]",
			"vmovdqa32 zmm2, zmm3",
			"vmovdqa32 zmm2, [rax+0x40]",
			"vmovdqa64 xmm2, xmm3",
			"vmovdqa64 xmm2, [rax+0x10]",
			"vmovdqa64 ymm2, ymm3",
			"vmovdqa64 ymm2, [rax+0x20]",
			"vmovdqa64 zmm2, zmm3",
			"vmovdqa64 zmm2, [rax+0x40]",
			"movdqu xmm1, xmm5",
			"movdqu xmm1, [rax]",
			"vmovdqu xmm1, xmm5",
			"vmovdqu xmm2, xmmword ptr [rax]",
			"vmovdqu ymm1, ymm5",
			"vmovdqu ymm2, ymmword ptr [rax]",
			"vmovdqu32 xmm2, xmm3",
			"vmovdqu32 xmm2, [rax+0x10]",
			"vmovdqu32 ymm2, ymm3",
			"vmovdqu32 ymm2, [rax+0x20]",
			"vmovdqu32 zmm2, zmm3",
			"vmovdqu32 zmm2, [rax+0x40]",
			"vmovdqu64 xmm2, xmm3",
			"vmovdqu64 xmm2, [rax+0x10]",
			"vmovdqu64 ymm2, ymm3",
			"vmovdqu64 ymm2, [rax+0x20]",
			"vmovdqu64 zmm2, zmm3",
			"vmovdqu64 zmm2, [rax+0x40]",
			"vmovdqu8 xmm2, xmm3",
			"vmovdqu8 xmm2, [rax+0x10]",
			"vmovdqu8 ymm2, ymm3",
			"vmovdqu8 ymm2, [rax+0x20]",
			"vmovdqu8 zmm2, zmm3",
			"vmovdqu8 zmm2, [rax+0x40]",
			"vmovdqu16 xmm2, xmm3",
			"vmovdqu16 xmm2, [rax+0x10]",
			"vmovdqu16 ymm2, ymm3",
			"vmovdqu16 ymm2, [rax+0x20]",
			"vmovdqu16 zmm2, zmm3",
			"vmovdqu16 zmm2, [rax+0x40]",
			"pshufw mmx1, mmx5, 0xa5",
			"pshufw mmx1, [rax], 0xa5",
			"pshufd xmm1, xmm5, 0xa5",
			"pshufd xmm1, [rax], 0xa5",
			"vpshufd xmm2, xmm3, 0xa5",
			"vpshufd xmm2, [rax], 0xa5",
			"vpshufd ymm2, ymm3, 0xa5",
			"vpshufd ymm2, [rax], 0xa5",
			"vpshufd xmm2{k3}{z}, xmm3, 0xa5",
			"vpshufd xmm2{k3}{z}, [rax+0x10], 0xa5",
			"vpshufd xmm2{k5}, dword ptr [rax+4]{1to4}, 0xa5",
			"vpshufd ymm2{k3}{z}, ymm3, 0xa5",
			"vpshufd ymm2{k3}{z}, [rax+0x20], 0xa5",
			"vpshufd ymm2{k5}, dword ptr [rax+4]{1to8}, 0xa5",
			"vpshufd zmm2{k3}{z}, zmm3, 0xa5",
			"vpshufd zmm2{k3}{z}, [rax+0x40], 0xa5",
			"vpshufd zmm2{k5}, dword ptr [rax+4]{1to16}, 0xa5",
			"pshufhw xmm1, xmm5, 0xa5",
			"pshufhw xmm1, [rax], 0xa5",
			"vpshufhw xmm2, xmm3, 0xa5",
			"vpshufhw xmm2, [rax], 0xa5",
			"vpshufhw ymm2, ymm3, 0xa5",
			"vpshufhw ymm2, [rax], 0xa5",
			"vpshufhw xmm2{k3}{z}, xmm3, 0xa5",
			"vpshufhw xmm2{k3}{z}, [rax+0x10], 0xa5",
			"vpshufhw ymm2{k3}{z}, ymm3, 0xa5",
			"vpshufhw ymm2{k3}{z}, [rax+0x20], 0xa5",
			"vpshufhw zmm2{k3}{z}, zmm3, 0xa5",
			"vpshufhw zmm2{k3}{z}, [rax+0x40], 0xa5",
			"pshuflw xmm1, xmm5, 0xa5",
			"pshuflw xmm1, [rax], 0xa5",
			"vpshuflw xmm2, xmm3, 0xa5",
			"vpshuflw xmm2, [rax], 0xa5",
			"vpshuflw ymm2, ymm3, 0xa5",
			"vpshuflw ymm2, [rax], 0xa5",
			"vpshuflw xmm2{k3}{z}, xmm3, 0xa5",
			"vpshuflw xmm2{k3}{z}, [rax+0x10], 0xa5",
			"vpshuflw ymm2{k3}{z}, ymm3, 0xa5",
			"vpshuflw ymm2{k3}{z}, [rax+0x20], 0xa5",
			"vpshuflw zmm2{k3}{z}, zmm3, 0xa5",
			"vpshuflw zmm2{k3}{z}, [rax+0x40], 0xa5",
			"psrlw mmx5, 0xa5",
			"psrlw xmm5, 0xa5",
			"vpsrlw xmm6, xmm5, 0xa5",
			"vpsrlw ymm6, ymm5, 0xa5",
			"vpsrlw xmm6{k3}, xmm5, 0xa5",
			"vpsrlw xmm6{k3}, [rax+0x10], 0xa5",
			"vpsrlw ymm6{k3}, ymm5, 0xa5",
			"vpsrlw ymm6{k3}, [rax+0x20], 0xa5",
			"vpsrlw zmm6{k3}, zmm5, 0xa5",
			"vpsrlw zmm6{k3}, [rax+0x40], 0xa5",
			"psraw mmx5, 0xa5",
			"psraw xmm5, 0xa5",
			"vpsraw xmm6, xmm5, 0xa5",
			"vpsraw ymm6, ymm5, 0xa5",
			"vpsraw xmm6{k3}, xmm5, 0xa5",
			"vpsraw xmm6{k3}, [rax+0x10], 0xa5",
			"vpsraw ymm6{k3}, ymm5, 0xa5",
			"vpsraw ymm6{k3}, [rax+0x20], 0xa5",
			"vpsraw zmm6{k3}, zmm5, 0xa5",
			"vpsraw zmm6{k3}, [rax+0x40], 0xa5",
			"psllw mmx5, 0xa5",
			"psllw xmm5, 0xa5",
			"vpsllw xmm6, xmm5, 0xa5",
			"vpsllw ymm6, ymm5, 0xa5",
			"vpsllw xmm6{k3}, xmm5, 0xa5",
			"vpsllw xmm6{k3}, [rax+0x10], 0xa5",
			"vpsllw ymm6{k3}, ymm5, 0xa5",
			"vpsllw ymm6{k3}, [rax+0x20], 0xa5",
			"vpsllw zmm6{k3}, zmm5, 0xa5",
			"vpsllw zmm6{k3}, [rax+0x40], 0xa5",
			"vprord xmm6{k3}, xmm5, 0xa5",
			"vprord xmm6{k3}, [rax+0x10], 0xa5",
			"vprord xmm6{k5}{z}, dword ptr [rax+4]{1to4}, 0xa5",
			"vprord ymm6{k3}, ymm5, 0xa5",
			"vprord ymm6{k3}, [rax+0x20], 0xa5",
			"vprord ymm6{k5}{z}, dword ptr [rax+4]{1to8}, 0xa5",
			"vprord zmm6{k3}, zmm5, 0xa5",
			"vprord zmm6{k3}, [rax+0x40], 0xa5",
			"vprord zmm6{k5}{z}, dword ptr [rax+4]{1to16}, 0xa5",
			"vprorq xmm6{k3}, xmm5, 0xa5",
			"vprorq xmm6{k3}, [rax+0x10], 0xa5",
			"vprorq xmm6{k5}{z}, qword ptr [rax+8]{1to2}, 0xa5",
			"vprorq ymm6{k3}, ymm5, 0xa5",
			"vprorq ymm6{k3}, [rax+0x20], 0xa5",
			"vprorq ymm6{k5}{z}, qword ptr [rax+8]{1to4}, 0xa5",
			"vprorq zmm6{k3}, zmm5, 0xa5",
			"vprorq zmm6{k3}, [rax+0x40], 0xa5",
			"vprorq zmm6{k5}{z}, qword ptr [rax+8]{1to8}, 0xa5",
			"vprold xmm6{k3}, xmm5, 0xa5",
			"vprold xmm6{k3}, [rax+0x10], 0xa5",
			"vprold xmm6{k5}{z}, dword ptr [rax+4]{1to4}, 0xa5",
			"vprold ymm6{k3}, ymm5, 0xa5",
			"vprold ymm6{k3}, [rax+0x20], 0xa5",
			"vprold ymm6{k5}{z}, dword ptr [rax+4]{1to8}, 0xa5",
			"vprold zmm6{k3}, zmm5, 0xa5",
			"vprold zmm6{k3}, [rax+0x40], 0xa5",
			"vprold zmm6{k5}{z}, dword ptr [rax+4]{1to16}, 0xa5",
			"vprolq xmm6{k3}, xmm5, 0xa5",
			"vprolq xmm6{k3}, [rax+0x10], 0xa5",
			"vprolq xmm6{k5}{z}, qword ptr [rax+8]{1to2}, 0xa5",
			"vprolq ymm6{k3}, ymm5, 0xa5",
			"vprolq ymm6{k3}, [rax+0x20], 0xa5",
			"vprolq ymm6{k5}{z}, qword ptr [rax+8]{1to4}, 0xa5",
			"vprolq zmm6{k3}, zmm5, 0xa5",
			"vprolq zmm6{k3}, [rax+0x40], 0xa5",
			"vprolq zmm6{k5}{z}, qword ptr [rax+8]{1to8}, 0xa5",
			"psrld mmx5, 0xa5",
			"psrld xmm5, 0xa5",
			"vpsrld xmm6, xmm5, 0xa5",
			"vpsrld ymm6, ymm5, 0xa5",
			"vpsrld xmm6{k3}, xmm5, 0xa5",
			"vpsrld xmm6{k3}, [rax+0x10], 0xa5",
			"vpsrld xmm6{k5}{z}, dword ptr [rax+4]{1to4}, 0xa5",
			"vpsrld ymm6{k3}, ymm5, 0xa5",
			"vpsrld ymm6{k3}, [rax+0x20], 0xa5",
			"vpsrld ymm6{k5}{z}, dword ptr [rax+4]{1to8}, 0xa5",
			"vpsrld zmm6{k3}, zmm5, 0xa5",
			"vpsrld zmm6{k3}, [rax+0x40], 0xa5",
			"vpsrld zmm6{k5}{z}, dword ptr [rax+4]{1to16}, 0xa5",
			"psrad mmx5, 0xa5",
			"psrad xmm5, 0xa5",
			"vpsrad xmm6, xmm5, 0xa5",
			"vpsrad ymm6, ymm5, 0xa5",
			"vpsrad xmm6{k3}, xmm5, 0xa5",
			"vpsrad xmm6{k3}, [rax+0x10], 0xa5",
			"vpsrad xmm6{k5}{z}, dword ptr [rax+4]{1to4}, 0xa5",
			"vpsrad ymm6{k3}, ymm5, 0xa5",
			"vpsrad ymm6{k3}, [rax+0x20], 0xa5",
			"vpsrad ymm6{k5}{z}, dword ptr [rax+4]{1to8}, 0xa5",
			"vpsrad zmm6{k3}, zmm5, 0xa5",
			"vpsrad zmm6{k3}, [rax+0x40], 0xa5",
			"vpsrad zmm6{k5}{z}, dword ptr [rax+4]{1to16}, 0xa5",
			"vpsraq xmm6{k3}, xmm5, 0xa5",
			"vpsraq xmm6{k3}, [rax+0x10], 0xa5",
			"vpsraq xmm6{k5}{z}, qword ptr [rax+8]{1to2}, 0xa5",
			"vpsraq ymm6{k3}, ymm5, 0xa5",
			"vpsraq ymm6{k3}, [rax+0x20], 0xa5",
			"vpsraq ymm6{k5}{z}, qword ptr [rax+8]{1to4}, 0xa5",
			"vpsraq zmm6{k3}, zmm5, 0xa5",
			"vpsraq zmm6{k3}, [rax+0x40], 0xa5",
			"vpsraq zmm6{k5}{z}, qword ptr [rax+8]{1to8}, 0xa5",
			"pslld mmx5, 0xa5",
			"pslld xmm5, 0xa5",
			"vpslld xmm6, xmm5, 0xa5",
			"vpslld ymm6, ymm5, 0xa5",
			"vpslld xmm6{k3}, xmm5, 0xa5",
			"vpslld xmm6{k3}, [rax+0x10], 0xa5",
			"vpslld xmm6{k5}{z}, dword ptr [rax+4]{1to4}, 0xa5",
			"vpslld ymm6{k3}, ymm5, 0xa5",
			"vpslld ymm6{k3}, [rax+0x20], 0xa5",
			"vpslld ymm6{k5}{z}, dword ptr [rax+4]{1to8}, 0xa5",
			"vpslld zmm6{k3}, zmm5, 0xa5",
			"vpslld zmm6{k3}, [rax+0x40], 0xa5",
			"vpslld zmm6{k5}{z}, dword ptr [rax+4]{1to16}, 0xa5",
			"psrlq mmx5, 0xa5",
			"psrlq xmm5, 0xa5",
			"vpsrlq xmm6, xmm5, 0xa5",
			"vpsrlq ymm6, ymm5, 0xa5",
			"vpsrlq xmm6{k3}, xmm5, 0xa5",
			"vpsrlq xmm6{k3}, [rax+0x10], 0xa5",
			"vpsrlq xmm6{k5}{z}, qword ptr [rax+8]{1to2}, 0xa5",
			"vpsrlq ymm6{k3}, ymm5, 0xa5",
			"vpsrlq ymm6{k3}, [rax+0x20], 0xa5",
			"vpsrlq ymm6{k5}{z}, qword ptr [rax+8]{1to4}, 0xa5",
			"vpsrlq zmm6{k3}, zmm5, 0xa5",
			"vpsrlq zmm6{k3}, [rax+0x40], 0xa5",
			"vpsrlq zmm6{k5}{z}, qword ptr [rax+8]{1to8}, 0xa5",
			"psrldq xmm5, 0xa5",
			"vpsrldq xmm6, xmm5, 0xa5",
			"vpsrldq ymm6, ymm5, 0xa5",
			"vpsrldq xmm6, xmm5, 0xa5",
			"vpsrldq xmm6, [rax+0x10], 0xa5",
			"vpsrldq ymm6, ymm5, 0xa5",
			"vpsrldq ymm6, [rax+0x20], 0xa5",
			"vpsrldq zmm6, zmm5, 0xa5",
			"vpsrldq zmm6, [rax+0x40], 0xa5",
			"psllq mmx5, 0xa5",
			"psllq xmm5, 0xa5",
			"vpsllq xmm6, xmm5, 0xa5",
			"vpsllq ymm6, ymm5, 0xa5",
			"vpsllq xmm6{k3}, xmm5, 0xa5",
			"vpsllq xmm6{k3}, [rax+0x10], 0xa5",
			"vpsllq xmm6{k5}{z}, qword ptr [rax+8]{1to2}, 0xa5",
			"vpsllq ymm6{k3}, ymm5, 0xa5",
			"vpsllq ymm6{k3}, [rax+0x20], 0xa5",
			"vpsllq ymm6{k5}{z}, qword ptr [rax+8]{1to4}, 0xa5",
			"vpsllq zmm6{k3}, zmm5, 0xa5",
			"vpsllq zmm6{k3}, [rax+0x40], 0xa5",
			"vpsllq zmm6{k5}{z}, qword ptr [rax+8]{1to8}, 0xa5",
			"pslldq xmm5, 0xa5",
			"vpslldq xmm6, xmm5, 0xa5",
			"vpslldq ymm6, ymm5, 0xa5",
			"vpslldq xmm6, xmm5, 0xa5",
			"vpslldq xmm6, [rax+0x10], 0xa5",
			"vpslldq ymm6, ymm5, 0xa5",
			"vpslldq ymm6, [rax+0x20], 0xa5",
			"vpslldq zmm6, zmm5, 0xa5",
			"vpslldq zmm6, [rax+0x40], 0xa5",
			"pcmpeqb mmx1, mmx5",
			"pcmpeqb mmx1, [rax]",
			"pcmpeqb xmm1, xmm5",
			"pcmpeqb xmm1, [rax]",
			"vpcmpeqb xmm2, xmm6, xmm3",
			"vpcmpeqb xmm2, xmm6, [rax]",
			"vpcmpeqb ymm2, ymm6, ymm3",
			"vpcmpeqb ymm2, ymm6, [rax]",
			"vpcmpeqb k2{k3}, xmm6, xmm3",
			"vpcmpeqb k2{k3}, xmm6, [rax+0x10]",
			"vpcmpeqb k2{k3}, ymm6, ymm3",
			"vpcmpeqb k2{k3}, ymm6, [rax+0x20]",
			"vpcmpeqb k2{k3}, zmm6, zmm3",
			"vpcmpeqb k2{k3}, zmm6, [rax+0x40]",
			"pcmpeqw mmx1, mmx5",
			"pcmpeqw mmx1, [rax]",
			"pcmpeqw xmm1, xmm5",
			"pcmpeqw xmm1, [rax]",
			"vpcmpeqw xmm2, xmm6, xmm3",
			"vpcmpeqw xmm2, xmm6, [rax]",
			"vpcmpeqw ymm2, ymm6, ymm3",
			"vpcmpeqw ymm2, ymm6, [rax]",
			"vpcmpeqw k2{k3}, xmm6, xmm3",
			"vpcmpeqw k2{k3}, xmm6, [rax+0x10]",
			"vpcmpeqw k2{k3}, ymm6, ymm3",
			"vpcmpeqw k2{k3}, ymm6, [rax+0x20]",
			"vpcmpeqw k2{k3}, zmm6, zmm3",
			"vpcmpeqw k2{k3}, zmm6, [rax+0x40]",
			"pcmpeqd mmx1, mmx5",
			"pcmpeqd mmx1, [rax]",
			"pcmpeqd xmm1, xmm5",
			"pcmpeqd xmm1, [rax]",
			"vpcmpeqd xmm2, xmm6, xmm3",
			"vpcmpeqd xmm2, xmm6, [rax]",
			"vpcmpeqd ymm2, ymm6, ymm3",
			"vpcmpeqd ymm2, ymm6, [rax]",
			"vpcmpeqd k2{k3}, xmm6, xmm3",
			"vpcmpeqd k2{k3}, xmm6, [rax+0x10]",
			"vpcmpeqd k2{k5}, xmm6, dword ptr [rax+4]{1to4}",
			"vpcmpeqd k2{k3}, ymm6, ymm3",
			"vpcmpeqd k2{k3}, ymm6, [rax+0x20]",
			"vpcmpeqd k2{k5}, ymm6, dword ptr [rax+4]{1to8}",
			"vpcmpeqd k2{k3}, zmm6, zmm3",
			"vpcmpeqd k2{k3}, zmm6, [rax+0x40]",
			"vpcmpeqd k2{k5}, zmm6, dword ptr [rax+4]{1to16}",
			"emms",
			"vzeroupper",
			"vzeroall",
			"vmread rsi, rcx",
			"vmread qword ptr [rax], rbx",
			"vmwrite rcx, rsi",
			"vmwrite rbx, qword ptr [rax]",
			"vcvttps2udq xmm2{k3}, xmm3",
			"vcvttps2udq xmm2, xmmword ptr [rax+0x10]",
			"vcvttps2udq xmm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvttps2udq ymm2{k3}, ymm3",
			"vcvttps2udq ymm2, ymmword ptr [rax+0x20]",
			"vcvttps2udq ymm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvttps2udq zmm2{k3}, zmm3",
			"vcvttps2udq zmm2, zmmword ptr [rax+0x40]",
			"vcvttps2udq zmm2{k3}{z}, dword ptr [rax+4]{1to16}",
			"vcvttpd2udq xmm2{k3}, xmm3",
			"vcvttpd2udq xmm2, xmmword ptr [rax+0x10]",
			"vcvttpd2udq xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvttpd2udq xmm2{k3}, ymm3",
			"vcvttpd2udq xmm2, ymmword ptr [rax+0x20]",
			"vcvttpd2udq xmm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvttpd2udq ymm2{k3}, zmm3",
			"vcvttpd2udq ymm2, zmmword ptr [rax+0x40]",
			"vcvttpd2udq ymm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvttps2uqq xmm2{k3}, xmm3",
			"vcvttps2uqq xmm2, qword ptr [rax+8]",
			"vcvttps2uqq xmm2{k3}{z}, dword ptr [rax+4]{1to2}",
			"vcvttps2uqq ymm2{k3}, xmm3",
			"vcvttps2uqq ymm2, xmmword ptr [rax+0x10]",
			"vcvttps2uqq ymm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvttps2uqq zmm2{k3}, ymm3",
			"vcvttps2uqq zmm2, ymmword ptr [rax+0x20]",
			"vcvttps2uqq zmm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvttpd2uqq xmm2{k3}, xmm3",
			"vcvttpd2uqq xmm2, [rax+0x10]",
			"vcvttpd2uqq xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvttpd2uqq ymm2{k3}, ymm3",
			"vcvttpd2uqq ymm2, [rax+0x20]",
			"vcvttpd2uqq ymm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvttpd2uqq zmm2{k3}, zmm3",
			"vcvttpd2uqq zmm2, [rax+0x40]",
			"vcvttpd2uqq zmm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvttss2usi edx, xmm3",
			"vcvttss2usi edx, dword ptr [rax+4]",
			"vcvttss2usi rdx, xmm3",
			"vcvttss2usi rdx, dword ptr [rax+4]",
			"vcvttsd2usi edx, xmm3",
			"vcvttsd2usi edx, qword ptr [rax+8]",
			"vcvttsd2usi rdx, xmm3",
			"vcvttsd2usi rdx, qword ptr [rax+8]",
			"vcvtps2udq xmm2{k3}, xmm3",
			"vcvtps2udq xmm2, xmmword ptr [rax+0x10]",
			"vcvtps2udq xmm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtps2udq ymm2{k3}, ymm3",
			"vcvtps2udq ymm2, ymmword ptr [rax+0x20]",
			"vcvtps2udq ymm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvtps2udq zmm2{k3}, zmm3",
			"vcvtps2udq zmm2, zmmword ptr [rax+0x40]",
			"vcvtps2udq zmm2{k3}{z}, dword ptr [rax+4]{1to16}",
			"vcvtpd2udq xmm2{k3}, xmm3",
			"vcvtpd2udq xmm2, xmmword ptr [rax+0x10]",
			"vcvtpd2udq xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvtpd2udq xmm2{k3}, ymm3",
			"vcvtpd2udq xmm2, ymmword ptr [rax+0x20]",
			"vcvtpd2udq xmm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvtpd2udq ymm2{k3}, zmm3",
			"vcvtpd2udq ymm2, zmmword ptr [rax+0x40]",
			"vcvtpd2udq ymm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvtps2uqq xmm2{k3}, xmm3",
			"vcvtps2uqq xmm2, qword ptr [rax+8]",
			"vcvtps2uqq xmm2{k3}{z}, dword ptr [rax+4]{1to2}",
			"vcvtps2uqq ymm2{k3}, xmm3",
			"vcvtps2uqq ymm2, xmmword ptr [rax+0x10]",
			"vcvtps2uqq ymm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtps2uqq zmm2{k3}, ymm3",
			"vcvtps2uqq zmm2, ymmword ptr [rax+0x20]",
			"vcvtps2uqq zmm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvtpd2uqq xmm2{k3}, xmm3",
			"vcvtpd2uqq xmm2, [rax+0x10]",
			"vcvtpd2uqq xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvtpd2uqq ymm2{k3}, ymm3",
			"vcvtpd2uqq ymm2, [rax+0x20]",
			"vcvtpd2uqq ymm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvtpd2uqq zmm2{k3}, zmm3",
			"vcvtpd2uqq zmm2, [rax+0x40]",
			"vcvtpd2uqq zmm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvtss2usi edx, xmm3",
			"vcvtss2usi edx, dword ptr [rax+4]",
			"vcvtss2usi rdx, xmm3",
			"vcvtss2usi rdx, dword ptr [rax+4]",
			"vcvtsd2usi edx, xmm3",
			"vcvtsd2usi edx, qword ptr [rax+8]",
			"vcvtsd2usi rdx, xmm3",
			"vcvtsd2usi rdx, qword ptr [rax+8]",
			"vcvttps2qq xmm2{k3}, xmm3",
			"vcvttps2qq xmm2, qword ptr [rax+8]",
			"vcvttps2qq xmm2{k3}{z}, dword ptr [rax+4]{1to2}",
			"vcvttps2qq ymm2{k3}, xmm3",
			"vcvttps2qq ymm2, xmmword ptr [rax+0x10]",
			"vcvttps2qq ymm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvttps2qq zmm2{k3}, ymm3",
			"vcvttps2qq zmm2, ymmword ptr [rax+0x20]",
			"vcvttps2qq zmm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvttpd2qq xmm2{k3}, xmm3",
			"vcvttpd2qq xmm2, [rax+0x10]",
			"vcvttpd2qq xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvttpd2qq ymm2{k3}, ymm3",
			"vcvttpd2qq ymm2, [rax+0x20]",
			"vcvttpd2qq ymm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvttpd2qq zmm2{k3}, zmm3",
			"vcvttpd2qq zmm2, [rax+0x40]",
			"vcvttpd2qq zmm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvtudq2pd xmm2{k3}, xmm3",
			"vcvtudq2pd xmm2, qword ptr [rax+8]",
			"vcvtudq2pd xmm2{k3}{z}, dword ptr [rax+4]{1to2}",
			"vcvtudq2pd ymm2{k3}, xmm3",
			"vcvtudq2pd ymm2, xmmword ptr [rax+0x10]",
			"vcvtudq2pd ymm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtudq2pd zmm2{k3}, ymm3",
			"vcvtudq2pd zmm2, ymmword ptr [rax+0x20]",
			"vcvtudq2pd zmm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvtuqq2pd xmm2{k3}, xmm3",
			"vcvtuqq2pd xmm2, [rax+0x10]",
			"vcvtuqq2pd xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvtuqq2pd ymm2{k3}, ymm3",
			"vcvtuqq2pd ymm2, [rax+0x20]",
			"vcvtuqq2pd ymm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvtuqq2pd zmm2{k3}, zmm3",
			"vcvtuqq2pd zmm2, [rax+0x40]",
			"vcvtuqq2pd zmm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvtudq2ps xmm2{k3}, xmm3",
			"vcvtudq2ps xmm2, xmmword ptr [rax+0x10]",
			"vcvtudq2ps xmm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtudq2ps ymm2{k3}, ymm3",
			"vcvtudq2ps ymm2, ymmword ptr [rax+0x20]",
			"vcvtudq2ps ymm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvtudq2ps zmm2{k3}, zmm3",
			"vcvtudq2ps zmm2, zmmword ptr [rax+0x40]",
			"vcvtudq2ps zmm2{k3}{z}, dword ptr [rax+4]{1to16}",
			"vcvtuqq2ps xmm2{k3}, xmm3",
			"vcvtuqq2ps xmm2, xmmword ptr [rax+0x10]",
			"vcvtuqq2ps xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvtuqq2ps xmm2{k3}, ymm3",
			"vcvtuqq2ps xmm2, ymmword ptr [rax+0x20]",
			"vcvtuqq2ps xmm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvtuqq2ps ymm2{k3}, zmm3",
			"vcvtuqq2ps ymm2, zmmword ptr [rax+0x40]",
			"vcvtuqq2ps ymm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvtps2qq xmm2{k3}, xmm3",
			"vcvtps2qq xmm2, qword ptr [rax+8]",
			"vcvtps2qq xmm2{k3}{z}, dword ptr [rax+4]{1to2}",
			"vcvtps2qq ymm2{k3}, xmm3",
			"vcvtps2qq ymm2, xmmword ptr [rax+0x10]",
			"vcvtps2qq ymm2{k3}{z}, dword ptr [rax+4]{1to4}",
			"vcvtps2qq zmm2{k3}, ymm3",
			"vcvtps2qq zmm2, ymmword ptr [rax+0x20]",
			"vcvtps2qq zmm2{k3}{z}, dword ptr [rax+4]{1to8}",
			"vcvtpd2qq xmm2{k3}, xmm3",
			"vcvtpd2qq xmm2, [rax+0x10]",
			"vcvtpd2qq xmm2{k3}{z}, qword ptr [rax+8]{1to2}",
			"vcvtpd2qq ymm2{k3}, ymm3",
			"vcvtpd2qq ymm2, [rax+0x20]",
			"vcvtpd2qq ymm2{k3}{z}, qword ptr [rax+8]{1to4}",
			"vcvtpd2qq zmm2{k3}, zmm3",
			"vcvtpd2qq zmm2, [rax+0x40]",
			"vcvtpd2qq zmm2{k3}{z}, qword ptr [rax+8]{1to8}",
			"vcvtusi2ss xmm2, xmm6, ebx",
			"vcvtusi2ss xmm2, xmm6, dword ptr [rax+4]",
			"vcvtusi2ss xmm2, xmm6, rbx",
			"vcvtusi2ss xmm2, xmm6, qword ptr [rax+8]",
			"vcvtusi2sd xmm2, xmm6, ebx",
			"vcvtusi2sd xmm2, xmm6, dword ptr [rax+4]",
			"vcvtusi2sd xmm2, xmm6, rbx",
			"vcvtusi2sd xmm2, xmm6, qword ptr [rax+8]",
			"haddpd xmm1, xmm5",
			"haddpd xmm1, [rax]",
			"vhaddpd xmm2, xmm6, xmm3",
			"vhaddpd xmm2, xmm6, [rax]",
			"vhaddpd ymm2, ymm6, ymm3",
			"vhaddpd ymm2, ymm6, [rax]",
			"haddps xmm1, xmm5",
			"haddps xmm1, [rax]",
			"vhaddps xmm2, xmm6, xmm3",
			"vhaddps xmm2, xmm6, [rax]",
			"vhaddps ymm2, ymm6, ymm3",
			"vhaddps ymm2, ymm6, [rax]",
			"hsubpd xmm1, xmm5",
			"hsubpd xmm1, [rax]",
			"vhsubpd xmm2, xmm6, xmm3",
			"vhsubpd xmm2, xmm6, [rax]",
			"vhsubpd ymm2, ymm6, ymm3",
			"vhsubpd ymm2, ymm6, [rax]",
			"hsubps xmm1, xmm5",
			"hsubps xmm1, [rax]",
			"vhsubps xmm2, xmm6, xmm3",
			"vhsubps xmm2, xmm6, [rax]",
			"vhsubps ymm2, ymm6, ymm3",
			"vhsubps ymm2, ymm6, [rax]",
			"movd ebp, mmx1",
			"movd dword ptr [rax], mmx1",
			"movq rbp, mmx1",
			"movq [rax], mmx1",
			"movd ebp, xmm1",
			"movd dword ptr [rax], xmm1",
			"movq rbp, xmm1",
			"movq qword ptr [rax], xmm1",
			"vmovd ebp, xmm1",
			"vmovd dword ptr [rax], xmm1",
			"vmovq rbp, xmm1",
			"vmovq qword ptr [rax], xmm1",
			"vmovd ebx, xmm2",
			"vmovd dword ptr [rax+4], xmm2",
			"vmovq rbx, xmm2",
			"vmovq qword ptr [rax+8], xmm2",
			"movq xmm1, xmm5",
			"movq xmm1, qword ptr [rax]",
			"vmovq xmm1, xmm5",
			"vmovq xmm2, qword ptr [rax]",
			"vmovq xmm2, xmm3",
			"vmovq xmm2, qword ptr [rax+8]",
			"movq mmx5, mmx1",
			"movq [rax], mmx1",
			"movdqa xmm5, xmm1",
			"movdqa [rax], xmm1",
			"vmovdqa xmm5, xmm1",
			"vmovdqa xmmword ptr [rax], xmm2",
			"vmovdqa ymm5, ymm1",
			"vmovdqa ymmword ptr [rax], ymm2",
			"vmovdqa32 xmm3, xmm2",
			"vmovdqa32 [rax+0x10], xmm2",
			"vmovdqa32 ymm3, ymm2",
			"vmovdqa32 [rax+0x20], ymm2",
			"vmovdqa32 zmm3, zmm2",
			"vmovdqa32 [rax+0x40], zmm2",
			"vmovdqa64 xmm3, xmm2",
			"vmovdqa64 [rax+0x10], xmm2",
			"vmovdqa64 ymm3, ymm2",
			"vmovdqa64 [rax+0x20], ymm2",
		};
	}
}
#endif
