using System.Drawing.Drawing2D;

namespace CSStack.WinForms.FluentDesign.Components
{
    public partial class FluentButton : Button, IDesignableControl
    {
        const int BORDER_RADIUS = 4;
        const int BORDER_WIDTH = 1;
        const int ELEVATION_OFFSET = 1;

        private Color _accentBackColor;
        private Color _accentBorderColor;
        private Color _accentDisabledBackColor;
        private Color _accentDisabledBorderColor;
        private Color _accentDisabledForeColor;
        private Color _accentElevationColor;
        private Color _accentForeColor;
        private Color _accentHoveredBackColor;
        private Color _accentHoveredForeColor;
        private Color _accentPressedBackColor;
        private Color _accentPressedForeColor;
        private FluentButtonType _buttonType = FluentButtonType.Normal;
        private bool _isHovered;
        private bool _isPressed;
        private Color _normalBackColor;
        private Color _normalBorderColor;
        private Color _normalDisabledBackColor;
        private Color _normalDisabledForeColor;
        private Color _normalElevationColor;
        private Color _normalForeColor;
        private Color _normalHoveredBackColor;
        private Color _normalHoveredForeColor;
        private Color _normalPressedBackColor;
        private Color _normalPressedForeColor;

        public FluentButton()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.DoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor,
                true);
            BackColor = Color.Transparent;
            Cursor = Cursors.Hand;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(75, 32);
            UpdateStyles();
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if(radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int diameter = radius * 2;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            // 左上
            path.AddArc(arcRect, 180, 90);

            // 右上
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if(mevent.Button == MouseButtons.Left)
            {
                _isPressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            _isPressed = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if(mevent.Button == MouseButtons.Left)
            {
                _isPressed = false;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Color backColor;
            Color foreColor;
            Color elevationColor;
            Color borderColor;

            bool hasElevation = !_isPressed && Enabled;

            if(ButtonType == FluentButtonType.Accent)
            {
                elevationColor = AccentElevationColor;

                if(Enabled)
                {
                    borderColor = AccentBorderColor;
                    if(_isPressed)
                    {
                        backColor = AccentPressedBackColor;
                        foreColor = AccentPressedForeColor;
                    }
                    else if(_isHovered)
                    {
                        backColor = AccentHoveredBackColor;
                        foreColor = AccentHoveredForeColor;
                    }
                    else
                    {
                        backColor = AccentBackColor;
                        foreColor = AccentForeColor;
                    }
                }
                else
                {
                    borderColor = AccentDisabledBorderColor;
                    backColor = AccentDisabledBackColor;
                    foreColor = AccentDisabledForeColor;
                }
            }
            else
            {
                elevationColor = NormalElevationColor;
                borderColor = NormalBorderColor;

                if(Enabled)
                {
                    if(_isPressed)
                    {
                        backColor = NormalPressedBackColor;
                        foreColor = NormalPressedForeColor;
                    }
                    else if(_isHovered)
                    {
                        backColor = NormalHoveredBackColor;
                        foreColor = NormalHoveredForeColor;
                    }
                    else
                    {
                        backColor = NormalBackColor;
                        foreColor = NormalForeColor;
                    }
                }
                else
                {
                    backColor = NormalDisabledBackColor;
                    foreColor = NormalDisabledForeColor;
                }
            }

            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle buttonRectangle = ClientRectangle;

            var elevationRect = buttonRectangle;
            using(var path = CreateRoundedRectanglePath(elevationRect, BORDER_RADIUS))
            {
                using(var brush = new SolidBrush(elevationColor))
                {
                    g.FillPath(brush, path);
                }
            }

            Rectangle bodyRect = new Rectangle()
            {
                Height = buttonRectangle.Height - BORDER_WIDTH - (hasElevation ? ELEVATION_OFFSET : 0),
                Width = buttonRectangle.Width - BORDER_WIDTH,
                X = buttonRectangle.X,
                Y = buttonRectangle.Y,
            };

            using(var path = CreateRoundedRectanglePath(bodyRect, BORDER_RADIUS))
            {
                using(var brush = new SolidBrush(backColor))
                {
                    using(var pen = new Pen(borderColor, BORDER_WIDTH))
                    {
                        g.FillPath(brush, path);
                        g.DrawPath(pen, path);
                    }
                }
            }

            TextRenderer.DrawText(
                g,
                Text,
                Font,
                bodyRect,
                foreColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using(GraphicsPath path = CreateRoundedRectanglePath(this.ClientRectangle, BORDER_RADIUS))
            {
                this.Region = new Region(path); // ボタンのヒット領域も角丸に
            }
        }

        public void ApplyDesign(ThemeResource themeResource)
        {
            // DefaultColors
            NormalBackColor = themeResource.Color.ControlFillColorDefaultBrush;
            NormalHoveredBackColor = themeResource.Color.ControlFillColorSecondaryBrush;
            NormalPressedBackColor = themeResource.Color.ControlFillColorTertiaryBrush;
            NormalDisabledBackColor = themeResource.Color.ControlFillColorDisabledBrush;
            NormalForeColor = themeResource.Color.TextFillColorPrimaryBrush;
            NormalHoveredForeColor = themeResource.Color.TextFillColorSecondaryBrush;
            NormalPressedForeColor = themeResource.Color.TextFillColorTertiaryBrush;
            NormalDisabledForeColor = themeResource.Color.TextFillColorDisabledBrush;
            NormalBorderColor = themeResource.Color.ControlStrokeColorDefaultBrush;
            NormalElevationColor = themeResource.Color.ControlStrokeColorSecondaryBrush;

            // AccentColors
            AccentBackColor = themeResource.Color.AccentFillColorDefaultBrush;
            AccentHoveredBackColor = themeResource.Color.AccentFillColorSecondaryBrush;
            AccentPressedBackColor = themeResource.Color.AccentFillColorTertiaryBrush;
            AccentDisabledBackColor = themeResource.Color.AccentFillColorDisabledBrush;
            AccentForeColor = themeResource.Color.TextOnAccentFillColorPrimaryBrush;
            AccentHoveredForeColor = themeResource.Color.TextOnAccentFillColorPrimaryBrush;
            AccentPressedForeColor = themeResource.Color.TextOnAccentFillColorSecondaryBrush;
            AccentDisabledForeColor = themeResource.Color.TextOnAccentFillColorDisabledBrush;
            AccentBorderColor = themeResource.Color.ControlStrokeColorOnAccentDefaultBrush;
            AccentDisabledBorderColor = themeResource.Color.ControlStrokeColorOnAccentDisabledBrush;
            AccentElevationColor = themeResource.Color.ControlStrokeColorOnAccentSecondaryBrush;

            // Font
            Font = themeResource.Typography.BodyTextBlockStyle;

            Invalidate();
        }

        public Color AccentBackColor
        {
            get
            {
                return _accentBackColor;
            }
            set
            {
                _accentBackColor = value;
                Invalidate();
            }
        }

        public Color AccentBorderColor
        {
            get
            {
                return _accentBorderColor;
            }
            set
            {
                _accentBorderColor = value;
                Invalidate();
            }
        }

        public Color AccentDisabledBackColor
        {
            get
            {
                return _accentDisabledBackColor;
            }
            set
            {
                _accentDisabledBackColor = value;
                Invalidate();
            }
        }

        public Color AccentDisabledBorderColor
        {
            get
            {
                return _accentDisabledBorderColor;
            }
            set
            {
                _accentDisabledBorderColor = value;
                Invalidate();
            }
        }

        public Color AccentDisabledForeColor
        {
            get
            {
                return _accentDisabledForeColor;
            }
            set
            {
                _accentDisabledForeColor = value;
                Invalidate();
            }
        }

        public Color AccentElevationColor
        {
            get => _accentElevationColor;
            set
            {
                _accentElevationColor = value;
                Invalidate();
            }
        }

        public Color AccentForeColor
        {
            get
            {
                return _accentForeColor;
            }
            set
            {
                _accentForeColor = value;
                Invalidate();
            }
        }

        public Color AccentHoveredBackColor
        {
            get
            {
                return _accentHoveredBackColor;
            }
            set
            {
                _accentHoveredBackColor = value;
                Invalidate();
            }
        }

        public Color AccentHoveredForeColor
        {
            get
            {
                return _accentHoveredForeColor;
            }
            set
            {
                _accentHoveredForeColor = value;
                Invalidate();
            }
        }

        public Color AccentPressedBackColor
        {
            get
            {
                return _accentPressedBackColor;
            }
            set
            {
                _accentPressedBackColor = value;
                Invalidate();
            }
        }

        public Color AccentPressedForeColor
        {
            get
            {
                return _accentPressedForeColor;
            }
            set
            {
                _accentPressedForeColor = value;
                Invalidate();
            }
        }

        public FluentButtonType ButtonType
        {
            get => _buttonType;
            set
            {
                _buttonType = value;
                Invalidate();
            }
        }

        public Color NormalBackColor
        {
            get
            {
                return _normalBackColor;
            }
            set
            {
                _normalBackColor = value;
                Invalidate();
            }
        }

        public Color NormalBorderColor
        {
            get => _normalBorderColor;
            set
            {
                _normalBorderColor = value;
                Invalidate();
            }
        }

        public Color NormalDisabledBackColor
        {
            get => _normalDisabledBackColor;
            set
            {
                _normalDisabledBackColor = value;
                Invalidate();
            }
        }

        public Color NormalDisabledForeColor
        {
            get => _normalDisabledForeColor;
            set
            {
                _normalDisabledForeColor = value;
                Invalidate();
            }
        }

        public Color NormalElevationColor
        {
            get => _normalElevationColor;
            set
            {
                _normalElevationColor = value;
                Invalidate();
            }
        }

        public Color NormalForeColor
        {
            get
            {
                return _normalForeColor;
            }
            set
            {
                _normalForeColor = value;
                Invalidate();
            }
        }

        public Color NormalHoveredBackColor
        {
            get => _normalHoveredBackColor;
            set
            {
                _normalHoveredBackColor = value;
                Invalidate();
            }
        }

        public Color NormalHoveredForeColor
        {
            get => _normalHoveredForeColor;
            set
            {
                _normalHoveredForeColor = value;
                Invalidate();
            }
        }

        public Color NormalPressedBackColor
        {
            get => _normalPressedBackColor;
            set
            {
                _normalPressedBackColor = value;
                Invalidate();
            }
        }

        public Color NormalPressedForeColor
        {
            get => _normalPressedForeColor;
            set
            {
                _normalPressedForeColor = value;
                Invalidate();
            }
        }

        public enum FluentButtonType
        {
            Normal = 0,
            Accent = 1,
        }
    }
}
