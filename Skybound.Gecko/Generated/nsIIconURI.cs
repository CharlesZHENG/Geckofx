// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIIconURI.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIIconURI.idl
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
	
	
	/// <summary>nsIMozIconURI </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E2D046D2-3729-440D-B0DB-F8D817BC2571")]
	public interface nsIMozIconURI : nsIURI
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
		
		/// <summary>Member GetIconURLAttribute </summary>
		/// <returns>A nsIURL </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURL  GetIconURLAttribute();
		
		/// <summary>Member SetIconURLAttribute </summary>
		/// <param name='aIconURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIconURLAttribute([MarshalAs(UnmanagedType.Interface)] nsIURL  aIconURL);
		
		/// <summary>Member GetImageSizeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetImageSizeAttribute();
		
		/// <summary>Member SetImageSizeAttribute </summary>
		/// <param name='aImageSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetImageSizeAttribute(System.UInt32  aImageSize);
		
		/// <summary>Member GetStockIconAttribute </summary>
		/// <param name='aStockIcon'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStockIconAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aStockIcon);
		
		/// <summary>Member GetIconSizeAttribute </summary>
		/// <param name='aIconSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIconSizeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aIconSize);
		
		/// <summary>Member GetIconStateAttribute </summary>
		/// <param name='aIconState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIconStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aIconState);
		
		/// <summary>Member GetContentTypeAttribute </summary>
		/// <param name='aContentType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType);
		
		/// <summary>Member SetContentTypeAttribute </summary>
		/// <param name='aContentType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType);
		
		/// <summary>Member GetFileExtensionAttribute </summary>
		/// <param name='aFileExtension'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aFileExtension);
	}
}
