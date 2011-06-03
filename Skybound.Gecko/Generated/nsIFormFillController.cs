// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIFormFillController.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIFormFillController.idl
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
	
	
	/// <summary>nsIFormFillController </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("07f0a0dc-f6e9-4cdd-a55f-56d770523a4c")]
	public interface nsIFormFillController
	{
		
		/// <summary>Member AttachToBrowser </summary>
		/// <param name='docShell'> </param>
		/// <param name='popup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AttachToBrowser([MarshalAs(UnmanagedType.Interface)] nsIDocShell  docShell, [MarshalAs(UnmanagedType.Interface)] nsIAutoCompletePopup  popup);
		
		/// <summary>Member DetachFromBrowser </summary>
		/// <param name='docShell'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DetachFromBrowser([MarshalAs(UnmanagedType.Interface)] nsIDocShell  docShell);
		
		/// <summary>Member MarkAsLoginManagerField </summary>
		/// <param name='aInput'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkAsLoginManagerField([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLInputElement  aInput);
	}
}
