// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIURILoader.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIURILoader.idl
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
	
	
	/// <summary>nsIURILoader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2f7e8051-f1c9-4bcc-8584-9cfd5849e343")]
	public interface nsIURILoader
	{
		
		/// <summary>Member RegisterContentListener </summary>
		/// <param name='aContentListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentListener([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener  aContentListener);
		
		/// <summary>Member UnRegisterContentListener </summary>
		/// <param name='aContentListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnRegisterContentListener([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener  aContentListener);
		
		/// <summary>Member OpenURI </summary>
		/// <param name='aChannel'> </param>
		/// <param name='aIsContentPreferred'> </param>
		/// <param name='aWindowContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenURI([MarshalAs(UnmanagedType.Interface)] nsIChannel  aChannel, System.Boolean  aIsContentPreferred, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  aWindowContext);
		
		/// <summary>Member OpenChannel </summary>
		/// <param name='aChannel'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aWindowContext'> </param>
		/// <returns>A nsIStreamListener</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamListener OpenChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel  aChannel, System.UInt32  aFlags, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  aWindowContext);
		
		/// <summary>Member Stop </summary>
		/// <param name='aLoadCookie'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop([MarshalAs(UnmanagedType.Interface)] nsISupports  aLoadCookie);
	}
}