# CommandLine

A lightweight C#‑based mini “command line” tool that supports basic directory & file operations (list, info, create, remove, etc.).

---

## Table of Contents

- [About the Project](#about-the-project)  
- [Features](#features)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)   
- [Usage](#usage)    
- [How It Works](#how-it-works)  
- [Contributing](#contributing)  
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


## Usage

Once running, the application prompts for commands which accept a command keyword followed by a path.
  ```bash
> list C:\MyFolder

> info C:\MyFolder\file.txt

> mkdir C:\MyFolder\NewDirectory

> remove C:\MyFolder\OldDirectory

> read C:\MyFolder\file.txt

> type C:\MyFolder\file.txt
```
## How It Works

- The entry point is Program.cs, which reads user input from the console.

- Input is parsed into two components: the command (e.g., list) and the path (e.g., C:\…).

- Depending on the command, the app uses classes in System.IO (e.g., DirectoryInfo, FileInfo, StreamReader, StreamWriter) to perform file system operations.

- The code is modular and can be extended easily with new commands.


## Contributing

Contributions are welcome! If you have ideas for new commands, improvements, bug fixes, or better error-handling — please fork the repo and open a pull request.

### Guidelines:

- Use clear commit messages

- Add tests for new features where applicable

- Follow existing code style and structure

- Update the README for any new commands or features

  ---
## Contact

### Created by Mohamed Amin.

GitHub: @mohamedamin7510

Email: [maming7510@gmial.com]

Thanks for checking out the project — enjoy exploring simple command‑line tools in C#!
