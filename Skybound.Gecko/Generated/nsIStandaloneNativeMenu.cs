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
// Generated by IDLImporter from file nsIStandaloneNativeMenu.idl
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
    /// Platform-independent interface to platform native menu objects.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7F7201EB-510C-4CEF-BDF0-04A15A7A4A8C")]
	public interface nsIStandaloneNativeMenu
	{
		
		/// <summary>
        /// Initialize the native menu using given XUL DOM element.
        ///
        /// @param aDOMElement A XUL DOM element of tag type |menu| or |menupopup|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aDOMElement);
		
		/// <summary>
        /// This method must be called before the menu is opened and displayed to the
        /// user. It allows the platform code to update the menu and also determine
        /// whether the menu should even be shown.
        ///
        /// @return true if the menu can be shown, false if it should not be shown
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MenuWillOpen();
		
		/// <summary>
        /// The native object representing the XUL menu that was passed to Init(). On
        /// Mac OS X, this will be a NSMenu pointer, which will be retained and
        /// autoreleased when the attribute is retrieved.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetNativeMenuAttribute();
		
		/// <summary>
        /// Activate the native menu item specified by |anIndexString|. This method
        /// is intended to be used by the test suite.
        ///
        /// @param anIndexString string containing a list of indices separated by
        /// pipe ('|') characters
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActivateNativeMenuItemAt([MarshalAs(UnmanagedType.LPStruct)] nsAString anIndexString);
		
		/// <summary>
        /// Force an update of the native menu item specified by |anIndexString|. This
        /// method is intended to be used by the test suite.
        ///
        /// @param anIndexString string containing a list of indices separated by
        /// pipe ('|') characters
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceUpdateNativeMenuAt([MarshalAs(UnmanagedType.LPStruct)] nsAString anIndexString);
	}
}
