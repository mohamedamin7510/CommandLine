# CommandLine

A lightweight C#‑based mini “command line” tool that supports basic directory & file operations (list, info, create, remove, etc.).

---

## Table of Contents

- [About the Project](#about-the-project)  
- [Features](#features)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Installation](#installation)  
- [Usage](#usage)  
  - [Available Commands](#available-commands)  
- [How It Works](#how-it-works)  
- [Contributing](#contributing)  
- [License](#license)  
- [Contact](#contact)  

---

## About the Project

This project provides a simple command‑line interface implemented in C#, utilising the .NET runtime, which allows you to interact with the file system. You can perform operations such as reading directory contents, obtaining info about files/directories, creating or removing directories, and more.

It is ideal for learning and exploring how command parsing, file I/O and directory traversal can be implemented using C# classes such as `StreamReader`, `StreamWriter`, `FileInfo`, `DirectoryInfo`, and others from `System.IO`.  
([GitHub Repo](https://github.com/mohamedamin7510/CommandLine.git))

---

## Features

- Parse user input into **command** + **path** components.  
- List directory contents.  
- Retrieve information about a given file or directory.  
- Create new directories.  
- Remove directories.  
- Clean, minimal codebase — great for educational or lightweight usage.  
- Entirely written in C# (.NET).

---

## Getting Started

### Prerequisites

- .NET SDK (compatible with .NET 8.0)  
- A development environment like Visual Studio or Visual Studio Code  
- Basic knowledge of C# and command-line usage

### Installation

1. Clone the repository:  
   ```bash
   git clone https://github.com/mohamedamin7510/CommandLine.git
