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

#if ((!NO_DECODER32 || !NO_DECODER64) && !NO_DECODER) || !NO_ENCODER
namespace Iced.Intel {
	enum VectorLength : byte {
		L128	= 0,
		L256	= 1,
		L512	= 2,
		Unknown	= 3,
	}
}
#endif
