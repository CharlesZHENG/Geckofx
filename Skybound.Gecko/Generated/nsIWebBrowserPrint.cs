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
// Generated by IDLImporter from file nsIWebBrowserPrint.idl
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
    /// nsIWebBrowserPrint corresponds to the main interface
    /// for printing an embedded Gecko web browser window/document
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9A7CA4B0-FBBA-11d4-A869-00105A183419")]
	public interface nsIWebBrowserPrint
	{
		
		/// <summary>
        /// Returns a "global" PrintSettings object
        /// Creates a new the first time, if one doesn't exist.
        ///
        /// Then returns the same object each time after that.
        ///
        /// Initializes the globalPrintSettings from the default printer
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings GetGlobalPrintSettingsAttribute();
		
		/// <summary>
        /// Returns a pointer to the PrintSettings object that
        /// that was passed into either "print" or "print preview"
        ///
        /// This enables any consumers of the interface to have access
        /// to the "current" PrintSetting at later points in the execution
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings GetCurrentPrintSettingsAttribute();
		
		/// <summary>
        /// Returns a pointer to the current child DOMWindow
        /// that is being print previewed. (FrameSet Frames)
        ///
        /// Returns null if parent document is not a frameset or the entire FrameSet
        /// document is being print previewed
        ///
        /// This enables any consumers of the interface to have access
        /// to the "current" child DOMWindow at later points in the execution
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetCurrentChildDOMWindowAttribute();
		
		/// <summary>
        /// Returns whether it is in Print mode
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDoingPrintAttribute();
		
		/// <summary>
        /// Returns whether it is in Print Preview mode
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDoingPrintPreviewAttribute();
		
		/// <summary>
        /// This returns whether the current document is a frameset document
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFramesetDocumentAttribute();
		
		/// <summary>
        /// This returns whether the current document is a frameset document
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFramesetFrameSelectedAttribute();
		
		/// <summary>
        /// This returns whether there is an IFrame selected
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsIFrameSelectedAttribute();
		
		/// <summary>
        /// This returns whether there is a "range" selection
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsRangeSelectionAttribute();
		
		/// <summary>
        /// This returns the total number of pages for the Print Preview
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintPreviewNumPagesAttribute();
		
		/// <summary>
        /// Print the specified DOM window
        ///
        /// @param aThePrintSettings - Printer Settings for the print job, if aThePrintSettings is null
        /// then the global PS will be used.
        /// @param aWPListener - is updated during the print
        /// @return void
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Print([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aWPListener);
		
		/// <summary>
        /// Print Preview the specified DOM window
        ///
        /// @param aThePrintSettings - Printer Settings for the print preview, if aThePrintSettings is null
        /// then the global PS will be used.
        /// @param aChildDOMWin - DOM Window to be print previewed.
        /// @param aWPListener - is updated during the printpreview
        /// @return void
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreview([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aChildDOMWin, [MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aWPListener);
		
		/// <summary>
        /// Print Preview - Navigates within the window
        ///
        /// @param aNavType - navigation enum
        /// @param aPageNum - page num to navigate to when aNavType = ePrintPreviewGoToPageNum
        /// @return void
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreviewNavigate(short aNavType, int aPageNum);
		
		/// <summary>
        /// Cancels the current print
        /// @return void
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel();
		
		/// <summary>
        /// Returns an array of the names of all documents names (Title or URL)
        /// and sub-documents. This will return a single item if the attr "isFramesetDocument" is false
        /// and may return any number of items is "isFramesetDocument" is true
        ///
        /// @param  aCount - returns number of printers returned
        /// @param  aResult - returns array of names
        /// @return void
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnumerateDocumentNames(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] aResult);
		
		/// <summary>
        /// This exists PrintPreview mode and returns browser window to galley mode
        /// @return void
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExitPrintPreview();
	}
	
	/// <summary>nsIWebBrowserPrintConsts </summary>
	public class nsIWebBrowserPrintConsts
	{
		
		// <summary>
        // PrintPreview Navigation Constants
        // </summary>
		public const int PRINTPREVIEW_GOTO_PAGENUM = 0;
		
		// 
		public const int PRINTPREVIEW_PREV_PAGE = 1;
		
		// 
		public const int PRINTPREVIEW_NEXT_PAGE = 2;
		
		// 
		public const int PRINTPREVIEW_HOME = 3;
		
		// 
		public const int PRINTPREVIEW_END = 4;
	}
}
