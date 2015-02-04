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
// Generated by IDLImporter from file nsIPrintOptions.idl
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
    /// Print options interface
    ///
    /// Do not attempt to freeze this API - it still needs lots of work. Consult
    /// John Keiser <jkeiser@netscape.com> and Roland Mainz
    /// <roland.mainz@informatik.med.uni-giessen.de> for futher details.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("92597c2b-109b-40bb-8f93-9b9acfa31de8")]
	public interface nsIPrintOptions
	{
		
		/// <summary>
        /// Show Native Print Options dialog, this may not be supported on all platforms
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrintSetupDialog([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aThePrintSettings);
		
		/// <summary>
        /// Creates a new PrintSettnigs Object
        /// and initializes it from prefs
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings CreatePrintSettings();
		
		/// <summary>
        /// Get a prefixed integer pref
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrinterPrefInt([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrefName);
		
		/// <summary>
        /// display Printer Job Properties dialog
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisplayJobProperties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinter, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings, [MarshalAs(UnmanagedType.U1)] ref bool aDisplayed);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetNativeData(short aDataType);
	}
	
	/// <summary>nsIPrintOptionsConsts </summary>
	public class nsIPrintOptionsConsts
	{
		
		// <summary>
        // Native data constants
        // </summary>
		public const short kNativeDataPrintRecord = 0;
	}
	
	/// <summary>nsIPrinterEnumerator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5e738fff-404c-4c94-9189-e8f2cce93e94")]
	public interface nsIPrinterEnumerator
	{
		
		/// <summary>
        /// The name of the system default printer. This name should also be
        /// present in printerNameList below. This is not necessarily gecko's
        /// default printer; see nsIPrintSettingsService.defaultPrinterName
        /// for that.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDefaultPrinterNameAttribute();
		
		/// <summary>
        /// Initializes certain settings from the native printer into the PrintSettings
        /// These settings include, but are not limited to:
        /// Page Orientation
        /// Page Size
        /// Number of Copies
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitPrintSettingsFromPrinter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinterName, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);
		
		/// <summary>
        /// The list of printer names
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStringEnumerator GetPrinterNameListAttribute();
		
		/// <summary>
        ///takes printer selected and will display job properties dlg for that printer
        /// returns true if dialog displays
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisplayPropertiesDlg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinter, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPrintSettings);
	}
}
