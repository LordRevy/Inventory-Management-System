# Inventory Management System

## Overview

This Windows Forms Inventory Management System was developed in C# using Visual Studio as part of a software engineering course project. The application provides a user-friendly interface to manage parts and products in an inventory system. It supports creating, modifying, searching, and deleting both parts and products, along with proper validation and data management according to the provided UML class diagram.

---

## Features

### Main Form
- Buttons for **Add**, **Modify**, **Delete**, **Search**, and **Exit**
- DataGridViews displaying lists of **Parts** and **Products**
- Textboxes and labels for search functionality and section titles

### Add / Modify Part Forms
- Radio buttons to select **In-House** or **Outsourced** part type
- Input fields for:  
  - ID (read-only)
  - Name  
  - Inventory  
  - Price  
  - Min / Max  
  - Machine ID / Company Name (based on part type)
- Save and Cancel functionality
- Field population for modification

### Add / Modify Product Forms
- DataGridViews to manage:  
  - **All Candidate Parts**  
  - **Associated Parts**  
- Input fields for:
  - ID (read-only)
  - Name  
  - Inventory  
  - Price  
  - Min / Max  
- Search, Add, and Delete associated parts
- Save and Cancel functionality
- Field population for modification

---

## Object-Oriented Structure

Implemented using object-oriented principles with the following main classes:

- `Part` (Abstract)
  - `InHouse` (inherits from `Part`)
  - `Outsourced` (inherits from `Part`)
- `Product`
- `Inventory`

Includes appropriate methods and properties for:

- CRUD operations
- Part association/disassociation
- Data validation
- Auto-incrementing IDs

---

## Input Validation

The application prevents:

- Non-numeric entries in numeric fields
- Setting `Min` greater than `Max`
- Inventory outside the Min-Max range
- Deleting parts that are associated with products
- Deleting parts/products without confirmation

---

## How to Run

1. Open `InventoryManagementSystem.sln` in Visual Studio.
2. Click the Greem Triangle that says "Inventory Manager" beside it.

---

## Author

**Trevor Boyce**  

---

## License

This project is for educational purposes only and is not licensed for commercial use.
