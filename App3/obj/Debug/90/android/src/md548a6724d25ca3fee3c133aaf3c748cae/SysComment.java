package md548a6724d25ca3fee3c133aaf3c748cae;


public class SysComment
	extends md56b537a863e73a163728b485bb6fa50db.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App3.Comment.SysComment, App3", SysComment.class, __md_methods);
	}


	public SysComment ()
	{
		super ();
		if (getClass () == SysComment.class)
			mono.android.TypeManager.Activate ("App3.Comment.SysComment, App3", "", this, new java.lang.Object[] {  });
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
