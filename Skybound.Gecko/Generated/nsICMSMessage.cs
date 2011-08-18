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
// Generated by IDLImporter from file nsICMSMessage.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// nsICMSMessage
    /// Interface to a CMS Message
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a4557478-ae16-11d5-ba4b-00108303b117")]
	public interface nsICMSMessage
	{
		
		/// <summary>
        /// nsICMSMessage
        /// Interface to a CMS Message
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ContentIsSigned([MarshalAs(UnmanagedType.Bool)] ref bool aSigned);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ContentIsEncrypted([MarshalAs(UnmanagedType.Bool)] ref bool aEncrypted);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSignerCommonName([MarshalAs(UnmanagedType.LPStr)] ref string aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSignerEmailAddress([MarshalAs(UnmanagedType.LPStr)] ref string aEmail);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSignerCert([MarshalAs(UnmanagedType.Interface)] ref nsIX509Cert scert);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEncryptionCert([MarshalAs(UnmanagedType.Interface)] ref nsIX509Cert ecert);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VerifySignature();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VerifyDetachedSignature(System.IntPtr aDigestData, uint aDigestDataLen);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateEncrypted([MarshalAs(UnmanagedType.Interface)] nsIArray aRecipientCerts);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateSigned([MarshalAs(UnmanagedType.Interface)] nsIX509Cert scert, [MarshalAs(UnmanagedType.Interface)] nsIX509Cert ecert, System.IntPtr aDigestData, uint aDigestDataLen);
	}
}
