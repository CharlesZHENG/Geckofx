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
// Generated by IDLImporter from file nsIProtocolHandler.idl
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
    /// nsIProtocolHandler
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("15fd6940-8ea7-11d3-93ad-00104ba0fd40")]
	public interface nsIProtocolHandler
	{
		
		/// <summary>
        /// The scheme of this protocol (e.g., "file").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);
		
		/// <summary>
        /// The default port is the port that this protocol normally uses.
        /// If a port does not make sense for the protocol (e.g., "about:")
        /// then -1 will be returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDefaultPortAttribute();
		
		/// <summary>
        /// Returns the protocol specific flags (see flag definitions below).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProtocolFlagsAttribute();
		
		/// <summary>
        /// Makes a URI object that is suitable for loading by this protocol,
        /// where the URI string is given as an UTF-8 string.  The caller may
        /// provide the charset from which the URI string originated, so that
        /// the URI string can be translated back to that charset (if necessary)
        /// before communicating with, for example, the origin server of the URI
        /// string.  (Many servers do not support UTF-8 IRIs at the present time,
        /// so we must be careful about tracking the native charset of the origin
        /// server.)
        ///
        /// @param aSpec          - the URI string in UTF-8 encoding. depending
        /// on the protocol implementation, unicode character
        /// sequences may or may not be %xx escaped.
        /// @param aOriginCharset - the charset of the document from which this URI
        /// string originated.  this corresponds to the
        /// charset that should be used when communicating
        /// this URI to an origin server, for example.  if
        /// null, then UTF-8 encoding is assumed (i.e.,
        /// no charset transformation from aSpec).
        /// @param aBaseURI       - if null, aSpec must specify an absolute URI.
        /// otherwise, aSpec may be resolved relative
        /// to aBaseURI, depending on the protocol.
        /// If the protocol has no concept of relative
        /// URI aBaseURI will simply be ignored.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// Constructs a new channel from the given URI for this protocol handler.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannel([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Allows a protocol to override blacklisted ports.
        ///
        /// This method will be called when there is an attempt to connect to a port
        /// that is blacklisted.  For example, for most protocols, port 25 (Simple Mail
        /// Transfer) is banned.  When a URI containing this "known-to-do-bad-things"
        /// port number is encountered, this function will be called to ask if the
        /// protocol handler wants to override the ban.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AllowPort(int port, [MarshalAs(UnmanagedType.LPStr)] string scheme);
	}
	
	/// <summary>nsIProtocolHandlerConsts </summary>
	public class nsIProtocolHandlerConsts
	{
		
		// <summary>
        // standard full URI with authority component and concept of relative
        // URIs (http, ftp, ...)
        // </summary>
		public const ulong URI_STD = 0;
		
		// <summary>
        // no concept of relative URIs (about, javascript, finger, ...)
        // </summary>
		public const ulong URI_NORELATIVE = (1<<0);
		
		// <summary>
        // no authority component (file, ...)
        // </summary>
		public const ulong URI_NOAUTH = (1<<1);
		
		// <summary>
        // The URIs for this protocol have no inherent security context, so
        // documents loaded via this protocol should inherit the security context
        // from the document that loads them.
        // </summary>
		public const ulong URI_INHERITS_SECURITY_CONTEXT = (1<<4);
		
		// <summary>
        // "Automatic" loads that would replace the document (e.g. <meta> refresh,
        // certain types of XLinks, possibly other loads that the application
        // decides are not user triggered) are not allowed if the originating (NOT
        // the target) URI has this protocol flag.  Note that the decision as to
        // what constitutes an "automatic" load is made externally, by the caller
        // of nsIScriptSecurityManager::CheckLoadURI.  See documentation for that
        // method for more information.
        //
        // A typical protocol that might want to set this flag is a protocol that
        // shows highly untrusted content in a viewing area that the user expects
        // to have a lot of control over, such as an e-mail reader.
        // </summary>
		public const ulong URI_FORBIDS_AUTOMATIC_DOCUMENT_REPLACEMENT = (1<<5);
		
		// <summary>
        // The URIs for this protocol can be loaded by anyone.  For example, any
        // website should be allowed to trigger a load of a URI for this protocol.
        // Web-safe protocols like "http" should set this flag.
        // </summary>
		public const ulong URI_LOADABLE_BY_ANYONE = (1<<6);
		
		// <summary>
        // The URIs for this protocol are UNSAFE if loaded by untrusted (web)
        // content and may only be loaded by privileged code (for example, code
        // which has the system principal).  Various internal protocols should set
        // this flag.
        // </summary>
		public const ulong URI_DANGEROUS_TO_LOAD = (1<<7);
		
		// <summary>
        // The URIs for this protocol point to resources that are part of the
        // application's user interface.  There are cases when such resources may
        // be made accessible to untrusted content such as web pages, so this is
        // less restrictive than URI_DANGEROUS_TO_LOAD but more restrictive than
        // URI_LOADABLE_BY_ANYONE.  See the documentation for
        // nsIScriptSecurityManager::CheckLoadURI.
        // </summary>
		public const ulong URI_IS_UI_RESOURCE = (1<<8);
		
		// <summary>
        // Loading of URIs for this protocol from other origins should only be
        // allowed if those origins should have access to the local filesystem.
        // It's up to the application to decide what origins should have such
        // access.  Protocols like "file" that point to local data should set this
        // flag.
        // </summary>
		public const ulong URI_IS_LOCAL_FILE = (1<<9);
		
		// <summary>
        // The URIs for this protocol can be loaded only by callers with a
        // principal that subsumes this uri. For example, privileged code and
        // websites that are same origin as this uri.
        // </summary>
		public const ulong URI_LOADABLE_BY_SUBSUMERS = (1<<14);
		
		// <summary>
        // Loading channels from this protocol has side-effects that make
        // it unsuitable for saving to a local file.
        // </summary>
		public const ulong URI_NON_PERSISTABLE = (1<<10);
		
		// <summary>
        // Channels using this protocol never call OnDataAvailable
        // on the listener passed to AsyncOpen and they therefore
        // do not return any data that we can use.
        // </summary>
		public const ulong URI_DOES_NOT_RETURN_DATA = (1<<11);
		
		// <summary>
        // URIs for this protocol are considered to be local resources.  This could
        // be a local file (URI_IS_LOCAL_FILE), a UI resource (URI_IS_UI_RESOURCE),
        // or something else that would not hit the network.
        // </summary>
		public const ulong URI_IS_LOCAL_RESOURCE = (1<<12);
		
		// <summary>
        // URIs for this protocol execute script when they are opened.
        // </summary>
		public const ulong URI_OPENING_EXECUTES_SCRIPT = (1<<13);
		
		// <summary>
        // Channels for this protocol don't need to spin the event loop to handle
        // Open() and reads on the resulting stream.
        // </summary>
		public const ulong URI_SYNC_LOAD_IS_OK = (1<<15);
		
		// <summary>
        // This protocol handler can be proxied via a proxy (socks or http)
        // (e.g., irc, smtp, http, etc.).  If the protocol supports transparent
        // proxying, the handler should implement nsIProxiedProtocolHandler.
        //
        // If it supports only HTTP proxying, then it need not support
        // nsIProxiedProtocolHandler, but should instead set the ALLOWS_PROXY_HTTP
        // flag (see below).
        //
        // @see nsIProxiedProtocolHandler
        // </summary>
		public const ulong ALLOWS_PROXY = (1<<2);
		
		// <summary>
        // This protocol handler can be proxied using a http proxy (e.g., http,
        // ftp, etc.).  nsIIOService::newChannelFromURI will feed URIs from this
        // protocol handler to the HTTP protocol handler instead.  This flag is
        // ignored if ALLOWS_PROXY is not set.
        // </summary>
		public const ulong ALLOWS_PROXY_HTTP = (1<<3);
		
		// <summary>
        // This protocol handler forbids accessing cookies e.g. for mail related
        // protocols.
        // </summary>
		public const ulong URI_FORBIDS_COOKIE_ACCESS = (1<<15);
	}
}
