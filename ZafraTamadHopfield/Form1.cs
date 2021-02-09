using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HopfieldNeuralNetwork;

namespace ZafraTamadHopfield
{
    public partial class Form1 : Form
    {
        private NeuralNetwork NN;
        private bool selectedAPattern = false;
        private int imageSize = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void createNNbtn_Click(object sender, EventArgs e)
        {
            NN = new NeuralNetwork(100);
            patternspanel.Controls.Clear();
            NN.EnergyChanged += new EnergyChangedHandler(NN_EnergyChanged);
            Random rng = new Random();
            int r = 0;
            Bitmap b = new Bitmap(imageSize, imageSize);
            for (int i = 0; i < imageSize; i++)
                for (int j = 0; j < imageSize; j++)
                {
                    r = rng.Next(2);
                    if (r == 0)
                        b.SetPixel(i, j, Color.Black);
                    else if (r == 1) 
                        b.SetPixel(i, j,Color.White);
                }
            nnState.MagnificationCoefficient = 27;
            nnState.ImageToMagnify = b;
            nnState.Visible = true;
            nnState.Invalidate();
            addPatternbtn.Enabled = true;
        }

        private void NN_EnergyChanged(object sender, EnergyEventArgs e)
        {
            int i = (int)e.NeuronIndex / imageSize;
            int j = e.NeuronIndex % imageSize;
            if (nnState.pixels[i, j] == Color.White.ToArgb()) nnState.pixels[i, j] = Color.Black.ToArgb();
            else if (nnState.pixels[i, j] == Color.Black.ToArgb()) nnState.pixels[i, j] = Color.White.ToArgb();
            nnState.Invalidate();
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);
        }

        private void addPatternbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap b = new Bitmap(openFileDialog1.FileName);
            int p = 0;
            int divider = Math.Abs((int)(Color.Black.ToArgb() / 2));
            List<Neuron> neuralnet = new List<Neuron>(imageSize*imageSize);
            for(int i = 0; i < imageSize; i++)
                for(int j = 0; j < imageSize; j++)
                {
                    Neuron n = new Neuron();
                    p = Math.Abs(b.GetPixel(i, j).ToArgb());
                    if(p < divider)
                    {
                        b.SetPixel(i, j, Color.White);
                        n.State = NeuronStates.AlongField;
                    }
                    else
                    {
                        b.SetPixel(i, j, Color.Black);
                        n.State = NeuronStates.AgainstField;
                    }
                    neuralnet.Add(n);
                }
            NN.AddPattern(neuralnet);
            ImageMagnifier.ImageMagnifier im = new ImageMagnifier.ImageMagnifier();
            im.MagnificationCoefficient = 6;
            im.ImageToMagnify = b;
            im.Location = new System.Drawing.Point(13, ((NN.M - 1) * (imageSize + 2) * im.MagnificationCoefficient));
            im.Size = new System.Drawing.Size(10 * im.MagnificationCoefficient, imageSize * im.MagnificationCoefficient);
            im.TabIndex = 0;
            im.Click += new EventHandler(im_Click);
            patternspanel.Controls.Add(im);
            runbtn.Enabled = true;
        }
        void im_Click(object sender, EventArgs e)
        {
            ImageMagnifier.ImageMagnifier im = (ImageMagnifier.ImageMagnifier)sender;
            this.nnState.ImageToMagnify = im.ImageToMagnify;

            Form2 form2 = new Form2();
            form2.ShowDialog();

            Random rng = new Random();
            int j = 0 , k = 0;

            for(int i = 0; i < form2.scrambleLevel; i++)
            {
                j = rng.Next(imageSize);
                k = rng.Next(imageSize);
                if (nnState.pixels[j, k] == Color.Black.ToArgb())
                    nnState.pixels[j, k] = Color.White.ToArgb();
                else if (nnState.pixels[j, k] == Color.White.ToArgb())
                    nnState.pixels[j, k] = Color.Black.ToArgb();
            }
            selectedAPattern = true;
            nnState.Invalidate();
        }

        private void runbtn_Click(object sender, EventArgs e)
        {
            if (!selectedAPattern)
            {
                MessageBox.Show("Please select a pattern!");
            }
            else
            {
                List<Neuron> initialState = new List<Neuron>(NN.N);
                for (int i = 0; i < imageSize; i++)
                    for (int j = 0; j < imageSize; j++)
                    {
                        Neuron neuron = new Neuron();
                        if (nnState.pixels[i, j] == Color.Black.ToArgb()) neuron.State = NeuronStates.AgainstField;
                        else if (nnState.pixels[i, j] == Color.White.ToArgb()) neuron.State = NeuronStates.AlongField;
                        initialState.Add(neuron);
                    }
                NN.Run(initialState);
                selectedAPattern = false;
            }
        }
    }
}
