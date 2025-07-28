namespace CSStack.WinForms.FluentDesign
{
    public sealed record ColorResource
    {
        /// <summary>
        /// Accent Acrylic Background / Base: Used for the bottom most layer of an acrylic surface only when the surface
        /// will use layers.
        /// </summary>
        public  Color AccentAcrylicBackgroundFillColorBaseBrush { get; set; } = Color.FromArgb(180, 217, 245);

        /// <summary>
        /// Accent Acrylic Background / Default: Default acrylic recipe used for control flyouts and surfaces that live
        /// with in the context of an app.
        /// </summary>
        public  Color AccentAcrylicBackgroundFillColorDefaultBrush
        {
            get;
            set;
        } = Color.FromArgb(179, 216, 244);

        /// <summary>
        /// Accent Control / Border: Rest
        /// </summary>
        public  Color AccentControlElevationBorderBrush { get; set; } = Color.FromArgb(146, 146, 146);

        /// <summary>
        /// Accent / Default: Rest
        /// </summary>
        public  Color AccentFillColorDefaultBrush { get; set; } = Color.FromArgb(0, 90, 158);

        /// <summary>
        /// Accent / Disabled: Disabled
        /// </summary>
        public  Color AccentFillColorDisabledBrush { get; set; } = Color.FromArgb(191, 191, 191);

        /// <summary>
        /// Accent / Secondary: Hover
        /// </summary>
        public  Color AccentFillColorSecondaryBrush { get; set; } = Color.FromArgb(25, 106, 167);

        /// <summary>
        /// Accent / Selected Text Background: Highighted/selected text background
        /// </summary>
        public  Color AccentFillColorSelectedTextBackgroundBrush { get; set; } = Color.FromArgb(0, 120, 215);

        /// <summary>
        /// Accent / Tertiary: Pressed
        /// </summary>
        public  Color AccentFillColorTertiaryBrush { get; set; } = Color.FromArgb(49, 121, 175);

        /// <summary>
        /// Accent Text / Disabled: Disabled only (not accessible)
        /// </summary>
        public  Color AccentTextFillColorDisabledBrush { get; set; } = Color.FromArgb(155, 155, 155);

        /// <summary>
        /// Accent Text / Primary: Rest or Hover
        /// </summary>
        public  Color AccentTextFillColorPrimaryBrush { get; set; } = Color.FromArgb(0, 66, 117);

        /// <summary>
        /// Accent Text / Secondary: Rest or Hover
        /// </summary>
        public  Color AccentTextFillColorSecondaryBrush { get; set; } = Color.FromArgb(0, 38, 66);

        /// <summary>
        /// Accent Text / Tertiary: Pressed only (not accessible)
        /// </summary>
        public  Color AccentTextFillColorTertiaryBrush { get; set; } = Color.FromArgb(0, 90, 158);

        /// <summary>
        /// Acrylic Background / Base: Used for the bottom most layer of an acrylic surface only when the surface will
        /// use layers.
        /// </summary>
        public  Color AcrylicBackgroundFillColorBaseBrush { get; set; } = Color.FromArgb(239, 239, 239);

        /// <summary>
        /// Acrylic Background / Default: Default acrylic recipe used for control flyouts and surfaces that live with in
        /// the context of an app.
        /// </summary>
        public  Color AcrylicBackgroundFillColorDefaultBrush { get; set; } = Color.FromArgb(250, 250, 250);

        /// <summary>
        /// Card Background / Default: Default card color
        /// </summary>
        public  Color CardBackgroundFillColorDefaultBrush { get; set; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Card Background / Secondary: Alternate card color: slightly darker
        /// </summary>
        public  Color CardBackgroundFillColorSecondaryBrush { get; set; } = Color.FromArgb(244, 244, 244);

        /// <summary>
        /// Card Background / Tertiary: Default card hover and pressed color
        /// </summary>
        public  Color CardBackgroundTertiaryBrush { get; set; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Card Stroke / Default: Card layer and strokes
        /// </summary>
        public  Color CardStrokeColorDefaultBrush { get; set; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Card Stroke / Default Solid: Solid equivalent of Card Stroke / Default. Used in command bar for expanded
        /// states
        /// </summary>
        public  Color CardStrokeColorDefaultSolidBrush { get; set; } = Color.FromArgb(235, 235, 235);

        /// <summary>
        /// Circle / Border: Rest
        /// </summary>
        public  Color CircleElevationBorderBrush { get; set; } = Color.FromArgb(204, 204, 204);

        /// <summary>
        /// Control Alt / Disabled: Disabled
        /// </summary>
        public  Color ControlAltFillColorDisabledBrush { get; set; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control Alt / Quarternary: Pressed
        /// </summary>
        public  Color ControlAltFillColorQuarternaryBrush { get; set; } = Color.FromArgb(220, 220, 220);

        /// <summary>
        /// Control Alt / Secondary: Rest
        /// </summary>
        public  Color ControlAltFillColorSecondaryBrush { get; set; } = Color.FromArgb(237, 237, 237);

        /// <summary>
        /// Control Alt / Tertiary: Hover
        /// </summary>
        public  Color ControlAltFillColorTertiaryBrush { get; set; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Control Alt / Transparent
        /// </summary>
        public  Color ControlAltFillColorTransparentBrush { get; set; } = Color.Transparent;

        /// <summary>
        /// Control / Border: Rest
        /// </summary>
        public  Color ControlElevationBorderBrush { get; set; } = Color.FromArgb(204, 204, 204);

        /// <summary>
        /// Control / Default: Rest
        /// </summary>
        public  Color ControlFillColorDefaultBrush { get; set; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Control / Disabled: Disabled
        /// </summary>
        public  Color ControlFillColorDisabledBrush { get; set; } = Color.FromArgb(245, 245, 245);

        /// <summary>
        /// Control / Input Active: Active/focused text input fields
        /// </summary>
        public  Color ControlFillColorInputActiveBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Control / Quartenary: Rest (Pill Button control)
        /// </summary>
        public  Color ControlFillColorQuarternaryBrush { get; set; } = Color.FromArgb(245, 245, 245);

        /// <summary>
        /// Control / Secondary: Hover
        /// </summary>
        public  Color ControlFillColorSecondaryBrush { get; set; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Control / Tertiary: Pressed
        /// </summary>
        public  Color ControlFillColorTertiaryBrush { get; set; } = Color.FromArgb(245, 245, 245);

        /// <summary>
        /// Control / Transparent: Rest
        /// </summary>
        public  Color ControlFillColorTransparentBrush { get; set; } = Color.Transparent;

        /// <summary>
        /// Control On Image Fill Default: Rest
        /// </summary>
        public  Color ControlOnImageFillColorDefaultBrush { get; set; } = Color.FromArgb(252, 252, 252);

        /// <summary>
        /// Control On Image Fill Disabled: Disabled only (not accessible)
        /// </summary>
        public  Color ControlOnImageFillColorDisabledBrush { get; set; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control On Image Fill Secondary: Hover
        /// </summary>
        public  Color ControlOnImageFillColorSecondaryBrush { get; set; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control On Image Fill Tertiary: Pressed
        /// </summary>
        public  Color ControlOnImageFillColorTertiaryBrush { get; set; } = Color.FromArgb(235, 235, 235);

        /// <summary>
        /// Control Solid / Default: Rest
        /// </summary>
        public  Color ControlSolidFillColorDefaultBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Control Stroke / Default: Used in Control Elevation Brushes. Pressed or Disabled
        /// </summary>
        public  Color ControlStrokeColorDefaultBrush { get; set; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Control Stroke / For Strong Fill When On Image: When used with a 'strong' fill color, ensures a 3:1 contrast
        /// on any background
        /// </summary>
        public  Color ControlStrokeColorForStrongFillWhenOnImageBrush
        {
            get;
            set;
        } = Color.FromArgb(247, 247, 247);

        /// <summary>
        /// Control Stroke / On Accent Default: Used in Control Elevation Brushes. Pressed or Disabled
        /// </summary>
        public  Color ControlStrokeColorOnAccentDefaultBrush { get; set; } = Color.FromArgb(244, 244, 244);

        /// <summary>
        /// Control Stroke / On Accent Disabled: Disabled
        /// </summary>
        public  Color ControlStrokeColorOnAccentDisabledBrush { get; set; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Control Stroke / On Accent Secondary: Used in Control Elevation Brushes
        /// </summary>
        public  Color ControlStrokeColorOnAccentSecondaryBrush { get; set; } = Color.FromArgb(146, 146, 146);

        /// <summary>
        /// Control Stroke / On Accent Tertiary: Linework on Accent controls, ie: dividers
        /// </summary>
        public  Color ControlStrokeColorOnAccentTertiaryBrush { get; set; } = Color.FromArgb(191, 191, 191);

        /// <summary>
        /// Control Stroke / Secondary: Used in Control Elevation Brushes
        /// </summary>
        public  Color ControlStrokeColorSecondaryBrush { get; set; } = Color.FromArgb(204, 204, 204);

        /// <summary>
        /// Control Strong / Default: Rest or hover
        /// </summary>
        public  Color ControlStrongFillColorDefaultBrush { get; set; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Control Strong / Disabled: Disabled only (not accessible)
        /// </summary>
        public  Color ControlStrongFillColorDisabledBrush { get; set; } = Color.FromArgb(166, 166, 166);

        /// <summary>
        /// Control Strong Stroke / Default: 3:1 control border
        /// </summary>
        public  Color ControlStrongStrokeColorDefaultBrush { get; set; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Control Strong Stroke / Disabled: Disabled
        /// </summary>
        public  Color ControlStrongStrokeColorDisabledBrush { get; set; } = Color.FromArgb(191, 191, 191);

        /// <summary>
        /// Divider Stroke / Default: Content dividers
        /// </summary>
        public  Color DividerStrokeColorDefaultBrush { get; set; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Focus / Inner: Inner stroke color
        /// </summary>
        public  Color FocusStrokeColorInnerBrush { get; set; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Focus / Outer: Outer stroke color
        /// </summary>
        public  Color FocusStrokeColorOuterBrush { get; set; } = Color.FromArgb(26, 26, 26);

        /// <summary>
        /// Layer / Alt: Alternate content layer color
        /// </summary>
        public  Color LayerFillColorAltBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Layer / Default: Content layer color
        /// </summary>
        public  Color LayerFillColorDefaultBrush { get; set; } = Color.FromArgb(249, 249, 249);

        /// <summary>
        /// Layer On Acrylic / Default: Content layer color on acrylic surfaces
        /// </summary>
        public  Color LayerOnAcrylicFillColorDefaultBrush { get; set; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Layer On Mica Base Alt / Default: Active Tab Rest, Content layer
        /// </summary>
        public  Color LayerOnMicaBaseAltFillColorDefaultBrush { get; set; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Layer On Mica Base Alt / Secondary: Inactive Tab Hover
        /// </summary>
        public  Color LayerOnMicaBaseAltFillColorSecondaryBrush { get; set; } = Color.FromArgb(233, 233, 233);

        /// <summary>
        /// Layer On Mica Base Alt / Tertiary: Active Tab Drag
        /// </summary>
        public  Color LayerOnMicaBaseAltFillColorTertiaryBrush { get; set; } = Color.FromArgb(249, 249, 249);

        /// <summary>
        /// Layer On Mica Base Alt / Transparent: Inactive Tab Rest
        /// </summary>
        public  Color LayerOnMicaBaseAltFillColorTransparentBrush
        {
            get;
            set;
        } = Color.Transparent;

        /// <summary>
        /// Mica Background / Base Alt: Default tab band background color.
        /// </summary>
        public  Color MicaBackgroundFillColorBaseAltBrush { get; set; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Mica Background / Base: Used for the bottom most layer of an experience.
        /// </summary>
        public  Color MicaBackgroundFillColorBaseBrush { get; set; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Smoke / Default: Dims the background behind dialogs
        /// </summary>
        public  Color SmokeFillColorDefaultBrush { get; set; } = Color.FromArgb(170, 170, 170);

        /// <summary>
        /// Solid Background / Base Alt: Used for the bottom most layer of an experience.
        /// </summary>
        public  Color SolidBackgroundFillColorBaseAltBrush { get; set; } = Color.FromArgb(218, 218, 218);

        /// <summary>
        /// Solid Background / Base: Used for the bottom most layer of an experience.
        /// </summary>
        public  Color SolidBackgroundFillColorBaseBrush { get; set; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Solid Background / Quarternary: Alt content layer color.
        /// </summary>
        public  Color SolidBackgroundFillColorQuarternaryBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Solid Background / Quinary: Used for solid default card colors
        /// </summary>
        public  Color SolidBackgroundFillColorQuinaryBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Solid Background / Secondary: Alternate base color for those who need a darker background color.
        /// </summary>
        public  Color SolidBackgroundFillColorSecondaryBrush { get; set; } = Color.FromArgb(238, 238, 238);

        /// <summary>
        /// Solid Background / Senary: Used for solid default card color
        /// </summary>
        public  Color SolidBackgroundFillColorSenaryBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Solid Background / Tertiary: Content layer color
        /// </summary>
        public  Color SolidBackgroundFillColorTertiaryBrush { get; set; } = Color.FromArgb(249, 249, 249);

        /// <summary>
        /// Subtle / Disabled: Disabled only (not accessible)
        /// </summary>
        public  Color SubtleFillColorDisabledBrush { get; set; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Subtle / Secondary: Hover
        /// </summary>
        public  Color SubtleFillColorSecondaryBrush { get; set; } = Color.FromArgb(234, 234, 234);

        /// <summary>
        /// Subtle / Tertiary: Pressed
        /// </summary>
        public  Color SubtleFillColorTertiaryBrush { get; set; } = Color.FromArgb(237, 237, 237);

        /// <summary>
        /// Subtle / Transparent: Rest
        /// </summary>
        public  Color SubtleFillColorTransparentBrush { get; set; } = Color.Transparent;

        /// <summary>
        /// Surface Stroke / Default: Window and dialog borders, theme inverse
        /// </summary>
        public  Color SurfaceStrokeColorDefaultBrush { get; set; } = Color.FromArgb(193, 193, 193);

        /// <summary>
        /// Surface Stroke / Flyout: Control flyouts, always dark
        /// </summary>
        public  Color SurfaceStrokeColorFlyoutBrush { get; set; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Button Face Color: Background color for buttons and any UI that can be interacted with.
        /// </summary>
        public  Color SystemColorButtonFaceColor { get; set; } = Color.FromArgb(32, 32, 32);

        /// <summary>
        /// Button Text Color: Foreground color for buttons and any UI that can be interacted with.
        /// </summary>
        public  Color SystemColorButtonTextColor { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Grey Text Color / Disabled: Foreground / Text color for Inactive (disabled) UI.
        /// </summary>
        public  Color SystemColorGreyTextColor { get; set; } = Color.FromArgb(166, 166, 166);

        /// <summary>
        /// Highlight Color: Background or accent color for UI that is selected, interacted with (hover, pressed), or in
        /// progress.
        /// </summary>
        public  Color SystemColorHighlightColor { get; set; } = Color.FromArgb(142, 227, 240);

        /// <summary>
        /// Highlight Text Color: Foreground color for text or UI that is selected, interacted with (hover, pressed), or
        /// in progress.
        /// </summary>
        public  Color SystemColorHighlightTextColor { get; set; } = Color.FromArgb(38, 59, 80);

        /// <summary>
        /// Hotlight Color: Foreground / Text color for hyperlink text.
        /// </summary>
        public  Color SystemColorHotlightColor { get; set; } = Color.FromArgb(117, 233, 252);

        /// <summary>
        /// Window Color: Background of pages, panes, popups, and windows.
        /// </summary>
        public  Color SystemColorWindowColor { get; set; } = Color.FromArgb(32, 32, 32);

        /// <summary>
        /// Window Text Color: Foreground / Text color for Headings, body copy, lists, placeholder text, app and window
        /// borders, any UI that can't be interacted with.
        /// </summary>
        public  Color SystemColorWindowTextColor { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// System / Attention Background: Infobar Background
        /// </summary>
        public  Color SystemFillColorAttentionBackgroundBrush { get; set; } = Color.FromArgb(244, 244, 244);

        /// <summary>
        /// System / Attention: Badge
        /// </summary>
        public  Color SystemFillColorAttentionBrush { get; set; } = Color.FromArgb(0, 120, 215);

        /// <summary>
        /// System / Caution Background: Infobar Background
        /// </summary>
        public  Color SystemFillColorCautionBackgroundBrush { get; set; } = Color.FromArgb(255, 244, 206);

        /// <summary>
        /// System / Caution: Badge
        /// </summary>
        public  Color SystemFillColorCautionBrush { get; set; } = Color.FromArgb(157, 93, 0);

        /// <summary>
        /// System / Critical Background: Infobar Background
        /// </summary>
        public  Color SystemFillColorCriticalBackgroundBrush { get; set; } = Color.FromArgb(253, 231, 233);

        /// <summary>
        /// System / Critical: Badge
        /// </summary>
        public  Color SystemFillColorCriticalBrush { get; set; } = Color.FromArgb(196, 43, 28);

        /// <summary>
        /// System / Neutral Background: Infobar Background
        /// </summary>
        public  Color SystemFillColorNeutralBackgroundBrush { get; set; } = Color.FromArgb(237, 237, 237);

        /// <summary>
        /// System / Neutral: Badge
        /// </summary>
        public  Color SystemFillColorNeutralBrush { get; set; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// System / Solid Attention Background: System / Solid Attention Background
        /// </summary>
        public  Color SystemFillColorSolidAttentionBackgroundBrush
        {
            get;
            set;
        } = Color.FromArgb(247, 247, 247);

        /// <summary>
        /// System / Solid Neutral Background: Neutral badges over content
        /// </summary>
        public  Color SystemFillColorSolidNeutralBackgroundBrush { get; set; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// System / Solid Neutral: Neutral badges over content
        /// </summary>
        public  Color SystemFillColorSolidNeutralBrush { get; set; } = Color.FromArgb(138, 138, 138);

        /// <summary>
        /// System / Success Background: Infobar Background
        /// </summary>
        public  Color SystemFillColorSuccessBackgroundBrush { get; set; } = Color.FromArgb(223, 246, 221);

        /// <summary>
        /// System / Success: Badge
        /// </summary>
        public  Color SystemFillColorSuccessBrush { get; set; } = Color.FromArgb(15, 123, 15);

        /// <summary>
        /// Text Control / Border: Rest
        /// </summary>
        public  Color TextControlElevationBorderBrush { get; set; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Text Control / Border Focused: Active text fields
        /// </summary>
        public  Color TextControlElevationBorderFocusedBrush { get; set; } = Color.FromArgb(0, 90, 158);

        /// <summary>
        /// Text / Disabled: Disabled only (not accessible)
        /// </summary>
        public  Color TextFillColorDisabledBrush { get; set; } = Color.FromArgb(155, 155, 155);

        /// <summary>
        /// Text / Primary: Rest or Hover
        /// </summary>
        public  Color TextFillColorPrimaryBrush { get; set; } = Color.FromArgb(26, 26, 26);

        /// <summary>
        /// Text / Secondary: Rest or Hover
        /// </summary>

        public  Color TextFillColorSecondaryBrush { get; set; } = Color.FromArgb(92, 92, 92);

        /// <summary>
        /// Text / Tertiary: Pressed only (not accessible)
        /// </summary>
        public  Color TextFillColorTertiaryBrush { get; set; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Text on Accent / Disabled: Disabled only (not accessible)
        /// </summary>
        public  Color TextOnAccentFillColorDisabledBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Text on Accent / Primary: Rest or Hover
        /// </summary>
        public  Color TextOnAccentFillColorPrimaryBrush { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Text on Accent / Secondary: Pressed only (not accessible)
        /// </summary>
        public  Color TextOnAccentFillColorSecondaryBrush { get; set; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Text on Accent / Selected: Text For highlighted text in text entry experiences
        /// </summary>
        public  Color TextOnAccentFillColorSelectedTextBrush { get; set; } = Color.FromArgb(255, 255, 255);
    }
}
