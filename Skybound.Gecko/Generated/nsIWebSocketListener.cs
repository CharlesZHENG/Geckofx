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
// Generated by IDLImporter from file nsIWebSocketListener.idl
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
	
	
	/// <summary>
    /// nsIWebSocketListener: passed to nsIWebSocketChannel::AsyncOpen. Receives
    /// websocket traffic events as they arrive.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b0c27050-31e9-42e5-bc59-499d54b52f99")]
	public interface nsIWebSocketListener
	{
		
		/// <summary>
        /// Called to signify the establishment of the message stream.
        /// Any listener that receives onStart will also receive OnStop.
        ///
        /// @param aContext user defined context
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStart([MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the completion of the message stream.
        /// OnStop is the final notification the listener will receive and it
        /// completes the WebSocket connection. This event can be received in error
        /// cases even if nsIWebSocketChannel::Close() has not been called.
        ///
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStop([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called to deliver text message.
        ///
        /// @param aContext user defined context
        /// @param aMsg the message data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnMessageAvailable([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMsg);
		
		/// <summary>
        /// Called to deliver binary message.
        ///
        /// @param aContext user defined context
        /// @param aMsg the message data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnBinaryMessageAvailable([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACString aMsg);
		
		/// <summary>
        /// Called to acknowledge message sent via sendMsg() or sendBinaryMsg.
        ///
        /// @param aContext user defined context
        /// @param aSize number of bytes placed in OS send buffer
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAcknowledge([MarshalAs(UnmanagedType.Interface)] nsISupports aContext, uint aSize);
		
		/// <summary>
        /// Called to inform receipt of WebSocket Close message from server.
        /// In the case of errors onStop() can be called without ever
        /// receiving server close.
        ///
        /// No additional messages through onMessageAvailable(),
        /// onBinaryMessageAvailable() or onAcknowledge() will be delievered
        /// to the listener after onServerClose(), though outgoing messages can still
        /// be sent through the nsIWebSocketChannel connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnServerClose([MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
	}
}
