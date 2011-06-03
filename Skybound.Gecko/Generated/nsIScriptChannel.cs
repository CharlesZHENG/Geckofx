// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIScriptChannel.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIScriptChannel.idl
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
	
	
	/// <summary>nsIScriptChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("33234b99-9588-4c7d-9da6-86b8b7cba565")]
	public interface nsIScriptChannel
	{
		
		/// <summary>Member GetExecutionPolicyAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetExecutionPolicyAttribute();
		
		/// <summary>Member SetExecutionPolicyAttribute </summary>
		/// <param name='aExecutionPolicy'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetExecutionPolicyAttribute(System.UInt32  aExecutionPolicy);
		
		/// <summary>Member GetExecuteAsyncAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetExecuteAsyncAttribute();
		
		/// <summary>Member SetExecuteAsyncAttribute </summary>
		/// <param name='aExecuteAsync'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetExecuteAsyncAttribute(System.Boolean  aExecuteAsync);
	}
}
