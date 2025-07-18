namespace CSStack.WinForms.FluentDesign
{
    public sealed record ColorResource
    {
        /// <summary>
        /// Accent Acrylic Background / Base: Used for the bottom most layer of an acrylic surface only when the surface
        /// will use layers.
        /// </summary>
        public required Color AccentAcrylicBackgroundFillColorBaseBrush { get; init; } = Color.FromArgb(180, 217, 245);

        /// <summary>
        /// Accent Acrylic Background / Default: Default acrylic recipe used for control flyouts and surfaces that live
        /// with in the context of an app.
        /// </summary>
        public required Color AccentAcrylicBackgroundFillColorDefaultBrush
        {
            get;
            init;
        } = Color.FromArgb(179, 216, 244);

        /// <summary>
        /// Accent Control / Border: Rest
        /// </summary>
        public required Color AccentControlElevationBorderBrush { get; init; } = Color.FromArgb(146, 146, 146);

        /// <summary>
        /// Accent / Default: Rest
        /// </summary>
        public required Color AccentFillColorDefaultBrush { get; init; } = Color.FromArgb(0, 90, 158);

        /// <summary>
        /// Accent / Disabled: Disabled
        /// </summary>
        public required Color AccentFillColorDisabledBrush { get; init; } = Color.FromArgb(191, 191, 191);

        /// <summary>
        /// Accent / Secondary: Hover
        /// </summary>
        public required Color AccentFillColorSecondaryBrush { get; init; } = Color.FromArgb(25, 106, 167);

        /// <summary>
        /// Accent / Selected Text Background: Highighted/selected text background
        /// </summary>
        public required Color AccentFillColorSelectedTextBackgroundBrush { get; init; } = Color.FromArgb(0, 120, 215);

        /// <summary>
        /// Accent / Tertiary: Pressed
        /// </summary>
        public required Color AccentFillColorTertiaryBrush { get; init; } = Color.FromArgb(49, 121, 175);

        /// <summary>
        /// Accent Text / Disabled: Disabled only (not accessible)
        /// </summary>
        public required Color AccentTextFillColorDisabledBrush { get; init; } = Color.FromArgb(155, 155, 155);

        /// <summary>
        /// Accent Text / Primary: Rest or Hover
        /// </summary>
        public required Color AccentTextFillColorPrimaryBrush { get; init; } = Color.FromArgb(0, 66, 117);

        /// <summary>
        /// Accent Text / Secondary: Rest or Hover
        /// </summary>
        public required Color AccentTextFillColorSecondaryBrush { get; init; } = Color.FromArgb(0, 38, 66);

        /// <summary>
        /// Accent Text / Tertiary: Pressed only (not accessible)
        /// </summary>
        public required Color AccentTextFillColorTertiaryBrush { get; init; } = Color.FromArgb(0, 90, 158);

        /// <summary>
        /// Acrylic Background / Base: Used for the bottom most layer of an acrylic surface only when the surface will
        /// use layers.
        /// </summary>
        public required Color AcrylicBackgroundFillColorBaseBrush { get; init; } = Color.FromArgb(239, 239, 239);

        /// <summary>
        /// Acrylic Background / Default: Default acrylic recipe used for control flyouts and surfaces that live with in
        /// the context of an app.
        /// </summary>
        public required Color AcrylicBackgroundFillColorDefaultBrush { get; init; } = Color.FromArgb(250, 250, 250);

        /// <summary>
        /// Card Background / Default: Default card color
        /// </summary>
        public required Color CardBackgroundFillColorDefaultBrush { get; init; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Card Background / Secondary: Alternate card color: slightly darker
        /// </summary>
        public required Color CardBackgroundFillColorSecondaryBrush { get; init; } = Color.FromArgb(244, 244, 244);

        /// <summary>
        /// Card Background / Tertiary: Default card hover and pressed color
        /// </summary>
        public required Color CardBackgroundTertiaryBrush { get; init; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Card Stroke / Default: Card layer and strokes
        /// </summary>
        public required Color CardStrokeColorDefaultBrush { get; init; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Card Stroke / Default Solid: Solid equivalent of Card Stroke / Default. Used in command bar for expanded
        /// states
        /// </summary>
        public required Color CardStrokeColorDefaultSolidBrush { get; init; } = Color.FromArgb(235, 235, 235);

        /// <summary>
        /// Circle / Border: Rest
        /// </summary>
        public required Color CircleElevationBorderBrush { get; init; } = Color.FromArgb(204, 204, 204);

        /// <summary>
        /// Control Alt / Disabled: Disabled
        /// </summary>
        public required Color ControlAltFillColorDisabledBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control Alt / Quarternary: Pressed
        /// </summary>
        public required Color ControlAltFillColorQuarternaryBrush { get; init; } = Color.FromArgb(220, 220, 220);

        /// <summary>
        /// Control Alt / Secondary: Rest
        /// </summary>
        public required Color ControlAltFillColorSecondaryBrush { get; init; } = Color.FromArgb(237, 237, 237);

        /// <summary>
        /// Control Alt / Tertiary: Hover
        /// </summary>
        public required Color ControlAltFillColorTertiaryBrush { get; init; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Control Alt / Transparent
        /// </summary>
        public required Color ControlAltFillColorTransparentBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control / Border: Rest
        /// </summary>
        public required Color ControlElevationBorderBrush { get; init; } = Color.FromArgb(204, 204, 204);

        /// <summary>
        /// Control / Default: Rest
        /// </summary>
        public required Color ControlFillColorDefaultBrush { get; init; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Control / Disabled: Disabled
        /// </summary>
        public required Color ControlFillColorDisabledBrush { get; init; } = Color.FromArgb(245, 245, 245);

        /// <summary>
        /// Control / Input Active: Active/focused text input fields
        /// </summary>
        public required Color ControlFillColorInputActiveBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Control / Quartenary: Rest (Pill Button control)
        /// </summary>
        public required Color ControlFillColorQuarternaryBrush { get; init; } = Color.FromArgb(245, 245, 245);

        /// <summary>
        /// Control / Secondary: Hover
        /// </summary>
        public required Color ControlFillColorSecondaryBrush { get; init; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Control / Tertiary: Pressed
        /// </summary>
        public required Color ControlFillColorTertiaryBrush { get; init; } = Color.FromArgb(245, 245, 245);

        /// <summary>
        /// Control / Transparent: Rest
        /// </summary>
        public required Color ControlFillColorTransparentBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control On Image Fill Default: Rest
        /// </summary>
        public required Color ControlOnImageFillColorDefaultBrush { get; init; } = Color.FromArgb(252, 252, 252);

        /// <summary>
        /// Control On Image Fill Disabled: Disabled only (not accessible)
        /// </summary>
        public required Color ControlOnImageFillColorDisabledBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control On Image Fill Secondary: Hover
        /// </summary>
        public required Color ControlOnImageFillColorSecondaryBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Control On Image Fill Tertiary: Pressed
        /// </summary>
        public required Color ControlOnImageFillColorTertiaryBrush { get; init; } = Color.FromArgb(235, 235, 235);

        /// <summary>
        /// Control Solid / Default: Rest
        /// </summary>
        public required Color ControlSolidFillColorDefaultBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Control Stroke / Default: Used in Control Elevation Brushes. Pressed or Disabled
        /// </summary>
        public required Color ControlStrokeColorDefaultBrush { get; init; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Control Stroke / For Strong Fill When On Image: When used with a 'strong' fill color, ensures a 3:1 contrast
        /// on any background
        /// </summary>
        public required Color ControlStrokeColorForStrongFillWhenOnImageBrush
        {
            get;
            init;
        } = Color.FromArgb(247, 247, 247);

        /// <summary>
        /// Control Stroke / On Accent Default: Used in Control Elevation Brushes. Pressed or Disabled
        /// </summary>
        public required Color ControlStrokeColorOnAccentDefaultBrush { get; init; } = Color.FromArgb(244, 244, 244);

        /// <summary>
        /// Control Stroke / On Accent Disabled: Disabled
        /// </summary>
        public required Color ControlStrokeColorOnAccentDisabledBrush { get; init; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Control Stroke / On Accent Secondary: Used in Control Elevation Brushes
        /// </summary>
        public required Color ControlStrokeColorOnAccentSecondaryBrush { get; init; } = Color.FromArgb(146, 146, 146);

        /// <summary>
        /// Control Stroke / On Accent Tertiary: Linework on Accent controls, ie: dividers
        /// </summary>
        public required Color ControlStrokeColorOnAccentTertiaryBrush { get; init; } = Color.FromArgb(191, 191, 191);

        /// <summary>
        /// Control Stroke / Secondary: Used in Control Elevation Brushes
        /// </summary>
        public required Color ControlStrokeColorSecondaryBrush { get; init; } = Color.FromArgb(204, 204, 204);

        /// <summary>
        /// Control Strong / Default: Rest or hover
        /// </summary>
        public required Color ControlStrongFillColorDefaultBrush { get; init; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Control Strong / Disabled: Disabled only (not accessible)
        /// </summary>
        public required Color ControlStrongFillColorDisabledBrush { get; init; } = Color.FromArgb(166, 166, 166);

        /// <summary>
        /// Control Strong Stroke / Default: 3:1 control border
        /// </summary>
        public required Color ControlStrongStrokeColorDefaultBrush { get; init; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Control Strong Stroke / Disabled: Disabled
        /// </summary>
        public required Color ControlStrongStrokeColorDisabledBrush { get; init; } = Color.FromArgb(191, 191, 191);

        /// <summary>
        /// Divider Stroke / Default: Content dividers
        /// </summary>
        public required Color DividerStrokeColorDefaultBrush { get; init; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Focus / Inner: Inner stroke color
        /// </summary>
        public required Color FocusStrokeColorInnerBrush { get; init; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Focus / Outer: Outer stroke color
        /// </summary>
        public required Color FocusStrokeColorOuterBrush { get; init; } = Color.FromArgb(26, 26, 26);

        /// <summary>
        /// Layer / Alt: Alternate content layer color
        /// </summary>
        public required Color LayerFillColorAltBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Layer / Default: Content layer color
        /// </summary>
        public required Color LayerFillColorDefaultBrush { get; init; } = Color.FromArgb(249, 249, 249);

        /// <summary>
        /// Layer On Acrylic / Default: Content layer color on acrylic surfaces
        /// </summary>
        public required Color LayerOnAcrylicFillColorDefaultBrush { get; init; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Layer On Mica Base Alt / Default: Active Tab Rest, Content layer
        /// </summary>
        public required Color LayerOnMicaBaseAltFillColorDefaultBrush { get; init; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Layer On Mica Base Alt / Secondary: Inactive Tab Hover
        /// </summary>
        public required Color LayerOnMicaBaseAltFillColorSecondaryBrush { get; init; } = Color.FromArgb(233, 233, 233);

        /// <summary>
        /// Layer On Mica Base Alt / Tertiary: Active Tab Drag
        /// </summary>
        public required Color LayerOnMicaBaseAltFillColorTertiaryBrush { get; init; } = Color.FromArgb(249, 249, 249);

        /// <summary>
        /// Layer On Mica Base Alt / Transparent: Inactive Tab Rest
        /// </summary>
        public required Color LayerOnMicaBaseAltFillColorTransparentBrush
        {
            get;
            init;
        } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Mica Background / Base Alt: Default tab band background color.
        /// </summary>
        public required Color MicaBackgroundFillColorBaseAltBrush { get; init; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Mica Background / Base: Used for the bottom most layer of an experience.
        /// </summary>
        public required Color MicaBackgroundFillColorBaseBrush { get; init; } = Color.FromArgb(246, 246, 246);

        /// <summary>
        /// Smoke / Default: Dims the background behind dialogs
        /// </summary>
        public required Color SmokeFillColorDefaultBrush { get; init; } = Color.FromArgb(170, 170, 170);

        /// <summary>
        /// Solid Background / Base Alt: Used for the bottom most layer of an experience.
        /// </summary>
        public required Color SolidBackgroundFillColorBaseAltBrush { get; init; } = Color.FromArgb(218, 218, 218);

        /// <summary>
        /// Solid Background / Base: Used for the bottom most layer of an experience.
        /// </summary>
        public required Color SolidBackgroundFillColorBaseBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Solid Background / Quarternary: Alt content layer color.
        /// </summary>
        public required Color SolidBackgroundFillColorQuarternaryBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Solid Background / Quinary: Used for solid default card colors
        /// </summary>
        public required Color SolidBackgroundFillColorQuinaryBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Solid Background / Secondary: Alternate base color for those who need a darker background color.
        /// </summary>
        public required Color SolidBackgroundFillColorSecondaryBrush { get; init; } = Color.FromArgb(238, 238, 238);

        /// <summary>
        /// Solid Background / Senary: Used for solid default card color
        /// </summary>
        public required Color SolidBackgroundFillColorSenaryBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Solid Background / Tertiary: Content layer color
        /// </summary>
        public required Color SolidBackgroundFillColorTertiaryBrush { get; init; } = Color.FromArgb(249, 249, 249);

        /// <summary>
        /// Subtle / Disabled: Disabled only (not accessible)
        /// </summary>
        public required Color SubtleFillColorDisabledBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Subtle / Secondary: Hover
        /// </summary>
        public required Color SubtleFillColorSecondaryBrush { get; init; } = Color.FromArgb(234, 234, 234);

        /// <summary>
        /// Subtle / Tertiary: Pressed
        /// </summary>
        public required Color SubtleFillColorTertiaryBrush { get; init; } = Color.FromArgb(237, 237, 237);

        /// <summary>
        /// Subtle / Transparent: Rest
        /// </summary>
        public required Color SubtleFillColorTransparentBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// Surface Stroke / Default: Window and dialog borders, theme inverse
        /// </summary>
        public required Color SurfaceStrokeColorDefaultBrush { get; init; } = Color.FromArgb(193, 193, 193);

        /// <summary>
        /// Surface Stroke / Flyout: Control flyouts, always dark
        /// </summary>
        public required Color SurfaceStrokeColorFlyoutBrush { get; init; } = Color.FromArgb(229, 229, 229);

        /// <summary>
        /// Button Face Color: Background color for buttons and any UI that can be interacted with.
        /// </summary>
        public required Color SystemColorButtonFaceColor { get; init; } = Color.FromArgb(32, 32, 32);

        /// <summary>
        /// Button Text Color: Foreground color for buttons and any UI that can be interacted with.
        /// </summary>
        public required Color SystemColorButtonTextColor { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Grey Text Color / Disabled: Foreground / Text color for Inactive (disabled) UI.
        /// </summary>
        public required Color SystemColorGreyTextColor { get; init; } = Color.FromArgb(166, 166, 166);

        /// <summary>
        /// Highlight Color: Background or accent color for UI that is selected, interacted with (hover, pressed), or in
        /// progress.
        /// </summary>
        public required Color SystemColorHighlightColor { get; init; } = Color.FromArgb(142, 227, 240);

        /// <summary>
        /// Highlight Text Color: Foreground color for text or UI that is selected, interacted with (hover, pressed), or
        /// in progress.
        /// </summary>
        public required Color SystemColorHighlightTextColor { get; init; } = Color.FromArgb(38, 59, 80);

        /// <summary>
        /// Hotlight Color: Foreground / Text color for hyperlink text.
        /// </summary>
        public required Color SystemColorHotlightColor { get; init; } = Color.FromArgb(117, 233, 252);

        /// <summary>
        /// Window Color: Background of pages, panes, popups, and windows.
        /// </summary>
        public required Color SystemColorWindowColor { get; init; } = Color.FromArgb(32, 32, 32);

        /// <summary>
        /// Window Text Color: Foreground / Text color for Headings, body copy, lists, placeholder text, app and window
        /// borders, any UI that can't be interacted with.
        /// </summary>
        public required Color SystemColorWindowTextColor { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// System / Attention Background: Infobar Background
        /// </summary>
        public required Color SystemFillColorAttentionBackgroundBrush { get; init; } = Color.FromArgb(244, 244, 244);

        /// <summary>
        /// System / Attention: Badge
        /// </summary>
        public required Color SystemFillColorAttentionBrush { get; init; } = Color.FromArgb(0, 120, 215);

        /// <summary>
        /// System / Caution Background: Infobar Background
        /// </summary>
        public required Color SystemFillColorCautionBackgroundBrush { get; init; } = Color.FromArgb(255, 244, 206);

        /// <summary>
        /// System / Caution: Badge
        /// </summary>
        public required Color SystemFillColorCautionBrush { get; init; } = Color.FromArgb(157, 93, 0);

        /// <summary>
        /// System / Critical Background: Infobar Background
        /// </summary>
        public required Color SystemFillColorCriticalBackgroundBrush { get; init; } = Color.FromArgb(253, 231, 233);

        /// <summary>
        /// System / Critical: Badge
        /// </summary>
        public required Color SystemFillColorCriticalBrush { get; init; } = Color.FromArgb(196, 43, 28);

        /// <summary>
        /// System / Neutral Background: Infobar Background
        /// </summary>
        public required Color SystemFillColorNeutralBackgroundBrush { get; init; } = Color.FromArgb(237, 237, 237);

        /// <summary>
        /// System / Neutral: Badge
        /// </summary>
        public required Color SystemFillColorNeutralBrush { get; init; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// System / Solid Attention Background: System / Solid Attention Background
        /// </summary>
        public required Color SystemFillColorSolidAttentionBackgroundBrush
        {
            get;
            init;
        } = Color.FromArgb(247, 247, 247);

        /// <summary>
        /// System / Solid Neutral Background: Neutral badges over content
        /// </summary>
        public required Color SystemFillColorSolidNeutralBackgroundBrush { get; init; } = Color.FromArgb(243, 243, 243);

        /// <summary>
        /// System / Solid Neutral: Neutral badges over content
        /// </summary>
        public required Color SystemFillColorSolidNeutralBrush { get; init; } = Color.FromArgb(138, 138, 138);

        /// <summary>
        /// System / Success Background: Infobar Background
        /// </summary>
        public required Color SystemFillColorSuccessBackgroundBrush { get; init; } = Color.FromArgb(223, 246, 221);

        /// <summary>
        /// System / Success: Badge
        /// </summary>
        public required Color SystemFillColorSuccessBrush { get; init; } = Color.FromArgb(15, 123, 15);

        /// <summary>
        /// Text Control / Border: Rest
        /// </summary>
        public required Color TextControlElevationBorderBrush { get; init; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Text Control / Border Focused: Active text fields
        /// </summary>
        public required Color TextControlElevationBorderFocusedBrush { get; init; } = Color.FromArgb(0, 90, 158);

        /// <summary>
        /// Text / Disabled: Disabled only (not accessible)
        /// </summary>
        public required Color TextFillColorDisabledBrush { get; init; } = Color.FromArgb(155, 155, 155);

        /// <summary>
        /// Text / Primary: Rest or Hover
        /// </summary>
        public required Color TextFillColorPrimaryBrush { get; init; } = Color.FromArgb(26, 26, 26);

        /// <summary>
        /// Text / Secondary: Rest or Hover
        /// </summary>

        public required Color TextFillColorSecondaryBrush { get; init; } = Color.FromArgb(92, 92, 92);

        /// <summary>
        /// Text / Tertiary: Pressed only (not accessible)
        /// </summary>
        public required Color TextFillColorTertiaryBrush { get; init; } = Color.FromArgb(134, 134, 134);

        /// <summary>
        /// Text on Accent / Disabled: Disabled only (not accessible)
        /// </summary>
        public required Color TextOnAccentFillColorDisabledBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Text on Accent / Primary: Rest or Hover
        /// </summary>
        public required Color TextOnAccentFillColorPrimaryBrush { get; init; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Text on Accent / Secondary: Pressed only (not accessible)
        /// </summary>
        public required Color TextOnAccentFillColorSecondaryBrush { get; init; } = Color.FromArgb(251, 251, 251);

        /// <summary>
        /// Text on Accent / Selected: Text For highlighted text in text entry experiences
        /// </summary>
        public required Color TextOnAccentFillColorSelectedTextBrush { get; init; } = Color.FromArgb(255, 255, 255);
    }
}
