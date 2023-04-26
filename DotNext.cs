namespace dottests.dotnext;
using DotNext;

public class MyDinkyClass 
{
    public bool inner;
}

public ref struct MyStruct {
    public bool inner;
}

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var maybe_bool = Optional.Some(true);
        Optional<bool> null_bool  = Optional.Some<bool>(null);

        var maybe_dinky = Optional.Some(new MyDinkyClass {
            inner = true,
        });
        var null_dinky  = Optional.Some<MyDinkyClass>(null); // I want this to be an error

        var maybe_struct = Optional.Some(new MyStruct {
            inner = true,
        });
        var null_struct = Optional.Some<MyStruct>(null);
    }
}