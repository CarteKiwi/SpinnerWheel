using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='ItemsRange']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/ItemsRange", DoNotGenerateAcw=true)]
	public partial class ItemsRange : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/ItemsRange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemsRange); }
		}

		protected ItemsRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='ItemsRange']/constructor[@name='ItemsRange' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ItemsRange ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ItemsRange)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='ItemsRange']/constructor[@name='ItemsRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe ItemsRange (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ItemsRange)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.ItemsRange __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.ItemsRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='ItemsRange']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFirst;
#pragma warning disable 0169
		static Delegate GetGetFirstHandler ()
		{
			if (cb_getFirst == null)
				cb_getFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirst);
			return cb_getFirst;
		}

		static int n_GetFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.ItemsRange __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.ItemsRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.First;
		}
#pragma warning restore 0169

		static IntPtr id_getFirst;
		public virtual unsafe int First {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='ItemsRange']/method[@name='getFirst' and count(parameter)=0]"
			[Register ("getFirst", "()I", "GetGetFirstHandler")]
			get {
				if (id_getFirst == IntPtr.Zero)
					id_getFirst = JNIEnv.GetMethodID (class_ref, "getFirst", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFirst);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirst", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLast;
#pragma warning disable 0169
		static Delegate GetGetLastHandler ()
		{
			if (cb_getLast == null)
				cb_getLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLast);
			return cb_getLast;
		}

		static int n_GetLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.ItemsRange __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.ItemsRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last;
		}
#pragma warning restore 0169

		static IntPtr id_getLast;
		public virtual unsafe int Last {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='ItemsRange']/method[@name='getLast' and count(parameter)=0]"
			[Register ("getLast", "()I", "GetGetLastHandler")]
			get {
				if (id_getLast == IntPtr.Zero)
					id_getLast = JNIEnv.GetMethodID (class_ref, "getLast", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLast);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLast", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_contains_I;
#pragma warning disable 0169
		static Delegate GetContains_IHandler ()
		{
			if (cb_contains_I == null)
				cb_contains_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Contains_I);
			return cb_contains_I;
		}

		static bool n_Contains_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.ItemsRange __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.ItemsRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Contains (p0);
		}
#pragma warning restore 0169

		static IntPtr id_contains_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='ItemsRange']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("contains", "(I)Z", "GetContains_IHandler")]
		public virtual unsafe bool Contains (int p0)
		{
			if (id_contains_I == IntPtr.Zero)
				id_contains_I = JNIEnv.GetMethodID (class_ref, "contains", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(I)Z"), __args);
			} finally {
			}
		}

	}
}
