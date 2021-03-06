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
// Generated by IDLImporter from file nsISpeechService.idl
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
	
	
	/// <summary>
    /// A callback is implemented by the service. For direct audio services, it is
    /// required to implement these, although it could be helpful to use the
    /// cancel method for shutting down the speech resources.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c576de0c-8a3d-4570-be7e-9876d3e5bed2")]
	public interface nsISpeechTaskCallback
	{
		
		/// <summary>
        /// The user or application has paused the speech.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPause();
		
		/// <summary>
        /// The user or application has resumed the speech.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnResume();
		
		/// <summary>
        /// The user or application has canceled the speech.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCancel();
		
		/// <summary>
        /// The user or application has changed the volume of this speech.
        /// This is only used on indirect audio service type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnVolumeChanged(float aVolume);
	}
	
	/// <summary>
    /// A task is associated with a single utterance. It is provided by the browser
    /// to the service in the speak() method.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ad59949c-2437-4b35-8eeb-d760caab75c5")]
	public interface nsISpeechTask
	{
		
		/// <summary>
        /// Prepare browser for speech.
        ///
        /// @param aCallback callback object for mid-speech operations.
        /// @param aChannels number of audio channels. Only required
        /// in direct audio services
        /// @param aRate     audio rate. Only required in direct audio services
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Setup([MarshalAs(UnmanagedType.Interface)] nsISpeechTaskCallback aCallback, uint aChannels, uint aRate, int argc);
		
		/// <summary>
        /// Send audio data to browser.
        ///
        /// @param aData     an Int16Array with PCM-16 audio data.
        /// @param aLandmarks an array of sample offset and landmark pairs.
        /// Used for emiting boundary and mark events.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendAudio(ref Gecko.JsVal aData, ref Gecko.JsVal aLandmarks, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendAudioNative(@short aData, uint aDataLen);
		
		/// <summary>
        /// Dispatch start event.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchStart();
		
		/// <summary>
        /// Dispatch end event.
        ///
        /// @param aElapsedTime time in seconds since speech has started.
        /// @param aCharIndex   offset of spoken characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchEnd(float aElapsedTime, uint aCharIndex);
		
		/// <summary>
        /// Dispatch pause event.
        ///
        /// @param aElapsedTime time in seconds since speech has started.
        /// @param aCharIndex   offset of spoken characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchPause(float aElapsedTime, uint aCharIndex);
		
		/// <summary>
        /// Dispatch resume event.
        ///
        /// @param aElapsedTime time in seconds since speech has started.
        /// @param aCharIndex   offset of spoken characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchResume(float aElapsedTime, uint aCharIndex);
		
		/// <summary>
        /// Dispatch error event.
        ///
        /// @param aElapsedTime time in seconds since speech has started.
        /// @param aCharIndex   offset of spoken characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchError(float aElapsedTime, uint aCharIndex);
		
		/// <summary>
        /// Dispatch boundary event.
        ///
        /// @param aName        name of boundary, 'word' or 'sentence'
        /// @param aElapsedTime time in seconds since speech has started.
        /// @param aCharIndex   offset of spoken characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchBoundary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, float aElapsedTime, uint aCharIndex);
		
		/// <summary>
        /// Dispatch mark event.
        ///
        /// @param aName        mark identifier.
        /// @param aElapsedTime time in seconds since speech has started.
        /// @param aCharIndex   offset of spoken characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DispatchMark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName, float aElapsedTime, uint aCharIndex);
	}
	
	/// <summary>
    /// The main interface of a speech synthesis service.
    ///
    /// A service's speak method could be implemented in two ways:
    /// 1. Indirect audio - the service is responsible for outputting audio.
    /// The service calls the nsISpeechTask.dispatch* methods directly. Starting
    /// with dispatchStart() and ending with dispatchEnd or dispatchError().
    ///
    /// 2. Direct audio - the service provides us with PCM-16 data, and we output it.
    /// The service does not call the dispatch task methods directly. Instead,
    /// audio information is provided at setup(), and audio data is sent with
    /// sendAudio(). The utterance is terminated with an empty sendAudio().
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9b7d59db-88ff-43d0-b6ee-9f63d042d08f")]
	public interface nsISpeechService
	{
		
		/// <summary>
        /// Speak the given text using the voice identified byu the given uri. See
        /// W3C Speech API spec for information about pitch and rate.
        /// https://dvcs.w3.org/hg/speech-api/raw-file/tip/speechapi.html#utterance-attributes
        ///
        /// @param aText   text to utter.
        /// @param aUri    unique voice identifier.
        /// @param aVolume volume to speak voice in. Only relevant for indirect audio.
        /// @param aRate   rate to speak voice in.
        /// @param aPitch  pitch to speak voice in.
        /// @param aTask  task instance for utterance, used for sending events or audio
        /// data back to browser.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Speak([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUri, float aVolume, float aRate, float aPitch, [MarshalAs(UnmanagedType.Interface)] nsISpeechTask aTask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		SpeechServiceType GetServiceTypeAttribute();
	}
	
	/// <summary>nsISpeechServiceConsts </summary>
	public class nsISpeechServiceConsts
	{
		
		// 
		public const long SERVICETYPE_DIRECT_AUDIO = 1;
		
		// 
		public const long SERVICETYPE_INDIRECT_AUDIO = 2;
	}
}
