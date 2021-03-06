﻿//Copyright (c) 2015-2017 Ilium VR, Inc.
//Licensed under the MIT License - https://raw.github.com/IliumVR/ToolsBindings/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IliumVR.Bindings.Win32.Hid
{
	[StructLayout(LayoutKind.Sequential)]
	public struct ButtonCaps
	{
		public ushort UsagePage;
		public byte ReportID;

		[MarshalAs(UnmanagedType.U1)]
		public bool IsAlias;

		public ushort BitField;
		public ushort LinkCollection;
		public ushort LinkUsage;
		public ushort LinkUsagePage;

		[MarshalAs(UnmanagedType.U1)]
		public bool IsRange;

		[MarshalAs(UnmanagedType.U1)]
		public bool IsStringRange;

		[MarshalAs(UnmanagedType.U1)]
		public bool IsDesignatorRange;

		[MarshalAs(UnmanagedType.U1)]
		public bool IsAbsolute;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public uint[] Reserved;

		public CapsRangeUnion RangeUnion;
	}
}
