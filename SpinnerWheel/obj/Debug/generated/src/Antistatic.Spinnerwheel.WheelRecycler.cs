using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelRecycler']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/WheelRecycler", DoNotGenerateAcw=true)]
	public partial class WheelRecycler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/WheelRecycler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelRecycler); }
		}

		protected WheelRecycler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lantistatic_spinnerwheel_AbstractWheel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelRecycler']/constructor[@name='WheelRecycler' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.AbstractWheel']]"
		[Register (".ctor", "(Lantistatic/spinnerwheel/AbstractWheel;)V", "")]
		public unsafe WheelRecycler (global::Antistatic.Spinnerwheel.AbstractWheel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WheelRecycler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lantistatic/spinnerwheel/AbstractWheel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lantistatic/spinnerwheel/AbstractWheel;)V", __args);
					return;
				}

				if (id_ctor_Lantistatic_spinnerwheel_AbstractWheel_ == IntPtr.Zero)
					id_ctor_Lantistatic_spinnerwheel_AbstractWheel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lantistatic/spinnerwheel/AbstractWheel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lantistatic_spinnerwheel_AbstractWheel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lantistatic_spinnerwheel_AbstractWheel_, __args);
			} finally {
			}
		}

		static Delegate cb_getEmptyItem;
#pragma warning disable 0169
		static Delegate GetGetEmptyItemHandler ()
		{
			if (cb_getEmptyItem == null)
				cb_getEmptyItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmptyItem);
			return cb_getEmptyItem;
		}

		static IntPtr n_GetEmptyItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.WheelRecycler __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelRecycler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EmptyItem);
		}
#pragma warning restore 0169

		static IntPtr id_getEmptyItem;
		public virtual unsafe global::Android.Views.View EmptyItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelRecycler']/method[@name='getEmptyItem' and count(parameter)=0]"
			[Register ("getEmptyItem", "()Landroid/view/View;", "GetGetEmptyItemHandler")]
			get {
				if (id_getEmptyItem == IntPtr.Zero)
					id_getEmptyItem = JNIEnv.GetMethodID (class_ref, "getEmptyItem", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmptyItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmptyItem", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItem;
#pragma warning disable 0169
		static Delegate GetGetItemHandler ()
		{
			if (cb_getItem == null)
				cb_getItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItem);
			return cb_getItem;
		}

		static IntPtr n_GetItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.WheelRecycler __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelRecycler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Item);
		}
#pragma warning restore 0169

		static IntPtr id_getItem;
		public virtual unsafe global::Android.Views.View Item {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelRecycler']/method[@name='getItem' and count(parameter)=0]"
			[Register ("getItem", "()Landroid/view/View;", "GetGetItemHandler")]
			get {
				if (id_getItem == IntPtr.Zero)
					id_getItem = JNIEnv.GetMethodID (class_ref, "getItem", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAll);
			return cb_clearAll;
		}

		static void n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.WheelRecycler __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelRecycler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelRecycler']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler")]
		public virtual unsafe void ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_;
#pragma warning disable 0169
		static Delegate GetRecycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_Handler ()
		{
			if (cb_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_ == null)
				cb_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_RecycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_);
			return cb_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_;
		}

		static int n_RecycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Antistatic.Spinnerwheel.WheelRecycler __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelRecycler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.LinearLayout p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.ItemsRange p2 = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.ItemsRange> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RecycleItems (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelRecycler']/method[@name='recycleItems' and count(parameter)=3 and parameter[1][@type='android.widget.LinearLayout'] and parameter[2][@type='int'] and parameter[3][@type='antistatic.spinnerwheel.ItemsRange']]"
		[Register ("recycleItems", "(Landroid/widget/LinearLayout;ILantistatic/spinnerwheel/ItemsRange;)I", "GetRecycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_Handler")]
		public virtual unsafe int RecycleItems (global::Android.Widget.LinearLayout p0, int p1, global::Antistatic.Spinnerwheel.ItemsRange p2)
		{
			if (id_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_ == IntPtr.Zero)
				id_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_ = JNIEnv.GetMethodID (class_ref, "recycleItems", "(Landroid/widget/LinearLayout;ILantistatic/spinnerwheel/ItemsRange;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_recycleItems_Landroid_widget_LinearLayout_ILantistatic_spinnerwheel_ItemsRange_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycleItems", "(Landroid/widget/LinearLayout;ILantistatic/spinnerwheel/ItemsRange;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
