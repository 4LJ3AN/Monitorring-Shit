using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Monitorring_Shit
{
    public partial class Monitoring : Form
    {

        private List<UserControl> slides;
        private int currentIndex = 0;
        private Timer slideTimer;
        private bool fadingOut = true;
        private Timer fadeTimer;
        private double fadeStep = 0.05; // Smaller = smoother

        private void InitializeSlideshow()
        {

            fadeTimer = new Timer();
            fadeTimer.Interval = 30; // speed of fade (lower = smoother)
            fadeTimer.Tick += FadeTimer_Tick;

            slides = new List<UserControl>()
    {
                new Badminton(),
                new Table_Tennis(),
                new Billiards_Tables(),
                new Scooter()
    };

            slideTimer = new Timer();
            slideTimer.Interval = 5000; // 5 seconds
            slideTimer.Tick += SlideTimer_Tick;
            slideTimer.Start();

            ShowSlide(0); // Show first slide

            currentIndex = 0;
        }

        private void ShowSlide(int index)
        {
            panelMain.Controls.Clear();

            var slide = slides[index];
            slide.Dock = DockStyle.Fill;

            panelMain.Controls.Add(slide);
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            slideTimer.Stop();
            fadingOut = true;
            fadeTimer.Start();
        }

        public Monitoring()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadingOut)
            {
                this.Opacity -= fadeStep;

                if (this.Opacity <= 0)
                {
                    this.Opacity = 0;
                    fadeTimer.Stop();

                    currentIndex++;
                    if (currentIndex >= slides.Count)
                        currentIndex = 0;

                    ShowSlide(currentIndex);

                    fadingOut = false;
                    fadeTimer.Start();
                }
            }
            else
            {
                this.Opacity += fadeStep;

                if (this.Opacity >= 1)
                {
                    this.Opacity = 1;
                    fadeTimer.Stop();
                    slideTimer.Start(); // ✅ resume slideshow timing
                }
            }
        }

        private void Monitoring_Load_1(object sender, EventArgs e)
        {
            this.Opacity = 1;
            InitializeSlideshow();
        }
    }

}
