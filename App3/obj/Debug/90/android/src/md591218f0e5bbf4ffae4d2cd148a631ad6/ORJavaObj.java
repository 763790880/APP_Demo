package md591218f0e5bbf4ffae4d2cd148a631ad6;


public class ORJavaObj
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App3.Model.ORJavaObj, App3", ORJavaObj.class, __md_methods);
	}


	public ORJavaObj ()
	{
		super ();
		if (getClass () == ORJavaObj.class)
			mono.android.TypeManager.Activate ("App3.Model.ORJavaObj, App3", "", this, new java.lang.Object[] {  });
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
