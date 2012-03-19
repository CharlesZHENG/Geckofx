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
// Generated by IDLImporter from file nsIProtectedAuthThread.idl
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
    /// nsIProtectedAuthThread
    /// This is used to communicate with the thread login on to
    /// a token with CKF_PROTECTED_AUTHENTICATION_PATH set.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4bb27cb7-8984-4cee-8ce7-9b014c3d091b")]
	public interface nsIProtectedAuthThread
	{
		
		/// <summary>
        /// login - run the thread
        /// A user interface implementing this interface needs to
        /// call this method as soon as the message to the user is
        /// displayed. This will trigger login operation. No user
        /// cancellation is possible during login operation.
        ///
        /// When the login is done, the observe method of @observer will
        /// be called on the UI thread with a topic of "login-finished"
        /// and null data and subject.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Login([MarshalAs(UnmanagedType.Interface)] nsIObserver observer);
		
		/// <summary>
        /// The PKCS11 slot
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPKCS11Slot GetSlotAttribute();
		
		/// <summary>
        /// Gets token to be logged in name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTokenName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
	}
}
