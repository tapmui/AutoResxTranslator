## AutoResxTranslator
A tool to automatically translate Resx files to any language using Google Translator. 
Difference to origin is 
- Google API key is required for the translator. This is get large amount of values to be translated without restrictions
- values are translated as a list to speed up process
- translation multiple resx files with single call, including sub-directories.


Note that Microsoft translation is not supported in this version..

This tool also provides a text translator out of the box.

Text translation
------
![Text-Translation](/Wiki/Images/text-translation.png?raw=true)

Resx Translation
------
![ResX-Translation](/Wiki/Images/resx-translation.png?raw=true)

Please look the picture “Resx Translation” picture. It shows an example with Skoruba identity Admin folder.

Instructions:
Idea is that one selects original language [sourceLang], and source directory from where to start translation.
With parse all files checkbox you do not  define source file. 
Tool finds all files matching with pattern “.[sourceLang].resx”, including sub-directories.
You need to select language(s) to which you want to translate.

Results are generated in the directory of source file.


Resx translation is in progress
------
![ResX-Translation](/Wiki/Images/resx-translating.png?raw=true)

Import from Excel sheet
------
![excel-import](/Wiki/Images/excel-import.png?raw=true)

Select Microsoft Cognitive Translation Service
------
![ms-translator](/Wiki/Images/ms-translator.png?raw=true)
