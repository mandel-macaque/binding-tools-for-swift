// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Runtime.InteropServices;
using SwiftRuntimeLibrary.SwiftMarshal;
using Xamarin.iOS;

namespace SwiftRuntimeLibrary {
	public class SwiftEquatableProxy : BaseProxy, ISwiftEquatable {
		ISwiftEquatable actualImpl;

		public SwiftEquatableProxy (ISwiftEquatable actualImplementation, EveryProtocol everyProtocol)
			: base (typeof (ISwiftEquatable), everyProtocol)
		{
			actualImpl = actualImplementation;
		}

		public SwiftEquatableProxy (ISwiftExistentialContainer container)
			: base (typeof (ISwiftEquatable), null)
		{
			throw new NotImplementedException ("SwiftEquatableProxy should never get constructed from an existential container.");
		}

		struct Equatable_xam_vtable {
			public delegate bool Delfunc0 (IntPtr one, IntPtr two);
			[MarshalAs (UnmanagedType.FunctionPtr)]
			public Delfunc0 func0;
		}

		static Equatable_xam_vtable vtableIEquatable;
		static SwiftEquatableProxy ()
		{
			XamSetVTable ();
		}

#if __IOS__
		[MonoPInvokeCallback(typeof(Equatable_xam_vtable.Delfunc0))]
#endif
		static bool EqFunc (IntPtr oneptr, IntPtr twoptr)
		{
			if (oneptr == twoptr)
				return true;

			var one = SwiftObjectRegistry.Registry.ProxyForEveryProtocolHandle<ISwiftEquatable> (oneptr);
			var two = SwiftObjectRegistry.Registry.ProxyForEveryProtocolHandle<ISwiftEquatable> (twoptr);

			return one.OpEquals (two);
		}

		static void XamSetVTable ()
		{
			vtableIEquatable.func0 = EqFunc;
			PISetVtable (ref vtableIEquatable);
		}

		public bool OpEquals (ISwiftEquatable other)
		{
			if (this == other)
				return true;
			var otherProxy = other as SwiftEquatableProxy;
			if (otherProxy != null) {
				return actualImpl.OpEquals (otherProxy.actualImpl);
			}
			return actualImpl.OpEquals (other);
		}


		static IntPtr protocolWitnessTable;
		public static IntPtr ProtocolWitnessTable {
			get {
				if (protocolWitnessTable == IntPtr.Zero)
					protocolWitnessTable = SwiftCore.ProtocolWitnessTableFromFile (SwiftCore.kXamGlue, "$s7XamGlue13EveryProtocolCSQAAMc",
						EveryProtocol.GetSwiftMetatype ());
				return protocolWitnessTable;
			}
		}

		[DllImport (SwiftCore.kXamGlue, EntryPoint = XamGlueConstants.SwiftEquatableProxy_PISetVtable)]
		static extern void PISetVtable (ref Equatable_xam_vtable vt);
	}
}
