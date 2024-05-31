# SpringBreak Booking Application

## Overview
The **SpringBreak Booking Application** is a Windows Forms application that allows users to book rooms at a resort. The application calculates the total cost based on the number of guests, number of nights, and the type of room selected. It also provides a personalized thank-you message to the user.

## Features
- Input fields for the number of guests, number of nights, and number of rooms.
- Dropdown for selecting room type (Double, Mini Suite, Suite).
- Calculation of total cost including tax.
- Display of a personalized thank-you message.
- Buttons to process the booking, clear inputs, and exit the application.

## Code Structure
The application is developed in C# using Windows Forms. Below is a brief description of the main components and their functionality.

### Variables
- `NumGuests`, `NumNights`, `NumRooms`, `RoomIndex`: Integer variables to store input values.
- `RoomCost`, `TotalCost`: Double variables to store calculated costs.
- `TaxRate`: Constant double variable for the tax rate.
- `DoubleCost`, `MiniSuiteCost`, `SuiteCost`: Constant double variables for room costs.
- `st1`, `st2`: String variables for formatted input values.
- `greet1` to `greet6`: Strings containing parts of the thank-you message.
- `bigone`: String to hold the full thank-you message.

### Methods
- `Form1()`: Constructor to initialize components.
- `button1_Click()`: Event handler for the "Process" button.
  - Calls `GetInput()`, `ProcessData()`, and `ProduceOutput()`.
- `GetInput()`: Retrieves and parses input values from text boxes and the combo box.
- `GetRoomCost()`: Determines room cost based on the selected room type.
- `ProcessData()`: Calculates the total cost including tax.
- `ProduceOutput()`: Generates and displays the total cost and thank-you message.
- `button2_Click()`: Event handler for the "Clear All" button.
  - Calls `ClearInput()`, `ClearProcess()`, and `ClearOutput()`.
- `ClearInput()`, `ClearProcess()`, `ClearOutput()`: Methods to reset input fields, variables, and output labels.
- `button3_Click()`: Event handler for the "Exit" button to terminate the application.

## Getting Started

### Prerequisites
- .NET Framework (version 4.7.2 or higher)
- Visual Studio (or any C# compatible IDE)

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/SpringBreak.git
    ```
2. Open the project in Visual Studio.
3. Build the solution to restore dependencies and compile the application.
4. Run the application.

### Usage
1. Enter the number of guests, number of nights, and number of rooms in the respective text boxes.
2. Select the room type from the dropdown menu.
3. Click the "Process" button to calculate the total cost and display the thank-you message.
4. To reset the form, click the "Clear All" button.
5. To exit the application, click the "Exit" button.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.

## Author
- Leslie Polley Cofer

Feel free to reach out for any questions or contributions. Happy coding!

---

### Note
This application is a sample project intended for learning and demonstration purposes. It may require further enhancements and testing for production use.
