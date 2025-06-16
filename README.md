# Kartlegging Backend Intro

> ![NOTE]
> Ignore the `flake.nix`, `flake.lock`, `.envrc` and `.direnv` files and folders. They are for a slightly more complex host system setup based on NixOS

> ![NOTE]
> This repository assumes that you have .NET 9.0 installed.
>
> You can check this by running `dotnet --version` in your terminal of choice

## Commands

- Clone the repository locally

    ```sh
    git clone https://github.com/LarsGJobloop/2025-06-kartlegging-backend-intro
    ```

- Generated a new template

    ```sh
    dotnet new list # Pick your poison
    dotnet new <shortname-of-poison>
    ````

- Start a development version of the project

    ```sh
    dotnet run
    ````

- Build the project

    ```sh
    dotnet publish --output out
    ```
