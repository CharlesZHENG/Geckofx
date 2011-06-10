// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPrincipal.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPrincipal.idl
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
	
	
	/// <summary>nsIPrincipal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("799ab95c-0038-4e0f-b705-74c21f185bb5")]
	public interface nsIPrincipal : nsISerializable
	{
		
		/// <summary>Member Read </summary>
		/// <param name='aInputStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream  aInputStream);
		
		/// <summary>Member Write </summary>
		/// <param name='aOutputStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream  aOutputStream);
		
		/// <summary>Member GetPreferences </summary>
		/// <param name='prefBranch'> </param>
		/// <param name='id'> </param>
		/// <param name='subjectName'> </param>
		/// <param name='grantedList'> </param>
		/// <param name='deniedList'> </param>
		/// <param name='isTrusted'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPreferences([MarshalAs(UnmanagedType.LPStr)] out System.String  prefBranch, [MarshalAs(UnmanagedType.LPStr)] out System.String  id, [MarshalAs(UnmanagedType.LPStr)] out System.String  subjectName, [MarshalAs(UnmanagedType.LPStr)] out System.String  grantedList, [MarshalAs(UnmanagedType.LPStr)] out System.String  deniedList, out System.Boolean  isTrusted);
		
		/// <summary>Member Equals </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  other);
		
		/// <summary>Member GetHashValueAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetHashValueAttribute();
		
		/// <summary>Member GetJSPrincipals </summary>
		/// <param name='cx'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetJSPrincipals(System.IntPtr  cx);
		
		/// <summary>Member GetSecurityPolicyAttribute </summary>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetSecurityPolicyAttribute();
		
		/// <summary>Member SetSecurityPolicyAttribute </summary>
		/// <param name='aSecurityPolicy'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityPolicyAttribute(System.IntPtr  aSecurityPolicy);
		
		/// <summary>Member CanEnableCapability </summary>
		/// <param name='capability'> </param>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short CanEnableCapability([MarshalAs(UnmanagedType.LPStr)] System.String  capability);
		
		/// <summary>Member SetCanEnableCapability </summary>
		/// <param name='capability'> </param>
		/// <param name='canEnable'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanEnableCapability([MarshalAs(UnmanagedType.LPStr)] System.String  capability, short canEnable);
		
		/// <summary>Member IsCapabilityEnabled </summary>
		/// <param name='capability'> </param>
		/// <param name='annotation'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCapabilityEnabled([MarshalAs(UnmanagedType.LPStr)] System.String  capability, System.IntPtr  annotation);
		
		/// <summary>Member EnableCapability </summary>
		/// <param name='capability'> </param>
		/// <param name='annotation'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableCapability([MarshalAs(UnmanagedType.LPStr)] System.String  capability, ref System.IntPtr  annotation);
		
		/// <summary>Member RevertCapability </summary>
		/// <param name='capability'> </param>
		/// <param name='annotation'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RevertCapability([MarshalAs(UnmanagedType.LPStr)] System.String  capability, ref System.IntPtr  annotation);
		
		/// <summary>Member DisableCapability </summary>
		/// <param name='capability'> </param>
		/// <param name='annotation'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableCapability([MarshalAs(UnmanagedType.LPStr)] System.String  capability, ref System.IntPtr  annotation);
		
		/// <summary>Member GetURIAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetURIAttribute();
		
		/// <summary>Member GetDomainAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetDomainAttribute();
		
		/// <summary>Member SetDomainAttribute </summary>
		/// <param name='aDomain'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDomainAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aDomain);
		
		/// <summary>Member GetOriginAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetOriginAttribute();
		
		/// <summary>Member GetHasCertificateAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetHasCertificateAttribute();
		
		/// <summary>Member GetFingerprintAttribute </summary>
		/// <param name='aFingerprint'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aFingerprint);
		
		/// <summary>Member GetPrettyNameAttribute </summary>
		/// <param name='aPrettyName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrettyNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aPrettyName);
		
		/// <summary>Member Subsumes </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Subsumes([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  other);
		
		/// <summary>Member CheckMayLoad </summary>
		/// <param name='uri'> </param>
		/// <param name='report'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckMayLoad([MarshalAs(UnmanagedType.Interface)] nsIURI  uri, System.Boolean  report);
		
		/// <summary>Member GetSubjectNameAttribute </summary>
		/// <param name='aSubjectName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSubjectNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aSubjectName);
		
		/// <summary>Member GetCertificateAttribute </summary>
		/// <returns>A nsISupports </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports  GetCertificateAttribute();
		
		/// <summary>Member GetCspAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetCspAttribute();
		
		/// <summary>Member SetCspAttribute </summary>
		/// <param name='aCsp'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCspAttribute(System.IntPtr aCsp);
	}
}
