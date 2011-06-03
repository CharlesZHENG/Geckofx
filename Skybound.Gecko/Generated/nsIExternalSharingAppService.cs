// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIExternalSharingAppService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIExternalSharingAppService.idl
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
	
	
	/// <summary>nsISharingHandlerApp </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7111f769-53ec-41fd-b314-613661d5b6ba")]
	public interface nsISharingHandlerApp : nsIHandlerApp
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member GetDetailedDescriptionAttribute </summary>
		/// <param name='aDetailedDescription'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailedDescription);
		
		/// <summary>Member SetDetailedDescriptionAttribute </summary>
		/// <param name='aDetailedDescription'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailedDescription);
		
		/// <summary>Member Equals </summary>
		/// <param name='aHandlerApp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIHandlerApp  aHandlerApp);
		
		/// <summary>Member LaunchWithURI </summary>
		/// <param name='aURI'> </param>
		/// <param name='aWindowContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LaunchWithURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  aWindowContext);
		
		/// <summary>Member Share </summary>
		/// <param name='data'> </param>
		/// <param name='title'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Share([MarshalAs(UnmanagedType.LPStruct)] nsAString data, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
	}
	
	/// <summary>nsIExternalSharingAppService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cf7d04e5-3892-482e-81bb-073dc1c83f76")]
	public interface nsIExternalSharingAppService
	{
		
		/// <summary>Member ShareWithDefault </summary>
		/// <param name='data'> </param>
		/// <param name='mime'> </param>
		/// <param name='title'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShareWithDefault([MarshalAs(UnmanagedType.LPStruct)] nsAString data, [MarshalAs(UnmanagedType.LPStruct)] nsAString mime, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
		
		/// <summary>Member GetSharingApps </summary>
		/// <param name='aMIMEType'> </param>
		/// <param name='aLen'> </param>
		/// <returns>A nsISharingHandlerApp </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISharingHandlerApp  GetSharingApps([MarshalAs(UnmanagedType.LPStruct)] nsAString aMIMEType, out System.UInt32  aLen);
	}
}
