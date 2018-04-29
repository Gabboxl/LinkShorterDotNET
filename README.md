# LinkShorter.NET [![Build Status](https://travis-ci.org/Gabboxl/LinkShorterDotNET.svg?branch=master)](https://travis-ci.org/Gabboxl/LinkShorterDotNET) [![Build Status](https://styleci.io/repos/128944187/shield?branch=master)](https://travis-ci.org/Gabboxl/LinkShorterDotNET) [![Build status](https://ci.appveyor.com/api/projects/status/x4226952m4234033?svg=false)](https://ci.appveyor.com/project/Gabboxl/linkshorterdotnet)
A simple C# .NET Standard library which inlcude the most link-shortener services.




 ------------------------------------------------------
 
 #How to use
 
  To include this class in your solution/project you need to add the reference to this class -> *right click* on the project in "explore solutions" on the right, -> add... -> reference.. -> browse-> click the button "browse" on the bottom -> select the .dll file downloaded from here: ----- .
  
 
 The class is very simple to use, here's an example:
 
 `using LinkShorterNET;`
 
 `Linkshorter test = new Linkshorter("Adfocus", "https://gabboxl.ga"); `  <-- we call the constructor, in this case we will use the *Adfocus* service.
 
  `return test.GetLink(); ` <-- we get the link shorten with the *GetLink()* method.
  
  
  
  
  #--- coming soon
