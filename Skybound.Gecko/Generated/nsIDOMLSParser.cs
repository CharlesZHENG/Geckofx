// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMLSParser.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMLSParser.idl
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
	
	
	/// <summary>nsIDOMLSParser </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2a31a3a0-be68-40af-9f64-914192f0fba2")]
	public interface nsIDOMLSParser
	{
		
		/// <summary>Member GetDomConfigAttribute </summary>
		/// <returns>A nsIDOMDOMConfiguration </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMConfiguration  GetDomConfigAttribute();
		
		/// <summary>Member GetFilterAttribute </summary>
		/// <returns>A nsIDOMLSParserFilter </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMLSParserFilter  GetFilterAttribute();
		
		/// <summary>Member SetFilterAttribute </summary>
		/// <param name='aFilter'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMLSParserFilter  aFilter);
		
		/// <summary>Member GetAsyncAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAsyncAttribute();
		
		/// <summary>Member GetBusyAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetBusyAttribute();
		
		/// <summary>Member Parse </summary>
		/// <param name='input'> </param>
		/// <returns>A nsIDOMDocument</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument Parse([MarshalAs(UnmanagedType.Interface)] nsIDOMLSInput  input);
		
		/// <summary>Member ParseURI </summary>
		/// <param name='uri'> </param>
		/// <returns>A nsIDOMDocument</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument ParseURI([MarshalAs(UnmanagedType.LPStruct)] nsAString uri);
		
		/// <summary>Member ParseWithContext </summary>
		/// <param name='input'> </param>
		/// <param name='contextArg'> </param>
		/// <param name='action'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ParseWithContext([MarshalAs(UnmanagedType.Interface)] nsIDOMLSInput  input, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  contextArg, ushort action);
		
		/// <summary>Member Abort </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Abort();
	}
}
