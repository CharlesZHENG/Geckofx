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
// Generated by IDLImporter from file nsIGonkSmsService.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("76681431-8261-4540-bab8-24ef3866e8b6")]
	public interface nsIGonkSmsService : nsISmsService
	{
		
		/// <summary>
        /// The default RIL service ID used for SMS.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetSmsDefaultServiceIdAttribute();
		
		/// <summary>
        /// Get the information necessary to create a multi-part SMS for a given text.
        ///
        /// @param text
        /// The text message content.
        /// @param request
        /// The callback object to use. It invokes
        /// |notifySegmentInfoForTextGot| on success, or
        /// |notifyGetSegmentInfoForTextFailed| on failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSegmentInfoForText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase text, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
		
		/// <summary>
        /// Send a SMS.
        ///
        /// @param serviceId
        /// The ID of RIL service to use.
        /// @param number
        /// Destination number in string.
        /// @param message
        /// The text message content.
        /// @param silent
        /// |true| to send a silent message. It's used to make a SMS based
        /// authentication for some services such as mobile billing.
        /// @param request
        /// The callback object to use. It invokes |notifyMessageSent| on
        /// success, or |notifySendMessageFailed| on failure.
        /// @throws NS_ERROR_INVALID_ARG
        /// If |serviceId| exceeds the max value of available IDs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Send(uint serviceId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
		
		/// <summary>
        /// Add a number to the list of silent message originators. When receiving a
        /// SMS sent from one of the numbers in the list, |SmsService| will notify
        /// observers through the topic "silent-sms-received".
        ///
        /// It's used when a SMS based authentication has been initiated and the client
        /// is waiting for an incoming silent message containing the authentication
        /// result.
        ///
        /// @param number
        /// Originator number in string.
        /// @throw NS_ERROR_UNEXPECTED
        /// If the given number has already been added before.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddSilentNumber([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number);
		
		/// <summary>
        /// Remove a number from the silent message originator list.
        ///
        /// @param number
        /// Originator number in string.
        /// @throws NS_ERROR_INVALID_ARG
        /// If the number doesn't exist in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveSilentNumber([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number);
		
		/// <summary>
        /// Get the short message service center address of given |serviceId|.
        ///
        /// @param serviceId
        /// The ID of RIL service to use.
        /// @param request
        /// The callback object to use. It invokes |notifyGetSmscAddress| on
        /// success, or |notifyGetSmscAddressFailed| on failure.
        /// @throws NS_ERROR_INVALID_ARG
        /// If |serviceId| exceeds the max value of available IDs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSmscAddress(uint serviceId, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
		
		/// <summary>
        /// Set the short message service center address of given |serviceId|.
        ///
        /// @param serviceId
        /// The ID of RIL service to use.
        /// @param number
        /// Number part of the SMSC address.
        /// @param typeOfNumber
        /// Type of number of the SMSC address.
        /// @param numberPlanIdentification
        /// Number plan identification of the SMSC address.
        /// @param request
        /// The callback object to use. It invokes |notifySetSmscAddress| on
        /// success, or |notifySetSmscAddressFailed| on failure.
        /// @throws NS_ERROR_INVALID_ARG
        /// If |serviceId| exceeds the max value of available IDs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSmscAddress(uint serviceId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase number, uint typeOfNumber, uint numberPlanIdentification, [MarshalAs(UnmanagedType.Interface)] nsIMobileMessageCallback request);
		
		/// <summary>
        /// Called when a short message has been received by the network.
        ///
        /// @param aServiceId
        /// The ID of the service where this message is received from.
        /// @param aSMSC
        /// SMS Center address.
        /// @param aSentTimestamp
        /// The time stamp when message is arrived to SMSC.
        /// @param aSender
        /// The sender's address of this message.
        /// @param aPid
        /// Protocol Identifier, See TS 23.040, subcluase 9.2.3.9.
        /// Set to 0 if invalid.
        /// @param aEncoding
        /// The encoding of message body.
        /// SMS_MESSAGE_ENCODING_*.
        /// @param aMessageClass
        /// A predefined constant of nsISmsService.MESSAGE_CLASS_TYPE_*.
        /// @param aLanguage
        /// ISO-639-1 language code for this message. Null if unspecified.
        /// @param aSegmentRef, aSegmentSeq, aSegmentMaxSeq
        /// Concatenation info. See TS 23.040, subclause 9.2.3.24.1.
        /// All set to 1 if no need for concatenatenation.
        /// @param aOriginatorPort, aDestinationPort
        /// Application Port Addressing. See TS 23.040 subclause 9.2.3.24.3~4.
        /// All set to 1 if no need for concatenatenation.
        /// @param aMwiPresent
        /// True if MWI is presented in this message.
        /// @param aMwiDiscard
        /// True if MWI has to be discarded after received.
        /// @param aMwiMsgCount
        /// The number of messages waiting in the voicemail server.
        /// -1 if number is unknown from the decoded MWI.
        /// @param aMwiActive
        /// True if there are messages waiting in the voicemail server.
        /// @param aCdmaMessageType
        /// CDMA SMS Message Type, as defined in 3GPP2 C.S0015-A v2.0, Table 3.4-1
        /// Set to 0 if invalid.
        /// @param aCdmaTeleservice
        /// SMS Teleservice Identitifier, as defined in 3GPP2 N.S0005, Table 175.
        /// Set to 0 if invalid.
        /// @param aCdmaServiceCategory
        /// CDMA Service Category, 3GPP2 C.R1001-D v2.0, 9.3 Service Category.
        /// Set to 0 if invalid.
        /// @param aBody
        /// Text message body.
        /// @param aData
        /// Binary message body.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyMessageReceived(
					uint aServiceId, 
					[MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSMSC, 
					long aSentTimestamp, 
					[MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSender, 
					ushort aPid, 
					ushort aEncoding, 
					uint aMessageClass, 
					[MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLanguage, 
					ushort aSegmentRef, 
					ushort aSegmentSeq, 
					ushort aSegmentMaxSeq, 
					uint aOriginatorPort, 
					uint aDestinationPort, 
					[MarshalAs(UnmanagedType.U1)] bool aMwiPresent, 
					[MarshalAs(UnmanagedType.U1)] bool aMwiDiscard, 
					short aMwiMsgCount, 
					[MarshalAs(UnmanagedType.U1)] bool aMwiActive, 
					ushort aCdmaMessageType, 
					uint aCdmaTeleservice, 
					uint aCdmaServiceCategory, 
					[MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBody, 
					[MarshalAs(UnmanagedType.LPArray, SizeParamIndex=22)] byte[] aData, 
					uint aDataLength);
	}
	
	/// <summary>nsIGonkSmsServiceConsts </summary>
	public class nsIGonkSmsServiceConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this file,
        // You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const ushort SMS_MESSAGE_ENCODING_7BITS_ALPHABET = 0x00;
		
		// 
		public const ushort SMS_MESSAGE_ENCODING_8BITS_ALPHABET = 0x04;
		
		// 
		public const ushort SMS_MESSAGE_ENCODING_16BITS_ALPHABET = 0x08;
		
		// 
		public const ulong SMS_APPLICATION_PORT_INVALID = 0xFFFFFFFF;
	}
}
