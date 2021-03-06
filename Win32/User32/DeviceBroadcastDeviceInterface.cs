﻿//Copyright (c) 2015-2017 Ilium VR, Inc.
//Licensed under the MIT License - https://raw.github.com/IliumVR/ToolsBindings/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IliumVR.Bindings.Win32.User32
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct DevBroadcastDeviceInterface
	{
		public int dbcc_size;
		public DeviceType dbcc_devicetype;
		public int dbcc_reserved;
		public Guid dbcc_classguid;
		public char dbcc_name;
	}
}
