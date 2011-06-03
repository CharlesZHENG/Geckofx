// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIHttpAuthenticableChannel.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIHttpAuthenticableChannel.idl
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
	
	
	/// <summary>nsIHttpAuthenticableChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("701093ac-5c7f-429c-99e3-423b041fccb4")]
	public interface nsIHttpAuthenticableChannel : nsIProxiedChannel
	{
		
		/// <summary>Member GetProxyInfoAttribute </summary>
		/// <returns>A nsIProxyInfo </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIProxyInfo  GetProxyInfoAttribute();
		
		/// <summary>Member GetIsSSLAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsSSLAttribute();
		
		/// <summary>Member GetProxyMethodIsConnectAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetProxyMethodIsConnectAttribute();
		
		/// <summary>Member Cancel </summary>
		/// <param name='aStatus'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(System.Int32  aStatus);
		
		/// <summary>Member GetLoadFlagsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLoadFlagsAttribute();
		
		/// <summary>Member GetURIAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetURIAttribute();
		
		/// <summary>Member GetLoadGroupAttribute </summary>
		/// <returns>A nsILoadGroup </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup  GetLoadGroupAttribute();
		
		/// <summary>Member GetNotificationCallbacksAttribute </summary>
		/// <returns>A nsIInterfaceRequestor </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceRequestor  GetNotificationCallbacksAttribute();
		
		/// <summary>Member GetRequestMethodAttribute </summary>
		/// <param name='aRequestMethod'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aRequestMethod);
		
		/// <summary>Member GetServerResponseHeaderAttribute </summary>
		/// <param name='aServerResponseHeader'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetServerResponseHeaderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aServerResponseHeader);
		
		/// <summary>Member GetProxyChallengesAttribute </summary>
		/// <param name='aProxyChallenges'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProxyChallengesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aProxyChallenges);
		
		/// <summary>Member GetWWWChallengesAttribute </summary>
		/// <param name='aWWWChallenges'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWWWChallengesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aWWWChallenges);
		
		/// <summary>Member SetProxyCredentials </summary>
		/// <param name='credentials'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProxyCredentials([MarshalAs(UnmanagedType.LPStruct)] nsAString  credentials);
		
		/// <summary>Member SetWWWCredentials </summary>
		/// <param name='credentials'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWWWCredentials([MarshalAs(UnmanagedType.LPStruct)] nsAString  credentials);
		
		/// <summary>Member OnAuthAvailable </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthAvailable();
		
		/// <summary>Member OnAuthCancelled </summary>
		/// <param name='userCancel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthCancelled(System.Boolean  userCancel);
	}
}
