# Overview

The WPF UnitComboBox Control implements a combobox that allows the selection of values from  different lists. Each list can represent a different unit (eg.: Celsius, Farenheit) and the viewmodel takes care of always converting to one unit (e.g. Celsius). This conversion is independent of what the user selected unit or value actually was.

This means, the application always sees only one unit and a different value while the user can use whatever unit he prefers to pick the aproppriate value.

Details are explained in a CodeProject article:
https://www.codeproject.com/Articles/575645/Inheriting-from-a-Look-Less-WPF-Control

The control is also used in Edi:
https://github.com/Dirkster99/Edi