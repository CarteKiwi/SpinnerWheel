using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/NumericWheelAdapter", DoNotGenerateAcw=true)]
	public partial class NumericWheelAdapter : global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/field[@name='DEFAULT_MAX_VALUE']"
		[Register ("DEFAULT_MAX_VALUE")]
		public const int DefaultMaxValue = (int) 9;
		// Metadata.xml XPath interface reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='NumericWheelAdapter.IntParamFunction']"
		[Register ("antistatic/spinnerwheel/adapters/NumericWheelAdapter$IntParamFunction", "", "Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter/IIntParamFunctionInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public partial interface IIntParamFunction : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='NumericWheelAdapter.IntParamFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("apply", "(I)Ljava/lang/Object;", "GetApply_IHandler:Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter/IIntParamFunctionInvoker, SpinnerWheel")]
			global::Java.Lang.Object Apply (int p0);

		}

		[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/NumericWheelAdapter$IntParamFunction", DoNotGenerateAcw=true)]
		internal class IIntParamFunctionInvoker : global::Java.Lang.Object, IIntParamFunction {

			static IntPtr java_class_ref = JNIEnv.FindClass ("antistatic/spinnerwheel/adapters/NumericWheelAdapter$IntParamFunction");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IIntParamFunctionInvoker); }
			}

			IntPtr class_ref;

			public static IIntParamFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IIntParamFunction> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "antistatic.spinnerwheel.adapters.NumericWheelAdapter.IntParamFunction"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IIntParamFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_apply_I;
#pragma warning disable 0169
			static Delegate GetApply_IHandler ()
			{
				if (cb_apply_I == null)
					cb_apply_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Apply_I);
				return cb_apply_I;
			}

			static IntPtr n_Apply_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter.IIntParamFunction __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter.IIntParamFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			}
#pragma warning restore 0169

			IntPtr id_apply_I;
			public unsafe global::Java.Lang.Object Apply (int p0)
			{
				if (id_apply_I == IntPtr.Zero)
					id_apply_I = JNIEnv.GetMethodID (class_ref, "apply", "(I)Ljava/lang/Object;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_I, __args), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/adapters/NumericWheelAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NumericWheelAdapter); }
		}

		protected NumericWheelAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_IILantistatic_spinnerwheel_adapters_NumericWheelAdapter_IntParamFunction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/constructor[@name='NumericWheelAdapter' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='antistatic.spinnerwheel.adapters.NumericWheelAdapter.IntParamFunction&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;IILantistatic/spinnerwheel/adapters/NumericWheelAdapter$IntParamFunction;)V", "")]
		public unsafe NumericWheelAdapter (global::Android.Content.Context p0, int p1, int p2, global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter.IIntParamFunction p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (NumericWheelAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;IILantistatic/spinnerwheel/adapters/NumericWheelAdapter$IntParamFunction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;IILantistatic/spinnerwheel/adapters/NumericWheelAdapter$IntParamFunction;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IILantistatic_spinnerwheel_adapters_NumericWheelAdapter_IntParamFunction_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IILantistatic_spinnerwheel_adapters_NumericWheelAdapter_IntParamFunction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;IILantistatic/spinnerwheel/adapters/NumericWheelAdapter$IntParamFunction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IILantistatic_spinnerwheel_adapters_NumericWheelAdapter_IntParamFunction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_IILantistatic_spinnerwheel_adapters_NumericWheelAdapter_IntParamFunction_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_IILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/constructor[@name='NumericWheelAdapter' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;IILjava/lang/String;)V", "")]
		public unsafe NumericWheelAdapter (global::Android.Content.Context p0, int p1, int p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (NumericWheelAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;IILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;IILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;IILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/constructor[@name='NumericWheelAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public unsafe NumericWheelAdapter (global::Android.Content.Context p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (NumericWheelAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/constructor[@name='NumericWheelAdapter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe NumericWheelAdapter (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (NumericWheelAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getItemsCount;
#pragma warning disable 0169
		static Delegate GetGetItemsCountHandler ()
		{
			if (cb_getItemsCount == null)
				cb_getItemsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemsCount);
			return cb_getItemsCount;
		}

		static int n_GetItemsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemsCount;
		public override unsafe int ItemsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/method[@name='getItemsCount' and count(parameter)=0]"
			[Register ("getItemsCount", "()I", "GetGetItemsCountHandler")]
			get {
				if (id_getItemsCount == IntPtr.Zero)
					id_getItemsCount = JNIEnv.GetMethodID (class_ref, "getItemsCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemsCount", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_addExact_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/method[@name='addExact' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addExact", "(II)I", "")]
		public static unsafe int AddExact (int p0, int p1)
		{
			if (id_addExact_II == IntPtr.Zero)
				id_addExact_II = JNIEnv.GetStaticMethodID (class_ref, "addExact", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_addExact_II, __args);
			} finally {
			}
		}

		static Delegate cb_getItemText_I;
#pragma warning disable 0169
		static Delegate GetGetItemText_IHandler ()
		{
			if (cb_getItemText_I == null)
				cb_getItemText_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItemText_I);
			return cb_getItemText_I;
		}

		static IntPtr n_GetItemText_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.GetItemTextFormatted (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItemText_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/method[@name='getItemText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemText", "(I)Ljava/lang/CharSequence;", "GetGetItemText_IHandler")]
		public override unsafe global::Java.Lang.ICharSequence GetItemTextFormatted (int p0)
		{
			if (id_getItemText_I == IntPtr.Zero)
				id_getItemText_I = JNIEnv.GetMethodID (class_ref, "getItemText", "(I)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItemText_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemText", "(I)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public string GetItemText (int p0)
		{
			global::Java.Lang.ICharSequence __result = GetItemTextFormatted (p0);
			return __result == null ? null : __result.ToString ();
		}

		static IntPtr id_negateExact_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/method[@name='negateExact' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("negateExact", "(I)I", "")]
		public static unsafe int NegateExact (int p0)
		{
			if (id_negateExact_I == IntPtr.Zero)
				id_negateExact_I = JNIEnv.GetStaticMethodID (class_ref, "negateExact", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_negateExact_I, __args);
			} finally {
			}
		}

		static Delegate cb_setMaxValue_I;
#pragma warning disable 0169
		static Delegate GetSetMaxValue_IHandler ()
		{
			if (cb_setMaxValue_I == null)
				cb_setMaxValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxValue_I);
			return cb_setMaxValue_I;
		}

		static void n_SetMaxValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/method[@name='setMaxValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxValue", "(I)V", "GetSetMaxValue_IHandler")]
		public virtual unsafe void SetMaxValue (int p0)
		{
			if (id_setMaxValue_I == IntPtr.Zero)
				id_setMaxValue_I = JNIEnv.GetMethodID (class_ref, "setMaxValue", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxValue_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxValue", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMinValue_I;
#pragma warning disable 0169
		static Delegate GetSetMinValue_IHandler ()
		{
			if (cb_setMinValue_I == null)
				cb_setMinValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinValue_I);
			return cb_setMinValue_I;
		}

		static void n_SetMinValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.NumericWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMinValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='NumericWheelAdapter']/method[@name='setMinValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMinValue", "(I)V", "GetSetMinValue_IHandler")]
		public virtual unsafe void SetMinValue (int p0)
		{
			if (id_setMinValue_I == IntPtr.Zero)
				id_setMinValue_I = JNIEnv.GetMethodID (class_ref, "setMinValue", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinValue_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinValue", "(I)V"), __args);
			} finally {
			}
		}

	}
}
