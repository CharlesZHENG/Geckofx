// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIX509Cert2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIX509Cert2.idl
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
	
	
	/// <summary>nsIX509Cert2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5b62c61c-f898-4dab-8ace-51109bb459b4")]
	public interface nsIX509Cert2 : nsIX509Cert
	{
		
		/// <summary>Member GetNicknameAttribute </summary>
		/// <param name='aNickname'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNicknameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNickname);
		
		/// <summary>Member GetEmailAddressAttribute </summary>
		/// <param name='aEmailAddress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetEmailAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aEmailAddress);
		
		/// <summary>Member GetEmailAddresses </summary>
		/// <param name='length'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetEmailAddresses(out System.UInt32  length);
		
		/// <summary>Member ContainsEmailAddress </summary>
		/// <param name='aEmailAddress'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool ContainsEmailAddress([MarshalAs(UnmanagedType.LPStruct)] nsAString aEmailAddress);
		
		/// <summary>Member GetSubjectNameAttribute </summary>
		/// <param name='aSubjectName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSubjectNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSubjectName);
		
		/// <summary>Member GetCommonNameAttribute </summary>
		/// <param name='aCommonName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCommonNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCommonName);
		
		/// <summary>Member GetOrganizationAttribute </summary>
		/// <param name='aOrganization'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOrganizationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrganization);
		
		/// <summary>Member GetOrganizationalUnitAttribute </summary>
		/// <param name='aOrganizationalUnit'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOrganizationalUnitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrganizationalUnit);
		
		/// <summary>Member GetSha1FingerprintAttribute </summary>
		/// <param name='aSha1Fingerprint'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSha1FingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSha1Fingerprint);
		
		/// <summary>Member GetMd5FingerprintAttribute </summary>
		/// <param name='aMd5Fingerprint'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMd5FingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMd5Fingerprint);
		
		/// <summary>Member GetTokenNameAttribute </summary>
		/// <param name='aTokenName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTokenNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTokenName);
		
		/// <summary>Member GetIssuerNameAttribute </summary>
		/// <param name='aIssuerName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aIssuerName);
		
		/// <summary>Member GetSerialNumberAttribute </summary>
		/// <param name='aSerialNumber'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSerialNumberAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSerialNumber);
		
		/// <summary>Member GetIssuerCommonNameAttribute </summary>
		/// <param name='aIssuerCommonName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerCommonNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aIssuerCommonName);
		
		/// <summary>Member GetIssuerOrganizationAttribute </summary>
		/// <param name='aIssuerOrganization'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerOrganizationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aIssuerOrganization);
		
		/// <summary>Member GetIssuerOrganizationUnitAttribute </summary>
		/// <param name='aIssuerOrganizationUnit'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerOrganizationUnitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aIssuerOrganizationUnit);
		
		/// <summary>Member GetIssuerAttribute </summary>
		/// <returns>A nsIX509Cert </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIX509Cert  GetIssuerAttribute();
		
		/// <summary>Member GetValidityAttribute </summary>
		/// <returns>A nsIX509CertValidity </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIX509CertValidity  GetValidityAttribute();
		
		/// <summary>Member GetDbKeyAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetDbKeyAttribute();
		
		/// <summary>Member GetWindowTitleAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetWindowTitleAttribute();
		
		/// <summary>Member GetChain </summary>
		/// <returns>A nsIArray</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIArray GetChain();
		
		/// <summary>Member GetUsagesArray </summary>
		/// <param name='ignoreOcsp'> </param>
		/// <param name='verified'> </param>
		/// <param name='count'> </param>
		/// <param name='usages'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUsagesArray(System.Boolean  ignoreOcsp, out System.UInt32  verified, out System.UInt32  count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)] out string usages);
		
		/// <summary>Member GetUsagesString </summary>
		/// <param name='ignoreOcsp'> </param>
		/// <param name='verified'> </param>
		/// <param name='usages'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUsagesString(System.Boolean  ignoreOcsp, out System.UInt32  verified, [MarshalAs(UnmanagedType.LPStruct)] nsAString usages);
		
		/// <summary>Member VerifyForUsage </summary>
		/// <param name='usage'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint VerifyForUsage(System.UInt32  usage);
		
		/// <summary>Member GetASN1StructureAttribute </summary>
		/// <returns>A nsIASN1Object </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIASN1Object  GetASN1StructureAttribute();
		
		/// <summary>Member GetRawDER </summary>
		/// <param name='length'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr  GetRawDER(out System.UInt32  length);
		
		/// <summary>Member Equals </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIX509Cert  other);
		
		/// <summary>Member GetCertTypeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetCertTypeAttribute();
		
		/// <summary>Member MarkForPermDeletion </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkForPermDeletion();
		
		/// <summary>Member GetCert </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetCert();
	}
}
