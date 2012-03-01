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
// Generated by IDLImporter from file nsIStreamConverter.idl
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
	
	
	/// <summary>
    /// nsIStreamConverter provides an interface to implement when you have code
    /// that converts data from one type to another.
    ///
    /// Suppose you had code that converted plain text into HTML. You could implement
    /// this interface to allow everyone else to use your conversion logic using a
    /// standard api.
    /// <p>
    /// <b>STREAM CONVERTER USERS</b>
    ///
    /// There are currently two ways to use a stream converter:
    /// <ol>
    /// <li> <b>SYNCHRONOUS</b> Stream to Stream
    /// You can supply the service with a stream of type X
    /// and it will convert it to your desired output type and return
    /// a converted (blocking) stream to you.</li>
    ///
    /// <li> <b>ASYNCHRONOUS</b> nsIStreamListener to nsIStreamListener
    /// You can supply data directly to the converter by calling it's
    /// nsIStreamListener::OnDataAvailable() method. It will then
    /// convert that data from type X to your desired output type and
    /// return converted data to you via the nsIStreamListener you passed
    /// in by calling its OnDataAvailable() method.</li>
    /// </ol>
    /// <p>
    ///
    /// <b>STREAM CONVERTER SUPPLIERS</b>
    ///
    /// Registering a stream converter:
    /// Stream converter registration is a two step process. First of all the stream
    /// converter implementation must register itself with the component manager using
    /// a contractid in the format below. Second, the stream converter must add the contractid
    /// to the registry.
    ///
    /// Stream converter contractid format (the stream converter root key is defined in this
    /// file):
    ///
    /// <pre>@mozilla.org/streamconv;1?from=FROM_MIME_TYPE&to=TO_MIME_TYPE</pre>
    ///
    /// @author Jud Valeski
    /// @see nsIStreamConverterService
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0b6e2c69-5cf5-48b0-9dfd-c95950e2cc7b")]
	public interface nsIStreamConverter : nsIStreamListener
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// If that number is greater than or equal to 2^32, this parameter
        /// will be PR_UINT32_MAX (2^32 - 1).
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, uint aOffset, uint aCount);
		
		/// <summary>
        /// <b>SYNCRONOUS VERSION</b>
        /// Converts a stream of one type, to a stream of another type.
        ///
        /// Use this method when you have a stream you want to convert.
        ///
        /// @param aFromStream   The stream representing the original/raw data.
        /// @param aFromType     The MIME type of aFromStream.
        /// @param aToType       The MIME type of the returned stream.
        /// @param aCtxt         Either an opaque context, or a converter specific context
        /// (implementation specific).
        /// @return              The converted stream. NOTE: The returned stream may not
        /// already be converted. An efficient stream converter
        /// implementation will converter data on demand rather than
        /// buffering the converted data until it is used.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, [MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);
		
		/// <summary>
        /// <b>ASYNCRONOUS VERSION</b>
        /// Converts data arriving via the converter's nsIStreamListener::OnDataAvailable()
        /// method from one type to another, pushing the converted data out to the caller
        /// via aListener::OnDataAvailable().
        ///
        /// Use this method when you want to proxy (and convert) nsIStreamListener callbacks
        /// asynchronously.
        ///
        /// @param aFromType     The MIME type of the original/raw data.
        /// @param aToType       The MIME type of the converted data.
        /// @param aListener     The listener who receives the converted data.
        /// @param aCtxt         Either an opaque context, or a converter specific context
        /// (implementation specific).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] string aFromType, [MarshalAs(UnmanagedType.LPStr)] string aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports aCtxt);
	}
}
