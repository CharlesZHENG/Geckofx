// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIAccessibleImage.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIAccessibleImage </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("09086623-0f09-4310-ac56-c2cda7c29648")]
	public interface nsIAccessibleImage
	{
		
		/// <summary>
        /// Returns the coordinates of the image.
        ///
        /// @param coordType  specifies coordinates origin (for available constants
        /// refer to nsIAccessibleCoordinateType)
        /// @param x          the x coordinate
        /// @param y          the y coordinate
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImagePosition(uint coordType, ref int x, ref int y);
		
		/// <summary>
        /// Returns the size of the image.
        ///
        /// @param width      the heigth
        /// @param height     the width
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImageSize(ref int width, ref int height);
	}
}
