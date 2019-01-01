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

#if !NO_GAS_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Gas {
	public sealed class GasFormatterTest64_ForceSuffix_008 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_ForceSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_008.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_008.AllInfos_Length] {
			"vpcompressb zmm10,zmm19{k3}{z}",
			"vpcompressb zmm2,1(rax)",
			"vpcompressw xmm2,xmm3",
			"vpcompressw xmm2,2(rax)",
			"vpcompressw ymm2,ymm3{k3}",
			"vpcompressw ymm2,2(rax){k3}",
			"vpcompressw zmm10,zmm19{k3}{z}",
			"vpcompressw zmm2,2(rax)",
			"vpshldvw xmm3,xmm6,xmm2{k3}",
			"vpshldvw 0x10(rax),xmm6,xmm2",
			"vpshldvw ymm3,ymm6,ymm2{k3}",
			"vpshldvw 0x20(rax),ymm6,ymm2{k3}",
			"vpshldvw zmm3,zmm14,zmm18{k3}{z}",
			"vpshldvw 0x40(rax),zmm6,zmm2{k3}{z}",
			"vpshldvd xmm3,xmm14,xmm18{k3}",
			"vpshldvd 0x10(rax),xmm6,xmm2",
			"vpshldvd 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpshldvd ymm3,ymm14,ymm18{k3}",
			"vpshldvd 0x20(rax),ymm6,ymm2{k3}",
			"vpshldvd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpshldvd zmm3,zmm6,zmm2{k3}{z}",
			"vpshldvd 0x40(rax),zmm6,zmm2",
			"vpshldvd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpshldvq xmm3,xmm14,xmm18{k3}",
			"vpshldvq 0x10(rax),xmm6,xmm2",
			"vpshldvq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpshldvq ymm3,ymm14,ymm18{k3}",
			"vpshldvq 0x20(rax),ymm6,ymm2{k3}",
			"vpshldvq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpshldvq zmm3,zmm6,zmm2{k3}{z}",
			"vpshldvq 0x40(rax),zmm6,zmm2",
			"vpshldvq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpshrdvw xmm3,xmm6,xmm2{k3}",
			"vpshrdvw 0x10(rax),xmm6,xmm2",
			"vpshrdvw ymm3,ymm6,ymm2{k3}",
			"vpshrdvw 0x20(rax),ymm6,ymm2{k3}",
			"vpshrdvw zmm3,zmm14,zmm18{k3}{z}",
			"vpshrdvw 0x40(rax),zmm6,zmm2{k3}{z}",
			"vpshrdvd xmm3,xmm14,xmm18{k3}",
			"vpshrdvd 0x10(rax),xmm6,xmm2",
			"vpshrdvd 4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpshrdvd ymm3,ymm14,ymm18{k3}",
			"vpshrdvd 0x20(rax),ymm6,ymm2{k3}",
			"vpshrdvd 4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpshrdvd zmm3,zmm6,zmm2{k3}{z}",
			"vpshrdvd 0x40(rax),zmm6,zmm2",
			"vpshrdvd 4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpshrdvq xmm3,xmm14,xmm18{k3}",
			"vpshrdvq 0x10(rax),xmm6,xmm2",
			"vpshrdvq 8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpshrdvq ymm3,ymm14,ymm18{k3}",
			"vpshrdvq 0x20(rax),ymm6,ymm2{k3}",
			"vpshrdvq 8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpshrdvq zmm3,zmm6,zmm2{k3}{z}",
			"vpshrdvq 0x40(rax),zmm6,zmm2",
			"vpshrdvq 8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpshufbitqmb xmm3,xmm6,k2{k3}",
			"vpshufbitqmb 0x10(rax),xmm6,k2",
			"vpshufbitqmb ymm3,ymm6,k2{k3}",
			"vpshufbitqmb 0x20(rax),ymm6,k2{k3}",
			"vpshufbitqmb zmm3,zmm6,k2{k3}",
			"vpshufbitqmb 0x40(rax),zmm6,k2",
			"gf2p8mulb xmm5,xmm1",
			"gf2p8mulb (rax),xmm1",
			"vgf2p8mulb xmm3,xmm6,xmm2",
			"vgf2p8mulb (rax),xmm6,xmm2",
			"vgf2p8mulb ymm3,ymm6,ymm2",
			"vgf2p8mulb (rax),ymm6,ymm2",
			"vgf2p8mulb xmm3,xmm6,xmm2{k3}",
			"vgf2p8mulb 0x10(rax),xmm6,xmm2",
			"vgf2p8mulb ymm3,ymm6,ymm2{k3}",
			"vgf2p8mulb 0x20(rax),ymm6,ymm2{k3}",
			"vgf2p8mulb zmm3,zmm14,zmm18{k3}{z}",
			"vgf2p8mulb 0x40(rax),zmm6,zmm2{k5}{z}",
			"vaesenc ymm3,ymm6,ymm2",
			"vaesenc (rax),ymm6,ymm2",
			"vaesenc xmm3,xmm6,xmm2",
			"vaesenc 0x10(rax),xmm6,xmm2",
			"vaesenc ymm3,ymm6,ymm2",
			"vaesenc 0x20(rax),ymm6,ymm2",
			"vaesenc zmm3,zmm6,zmm2",
			"vaesenc 0x40(rax),zmm6,zmm2",
			"vaesenclast ymm3,ymm6,ymm2",
			"vaesenclast (rax),ymm6,ymm2",
			"vaesenclast xmm3,xmm6,xmm2",
			"vaesenclast 0x10(rax),xmm6,xmm2",
			"vaesenclast ymm3,ymm6,ymm2",
			"vaesenclast 0x20(rax),ymm6,ymm2",
			"vaesenclast zmm3,zmm6,zmm2",
			"vaesenclast 0x40(rax),zmm6,zmm2",
			"vaesdec ymm3,ymm6,ymm2",
			"vaesdec (rax),ymm6,ymm2",
			"vaesdec xmm3,xmm6,xmm2",
			"vaesdec 0x10(rax),xmm6,xmm2",
			"vaesdec ymm3,ymm6,ymm2",
			"vaesdec 0x20(rax),ymm6,ymm2",
			"vaesdec zmm3,zmm6,zmm2",
			"vaesdec 0x40(rax),zmm6,zmm2",
			"vaesdeclast ymm3,ymm6,ymm2",
			"vaesdeclast (rax),ymm6,ymm2",
			"vaesdeclast xmm3,xmm6,xmm2",
			"vaesdeclast 0x10(rax),xmm6,xmm2",
			"vaesdeclast ymm3,ymm6,ymm2",
			"vaesdeclast 0x20(rax),ymm6,ymm2",
			"vaesdeclast zmm3,zmm6,zmm2",
			"vaesdeclast 0x40(rax),zmm6,zmm2",
			"wrussd ebx,(rax)",
			"wrussq rbx,(rax)",
			"wrssd ebx,(rax)",
			"wrssq rbx,(rax)",
			"movdir64b (eax),ebx",
			"movdir64b (rax),rbx",
			"movdiri ebx,(rax)",
			"movdiri rbx,(rax)",
			"vpclmulqdq $-0x5b,ymm3,ymm6,ymm2",
			"vpclmulqdq $-0x5b,(rax),ymm6,ymm2",
			"vpclmulqdq $-0x5b,xmm3,xmm6,xmm2",
			"vpclmulqdq $-0x5b,0x10(rax),xmm6,xmm2",
			"vpclmulqdq $-0x5b,ymm3,ymm6,ymm2",
			"vpclmulqdq $-0x5b,0x20(rax),ymm6,ymm2",
			"vpclmulqdq $-0x5b,zmm3,zmm6,zmm2",
			"vpclmulqdq $-0x5b,0x40(rax),zmm6,zmm2",
			"vpshldw $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vpshldw $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpshldw $-0x5b,ymm3,ymm14,ymm18{k3}{z}",
			"vpshldw $-0x5b,0x20(rax),ymm6,ymm2{k5}{z}",
			"vpshldw $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vpshldw $-0x5b,0x40(rax),zmm6,zmm2",
			"vpshldd $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vpshldd $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpshldd $-0x5b,4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpshldd $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vpshldd $-0x5b,0x20(rax),ymm6,ymm2",
			"vpshldd $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpshldd $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vpshldd $-0x5b,0x40(rax),zmm6,zmm2",
			"vpshldd $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpshldq $-0x5b,xmm3,xmm14,xmm18{k3}",
			"vpshldq $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpshldq $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpshldq $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vpshldq $-0x5b,0x20(rax),ymm6,ymm2",
			"vpshldq $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpshldq $-0x5b,zmm3,zmm14,zmm18{k3}",
			"vpshldq $-0x5b,0x40(rax),zmm6,zmm2",
			"vpshldq $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"vpshrdw $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vpshrdw $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpshrdw $-0x5b,ymm3,ymm14,ymm18{k3}{z}",
			"vpshrdw $-0x5b,0x20(rax),ymm6,ymm2{k5}{z}",
			"vpshrdw $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vpshrdw $-0x5b,0x40(rax),zmm6,zmm2",
			"vpshrdd $-0x5b,xmm3,xmm6,xmm2{k3}",
			"vpshrdd $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpshrdd $-0x5b,4(rax){1to4},xmm6,xmm2{k5}{z}",
			"vpshrdd $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vpshrdd $-0x5b,0x20(rax),ymm6,ymm2",
			"vpshrdd $-0x5b,4(rax){1to8},ymm6,ymm2{k5}{z}",
			"vpshrdd $-0x5b,zmm3,zmm6,zmm2{k3}",
			"vpshrdd $-0x5b,0x40(rax),zmm6,zmm2",
			"vpshrdd $-0x5b,4(rax){1to16},zmm6,zmm2{k5}{z}",
			"vpshrdq $-0x5b,xmm3,xmm14,xmm18{k3}",
			"vpshrdq $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vpshrdq $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vpshrdq $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vpshrdq $-0x5b,0x20(rax),ymm6,ymm2",
			"vpshrdq $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vpshrdq $-0x5b,zmm3,zmm14,zmm18{k3}",
			"vpshrdq $-0x5b,0x40(rax),zmm6,zmm2",
			"vpshrdq $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"gf2p8affineqb $-0x5b,xmm5,xmm1",
			"gf2p8affineqb $-0x5b,(rax),xmm1",
			"vgf2p8affineqb $-0x5b,xmm3,xmm6,xmm2",
			"vgf2p8affineqb $-0x5b,(rax),xmm6,xmm2",
			"vgf2p8affineqb $-0x5b,ymm3,ymm6,ymm2",
			"vgf2p8affineqb $-0x5b,(rax),ymm6,ymm2",
			"vgf2p8affineqb $-0x5b,xmm3,xmm14,xmm18{k3}",
			"vgf2p8affineqb $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vgf2p8affineqb $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vgf2p8affineqb $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vgf2p8affineqb $-0x5b,0x20(rax),ymm6,ymm2",
			"vgf2p8affineqb $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vgf2p8affineqb $-0x5b,zmm3,zmm14,zmm18{k3}",
			"vgf2p8affineqb $-0x5b,0x40(rax),zmm6,zmm2",
			"vgf2p8affineqb $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"gf2p8affineinvqb $-0x5b,xmm5,xmm1",
			"gf2p8affineinvqb $-0x5b,(rax),xmm1",
			"vgf2p8affineinvqb $-0x5b,xmm3,xmm6,xmm2",
			"vgf2p8affineinvqb $-0x5b,(rax),xmm6,xmm2",
			"vgf2p8affineinvqb $-0x5b,ymm3,ymm6,ymm2",
			"vgf2p8affineinvqb $-0x5b,(rax),ymm6,ymm2",
			"vgf2p8affineinvqb $-0x5b,xmm3,xmm14,xmm18{k3}",
			"vgf2p8affineinvqb $-0x5b,0x10(rax),xmm6,xmm2{k3}",
			"vgf2p8affineinvqb $-0x5b,8(rax){1to2},xmm6,xmm2{k5}{z}",
			"vgf2p8affineinvqb $-0x5b,ymm3,ymm6,ymm2{k3}{z}",
			"vgf2p8affineinvqb $-0x5b,0x20(rax),ymm6,ymm2",
			"vgf2p8affineinvqb $-0x5b,8(rax){1to4},ymm6,ymm2{k5}{z}",
			"vgf2p8affineinvqb $-0x5b,zmm3,zmm14,zmm18{k3}",
			"vgf2p8affineinvqb $-0x5b,0x40(rax),zmm6,zmm2",
			"vgf2p8affineinvqb $-0x5b,8(rax){1to8},zmm6,zmm2{k5}{z}",
			"addr32 fs monitor",
			"fs monitor",
			"addr32 fs monitorx",
			"fs monitorx",
			"addr32 fs clzero",
			"fs clzero",
			"fs umonitor ebp",
			"fs umonitor rbp",
		};
	}
}
#endif
