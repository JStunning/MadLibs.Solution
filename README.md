# Mad Libs

#### A digital Mad Libs game using C# and ASP.NET Core MVC, Current Version: 03.09.20

#### By Sarah "Sasa" Schwartz, and Jack Dunning

## Description

A digital Mad Libs game using C# and ASP.NET Core MVC. The mad lib is food themed and allows the user to input various nouns, verbs, etc. to be displayed in the resulting text.

## Description of what we worked on 3/9/20

- Reviewed weekend reading and coded along
- MadLibs application
- Clean up our githubs and rename/reorganize projects
- Went through old projects (particularly Friday project) to convert to .NET Core MVC framework

## Setup/Installation Requirements

- Clone the repo to your desktop
- From the root folder \$ cd MadLibs
- \$ dotnet restore
- \$ dotnet run
- The app should host on http://localhost:5000
- Open this link in your browser to use the app!

## Specs

- User can input words into a form.
  - Sample input: User inputs a noun, "dog".
  - Expected output: No output until form is submitted.
- User can submit form to be processed.
  - Sample input: User clicks the "Create MadLib" button.
  - Expected output: The form disappears, and the user's responses are displayed in a madlib on screen.
- User's responses will determine the madlib story
  - Sample input: User had inputted "dog" and clicked submit
  - Expected output: When the madlib story appears, the word "dog" replaces the noun blank in the sentence.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- ASP .NET Core MVC

### License

- This software is licensed under the MIT license.
