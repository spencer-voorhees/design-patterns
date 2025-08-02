## Builder – Robot

This example demonstrates the Builder pattern using a simplified robot assembly system.

**Real-world context:**  
A robot factory allows engineers to construct robots with varying configurations. Some robots use default components, while others are customized for specific missions. Instead of creating multiple constructors or a complex setup method, the Builder pattern offers a fluent way to construct the robot step by step.

**Key points:**
- Defines a `RobotBuilder` class that sets individual components like head, arms, and legs.
- Supports a fluent interface to chain configuration methods.
- The final `Build()` call returns a complete and immutable `Robot` instance.
- Allows flexible creation without needing to pass every detail upfront.