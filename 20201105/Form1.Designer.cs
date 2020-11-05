namespace _20201105
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.tbPlate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(61, 175);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(200, 200);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(353, 175);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(200, 200);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(61, 407);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(200, 200);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(353, 407);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(200, 200);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("新細明體", 36F);
            this.btn.Location = new System.Drawing.Point(353, 66);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(200, 96);
            this.btn.TabIndex = 4;
            this.btn.Text = "查詢";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbPlate
            // 
            this.tbPlate.Location = new System.Drawing.Point(83, 76);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(100, 22);
            this.tbPlate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.tbPlate);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tbPlate;
    }
}

