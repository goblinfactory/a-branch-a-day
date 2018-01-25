namespace Tests.GcHandleTests
{
    // from MSDN Documentation: https://msdn.microsoft.com/en-us/library/83y4ak54.aspx

    // This handle type represents an opaque handle, meaning you cannot resolve the address of the pinned object 
    // through the handle.
    // You can use this type to track an object and prevent its collection by the garbage collector.
    // This enumeration member is useful when an unmanaged client holds the only reference, 
    // which is undetectable from the garbage collector, to a managed object.

    public class GCHandleNormalTests
    {

    }
}