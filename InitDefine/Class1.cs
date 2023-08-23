namespace InitDefine
{
    public readonly struct Test
    {
        public int Foo { get; init; }
    }
}

namespace System.Runtime.CompilerServices
{
#if !NET5_0_OR_GREATER
    static class IsExternalInit {}
#endif
}
