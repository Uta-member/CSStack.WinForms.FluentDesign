namespace CSStack.WinForms.FluentDesign
{
    public sealed record TypographyResource
    {
        public  Font BodyStrongTextBlockStyle { get; set; } = new Font("Segoe UI", 11, FontStyle.Bold);

        public  Font BodyTextBlockStyle { get; set; } = new Font("Segoe UI", 11, FontStyle.Regular);

        public  Font CaptionTextBlockStyle { get; set; } = new Font("Segoe UI", 9, FontStyle.Regular);

        public  Font DisplayTextBlockStyle { get; set; } = new Font("Segoe UI", 51, FontStyle.Bold);

        public  Font SubtitleTextBlockStyle { get; set; } = new Font("Segoe UI", 15, FontStyle.Bold);

        public  Font TitleLargeTextBlockStyle { get; set; } = new Font("Segoe UI", 30, FontStyle.Bold);

        public  Font TitleTextBlockStyle { get; set; } = new Font("Segoe UI", 21, FontStyle.Bold);
    }
}
