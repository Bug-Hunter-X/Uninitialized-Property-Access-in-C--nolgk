# Uninitialized Property Access in C#

This example showcases a common error in C#: accessing a property before it has been assigned a value. In C#, uninitialized instance variables (including properties) are initialized to their default values (0 for integers, null for references, etc.).  Accessing them before explicit assignment can lead to unexpected behavior, particularly if the default value isn't suitable for your program's logic.

The `bug.cs` file demonstrates this by printing the value of `MyProperty` before it is assigned. The `bugSolution.cs` file demonstrates how to resolve this issue by ensuring that the property is assigned a value before use.

This is a simple example, but in more complex scenarios, uninitialized properties can result in hard-to-debug issues or even exceptions.

**Key takeaway:** Always initialize your properties with default or meaningful values before accessing them in your code.