// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIEditorMailSupport.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIEditorMailSupport.idl
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
	
	
	/// <summary>nsIEditorMailSupport </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fdf23301-4a94-11d3-9ce4-9960496c41bc")]
	public interface nsIEditorMailSupport
	{
		
		/// <summary>Member PasteAsQuotation </summary>
		/// <param name='aSelectionType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PasteAsQuotation(System.Int32  aSelectionType);
		
		/// <summary>Member InsertAsQuotation </summary>
		/// <param name='aQuotedText'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode InsertAsQuotation([MarshalAs(UnmanagedType.LPStruct)] nsAString aQuotedText);
		
		/// <summary>Member InsertTextWithQuotations </summary>
		/// <param name='aStringToInsert'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertTextWithQuotations([MarshalAs(UnmanagedType.LPStruct)] nsAString aStringToInsert);
		
		/// <summary>Member PasteAsCitedQuotation </summary>
		/// <param name='aCitation'> </param>
		/// <param name='aSelectionType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PasteAsCitedQuotation([MarshalAs(UnmanagedType.LPStruct)] nsAString aCitation, System.Int32  aSelectionType);
		
		/// <summary>Member InsertAsCitedQuotation </summary>
		/// <param name='aQuotedText'> </param>
		/// <param name='aCitation'> </param>
		/// <param name='aInsertHTML'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode InsertAsCitedQuotation([MarshalAs(UnmanagedType.LPStruct)] nsAString aQuotedText, [MarshalAs(UnmanagedType.LPStruct)] nsAString aCitation, System.Boolean  aInsertHTML);
		
		/// <summary>Member Rewrap </summary>
		/// <param name='aRespectNewlines'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Rewrap(System.Boolean  aRespectNewlines);
		
		/// <summary>Member StripCites </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StripCites();
		
		/// <summary>Member GetEmbeddedObjects </summary>
		/// <returns>A nsISupportsArray</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetEmbeddedObjects();
	}
}
