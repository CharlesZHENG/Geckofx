// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIContentSecurityPolicy.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIContentSecurityPolicy.idl
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
	
	
	/// <summary>nsIContentSecurityPolicy </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AB36A2BF-CB32-4AA6-AB41-6B4E4444A221")]
	public interface nsIContentSecurityPolicy
	{
		
		/// <summary>Member GetIsInitializedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsInitializedAttribute();
		
		/// <summary>Member SetIsInitializedAttribute </summary>
		/// <param name='aIsInitialized'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedAttribute(System.Boolean  aIsInitialized);
		
		/// <summary>Member GetReportOnlyModeAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetReportOnlyModeAttribute();
		
		/// <summary>Member SetReportOnlyModeAttribute </summary>
		/// <param name='aReportOnlyMode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReportOnlyModeAttribute(System.Boolean  aReportOnlyMode);
		
		/// <summary>Member GetPolicyAttribute </summary>
		/// <param name='aPolicy'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPolicyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPolicy);
		
		/// <summary>Member GetAllowsInlineScriptAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowsInlineScriptAttribute();
		
		/// <summary>Member GetAllowsEvalAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowsEvalAttribute();
		
		/// <summary>Member LogViolationDetails </summary>
		/// <param name='violationType'> </param>
		/// <param name='sourceFile'> </param>
		/// <param name='scriptSample'> </param>
		/// <param name='lineNum'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogViolationDetails(ushort violationType, [MarshalAs(UnmanagedType.LPStruct)] nsAString sourceFile, [MarshalAs(UnmanagedType.LPStruct)] nsAString scriptSample, System.Int32  lineNum);
		
		/// <summary>Member SendReports </summary>
		/// <param name='blockedURI'> </param>
		/// <param name='violatedDirective'> </param>
		/// <param name='scriptSample'> </param>
		/// <param name='lineNum'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendReports([MarshalAs(UnmanagedType.LPStruct)] nsAString blockedURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString violatedDirective, [MarshalAs(UnmanagedType.LPStruct)] nsAString scriptSample, System.Int32  lineNum);
		
		/// <summary>Member ScanRequestData </summary>
		/// <param name='aChannel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScanRequestData([MarshalAs(UnmanagedType.Interface)] nsIHttpChannel  aChannel);
		
		/// <summary>Member RefinePolicy </summary>
		/// <param name='policyString'> </param>
		/// <param name='selfURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RefinePolicy([MarshalAs(UnmanagedType.LPStruct)] nsAString policyString, [MarshalAs(UnmanagedType.Interface)] nsIURI  selfURI);
		
		/// <summary>Member PermitsAncestry </summary>
		/// <param name='docShell'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PermitsAncestry([MarshalAs(UnmanagedType.Interface)] nsIDocShell  docShell);
		
		/// <summary>Member ShouldLoad </summary>
		/// <param name='aContentType'> </param>
		/// <param name='aContentLocation'> </param>
		/// <param name='aRequestOrigin'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aMimeTypeGuess'> </param>
		/// <param name='aExtra'> </param>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldLoad(System.UInt32  aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI  aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI  aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeTypeGuess, [MarshalAs(UnmanagedType.Interface)] nsISupports  aExtra);
		
		/// <summary>Member ShouldProcess </summary>
		/// <param name='aContentType'> </param>
		/// <param name='aContentLocation'> </param>
		/// <param name='aRequestOrigin'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aExtra'> </param>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldProcess(System.UInt32  aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI  aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI  aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aMimeType, [MarshalAs(UnmanagedType.Interface)] nsISupports  aExtra);
	}
}
