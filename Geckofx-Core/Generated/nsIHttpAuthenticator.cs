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
// Generated by IDLImporter from file nsIHttpAuthenticator.idl
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
    /// nsIHttpAuthenticator
    ///
    /// Interface designed to allow for pluggable HTTP authentication modules.
    /// Implementations are registered under the ContractID:
    ///
    /// "@mozilla.org/network/http-authenticator;1?scheme=<auth-scheme>"
    ///
    /// where <auth-scheme> is the lower-cased value of the authentication scheme
    /// found in the server challenge per the rules of RFC 2617.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("16784db0-fcb1-4352-b0c9-6a3a67e3cf79")]
	public interface nsIHttpAuthenticator
	{
		
		/// <summary>
        /// Upon receipt of a server challenge, this function is called to determine
        /// whether or not the current user identity has been rejected.  If true,
        /// then the user will be prompted by the channel to enter (or revise) their
        /// identity.  Following this, generateCredentials will be called.
        ///
        /// If the IDENTITY_IGNORED auth flag is set, then the aInvalidateIdentity
        /// return value will be ignored, and user prompting will be suppressed.
        ///
        /// @param aChannel
        /// the http channel that received the challenge.
        /// @param aChallenge
        /// the challenge from the WWW-Authenticate/Proxy-Authenticate
        /// server response header.  (possibly from the auth cache.)
        /// @param aProxyAuth
        /// flag indicating whether or not aChallenge is from a proxy.
        /// @param aSessionState
        /// see description below for generateCredentials.
        /// @param aContinuationState
        /// see description below for generateCredentials.
        /// @param aInvalidateIdentity
        /// return value indicating whether or not to prompt the user for a
        /// revised identity.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChallengeReceived([MarshalAs(UnmanagedType.Interface)] nsIHttpAuthenticableChannel aChannel, [MarshalAs(UnmanagedType.LPStr)] string aChallenge, [MarshalAs(UnmanagedType.U1)] bool aProxyAuth, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSessionState, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aContinuationState, [MarshalAs(UnmanagedType.U1)] ref bool aInvalidatesIdentity);
		
		/// <summary>
        /// Called to generate the authentication credentials for a particular
        /// server/proxy challenge.  This is the value that will be sent back
        /// to the server via an Authorization/Proxy-Authorization header.
        ///
        /// This function may be called using a cached challenge provided the
        /// authenticator sets the REUSABLE_CHALLENGE flag.
        ///
        /// @param aChannel
        /// the http channel requesting credentials
        /// @param aChallenge
        /// the challenge from the WWW-Authenticate/Proxy-Authenticate
        /// server response header.  (possibly from the auth cache.)
        /// @param aProxyAuth
        /// flag indicating whether or not aChallenge is from a proxy.
        /// @param aDomain
        /// string containing the domain name (if appropriate)
        /// @param aUser
        /// string containing the user name
        /// @param aPassword
        /// string containing the password
        /// @param aSessionState
        /// state stored along side the user's identity in the auth cache
        /// for the lifetime of the browser session.  if a new auth cache
        /// entry is created for this challenge, then this parameter will
        /// be null.  on return, the result will be stored in the new auth
        /// cache entry.  this parameter is non-null when an auth cache entry
        /// is being reused.
        /// @param aContinuationState
        /// state held by the channel between consecutive calls to
        /// generateCredentials, assuming multiple calls are required
        /// to authenticate.  this state is held for at most the lifetime of
        /// the channel.
        /// @param aFlags
        /// authenticator may return one of the generate flags bellow.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GenerateCredentials([MarshalAs(UnmanagedType.Interface)] nsIHttpAuthenticableChannel aChannel, [MarshalAs(UnmanagedType.LPStr)] string aChallenge, [MarshalAs(UnmanagedType.U1)] bool aProxyAuth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDomain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aUser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPassword, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aSessionState, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aContinuationState, ref uint aFlags);
		
		/// <summary>
        /// Flags defining various properties of the authenticator.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAuthFlagsAttribute();
	}
	
	/// <summary>nsIHttpAuthenticatorConsts </summary>
	public class nsIHttpAuthenticatorConsts
	{
		
		// <summary>
        // Indicates that the authenticator has used an out-of-band or internal
        // source of identity and tells the consumer that it must not cache
        // the returned identity because it might not be valid and would overwrite
        // the cached identity.  See bug 542318 comment 32.
        // </summary>
		public const ulong USING_INTERNAL_IDENTITY = (1<<0);
		
		// <summary>
        // A request based authentication scheme only authenticates an individual
        // request (or a set of requests under the same authentication domain as
        // defined by RFC 2617).  BASIC and DIGEST are request based authentication
        // schemes.
        // </summary>
		public const ulong REQUEST_BASED = (1<<0);
		
		// <summary>
        // A connection based authentication scheme authenticates an individual
        // connection.  Multiple requests may be issued over the connection without
        // repeating the authentication steps.  Connection based authentication
        // schemes can associate state with the connection being authenticated via
        // the aContinuationState parameter (see generateCredentials).
        // </summary>
		public const ulong CONNECTION_BASED = (1<<1);
		
		// <summary>
        // The credentials returned from generateCredentials may be reused with any
        // other URLs within "the protection space" as defined by RFC 2617 section
        // 1.2.  If this flag is not set, then generateCredentials must be called
        // for each request within the protection space.  REUSABLE_CREDENTIALS
        // implies REUSABLE_CHALLENGE.
        // </summary>
		public const ulong REUSABLE_CREDENTIALS = (1<<2);
		
		// <summary>
        // A challenge may be reused to later generate credentials in anticipation
        // of a duplicate server challenge for URLs within "the protection space"
        // as defined by RFC 2617 section 1.2.
        // </summary>
		public const ulong REUSABLE_CHALLENGE = (1<<3);
		
		// <summary>
        // This flag indicates that the identity of the user is not required by
        // this authentication scheme.
        // </summary>
		public const ulong IDENTITY_IGNORED = (1<<10);
		
		// <summary>
        // This flag indicates that the identity of the user includes a domain
        // attribute that the user must supply.
        // </summary>
		public const ulong IDENTITY_INCLUDES_DOMAIN = (1<<11);
		
		// <summary>
        // This flag indicates that the identity will be sent encrypted. It does
        // not make sense to combine this flag with IDENTITY_IGNORED.
        // </summary>
		public const ulong IDENTITY_ENCRYPTED = (1<<12);
	}
}
