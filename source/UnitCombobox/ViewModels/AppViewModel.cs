﻿namespace UnitCombobox.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Windows.Input;
    using UnitComboLib;
    using UnitComboLib.Command;
    using UnitComboLib.Models;
    using UnitComboLib.Models.Unit;
    using UnitComboLib.Models.Unit.Screen;
    using UnitComboLib.ViewModels;

    public class AppViewModel : BaseViewModel
    {
        private ICommand _NavigateWebCommand;

        #region constructor
        /// <summary>
        /// Class constructor
        /// </summary>
        public AppViewModel()
        {
            this.SizeUnitLabel = UnitViewModeService.CreateInstance(
                this.GenerateScreenUnitList(), new ScreenConverter(),
                1,       // Default Unit 0 Percent, 1 ScreeFontPoints
                12      // Default Value
                ,"###" // Placeholder to measure for maximum expected string len in textbox
            );
        }
        #endregion constructor

        #region properties
        /// <summary>
        /// Gets the Unit ViewModel that drives
        /// the <seealso cref="UnitComboBox"/> control.
        /// </summary>
        public IUnitViewModel SizeUnitLabel { get; private set; }

        public string CodeProjectUri
        {       
            get
            {
                return "https://www.codeproject.com/Articles/575645/Inheriting-from-a-Look-Less-WPF-Control";
            }
        }

        public string GitHubUri
        {
            get
            {
                return "https://github.com/Dirkster99/UnitComboLib";
            }
        }

        public string NuGetUri
        {
            get
            {
                return "https://preview.nuget.org/packages/Dirkster.UnitComboLib/";
            }
        }

        public ICommand NavigateWebCommand
        {
            get
            {
                if (_NavigateWebCommand == null)
                {
                    _NavigateWebCommand = new RelayCommand<object>((p) =>
                    {
                        var param = p as string;

                        if (param == null) return;

                        Process.Start(new ProcessStartInfo(param));
                    });
                }

                return _NavigateWebCommand;
            }
        }
        #endregion properties

        #region methods
        private IList<ListItem> GenerateScreenUnitList()
        {
            IList<ListItem> unitList = new List<ListItem>();

            var percentDefaults = new ObservableCollection<string>() { "25", "50", "75", "100", "125", "150", "175", "200", "300", "400", "500" };
            var pointsDefaults = new ObservableCollection<string>() { "3", "6", "8", "9", "10", "12", "14", "16", "18", "20", "24", "26", "32", "48", "60" };

            unitList.Add(new ListItem(Itemkey.ScreenPercent, UnitComboLib.Local.Strings.Percent_String, UnitComboLib.Local.Strings.Percent_String_Short, percentDefaults));
            unitList.Add(new ListItem(Itemkey.ScreenFontPoints, UnitComboLib.Local.Strings.Point_String, UnitComboLib.Local.Strings.Point_String_Short, pointsDefaults));

            return unitList;
        }
        #endregion methods
    }
}
