namespace background_time
{
    public partial class Form1 : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public DesktopTimer desktopTimer;

        public Form1()
        {
            InitializeComponent();

            desktopTimer = new DesktopTimer(this);

            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;

            notifyIcon1.Icon = Properties.Resources.preferences_system_time_clock_22501;

            this.timeLabel.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.timeLabel.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.timeLabel.MouseUp += new MouseEventHandler(Form1_MouseUp);
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form1_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Restore the form's location and size from the saved settings
            this.Location = Properties.Settings.Default.WindowLocation;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Save the form's location and size to the settings
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.Save();
        }
    }
}