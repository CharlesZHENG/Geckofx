// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMNSEventTarget.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMNSEventTarget.idl
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
	
	
	/// <summary>nsIDOMNSEventTarget </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c8b658d5-d583-472a-a7ec-cbc2e79f75dd")]
	public interface nsIDOMNSEventTarget
	{
		
		/// <summary>Member AddEventListener </summary>
		/// <param name='type'> </param>
		/// <param name='listener'> </param>
		/// <param name='useCapture'> </param>
		/// <param name='wantsUntrusted'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  listener, System.Boolean  useCapture, System.Boolean  wantsUntrusted);
		
		/// <summary>Member GetScriptTypeIDAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetScriptTypeIDAttribute();
		
		/// <summary>Member SetScriptTypeIDAttribute </summary>
		/// <param name='aScriptTypeID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScriptTypeIDAttribute(System.UInt32  aScriptTypeID);
	}
}
