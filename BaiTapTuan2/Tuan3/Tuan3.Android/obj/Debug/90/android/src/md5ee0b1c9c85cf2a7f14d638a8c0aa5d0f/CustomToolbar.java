package md5ee0b1c9c85cf2a7f14d638a8c0aa5d0f;


public class CustomToolbar
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Syncfusion.SfImageEditor.Android.CustomToolbar, Syncfusion.SfImageEditor.XForms.Android", CustomToolbar.class, __md_methods);
	}


	public CustomToolbar (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomToolbar.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfImageEditor.Android.CustomToolbar, Syncfusion.SfImageEditor.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public CustomToolbar (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomToolbar.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfImageEditor.Android.CustomToolbar, Syncfusion.SfImageEditor.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomToolbar (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomToolbar.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfImageEditor.Android.CustomToolbar, Syncfusion.SfImageEditor.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomToolbar (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == CustomToolbar.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfImageEditor.Android.CustomToolbar, Syncfusion.SfImageEditor.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
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
