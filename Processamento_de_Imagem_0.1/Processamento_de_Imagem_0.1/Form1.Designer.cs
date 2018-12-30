namespace Processamento_de_Imagem_0._1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btt_Start = new System.Windows.Forms.Button();
            this.bttStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frameRateLB = new System.Windows.Forms.Label();
            this._frameRate = new System.Windows.Forms.Label();
            this.larguraLB = new System.Windows.Forms.Label();
            this.alturaLB = new System.Windows.Forms.Label();
            this._largura = new System.Windows.Forms.Label();
            this._altura = new System.Windows.Forms.Label();
            this.btt_Refresh = new System.Windows.Forms.Button();
            this.comboBox_Cam = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btt_Start
            // 
            this.btt_Start.Location = new System.Drawing.Point(6, 71);
            this.btt_Start.Name = "btt_Start";
            this.btt_Start.Size = new System.Drawing.Size(75, 23);
            this.btt_Start.TabIndex = 0;
            this.btt_Start.Text = "Start";
            this.btt_Start.UseVisualStyleBackColor = true;
            this.btt_Start.Click += new System.EventHandler(this.btt_Start_Click);
            // 
            // bttStop
            // 
            this.bttStop.Location = new System.Drawing.Point(87, 71);
            this.bttStop.Name = "bttStop";
            this.bttStop.Size = new System.Drawing.Size(75, 23);
            this.bttStop.TabIndex = 1;
            this.bttStop.Text = "Stop";
            this.bttStop.UseVisualStyleBackColor = true;
            this.bttStop.Click += new System.EventHandler(this.bttStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frameRateLB);
            this.groupBox1.Controls.Add(this._frameRate);
            this.groupBox1.Controls.Add(this.larguraLB);
            this.groupBox1.Controls.Add(this.alturaLB);
            this.groupBox1.Controls.Add(this._largura);
            this.groupBox1.Controls.Add(this._altura);
            this.groupBox1.Controls.Add(this.btt_Refresh);
            this.groupBox1.Controls.Add(this.comboBox_Cam);
            this.groupBox1.Controls.Add(this.bttStop);
            this.groupBox1.Controls.Add(this.btt_Start);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONFIGURAÇÃO";
            // 
            // frameRateLB
            // 
            this.frameRateLB.AutoSize = true;
            this.frameRateLB.Location = new System.Drawing.Point(201, 113);
            this.frameRateLB.Name = "frameRateLB";
            this.frameRateLB.Size = new System.Drawing.Size(13, 13);
            this.frameRateLB.TabIndex = 9;
            this.frameRateLB.Text = "0";
            // 
            // _frameRate
            // 
            this._frameRate.AutoSize = true;
            this._frameRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._frameRate.Location = new System.Drawing.Point(115, 111);
            this._frameRate.Name = "_frameRate";
            this._frameRate.Size = new System.Drawing.Size(79, 16);
            this._frameRate.TabIndex = 8;
            this._frameRate.Text = "FrameRate:";
            // 
            // larguraLB
            // 
            this.larguraLB.AutoSize = true;
            this.larguraLB.Location = new System.Drawing.Point(69, 130);
            this.larguraLB.Name = "larguraLB";
            this.larguraLB.Size = new System.Drawing.Size(13, 13);
            this.larguraLB.TabIndex = 7;
            this.larguraLB.Text = "0";
            // 
            // alturaLB
            // 
            this.alturaLB.AutoSize = true;
            this.alturaLB.Location = new System.Drawing.Point(69, 113);
            this.alturaLB.Name = "alturaLB";
            this.alturaLB.Size = new System.Drawing.Size(13, 13);
            this.alturaLB.TabIndex = 6;
            this.alturaLB.Text = "0";
            // 
            // _largura
            // 
            this._largura.AutoSize = true;
            this._largura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._largura.Location = new System.Drawing.Point(6, 127);
            this._largura.Name = "_largura";
            this._largura.Size = new System.Drawing.Size(57, 16);
            this._largura.TabIndex = 5;
            this._largura.Text = "Largura:";
            // 
            // _altura
            // 
            this._altura.AutoSize = true;
            this._altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._altura.Location = new System.Drawing.Point(6, 111);
            this._altura.Name = "_altura";
            this._altura.Size = new System.Drawing.Size(48, 16);
            this._altura.TabIndex = 4;
            this._altura.Text = "Altura: ";
            // 
            // btt_Refresh
            // 
            this.btt_Refresh.Location = new System.Drawing.Point(168, 42);
            this.btt_Refresh.Name = "btt_Refresh";
            this.btt_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btt_Refresh.TabIndex = 2;
            this.btt_Refresh.Text = "Atualizar";
            this.btt_Refresh.UseVisualStyleBackColor = true;
            this.btt_Refresh.Click += new System.EventHandler(this.btt_Refresh_Click);
            // 
            // comboBox_Cam
            // 
            this.comboBox_Cam.CausesValidation = false;
            this.comboBox_Cam.FormattingEnabled = true;
            this.comboBox_Cam.Location = new System.Drawing.Point(6, 44);
            this.comboBox_Cam.Name = "comboBox_Cam";
            this.comboBox_Cam.Size = new System.Drawing.Size(156, 21);
            this.comboBox_Cam.TabIndex = 0;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(269, 27);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(520, 410);
            this.videoSourcePlayer1.TabIndex = 3;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoSourcePlayer1_NewFrame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Processamento de Imagem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_Start;
        private System.Windows.Forms.Button bttStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_Refresh;
        private System.Windows.Forms.ComboBox comboBox_Cam;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label larguraLB;
        private System.Windows.Forms.Label alturaLB;
        private System.Windows.Forms.Label _largura;
        private System.Windows.Forms.Label _altura;
        private System.Windows.Forms.Label frameRateLB;
        private System.Windows.Forms.Label _frameRate;
    }
}

