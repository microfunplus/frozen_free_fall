//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1008
//   获取android 设备信息 管理类

// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections.Generic;

public class MFPDeviceAndroid
		{


		/**NETWORK CONNECTED*/
    public const int NETWORK_STATE_CONNECTED = 1;

	/**NETWORK NOT CONNECTED*/
	public const int NETWORK_STATE_NOT_CONNECTED = 2;
		

		
		/**移动 */
		public const int PROVIDER_MOBILE = 1;
		
		/**联通 */
		public const int PROVIDER_UNICON = 2;
		
		/**电信 */
		public const int PROVIDER_TELECOM = 3;
		// The reflected class of java api of CMBilling.jar
	#if UNITY_ANDROID && !UNITY_EDITOR
		private AndroidJavaClass klass = new AndroidJavaClass("com.mfp.android.DeviceManager");	
	#endif
		// The instance of billing script.
		private static MFPDeviceAndroid _instance;
		public static MFPDeviceAndroid Instance
		{
			get
			{
				if(_instance==null){
					_instance = new MFPDeviceAndroid();
				}
				return _instance;
			}
		}
	/**
	 * 得到设备的联网状态
	 * 网络连接： 1、 wifi 开着或者 mobile 开着
	 * 网络无连接：2、两者都没有开，或者都么有
	 * 
	 */ 
		public int getNetWorkState()
		{
		int netstate = NETWORK_STATE_NOT_CONNECTED;
		#if UNITY_ANDROID && !UNITY_EDITOR
		using (AndroidJavaClass unityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) {
			using (AndroidJavaObject curActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")) {

		netstate = 	klass.CallStatic<int>("getNetWorkState",curActivity);
			}
		}
		#endif
		return netstate;
		}

		/**
		 * 得到运营商信息
		 * 1：移动
		 * 2：联通
		 * 3：电信
		 * 
		 */ 
		public int getProvider()
		{
		int provider = PROVIDER_MOBILE;
		#if UNITY_ANDROID && !UNITY_EDITOR
			using (AndroidJavaClass unityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) {
					using (AndroidJavaObject curActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")) {
				Debug.Log(" wenming MFPDeviceAndroid  1111111111111111111111111111111111");
			provider = klass.CallStatic<int>("getProvider",curActivity);
				Debug.Log(" wenming MFPDeviceAndroid 22222222222222222222222222222222222");

				}
			}
		#endif

			return 	provider;
		}

		/**
		 * 获取设备id
		 * 
		 */ 
	public string getVendorID()
		{
		string deviceid ="mfp";
		#if UNITY_ANDROID && !UNITY_EDITOR
		using (AndroidJavaClass unityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) {
			using (AndroidJavaObject curActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")) {
		deviceid =  klass.CallStatic<String>("getVendorID",curActivity);	
			}
		}
		#endif
		return deviceid;
		}
		
		
				/**
		 * 获取设备的型号
		 * 
		 */ 
	public string getDeviceModel()
		{
		string deviceModel ="mfp model";
		#if UNITY_ANDROID && !UNITY_EDITOR
		using (AndroidJavaClass unityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) {
			using (AndroidJavaObject curActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")) {
		deviceModel =  klass.CallStatic<String>("getDeviceMode",curActivity);	
			}
		}
		#endif
		return deviceModel;
		}
		

		public string getDataPath()
		{
			string path = Application.persistentDataPath;
			#if UNITY_ANDROID && !UNITY_EDITOR
			using (AndroidJavaClass unityPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) {
				using (AndroidJavaObject curActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")) {
			path =  klass.CallStatic<String>("getDataPath",curActivity);	
				}
			}
			#endif
		if (String.IsNullOrEmpty(path))
		{
			path = Application.persistentDataPath;;
		}
			return path;
		}
}



