namespace CSStack.WinForms.FluentDesign.Provider
{
    public partial class FluentFormBase : Control, IFluentComponent
    {
        public FluentFormBase()
        {
            InitializeComponent();
        }

        private void ApplyDesignToChildren(Control.ControlCollection controls, ThemeResource themeResource)
        {
            foreach(Control control in controls)
            {
                // 現在のコントロールがIFluentComponentを実装している場合、デザインを適用
                if(control is IFluentComponent fluentComponent)
                {
                    // ここでの ApplyDesign 呼び出しは、そのFluentComponent自身にテーマを適用します。
                    // その FluentComponent がさらに子を持つ場合は、その内部で再帰処理を行うか、
                    // このメソッドの次の行で処理することになります。
                    fluentComponent.ApplyDesign(themeResource);
                }
                else
                {
                    // IFluentComponentを実装していないコントロールでも、子を持つ可能性があるため、
                    // 無条件でその子コレクションを走査します。
                    // ただし、この分岐では ApplyDesign は直接呼び出されません。
                    // そのコントロールのデフォルトの見た目がThemeResourceのブラシで変更されることはありません。
                }

                // 現在のコントロールが子コントロールを持っている場合、その子コントロールにも再帰的に適用
                if(control.HasChildren)
                {
                    ApplyDesignToChildren(control.Controls, themeResource);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void ApplyDesign(ThemeResource themeResource)
        {
            // まず自分自身にデザインを適用
            Font = themeResource.Typography.BodyTextBlockStyle;
            ForeColor = themeResource.Color.TextFillColorPrimaryBrush;
            BackColor = themeResource.Color.SolidBackgroundFillColorBaseBrush;

            // 子コントロールと孫コントロールに再帰的にデザインを適用
            ApplyDesignToChildren(this.Controls, themeResource);

            Invalidate(); // 全体の再描画を要求
        }
    }
}
