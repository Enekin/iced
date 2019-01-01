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

#if !NO_NASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Nasm {
	public sealed class NasmFormatterTest64_Misc : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, NasmFormatterFactory.Create());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_Misc.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_Misc.AllInfos_Length] {
			"lock adc [rax],cl",
			"lock adc byte [rax],0xa5",
			"lock adc [rax],cx",
			"lock adc word [rax],byte 0xffa5",
			"lock adc word [rax],0xa55a",
			"lock adc [rax],ecx",
			"lock adc dword [rax],byte 0xffffffa5",
			"lock adc dword [rax],0xa55a1234",
			"lock adc [rax],rcx",
			"lock adc qword [rax],byte 0xffffffffffffffa5",
			"lock adc qword [rax],qword 0xffffffffa55a1234",
			"lock add [rax],cl",
			"lock add byte [rax],0xa5",
			"lock add [rax],cx",
			"lock add word [rax],byte 0xffa5",
			"lock add word [rax],0xa55a",
			"lock add [rax],ecx",
			"lock add dword [rax],byte 0xffffffa5",
			"lock add dword [rax],0xa55a1234",
			"lock add [rax],rcx",
			"lock add qword [rax],byte 0xffffffffffffffa5",
			"lock add qword [rax],qword 0xffffffffa55a1234",
			"lock and [rax],cl",
			"lock and byte [rax],0xa5",
			"lock and [rax],cx",
			"lock and word [rax],byte 0xffa5",
			"lock and word [rax],0xa55a",
			"lock and [rax],ecx",
			"lock and dword [rax],byte 0xffffffa5",
			"lock and dword [rax],0xa55a1234",
			"lock and [rax],rcx",
			"lock and qword [rax],byte 0xffffffffffffffa5",
			"lock and qword [rax],qword 0xffffffffa55a1234",
			"lock or [rax],cl",
			"lock or byte [rax],0xa5",
			"lock or [rax],cx",
			"lock or word [rax],byte 0xffa5",
			"lock or word [rax],0xa55a",
			"lock or [rax],ecx",
			"lock or dword [rax],byte 0xffffffa5",
			"lock or dword [rax],0xa55a1234",
			"lock or [rax],rcx",
			"lock or qword [rax],byte 0xffffffffffffffa5",
			"lock or qword [rax],qword 0xffffffffa55a1234",
			"lock sbb [rax],cl",
			"lock sbb byte [rax],0xa5",
			"lock sbb [rax],cx",
			"lock sbb word [rax],byte 0xffa5",
			"lock sbb word [rax],0xa55a",
			"lock sbb [rax],ecx",
			"lock sbb dword [rax],byte 0xffffffa5",
			"lock sbb dword [rax],0xa55a1234",
			"lock sbb [rax],rcx",
			"lock sbb qword [rax],byte 0xffffffffffffffa5",
			"lock sbb qword [rax],qword 0xffffffffa55a1234",
			"lock sub [rax],cl",
			"lock sub byte [rax],0xa5",
			"lock sub [rax],cx",
			"lock sub word [rax],byte 0xffa5",
			"lock sub word [rax],0xa55a",
			"lock sub [rax],ecx",
			"lock sub dword [rax],byte 0xffffffa5",
			"lock sub dword [rax],0xa55a1234",
			"lock sub [rax],rcx",
			"lock sub qword [rax],byte 0xffffffffffffffa5",
			"lock sub qword [rax],qword 0xffffffffa55a1234",
			"lock xor [rax],cl",
			"lock xor byte [rax],0xa5",
			"lock xor [rax],cx",
			"lock xor word [rax],byte 0xffa5",
			"lock xor word [rax],0xa55a",
			"lock xor [rax],ecx",
			"lock xor dword [rax],byte 0xffffffa5",
			"lock xor dword [rax],0xa55a1234",
			"lock xor [rax],rcx",
			"lock xor qword [rax],byte 0xffffffffffffffa5",
			"lock xor qword [rax],qword 0xffffffffa55a1234",
			"lock btc [rax],cx",
			"lock btc word [rax],0xa5",
			"lock btc [rax],ecx",
			"lock btc dword [rax],0xa5",
			"lock btc [rax],rcx",
			"lock btc qword [rax],0xa5",
			"lock btr [rax],cx",
			"lock btr word [rax],0xa5",
			"lock btr [rax],ecx",
			"lock btr dword [rax],0xa5",
			"lock btr [rax],rcx",
			"lock btr qword [rax],0xa5",
			"lock bts [rax],cx",
			"lock bts word [rax],0xa5",
			"lock bts [rax],ecx",
			"lock bts dword [rax],0xa5",
			"lock bts [rax],rcx",
			"lock bts qword [rax],0xa5",
			"lock dec byte [rax]",
			"lock dec word [rax]",
			"lock dec dword [rax]",
			"lock dec qword [rax]",
			"lock inc byte [rax]",
			"lock inc word [rax]",
			"lock inc dword [rax]",
			"lock inc qword [rax]",
			"lock neg byte [rax]",
			"lock neg word [rax]",
			"lock neg dword [rax]",
			"lock neg qword [rax]",
			"lock not byte [rax]",
			"lock not word [rax]",
			"lock not dword [rax]",
			"lock not qword [rax]",
			"lock cmpxchg [rax],cl",
			"lock cmpxchg [rax],cx",
			"lock cmpxchg [rax],ecx",
			"lock cmpxchg [rax],rcx",
			"lock xadd [rax],cl",
			"lock xadd [rax],cx",
			"lock xadd [rax],ecx",
			"lock xadd [rax],rcx",
			"lock xchg cl,[rax]",
			"lock xchg cx,[rax]",
			"lock xchg ecx,[rax]",
			"lock xchg rcx,[rax]",
			"lock cmpxchg8b [rax]",
			"lock cmpxchg16b [rax]",
			"rep insb",
			"rep insw",
			"rep insd",
			"rep outsb",
			"rep outsw",
			"rep outsd",
			"rep movsb",
			"rep movsw",
			"rep movsd",
			"rep movsq",
			"repe cmpsb",
			"repne cmpsb",
			"repe cmpsw",
			"repne cmpsw",
			"repe cmpsd",
			"repne cmpsd",
			"repe cmpsq",
			"repne cmpsq",
			"rep stosb",
			"rep stosw",
			"rep stosd",
			"rep stosq",
			"rep lodsb",
			"rep lodsw",
			"rep lodsd",
			"rep lodsq",
			"repe scasb",
			"repne scasb",
			"repe scasw",
			"repne scasw",
			"repe scasd",
			"repne scasd",
			"repe scasq",
			"repne scasq",
			"xacquire lock adc [rax],cl",
			"xacquire lock adc byte [rax],0xa5",
			"xacquire lock adc [rax],cx",
			"xacquire lock adc word [rax],byte 0xffa5",
			"xacquire lock adc word [rax],0xa55a",
			"xacquire lock adc [rax],ecx",
			"xacquire lock adc dword [rax],byte 0xffffffa5",
			"xacquire lock adc dword [rax],0xa55a1234",
			"xacquire lock adc [rax],rcx",
			"xacquire lock adc qword [rax],byte 0xffffffffffffffa5",
			"xacquire lock adc qword [rax],qword 0xffffffffa55a1234",
			"xacquire lock add [rax],cl",
			"xacquire lock add byte [rax],0xa5",
			"xacquire lock add [rax],cx",
			"xacquire lock add word [rax],byte 0xffa5",
			"xacquire lock add word [rax],0xa55a",
			"xacquire lock add [rax],ecx",
			"xacquire lock add dword [rax],byte 0xffffffa5",
			"xacquire lock add dword [rax],0xa55a1234",
			"xacquire lock add [rax],rcx",
			"xacquire lock add qword [rax],byte 0xffffffffffffffa5",
			"xacquire lock add qword [rax],qword 0xffffffffa55a1234",
			"xacquire lock and [rax],cl",
			"xacquire lock and byte [rax],0xa5",
			"xacquire lock and [rax],cx",
			"xacquire lock and word [rax],byte 0xffa5",
			"xacquire lock and word [rax],0xa55a",
			"xacquire lock and [rax],ecx",
			"xacquire lock and dword [rax],byte 0xffffffa5",
			"xacquire lock and dword [rax],0xa55a1234",
			"xacquire lock and [rax],rcx",
			"xacquire lock and qword [rax],byte 0xffffffffffffffa5",
			"xacquire lock and qword [rax],qword 0xffffffffa55a1234",
			"xacquire lock or [rax],cl",
			"xacquire lock or byte [rax],0xa5",
			"xacquire lock or [rax],cx",
			"xacquire lock or word [rax],byte 0xffa5",
			"xacquire lock or word [rax],0xa55a",
			"xacquire lock or [rax],ecx",
			"xacquire lock or dword [rax],byte 0xffffffa5",
			"xacquire lock or dword [rax],0xa55a1234",
			"xacquire lock or [rax],rcx",
			"xacquire lock or qword [rax],byte 0xffffffffffffffa5",
			"xacquire lock or qword [rax],qword 0xffffffffa55a1234",
			"xacquire lock sbb [rax],cl",
			"xacquire lock sbb byte [rax],0xa5",
			"xacquire lock sbb [rax],cx",
			"xacquire lock sbb word [rax],byte 0xffa5",
			"xacquire lock sbb word [rax],0xa55a",
			"xacquire lock sbb [rax],ecx",
			"xacquire lock sbb dword [rax],byte 0xffffffa5",
			"xacquire lock sbb dword [rax],0xa55a1234",
			"xacquire lock sbb [rax],rcx",
			"xacquire lock sbb qword [rax],byte 0xffffffffffffffa5",
			"xacquire lock sbb qword [rax],qword 0xffffffffa55a1234",
			"xacquire lock sub [rax],cl",
			"xacquire lock sub byte [rax],0xa5",
			"xacquire lock sub [rax],cx",
			"xacquire lock sub word [rax],byte 0xffa5",
			"xacquire lock sub word [rax],0xa55a",
			"xacquire lock sub [rax],ecx",
			"xacquire lock sub dword [rax],byte 0xffffffa5",
			"xacquire lock sub dword [rax],0xa55a1234",
			"xacquire lock sub [rax],rcx",
			"xacquire lock sub qword [rax],byte 0xffffffffffffffa5",
			"xacquire lock sub qword [rax],qword 0xffffffffa55a1234",
			"xacquire lock xor [rax],cl",
			"xacquire lock xor byte [rax],0xa5",
			"xacquire lock xor [rax],cx",
			"xacquire lock xor word [rax],byte 0xffa5",
			"xacquire lock xor word [rax],0xa55a",
			"xacquire lock xor [rax],ecx",
			"xacquire lock xor dword [rax],byte 0xffffffa5",
			"xacquire lock xor dword [rax],0xa55a1234",
			"xacquire lock xor [rax],rcx",
			"xacquire lock xor qword [rax],byte 0xffffffffffffffa5",
			"xacquire lock xor qword [rax],qword 0xffffffffa55a1234",
			"xacquire lock btc [rax],cx",
			"xacquire lock btc word [rax],0xa5",
			"xacquire lock btc [rax],ecx",
			"xacquire lock btc dword [rax],0xa5",
			"xacquire lock btc [rax],rcx",
			"xacquire lock btc qword [rax],0xa5",
			"xacquire lock btr [rax],cx",
			"xacquire lock btr word [rax],0xa5",
			"xacquire lock btr [rax],ecx",
			"xacquire lock btr dword [rax],0xa5",
			"xacquire lock btr [rax],rcx",
			"xacquire lock btr qword [rax],0xa5",
			"xacquire lock bts [rax],cx",
			"xacquire lock bts word [rax],0xa5",
			"xacquire lock bts [rax],ecx",
			"xacquire lock bts dword [rax],0xa5",
			"xacquire lock bts [rax],rcx",
			"xacquire lock bts qword [rax],0xa5",
			"xacquire lock dec byte [rax]",
			"xacquire lock dec word [rax]",
			"xacquire lock dec dword [rax]",
			"xacquire lock dec qword [rax]",
			"xacquire lock inc byte [rax]",
			"xacquire lock inc word [rax]",
			"xacquire lock inc dword [rax]",
			"xacquire lock inc qword [rax]",
			"xacquire lock neg byte [rax]",
			"xacquire lock neg word [rax]",
			"xacquire lock neg dword [rax]",
			"xacquire lock neg qword [rax]",
			"xacquire lock not byte [rax]",
			"xacquire lock not word [rax]",
			"xacquire lock not dword [rax]",
			"xacquire lock not qword [rax]",
			"xacquire lock cmpxchg [rax],cl",
			"xacquire lock cmpxchg [rax],cx",
			"xacquire lock cmpxchg [rax],ecx",
			"xacquire lock cmpxchg [rax],rcx",
			"xacquire lock xadd [rax],cl",
			"xacquire lock xadd [rax],cx",
			"xacquire lock xadd [rax],ecx",
			"xacquire lock xadd [rax],rcx",
			"xacquire xchg cl,[rax]",
			"xacquire xchg cx,[rax]",
			"xacquire xchg ecx,[rax]",
			"xacquire xchg rcx,[rax]",
			"xacquire lock xchg cl,[rax]",
			"xacquire lock xchg cx,[rax]",
			"xacquire lock xchg ecx,[rax]",
			"xacquire lock xchg rcx,[rax]",
			"xacquire lock cmpxchg8b [rax]",
			"xrelease lock adc [rax],cl",
			"xrelease lock adc byte [rax],0xa5",
			"xrelease lock adc [rax],cx",
			"xrelease lock adc word [rax],byte 0xffa5",
			"xrelease lock adc word [rax],0xa55a",
			"xrelease lock adc [rax],ecx",
			"xrelease lock adc dword [rax],byte 0xffffffa5",
			"xrelease lock adc dword [rax],0xa55a1234",
			"xrelease lock adc [rax],rcx",
			"xrelease lock adc qword [rax],byte 0xffffffffffffffa5",
			"xrelease lock adc qword [rax],qword 0xffffffffa55a1234",
			"xrelease lock add [rax],cl",
			"xrelease lock add byte [rax],0xa5",
			"xrelease lock add [rax],cx",
			"xrelease lock add word [rax],byte 0xffa5",
			"xrelease lock add word [rax],0xa55a",
			"xrelease lock add [rax],ecx",
			"xrelease lock add dword [rax],byte 0xffffffa5",
			"xrelease lock add dword [rax],0xa55a1234",
			"xrelease lock add [rax],rcx",
			"xrelease lock add qword [rax],byte 0xffffffffffffffa5",
			"xrelease lock add qword [rax],qword 0xffffffffa55a1234",
			"xrelease lock and [rax],cl",
			"xrelease lock and byte [rax],0xa5",
			"xrelease lock and [rax],cx",
			"xrelease lock and word [rax],byte 0xffa5",
			"xrelease lock and word [rax],0xa55a",
			"xrelease lock and [rax],ecx",
			"xrelease lock and dword [rax],byte 0xffffffa5",
			"xrelease lock and dword [rax],0xa55a1234",
			"xrelease lock and [rax],rcx",
			"xrelease lock and qword [rax],byte 0xffffffffffffffa5",
			"xrelease lock and qword [rax],qword 0xffffffffa55a1234",
			"xrelease lock or [rax],cl",
			"xrelease lock or byte [rax],0xa5",
			"xrelease lock or [rax],cx",
			"xrelease lock or word [rax],byte 0xffa5",
			"xrelease lock or word [rax],0xa55a",
			"xrelease lock or [rax],ecx",
			"xrelease lock or dword [rax],byte 0xffffffa5",
			"xrelease lock or dword [rax],0xa55a1234",
			"xrelease lock or [rax],rcx",
			"xrelease lock or qword [rax],byte 0xffffffffffffffa5",
			"xrelease lock or qword [rax],qword 0xffffffffa55a1234",
			"xrelease lock sbb [rax],cl",
			"xrelease lock sbb byte [rax],0xa5",
			"xrelease lock sbb [rax],cx",
			"xrelease lock sbb word [rax],byte 0xffa5",
			"xrelease lock sbb word [rax],0xa55a",
			"xrelease lock sbb [rax],ecx",
			"xrelease lock sbb dword [rax],byte 0xffffffa5",
			"xrelease lock sbb dword [rax],0xa55a1234",
			"xrelease lock sbb [rax],rcx",
			"xrelease lock sbb qword [rax],byte 0xffffffffffffffa5",
			"xrelease lock sbb qword [rax],qword 0xffffffffa55a1234",
			"xrelease lock sub [rax],cl",
			"xrelease lock sub byte [rax],0xa5",
			"xrelease lock sub [rax],cx",
			"xrelease lock sub word [rax],byte 0xffa5",
			"xrelease lock sub word [rax],0xa55a",
			"xrelease lock sub [rax],ecx",
			"xrelease lock sub dword [rax],byte 0xffffffa5",
			"xrelease lock sub dword [rax],0xa55a1234",
			"xrelease lock sub [rax],rcx",
			"xrelease lock sub qword [rax],byte 0xffffffffffffffa5",
			"xrelease lock sub qword [rax],qword 0xffffffffa55a1234",
			"xrelease lock xor [rax],cl",
			"xrelease lock xor byte [rax],0xa5",
			"xrelease lock xor [rax],cx",
			"xrelease lock xor word [rax],byte 0xffa5",
			"xrelease lock xor word [rax],0xa55a",
			"xrelease lock xor [rax],ecx",
			"xrelease lock xor dword [rax],byte 0xffffffa5",
			"xrelease lock xor dword [rax],0xa55a1234",
			"xrelease lock xor [rax],rcx",
			"xrelease lock xor qword [rax],byte 0xffffffffffffffa5",
			"xrelease lock xor qword [rax],qword 0xffffffffa55a1234",
			"xrelease lock btc [rax],cx",
			"xrelease lock btc word [rax],0xa5",
			"xrelease lock btc [rax],ecx",
			"xrelease lock btc dword [rax],0xa5",
			"xrelease lock btc [rax],rcx",
			"xrelease lock btc qword [rax],0xa5",
			"xrelease lock btr [rax],cx",
			"xrelease lock btr word [rax],0xa5",
			"xrelease lock btr [rax],ecx",
			"xrelease lock btr dword [rax],0xa5",
			"xrelease lock btr [rax],rcx",
			"xrelease lock btr qword [rax],0xa5",
			"xrelease lock bts [rax],cx",
			"xrelease lock bts word [rax],0xa5",
			"xrelease lock bts [rax],ecx",
			"xrelease lock bts dword [rax],0xa5",
			"xrelease lock bts [rax],rcx",
			"xrelease lock bts qword [rax],0xa5",
			"xrelease lock dec byte [rax]",
			"xrelease lock dec word [rax]",
			"xrelease lock dec dword [rax]",
			"xrelease lock dec qword [rax]",
			"xrelease lock inc byte [rax]",
			"xrelease lock inc word [rax]",
			"xrelease lock inc dword [rax]",
			"xrelease lock inc qword [rax]",
			"xrelease lock neg byte [rax]",
			"xrelease lock neg word [rax]",
			"xrelease lock neg dword [rax]",
			"xrelease lock neg qword [rax]",
			"xrelease lock not byte [rax]",
			"xrelease lock not word [rax]",
			"xrelease lock not dword [rax]",
			"xrelease lock not qword [rax]",
			"xrelease lock cmpxchg [rax],cl",
			"xrelease lock cmpxchg [rax],cx",
			"xrelease lock cmpxchg [rax],ecx",
			"xrelease lock cmpxchg [rax],rcx",
			"xrelease lock xadd [rax],cl",
			"xrelease lock xadd [rax],cx",
			"xrelease lock xadd [rax],ecx",
			"xrelease lock xadd [rax],rcx",
			"xrelease xchg cl,[rax]",
			"xrelease xchg cx,[rax]",
			"xrelease xchg ecx,[rax]",
			"xrelease xchg rcx,[rax]",
			"xrelease lock xchg cl,[rax]",
			"xrelease lock xchg cx,[rax]",
			"xrelease lock xchg ecx,[rax]",
			"xrelease lock xchg rcx,[rax]",
			"xrelease lock cmpxchg8b [rax]",
			"xrelease mov [rax],cl",
			"xrelease mov [rax],cx",
			"xrelease mov [rax],ecx",
			"xrelease mov [rax],rcx",
			"xrelease mov byte [rax],0xa5",
			"xrelease mov word [rax],0xa55a",
			"xrelease mov dword [rax],0xa55a1234",
			"xrelease mov qword [rax],qword 0xffffffffa55a1234",
			"cs jo 0x7ffffffffffffff3",
			"cs jno 0x7ffffffffffffff3",
			"cs jb 0x7ffffffffffffff3",
			"cs jae 0x7ffffffffffffff3",
			"cs je 0x7ffffffffffffff3",
			"cs jne 0x7ffffffffffffff3",
			"cs jbe 0x7ffffffffffffff3",
			"cs ja 0x7ffffffffffffff3",
			"cs js 0x7ffffffffffffff3",
			"cs jns 0x7ffffffffffffff3",
			"cs jp 0x7ffffffffffffff3",
			"cs jnp 0x7ffffffffffffff3",
			"cs jl 0x7ffffffffffffff3",
			"cs jge 0x7ffffffffffffff3",
			"cs jle 0x7ffffffffffffff3",
			"cs jg 0x7ffffffffffffff3",
			"ds jo 0x7ffffffffffffff3",
			"ds jno 0x7ffffffffffffff3",
			"ds jb 0x7ffffffffffffff3",
			"ds jae 0x7ffffffffffffff3",
			"ds je 0x7ffffffffffffff3",
			"ds jne 0x7ffffffffffffff3",
			"ds jbe 0x7ffffffffffffff3",
			"ds ja 0x7ffffffffffffff3",
			"ds js 0x7ffffffffffffff3",
			"ds jns 0x7ffffffffffffff3",
			"ds jp 0x7ffffffffffffff3",
			"ds jnp 0x7ffffffffffffff3",
			"ds jl 0x7ffffffffffffff3",
			"ds jge 0x7ffffffffffffff3",
			"ds jle 0x7ffffffffffffff3",
			"ds jg 0x7ffffffffffffff3",
			"cs jo 0x7ffffffffffffff7",
			"cs jno 0x7ffffffffffffff7",
			"cs jb 0x7ffffffffffffff7",
			"cs jae 0x7ffffffffffffff7",
			"cs je 0x7ffffffffffffff7",
			"cs jne 0x7ffffffffffffff7",
			"cs jbe 0x7ffffffffffffff7",
			"cs ja 0x7ffffffffffffff7",
			"cs js 0x7ffffffffffffff7",
			"cs jns 0x7ffffffffffffff7",
			"cs jp 0x7ffffffffffffff7",
			"cs jnp 0x7ffffffffffffff7",
			"cs jl 0x7ffffffffffffff7",
			"cs jge 0x7ffffffffffffff7",
			"cs jle 0x7ffffffffffffff7",
			"cs jg 0x7ffffffffffffff7",
			"ds jo 0x7ffffffffffffff7",
			"ds jno 0x7ffffffffffffff7",
			"ds jb 0x7ffffffffffffff7",
			"ds jae 0x7ffffffffffffff7",
			"ds je 0x7ffffffffffffff7",
			"ds jne 0x7ffffffffffffff7",
			"ds jbe 0x7ffffffffffffff7",
			"ds ja 0x7ffffffffffffff7",
			"ds js 0x7ffffffffffffff7",
			"ds jns 0x7ffffffffffffff7",
			"ds jp 0x7ffffffffffffff7",
			"ds jnp 0x7ffffffffffffff7",
			"ds jl 0x7ffffffffffffff7",
			"ds jge 0x7ffffffffffffff7",
			"ds jle 0x7ffffffffffffff7",
			"ds jg 0x7ffffffffffffff7",
			"bnd jo 0x7ffffffffffffff3",
			"bnd jno 0x7ffffffffffffff3",
			"bnd jb 0x7ffffffffffffff3",
			"bnd jae 0x7ffffffffffffff3",
			"bnd je 0x7ffffffffffffff3",
			"bnd jne 0x7ffffffffffffff3",
			"bnd jbe 0x7ffffffffffffff3",
			"bnd ja 0x7ffffffffffffff3",
			"bnd js 0x7ffffffffffffff3",
			"bnd jns 0x7ffffffffffffff3",
			"bnd jp 0x7ffffffffffffff3",
			"bnd jnp 0x7ffffffffffffff3",
			"bnd jl 0x7ffffffffffffff3",
			"bnd jge 0x7ffffffffffffff3",
			"bnd jle 0x7ffffffffffffff3",
			"bnd jg 0x7ffffffffffffff3",
			"bnd jo 0x7ffffffffffffff7",
			"bnd jno 0x7ffffffffffffff7",
			"bnd jb 0x7ffffffffffffff7",
			"bnd jae 0x7ffffffffffffff7",
			"bnd je 0x7ffffffffffffff7",
			"bnd jne 0x7ffffffffffffff7",
			"bnd jbe 0x7ffffffffffffff7",
			"bnd ja 0x7ffffffffffffff7",
			"bnd js 0x7ffffffffffffff7",
			"bnd jns 0x7ffffffffffffff7",
			"bnd jp 0x7ffffffffffffff7",
			"bnd jnp 0x7ffffffffffffff7",
			"bnd jl 0x7ffffffffffffff7",
			"bnd jge 0x7ffffffffffffff7",
			"bnd jle 0x7ffffffffffffff7",
			"bnd jg 0x7ffffffffffffff7",
			"bnd jmp 0x7ffffffffffffff6",
			"bnd jmp qword [rax]",
			"bnd jmp rax",
			"bnd call 0x7ffffffffffffff6",
			"bnd call qword [rax]",
			"bnd call rax",
			"bnd ret 0",
			"bnd ret",
			"notrack call qword [ds:rax]",
			"notrack call qword [ds:rbp+0x11]",
			"notrack call rcx",
			"notrack jmp qword [ds:rax]",
			"notrack jmp qword [ds:rbp+0x11]",
			"notrack jmp rcx",
			"notrack bnd call rcx",
			"call qword [fs:rax]",
			"call qword [fs:rax]",
			"notrack bnd jmp rcx",
			"jmp qword [fs:rax]",
			"jmp qword [fs:rax]",
		};
	}
}
#endif
