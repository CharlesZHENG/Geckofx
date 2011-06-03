// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMLSSerializer.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMLSSerializer.idl
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
	
	
	/// <summary>nsIDOMLSSerializer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("96ea4792-d362-4c28-a8c2-0337790d648a")]
	public interface nsIDOMLSSerializer
	{
		
		/// <summary>Member GetDomConfigAttribute </summary>
		/// <returns>A nsIDOMDOMConfiguration </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMConfiguration  GetDomConfigAttribute();
		
		/// <summary>Member GetNewLineAttribute </summary>
		/// <param name='aNewLine'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNewLineAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNewLine);
		
		/// <summary>Member SetNewLineAttribute </summary>
		/// <param name='aNewLine'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNewLineAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNewLine);
		
		/// <summary>Member GetFilterAttribute </summary>
		/// <returns>A nsIDOMLSSerializerFilter </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMLSSerializerFilter  GetFilterAttribute();
		
		/// <summary>Member SetFilterAttribute </summary>
		/// <param name='aFilter'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMLSSerializerFilter  aFilter);
		
		/// <summary>Member Write </summary>
		/// <param name='nodeArg'> </param>
		/// <param name='destination'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Write([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  nodeArg, [MarshalAs(UnmanagedType.Interface)] nsIDOMLSOutput  destination);
		
		/// <summary>Member WriteToURI </summary>
		/// <param name='nodeArg'> </param>
		/// <param name='uri'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool WriteToURI([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  nodeArg, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri);
		
		/// <summary>Member WriteToString </summary>
		/// <param name='nodeArg'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString WriteToString([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  nodeArg);
	}
}
