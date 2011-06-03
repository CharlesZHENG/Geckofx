// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGStylable.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGStylable.idl
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
	
	
	/// <summary>nsIDOMSVGStylable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ea8a6cb1-9176-45db-989d-d0e89f563d7e")]
	public interface nsIDOMSVGStylable
	{
		
		/// <summary>Member GetClassNameAttribute </summary>
		/// <returns>A nsIDOMSVGAnimatedString </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGAnimatedString  GetClassNameAttribute();
		
		/// <summary>Member GetStyleAttribute </summary>
		/// <returns>A nsIDOMCSSStyleDeclaration </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleDeclaration  GetStyleAttribute();
		
		/// <summary>Member GetPresentationAttribute </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMCSSValue</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSValue GetPresentationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}
}
