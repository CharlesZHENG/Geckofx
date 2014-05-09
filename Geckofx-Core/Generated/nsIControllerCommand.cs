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
// Generated by IDLImporter from file nsIControllerCommand.idl
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
    /// nsIControllerCommand
    ///
    /// A generic command interface. You can register an nsIControllerCommand
    /// with the nsIControllerCommandTable.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0eae9a46-1dd2-11b2-aca0-9176f05fe9db")]
	public interface nsIControllerCommand
	{
		
		/// <summary>
        /// Returns true if the command is currently enabled. An nsIControllerCommand
        /// can implement more than one commands; say, a group of related commands
        /// (e.g. delete left/delete right). Because of this, the command name is
        /// passed to each method.
        ///
        /// @param aCommandName  the name of the command for which we want the enabled
        /// state.
        /// @param aCommandContext    a cookie held by the nsIControllerCommandTable,
        /// allowing the command to get some context information.
        /// The contents of this cookie are implementation-defined.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommandStateParams([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParams, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);
		
		/// <summary>
        /// Execute the name command.
        ///
        /// @param aCommandName  the name of the command to execute.
        ///
        /// @param aCommandContext    a cookie held by the nsIControllerCommandTable,
        /// allowing the command to get some context information.
        /// The contents of this cookie are implementation-defined.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommandParams([MarshalAs(UnmanagedType.LPStr)] string aCommandName, [MarshalAs(UnmanagedType.Interface)] nsICommandParams aParams, [MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);
	}
}
