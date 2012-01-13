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
// Generated by IDLImporter from file nsIFilePicker.idl
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
	
	
	/// <summary>nsIFilePicker </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f2c0e216-5d07-4df4-bbcb-37683077ae7e")]
	public interface nsIFilePicker
	{
		
		/// <summary>
        /// Initialize the file picker widget.  The file picker is not valid until this
        /// method is called.
        ///
        /// @param      parent   nsIDOMWindow parent.  This dialog will be dependent
        /// on this parent. parent must be non-null.
        /// @param      title    The title for the file widget
        /// @param      mode     load, save, or get folder
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.LPStruct)] nsAString title, short mode);
		
		/// <summary>
        /// Append to the  filter list with things from the predefined list
        ///
        /// @param      filters  mask of filters i.e. (filterAll | filterHTML)
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendFilters(int filterMask);
		
		/// <summary>
        /// Add a filter
        ///
        /// @param      title    name of the filter
        /// @param      filter   extensions to filter -- semicolon and space separated
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendFilter([MarshalAs(UnmanagedType.LPStruct)] nsAString title, [MarshalAs(UnmanagedType.LPStruct)] nsAString filter);
		
		/// <summary>
        /// The filename that should be suggested to the user as a default. This should
        /// include the extension.
        ///
        /// @throws NS_ERROR_FAILURE on attempts to get
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDefaultString);
		
		/// <summary>
        /// The filename that should be suggested to the user as a default. This should
        /// include the extension.
        ///
        /// @throws NS_ERROR_FAILURE on attempts to get
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDefaultString);
		
		/// <summary>
        /// The extension that should be associated with files of the type we
        /// want to work with.  On some platforms, this extension will be
        /// automatically appended to filenames the user enters, if needed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDefaultExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDefaultExtension);
		
		/// <summary>
        /// The extension that should be associated with files of the type we
        /// want to work with.  On some platforms, this extension will be
        /// automatically appended to filenames the user enters, if needed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDefaultExtension);
		
		/// <summary>
        /// The filter which is currently selected in the File Picker dialog
        ///
        /// @return Returns the index (0 based) of the selected filter in the filter list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFilterIndexAttribute();
		
		/// <summary>
        /// The filter which is currently selected in the File Picker dialog
        ///
        /// @return Returns the index (0 based) of the selected filter in the filter list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterIndexAttribute(int aFilterIndex);
		
		/// <summary>
        /// Set the directory that the file open/save dialog initially displays
        ///
        /// @param      displayDirectory  the name of the directory
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetDisplayDirectoryAttribute();
		
		/// <summary>
        /// Set the directory that the file open/save dialog initially displays
        ///
        /// @param      displayDirectory  the name of the directory
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayDirectoryAttribute([MarshalAs(UnmanagedType.Interface)] nsILocalFile aDisplayDirectory);
		
		/// <summary>
        /// Get the nsILocalFile for the file or directory.
        ///
        /// @return Returns the file currently selected
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile GetFileAttribute();
		
		/// <summary>
        /// Get the nsIURI for the file or directory.
        ///
        /// @return Returns the file currently selected
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetFileURLAttribute();
		
		/// <summary>
        /// Get the enumerator for the selected files
        /// only works in the modeOpenMultiple mode
        ///
        /// @return Returns the files currently selected
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetFilesAttribute();
		
		/// <summary>
        /// Controls whether the chosen file(s) should be added to the system's recent
        /// documents list. This attribute will be ignored if the system has no "Recent
        /// Docs" concept, or if the application is in private browsing mode (in which
        /// case the file will not be added). Defaults to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAddToRecentDocsAttribute();
		
		/// <summary>
        /// Controls whether the chosen file(s) should be added to the system's recent
        /// documents list. This attribute will be ignored if the system has no "Recent
        /// Docs" concept, or if the application is in private browsing mode (in which
        /// case the file will not be added). Defaults to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAddToRecentDocsAttribute([MarshalAs(UnmanagedType.Bool)] bool aAddToRecentDocs);
		
		/// <summary>
        /// Show File Dialog. The dialog is displayed modally.
        ///
        /// @return returnOK if the user selects OK, returnCancel if the user selects cancel
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short Show();
	}
}
