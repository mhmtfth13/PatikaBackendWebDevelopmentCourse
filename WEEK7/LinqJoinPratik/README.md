# LINQ Join Exercise - Book and Author Management

This C# console application demonstrates the usage of LINQ Join operations to combine and display information about books and their respective authors.

## Project Description

The application showcases a simple implementation of joining two collections:

- A list of books containing book titles and author IDs
- A list of authors containing author names and IDs

The program creates a relationship between books and authors using LINQ Join operations and displays the combined information.

## Code Structure

The project consists of the following main components:

### `Book` Class (implied)

Contains:
- `BookId`
- `AuthorId`
- `Title`

### `Author` Class (implied)

Contains:
- `AuthorId`
- `Name`

## Features

- Creates and populates sample book and author collections
- Implements LINQ Join operation to combine book and author information
- Displays formatted output showing book titles with their corresponding authors

## Sample Data

### Books

- "Kar" by AuthorId 1
- "Istanbul" by AuthorId 1
- "10 Minutes 38 Seconds in This Strange World" by AuthorId 2
- "Beyoglu Rapsodisi" by AuthorId 3

### Authors

- Orhan Pamuk (AuthorId: 1)
- Elif Safak (AuthorId: 2)
- Ahmet Umit (AuthorId: 3)

## Usage

The program will output each book's title along with its author's name in the following format:

