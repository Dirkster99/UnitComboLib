[![Release](https://img.shields.io/github/release/Dirkster99/UnitComboLib.svg)](https://github.com/Dirkster99/UnitComboLib/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.UnitComboLib.svg)](http://nuget.org/packages/Dirkster.UnitComboLib)

# Overview

The WPF UnitComboBox Control implements a combobox that allows the selection of values from  different lists. Each list can represent a different unit (eg.: Celsius, Farenheit) and the viewmodel takes care of always converting to one unit (e.g. Celsius). This conversion is independent of what the user selected unit or value actually was.

This means, the application always sees only one unit and a different value while the user can use whatever unit he prefers to pick the aproppriate value.

Details are explained in a CodeProject article:
https://www.codeproject.com/Articles/575645/Inheriting-from-a-Look-Less-WPF-Control

The control is also used in Edi:
https://github.com/Dirkster99/Edi

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
