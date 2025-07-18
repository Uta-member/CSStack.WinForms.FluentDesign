namespace CSStack.WinForms.FluentDesign
{
    public sealed record ThemeResource
    {
        public required ColorResource Color { get; init; }

        public required TypographyResource Typography { get; init; }
    }
}
