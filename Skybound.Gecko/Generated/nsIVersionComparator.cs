// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIVersionComparator.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// Version strings are dot-separated sequences of version-parts.
    ///
    /// A version-part consists of up to four parts, all of which are optional:
    ///
    /// <number-a><string-b><number-c><string-d (everything else)>
    ///
    /// A version-part may also consist of a single asterisk "*" which indicates
    /// "infinity".
    ///
    /// Numbers are base-10, and are zero if left out.
    /// Strings are compared bytewise.
    ///
    /// For additional backwards compatibility, if "string-b" is "+" then
    /// "number-a" is incremented by 1 and "string-b" becomes "pre".
    ///
    /// 1.0pre1
    /// < 1.0pre2
    /// < 1.0 == 1.0.0 == 1.0.0.0
    /// < 1.1pre == 1.1pre0 == 1.0+
    /// < 1.1pre1a
    /// < 1.1pre1
    /// < 1.1pre10a
    /// < 1.1pre10
    ///
    /// Although not required by this interface, it is recommended that
    /// numbers remain within the limits of a signed char, i.e. -127 to 128.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e6cd620a-edbb-41d2-9e42-9a2ffc8107f3")]
	public interface nsIVersionComparator
	{
		
		/// <summary>
        /// Compare two version strings
        /// @param   A   The first version
        /// @param   B   The second version
        /// @returns < 0 if A < B
        /// = 0 if A == B
        /// > 0 if A > B
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Compare([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase A, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase B);
	}
}
