﻿//Copyright (c) 2015-2017 Ilium VR, Inc.
//Licensed under the MIT License - https://raw.github.com/IliumVR/ToolsBindings/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IliumVR.Bindings.Win32.Kernel32
{
	public enum CreationDisposition : uint
	{
		/// <summary>
		/// Creates a new file. The function fails if a specified file exists.
		/// </summary>
		New = 1,
		/// <summary>
		/// Creates a new file, always. 
		/// If a file exists, the function overwrites the file, clears the existing attributes, combines the specified file attributes, 
		/// and flags with FILE_ATTRIBUTE_ARCHIVE, but does not set the security descriptor that the SECURITY_ATTRIBUTES structure specifies.
		/// </summary>
		CreateAlways = 2,
		/// <summary>
		/// Opens a file. The function fails if the file does not exist. 
		/// </summary>
		OpenExisting = 3,
		/// <summary>
		/// Opens a file, always. 
		/// If a file does not exist, the function creates a file as if dwCreationDisposition is CREATE_NEW.
		/// </summary>
		OpenAlways = 4,
		/// <summary>
		/// Opens a file and truncates it so that its size is 0 (zero) bytes. The function fails if the file does not exist.
		/// The calling process must open the file with the GENERIC_WRITE access right. 
		/// </summary>
		TruncateExisting = 5
	}
}
