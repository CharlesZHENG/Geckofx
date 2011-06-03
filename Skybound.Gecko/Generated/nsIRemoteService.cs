// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIRemoteService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIRemoteService.idl
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
	
	
	/// <summary>nsIRemoteService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a2240f6a-f1e4-4548-9e1a-6f3bc9b2426c")]
	public interface nsIRemoteService
	{
		
		/// <summary>Member Startup </summary>
		/// <param name='appName'> </param>
		/// <param name='profileName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Startup([MarshalAs(UnmanagedType.LPStr)] System.String  appName, [MarshalAs(UnmanagedType.LPStr)] System.String  profileName);
		
		/// <summary>Member RegisterWindow </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow);
		
		/// <summary>Member Shutdown </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
	}
}
