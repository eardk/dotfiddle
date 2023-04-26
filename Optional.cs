namespace dottests.optional;
using Optional;

public class MyClass {
    public bool inner;
}

public struct MyStruct {
    public bool inner;
}

// stack allocated struct
public ref struct MyRefStruct {
    public bool inner;
}

public class OptionalTest {
    [Fact]
    public void Test1() {
        var maybe_bool = Option.Some(true);
        var null_bool = Option.Some<bool>(null);

        var maybe_class = Option.Some(new MyClass {
            inner = true,
        });
        var null_class = Option.Some<MyClass>(null); // still needs nullable as errors

        var maybe_struct = Option.Some(new MyStruct {
            inner = true,
        });
        var null_struct = Option.Some<MyStruct>(null); // structs are good
//        var maybe_class = Option.Some(new MyRefStruct {
//            inner = true,
//        });
    }
}
