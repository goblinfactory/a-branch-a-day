namespace Tests.GcHandleTests
{
    // from MSDN Documentation: https://msdn.microsoft.com/en-us/library/83y4ak54.aspx

    // This handle type is used to track an object, but allow it to be collected.
    // When an object is collected, the contents of the GCHandle are zeroed. 
    // Weak references are zeroed before the finalizer runs, 
    // so even if the finalizer resurrects the object, the Weak reference is still zeroed.

    public class GCHandleWeakTests
    {

    }
}