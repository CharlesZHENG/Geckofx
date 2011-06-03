// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGTransformList.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGTransformList.idl
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
	
	
	/// <summary>nsIDOMSVGTransformList </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cee0a9d4-8554-4bf6-bf9b-7d0cebb4269d")]
	public interface nsIDOMSVGTransformList
	{
		
		/// <summary>Member GetNumberOfItemsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNumberOfItemsAttribute();
		
		/// <summary>Member Clear </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		/// <summary>Member Initialize </summary>
		/// <param name='newItem'> </param>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform Initialize([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGTransform  newItem);
		
		/// <summary>Member GetItem </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform GetItem(System.UInt32  index);
		
		/// <summary>Member InsertItemBefore </summary>
		/// <param name='newItem'> </param>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform InsertItemBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGTransform  newItem, System.UInt32  index);
		
		/// <summary>Member ReplaceItem </summary>
		/// <param name='newItem'> </param>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform ReplaceItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGTransform  newItem, System.UInt32  index);
		
		/// <summary>Member RemoveItem </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform RemoveItem(System.UInt32  index);
		
		/// <summary>Member AppendItem </summary>
		/// <param name='newItem'> </param>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform AppendItem([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGTransform  newItem);
		
		/// <summary>Member CreateSVGTransformFromMatrix </summary>
		/// <param name='matrix'> </param>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform CreateSVGTransformFromMatrix([MarshalAs(UnmanagedType.Interface)] nsIDOMSVGMatrix  matrix);
		
		/// <summary>Member Consolidate </summary>
		/// <returns>A nsIDOMSVGTransform</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransform Consolidate();
	}
}
