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
// Generated by IDLImporter from file amIWebInstallListener.idl
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
    /// amIWebInstallInfo is used by the default implementation of
    /// amIWebInstallListener to communicate with the running application and allow
    /// it to warn the user about blocked installs and start the installs running.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8710e692-3989-4dc7-b607-40d57610ae75")]
	public interface amIWebInstallInfo
	{
		
		/// <summary>
        /// amIWebInstallInfo is used by the default implementation of
        /// amIWebInstallListener to communicate with the running application and allow
        /// it to warn the user about blocked installs and start the installs running.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetOriginatingWindowAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetOriginatingURIAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetInstallsAttribute();
		
		/// <summary>
        /// Starts all installs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Install();
	}
	
	/// <summary>
    /// The registered amIWebInstallListener is used to notify about new installs
    /// triggered by websites. The default implementation displays a confirmation
    /// dialog when add-ons are ready to install and uses the observer service to
    /// notify when installations are blocked.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a5503979-89c8-441e-9e4a-321df379c172")]
	public interface amIWebInstallListener
	{
		
		/// <summary>
        /// Called when installation by websites is currently disabled.
        ///
        /// @param  aWindow
        /// The window that triggered the installs
        /// @param  aUri
        /// The URI of the site that triggered the installs
        /// @param  aInstalls
        /// The AddonInstalls that were blocked
        /// @param  aCount
        /// The number of AddonInstalls
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnWebInstallDisabled([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI aUri, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] nsIVariant[] aInstalls, uint aCount);
		
		/// <summary>
        /// Called when the website is not allowed to directly prompt the user to
        /// install add-ons.
        ///
        /// @param  aWindow
        /// The window that triggered the installs
        /// @param  aUri
        /// The URI of the site that triggered the installs
        /// @param  aInstalls
        /// The AddonInstalls that were blocked
        /// @param  aCount
        /// The number of AddonInstalls
        /// @return true if the caller should start the installs
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnWebInstallBlocked([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI aUri, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] nsIVariant[] aInstalls, uint aCount);
		
		/// <summary>
        /// Called when a website wants to ask the user to install add-ons.
        ///
        /// @param  aWindow
        /// The window that triggered the installs
        /// @param  aUri
        /// The URI of the site that triggered the installs
        /// @param  aInstalls
        /// The AddonInstalls that were requested
        /// @param  aCount
        /// The number of AddonInstalls
        /// @return true if the caller should start the installs
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnWebInstallRequested([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI aUri, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] nsIVariant[] aInstalls, uint aCount);
	}
	
	/// <summary>
    /// amIWebInstallPrompt is used, if available, by the default implementation of
    /// amIWebInstallInfo to display a confirmation UI to the user before running
    /// installs.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c5529918-4291-4b56-bd46-e9268900f2a3")]
	public interface amIWebInstallPrompt
	{
		
		/// <summary>
        /// Get a confirmation that the user wants to start the installs.
        ///
        /// @param  aWindow
        /// The window that triggered the installs
        /// @param  aUri
        /// The URI of the site that triggered the installs
        /// @param  aInstalls
        /// The AddonInstalls that were requested
        /// @param  aCount
        /// The number of AddonInstalls
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Confirm([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI aUri, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] nsIVariant[] aInstalls, uint aCount);
	}
}
