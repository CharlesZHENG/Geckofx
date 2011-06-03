// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIConverterInputStream.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIConverterInputStream.idl
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
	
	
	/// <summary>nsIConverterInputStream </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("FC66FFB6-5404-4908-A4A3-27F92FA0579D")]
	public interface nsIConverterInputStream : nsIUnicharInputStream
	{
		
		/// <summary>Member Read </summary>
		/// <param name='aBuf'> </param>
		/// <param name='aCount'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint Read([MarshalAs(UnmanagedType.LPWStr, SizeParamIndex=1)] System.String  aBuf, System.UInt32  aCount);
		
		/// <summary>Member ReadSegments </summary>
		/// <param name='aWriter'> </param>
		/// <param name='aClosure'> </param>
		/// <param name='aCount'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint ReadSegments(System.IntPtr aWriter, System.IntPtr  aClosure, System.UInt32  aCount);
		
		/// <summary>Member ReadString </summary>
		/// <param name='aCount'> </param>
		/// <param name='aString'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint ReadString(System.UInt32  aCount, [MarshalAs(UnmanagedType.LPStruct)] nsAString aString);
		
		/// <summary>Member Close </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>Member Init </summary>
		/// <param name='aStream'> </param>
		/// <param name='aCharset'> </param>
		/// <param name='aBufferSize'> </param>
		/// <param name='aReplacementChar'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aStream, [MarshalAs(UnmanagedType.LPStr)] System.String  aCharset, System.Int32  aBufferSize, [MarshalAs(UnmanagedType.LPWStr)] System.String  aReplacementChar);
	}
}
