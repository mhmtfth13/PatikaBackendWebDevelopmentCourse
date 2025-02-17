# LINQ GroupJoin Example - Student and Class Management

This C# console application demonstrates the usage of LINQ's GroupJoin operation to combine and display information about students and their respective classes.

## Project Description

The application showcases a simple implementation of joining two collections:

- A list of students containing student names and class IDs.
- A list of classes containing class names and class IDs.

The program groups students by their class IDs and displays the combined information in a structured format.

## Code Structure

The project consists of the following main components:

1. **Student class** (defined as `Student`) containing:
   - `StudentId`
   - `StudentName`
   - `ClassId`
   
2. **Classes class** (defined as `Classes`) containing:
   - `ClassId`
   - `ClassName`

3. **Main method**: The `Main` method performs the following tasks:
   - Creates and populates sample student and class collections.
   - Implements LINQ GroupJoin operation to group students by their respective classes.
   - Displays the grouped data in the console, showing class names and the list of students in each class.

## Features

- Creates and populates sample student and class collections.
- Implements the LINQ **GroupJoin** operation to combine student and class data.
- Displays formatted output showing class names with their corresponding students.

### Sample Data

#### Students:
- **Ali** (StudentId: 1, ClassId: 1)
- **Ayse** (StudentId: 2, ClassId: 2)
- **Mehmet** (StudentId: 3, ClassId: 1)
- **Fatma** (StudentId: 4, ClassId: 3)
- **Ahmet** (StudentId: 5, ClassId: 2)

#### Classes:
- **Matematik** (ClassId: 1)
- **Turkce** (ClassId: 2)
- **Kimya** (ClassId: 3)

## How It Works

The `GroupJoin` operation in LINQ is used to group students by their respective classes. The code performs the following steps:
