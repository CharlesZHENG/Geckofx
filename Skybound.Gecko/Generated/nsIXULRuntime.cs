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
// Generated by IDLImporter from file nsIXULRuntime.idl
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
    /// Provides information about the XUL runtime.
    /// @status UNSTABLE - This interface is not frozen and will probably change in
    /// future releases. If you need this functionality to be
    /// stable/frozen, please contact Benjamin Smedberg.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7685dac8-3637-4660-a544-928c5ec0e714")]
	public interface nsIXULRuntime
	{
		
		/// <summary>
        /// Whether the application was launched in safe mode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInSafeModeAttribute();
		
		/// <summary>
        /// Whether to write console errors to a log file. If a component
        /// encounters startup errors that might prevent the app from showing
        /// proper UI, it should set this flag to "true".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLogConsoleErrorsAttribute();
		
		/// <summary>
        /// Whether to write console errors to a log file. If a component
        /// encounters startup errors that might prevent the app from showing
        /// proper UI, it should set this flag to "true".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLogConsoleErrorsAttribute(bool aLogConsoleErrors);
		
		/// <summary>
        /// A string tag identifying the current operating system. This is taken
        /// from the OS_TARGET configure variable. It will always be available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOSAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aOS);
		
		/// <summary>
        /// A string tag identifying the binary ABI of the current processor and
        /// compiler vtable. This is taken from the TARGET_XPCOM_ABI configure
        /// variable. It may not be available on all platforms, especially
        /// unusual processor or compiler combinations.
        ///
        /// The result takes the form <processor>-<compilerABI>, for example:
        /// x86-msvc
        /// ppc-gcc3
        ///
        /// This value should almost always be used in combination with "OS".
        ///
        /// @throw NS_ERROR_NOT_AVAILABLE if not available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetXPCOMABIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aXPCOMABI);
		
		/// <summary>
        /// A string tag identifying the target widget toolkit in use.
        /// This is taken from the MOZ_WIDGET_TOOLKIT configure variable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWidgetToolkitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aWidgetToolkit);
		
		/// <summary>
        /// The type of the caller's process.  Returns one of the values above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProcessTypeAttribute();
		
		/// <summary>
        /// Signal the apprunner to invalidate caches on the next restart.
        /// This will cause components to be autoregistered and all
        /// fastload data to be re-created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateCachesOnRestart();
		
		/// <summary>
        /// Starts a child process. This method is intented to pre-start a
        /// content child process so that when it is actually needed, it is
        /// ready to go.
        ///
        /// @throw NS_ERROR_NOT_AVAILABLE if not available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnsureContentProcess();
	}
}
