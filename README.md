# SSSS Tools
Collection of tools for Saint Seiya: Soldiers' Soul <br />
Author: Erik JS

--------------------------------------------------------

## TDB Reader
Reads TDB files.
- Language: Java

## Soul Save Editor
Reads and edits game's saved data, for PC or PS3.
PS3's savedata file must be decrypted with third-party tools.
- Language: Visual Basic (.NET Framework 4.5)

## TDB Maker
Converts TDB files to and from XML.
- Language: C# (.NET Framework 4.5)

--------------------------------------------------------

### Extracting files from resource.cpk
Using [QuickBMS](http://aluigi.altervista.org/quickbms.htm):<br />
1- Double-click quickbms.exe;<br />
2- Select cpk.bms (available at QuickBMS' page);<br />
3- Select resource.cpk;<br />
4- Select folder where contents will be extracted to;<br />
*To avoid ambiguity: you have to enter in the folder where contents will be put.*<br />
5- Wait until everything is extracted.<br />

### Injecting modified files into resource.cpk
1- Create a 'mod' folder somewhere;<br />
2- Put edited files in the 'mod' folder, keeping the original folder hierarchy from resource.cpk;<br />
*Example: you edited or created a new TdbPauseMenu.tdb, then it should be in 'mod\resource\text'.*<br />
3- Go to QuickBMS' folder, double-click reimport.bat;<br />
4- Select cpk.bms;<br />
5- Select resource.cpk;<br />
6- Select 'mod' folder;<br />
*This means you have to enter in the 'mod' folder.*<br />
7- Wait until QuickBMS says all files have been reimported.

--------------------------------------------------------

**Always back up your files before modifying your game!**

--------------------------------------------------------

These tools are not made or supported by BANDAI NAMCO Entertainment Inc. or its affiliates.

Saint Seiya © Masami Kurumada, Toei Animation <br />
Game © 2015 BANDAI NAMCO Entertainment Inc.