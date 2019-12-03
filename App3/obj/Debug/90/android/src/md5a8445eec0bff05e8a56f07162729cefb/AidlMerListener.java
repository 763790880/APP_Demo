package md5a8445eec0bff05e8a56f07162729cefb;


public class AidlMerListener
	extends com.lkl.cloudpos.mdx.aidl.system.AidlMerListener.Stub
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFail:(I)V:GetOnFail_IHandler\n" +
			"n_onSuccess:(Ljava/lang/String;Ljava/lang/String;)V:GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("App3.LKLModel.AidlMerListener, App3", AidlMerListener.class, __md_methods);
	}


	public AidlMerListener ()
	{
		super ();
		if (getClass () == AidlMerListener.class)
			mono.android.TypeManager.Activate ("App3.LKLModel.AidlMerListener, App3", "", this, new java.lang.Object[] {  });
	}


	public void onFail (int p0)
	{
		n_onFail (p0);
	}

	private native void n_onFail (int p0);


	public void onSuccess (java.lang.String p0, java.lang.String p1)
	{
		n_onSuccess (p0, p1);
	}

	private native void n_onSuccess (java.lang.String p0, java.lang.String p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
