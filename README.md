# Open/Closed Principle Demonstration

This repository contains a console application that demonstrates the Open/Closed Principle (OCP), one of the SOLID design principles. The OCP states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.

## Project Structure

The project includes two main classes within a single application:

- `Logger`: Demonstrates a violation of the Open/Closed Principle by requiring modifications to existing code when new functionality is added.
- `ILogger`: Demonstrates adherence to the Open/Closed Principle using interfaces and polymorphism, promoting extensibility without modifying existing code.

### Logger Class

This class uses a switch statement inside a Logger method to determine how to log messages (to the console or to a file), which violates the OCP because it requires modifications to add new logging methods.

### ILogger Class

This approach uses an `ILogger` interface with different implementations (e.g., `ConsoleLogger` and `FileLogger`), which conforms to the OCP. Adding new types of loggers does not require any changes to existing classes.
