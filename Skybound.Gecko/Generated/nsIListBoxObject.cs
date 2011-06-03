// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIListBoxObject.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIListBoxObject.idl
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
	
	
	/// <summary>nsIListBoxObject </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AA9DEF4E-2E59-412d-A6DF-B76F52167795")]
	public interface nsIListBoxObject
	{
		
		/// <summary>Member GetRowCount </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRowCount();
		
		/// <summary>Member GetNumberOfVisibleRows </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumberOfVisibleRows();
		
		/// <summary>Member GetIndexOfFirstVisibleRow </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIndexOfFirstVisibleRow();
		
		/// <summary>Member EnsureIndexIsVisible </summary>
		/// <param name='rowIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnsureIndexIsVisible(System.Int32  rowIndex);
		
		/// <summary>Member ScrollToIndex </summary>
		/// <param name='rowIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollToIndex(System.Int32  rowIndex);
		
		/// <summary>Member ScrollByLines </summary>
		/// <param name='numLines'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollByLines(System.Int32  numLines);
		
		/// <summary>Member GetItemAtIndex </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMElement</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetItemAtIndex(System.Int32  index);
		
		/// <summary>Member GetIndexOfItem </summary>
		/// <param name='item'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIndexOfItem([MarshalAs(UnmanagedType.Interface)] nsIDOMElement  item);
	}
}
