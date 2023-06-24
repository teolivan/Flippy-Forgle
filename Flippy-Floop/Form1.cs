namespace Flippy_Floop
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            forgle.Top += gravity;
            pipebottom.Left -= pipeSpeed;
            pipetop.Left -= pipeSpeed;
            scoretxt.Text = "Score: " + score;

            if (pipebottom.Left < -120) 
            {
                pipebottom.Left = 800;
                score++;
            }
            if (pipetop.Left < -120)
            {
                pipetop.Left = 900;
                score++;
            }

            if(forgle.Bounds.IntersectsWith(pipebottom.Bounds) || forgle.Bounds.IntersectsWith(pipetop.Bounds) || forgle.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            scoretxt.Text += "  Game over!!";
        }
    }
}