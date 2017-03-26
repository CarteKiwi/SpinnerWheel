using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/AbstractWheelAdapter", DoNotGenerateAcw=true)]
	public abstract partial class AbstractWheelAdapter : global::Java.Lang.Object, global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/adapters/AbstractWheelAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheelAdapter); }
		}

		protected AbstractWheelAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/constructor[@name='AbstractWheelAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractWheelAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbstractWheelAdapter)) {
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

		static Delegate cb_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_);
			return cb_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEmptyItem (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='getEmptyItem' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("getEmptyItem", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Android.Views.View GetEmptyItem (global::Android.Views.View p0, global::Android.Views.ViewGroup p1)
		{
			if (id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getEmptyItem", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmptyItem", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_notifyDataChangedEvent;
#pragma warning disable 0169
		static Delegate GetNotifyDataChangedEventHandler ()
		{
			if (cb_notifyDataChangedEvent == null)
				cb_notifyDataChangedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataChangedEvent);
			return cb_notifyDataChangedEvent;
		}

		static void n_NotifyDataChangedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataChangedEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataChangedEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='notifyDataChangedEvent' and count(parameter)=0]"
		[Register ("notifyDataChangedEvent", "()V", "GetNotifyDataChangedEventHandler")]
		protected virtual unsafe void NotifyDataChangedEvent ()
		{
			if (id_notifyDataChangedEvent == IntPtr.Zero)
				id_notifyDataChangedEvent = JNIEnv.GetMethodID (class_ref, "notifyDataChangedEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDataChangedEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataChangedEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifyDataInvalidatedEvent;
#pragma warning disable 0169
		static Delegate GetNotifyDataInvalidatedEventHandler ()
		{
			if (cb_notifyDataInvalidatedEvent == null)
				cb_notifyDataInvalidatedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataInvalidatedEvent);
			return cb_notifyDataInvalidatedEvent;
		}

		static void n_NotifyDataInvalidatedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataInvalidatedEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataInvalidatedEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='notifyDataInvalidatedEvent' and count(parameter)=0]"
		[Register ("notifyDataInvalidatedEvent", "()V", "GetNotifyDataInvalidatedEventHandler")]
		protected virtual unsafe void NotifyDataInvalidatedEvent ()
		{
			if (id_notifyDataInvalidatedEvent == IntPtr.Zero)
				id_notifyDataInvalidatedEvent = JNIEnv.GetMethodID (class_ref, "notifyDataInvalidatedEvent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDataInvalidatedEvent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataInvalidatedEvent", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='registerDataSetObserver' and count(parameter)=1 and parameter[1][@type='android.database.DataSetObserver']]"
		[Register ("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public virtual unsafe void RegisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerDataSetObserver_Landroid_database_DataSetObserver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='unregisterDataSetObserver' and count(parameter)=1 and parameter[1][@type='android.database.DataSetObserver']]"
		[Register ("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public virtual unsafe void UnregisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetGetItem_ILandroid_view_View_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I == null)
				cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr>) n_GetItem_ILandroid_view_View_Landroid_view_ViewGroup_I);
			return cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_GetItem_ILandroid_view_View_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetItem (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']/method[@name='getItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup'] and parameter[4][@type='int']]"
		[Register ("getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;", "GetGetItem_ILandroid_view_View_Landroid_view_ViewGroup_IHandler")]
		public abstract global::Android.Views.View GetItem (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2, int p3);

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
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemsCount;
		}
#pragma warning restore 0169

		public abstract int ItemsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='getItemsCount' and count(parameter)=0]"
			[Register ("getItemsCount", "()I", "GetGetItemsCountHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/AbstractWheelAdapter", DoNotGenerateAcw=true)]
	internal partial class AbstractWheelAdapterInvoker : AbstractWheelAdapter {

		public AbstractWheelAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheelAdapterInvoker); }
		}

		static IntPtr id_getItemsCount;
		public override unsafe int ItemsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='getItemsCount' and count(parameter)=0]"
			[Register ("getItemsCount", "()I", "GetGetItemsCountHandler")]
			get {
				if (id_getItemsCount == IntPtr.Zero)
					id_getItemsCount = JNIEnv.GetMethodID (class_ref, "getItemsCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemsCount);
				} finally {
				}
			}
		}

		static IntPtr id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']/method[@name='getItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup'] and parameter[4][@type='int']]"
		[Register ("getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;", "GetGetItem_ILandroid_view_View_Landroid_view_ViewGroup_IHandler")]
		public override unsafe global::Android.Views.View GetItem (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2, int p3)
		{
			if (id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
