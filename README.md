# About this project

LogSharp is a bare-bones, basic (yet stylish) logging library to display info, errors, warnings, and success messages to the console.
Each message is color coded to each type of warning so that the different types can be easily spotted when looking through the console.

# Usage

You can create an instance of the logger class by adding th following code to any class:

```cs
Logger Logger = new("SectionName");
```

"SectionName" should be re-named to whatever function that class serves, an example is having ``Server`` for a server class, and ``main`` for the main class that manages the server,
this way you know where errors occur.

# Licensing

LogSharp is licenced under the GPL-V2 license.