// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWebProgressListener2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWebProgressListener2.idl
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
	
	
	/// <summary>nsIWebProgressListener2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dde39de0-e4e0-11da-8ad9-0800200c9a66")]
	public interface nsIWebProgressListener2 : nsIWebProgressListener
	{
		
		/// <summary>Member OnStateChange </summary>
		/// <param name='aWebProgress'> </param>
		/// <param name='aRequest'> </param>
		/// <param name='aStateFlags'> </param>
		/// <param name='aStatus'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStateChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress  aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, System.UInt32  aStateFlags, System.Int32  aStatus);
		
		/// <summary>Member OnProgressChange </summary>
		/// <param name='aWebProgress'> </param>
		/// <param name='aRequest'> </param>
		/// <param name='aCurSelfProgress'> </param>
		/// <param name='aMaxSelfProgress'> </param>
		/// <param name='aCurTotalProgress'> </param>
		/// <param name='aMaxTotalProgress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnProgressChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress  aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, System.Int32  aCurSelfProgress, System.Int32  aMaxSelfProgress, System.Int32  aCurTotalProgress, System.Int32  aMaxTotalProgress);
		
		/// <summary>Member OnLocationChange </summary>
		/// <param name='aWebProgress'> </param>
		/// <param name='aRequest'> </param>
		/// <param name='aLocation'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnLocationChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress  aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsIURI  aLocation);
		
		/// <summary>Member OnStatusChange </summary>
		/// <param name='aWebProgress'> </param>
		/// <param name='aRequest'> </param>
		/// <param name='aStatus'> </param>
		/// <param name='aMessage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStatusChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress  aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, System.Int32  aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aMessage);
		
		/// <summary>Member OnSecurityChange </summary>
		/// <param name='aWebProgress'> </param>
		/// <param name='aRequest'> </param>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress  aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, System.UInt32  aState);
		
		/// <summary>Member OnProgressChange64 </summary>
		/// <param name='aWebProgress'> </param>
		/// <param name='aRequest'> </param>
		/// <param name='aCurSelfProgress'> </param>
		/// <param name='aMaxSelfProgress'> </param>
		/// <param name='aCurTotalProgress'> </param>
		/// <param name='aMaxTotalProgress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgressChange64([MarshalAs(UnmanagedType.Interface)] nsIWebProgress  aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, System.Int32  aCurSelfProgress, System.Int32  aMaxSelfProgress, System.Int32  aCurTotalProgress, System.Int32  aMaxTotalProgress);
		
		/// <summary>Member OnRefreshAttempted </summary>
		/// <param name='aWebProgress'> </param>
		/// <param name='aRefreshURI'> </param>
		/// <param name='aMillis'> </param>
		/// <param name='aSameURI'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnRefreshAttempted([MarshalAs(UnmanagedType.Interface)] nsIWebProgress  aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIURI  aRefreshURI, System.Int32  aMillis, System.Boolean  aSameURI);
	}
}
