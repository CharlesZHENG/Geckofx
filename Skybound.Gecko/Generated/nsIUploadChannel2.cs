// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIUploadChannel2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIUploadChannel2.idl
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
	
	
	/// <summary>nsIUploadChannel2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8821E259-7252-4464-B874-A55D8EF6B222")]
	public interface nsIUploadChannel2
	{
		
		/// <summary>Member ExplicitSetUploadStream </summary>
		/// <param name='aStream'> </param>
		/// <param name='aContentType'> </param>
		/// <param name='aContentLength'> </param>
		/// <param name='aMethod'> </param>
		/// <param name='aStreamHasHeaders'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExplicitSetUploadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aStream, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType, System.Int32  aContentLength, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMethod, System.Boolean  aStreamHasHeaders);
	}
}