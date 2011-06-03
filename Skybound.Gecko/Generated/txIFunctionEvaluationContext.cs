// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: txIFunctionEvaluationContext.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file txIFunctionEvaluationContext.idl
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
	
	
	/// <summary>txIFunctionEvaluationContext </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0ecbb00c-6a78-11d9-9791-000a95dc234c")]
	public interface txIFunctionEvaluationContext
	{
		
		/// <summary>Member GetPositionAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetPositionAttribute();
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetSizeAttribute();
		
		/// <summary>Member GetContextNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetContextNodeAttribute();
		
		/// <summary>Member GetStateAttribute </summary>
		/// <returns>A nsISupports </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports  GetStateAttribute();
	}
}
