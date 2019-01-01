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

#if (!NO_GAS_FORMATTER || !NO_INTEL_FORMATTER || !NO_MASM_FORMATTER || !NO_NASM_FORMATTER) && !NO_FORMATTER
using Iced.Intel;

namespace Iced.UnitTests.Intel.FormatterTests {
	static class InstructionInfos64_Misc {
		public const int AllInfos_Length = 539;
		public static readonly InstructionInfo[] AllInfos = new InstructionInfo[AllInfos_Length] {
			new InstructionInfo(64, "F0 10 08", Code.Adc_rm8_r8),
			new InstructionInfo(64, "F0 80 10 A5", Code.Adc_rm8_imm8),
			new InstructionInfo(64, "F0 66 11 08", Code.Adc_rm16_r16),
			new InstructionInfo(64, "F0 66 83 10 A5", Code.Adc_rm16_imm8),
			new InstructionInfo(64, "F0 66 81 10 5AA5", Code.Adc_rm16_imm16),
			new InstructionInfo(64, "F0 11 08", Code.Adc_rm32_r32),
			new InstructionInfo(64, "F0 83 10 A5", Code.Adc_rm32_imm8),
			new InstructionInfo(64, "F0 81 10 34 12 5AA5", Code.Adc_rm32_imm32),
			new InstructionInfo(64, "F0 48 11 08", Code.Adc_rm64_r64),
			new InstructionInfo(64, "F0 48 83 10 A5", Code.Adc_rm64_imm8),
			new InstructionInfo(64, "F0 48 81 10 34 12 5AA5", Code.Adc_rm64_imm32),
			new InstructionInfo(64, "F0 00 08", Code.Add_rm8_r8),
			new InstructionInfo(64, "F0 80 00 A5", Code.Add_rm8_imm8),
			new InstructionInfo(64, "F0 66 01 08", Code.Add_rm16_r16),
			new InstructionInfo(64, "F0 66 83 00 A5", Code.Add_rm16_imm8),
			new InstructionInfo(64, "F0 66 81 00 5AA5", Code.Add_rm16_imm16),
			new InstructionInfo(64, "F0 01 08", Code.Add_rm32_r32),
			new InstructionInfo(64, "F0 83 00 A5", Code.Add_rm32_imm8),
			new InstructionInfo(64, "F0 81 00 34 12 5AA5", Code.Add_rm32_imm32),
			new InstructionInfo(64, "F0 48 01 08", Code.Add_rm64_r64),
			new InstructionInfo(64, "F0 48 83 00 A5", Code.Add_rm64_imm8),
			new InstructionInfo(64, "F0 48 81 00 34 12 5AA5", Code.Add_rm64_imm32),
			new InstructionInfo(64, "F0 20 08", Code.And_rm8_r8),
			new InstructionInfo(64, "F0 80 20 A5", Code.And_rm8_imm8),
			new InstructionInfo(64, "F0 66 21 08", Code.And_rm16_r16),
			new InstructionInfo(64, "F0 66 83 20 A5", Code.And_rm16_imm8),
			new InstructionInfo(64, "F0 66 81 20 5AA5", Code.And_rm16_imm16),
			new InstructionInfo(64, "F0 21 08", Code.And_rm32_r32),
			new InstructionInfo(64, "F0 83 20 A5", Code.And_rm32_imm8),
			new InstructionInfo(64, "F0 81 20 34 12 5AA5", Code.And_rm32_imm32),
			new InstructionInfo(64, "F0 48 21 08", Code.And_rm64_r64),
			new InstructionInfo(64, "F0 48 83 20 A5", Code.And_rm64_imm8),
			new InstructionInfo(64, "F0 48 81 20 34 12 5AA5", Code.And_rm64_imm32),
			new InstructionInfo(64, "F0 08 08", Code.Or_rm8_r8),
			new InstructionInfo(64, "F0 80 08 A5", Code.Or_rm8_imm8),
			new InstructionInfo(64, "F0 66 09 08", Code.Or_rm16_r16),
			new InstructionInfo(64, "F0 66 83 08 A5", Code.Or_rm16_imm8),
			new InstructionInfo(64, "F0 66 81 08 5AA5", Code.Or_rm16_imm16),
			new InstructionInfo(64, "F0 09 08", Code.Or_rm32_r32),
			new InstructionInfo(64, "F0 83 08 A5", Code.Or_rm32_imm8),
			new InstructionInfo(64, "F0 81 08 34 12 5AA5", Code.Or_rm32_imm32),
			new InstructionInfo(64, "F0 48 09 08", Code.Or_rm64_r64),
			new InstructionInfo(64, "F0 48 83 08 A5", Code.Or_rm64_imm8),
			new InstructionInfo(64, "F0 48 81 08 34 12 5AA5", Code.Or_rm64_imm32),
			new InstructionInfo(64, "F0 18 08", Code.Sbb_rm8_r8),
			new InstructionInfo(64, "F0 80 18 A5", Code.Sbb_rm8_imm8),
			new InstructionInfo(64, "F0 66 19 08", Code.Sbb_rm16_r16),
			new InstructionInfo(64, "F0 66 83 18 A5", Code.Sbb_rm16_imm8),
			new InstructionInfo(64, "F0 66 81 18 5AA5", Code.Sbb_rm16_imm16),
			new InstructionInfo(64, "F0 19 08", Code.Sbb_rm32_r32),
			new InstructionInfo(64, "F0 83 18 A5", Code.Sbb_rm32_imm8),
			new InstructionInfo(64, "F0 81 18 34 12 5AA5", Code.Sbb_rm32_imm32),
			new InstructionInfo(64, "F0 48 19 08", Code.Sbb_rm64_r64),
			new InstructionInfo(64, "F0 48 83 18 A5", Code.Sbb_rm64_imm8),
			new InstructionInfo(64, "F0 48 81 18 34 12 5AA5", Code.Sbb_rm64_imm32),
			new InstructionInfo(64, "F0 28 08", Code.Sub_rm8_r8),
			new InstructionInfo(64, "F0 80 28 A5", Code.Sub_rm8_imm8),
			new InstructionInfo(64, "F0 66 29 08", Code.Sub_rm16_r16),
			new InstructionInfo(64, "F0 66 83 28 A5", Code.Sub_rm16_imm8),
			new InstructionInfo(64, "F0 66 81 28 5AA5", Code.Sub_rm16_imm16),
			new InstructionInfo(64, "F0 29 08", Code.Sub_rm32_r32),
			new InstructionInfo(64, "F0 83 28 A5", Code.Sub_rm32_imm8),
			new InstructionInfo(64, "F0 81 28 34 12 5AA5", Code.Sub_rm32_imm32),
			new InstructionInfo(64, "F0 48 29 08", Code.Sub_rm64_r64),
			new InstructionInfo(64, "F0 48 83 28 A5", Code.Sub_rm64_imm8),
			new InstructionInfo(64, "F0 48 81 28 34 12 5AA5", Code.Sub_rm64_imm32),
			new InstructionInfo(64, "F0 30 08", Code.Xor_rm8_r8),
			new InstructionInfo(64, "F0 80 30 A5", Code.Xor_rm8_imm8),
			new InstructionInfo(64, "F0 66 31 08", Code.Xor_rm16_r16),
			new InstructionInfo(64, "F0 66 83 30 A5", Code.Xor_rm16_imm8),
			new InstructionInfo(64, "F0 66 81 30 5AA5", Code.Xor_rm16_imm16),
			new InstructionInfo(64, "F0 31 08", Code.Xor_rm32_r32),
			new InstructionInfo(64, "F0 83 30 A5", Code.Xor_rm32_imm8),
			new InstructionInfo(64, "F0 81 30 34 12 5AA5", Code.Xor_rm32_imm32),
			new InstructionInfo(64, "F0 48 31 08", Code.Xor_rm64_r64),
			new InstructionInfo(64, "F0 48 83 30 A5", Code.Xor_rm64_imm8),
			new InstructionInfo(64, "F0 48 81 30 34 12 5AA5", Code.Xor_rm64_imm32),
			new InstructionInfo(64, "F0 66 0F BB 08", Code.Btc_rm16_r16),
			new InstructionInfo(64, "F0 66 0F BA 38 A5", Code.Btc_rm16_imm8),
			new InstructionInfo(64, "F0 0F BB 08", Code.Btc_rm32_r32),
			new InstructionInfo(64, "F0 0F BA 38 A5", Code.Btc_rm32_imm8),
			new InstructionInfo(64, "F0 48 0F BB 08", Code.Btc_rm64_r64),
			new InstructionInfo(64, "F0 48 0F BA 38 A5", Code.Btc_rm64_imm8),
			new InstructionInfo(64, "F0 66 0F B3 08", Code.Btr_rm16_r16),
			new InstructionInfo(64, "F0 66 0F BA 30 A5", Code.Btr_rm16_imm8),
			new InstructionInfo(64, "F0 0F B3 08", Code.Btr_rm32_r32),
			new InstructionInfo(64, "F0 0F BA 30 A5", Code.Btr_rm32_imm8),
			new InstructionInfo(64, "F0 48 0F B3 08", Code.Btr_rm64_r64),
			new InstructionInfo(64, "F0 48 0F BA 30 A5", Code.Btr_rm64_imm8),
			new InstructionInfo(64, "F0 66 0F AB 08", Code.Bts_rm16_r16),
			new InstructionInfo(64, "F0 66 0F BA 28 A5", Code.Bts_rm16_imm8),
			new InstructionInfo(64, "F0 0F AB 08", Code.Bts_rm32_r32),
			new InstructionInfo(64, "F0 0F BA 28 A5", Code.Bts_rm32_imm8),
			new InstructionInfo(64, "F0 48 0F AB 08", Code.Bts_rm64_r64),
			new InstructionInfo(64, "F0 48 0F BA 28 A5", Code.Bts_rm64_imm8),
			new InstructionInfo(64, "F0 FE 08", Code.Dec_rm8),
			new InstructionInfo(64, "F0 66 FF 08", Code.Dec_rm16),
			new InstructionInfo(64, "F0 FF 08", Code.Dec_rm32),
			new InstructionInfo(64, "F0 48 FF 08", Code.Dec_rm64),
			new InstructionInfo(64, "F0 FE 00", Code.Inc_rm8),
			new InstructionInfo(64, "F0 66 FF 00", Code.Inc_rm16),
			new InstructionInfo(64, "F0 FF 00", Code.Inc_rm32),
			new InstructionInfo(64, "F0 48 FF 00", Code.Inc_rm64),
			new InstructionInfo(64, "F0 F6 18", Code.Neg_rm8),
			new InstructionInfo(64, "F0 66 F7 18", Code.Neg_rm16),
			new InstructionInfo(64, "F0 F7 18", Code.Neg_rm32),
			new InstructionInfo(64, "F0 48 F7 18", Code.Neg_rm64),
			new InstructionInfo(64, "F0 F6 10", Code.Not_rm8),
			new InstructionInfo(64, "F0 66 F7 10", Code.Not_rm16),
			new InstructionInfo(64, "F0 F7 10", Code.Not_rm32),
			new InstructionInfo(64, "F0 48 F7 10", Code.Not_rm64),
			new InstructionInfo(64, "F0 0F B0 08", Code.Cmpxchg_rm8_r8),
			new InstructionInfo(64, "F0 66 0F B1 08", Code.Cmpxchg_rm16_r16),
			new InstructionInfo(64, "F0 0F B1 08", Code.Cmpxchg_rm32_r32),
			new InstructionInfo(64, "F0 48 0F B1 08", Code.Cmpxchg_rm64_r64),
			new InstructionInfo(64, "F0 0F C0 08", Code.Xadd_rm8_r8),
			new InstructionInfo(64, "F0 66 0F C1 08", Code.Xadd_rm16_r16),
			new InstructionInfo(64, "F0 0F C1 08", Code.Xadd_rm32_r32),
			new InstructionInfo(64, "F0 48 0F C1 08", Code.Xadd_rm64_r64),
			new InstructionInfo(64, "F0 86 08", Code.Xchg_rm8_r8),
			new InstructionInfo(64, "F0 66 87 08", Code.Xchg_rm16_r16),
			new InstructionInfo(64, "F0 87 08", Code.Xchg_rm32_r32),
			new InstructionInfo(64, "F0 48 87 08", Code.Xchg_rm64_r64),
			new InstructionInfo(64, "F0 0F C7 08", Code.Cmpxchg8b_m64),
			new InstructionInfo(64, "F0 48 0F C7 08", Code.Cmpxchg16b_m128),
			new InstructionInfo(64, "F3 6C", Code.Insb_m8_DX),
			new InstructionInfo(64, "F3 66 6D", Code.Insw_m16_DX),
			new InstructionInfo(64, "F3 6D", Code.Insd_m32_DX),
			new InstructionInfo(64, "F3 6E", Code.Outsb_DX_m8),
			new InstructionInfo(64, "F3 66 6F", Code.Outsw_DX_m16),
			new InstructionInfo(64, "F3 6F", Code.Outsd_DX_m32),
			new InstructionInfo(64, "F3 A4", Code.Movsb_m8_m8),
			new InstructionInfo(64, "F3 66 A5", Code.Movsw_m16_m16),
			new InstructionInfo(64, "F3 A5", Code.Movsd_m32_m32),
			new InstructionInfo(64, "F3 48 A5", Code.Movsq_m64_m64),
			new InstructionInfo(64, "F3 A6", Code.Cmpsb_m8_m8),
			new InstructionInfo(64, "F2 A6", Code.Cmpsb_m8_m8),
			new InstructionInfo(64, "F3 66 A7", Code.Cmpsw_m16_m16),
			new InstructionInfo(64, "F2 66 A7", Code.Cmpsw_m16_m16),
			new InstructionInfo(64, "F3 A7", Code.Cmpsd_m32_m32),
			new InstructionInfo(64, "F2 A7", Code.Cmpsd_m32_m32),
			new InstructionInfo(64, "F3 48 A7", Code.Cmpsq_m64_m64),
			new InstructionInfo(64, "F2 48 A7", Code.Cmpsq_m64_m64),
			new InstructionInfo(64, "F3 AA", Code.Stosb_m8_AL),
			new InstructionInfo(64, "F3 66 AB", Code.Stosw_m16_AX),
			new InstructionInfo(64, "F3 AB", Code.Stosd_m32_EAX),
			new InstructionInfo(64, "F3 48 AB", Code.Stosq_m64_RAX),
			new InstructionInfo(64, "F3 AC", Code.Lodsb_AL_m8),
			new InstructionInfo(64, "F3 66 AD", Code.Lodsw_AX_m16),
			new InstructionInfo(64, "F3 AD", Code.Lodsd_EAX_m32),
			new InstructionInfo(64, "F3 48 AD", Code.Lodsq_RAX_m64),
			new InstructionInfo(64, "F3 AE", Code.Scasb_AL_m8),
			new InstructionInfo(64, "F2 AE", Code.Scasb_AL_m8),
			new InstructionInfo(64, "F3 66 AF", Code.Scasw_AX_m16),
			new InstructionInfo(64, "F2 66 AF", Code.Scasw_AX_m16),
			new InstructionInfo(64, "F3 AF", Code.Scasd_EAX_m32),
			new InstructionInfo(64, "F2 AF", Code.Scasd_EAX_m32),
			new InstructionInfo(64, "F3 48 AF", Code.Scasq_RAX_m64),
			new InstructionInfo(64, "F2 48 AF", Code.Scasq_RAX_m64),
			new InstructionInfo(64, "F2 F0 10 08", Code.Adc_rm8_r8),
			new InstructionInfo(64, "F2 F0 80 10 A5", Code.Adc_rm8_imm8),
			new InstructionInfo(64, "F2 F0 66 11 08", Code.Adc_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 83 10 A5", Code.Adc_rm16_imm8),
			new InstructionInfo(64, "F2 F0 66 81 10 5AA5", Code.Adc_rm16_imm16),
			new InstructionInfo(64, "F2 F0 11 08", Code.Adc_rm32_r32),
			new InstructionInfo(64, "F2 F0 83 10 A5", Code.Adc_rm32_imm8),
			new InstructionInfo(64, "F2 F0 81 10 34 12 5AA5", Code.Adc_rm32_imm32),
			new InstructionInfo(64, "F2 F0 48 11 08", Code.Adc_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 83 10 A5", Code.Adc_rm64_imm8),
			new InstructionInfo(64, "F2 F0 48 81 10 34 12 5AA5", Code.Adc_rm64_imm32),
			new InstructionInfo(64, "F2 F0 00 08", Code.Add_rm8_r8),
			new InstructionInfo(64, "F2 F0 80 00 A5", Code.Add_rm8_imm8),
			new InstructionInfo(64, "F2 F0 66 01 08", Code.Add_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 83 00 A5", Code.Add_rm16_imm8),
			new InstructionInfo(64, "F2 F0 66 81 00 5AA5", Code.Add_rm16_imm16),
			new InstructionInfo(64, "F2 F0 01 08", Code.Add_rm32_r32),
			new InstructionInfo(64, "F2 F0 83 00 A5", Code.Add_rm32_imm8),
			new InstructionInfo(64, "F2 F0 81 00 34 12 5AA5", Code.Add_rm32_imm32),
			new InstructionInfo(64, "F2 F0 48 01 08", Code.Add_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 83 00 A5", Code.Add_rm64_imm8),
			new InstructionInfo(64, "F2 F0 48 81 00 34 12 5AA5", Code.Add_rm64_imm32),
			new InstructionInfo(64, "F2 F0 20 08", Code.And_rm8_r8),
			new InstructionInfo(64, "F2 F0 80 20 A5", Code.And_rm8_imm8),
			new InstructionInfo(64, "F2 F0 66 21 08", Code.And_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 83 20 A5", Code.And_rm16_imm8),
			new InstructionInfo(64, "F2 F0 66 81 20 5AA5", Code.And_rm16_imm16),
			new InstructionInfo(64, "F2 F0 21 08", Code.And_rm32_r32),
			new InstructionInfo(64, "F2 F0 83 20 A5", Code.And_rm32_imm8),
			new InstructionInfo(64, "F2 F0 81 20 34 12 5AA5", Code.And_rm32_imm32),
			new InstructionInfo(64, "F2 F0 48 21 08", Code.And_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 83 20 A5", Code.And_rm64_imm8),
			new InstructionInfo(64, "F2 F0 48 81 20 34 12 5AA5", Code.And_rm64_imm32),
			new InstructionInfo(64, "F2 F0 08 08", Code.Or_rm8_r8),
			new InstructionInfo(64, "F2 F0 80 08 A5", Code.Or_rm8_imm8),
			new InstructionInfo(64, "F2 F0 66 09 08", Code.Or_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 83 08 A5", Code.Or_rm16_imm8),
			new InstructionInfo(64, "F2 F0 66 81 08 5AA5", Code.Or_rm16_imm16),
			new InstructionInfo(64, "F2 F0 09 08", Code.Or_rm32_r32),
			new InstructionInfo(64, "F2 F0 83 08 A5", Code.Or_rm32_imm8),
			new InstructionInfo(64, "F2 F0 81 08 34 12 5AA5", Code.Or_rm32_imm32),
			new InstructionInfo(64, "F2 F0 48 09 08", Code.Or_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 83 08 A5", Code.Or_rm64_imm8),
			new InstructionInfo(64, "F2 F0 48 81 08 34 12 5AA5", Code.Or_rm64_imm32),
			new InstructionInfo(64, "F2 F0 18 08", Code.Sbb_rm8_r8),
			new InstructionInfo(64, "F2 F0 80 18 A5", Code.Sbb_rm8_imm8),
			new InstructionInfo(64, "F2 F0 66 19 08", Code.Sbb_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 83 18 A5", Code.Sbb_rm16_imm8),
			new InstructionInfo(64, "F2 F0 66 81 18 5AA5", Code.Sbb_rm16_imm16),
			new InstructionInfo(64, "F2 F0 19 08", Code.Sbb_rm32_r32),
			new InstructionInfo(64, "F2 F0 83 18 A5", Code.Sbb_rm32_imm8),
			new InstructionInfo(64, "F2 F0 81 18 34 12 5AA5", Code.Sbb_rm32_imm32),
			new InstructionInfo(64, "F2 F0 48 19 08", Code.Sbb_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 83 18 A5", Code.Sbb_rm64_imm8),
			new InstructionInfo(64, "F2 F0 48 81 18 34 12 5AA5", Code.Sbb_rm64_imm32),
			new InstructionInfo(64, "F2 F0 28 08", Code.Sub_rm8_r8),
			new InstructionInfo(64, "F2 F0 80 28 A5", Code.Sub_rm8_imm8),
			new InstructionInfo(64, "F2 F0 66 29 08", Code.Sub_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 83 28 A5", Code.Sub_rm16_imm8),
			new InstructionInfo(64, "F2 F0 66 81 28 5AA5", Code.Sub_rm16_imm16),
			new InstructionInfo(64, "F2 F0 29 08", Code.Sub_rm32_r32),
			new InstructionInfo(64, "F2 F0 83 28 A5", Code.Sub_rm32_imm8),
			new InstructionInfo(64, "F2 F0 81 28 34 12 5AA5", Code.Sub_rm32_imm32),
			new InstructionInfo(64, "F2 F0 48 29 08", Code.Sub_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 83 28 A5", Code.Sub_rm64_imm8),
			new InstructionInfo(64, "F2 F0 48 81 28 34 12 5AA5", Code.Sub_rm64_imm32),
			new InstructionInfo(64, "F2 F0 30 08", Code.Xor_rm8_r8),
			new InstructionInfo(64, "F2 F0 80 30 A5", Code.Xor_rm8_imm8),
			new InstructionInfo(64, "F2 F0 66 31 08", Code.Xor_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 83 30 A5", Code.Xor_rm16_imm8),
			new InstructionInfo(64, "F2 F0 66 81 30 5AA5", Code.Xor_rm16_imm16),
			new InstructionInfo(64, "F2 F0 31 08", Code.Xor_rm32_r32),
			new InstructionInfo(64, "F2 F0 83 30 A5", Code.Xor_rm32_imm8),
			new InstructionInfo(64, "F2 F0 81 30 34 12 5AA5", Code.Xor_rm32_imm32),
			new InstructionInfo(64, "F2 F0 48 31 08", Code.Xor_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 83 30 A5", Code.Xor_rm64_imm8),
			new InstructionInfo(64, "F2 F0 48 81 30 34 12 5AA5", Code.Xor_rm64_imm32),
			new InstructionInfo(64, "F2 F0 66 0F BB 08", Code.Btc_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 0F BA 38 A5", Code.Btc_rm16_imm8),
			new InstructionInfo(64, "F2 F0 0F BB 08", Code.Btc_rm32_r32),
			new InstructionInfo(64, "F2 F0 0F BA 38 A5", Code.Btc_rm32_imm8),
			new InstructionInfo(64, "F2 F0 48 0F BB 08", Code.Btc_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 0F BA 38 A5", Code.Btc_rm64_imm8),
			new InstructionInfo(64, "F2 F0 66 0F B3 08", Code.Btr_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 0F BA 30 A5", Code.Btr_rm16_imm8),
			new InstructionInfo(64, "F2 F0 0F B3 08", Code.Btr_rm32_r32),
			new InstructionInfo(64, "F2 F0 0F BA 30 A5", Code.Btr_rm32_imm8),
			new InstructionInfo(64, "F2 F0 48 0F B3 08", Code.Btr_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 0F BA 30 A5", Code.Btr_rm64_imm8),
			new InstructionInfo(64, "F2 F0 66 0F AB 08", Code.Bts_rm16_r16),
			new InstructionInfo(64, "F2 F0 66 0F BA 28 A5", Code.Bts_rm16_imm8),
			new InstructionInfo(64, "F2 F0 0F AB 08", Code.Bts_rm32_r32),
			new InstructionInfo(64, "F2 F0 0F BA 28 A5", Code.Bts_rm32_imm8),
			new InstructionInfo(64, "F2 F0 48 0F AB 08", Code.Bts_rm64_r64),
			new InstructionInfo(64, "F2 F0 48 0F BA 28 A5", Code.Bts_rm64_imm8),
			new InstructionInfo(64, "F2 F0 FE 08", Code.Dec_rm8),
			new InstructionInfo(64, "F2 F0 66 FF 08", Code.Dec_rm16),
			new InstructionInfo(64, "F2 F0 FF 08", Code.Dec_rm32),
			new InstructionInfo(64, "F2 F0 48 FF 08", Code.Dec_rm64),
			new InstructionInfo(64, "F2 F0 FE 00", Code.Inc_rm8),
			new InstructionInfo(64, "F2 F0 66 FF 00", Code.Inc_rm16),
			new InstructionInfo(64, "F2 F0 FF 00", Code.Inc_rm32),
			new InstructionInfo(64, "F2 F0 48 FF 00", Code.Inc_rm64),
			new InstructionInfo(64, "F2 F0 F6 18", Code.Neg_rm8),
			new InstructionInfo(64, "F2 F0 66 F7 18", Code.Neg_rm16),
			new InstructionInfo(64, "F2 F0 F7 18", Code.Neg_rm32),
			new InstructionInfo(64, "F2 F0 48 F7 18", Code.Neg_rm64),
			new InstructionInfo(64, "F2 F0 F6 10", Code.Not_rm8),
			new InstructionInfo(64, "F2 F0 66 F7 10", Code.Not_rm16),
			new InstructionInfo(64, "F2 F0 F7 10", Code.Not_rm32),
			new InstructionInfo(64, "F2 F0 48 F7 10", Code.Not_rm64),
			new InstructionInfo(64, "F2 F0 0F B0 08", Code.Cmpxchg_rm8_r8),
			new InstructionInfo(64, "F2 F0 66 0F B1 08", Code.Cmpxchg_rm16_r16),
			new InstructionInfo(64, "F2 F0 0F B1 08", Code.Cmpxchg_rm32_r32),
			new InstructionInfo(64, "F2 F0 48 0F B1 08", Code.Cmpxchg_rm64_r64),
			new InstructionInfo(64, "F2 F0 0F C0 08", Code.Xadd_rm8_r8),
			new InstructionInfo(64, "F2 F0 66 0F C1 08", Code.Xadd_rm16_r16),
			new InstructionInfo(64, "F2 F0 0F C1 08", Code.Xadd_rm32_r32),
			new InstructionInfo(64, "F2 F0 48 0F C1 08", Code.Xadd_rm64_r64),
			new InstructionInfo(64, "F2 86 08", Code.Xchg_rm8_r8),
			new InstructionInfo(64, "F2 66 87 08", Code.Xchg_rm16_r16),
			new InstructionInfo(64, "F2 87 08", Code.Xchg_rm32_r32),
			new InstructionInfo(64, "F2 48 87 08", Code.Xchg_rm64_r64),
			new InstructionInfo(64, "F2 F0 86 08", Code.Xchg_rm8_r8),
			new InstructionInfo(64, "F2 F0 66 87 08", Code.Xchg_rm16_r16),
			new InstructionInfo(64, "F2 F0 87 08", Code.Xchg_rm32_r32),
			new InstructionInfo(64, "F2 F0 48 87 08", Code.Xchg_rm64_r64),
			new InstructionInfo(64, "F2 F0 0F C7 08", Code.Cmpxchg8b_m64),
			new InstructionInfo(64, "F3 F0 10 08", Code.Adc_rm8_r8),
			new InstructionInfo(64, "F3 F0 80 10 A5", Code.Adc_rm8_imm8),
			new InstructionInfo(64, "F3 F0 66 11 08", Code.Adc_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 83 10 A5", Code.Adc_rm16_imm8),
			new InstructionInfo(64, "F3 F0 66 81 10 5AA5", Code.Adc_rm16_imm16),
			new InstructionInfo(64, "F3 F0 11 08", Code.Adc_rm32_r32),
			new InstructionInfo(64, "F3 F0 83 10 A5", Code.Adc_rm32_imm8),
			new InstructionInfo(64, "F3 F0 81 10 34 12 5AA5", Code.Adc_rm32_imm32),
			new InstructionInfo(64, "F3 F0 48 11 08", Code.Adc_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 83 10 A5", Code.Adc_rm64_imm8),
			new InstructionInfo(64, "F3 F0 48 81 10 34 12 5AA5", Code.Adc_rm64_imm32),
			new InstructionInfo(64, "F3 F0 00 08", Code.Add_rm8_r8),
			new InstructionInfo(64, "F3 F0 80 00 A5", Code.Add_rm8_imm8),
			new InstructionInfo(64, "F3 F0 66 01 08", Code.Add_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 83 00 A5", Code.Add_rm16_imm8),
			new InstructionInfo(64, "F3 F0 66 81 00 5AA5", Code.Add_rm16_imm16),
			new InstructionInfo(64, "F3 F0 01 08", Code.Add_rm32_r32),
			new InstructionInfo(64, "F3 F0 83 00 A5", Code.Add_rm32_imm8),
			new InstructionInfo(64, "F3 F0 81 00 34 12 5AA5", Code.Add_rm32_imm32),
			new InstructionInfo(64, "F3 F0 48 01 08", Code.Add_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 83 00 A5", Code.Add_rm64_imm8),
			new InstructionInfo(64, "F3 F0 48 81 00 34 12 5AA5", Code.Add_rm64_imm32),
			new InstructionInfo(64, "F3 F0 20 08", Code.And_rm8_r8),
			new InstructionInfo(64, "F3 F0 80 20 A5", Code.And_rm8_imm8),
			new InstructionInfo(64, "F3 F0 66 21 08", Code.And_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 83 20 A5", Code.And_rm16_imm8),
			new InstructionInfo(64, "F3 F0 66 81 20 5AA5", Code.And_rm16_imm16),
			new InstructionInfo(64, "F3 F0 21 08", Code.And_rm32_r32),
			new InstructionInfo(64, "F3 F0 83 20 A5", Code.And_rm32_imm8),
			new InstructionInfo(64, "F3 F0 81 20 34 12 5AA5", Code.And_rm32_imm32),
			new InstructionInfo(64, "F3 F0 48 21 08", Code.And_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 83 20 A5", Code.And_rm64_imm8),
			new InstructionInfo(64, "F3 F0 48 81 20 34 12 5AA5", Code.And_rm64_imm32),
			new InstructionInfo(64, "F3 F0 08 08", Code.Or_rm8_r8),
			new InstructionInfo(64, "F3 F0 80 08 A5", Code.Or_rm8_imm8),
			new InstructionInfo(64, "F3 F0 66 09 08", Code.Or_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 83 08 A5", Code.Or_rm16_imm8),
			new InstructionInfo(64, "F3 F0 66 81 08 5AA5", Code.Or_rm16_imm16),
			new InstructionInfo(64, "F3 F0 09 08", Code.Or_rm32_r32),
			new InstructionInfo(64, "F3 F0 83 08 A5", Code.Or_rm32_imm8),
			new InstructionInfo(64, "F3 F0 81 08 34 12 5AA5", Code.Or_rm32_imm32),
			new InstructionInfo(64, "F3 F0 48 09 08", Code.Or_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 83 08 A5", Code.Or_rm64_imm8),
			new InstructionInfo(64, "F3 F0 48 81 08 34 12 5AA5", Code.Or_rm64_imm32),
			new InstructionInfo(64, "F3 F0 18 08", Code.Sbb_rm8_r8),
			new InstructionInfo(64, "F3 F0 80 18 A5", Code.Sbb_rm8_imm8),
			new InstructionInfo(64, "F3 F0 66 19 08", Code.Sbb_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 83 18 A5", Code.Sbb_rm16_imm8),
			new InstructionInfo(64, "F3 F0 66 81 18 5AA5", Code.Sbb_rm16_imm16),
			new InstructionInfo(64, "F3 F0 19 08", Code.Sbb_rm32_r32),
			new InstructionInfo(64, "F3 F0 83 18 A5", Code.Sbb_rm32_imm8),
			new InstructionInfo(64, "F3 F0 81 18 34 12 5AA5", Code.Sbb_rm32_imm32),
			new InstructionInfo(64, "F3 F0 48 19 08", Code.Sbb_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 83 18 A5", Code.Sbb_rm64_imm8),
			new InstructionInfo(64, "F3 F0 48 81 18 34 12 5AA5", Code.Sbb_rm64_imm32),
			new InstructionInfo(64, "F3 F0 28 08", Code.Sub_rm8_r8),
			new InstructionInfo(64, "F3 F0 80 28 A5", Code.Sub_rm8_imm8),
			new InstructionInfo(64, "F3 F0 66 29 08", Code.Sub_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 83 28 A5", Code.Sub_rm16_imm8),
			new InstructionInfo(64, "F3 F0 66 81 28 5AA5", Code.Sub_rm16_imm16),
			new InstructionInfo(64, "F3 F0 29 08", Code.Sub_rm32_r32),
			new InstructionInfo(64, "F3 F0 83 28 A5", Code.Sub_rm32_imm8),
			new InstructionInfo(64, "F3 F0 81 28 34 12 5AA5", Code.Sub_rm32_imm32),
			new InstructionInfo(64, "F3 F0 48 29 08", Code.Sub_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 83 28 A5", Code.Sub_rm64_imm8),
			new InstructionInfo(64, "F3 F0 48 81 28 34 12 5AA5", Code.Sub_rm64_imm32),
			new InstructionInfo(64, "F3 F0 30 08", Code.Xor_rm8_r8),
			new InstructionInfo(64, "F3 F0 80 30 A5", Code.Xor_rm8_imm8),
			new InstructionInfo(64, "F3 F0 66 31 08", Code.Xor_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 83 30 A5", Code.Xor_rm16_imm8),
			new InstructionInfo(64, "F3 F0 66 81 30 5AA5", Code.Xor_rm16_imm16),
			new InstructionInfo(64, "F3 F0 31 08", Code.Xor_rm32_r32),
			new InstructionInfo(64, "F3 F0 83 30 A5", Code.Xor_rm32_imm8),
			new InstructionInfo(64, "F3 F0 81 30 34 12 5AA5", Code.Xor_rm32_imm32),
			new InstructionInfo(64, "F3 F0 48 31 08", Code.Xor_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 83 30 A5", Code.Xor_rm64_imm8),
			new InstructionInfo(64, "F3 F0 48 81 30 34 12 5AA5", Code.Xor_rm64_imm32),
			new InstructionInfo(64, "F3 F0 66 0F BB 08", Code.Btc_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 0F BA 38 A5", Code.Btc_rm16_imm8),
			new InstructionInfo(64, "F3 F0 0F BB 08", Code.Btc_rm32_r32),
			new InstructionInfo(64, "F3 F0 0F BA 38 A5", Code.Btc_rm32_imm8),
			new InstructionInfo(64, "F3 F0 48 0F BB 08", Code.Btc_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 0F BA 38 A5", Code.Btc_rm64_imm8),
			new InstructionInfo(64, "F3 F0 66 0F B3 08", Code.Btr_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 0F BA 30 A5", Code.Btr_rm16_imm8),
			new InstructionInfo(64, "F3 F0 0F B3 08", Code.Btr_rm32_r32),
			new InstructionInfo(64, "F3 F0 0F BA 30 A5", Code.Btr_rm32_imm8),
			new InstructionInfo(64, "F3 F0 48 0F B3 08", Code.Btr_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 0F BA 30 A5", Code.Btr_rm64_imm8),
			new InstructionInfo(64, "F3 F0 66 0F AB 08", Code.Bts_rm16_r16),
			new InstructionInfo(64, "F3 F0 66 0F BA 28 A5", Code.Bts_rm16_imm8),
			new InstructionInfo(64, "F3 F0 0F AB 08", Code.Bts_rm32_r32),
			new InstructionInfo(64, "F3 F0 0F BA 28 A5", Code.Bts_rm32_imm8),
			new InstructionInfo(64, "F3 F0 48 0F AB 08", Code.Bts_rm64_r64),
			new InstructionInfo(64, "F3 F0 48 0F BA 28 A5", Code.Bts_rm64_imm8),
			new InstructionInfo(64, "F3 F0 FE 08", Code.Dec_rm8),
			new InstructionInfo(64, "F3 F0 66 FF 08", Code.Dec_rm16),
			new InstructionInfo(64, "F3 F0 FF 08", Code.Dec_rm32),
			new InstructionInfo(64, "F3 F0 48 FF 08", Code.Dec_rm64),
			new InstructionInfo(64, "F3 F0 FE 00", Code.Inc_rm8),
			new InstructionInfo(64, "F3 F0 66 FF 00", Code.Inc_rm16),
			new InstructionInfo(64, "F3 F0 FF 00", Code.Inc_rm32),
			new InstructionInfo(64, "F3 F0 48 FF 00", Code.Inc_rm64),
			new InstructionInfo(64, "F3 F0 F6 18", Code.Neg_rm8),
			new InstructionInfo(64, "F3 F0 66 F7 18", Code.Neg_rm16),
			new InstructionInfo(64, "F3 F0 F7 18", Code.Neg_rm32),
			new InstructionInfo(64, "F3 F0 48 F7 18", Code.Neg_rm64),
			new InstructionInfo(64, "F3 F0 F6 10", Code.Not_rm8),
			new InstructionInfo(64, "F3 F0 66 F7 10", Code.Not_rm16),
			new InstructionInfo(64, "F3 F0 F7 10", Code.Not_rm32),
			new InstructionInfo(64, "F3 F0 48 F7 10", Code.Not_rm64),
			new InstructionInfo(64, "F3 F0 0F B0 08", Code.Cmpxchg_rm8_r8),
			new InstructionInfo(64, "F3 F0 66 0F B1 08", Code.Cmpxchg_rm16_r16),
			new InstructionInfo(64, "F3 F0 0F B1 08", Code.Cmpxchg_rm32_r32),
			new InstructionInfo(64, "F3 F0 48 0F B1 08", Code.Cmpxchg_rm64_r64),
			new InstructionInfo(64, "F3 F0 0F C0 08", Code.Xadd_rm8_r8),
			new InstructionInfo(64, "F3 F0 66 0F C1 08", Code.Xadd_rm16_r16),
			new InstructionInfo(64, "F3 F0 0F C1 08", Code.Xadd_rm32_r32),
			new InstructionInfo(64, "F3 F0 48 0F C1 08", Code.Xadd_rm64_r64),
			new InstructionInfo(64, "F3 86 08", Code.Xchg_rm8_r8),
			new InstructionInfo(64, "F3 66 87 08", Code.Xchg_rm16_r16),
			new InstructionInfo(64, "F3 87 08", Code.Xchg_rm32_r32),
			new InstructionInfo(64, "F3 48 87 08", Code.Xchg_rm64_r64),
			new InstructionInfo(64, "F3 F0 86 08", Code.Xchg_rm8_r8),
			new InstructionInfo(64, "F3 F0 66 87 08", Code.Xchg_rm16_r16),
			new InstructionInfo(64, "F3 F0 87 08", Code.Xchg_rm32_r32),
			new InstructionInfo(64, "F3 F0 48 87 08", Code.Xchg_rm64_r64),
			new InstructionInfo(64, "F3 F0 0F C7 08", Code.Cmpxchg8b_m64),
			new InstructionInfo(64, "F3 88 08", Code.Mov_rm8_r8),
			new InstructionInfo(64, "F3 66 89 08", Code.Mov_rm16_r16),
			new InstructionInfo(64, "F3 89 08", Code.Mov_rm32_r32),
			new InstructionInfo(64, "F3 48 89 08", Code.Mov_rm64_r64),
			new InstructionInfo(64, "F3 C6 00 A5", Code.Mov_rm8_imm8),
			new InstructionInfo(64, "F3 66 C7 00 5AA5", Code.Mov_rm16_imm16),
			new InstructionInfo(64, "F3 C7 00 34125AA5", Code.Mov_rm32_imm32),
			new InstructionInfo(64, "F3 48 C7 00 34125AA5", Code.Mov_rm64_imm32),
			new InstructionInfo(64, "2E 70 00", Code.Jo_rel8_64),
			new InstructionInfo(64, "2E 71 00", Code.Jno_rel8_64),
			new InstructionInfo(64, "2E 72 00", Code.Jb_rel8_64),
			new InstructionInfo(64, "2E 73 00", Code.Jae_rel8_64),
			new InstructionInfo(64, "2E 74 00", Code.Je_rel8_64),
			new InstructionInfo(64, "2E 75 00", Code.Jne_rel8_64),
			new InstructionInfo(64, "2E 76 00", Code.Jbe_rel8_64),
			new InstructionInfo(64, "2E 77 00", Code.Ja_rel8_64),
			new InstructionInfo(64, "2E 78 00", Code.Js_rel8_64),
			new InstructionInfo(64, "2E 79 00", Code.Jns_rel8_64),
			new InstructionInfo(64, "2E 7A 00", Code.Jp_rel8_64),
			new InstructionInfo(64, "2E 7B 00", Code.Jnp_rel8_64),
			new InstructionInfo(64, "2E 7C 00", Code.Jl_rel8_64),
			new InstructionInfo(64, "2E 7D 00", Code.Jge_rel8_64),
			new InstructionInfo(64, "2E 7E 00", Code.Jle_rel8_64),
			new InstructionInfo(64, "2E 7F 00", Code.Jg_rel8_64),
			new InstructionInfo(64, "3E 70 00", Code.Jo_rel8_64),
			new InstructionInfo(64, "3E 71 00", Code.Jno_rel8_64),
			new InstructionInfo(64, "3E 72 00", Code.Jb_rel8_64),
			new InstructionInfo(64, "3E 73 00", Code.Jae_rel8_64),
			new InstructionInfo(64, "3E 74 00", Code.Je_rel8_64),
			new InstructionInfo(64, "3E 75 00", Code.Jne_rel8_64),
			new InstructionInfo(64, "3E 76 00", Code.Jbe_rel8_64),
			new InstructionInfo(64, "3E 77 00", Code.Ja_rel8_64),
			new InstructionInfo(64, "3E 78 00", Code.Js_rel8_64),
			new InstructionInfo(64, "3E 79 00", Code.Jns_rel8_64),
			new InstructionInfo(64, "3E 7A 00", Code.Jp_rel8_64),
			new InstructionInfo(64, "3E 7B 00", Code.Jnp_rel8_64),
			new InstructionInfo(64, "3E 7C 00", Code.Jl_rel8_64),
			new InstructionInfo(64, "3E 7D 00", Code.Jge_rel8_64),
			new InstructionInfo(64, "3E 7E 00", Code.Jle_rel8_64),
			new InstructionInfo(64, "3E 7F 00", Code.Jg_rel8_64),
			new InstructionInfo(64, "2E 0F80 00000000", Code.Jo_rel32_64),
			new InstructionInfo(64, "2E 0F81 00000000", Code.Jno_rel32_64),
			new InstructionInfo(64, "2E 0F82 00000000", Code.Jb_rel32_64),
			new InstructionInfo(64, "2E 0F83 00000000", Code.Jae_rel32_64),
			new InstructionInfo(64, "2E 0F84 00000000", Code.Je_rel32_64),
			new InstructionInfo(64, "2E 0F85 00000000", Code.Jne_rel32_64),
			new InstructionInfo(64, "2E 0F86 00000000", Code.Jbe_rel32_64),
			new InstructionInfo(64, "2E 0F87 00000000", Code.Ja_rel32_64),
			new InstructionInfo(64, "2E 0F88 00000000", Code.Js_rel32_64),
			new InstructionInfo(64, "2E 0F89 00000000", Code.Jns_rel32_64),
			new InstructionInfo(64, "2E 0F8A 00000000", Code.Jp_rel32_64),
			new InstructionInfo(64, "2E 0F8B 00000000", Code.Jnp_rel32_64),
			new InstructionInfo(64, "2E 0F8C 00000000", Code.Jl_rel32_64),
			new InstructionInfo(64, "2E 0F8D 00000000", Code.Jge_rel32_64),
			new InstructionInfo(64, "2E 0F8E 00000000", Code.Jle_rel32_64),
			new InstructionInfo(64, "2E 0F8F 00000000", Code.Jg_rel32_64),
			new InstructionInfo(64, "3E 0F80 00000000", Code.Jo_rel32_64),
			new InstructionInfo(64, "3E 0F81 00000000", Code.Jno_rel32_64),
			new InstructionInfo(64, "3E 0F82 00000000", Code.Jb_rel32_64),
			new InstructionInfo(64, "3E 0F83 00000000", Code.Jae_rel32_64),
			new InstructionInfo(64, "3E 0F84 00000000", Code.Je_rel32_64),
			new InstructionInfo(64, "3E 0F85 00000000", Code.Jne_rel32_64),
			new InstructionInfo(64, "3E 0F86 00000000", Code.Jbe_rel32_64),
			new InstructionInfo(64, "3E 0F87 00000000", Code.Ja_rel32_64),
			new InstructionInfo(64, "3E 0F88 00000000", Code.Js_rel32_64),
			new InstructionInfo(64, "3E 0F89 00000000", Code.Jns_rel32_64),
			new InstructionInfo(64, "3E 0F8A 00000000", Code.Jp_rel32_64),
			new InstructionInfo(64, "3E 0F8B 00000000", Code.Jnp_rel32_64),
			new InstructionInfo(64, "3E 0F8C 00000000", Code.Jl_rel32_64),
			new InstructionInfo(64, "3E 0F8D 00000000", Code.Jge_rel32_64),
			new InstructionInfo(64, "3E 0F8E 00000000", Code.Jle_rel32_64),
			new InstructionInfo(64, "3E 0F8F 00000000", Code.Jg_rel32_64),
			new InstructionInfo(64, "F2 70 00", Code.Jo_rel8_64),
			new InstructionInfo(64, "F2 71 00", Code.Jno_rel8_64),
			new InstructionInfo(64, "F2 72 00", Code.Jb_rel8_64),
			new InstructionInfo(64, "F2 73 00", Code.Jae_rel8_64),
			new InstructionInfo(64, "F2 74 00", Code.Je_rel8_64),
			new InstructionInfo(64, "F2 75 00", Code.Jne_rel8_64),
			new InstructionInfo(64, "F2 76 00", Code.Jbe_rel8_64),
			new InstructionInfo(64, "F2 77 00", Code.Ja_rel8_64),
			new InstructionInfo(64, "F2 78 00", Code.Js_rel8_64),
			new InstructionInfo(64, "F2 79 00", Code.Jns_rel8_64),
			new InstructionInfo(64, "F2 7A 00", Code.Jp_rel8_64),
			new InstructionInfo(64, "F2 7B 00", Code.Jnp_rel8_64),
			new InstructionInfo(64, "F2 7C 00", Code.Jl_rel8_64),
			new InstructionInfo(64, "F2 7D 00", Code.Jge_rel8_64),
			new InstructionInfo(64, "F2 7E 00", Code.Jle_rel8_64),
			new InstructionInfo(64, "F2 7F 00", Code.Jg_rel8_64),
			new InstructionInfo(64, "F2 0F80 00000000", Code.Jo_rel32_64),
			new InstructionInfo(64, "F2 0F81 00000000", Code.Jno_rel32_64),
			new InstructionInfo(64, "F2 0F82 00000000", Code.Jb_rel32_64),
			new InstructionInfo(64, "F2 0F83 00000000", Code.Jae_rel32_64),
			new InstructionInfo(64, "F2 0F84 00000000", Code.Je_rel32_64),
			new InstructionInfo(64, "F2 0F85 00000000", Code.Jne_rel32_64),
			new InstructionInfo(64, "F2 0F86 00000000", Code.Jbe_rel32_64),
			new InstructionInfo(64, "F2 0F87 00000000", Code.Ja_rel32_64),
			new InstructionInfo(64, "F2 0F88 00000000", Code.Js_rel32_64),
			new InstructionInfo(64, "F2 0F89 00000000", Code.Jns_rel32_64),
			new InstructionInfo(64, "F2 0F8A 00000000", Code.Jp_rel32_64),
			new InstructionInfo(64, "F2 0F8B 00000000", Code.Jnp_rel32_64),
			new InstructionInfo(64, "F2 0F8C 00000000", Code.Jl_rel32_64),
			new InstructionInfo(64, "F2 0F8D 00000000", Code.Jge_rel32_64),
			new InstructionInfo(64, "F2 0F8E 00000000", Code.Jle_rel32_64),
			new InstructionInfo(64, "F2 0F8F 00000000", Code.Jg_rel32_64),
			new InstructionInfo(64, "F2 E9 00000000", Code.Jmp_rel32_64),
			new InstructionInfo(64, "F2 FF 20", Code.Jmp_rm64),
			new InstructionInfo(64, "F2 FF E0", Code.Jmp_rm64),
			new InstructionInfo(64, "F2 E8 00000000", Code.Call_rel32_64),
			new InstructionInfo(64, "F2 FF 10", Code.Call_rm64),
			new InstructionInfo(64, "F2 FF D0", Code.Call_rm64),
			new InstructionInfo(64, "F2 C2 00 00", Code.Retnq_imm16),
			new InstructionInfo(64, "F2 C3", Code.Retnq),
			new InstructionInfo(64, "3E FF 10", Code.Call_rm64),
			new InstructionInfo(64, "3E FF 55 11", Code.Call_rm64),
			new InstructionInfo(64, "3E FF D1", Code.Call_rm64),
			new InstructionInfo(64, "3E FF 20", Code.Jmp_rm64),
			new InstructionInfo(64, "3E FF 65 11", Code.Jmp_rm64),
			new InstructionInfo(64, "3E FF E1", Code.Jmp_rm64),
			new InstructionInfo(64, "3E F2 FF D1", Code.Call_rm64),
			new InstructionInfo(64, "64 3E FF 10", Code.Call_rm64),
			new InstructionInfo(64, "3E 64 FF 10", Code.Call_rm64),
			new InstructionInfo(64, "3E F2 FF E1", Code.Jmp_rm64),
			new InstructionInfo(64, "64 3E FF 20", Code.Jmp_rm64),
			new InstructionInfo(64, "3E 64 FF 20", Code.Jmp_rm64),
		};
	}
}
#endif
