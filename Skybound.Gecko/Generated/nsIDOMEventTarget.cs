// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMEventTarget.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMEventTarget.idl
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
	
	
	/// <summary>nsIDOMEventTarget </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1c773b30-d1cf-11d2-bd95-00805f8ae3f4")]
	public interface nsIDOMEventTarget
	{
		
		/// <summary>Member AddEventListener </summary>
		/// <param name='type'> </param>
		/// <param name='listener'> </param>
		/// <param name='useCapture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  listener, System.Boolean  useCapture);
		
		/// <summary>Member RemoveEventListener </summary>
		/// <param name='type'> </param>
		/// <param name='listener'> </param>
		/// <param name='useCapture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  listener, System.Boolean  useCapture);
		
		/// <summary>Member DispatchEvent </summary>
		/// <param name='evt'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent  evt);
	}
}