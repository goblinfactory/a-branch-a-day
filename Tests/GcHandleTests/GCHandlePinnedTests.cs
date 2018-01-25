namespace Tests.GcHandleTests
{

    // from MSDN Documentation: https://msdn.microsoft.com/en-us/library/83y4ak54.aspx

    // This handle type is similar to Normal, but allows the address of the pinned object to be taken.
    // This prevents the garbage collector from moving the object and hence undermines the efficiency 
    // of the garbage collector. Use the Free method to free the allocated handle as soon as possible.

    public class GCHandlePinnedTests
    {

    }
}