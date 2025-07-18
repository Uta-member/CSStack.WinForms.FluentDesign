namespace CSStack.WinForms.FluentDesign
{
    public sealed record TypographyResource
    {
        public required Font BodyStrongTextBlockStyle { get; set; } = new Font("Segoe UI", 11, FontStyle.Bold);

        public required Font BodyTextBlockStyle { get; set; } = new Font("Segoe UI", 11, FontStyle.Regular);

        public required Font CaptionTextBlockStyle { get; set; } = new Font("Segoe UI", 9, FontStyle.Regular);

        public required Font DisplayTextBlockStyle { get; set; } = new Font("Segoe UI", 51, FontStyle.Bold);

        public required Font SubtitleTextBlockStyle { get; set; } = new Font("Segoe UI", 15, FontStyle.Bold);

        public required Font TitleLargeTextBlockStyle { get; set; } = new Font("Segoe UI", 30, FontStyle.Bold);

        public required Font TitleTextBlockStyle { get; set; } = new Font("Segoe UI", 21, FontStyle.Bold);
    }
}
