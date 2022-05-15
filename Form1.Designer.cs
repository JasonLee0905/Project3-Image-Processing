namespace _0427app
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnload = new System.Windows.Forms.Button();
            this.btnload2 = new System.Windows.Forms.Button();
            this.btngray = new System.Windows.Forms.Button();
            this.btngray1 = new System.Windows.Forms.Button();
            this.btnlighter = new System.Windows.Forms.Button();
            this.btnMosaic = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnblur = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_0427app.Properties.Resources.p3_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(46, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(465, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 485);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnload.Location = new System.Drawing.Point(46, 553);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(353, 118);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "載入基本圖片";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnload2
            // 
            this.btnload2.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnload2.Location = new System.Drawing.Point(426, 661);
            this.btnload2.Name = "btnload2";
            this.btnload2.Size = new System.Drawing.Size(256, 118);
            this.btnload2.TabIndex = 3;
            this.btnload2.Text = "載入圖片";
            this.btnload2.UseVisualStyleBackColor = true;
            this.btnload2.Click += new System.EventHandler(this.btnload2_Click);
            // 
            // btngray
            // 
            this.btngray.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngray.Location = new System.Drawing.Point(688, 661);
            this.btngray.Name = "btngray";
            this.btngray.Size = new System.Drawing.Size(256, 118);
            this.btngray.TabIndex = 4;
            this.btngray.Text = "負片效果";
            this.btngray.UseVisualStyleBackColor = true;
            this.btngray.Click += new System.EventHandler(this.btngray_Click);
            // 
            // btngray1
            // 
            this.btngray1.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngray1.Location = new System.Drawing.Point(950, 661);
            this.btngray1.Name = "btngray1";
            this.btngray1.Size = new System.Drawing.Size(256, 118);
            this.btngray1.TabIndex = 5;
            this.btngray1.Text = "灰階轉換";
            this.btngray1.UseVisualStyleBackColor = true;
            this.btngray1.Click += new System.EventHandler(this.btngray1_Click);
            // 
            // btnlighter
            // 
            this.btnlighter.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnlighter.Location = new System.Drawing.Point(1212, 661);
            this.btnlighter.Name = "btnlighter";
            this.btnlighter.Size = new System.Drawing.Size(256, 118);
            this.btnlighter.TabIndex = 6;
            this.btnlighter.Text = "影像變亮";
            this.btnlighter.UseVisualStyleBackColor = true;
            this.btnlighter.Click += new System.EventHandler(this.btnlighter_Click);
            // 
            // btnMosaic
            // 
            this.btnMosaic.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMosaic.Location = new System.Drawing.Point(426, 785);
            this.btnMosaic.Name = "btnMosaic";
            this.btnMosaic.Size = new System.Drawing.Size(256, 118);
            this.btnMosaic.TabIndex = 7;
            this.btnMosaic.Text = "馬賽克";
            this.btnMosaic.UseVisualStyleBackColor = true;
            this.btnMosaic.Click += new System.EventHandler(this.btnMosaic_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(884, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(364, 485);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnblur
            // 
            this.btnblur.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnblur.Location = new System.Drawing.Point(688, 785);
            this.btnblur.Name = "btnblur";
            this.btnblur.Size = new System.Drawing.Size(256, 118);
            this.btnblur.TabIndex = 9;
            this.btnblur.Text = "模糊效果";
            this.btnblur.UseVisualStyleBackColor = true;
            this.btnblur.Click += new System.EventHandler(this.btnblur_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(950, 785);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(256, 118);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "上下顛倒";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnred_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(1212, 785);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(256, 118);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "黑白變色";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(816, 909);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 118);
            this.button1.TabIndex = 12;
            this.button1.Text = "浮雕";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 1086);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnblur);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnMosaic);
            this.Controls.Add(this.btnlighter);
            this.Controls.Add(this.btngray1);
            this.Controls.Add(this.btngray);
            this.Controls.Add(this.btnload2);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnload2;
        private System.Windows.Forms.Button btngray;
        private System.Windows.Forms.Button btngray1;
        private System.Windows.Forms.Button btnlighter;
        private System.Windows.Forms.Button btnMosaic;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnblur;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
    }
}

