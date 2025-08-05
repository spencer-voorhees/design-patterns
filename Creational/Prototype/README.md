## Prototype – Document Template

This example demonstrates the Prototype pattern using a simple `DocumentTemplate` class.

**Real-world context:**  
You have a base document structure (like a project or report template) and need to create multiple copies with slight modifications without rebuilding everything from scratch.

**Key points:**
- The `Clone()` method creates a copy of the `DocumentTemplate`.
- Modifications are applied to the cloned object without altering the original.
- Useful when creating many objects that share the same structure or default state.