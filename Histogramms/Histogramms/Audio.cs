using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Numerics;
using NAudio.Wave;

namespace Histogramms
{
    public partial class Audio : Form
    {
        private int RATE = 44100;
        private int BUFFERSIZE = 2048;
        private string fileName, ext;

        public BufferedWaveProvider bwp;
        public WaveOutEvent wo;
        WaveFileReader wavReader;
        Mp3FileReader mp3Reader;


        public Audio(string arg, string file)
        {
            InitializeComponent();
            fileName = file;
            ext = arg;
            if (arg == "microphone")
                StartListeningToMicrophone();
            else
                PlayFile();
            chart.ChartAreas[0].AxisX.Maximum = BUFFERSIZE;

            chart.ChartAreas[1].AxisX.Maximum = 255;
            chart.ChartAreas[1].AxisX.Minimum = 0;
            chart.ChartAreas[1].AxisY.Maximum = 130;

            chart.ChartAreas[2].AxisX.Maximum = BUFFERSIZE / 2;
            chart.ChartAreas[2].AxisX.Minimum = 0;
            chart.ChartAreas[2].AxisY.Maximum = 3;
            chart.ChartAreas[2].AxisY.Minimum = -3;

            chart.ChartAreas[3].AxisX.Maximum = RATE / 500;
            chart.ChartAreas[3].AxisX.Minimum = 0;
            chart.ChartAreas[3].AxisY.Maximum = 0.4;

            timer.Start();
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            PlotData();
            timer.Enabled = true;
        }

        void AudioDataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public void StartListeningToMicrophone(int audioDeviceNumber = 0)
        {
            WaveIn wi = new WaveIn();
            wi.DeviceNumber = audioDeviceNumber;
            wi.WaveFormat = new WaveFormat(RATE, 1);
            wi.BufferMilliseconds = (int)(BUFFERSIZE / (double)RATE * 1000.0);
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(AudioDataAvailable);

            bwp = new BufferedWaveProvider(wi.WaveFormat);
            bwp.BufferLength = BUFFERSIZE * 2;
            bwp.DiscardOnBufferOverflow = true;
            try
            {
                wi.StartRecording();
            }
            catch
            {
                string msg = "Не получилось начать запись с микрофона\n\n";
                msg += "Убедитесь что он подключен\n";
                msg += "Убедитесь что он установлен как устройство записи по умолчанию";
                MessageBox.Show(msg, "ERROR");
            }
        }

        private void PlayFile()
        {
            if (ext == "wav")
            {
                wo = new WaveOutEvent();
                wavReader = new WaveFileReader(fileName);
                wo.Init(wavReader);
                wo.Volume = 0.1f;
            }
            if (ext == "mp3")
            {
                wo = new WaveOutEvent();
                mp3Reader = new Mp3FileReader(fileName);
                wo.Init(mp3Reader);
                wo.Volume = 0.1f;
            }
        }

        private void PlotData()
        {
            if (fileName != "" && wo.PlaybackState == PlaybackState.Stopped)
                wo.Play();
            var audioBytes = new byte[BUFFERSIZE];
            if (ext == "microphone")
                bwp.Read(audioBytes, 0, BUFFERSIZE);
            if (ext == "wav")
                wavReader.Read(audioBytes, 0, BUFFERSIZE);
            if (ext == "mp3")
                mp3Reader.Read(audioBytes, 0, BUFFERSIZE);

            if (audioBytes.Length == 0)
                return;
            if (audioBytes[BUFFERSIZE - 2] == 0)
                return;

            int BYTES_PER_POINT = 2;
            int graphPointCount = audioBytes.Length / BYTES_PER_POINT;

            double[] pcm = new double[graphPointCount];
            double[] fft = new double[graphPointCount];
            double[] fftReal = new double[graphPointCount / 2];


            for (int i = 0; i < graphPointCount; i++)
            {
                Int16 val = BitConverter.ToInt16(audioBytes, i * 2);

                if (ext != "microphone")
                    pcm[i] = val / Math.Pow(2, 16) * 5.0;
                else
                    pcm[i] = val / Math.Pow(2, 16) * 200.0;

            }

            fft = FFT(pcm);

            double pcmPointSpacingMs = RATE / 1000;
            double fftMaxFreq = RATE / 2;
            double fftPointSpacingHz = fftMaxFreq / graphPointCount;
            

            Array.Copy(fft, fftReal, fftReal.Length);

            int[] audioBytesInt = new int[BUFFERSIZE];
            for (int i = 0; i < BUFFERSIZE; ++i)
                audioBytesInt[i] = audioBytes[i];

            HistogramDataProcessor processor = new HistogramDataProcessor();
            List<HistogramDataProcessor.Element> histogramData = processor.Process(audioBytesInt);
            histogramData.Reverse();

            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();
            chart.Series[3].Points.Clear();


            for (int i = 0; i < audioBytesInt.Length; ++i)
            {
                chart.Series[0].Points.AddXY(i, audioBytesInt[i]);
            }
            for (int i = 0; i < histogramData.Count; ++i)
            {
                chart.Series[1].Points.AddXY(histogramData[i].value, histogramData[histogramData.Count - i - 1].count);
            }
            for (int i = 0; i < pcm.Length; ++i)
            {
                chart.Series[2].Points.AddXY(i, pcm[i]);
            }
            for (int i = 0; i < fftReal.Length; ++i)
            {
                chart.Series[3].Points.AddXY(i, fftReal[i]);
            }
            chart.Update();
            Application.DoEvents();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();
            if (wo != null && wo.PlaybackState == PlaybackState.Playing)
            {
                wo.Stop();
            }
            Close();
        }

        public double[] FFT(double[] data)
        {
            double[] fft = new double[data.Length];
            Complex[] fftComplex = new Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
                fftComplex[i] = new System.Numerics.Complex(data[i], 0.0);
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
                fft[i] = fftComplex[i].Magnitude;
            return fft;
        }

    }
}
