
namespace CSStack.WinForms.FluentDesign.Provider
{
    public partial class FluentFormBase : Form, IDesignableControl
    {
        public FluentFormBase()
        {
            InitializeComponent();
        }

        private void ApplyDesignToChildren(Control.ControlCollection controls, ThemeResource themeResource)
        {
            foreach(Control control in controls)
            {
                if(control is IDesignableControl fluentComponent)
                {
                    fluentComponent.ApplyDesign(themeResource);
                }
                else if(control is Panel panelComponent)
                {
                    panelComponent.BackColor = Color.Transparent;
                }
                else if(control is UserControl userControl)
                {
                    userControl.BackColor = Color.Transparent;
                }

                if(control.HasChildren)
                {
                    ApplyDesignToChildren(control.Controls, themeResource);
                }
            }
        }

        private void BaseThemedForm_ControlAdded(object? sender, ControlEventArgs e)
        {
            ApplyDesign(CurrentTheme);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ControlAdded += BaseThemedForm_ControlAdded;
            ApplyDesign(CurrentTheme);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void ApplyDesign(ThemeResource themeResource)
        {
            Font = themeResource.Typography.BodyTextBlockStyle;
            ForeColor = themeResource.Color.TextFillColorPrimaryBrush;
            BackColor = themeResource.Color.SolidBackgroundFillColorBaseBrush;

            ApplyDesignToChildren(Controls, themeResource);

            Invalidate();
        }

        public ThemeResource CurrentTheme { get; set; } = new ThemeResource();
    }
}
