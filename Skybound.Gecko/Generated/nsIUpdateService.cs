// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIUpdateService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIUpdateService.idl
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
	
	
	/// <summary>nsIUpdatePatch </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("60523512-bb69-417c-9b2c-87a0664b0bbe")]
	public interface nsIUpdatePatch
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member SetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetURLAttribute </summary>
		/// <param name='aURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>Member SetURLAttribute </summary>
		/// <param name='aURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		/// <summary>Member GetFinalURLAttribute </summary>
		/// <param name='aFinalURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFinalURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFinalURL);
		
		/// <summary>Member SetFinalURLAttribute </summary>
		/// <param name='aFinalURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFinalURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFinalURL);
		
		/// <summary>Member GetHashFunctionAttribute </summary>
		/// <param name='aHashFunction'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHashFunctionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHashFunction);
		
		/// <summary>Member SetHashFunctionAttribute </summary>
		/// <param name='aHashFunction'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHashFunctionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHashFunction);
		
		/// <summary>Member GetHashValueAttribute </summary>
		/// <param name='aHashValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHashValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHashValue);
		
		/// <summary>Member SetHashValueAttribute </summary>
		/// <param name='aHashValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHashValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHashValue);
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetSizeAttribute();
		
		/// <summary>Member SetSizeAttribute </summary>
		/// <param name='aSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSizeAttribute(System.UInt32  aSize);
		
		/// <summary>Member GetStateAttribute </summary>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aState);
		
		/// <summary>Member SetStateAttribute </summary>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aState);
		
		/// <summary>Member GetSelectedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetSelectedAttribute();
		
		/// <summary>Member SetSelectedAttribute </summary>
		/// <param name='aSelected'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectedAttribute(System.Boolean  aSelected);
		
		/// <summary>Member Serialize </summary>
		/// <param name='updates'> </param>
		/// <returns>A nsIDOMElement</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement Serialize([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument  updates);
	}
	
	/// <summary>nsIUpdate </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2379e2e1-8eab-4084-8d8c-94ffeee56804")]
	public interface nsIUpdate
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member SetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member GetDisplayVersionAttribute </summary>
		/// <param name='aDisplayVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayVersion);
		
		/// <summary>Member SetDisplayVersionAttribute </summary>
		/// <param name='aDisplayVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayVersion);
		
		/// <summary>Member GetAppVersionAttribute </summary>
		/// <param name='aAppVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAppVersion);
		
		/// <summary>Member SetAppVersionAttribute </summary>
		/// <param name='aAppVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAppVersion);
		
		/// <summary>Member GetPlatformVersionAttribute </summary>
		/// <param name='aPlatformVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPlatformVersion);
		
		/// <summary>Member SetPlatformVersionAttribute </summary>
		/// <param name='aPlatformVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPlatformVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPlatformVersion);
		
		/// <summary>Member GetPreviousAppVersionAttribute </summary>
		/// <param name='aPreviousAppVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPreviousAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPreviousAppVersion);
		
		/// <summary>Member SetPreviousAppVersionAttribute </summary>
		/// <param name='aPreviousAppVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPreviousAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPreviousAppVersion);
		
		/// <summary>Member GetBuildIDAttribute </summary>
		/// <param name='aBuildID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aBuildID);
		
		/// <summary>Member SetBuildIDAttribute </summary>
		/// <param name='aBuildID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aBuildID);
		
		/// <summary>Member GetDetailsURLAttribute </summary>
		/// <param name='aDetailsURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDetailsURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailsURL);
		
		/// <summary>Member SetDetailsURLAttribute </summary>
		/// <param name='aDetailsURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDetailsURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailsURL);
		
		/// <summary>Member GetBillboardURLAttribute </summary>
		/// <param name='aBillboardURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBillboardURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aBillboardURL);
		
		/// <summary>Member SetBillboardURLAttribute </summary>
		/// <param name='aBillboardURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBillboardURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aBillboardURL);
		
		/// <summary>Member GetLicenseURLAttribute </summary>
		/// <param name='aLicenseURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLicenseURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLicenseURL);
		
		/// <summary>Member SetLicenseURLAttribute </summary>
		/// <param name='aLicenseURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLicenseURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLicenseURL);
		
		/// <summary>Member GetServiceURLAttribute </summary>
		/// <param name='aServiceURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetServiceURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aServiceURL);
		
		/// <summary>Member SetServiceURLAttribute </summary>
		/// <param name='aServiceURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetServiceURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aServiceURL);
		
		/// <summary>Member GetChannelAttribute </summary>
		/// <param name='aChannel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetChannelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aChannel);
		
		/// <summary>Member SetChannelAttribute </summary>
		/// <param name='aChannel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChannelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aChannel);
		
		/// <summary>Member GetShowPromptAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetShowPromptAttribute();
		
		/// <summary>Member SetShowPromptAttribute </summary>
		/// <param name='aShowPrompt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowPromptAttribute(System.Boolean  aShowPrompt);
		
		/// <summary>Member GetShowNeverForVersionAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetShowNeverForVersionAttribute();
		
		/// <summary>Member SetShowNeverForVersionAttribute </summary>
		/// <param name='aShowNeverForVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowNeverForVersionAttribute(System.Boolean  aShowNeverForVersion);
		
		/// <summary>Member GetShowSurveyAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetShowSurveyAttribute();
		
		/// <summary>Member SetShowSurveyAttribute </summary>
		/// <param name='aShowSurvey'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowSurveyAttribute(System.Boolean  aShowSurvey);
		
		/// <summary>Member GetIsCompleteUpdateAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsCompleteUpdateAttribute();
		
		/// <summary>Member SetIsCompleteUpdateAttribute </summary>
		/// <param name='aIsCompleteUpdate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsCompleteUpdateAttribute(System.Boolean  aIsCompleteUpdate);
		
		/// <summary>Member GetIsSecurityUpdateAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsSecurityUpdateAttribute();
		
		/// <summary>Member SetIsSecurityUpdateAttribute </summary>
		/// <param name='aIsSecurityUpdate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsSecurityUpdateAttribute(System.Boolean  aIsSecurityUpdate);
		
		/// <summary>Member GetInstallDateAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetInstallDateAttribute();
		
		/// <summary>Member SetInstallDateAttribute </summary>
		/// <param name='aInstallDate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInstallDateAttribute(System.Int32  aInstallDate);
		
		/// <summary>Member GetStatusTextAttribute </summary>
		/// <param name='aStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStatusText);
		
		/// <summary>Member SetStatusTextAttribute </summary>
		/// <param name='aStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStatusText);
		
		/// <summary>Member GetSelectedPatchAttribute </summary>
		/// <returns>A nsIUpdatePatch </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdatePatch  GetSelectedPatchAttribute();
		
		/// <summary>Member GetStateAttribute </summary>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aState);
		
		/// <summary>Member SetStateAttribute </summary>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aState);
		
		/// <summary>Member GetErrorCodeAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetErrorCodeAttribute();
		
		/// <summary>Member SetErrorCodeAttribute </summary>
		/// <param name='aErrorCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetErrorCodeAttribute(System.Int32  aErrorCode);
		
		/// <summary>Member GetPatchCountAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetPatchCountAttribute();
		
		/// <summary>Member GetPatchAt </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIUpdatePatch</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdatePatch GetPatchAt(System.UInt32  index);
		
		/// <summary>Member Serialize </summary>
		/// <param name='updates'> </param>
		/// <returns>A nsIDOMElement</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement Serialize([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument  updates);
	}
	
	/// <summary>nsIUpdateCheckListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8cbceb6e-8e27-46f2-8808-444c6499f836")]
	public interface nsIUpdateCheckListener
	{
		
		/// <summary>Member OnProgress </summary>
		/// <param name='request'> </param>
		/// <param name='position'> </param>
		/// <param name='totalSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgress([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest  request, System.UInt32  position, System.UInt32  totalSize);
		
		/// <summary>Member OnCheckComplete </summary>
		/// <param name='request'> </param>
		/// <param name='updates'> </param>
		/// <param name='updateCount'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCheckComplete([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest  request, nsIUpdate  updates, System.UInt32  updateCount);
		
		/// <summary>Member OnError </summary>
		/// <param name='request'> </param>
		/// <param name='update'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnError([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest  request, [MarshalAs(UnmanagedType.Interface)] nsIUpdate  update);
	}
	
	/// <summary>nsIUpdateChecker </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("877ace25-8bc5-452a-8586-9c1cf2871994")]
	public interface nsIUpdateChecker
	{
		
		/// <summary>Member CheckForUpdates </summary>
		/// <param name='listener'> </param>
		/// <param name='force'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckForUpdates([MarshalAs(UnmanagedType.Interface)] nsIUpdateCheckListener  listener, System.Boolean  force);
		
		/// <summary>Member StopChecking </summary>
		/// <param name='duration'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopChecking(ushort duration);
	}
	
	/// <summary>nsIApplicationUpdateService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b5811144-ed30-4343-aff9-c514034aa19a")]
	public interface nsIApplicationUpdateService
	{
		
		/// <summary>Member GetBackgroundCheckerAttribute </summary>
		/// <returns>A nsIUpdateChecker </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdateChecker  GetBackgroundCheckerAttribute();
		
		/// <summary>Member SelectUpdate </summary>
		/// <param name='updates'> </param>
		/// <param name='updateCount'> </param>
		/// <returns>A nsIUpdate</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdate SelectUpdate(nsIUpdate  updates, System.UInt32  updateCount);
		
		/// <summary>Member AddDownloadListener </summary>
		/// <param name='listener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDownloadListener([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver  listener);
		
		/// <summary>Member RemoveDownloadListener </summary>
		/// <param name='listener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDownloadListener([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver  listener);
		
		/// <summary>Member DownloadUpdate </summary>
		/// <param name='update'> </param>
		/// <param name='background'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString DownloadUpdate([MarshalAs(UnmanagedType.Interface)] nsIUpdate  update, System.Boolean  background);
		
		/// <summary>Member PauseDownload </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PauseDownload();
		
		/// <summary>Member GetIsDownloadingAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsDownloadingAttribute();
		
		/// <summary>Member GetCanCheckForUpdatesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetCanCheckForUpdatesAttribute();
		
		/// <summary>Member GetCanApplyUpdatesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetCanApplyUpdatesAttribute();
	}
	
	/// <summary>nsIUpdateManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fede66a9-9f96-4507-a22a-775ee885577e")]
	public interface nsIUpdateManager
	{
		
		/// <summary>Member GetUpdateAt </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIUpdate</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdate GetUpdateAt(System.Int32  index);
		
		/// <summary>Member GetUpdateCountAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetUpdateCountAttribute();
		
		/// <summary>Member GetActiveUpdateAttribute </summary>
		/// <returns>A nsIUpdate </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdate  GetActiveUpdateAttribute();
		
		/// <summary>Member SetActiveUpdateAttribute </summary>
		/// <param name='aActiveUpdate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActiveUpdateAttribute([MarshalAs(UnmanagedType.Interface)] nsIUpdate  aActiveUpdate);
		
		/// <summary>Member SaveUpdates </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveUpdates();
	}
	
	/// <summary>nsIUpdatePrompt </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("599fd3c6-ec68-4499-ada5-2997739c97a6")]
	public interface nsIUpdatePrompt
	{
		
		/// <summary>Member CheckForUpdates </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckForUpdates();
		
		/// <summary>Member ShowUpdateAvailable </summary>
		/// <param name='update'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateAvailable([MarshalAs(UnmanagedType.Interface)] nsIUpdate  update);
		
		/// <summary>Member ShowUpdateDownloaded </summary>
		/// <param name='update'> </param>
		/// <param name='background'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateDownloaded([MarshalAs(UnmanagedType.Interface)] nsIUpdate  update, System.Boolean  background);
		
		/// <summary>Member ShowUpdateInstalled </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateInstalled();
		
		/// <summary>Member ShowUpdateError </summary>
		/// <param name='update'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateError([MarshalAs(UnmanagedType.Interface)] nsIUpdate  update);
		
		/// <summary>Member ShowUpdateHistory </summary>
		/// <param name='parent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateHistory([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  parent);
	}
}
