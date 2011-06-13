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
// Generated by IDLImporter from file nsILoadContext.idl
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
    /// An nsILoadContext represents the context of a load.  This interface
    /// can be queried for various information about where the load is
    /// happening.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("314d8a54-1caf-4721-94d7-f6c82d9b82ed")]
	public interface nsILoadContext
	{
		
		/// <summary>
        /// associatedWindow is the window with which the load is associated, if any.
        /// Note that the load may be triggered by a document which is different from
        /// the document in associatedWindow, and in fact the source of the load need
        /// not be same-origin with the document in associatedWindow.  This attribute
        /// may be null if there is no associated window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetAssociatedWindowAttribute();
		
		/// <summary>
        /// topWindow is the top window which is of same type as associatedWindow.
        /// This is equivalent to associatedWindow.top, but is provided here as a
        /// convenience.  All the same caveats as associatedWindow of apply, of
        /// course.  This attribute may be null if there is no associated window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetTopWindowAttribute();
		
		/// <summary>
        /// Check whether the load is happening in a particular type of application.
        ///
        /// @param an application type.  For now, the constants to be passed here are
        /// the nsIDocShell APP_TYPE_* constants.
        ///
        /// @return whether there is some ancestor of the associatedWindow that is of
        /// the given app type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsAppOfType(uint appType);
		
		/// <summary>
        /// True if the load context is content (as opposed to chrome).  This is
        /// determined based on the type of window the load is performed in, NOT based
        /// on any URIs that might be around.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsContentAttribute();
	}
}
