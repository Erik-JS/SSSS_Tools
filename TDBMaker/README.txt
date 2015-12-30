TDB Maker
=========

This program can convert TDB files to XML, and then back to TDB, in order to facilitate
editing of the game's text.

Recommended text editor for XML editing: Notepad++ (https://notepad-plus-plus.org/)

Do not use good old Windows Notepad... more on that below.

=========================================================================================

### TDB to XML ###
------------------

- Drag and drop one or more TDB files into TDB Maker's window.
Resulting XML files will be created in the folder where source TDB's are.

OR

- Click "Convert TDB to XML";
- Select TDB file to be converted;
- Select XML file to be created.

### XML to TDB ###
------------------

- Drag and drop one or more XML files into TDB Maker's window.
Resulting TDB files will be created in the folder where source XML's are.

OR

- Click "Convert XML to TDB";
- Select XML file to be converted;
- Select TDB file to be created.

=========================================================================================

*****************
*** IMPORTANT ***
*****************

1) Do not run TDB Maker with admin rights or you may be unable to drop files on it.
This is also valid for running Visual Studio as admin and debugging TDB Maker through it.

2) Mark for new line used in generated XML's is 0A ("\n", vbLf), not 0D0A ("\r\n", vbCrLf).
Notepad can only recognize 0D0A as new line mark. Notepad++ is able to recognize both marks,
and any "enter" added by the user is written as whatever mark being already used in the file.
There are multiline strings in the game (example: Battle of Gold explanation).
TDB Maker will create a TDB file with whatever new line mark is present in the string entries
of the source XML.
While the game engine can work with both 0A and 0D0A, it seems developers intended to use only
the former. Some TDB files, which are leftovers from Brave Soldiers as far as I can tell, use
0D0A as new line mark, and TDB Maker will "convert" them to 0A (though this is useless
because, as I said, they are leftovers). BS leftovers are present in PS3 and PC versions of SS,
but only in PC they use 0D0A.

3) TDB's from BS (actual files from that game or leftovers in SS) don't have all languages
filled with text.
I originally intended to use language names in XML tags, but in order to maintain coherence
with BS, language tags in XML are named simply "LanguageX".
Language order in Brave Soldiers:
Japanese, English, Italian, French, Spanish, two unused languages and Brazilian Portuguese.
Language order in Soldiers' Soul:
Japanese, English, French, Italian, Castilian Spanish, Brazilian Portuguese, Latin American
Spanish and Chinese.

