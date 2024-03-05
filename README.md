# RestSharp API Testing with SpecFlow

This project is aimed at testing RESTful APIs using RestSharp and SpecFlow.

## Project Structure

- **RestSharp_API_Testing.Specs**: Contains SpecFlow feature files, step definitions, and related code.
  - **Features**: SpecFlow feature files describing test scenarios.
  - **Models**: Classes representing data models used in the tests.
  - **Steps**: Step definition files where SpecFlow steps are implemented.
- **README.md**: This file, providing an overview of the project.

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/RestSharp_API_Testing.git
   ```

2. Open the solution file (`RestSharp_API_Testing.sln`) in Visual Studio.

3. Build the solution to restore dependencies and ensure everything is set up correctly.

4. Explore the project structure and start adding your test scenarios in the feature files under the **Features** directory.

5. Implement step definitions in the **Steps** directory to define the behavior of each step in your scenarios.

6. Execute the tests using your preferred test runner.

## Running Tests

To run the tests, follow these steps:

1. Build the solution if you haven't already done so.

2. Open the Test Explorer window in Visual Studio (`Test` > `Test Explorer`).

3. Click on `Run All` in the Test Explorer window to execute all tests.

Alternatively, you can use the command line to run the tests:

```bash
dotnet test
```

This command will build the solution and run all tests.

## Dependencies

- **RestSharp**: A simple REST and HTTP API Client for .NET.
- **SpecFlow**: A pragmatic BDD framework for .NET, allowing you to define executable specifications.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.
