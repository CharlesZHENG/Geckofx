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
// Generated by IDLImporter from file nsIThreadInternal.idl
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
    /// The XPCOM thread object implements this interface, which allows a consumer
    /// to observe dispatch activity on the thread.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("504e9e1f-70e1-4f33-a785-5840a4680414")]
	public interface nsIThreadInternal : nsIThread
	{
		
		/// <summary>
        /// Dispatch an event to this event target.  This function may be called from
        /// any thread, and it may be called re-entrantly.
        ///
        /// @param event
        /// The event to dispatch.
        /// @param flags
        /// The flags modifying event dispatch.  The flags are described in detail
        /// below.
        ///
        /// @throws NS_ERROR_INVALID_ARG
        /// Indicates that event is null.
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that the thread is shutting down and has finished processing
        /// events, so this event would never run and has not been dispatched.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Dispatch([MarshalAs(UnmanagedType.Interface)] nsIRunnable @event, uint flags);
		
		/// <summary>
        /// Check to see if this event target is associated with the current thread.
        ///
        /// @returns
        /// A boolean value that if "true" indicates that events dispatched to this
        /// event target will run on the current thread (i.e., the thread calling
        /// this method).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsOnCurrentThread();
		
		/// <summary>
        /// @returns
        /// The NSPR thread object corresponding to this nsIThread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetPRThreadAttribute();
		
		/// <summary>
        /// Shutdown the thread.  This method prevents further dispatch of events to
        /// the thread, and it causes any pending events to run to completion before
        /// the thread joins (see PR_JoinThread) with the current thread.  During this
        /// method call, events for the current thread may be processed.
        ///
        /// This method MAY NOT be executed from the thread itself.  Instead, it is
        /// meant to be executed from another thread (usually the thread that created
        /// this thread or the main application thread).  When this function returns,
        /// the thread will be shutdown, and it will no longer be possible to dispatch
        /// events to the thread.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that this method was erroneously called when this thread was
        /// the current thread, that this thread was not created with a call to
        /// nsIThreadManager::NewThread, or if this method was called more than once
        /// on the thread object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Shutdown();
		
		/// <summary>
        /// This method may be called to determine if there are any events ready to be
        /// processed.  It may only be called when this thread is the current thread.
        ///
        /// Because events may be added to this thread by another thread, a "false"
        /// result does not mean that this thread has no pending events.  It only
        /// means that there were no pending events when this method was called.
        ///
        /// @returns
        /// A boolean value that if "true" indicates that this thread has one or
        /// more pending events.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that this method was erroneously called when this thread was
        /// not the current thread.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasPendingEvents();
		
		/// <summary>
        /// Process the next event.  If there are no pending events, then this method
        /// may wait -- depending on the value of the mayWait parameter -- until an
        /// event is dispatched to this thread.  This method is re-entrant but may
        /// only be called if this thread is the current thread.
        ///
        /// @param mayWait
        /// A boolean parameter that if "true" indicates that the method may block
        /// the calling thread to wait for a pending event.
        ///
        /// @returns
        /// A boolean value that if "true" indicates that an event was processed.
        ///
        /// @throws NS_ERROR_UNEXPECTED
        /// Indicates that this method was erroneously called when this thread was
        /// not the current thread.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool ProcessNextEvent([MarshalAs(UnmanagedType.U1)] bool mayWait);
		
		/// <summary>
        /// Get/set the current thread observer (may be null).  This attribute may be
        /// read from any thread, but must only be set on the thread corresponding to
        /// this thread object.  The observer will be released on the thread
        /// corresponding to this thread object after all other events have been
        /// processed during a call to Shutdown.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIThreadObserver GetObserverAttribute();
		
		/// <summary>
        /// Get/set the current thread observer (may be null).  This attribute may be
        /// read from any thread, but must only be set on the thread corresponding to
        /// this thread object.  The observer will be released on the thread
        /// corresponding to this thread object after all other events have been
        /// processed during a call to Shutdown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetObserverAttribute([MarshalAs(UnmanagedType.Interface)] nsIThreadObserver aObserver);
		
		/// <summary>
        /// The current recursion depth, 0 when no events are running, 1 when a single
        /// event is running, and higher when nested events are running. Must only be
        /// called on the target thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRecursionDepthAttribute();
		
		/// <summary>
        /// Add an observer that will *only* receive onProcessNextEvent and
        /// afterProcessNextEvent callbacks. Always called on the target thread, and
        /// the implementation does not have to be threadsafe. Order of callbacks is
        /// not guaranteed (i.e. afterProcessNextEvent may be called first depending on
        /// whether or not the observer is added in a nested loop). Holds a strong ref.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIThreadObserver observer);
		
		/// <summary>
        /// Remove an observer added via the addObserver call. Once removed the
        /// observer will never be called again by the thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIThreadObserver observer);
	}
	
	/// <summary>
    /// This interface provides the observer with hooks to implement a layered
    /// event queue.  For example, it is possible to overlay processing events
    /// for a GUI toolkit on top of the events for a thread:
    ///
    /// var NativeQueue;
    /// Observer = {
    /// onDispatchedEvent(thread) {
    /// NativeQueue.signal();
    /// }
    /// onProcessNextEvent(thread, mayWait, recursionDepth) {
    /// if (NativeQueue.hasNextEvent())
    /// NativeQueue.processNextEvent();
    /// while (mayWait && !thread.hasPendingEvent()) {
    /// NativeQueue.wait();
    /// NativeQueue.processNextEvent();
    /// }
    /// }
    /// };
    ///
    /// NOTE: The implementation of this interface must be threadsafe.
    ///
    /// NOTE: It is valid to change the thread's observer during a call to an
    /// observer method.
    ///
    /// NOTE: Will be split into two interfaces soon: one for onProcessNextEvent and
    /// afterProcessNextEvent, then another that inherits the first and adds
    /// onDispatchedEvent.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("81D0B509-F198-4417-8020-08EB4271491F")]
	public interface nsIThreadObserver
	{
		
		/// <summary>
        /// This method is called after an event has been dispatched to the thread.
        /// This method may be called from any thread.
        ///
        /// @param thread
        /// The thread where the event is being dispatched.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDispatchedEvent([MarshalAs(UnmanagedType.Interface)] nsIThreadInternal thread);
		
		/// <summary>
        /// This method is called (from nsIThread::ProcessNextEvent) before an event
        /// is processed.  This method is only called on the target thread.
        ///
        /// @param thread
        /// The thread being asked to process another event.
        /// @param mayWait
        /// Indicates whether or not the method is allowed to block the calling
        /// thread.  For example, this parameter is false during thread shutdown.
        /// @param recursionDepth
        /// Indicates the number of calls to ProcessNextEvent on the call stack in
        /// addition to the current call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProcessNextEvent([MarshalAs(UnmanagedType.Interface)] nsIThreadInternal thread, [MarshalAs(UnmanagedType.U1)] bool mayWait, uint recursionDepth);
		
		/// <summary>
        /// This method is called (from nsIThread::ProcessNextEvent) after an event
        /// is processed.  This method is only called on the target thread.
        ///
        /// @param thread
        /// The thread that processed another event.
        /// @param recursionDepth
        /// Indicates the number of calls to ProcessNextEvent on the call stack in
        /// addition to the current call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AfterProcessNextEvent([MarshalAs(UnmanagedType.Interface)] nsIThreadInternal thread, uint recursionDepth);
	}
}
