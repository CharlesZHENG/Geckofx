// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsITraceRefcnt.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsITraceRefcnt.idl
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
	
	
	/// <summary>nsITraceRefcnt </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("273dc92f-0fe6-4545-96a9-21be77828039")]
	public interface nsITraceRefcnt
	{
		
		/// <summary>Member LogAddRef </summary>
		/// <param name='aPtr'> </param>
		/// <param name='aNewRefcnt'> </param>
		/// <param name='aTypeName'> </param>
		/// <param name='aInstanceSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogAddRef(System.IntPtr  aPtr, System.Int32  aNewRefcnt, [MarshalAs(UnmanagedType.LPStr)] System.String  aTypeName, System.UInt32  aInstanceSize);
		
		/// <summary>Member LogRelease </summary>
		/// <param name='aPtr'> </param>
		/// <param name='aNewRefcnt'> </param>
		/// <param name='aTypeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogRelease(System.IntPtr  aPtr, System.Int32  aNewRefcnt, [MarshalAs(UnmanagedType.LPStr)] System.String  aTypeName);
		
		/// <summary>Member LogCtor </summary>
		/// <param name='aPtr'> </param>
		/// <param name='aTypeName'> </param>
		/// <param name='aInstanceSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogCtor(System.IntPtr  aPtr, [MarshalAs(UnmanagedType.LPStr)] System.String  aTypeName, System.UInt32  aInstanceSize);
		
		/// <summary>Member LogDtor </summary>
		/// <param name='aPtr'> </param>
		/// <param name='aTypeName'> </param>
		/// <param name='aInstanceSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogDtor(System.IntPtr  aPtr, [MarshalAs(UnmanagedType.LPStr)] System.String  aTypeName, System.UInt32  aInstanceSize);
		
		/// <summary>Member LogAddCOMPtr </summary>
		/// <param name='aPtr'> </param>
		/// <param name='aObject'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogAddCOMPtr(System.IntPtr  aPtr, [MarshalAs(UnmanagedType.Interface)] nsISupports  aObject);
		
		/// <summary>Member LogReleaseCOMPtr </summary>
		/// <param name='aPtr'> </param>
		/// <param name='aObject'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogReleaseCOMPtr(System.IntPtr  aPtr, [MarshalAs(UnmanagedType.Interface)] nsISupports  aObject);
	}
}
