# User Data Registration WPF Module

## Introduction
You are implementing an application that has a User Data Registration WPF Module.
The module contains the `RegisterUserWindow` window that allows the user to register in the designed application.
You have to finish the implementation by meeting the requirements described below.

## Problem Statement

You have to implement the following requirements:
- The `grid` Grid should have a 20 pixels margin around.
- The `labTitle` label should be added to the first row and the first column of the `grid`. The control should span all columns of the row and the text should be displayed (aligned) centrally.  
- The title label should use a 40 pixels size font `Tahoma`.
- The `labFirstName` label should be displayed in the second row and the first column of the `grid`. The text should be aligned to the right.
- The `edFirstName` text field should be displayed in the second row and the second column of the `grid`.
- The `labLastName` label should be displayed in the second row and the third column of the `grid`. The text should be aligned to the right.
- The `edLastName` text field should be displayed in the second row and the fourth column of the `grid`.
- The `edAggree` checkbox field should be displayed in the third row and the second column of the `grid`. The field should be displayed at the bottom of the cell.
- The `btnRegister` button should be displayed in the fourth row and in the joined second and third column of the `grid`.
- The `labResult` label should be displayed in the fifth row and the first column of the `grid`. 
- After clicking the `btnRegister` button, if the first name or the last name is empty and/or `edAggree` is not checked, the 'The form has not been completed correctly!' should be displayed on the `labResult` content.
- After clicking the `btnRegister` button, the `OnRegister`  should be called (if it is injected) and the result of the function should be displayed on the `labResult` content. Otherwise, nothing should be done.
- The `edFirstName` should bind to the `FirstName` property of the `UserDataViewModel` (two-way binding). The `DataContext` is initialized to the `UserDataViewModel`.
- The `edLastName` should bind to the `LastName` property of the `UserDataViewModel` (two-way binding). The `DataContext` is initialized to `UserDataViewModel`.
- The `edAggree` should bind to the `Agree` property of the `UserDataViewModel` (two-way binding). The `DataContext` is initialized to the `UserDataViewModel`.
- The first row of the `grid` should have 100 pixels height.
- The second row of the `grid` should have 40 pixels height.
- The third row of the `grid` should have 40 pixels height.
- The fourth row of the `grid` should have 40 pixels height.
- The fifth row of the `grid` should use the remaining available space.

## Hints
1. Your solution should pass all tests.
2. Check the `TODO` comments.
3. Remember that rows and columns are counted from 0, for example, the `first row` means `row 0`.
4. *To run all tests, you may need to run Visual Studio with administrator privileges.*
