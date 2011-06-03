// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPrintSettings.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPrintSettings.idl
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
	
	
	/// <summary>nsIPrintSettings </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("343700dd-078b-42b6-a809-b9c1d7e951d0")]
	public interface nsIPrintSettings
	{
		
		/// <summary>Member SetPrintOptions </summary>
		/// <param name='aType'> </param>
		/// <param name='aTurnOnOff'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintOptions(System.Int32  aType, System.Boolean  aTurnOnOff);
		
		/// <summary>Member GetPrintOptions </summary>
		/// <param name='aType'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintOptions(System.Int32  aType);
		
		/// <summary>Member GetPrintOptionsBits </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintOptionsBits();
		
		/// <summary>Member GetEffectivePageSize </summary>
		/// <param name='aWidth'> </param>
		/// <param name='aHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEffectivePageSize(out double aWidth, out double aHeight);
		
		/// <summary>Member Clone </summary>
		/// <returns>A nsIPrintSettings</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings Clone();
		
		/// <summary>Member Assign </summary>
		/// <param name='aPS'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Assign([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings  aPS);
		
		/// <summary>Member GetPrintSessionAttribute </summary>
		/// <returns>A nsIPrintSession </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSession  GetPrintSessionAttribute();
		
		/// <summary>Member SetPrintSessionAttribute </summary>
		/// <param name='aPrintSession'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintSessionAttribute([MarshalAs(UnmanagedType.Interface)] nsIPrintSession  aPrintSession);
		
		/// <summary>Member GetStartPageRangeAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetStartPageRangeAttribute();
		
		/// <summary>Member SetStartPageRangeAttribute </summary>
		/// <param name='aStartPageRange'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartPageRangeAttribute(System.Int32  aStartPageRange);
		
		/// <summary>Member GetEndPageRangeAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetEndPageRangeAttribute();
		
		/// <summary>Member SetEndPageRangeAttribute </summary>
		/// <param name='aEndPageRange'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndPageRangeAttribute(System.Int32  aEndPageRange);
		
		/// <summary>Member GetEdgeTopAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeTopAttribute();
		
		/// <summary>Member SetEdgeTopAttribute </summary>
		/// <param name='aEdgeTop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeTopAttribute(double aEdgeTop);
		
		/// <summary>Member GetEdgeLeftAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeLeftAttribute();
		
		/// <summary>Member SetEdgeLeftAttribute </summary>
		/// <param name='aEdgeLeft'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeLeftAttribute(double aEdgeLeft);
		
		/// <summary>Member GetEdgeBottomAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeBottomAttribute();
		
		/// <summary>Member SetEdgeBottomAttribute </summary>
		/// <param name='aEdgeBottom'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeBottomAttribute(double aEdgeBottom);
		
		/// <summary>Member GetEdgeRightAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeRightAttribute();
		
		/// <summary>Member SetEdgeRightAttribute </summary>
		/// <param name='aEdgeRight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeRightAttribute(double aEdgeRight);
		
		/// <summary>Member GetMarginTopAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginTopAttribute();
		
		/// <summary>Member SetMarginTopAttribute </summary>
		/// <param name='aMarginTop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginTopAttribute(double aMarginTop);
		
		/// <summary>Member GetMarginLeftAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginLeftAttribute();
		
		/// <summary>Member SetMarginLeftAttribute </summary>
		/// <param name='aMarginLeft'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginLeftAttribute(double aMarginLeft);
		
		/// <summary>Member GetMarginBottomAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginBottomAttribute();
		
		/// <summary>Member SetMarginBottomAttribute </summary>
		/// <param name='aMarginBottom'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginBottomAttribute(double aMarginBottom);
		
		/// <summary>Member GetMarginRightAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginRightAttribute();
		
		/// <summary>Member SetMarginRightAttribute </summary>
		/// <param name='aMarginRight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginRightAttribute(double aMarginRight);
		
		/// <summary>Member GetUnwriteableMarginTopAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginTopAttribute();
		
		/// <summary>Member SetUnwriteableMarginTopAttribute </summary>
		/// <param name='aUnwriteableMarginTop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginTopAttribute(double aUnwriteableMarginTop);
		
		/// <summary>Member GetUnwriteableMarginLeftAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginLeftAttribute();
		
		/// <summary>Member SetUnwriteableMarginLeftAttribute </summary>
		/// <param name='aUnwriteableMarginLeft'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginLeftAttribute(double aUnwriteableMarginLeft);
		
		/// <summary>Member GetUnwriteableMarginBottomAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginBottomAttribute();
		
		/// <summary>Member SetUnwriteableMarginBottomAttribute </summary>
		/// <param name='aUnwriteableMarginBottom'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginBottomAttribute(double aUnwriteableMarginBottom);
		
		/// <summary>Member GetUnwriteableMarginRightAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginRightAttribute();
		
		/// <summary>Member SetUnwriteableMarginRightAttribute </summary>
		/// <param name='aUnwriteableMarginRight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginRightAttribute(double aUnwriteableMarginRight);
		
		/// <summary>Member GetScalingAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetScalingAttribute();
		
		/// <summary>Member SetScalingAttribute </summary>
		/// <param name='aScaling'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScalingAttribute(double aScaling);
		
		/// <summary>Member GetPrintBGColorsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetPrintBGColorsAttribute();
		
		/// <summary>Member SetPrintBGColorsAttribute </summary>
		/// <param name='aPrintBGColors'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintBGColorsAttribute(System.Boolean  aPrintBGColors);
		
		/// <summary>Member GetPrintBGImagesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetPrintBGImagesAttribute();
		
		/// <summary>Member SetPrintBGImagesAttribute </summary>
		/// <param name='aPrintBGImages'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintBGImagesAttribute(System.Boolean  aPrintBGImages);
		
		/// <summary>Member GetPrintRangeAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintRangeAttribute();
		
		/// <summary>Member SetPrintRangeAttribute </summary>
		/// <param name='aPrintRange'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintRangeAttribute(short aPrintRange);
		
		/// <summary>Member GetTitleAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTitleAttribute();
		
		/// <summary>Member SetTitleAttribute </summary>
		/// <param name='aTitle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aTitle);
		
		/// <summary>Member GetDocURLAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDocURLAttribute();
		
		/// <summary>Member SetDocURLAttribute </summary>
		/// <param name='aDocURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDocURL);
		
		/// <summary>Member GetHeaderStrLeftAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrLeftAttribute();
		
		/// <summary>Member SetHeaderStrLeftAttribute </summary>
		/// <param name='aHeaderStrLeft'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrLeftAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aHeaderStrLeft);
		
		/// <summary>Member GetHeaderStrCenterAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrCenterAttribute();
		
		/// <summary>Member SetHeaderStrCenterAttribute </summary>
		/// <param name='aHeaderStrCenter'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrCenterAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aHeaderStrCenter);
		
		/// <summary>Member GetHeaderStrRightAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrRightAttribute();
		
		/// <summary>Member SetHeaderStrRightAttribute </summary>
		/// <param name='aHeaderStrRight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrRightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aHeaderStrRight);
		
		/// <summary>Member GetFooterStrLeftAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrLeftAttribute();
		
		/// <summary>Member SetFooterStrLeftAttribute </summary>
		/// <param name='aFooterStrLeft'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrLeftAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aFooterStrLeft);
		
		/// <summary>Member GetFooterStrCenterAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrCenterAttribute();
		
		/// <summary>Member SetFooterStrCenterAttribute </summary>
		/// <param name='aFooterStrCenter'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrCenterAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aFooterStrCenter);
		
		/// <summary>Member GetFooterStrRightAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrRightAttribute();
		
		/// <summary>Member SetFooterStrRightAttribute </summary>
		/// <param name='aFooterStrRight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrRightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aFooterStrRight);
		
		/// <summary>Member GetHowToEnableFrameUIAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetHowToEnableFrameUIAttribute();
		
		/// <summary>Member SetHowToEnableFrameUIAttribute </summary>
		/// <param name='aHowToEnableFrameUI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHowToEnableFrameUIAttribute(short aHowToEnableFrameUI);
		
		/// <summary>Member GetIsCancelledAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsCancelledAttribute();
		
		/// <summary>Member SetIsCancelledAttribute </summary>
		/// <param name='aIsCancelled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsCancelledAttribute(System.Boolean  aIsCancelled);
		
		/// <summary>Member GetPrintFrameTypeUsageAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintFrameTypeUsageAttribute();
		
		/// <summary>Member SetPrintFrameTypeUsageAttribute </summary>
		/// <param name='aPrintFrameTypeUsage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintFrameTypeUsageAttribute(short aPrintFrameTypeUsage);
		
		/// <summary>Member GetPrintFrameTypeAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintFrameTypeAttribute();
		
		/// <summary>Member SetPrintFrameTypeAttribute </summary>
		/// <param name='aPrintFrameType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintFrameTypeAttribute(short aPrintFrameType);
		
		/// <summary>Member GetPrintSilentAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetPrintSilentAttribute();
		
		/// <summary>Member SetPrintSilentAttribute </summary>
		/// <param name='aPrintSilent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintSilentAttribute(System.Boolean  aPrintSilent);
		
		/// <summary>Member GetShrinkToFitAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetShrinkToFitAttribute();
		
		/// <summary>Member SetShrinkToFitAttribute </summary>
		/// <param name='aShrinkToFit'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShrinkToFitAttribute(System.Boolean  aShrinkToFit);
		
		/// <summary>Member GetShowPrintProgressAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetShowPrintProgressAttribute();
		
		/// <summary>Member SetShowPrintProgressAttribute </summary>
		/// <param name='aShowPrintProgress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowPrintProgressAttribute(System.Boolean  aShowPrintProgress);
		
		/// <summary>Member GetPaperNameAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPaperNameAttribute();
		
		/// <summary>Member SetPaperNameAttribute </summary>
		/// <param name='aPaperName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPaperName);
		
		/// <summary>Member GetPaperSizeTypeAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperSizeTypeAttribute();
		
		/// <summary>Member SetPaperSizeTypeAttribute </summary>
		/// <param name='aPaperSizeType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperSizeTypeAttribute(short aPaperSizeType);
		
		/// <summary>Member GetPaperDataAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperDataAttribute();
		
		/// <summary>Member SetPaperDataAttribute </summary>
		/// <param name='aPaperData'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperDataAttribute(short aPaperData);
		
		/// <summary>Member GetPaperWidthAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPaperWidthAttribute();
		
		/// <summary>Member SetPaperWidthAttribute </summary>
		/// <param name='aPaperWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperWidthAttribute(double aPaperWidth);
		
		/// <summary>Member GetPaperHeightAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPaperHeightAttribute();
		
		/// <summary>Member SetPaperHeightAttribute </summary>
		/// <param name='aPaperHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperHeightAttribute(double aPaperHeight);
		
		/// <summary>Member GetPaperSizeUnitAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperSizeUnitAttribute();
		
		/// <summary>Member SetPaperSizeUnitAttribute </summary>
		/// <param name='aPaperSizeUnit'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperSizeUnitAttribute(short aPaperSizeUnit);
		
		/// <summary>Member GetPlexNameAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPlexNameAttribute();
		
		/// <summary>Member SetPlexNameAttribute </summary>
		/// <param name='aPlexName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPlexNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPlexName);
		
		/// <summary>Member GetColorspaceAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetColorspaceAttribute();
		
		/// <summary>Member SetColorspaceAttribute </summary>
		/// <param name='aColorspace'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetColorspaceAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aColorspace);
		
		/// <summary>Member GetResolutionNameAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetResolutionNameAttribute();
		
		/// <summary>Member SetResolutionNameAttribute </summary>
		/// <param name='aResolutionName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetResolutionNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aResolutionName);
		
		/// <summary>Member GetDownloadFontsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetDownloadFontsAttribute();
		
		/// <summary>Member SetDownloadFontsAttribute </summary>
		/// <param name='aDownloadFonts'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDownloadFontsAttribute(System.Boolean  aDownloadFonts);
		
		/// <summary>Member GetPrintReversedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetPrintReversedAttribute();
		
		/// <summary>Member SetPrintReversedAttribute </summary>
		/// <param name='aPrintReversed'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintReversedAttribute(System.Boolean  aPrintReversed);
		
		/// <summary>Member GetPrintInColorAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetPrintInColorAttribute();
		
		/// <summary>Member SetPrintInColorAttribute </summary>
		/// <param name='aPrintInColor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintInColorAttribute(System.Boolean  aPrintInColor);
		
		/// <summary>Member GetOrientationAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetOrientationAttribute();
		
		/// <summary>Member SetOrientationAttribute </summary>
		/// <param name='aOrientation'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOrientationAttribute(System.Int32  aOrientation);
		
		/// <summary>Member GetPrintCommandAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrintCommandAttribute();
		
		/// <summary>Member SetPrintCommandAttribute </summary>
		/// <param name='aPrintCommand'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintCommandAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPrintCommand);
		
		/// <summary>Member GetNumCopiesAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetNumCopiesAttribute();
		
		/// <summary>Member SetNumCopiesAttribute </summary>
		/// <param name='aNumCopies'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNumCopiesAttribute(System.Int32  aNumCopies);
		
		/// <summary>Member GetPrinterNameAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrinterNameAttribute();
		
		/// <summary>Member SetPrinterNameAttribute </summary>
		/// <param name='aPrinterName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrinterNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPrinterName);
		
		/// <summary>Member GetPrintToFileAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetPrintToFileAttribute();
		
		/// <summary>Member SetPrintToFileAttribute </summary>
		/// <param name='aPrintToFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintToFileAttribute(System.Boolean  aPrintToFile);
		
		/// <summary>Member GetToFileNameAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetToFileNameAttribute();
		
		/// <summary>Member SetToFileNameAttribute </summary>
		/// <param name='aToFileName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetToFileNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aToFileName);
		
		/// <summary>Member GetOutputFormatAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetOutputFormatAttribute();
		
		/// <summary>Member SetOutputFormatAttribute </summary>
		/// <param name='aOutputFormat'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutputFormatAttribute(short aOutputFormat);
		
		/// <summary>Member GetPrintPageDelayAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetPrintPageDelayAttribute();
		
		/// <summary>Member SetPrintPageDelayAttribute </summary>
		/// <param name='aPrintPageDelay'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintPageDelayAttribute(System.Int32  aPrintPageDelay);
		
		/// <summary>Member GetIsInitializedFromPrinterAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsInitializedFromPrinterAttribute();
		
		/// <summary>Member SetIsInitializedFromPrinterAttribute </summary>
		/// <param name='aIsInitializedFromPrinter'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedFromPrinterAttribute(System.Boolean  aIsInitializedFromPrinter);
		
		/// <summary>Member GetIsInitializedFromPrefsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsInitializedFromPrefsAttribute();
		
		/// <summary>Member SetIsInitializedFromPrefsAttribute </summary>
		/// <param name='aIsInitializedFromPrefs'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedFromPrefsAttribute(System.Boolean  aIsInitializedFromPrefs);
		
		/// <summary>Member SetMarginInTwips </summary>
		/// <param name='aMargin'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginInTwips(System.IntPtr aMargin);
		
		/// <summary>Member SetEdgeInTwips </summary>
		/// <param name='aEdge'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeInTwips(System.IntPtr aEdge);
		
		/// <summary>Member GetMarginInTwips </summary>
		/// <param name='aMargin'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarginInTwips(System.IntPtr aMargin);
		
		/// <summary>Member GetEdgeInTwips </summary>
		/// <param name='aEdge'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEdgeInTwips(System.IntPtr aEdge);
		
		/// <summary>Member SetupSilentPrinting </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupSilentPrinting();
		
		/// <summary>Member SetUnwriteableMarginInTwips </summary>
		/// <param name='aEdge'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginInTwips(System.IntPtr aEdge);
		
		/// <summary>Member GetUnwriteableMarginInTwips </summary>
		/// <param name='aEdge'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUnwriteableMarginInTwips(System.IntPtr aEdge);
	}
}
