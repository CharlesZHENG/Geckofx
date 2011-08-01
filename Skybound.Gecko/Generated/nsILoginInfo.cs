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
// Generated by IDLImporter from file nsILoginInfo.idl
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
    /// An object containing information for a login stored by the
    /// password manager.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c41b7dff-6b9b-42fe-b78d-113051facb05")]
	public interface nsILoginInfo
	{
		
		/// <summary>
        /// The hostname the login applies to.
        ///
        /// The hostname should be formatted as an URL. For example,
        /// "https://site.com", "http://site.com:1234", "ftp://ftp.site.com".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname);
		
		/// <summary>
        /// The hostname the login applies to.
        ///
        /// The hostname should be formatted as an URL. For example,
        /// "https://site.com", "http://site.com:1234", "ftp://ftp.site.com".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname);
		
		/// <summary>
        /// The URL a form-based login was submitted to.
        ///
        /// For logins obtained from HTML forms, this field is the |action|
        /// attribute from the |form| element, with the path removed. For
        /// example "http://www.site.com". [Forms with no |action| attribute
        /// default to submitting to their origin URL, so we store that.]
        ///
        /// For logins obtained from a HTTP or FTP protocol authentication,
        /// this field is NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFormSubmitURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFormSubmitURL);
		
		/// <summary>
        /// The URL a form-based login was submitted to.
        ///
        /// For logins obtained from HTML forms, this field is the |action|
        /// attribute from the |form| element, with the path removed. For
        /// example "http://www.site.com". [Forms with no |action| attribute
        /// default to submitting to their origin URL, so we store that.]
        ///
        /// For logins obtained from a HTTP or FTP protocol authentication,
        /// this field is NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFormSubmitURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFormSubmitURL);
		
		/// <summary>
        /// The HTTP Realm a login was requested for.
        ///
        /// When an HTTP server sends a 401 result, the WWW-Authenticate
        /// header includes a realm to identify the "protection space." See
        /// RFC2617. If the response sent has a missing or blank realm, the
        /// hostname is used instead.
        ///
        /// For logins obtained from HTML forms, this field is NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHttpRealmAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHttpRealm);
		
		/// <summary>
        /// The HTTP Realm a login was requested for.
        ///
        /// When an HTTP server sends a 401 result, the WWW-Authenticate
        /// header includes a realm to identify the "protection space." See
        /// RFC2617. If the response sent has a missing or blank realm, the
        /// hostname is used instead.
        ///
        /// For logins obtained from HTML forms, this field is NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHttpRealmAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHttpRealm);
		
		/// <summary>
        /// The username for the login.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		/// <summary>
        /// The username for the login.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		/// <summary>
        /// The |name| attribute for the username input field.
        ///
        /// For logins obtained from a HTTP or FTP protocol authentication,
        /// this field is an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsernameFieldAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsernameField);
		
		/// <summary>
        /// The |name| attribute for the username input field.
        ///
        /// For logins obtained from a HTTP or FTP protocol authentication,
        /// this field is an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsernameFieldAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsernameField);
		
		/// <summary>
        /// The password for the login.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		/// <summary>
        /// The password for the login.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		/// <summary>
        /// The |name| attribute for the password input field.
        ///
        /// For logins obtained from a HTTP or FTP protocol authentication,
        /// this field is an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPasswordFieldAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPasswordField);
		
		/// <summary>
        /// The |name| attribute for the password input field.
        ///
        /// For logins obtained from a HTTP or FTP protocol authentication,
        /// this field is an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPasswordFieldAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPasswordField);
		
		/// <summary>
        /// Initialize a newly created nsLoginInfo object.
        ///
        /// The arguments are the fields for the new object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname, [MarshalAs(UnmanagedType.LPStruct)] nsAString aFormSubmitURL, [MarshalAs(UnmanagedType.LPStruct)] nsAString aHttpRealm, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword, [MarshalAs(UnmanagedType.LPStruct)] nsAString aUsernameField, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPasswordField);
		
		/// <summary>
        /// Test for strict equality with another nsILoginInfo object.
        ///
        /// @param aLoginInfo
        /// The other object to test.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLoginInfo);
		
		/// <summary>
        /// Test for loose equivalency with another nsILoginInfo object. The
        /// passwordField and usernameField values are ignored, and the password
        /// values may be optionally ignored. If one login's formSubmitURL is an
        /// empty string (but not null), it will be treated as a wildcard. [The
        /// blank value indicates the login was stored before bug 360493 was fixed.]
        ///
        /// @param aLoginInfo
        /// The other object to test.
        /// @param ignorePassword
        /// If true, ignore the password when checking for match.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Matches([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLoginInfo, [MarshalAs(UnmanagedType.Bool)] bool ignorePassword);
		
		/// <summary>
        /// Create an identical copy of the login, duplicating all of the login's
        /// nsILoginInfo and nsILoginMetaInfo properties.
        ///
        /// This allows code to be forwards-compatible, when additional properties
        /// are added to nsILoginMetaInfo (or nsILoginInfo) in the future.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoginInfo Clone();
	}
}
