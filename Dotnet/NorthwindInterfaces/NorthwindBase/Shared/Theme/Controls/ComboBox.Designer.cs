﻿namespace Northwind.Shared.Theme.Controls
{
    partial class ComboBox
    {
        void InitializeComponent()
        {
            AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0,0,0,0);
            AbsoluteBindTop = true;
            Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            RightToLeftLayout = false;
            FontScheme = new Northwind.Shared.Theme.Fonts.DefaultTableEditField();
            ColorScheme = new Northwind.Shared.Theme.Colors.DefaultEditField();
            DrawDisabledWhiteContour = false;
            Style = Firefly.Box.UI.ControlStyle.Sunken;
            Lines = 0;
            HideSelectionBoxWhileInactiveOnGrid = true;
            ClearListIfListSourceHasNoRowsAndDisplayValueWasSet = true;
        }
    }
}
