using System;
using System.Collections.Generic;
using System.Windows.Forms;
    
namespace laba4_Csharp
{
    public partial class Form1 : Form
    {
        private Queue<MagicalArtifact> artifactQueue = new Queue<MagicalArtifact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            artifactQueue.Clear();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        artifactQueue.Enqueue(MagicSword.Generate());
                        break;
                    case 1:
                        artifactQueue.Enqueue(MagicAmulet.Generate());
                        break;
                    case 2:
                        artifactQueue.Enqueue(MagicScroll.Generate());
                        break;
                }
            }
            UpdateQueueDisplay();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (artifactQueue.Count > 0)
            {
                var artifact = artifactQueue.Dequeue();
                txtOut.Text = artifact.GetInfo();
            }
            else
            {
                txtOut.Text = "Пусто Q_Q";
            }
            UpdateQueueDisplay();
        }

        private void UpdateQueueDisplay()
        {
            txtInfo.Text = "Очередь артефактов:\n";
            foreach (var artifact in artifactQueue)
            {
                txtInfo.Text += artifact.GetInfo() + "\n";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
