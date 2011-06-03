// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: txIEXSLTRegExFunctions.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file txIEXSLTRegExFunctions.idl
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
	
	
	/// <summary>txIEXSLTRegExFunctions </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c180e993-aced-4839-95a0-ecd5ff138be9")]
	public interface txIEXSLTRegExFunctions
	{
		
		/// <summary>Member Match </summary>
		/// <param name='aContext'> </param>
		/// <param name='aString'> </param>
		/// <param name='aRegEx'> </param>
		/// <param name='aFlags'> </param>
		/// <returns>A txINodeSet</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		txINodeSet Match(txIFunctionEvaluationContext  aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAString aString, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRegEx, [MarshalAs(UnmanagedType.LPStruct)] nsAString aFlags);
		
		/// <summary>Member Replace </summary>
		/// <param name='aString'> </param>
		/// <param name='aRegEx'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aReplace'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString Replace([MarshalAs(UnmanagedType.LPStruct)] nsAString aString, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRegEx, [MarshalAs(UnmanagedType.LPStruct)] nsAString aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAString aReplace);
		
		/// <summary>Member Test </summary>
		/// <param name='aString'> </param>
		/// <param name='aRegEx'> </param>
		/// <param name='aFlags'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Test([MarshalAs(UnmanagedType.LPStruct)] nsAString aString, [MarshalAs(UnmanagedType.LPStruct)] nsAString aRegEx, [MarshalAs(UnmanagedType.LPStruct)] nsAString aFlags);
	}
}