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
// Generated by IDLImporter from file nsPIPlacesDatabase.idl
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
    /// This is a private interface used by Places components to get access to the
    /// database.  If outside consumers wish to use this, they should only read from
    /// the database so they do not break any internal invariants.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6eb7ed3d-13ca-450b-b370-15c75e2f3dab")]
	public interface nsPIPlacesDatabase
	{
		
		/// <summary>
        /// The database connection used by Places.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageConnection GetDBConnectionAttribute();
		
		/// <summary>
        /// Asynchronously executes the statement created from queries.
        ///
        /// @see nsINavHistoryService::executeQueries
        /// @note THIS IS A TEMPORARY API.  Don't rely on it, since it will be replaced
        /// in future versions by a real async querying API.
        /// @note Results obtained from this method differ from results obtained from
        /// executeQueries, because there is additional filtering and sorting
        /// done by the latter.  Thus you should use executeQueries, unless you
        /// are absolutely sure that the returned results are fine for
        /// your use-case.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStoragePendingStatement AsyncExecuteLegacyQueries(nsINavHistoryQuery aQueries, uint aQueryCount, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryQueryOptions aOptions, mozIStorageStatementCallback aCallback);
	}
}
