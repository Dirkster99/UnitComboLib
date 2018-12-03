[![Build status](https://ci.appveyor.com/api/projects/status/8rmd1b9d35efwunj?svg=true)](https://ci.appveyor.com/project/Dirkster99/unitcombolib)
[![Release](https://img.shields.io/github/release/Dirkster99/UnitComboLib.svg)](https://github.com/Dirkster99/UnitComboLib/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.UnitComboLib.svg)](http://nuget.org/packages/Dirkster.UnitComboLib)

# Overview

The WPF UnitComboBox Control implements a combobox that allows the selection of values from  different lists. Each list can represent a different unit (eg.: Celsius, Farenheit) and the viewmodel takes care of always converting to one unit (e.g. Celsius). This conversion is independent of what the user selected unit or value actually was.

This means, the application always sees only one unit and a different value while the user can use whatever unit he prefers to pick the aproppriate value.

<table cellspacing="0" cellpadding="0">
<tr>
<td valign="bottom">
<img src="https://github.com/Dirkster99/Docu/blob/master/UnitComboLib/MetroDark_Percent.png" width="100"/>
</td><td valign="bottom">
<img src="https://github.com/Dirkster99/Docu/blob/master/UnitComboLib/MetroDark_Pt.png" width="100"/>
</td><td valign="bottom">
<img src="https://github.com/Dirkster99/Docu/blob/master/UnitComboLib/MetroLight_Percent.png" width="150"/>
</td><td valign="bottom">
<img src="https://github.com/Dirkster99/Docu/blob/master/UnitComboLib/MetroLight_Pt.png" width="100"/>
</td>
</tr>
</table>

Details are explained in a CodeProject article:
https://www.codeproject.com/Articles/575645/Inheriting-from-a-Look-Less-WPF-Control

Sample Applications:
- [Edi](https://github.com/Dirkster99/Edi)
- [XmlExplorer](https://github.com/Dirkster99/XmlExplorer)

## Theming

Load *Light* or *Dark* brush resources in you resource dictionary to take advantage of existing definitions.

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/UnitComboLib;component/Themes/DarkBrushs.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/UnitComboLib;component/Themes/LightBrushs.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

These definitions do not theme all controls used within this library. You should use a standard theming library, such as:
- [MahApps.Metro](https://github.com/MahApps/MahApps.Metro),
- [MLib](https://github.com/Dirkster99/MLib), or
- [MUI](https://github.com/firstfloorsoftware/mui)

to also theme standard elements, such as, button and textblock etc.
