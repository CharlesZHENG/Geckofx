// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIURIChecker.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIURIChecker.idl
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
	
	
	/// <summary>nsIURIChecker </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4660c1a1-be2d-4c78-9baf-c22984176c28")]
	public interface nsIURIChecker : nsIRequest
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member IsPending </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsPending();
		
		/// <summary>Member GetStatusAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetStatusAttribute();
		
		/// <summary>Member Cancel </summary>
		/// <param name='aStatus'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Cancel(System.Int32  aStatus);
		
		/// <summary>Member Suspend </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Suspend();
		
		/// <summary>Member Resume </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Resume();
		
		/// <summary>Member GetLoadGroupAttribute </summary>
		/// <returns>A nsILoadGroup </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsILoadGroup  GetLoadGroupAttribute();
		
		/// <summary>Member SetLoadGroupAttribute </summary>
		/// <param name='aLoadGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup  aLoadGroup);
		
		/// <summary>Member GetLoadFlagsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetLoadFlagsAttribute();
		
		/// <summary>Member SetLoadFlagsAttribute </summary>
		/// <param name='aLoadFlags'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadFlagsAttribute(System.UInt32  aLoadFlags);
		
		/// <summary>Member Init </summary>
		/// <param name='aURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>Member GetBaseChannelAttribute </summary>
		/// <returns>A nsIChannel </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel  GetBaseChannelAttribute();
		
		/// <summary>Member AsyncCheck </summary>
		/// <param name='aObserver'> </param>
		/// <param name='aContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncCheck([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver  aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
	}
}
