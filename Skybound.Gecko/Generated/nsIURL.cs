// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIURL.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIURL.idl
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
	
	
	/// <summary>nsIURL </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d6116970-8034-11d3-9399-00104ba0fd40")]
	public interface nsIURL : nsIURI
	{
		
		/// <summary>Member GetSpecAttribute </summary>
		/// <param name='aSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aSpec);
		
		/// <summary>Member SetSpecAttribute </summary>
		/// <param name='aSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aSpec);
		
		/// <summary>Member GetPrePathAttribute </summary>
		/// <param name='aPrePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aPrePath);
		
		/// <summary>Member GetSchemeAttribute </summary>
		/// <param name='aScheme'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aScheme);
		
		/// <summary>Member SetSchemeAttribute </summary>
		/// <param name='aScheme'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aScheme);
		
		/// <summary>Member GetUserPassAttribute </summary>
		/// <param name='aUserPass'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aUserPass);
		
		/// <summary>Member SetUserPassAttribute </summary>
		/// <param name='aUserPass'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aUserPass);
		
		/// <summary>Member GetUsernameAttribute </summary>
		/// <param name='aUsername'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aUsername);
		
		/// <summary>Member SetUsernameAttribute </summary>
		/// <param name='aUsername'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aUsername);
		
		/// <summary>Member GetPasswordAttribute </summary>
		/// <param name='aPassword'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aPassword);
		
		/// <summary>Member SetPasswordAttribute </summary>
		/// <param name='aPassword'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aPassword);
		
		/// <summary>Member GetHostPortAttribute </summary>
		/// <param name='aHostPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aHostPort);
		
		/// <summary>Member SetHostPortAttribute </summary>
		/// <param name='aHostPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aHostPort);
		
		/// <summary>Member GetHostAttribute </summary>
		/// <param name='aHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aHost);
		
		/// <summary>Member SetHostAttribute </summary>
		/// <param name='aHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aHost);
		
		/// <summary>Member GetPortAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetPortAttribute();
		
		/// <summary>Member SetPortAttribute </summary>
		/// <param name='aPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPortAttribute(System.Int32  aPort);
		
		/// <summary>Member GetPathAttribute </summary>
		/// <param name='aPath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aPath);
		
		/// <summary>Member SetPathAttribute </summary>
		/// <param name='aPath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aPath);
		
		/// <summary>Member Equals </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIURI  other);
		
		/// <summary>Member SchemeIs </summary>
		/// <param name='scheme'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] System.String  scheme);
		
		/// <summary>Member Clone </summary>
		/// <returns>A nsIURI</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI Clone();
		
		/// <summary>Member Resolve </summary>
		/// <param name='relativePath'> </param>
		/// <returns>A nsAUTF8String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAUTF8String Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  relativePath);
		
		/// <summary>Member GetAsciiSpecAttribute </summary>
		/// <param name='aAsciiSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAsciiSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aAsciiSpec);
		
		/// <summary>Member GetAsciiHostAttribute </summary>
		/// <param name='aAsciiHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAsciiHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aAsciiHost);
		
		/// <summary>Member GetOriginCharsetAttribute </summary>
		/// <param name='aOriginCharset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOriginCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aOriginCharset);
		
		/// <summary>Member GetFilePathAttribute </summary>
		/// <param name='aFilePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFilePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFilePath);
		
		/// <summary>Member SetFilePathAttribute </summary>
		/// <param name='aFilePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFilePath);
		
		/// <summary>Member GetParamAttribute </summary>
		/// <param name='aParam'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetParamAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aParam);
		
		/// <summary>Member SetParamAttribute </summary>
		/// <param name='aParam'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParamAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aParam);
		
		/// <summary>Member GetQueryAttribute </summary>
		/// <param name='aQuery'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetQueryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aQuery);
		
		/// <summary>Member SetQueryAttribute </summary>
		/// <param name='aQuery'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetQueryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aQuery);
		
		/// <summary>Member GetRefAttribute </summary>
		/// <param name='aRef'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aRef);
		
		/// <summary>Member SetRefAttribute </summary>
		/// <param name='aRef'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aRef);
		
		/// <summary>Member GetDirectoryAttribute </summary>
		/// <param name='aDirectory'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDirectoryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aDirectory);
		
		/// <summary>Member SetDirectoryAttribute </summary>
		/// <param name='aDirectory'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDirectoryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aDirectory);
		
		/// <summary>Member GetFileNameAttribute </summary>
		/// <param name='aFileName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFileName);
		
		/// <summary>Member SetFileNameAttribute </summary>
		/// <param name='aFileName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFileName);
		
		/// <summary>Member GetFileBaseNameAttribute </summary>
		/// <param name='aFileBaseName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFileBaseNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFileBaseName);
		
		/// <summary>Member SetFileBaseNameAttribute </summary>
		/// <param name='aFileBaseName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileBaseNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFileBaseName);
		
		/// <summary>Member GetFileExtensionAttribute </summary>
		/// <param name='aFileExtension'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFileExtension);
		
		/// <summary>Member SetFileExtensionAttribute </summary>
		/// <param name='aFileExtension'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFileExtension);
		
		/// <summary>Member GetCommonBaseSpec </summary>
		/// <param name='aURIToCompare'> </param>
		/// <returns>A nsAUTF8String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAUTF8String GetCommonBaseSpec([MarshalAs(UnmanagedType.Interface)] nsIURI  aURIToCompare);
		
		/// <summary>Member GetRelativeSpec </summary>
		/// <param name='aURIToCompare'> </param>
		/// <returns>A nsAUTF8String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAUTF8String GetRelativeSpec([MarshalAs(UnmanagedType.Interface)] nsIURI  aURIToCompare);
	}
}
