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
// Generated by IDLImporter from file nsIUnicodeNormalizer.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B43A461F-1BCF-4329-820B-66E48C979E14")]
	public interface nsIUnicodeNormalizer
	{
		
		/// <summary>
        /// Normalize Unicode (NFD, NFC, NFKD, NFKC).
        ///
        /// NFD: Canonical Decomposition
        /// NFC: Canonical Decomposition, followed by Canonical Composition
        /// NFKD: Compatibility Decomposition
        /// NFKC: Compatibility Decomposition, followed by Canonical Composition
        /// Reference: Unicode Standard, TR15, Unicode Normalization Forms
        ///
        /// @param aSrc         [IN]  nsAString which contains an input UTF-16 string.
        /// @param aDest        [OUT] A pointer to an output buffer provided by a callee.
        /// @return             NS_OK for success,
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFD([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDest);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFC([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDest);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFKD([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDest);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NormalizeUnicodeNFKC([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDest);
	}
}
