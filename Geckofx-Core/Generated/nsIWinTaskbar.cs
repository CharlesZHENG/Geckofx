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
// Generated by IDLImporter from file nsIWinTaskbar.idl
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
    /// nsIWinTaskbar
    ///
    /// This interface represents a service which exposes the APIs provided by the
    /// Windows taskbar to applications.
    ///
    /// Starting in Windows 7, applications gain some control over their appearance
    /// in the taskbar. By default, there is one taskbar preview per top level
    /// window (excluding popups). This preview is represented by an
    /// nsITaskbarWindowPreview object.
    ///
    /// An application can register its own "tab" previews. Such previews will hide
    /// the corresponding nsITaskbarWindowPreview automatically (though this is not
    /// reflected in the visible attribute of the nsITaskbarWindowPreview). These
    /// tab previews do not have to correspond to tabs in the application - they can
    /// vary in size, shape and location. They do not even need to be actual GUI
    /// elements on the window. Unlike window previews, tab previews require most of
    /// the functionality of the nsITaskbarPreviewController to be implemented.
    ///
    /// Applications can also show progress on their taskbar icon. This does not
    /// interact with the taskbar previews except if the nsITaskbarWindowPreview is
    /// made invisible in which case the progress is naturally not shown on that
    /// window.
    ///
    /// When taskbar icons are combined as is the default in Windows 7, the progress
    /// for those windows is also combined as defined here:
    /// http://msdn.microsoft.com/en-us/library/dd391697%28VS.85%29.aspx
    ///
    /// Applications may also define custom taskbar jump lists on application shortcuts.
    /// See nsIJumpListBuilder for more information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3232f40a-e94b-432d-9496-096abf1387bd")]
	public interface nsIWinTaskbar
	{
		
		/// <summary>
        /// Returns true if the operating system supports Win7+ taskbar features.
        /// This property acts as a replacement for in-place os version checking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAvailableAttribute();
		
		/// <summary>
        /// Returns the default application user model identity the application
        /// registers with the system. This id is used by the taskbar in grouping
        /// windows and in associating pinned shortcuts with running instances and
        /// jump lists.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultGroupIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultGroupId);
		
		/// <summary>
        /// Creates a taskbar preview. The docshell should be a toplevel docshell and
        /// is used to find the toplevel window. See the documentation for
        /// nsITaskbarTabPreview for more information.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITaskbarTabPreview CreateTaskbarTabPreview([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell, [MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewController controller);
		
		/// <summary>
        /// Gets the taskbar preview for a window. The docshell is used to find the
        /// toplevel window. See the documentation for nsITaskbarTabPreview for more
        /// information.
        ///
        /// Note: to implement custom drawing or buttons, a controller is required.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITaskbarWindowPreview GetTaskbarWindowPreview([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell);
		
		/// <summary>
        /// Gets the taskbar progress for a window. The docshell is used to find the
        /// toplevel window. See the documentation for nsITaskbarProgress for more
        /// information.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITaskbarProgress GetTaskbarProgress([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell);
		
		/// <summary>
        /// Gets the taskbar icon overlay controller for a window. The docshell is used
        /// to find the toplevel window. See the documentation in
        /// nsITaskbarOverlayIconController for more details.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITaskbarOverlayIconController GetOverlayIconController([MarshalAs(UnmanagedType.Interface)] nsIDocShell shell);
		
		/// <summary>
        /// Retrieve a taskbar jump list builder
        ///
        /// Fails if a jump list build operation has already been initiated, developers
        /// should make use of a single instance of nsIJumpListBuilder for building lists
        /// within an application.
        ///
        /// @throw NS_ERROR_ALREADY_INITIALIZED if an nsIJumpListBuilder instance is
        /// currently building a list.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIJumpListBuilder CreateJumpListBuilder();
		
		/// <summary>
        /// Set the grouping id for a window.
        ///
        /// The runtime sets a default, global grouping id for all windows on startup.
        /// setGroupIdForWindow allows individual windows to be grouped independently
        /// on the taskbar. Ids should be unique to the app and window to insure
        /// conflicts with other pinned applications do no arise.
        ///
        /// The default group id is based on application.ini vendor, application, and
        /// version values, with a format of 'vendor.app.version'. The default can be
        /// retrieved via defaultGroupId.
        ///
        /// Note, when a window changes taskbar window stacks, it is placed at the
        /// bottom of the new stack.
        ///
        /// @throw NS_ERROR_INVALID_ARG if the window is not a valid top level window
        /// associated with a widget.
        /// @throw NS_ERROR_FAILURE if the property on the window could not be set.
        /// @throw NS_ERROR_UNEXPECTED for general failures.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGroupIdForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aIdentifier);
		
		/// <summary>
        /// Notify the taskbar that a window is about to enter full screen mode.
        ///
        /// A Windows autohide taskbar will not behave correctly in all cases if
        /// it is not notified when full screen operations start and end.
        ///
        /// @throw NS_ERROR_INVALID_ARG if the window is not a valid top level window
        /// @throw NS_ERROR_UNEXPECTED for general failures.
        /// @throw NS_ERROR_NOT_AVAILABLE if the taskbar cannot be obtained.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrepareFullScreen([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.U1)] bool aFullScreen);
		
		/// <summary>
        /// Notify the taskbar that a window identified by its HWND is about to enter
        /// full screen mode.
        ///
        /// A Windows autohide taskbar will not behave correctly in all cases if
        /// it is not notified when full screen operations start and end.
        ///
        /// @throw NS_ERROR_INVALID_ARG if the window is not a valid top level window
        /// @throw NS_ERROR_UNEXPECTED for general failures.
        /// @throw NS_ERROR_NOT_AVAILABLE if the taskbar cannot be obtained.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrepareFullScreenHWND(System.IntPtr aWindow, [MarshalAs(UnmanagedType.U1)] bool aFullScreen);
	}
}
