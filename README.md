# Xpdf.Wrapper
A C# wrapper for [Xpdf](https://www.xpdfreader.com/ "Xpdf"). Reads text and images from a pdf file.

This is a near complete rewrite of thr XpdfNet library.  This allows for easier addition of more of the Xpdf executables and initially include PdfImages as well.

TODO:
-----
 * Research how to automatically use the correct Xpdf exe based on processor architecture (x86/x64) and OS.
 * Update and refresh unit tests based on code changes.
 * Add additional unit tests to handle added command line parameters.

Simple Usage
------------
```csharp
using Xpdf.Wrapper;

string content = Xpdf.PdfToText("./pathToFile.pdf");
```

You also have access to many of the XDF commandline params by alternatively passing in a PdfToTextParameters class to PdfToText.


Original XpdfNet Readme:

Usage
------
```csharp
using XpdfNet;

var pdfHelper = new XpdfHelper();

string content = pdfHelper.ToText("./pathToFile.pdf");
```
