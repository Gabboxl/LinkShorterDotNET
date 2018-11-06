# LinkShorter.NET [![Build Status](https://travis-ci.org/Gabboxl/LinkShorterDotNET.svg?branch=master)](https://travis-ci.org/Gabboxl/LinkShorterDotNET) [![Build status](https://ci.appveyor.com/api/projects/status/x4226952m4234033?svg=true)](https://ci.appveyor.com/project/Gabboxl/linkshorterdotnet) [![StyleCI](https://styleci.io/repos/128944187/shield?branch=master)](https://styleci.io/repos/128944187)
A simple C# .NET Standard library which inlcude the most link-shortener services.




 ------------------------------------------------------
 
  How to use
 --------------
 
  To include this class in your solution/project you need to add the reference to this class:
  1) *right click* on the project in "explore solutions" on the right
  2) click on "*add...*"
  3) click on "*reference..*"
  4) go in the tab "*browse*" on the left
  5) click the button "browse" on the bottom- right
  6) select the .dll file downloaded from here: https://github.com/Gabboxl/LinkShorterDotNET/releases (you can also build the latest code with Visual Studio by downloading the solution at the top).
  
 
 The class is very simple to use, here's an example:
 
 `using LinkShorterNET;`
 
 `Linkshorter test = new Linkshorter("Adfocus", "https://gabboxl.ga"); `  <-- we call the constructor, in this example we will use the *Adfocus* service.
 
  `return test.GetLink(); ` <-- we get the link shorten with the *GetLink()* method.
  
  
  
  --------
 -under construction-
