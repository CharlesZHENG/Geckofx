// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMGeoGeolocation.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMGeoGeolocation.idl
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
	
	
	/// <summary>nsIDOMGeoGeolocation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("37687DAF-B85F-4E4D-8881-85A0AD24CF78")]
	public interface nsIDOMGeoGeolocation
	{
		
		/// <summary>Member GetCurrentPosition </summary>
		/// <param name='successCallback'> </param>
		/// <param name='errorCallback'> </param>
		/// <param name='options'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCurrentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionCallback  successCallback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionErrorCallback  errorCallback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionOptions  options);
		
		/// <summary>Member WatchPosition </summary>
		/// <param name='successCallback'> </param>
		/// <param name='errorCallback'> </param>
		/// <param name='options'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int WatchPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionCallback  successCallback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionErrorCallback  errorCallback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionOptions  options);
		
		/// <summary>Member ClearWatch </summary>
		/// <param name='watchId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearWatch(System.Int32  watchId);
	}
}
