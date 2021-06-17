namespace Histogramms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonMircophone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonMp3 = new System.Windows.Forms.Button();
            this.buttonWav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonMircophone
            // 
            this.ButtonMircophone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMircophone.Location = new System.Drawing.Point(157, 75);
            this.ButtonMircophone.Name = "ButtonMircophone";
            this.ButtonMircophone.Size = new System.Drawing.Size(152, 51);
            this.ButtonMircophone.TabIndex = 0;
            this.ButtonMircophone.Text = "Микрофон";
            this.ButtonMircophone.UseVisualStyleBackColor = true;
            this.ButtonMircophone.Click += new System.EventHandler(this.ButtonMicrophoneClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбирите источник данных";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.Location = new System.Drawing.Point(157, 146);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(152, 89);
            this.buttonRandom.TabIndex = 2;
            this.buttonRandom.Text = "Массив случайных чисел";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonMp3
            // 
            this.buttonMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMp3.Location = new System.Drawing.Point(157, 349);
            this.buttonMp3.Name = "buttonMp3";
            this.buttonMp3.Size = new System.Drawing.Size(152, 64);
            this.buttonMp3.TabIndex = 3;
            this.buttonMp3.Text = "Аудио фйл (mp3)";
            this.buttonMp3.UseVisualStyleBackColor = true;
            this.buttonMp3.Click += new System.EventHandler(this.buttonMp3_Click);
            // 
            // buttonWav
            // 
            this.buttonWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWav.Location = new System.Drawing.Point(157, 268);
            this.buttonWav.Name = "buttonWav";
            this.buttonWav.Size = new System.Drawing.Size(152, 64);
            this.buttonWav.TabIndex = 4;
            this.buttonWav.Text = "Аудио фйл (wav)";
            this.buttonWav.UseVisualStyleBackColor = true;
            this.buttonWav.Click += new System.EventHandler(this.buttonWav_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 434);
            this.Controls.Add(this.buttonWav);
            this.Controls.Add(this.buttonMp3);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonMircophone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMircophone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonMp3;
        private System.Windows.Forms.Button buttonWav;
    }
}

