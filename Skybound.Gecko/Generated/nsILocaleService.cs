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
// Generated by IDLImporter from file nsILocaleService.idl
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
    /// The Locale service interface. This is a singleton object, and should be
    /// obtained from the <tt>nsServiceManager</tt>.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c2edc848-4219-4440-abbf-98119882c83f")]
	public interface nsILocaleService
	{
		
		/// <summary>
        /// Create a new nsILocale from a locale string.
        ///
        /// @param aLocale
        /// A locale code as described in nsILocale.
        /// @return A nsILocale representing the given locale.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocale NewLocale([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocale);
		
		/// <summary>
        /// Get the user preference for locale from the operating system.
        ///
        /// @return User's OS setting for preferred locale.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocale GetSystemLocale();
		
		/// <summary>
        /// Get the user preference for locale from the operating system.
        ///
        /// NOTE: This has nothing to do with the locale used for localization of
        /// the application (UI text strings etc.). This method returns something
        /// similar to getSystemLocale.
        ///
        /// @return User's OS setting for preferred locale.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocale GetApplicationLocale();
		
		/// <summary>
        /// Get the most preferred locale from a list of locale preferences.
        ///
        /// @param acceptLanguage
        /// Locale preference in the same format as the Accept-Language HTTP
        /// header.
        /// @return The most preferred locale according to the acceptLanguage
        /// parameter.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocale GetLocaleFromAcceptLanguage([MarshalAs(UnmanagedType.LPStr)] string acceptLanguage);
		
		/// <summary>
        /// Get the user preference for locale from the operating system.
        ///
        /// NOTE: This has nothing to do with any HTTP User-Agent. This method
        /// returns the same as getSystemLocale, but as a string.
        ///
        /// @return User's OS setting for preferred locale in the format described
        /// in nsILocale.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetLocaleComponentForUserAgent();
	}
}
