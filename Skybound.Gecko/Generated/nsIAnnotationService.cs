// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIAnnotationService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIAnnotationService.idl
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
	
	
	/// <summary>nsIAnnotationObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("63fe98e0-6889-4c2c-ac9f-703e4bc25027")]
	public interface nsIAnnotationObserver
	{
		
		/// <summary>Member OnPageAnnotationSet </summary>
		/// <param name='aPage'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPageAnnotationSet([MarshalAs(UnmanagedType.Interface)] nsIURI  aPage, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member OnItemAnnotationSet </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAnnotationSet(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member OnPageAnnotationRemoved </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPageAnnotationRemoved([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member OnItemAnnotationRemoved </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAnnotationRemoved(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
	}
	
	/// <summary>nsIAnnotationService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ba249b58-346f-42a9-a393-203ae34ec6c4")]
	public interface nsIAnnotationService
	{
		
		/// <summary>Member SetPageAnnotation </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant  aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotation(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant  aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetPageAnnotationString </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationString </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationString(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetPageAnnotationInt32 </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, System.Int32  aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationInt32 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationInt32(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, System.Int32  aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetPageAnnotationInt64 </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, System.Int32  aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationInt64 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationInt64(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, System.Int32  aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetPageAnnotationDouble </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, double aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationDouble </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationDouble(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, double aValue, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetPageAnnotationBinary </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aData'> </param>
		/// <param name='aDataLen'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageAnnotationBinary([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, System.IntPtr  aData, System.UInt32  aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member SetItemAnnotationBinary </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aData'> </param>
		/// <param name='aDataLen'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemAnnotationBinary(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, System.IntPtr  aData, System.UInt32  aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType, System.Int32  aFlags, ushort aExpiration);
		
		/// <summary>Member GetPageAnnotation </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetPageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetItemAnnotation(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetPageAnnotationString </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetPageAnnotationString([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetItemAnnotationString </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetItemAnnotationString(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetPageAnnotationInt32 </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageAnnotationInt32([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetItemAnnotationInt32 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemAnnotationInt32(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetPageAnnotationInt64 </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPageAnnotationInt64([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetItemAnnotationInt64 </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemAnnotationInt64(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetPageAnnotationDouble </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPageAnnotationDouble([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetItemAnnotationDouble </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetItemAnnotationDouble(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetPageAnnotationBinary </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aData'> </param>
		/// <param name='aDataLen'> </param>
		/// <param name='aMimeType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageAnnotationBinary([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, out System.IntPtr  aData, out System.UInt32  aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType);
		
		/// <summary>Member GetItemAnnotationBinary </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aData'> </param>
		/// <param name='aDataLen'> </param>
		/// <param name='aMimeType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemAnnotationBinary(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, out System.IntPtr  aData, out System.UInt32  aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType);
		
		/// <summary>Member GetPageAnnotationInfo </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageAnnotationInfo([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, out System.Int32  aFlags, out ushort aExpiration, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType, out ushort aType);
		
		/// <summary>Member GetItemAnnotationInfo </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aExpiration'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemAnnotationInfo(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName, out System.Int32  aFlags, out ushort aExpiration, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType, out ushort aType);
		
		/// <summary>Member GetPageAnnotationType </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPageAnnotationType([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetItemAnnotationType </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetItemAnnotationType(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member GetPagesWithAnnotation </summary>
		/// <param name='name'> </param>
		/// <param name='resultCount'> </param>
		/// <returns>A nsIURI </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetPagesWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAString  name, out System.UInt32  resultCount);
		
		/// <summary>Member GetItemsWithAnnotation </summary>
		/// <param name='name'> </param>
		/// <param name='resultCount'> </param>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetItemsWithAnnotation([MarshalAs(UnmanagedType.LPStruct)] nsAString  name, out System.UInt32  resultCount);
		
		/// <summary>Member GetPageAnnotationNames </summary>
		/// <param name='aURI'> </param>
		/// <param name='count'> </param>
		/// <returns>A nsIVariant </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant  GetPageAnnotationNames([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, out System.UInt32  count);
		
		/// <summary>Member GetItemAnnotationNames </summary>
		/// <param name='aItemId'> </param>
		/// <param name='count'> </param>
		/// <returns>A nsIVariant </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant  GetItemAnnotationNames(System.Int32  aItemId, out System.UInt32  count);
		
		/// <summary>Member PageHasAnnotation </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PageHasAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member ItemHasAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ItemHasAnnotation(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member RemovePageAnnotation </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePageAnnotation([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member RemoveItemAnnotation </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItemAnnotation(System.Int32  aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member RemovePageAnnotations </summary>
		/// <param name='aURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>Member RemoveItemAnnotations </summary>
		/// <param name='aItemId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItemAnnotations(System.Int32  aItemId);
		
		/// <summary>Member CopyPageAnnotations </summary>
		/// <param name='aSourceURI'> </param>
		/// <param name='aDestURI'> </param>
		/// <param name='aOverwriteDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyPageAnnotations([MarshalAs(UnmanagedType.Interface)] nsIURI  aSourceURI, [MarshalAs(UnmanagedType.Interface)] nsIURI  aDestURI, System.Boolean  aOverwriteDest);
		
		/// <summary>Member CopyItemAnnotations </summary>
		/// <param name='aSourceItemId'> </param>
		/// <param name='aDestItemId'> </param>
		/// <param name='aOverwriteDest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyItemAnnotations(System.Int32  aSourceItemId, System.Int32  aDestItemId, System.Boolean  aOverwriteDest);
		
		/// <summary>Member AddObserver </summary>
		/// <param name='aObserver'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver  aObserver);
		
		/// <summary>Member RemoveObserver </summary>
		/// <param name='aObserver'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIAnnotationObserver  aObserver);
		
		/// <summary>Member GetAnnotationURI </summary>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <returns>A nsIURI</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetAnnotationURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
	}
}
