using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='ArrayWheelAdapter']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/ArrayWheelAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ArrayWheelAdapter : global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/adapters/ArrayWheelAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayWheelAdapter); }
		}

		protected ArrayWheelAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='ArrayWheelAdapter']/constructor[@name='ArrayWheelAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='T[]']]"
		[Register (".ctor", "(Landroid/content/Context;[Ljava/lang/Object;)V", "")]
		public unsafe ArrayWheelAdapter (global::Android.Content.Context p0, global::Java.Lang.Object[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ArrayWheelAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;[Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;[Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;[Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_arrayLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_arrayLjava_lang_Object_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Antistatic.Spinnerwheel.Adapters.ArrayWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.ArrayWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemsCount;
		public override unsafe int ItemsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='ArrayWheelAdapter']/method[@name='getItemsCount' and count(parameter)=0]"
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
			global::Antistatic.Spinnerwheel.Adapters.ArrayWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.ArrayWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.GetItemTextFormatted (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItemText_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='ArrayWheelAdapter']/method[@name='getItemText' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
