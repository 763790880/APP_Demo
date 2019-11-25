package md530732b49c800fd953a1ccb628afcf8d6;


public class HttpApi
	extends md56b537a863e73a163728b485bb6fa50db.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App3.WebApi.HttpApi, App3", HttpApi.class, __md_methods);
	}


	public HttpApi ()
	{
		super ();
		if (getClass () == HttpApi.class)
			mono.android.TypeManager.Activate ("App3.WebApi.HttpApi, App3", "", this, new java.lang.Object[] {  });
	}

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
