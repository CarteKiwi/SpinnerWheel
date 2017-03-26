using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel.Adapters {

	// Metadata.xml XPath interface reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']"
	[Register ("antistatic/spinnerwheel/adapters/WheelViewAdapter", "", "Antistatic.Spinnerwheel.Adapters.IWheelViewAdapterInvoker")]
	public partial interface IWheelViewAdapter : IJavaObject {

		int ItemsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']/method[@name='getItemsCount' and count(parameter)=0]"
			[Register ("getItemsCount", "()I", "GetGetItemsCountHandler:Antistatic.Spinnerwheel.Adapters.IWheelViewAdapterInvoker, SpinnerWheel")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']/method[@name='getEmptyItem' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("getEmptyItem", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_Handler:Antistatic.Spinnerwheel.Adapters.IWheelViewAdapterInvoker, SpinnerWheel")]
		global::Android.Views.View GetEmptyItem (global::Android.Views.View p0, global::Android.Views.ViewGroup p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']/method[@name='getItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup'] and parameter[4][@type='int']]"
		[Register ("getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;", "GetGetItem_ILandroid_view_View_Landroid_view_ViewGroup_IHandler:Antistatic.Spinnerwheel.Adapters.IWheelViewAdapterInvoker, SpinnerWheel")]
		global::Android.Views.View GetItem (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']/method[@name='registerDataSetObserver' and count(parameter)=1 and parameter[1][@type='android.database.DataSetObserver']]"
		[Register ("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler:Antistatic.Spinnerwheel.Adapters.IWheelViewAdapterInvoker, SpinnerWheel")]
		void RegisterDataSetObserver (global::Android.Database.DataSetObserver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/interface[@name='WheelViewAdapter']/method[@name='unregisterDataSetObserver' and count(parameter)=1 and parameter[1][@type='android.database.DataSetObserver']]"
		[Register ("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler:Antistatic.Spinnerwheel.Adapters.IWheelViewAdapterInvoker, SpinnerWheel")]
		void UnregisterDataSetObserver (global::Android.Database.DataSetObserver p0);

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/WheelViewAdapter", DoNotGenerateAcw=true)]
	internal class IWheelViewAdapterInvoker : global::Java.Lang.Object, IWheelViewAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("antistatic/spinnerwheel/adapters/WheelViewAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWheelViewAdapterInvoker); }
		}

		IntPtr class_ref;

		public static IWheelViewAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWheelViewAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "antistatic.spinnerwheel.adapters.WheelViewAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWheelViewAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemsCount;
		}
#pragma warning restore 0169

		IntPtr id_getItemsCount;
		public unsafe int ItemsCount {
			get {
				if (id_getItemsCount == IntPtr.Zero)
					id_getItemsCount = JNIEnv.GetMethodID (class_ref, "getItemsCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemsCount);
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
			global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEmptyItem (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View GetEmptyItem (global::Android.Views.View p0, global::Android.Views.ViewGroup p1)
		{
			if (id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getEmptyItem", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmptyItem_Landroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetItem (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
		public unsafe global::Android.Views.View GetItem (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2, int p3)
		{
			if (id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;
		public unsafe void RegisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerDataSetObserver_Landroid_database_DataSetObserver_, __args);
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
			global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver p0 = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterDataSetObserver (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		public unsafe void UnregisterDataSetObserver (global::Android.Database.DataSetObserver p0)
		{
			if (id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, __args);
		}

	}

}
