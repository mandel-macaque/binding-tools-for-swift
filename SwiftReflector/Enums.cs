// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace SwiftReflector {
	public enum CoreCompoundType {
		ModuleName,
		Function,
		Class,
		Struct,
		Array,
		Scalar,
		Tuple,
		BoundGeneric,
		MetaClass,
		LazyCache,
		DirectMetadata,
		NominalTypeDescriptor,
		Variable,
		Thunk,
		ProtocolList,
		ProtocolTypeDescriptor,
		UnboundGeneric,
		GenericReference,
		FieldOffset,
		ArgumentInitializer,
		UnsafeMutableAddressor,
		ProtocolConformanceDescriptor,
		MethodDescriptor,
		ModuleDescriptor,
		PropertyDescriptor,
		MetadataDescriptor,
		ProtocolRequirementsBaseDescriptor,
		BaseConformanceDescriptor,
	}

	public enum CoreBuiltInType {
		Int,
		UInt,
		Double,
		Float,
		Bool,
	}

	public enum EntityType {
		None,
		Class,
		Struct,
		Enum,
		TrivialEnum,
		Scalar,
		Protocol,
		Tuple,
		Closure,
		ProtocolList,
	}

	public enum MemberNesting {
		Class,
		Struct,
		Enum,
		Protocol,
	}

	public enum MemberType {
		Function,
		UncurriedFunction,
		Allocator,
		Constructor,
		Destructor,
		Deallocator,
		Getter,
		Setter,
		Materializer,
		ExplicitClosure,
		Addressor,
		CFunction,
		Initializer,
	}

	public enum PropertyType {
		Getter,
		Setter,
		Materializer,
		DidSet,
		WillSet,
		ModifyAccessor,
	}

	public enum AddressorType {
		OwningMutable,
		NativeOwningMutable,
		NativePinningMutable,
		UnsafeMutable,
		Owning,
		NativeOwning,
		NativePinning,
		Unsafe,
	}

	public enum InitializerType {
		Variable,
	}

	public enum ThunkType {
		Reabstraction,
		ReabstractionHelper,
		ProtocolWitness,
		Curry,
	}

	public enum OperatorType {
		None,
		Prefix,
		Postfix,
		Infix,
		Unknown,
	}

	public enum WitnessType {
		Class,
		Value,
		Protocol,
		ProtocolAccessor,
	}

	public enum PlatformName {
		None, // desktop managed executable
		macOS, // Xamarin.Mac app
		iOS,
		watchOS,
		tvOS,
	}

	public enum SwiftTypeAttribute {
		ObjC,
		NonObjC,
		Dynamic,
		ImplFunction,
		DirectMethodReference,
	}
}

