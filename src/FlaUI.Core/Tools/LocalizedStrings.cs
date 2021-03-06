﻿namespace FlaUI.Core.Tools
{
    /// <summary>
    /// Static class which provides localized texts of some control texts.
    /// </summary>
    public static class LocalizedStrings
    {
        static LocalizedStrings()
        {
            switch (OperatingSystem.CurrentCulture.TwoLetterISOLanguageName)
            {
                case "de":
                    HorizontalScrollBar = "Horizontale Schiebeleiste";
                    VerticalScrollBar = "Vertikale Schiebeleiste";
                    TableHorizontalScrollBar = "Horizontale Schiebeleiste";
                    TableVerticalScrollBar = "Vertikale Schiebeleiste";
                    DataGridViewHeader = "Oberste Zeile";
                    DataGridViewHeaderItemTopLeft = "Obere linke Headerzelle";
                    break;
                default:
                    HorizontalScrollBar = "Horizontal ScrollBar";
                    VerticalScrollBar = "Vertical ScrollBar";
                    TableHorizontalScrollBar = "Horizontal Scroll Bar";
                    TableVerticalScrollBar = "Vertical Scroll Bar";
                    DataGridViewHeader = "Top Row";
                    DataGridViewHeaderItemTopLeft = "Top Left Header Cell";
                    break;
            }
        }

        public static string HorizontalScrollBar { get; }
        public static string VerticalScrollBar { get; }
        public static string TableHorizontalScrollBar { get; }
        public static string TableVerticalScrollBar { get; }

        /// <summary>
        /// Name of the header row in a DataGridView.
        /// </summary>
        public static string DataGridViewHeader { get; set; }

        /// <summary>
        /// Name of the top-left header item.
        /// </summary>
        public static string DataGridViewHeaderItemTopLeft { get; set; }
    }
}
