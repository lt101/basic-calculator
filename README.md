# C# class libraries: basic-calculator

## About
This is a mini-project showcasing the use of class libraries in C#. The calculator logic is found in the CalculatorLibrary class. Two different UIs (a console app and a WinForms app) interact with the CalculatorLibrary class, reusing its common functionalities.

## How to use
To use the console app, open the ConsoleUI application located in ConsoleUI > bin > Debug > net6.0 > ConsoleUI.
To use the WinForms app, open the WinFormsUI application located in WinFormsUI > bin > Debug > net6.0-windows > WinFormsUI.

## Developer notes
The focus of this project is to show the utility of class libraries. The calculator logic is imperfect (returning -1 as an error is problematic, especially in the case where the result of a valid operation is in fact -1), but is functional enough for quick testing.
