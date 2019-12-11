package md548a6724d25ca3fee3c133aaf3c748cae;


public class MyItemDecoration
	extends android.support.v7.widget.RecyclerView.ItemDecoration
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDraw:(Landroid/graphics/Canvas;Landroid/support/v7/widget/RecyclerView;)V:GetOnDraw_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_Handler\n" +
			"n_getItemOffsets:(Landroid/graphics/Rect;ILandroid/support/v7/widget/RecyclerView;)V:GetGetItemOffsets_Landroid_graphics_Rect_ILandroid_support_v7_widget_RecyclerView_Handler\n" +
			"";
		mono.android.Runtime.register ("App3.Comment.MyItemDecoration, App3", MyItemDecoration.class, __md_methods);
	}


	public MyItemDecoration ()
	{
		super ();
		if (getClass () == MyItemDecoration.class)
			mono.android.TypeManager.Activate ("App3.Comment.MyItemDecoration, App3", "", this, new java.lang.Object[] {  });
	}

	public MyItemDecoration (android.content.Context p0, int p1)
	{
		super ();
		if (getClass () == MyItemDecoration.class)
			mono.android.TypeManager.Activate ("App3.Comment.MyItemDecoration, App3", "Android.Content.Context, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public void onDraw (android.graphics.Canvas p0, android.support.v7.widget.RecyclerView p1)
	{
		n_onDraw (p0, p1);
	}

	private native void n_onDraw (android.graphics.Canvas p0, android.support.v7.widget.RecyclerView p1);


	public void getItemOffsets (android.graphics.Rect p0, int p1, android.support.v7.widget.RecyclerView p2)
	{
		n_getItemOffsets (p0, p1, p2);
	}

	private native void n_getItemOffsets (android.graphics.Rect p0, int p1, android.support.v7.widget.RecyclerView p2);

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
