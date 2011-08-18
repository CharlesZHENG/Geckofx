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
// Generated by IDLImporter from file nsITelemetry.idl
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
	
	
	/// <summary>nsITelemetry </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("29464d3d-f838-4afb-a737-319fe0c6cc04")]
	public interface nsITelemetry
	{
		
		/// <summary>
        /// An object containing a snapshot from all of the currently registered histograms.
        /// { name1: {data1}, name2:{data2}...}
        /// where data is consists of the following properties:
        /// min - Minimal bucket size
        /// max - Maximum bucket size
        /// histogram_type - HISTOGRAM_EXPONENTIAL or HISTOGRAM_LINEAR
        /// counts - array representing contents of the buckets in the histogram
        /// ranges -  an array with calculated bucket sizes
        /// sum - sum of the bucket contents
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetHistogramSnapshotsAttribute();
		
		/// <summary>
        /// Create and return a histogram where bucket sizes increase exponentially. Parameters:
        /// @param name Unique histogram name
        /// @param min - Minimal bucket size
        /// @param max - Maximum bucket size
        /// @param bucket_count - number of buckets in the histogram.
        /// @param type - HISTOGRAM_EXPONENTIAL or HISTOGRAM_LINEAR
        /// The returned object has the following functions:
        /// add(int) - Adds an int value to the appropriate bucket
        /// snapshot() - Returns a snapshot of the histogram with the same data fields as in histogramSnapshots()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr NewHistogram([MarshalAs(UnmanagedType.LPStruct)] nsACString name, uint min, uint max, uint bucket_count, uint histogram_type);
	}
}
