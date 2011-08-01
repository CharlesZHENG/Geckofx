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
// Generated by IDLImporter from file nsIPluginInstanceOwner.idl
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
	
	
	/// <summary>nsIPluginInstanceOwner </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("17E89C1F-AE62-448E-83D5-C33FA6E07A19")]
	public interface nsIPluginInstanceOwner
	{
		
		/// <summary>
        /// Let the owner know what its instance is
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInstance(System.IntPtr aInstance);
		
		/// <summary>
        /// Get the instance associated with this owner.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetInstance();
		
		/// <summary>
        /// Get a handle to the window structure of the owner.
        /// This pointer cannot be made persistent by the caller.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWindow(System.IntPtr aWindow);
		
		/// <summary>
        /// Get the display mode for the plugin instance.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetModeAttribute();
		
		/// <summary>
        /// Create a place for the plugin to live in the owner's
        /// environment. this may or may not create a window
        /// depending on the windowless state of the plugin instance.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateWidget();
		
		/// <summary>
        /// Show a status message in the host environment.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowStatus([MarshalAs(UnmanagedType.LPStr)] string aStatusMsg);
		
		/// <summary>
        /// Get the associated document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDocumentAttribute();
		
		/// <summary>
        /// Invalidate the rectangle
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateRect(System.IntPtr aRect);
		
		/// <summary>
        /// Invalidate the region
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateRegion(System.IntPtr aRegion);
		
		/// <summary>
        /// Force a redraw
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceRedraw();
		
		/// <summary>
        /// Get NetscapeWindow, corresponds to NPNVnetscapeWindow
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNetscapeWindow(System.IntPtr aValue);
		
		/// <summary>
        /// Show native context menu
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEventModel(int eventModel);
		
		/// <summary>
        /// Call NPP_SetWindow on the plugin.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindow();
	}
}
