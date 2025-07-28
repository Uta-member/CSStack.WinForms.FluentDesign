namespace CSStack.WinForms.FluentDesign
{
    public sealed record ThemeResource
    {
        public ColorResource Color { get; set; } = new ColorResource();

        public TypographyResource Typography { get; set; } = new TypographyResource();
    }
}
