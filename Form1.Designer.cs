
namespace Zoom_XY
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
            this.components = new System.ComponentModel.Container();
            this._zoomxylabel = new System.Windows.Forms.Label();
            this._StartBtn = new System.Windows.Forms.Button();
            this._GetZoomXY = new System.Windows.Forms.Timer(this.components);
            this._GetZoomJoinXY = new System.Windows.Forms.Timer(this.components);
            this._zoomjoinlabel = new System.Windows.Forms.Label();
            this._CheckZoomRunner = new System.Windows.Forms.Timer(this.components);
            this._zoomaudiolabel = new System.Windows.Forms.Label();
            this._GetZoomAudioXY = new System.Windows.Forms.Timer(this.components);
            this._zoomcontentviewXY = new System.Windows.Forms.Label();
            this._GetZoomContentViewXY = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this._GetZoomLeaveXY = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _zoomxylabel
            // 
            this._zoomxylabel.AutoSize = true;
            this._zoomxylabel.Font = new System.Drawing.Font("Reem Kufi", 21.75F);
            this._zoomxylabel.Location = new System.Drawing.Point(12, 9);
            this._zoomxylabel.Name = "_zoomxylabel";
            this._zoomxylabel.Size = new System.Drawing.Size(158, 56);
            this._zoomxylabel.TabIndex = 0;
            this._zoomxylabel.Text = "Zoom XY : ";
            // 
            // _StartBtn
            // 
            this._StartBtn.Font = new System.Drawing.Font("Reem Kufi", 21.75F);
            this._StartBtn.Location = new System.Drawing.Point(22, 327);
            this._StartBtn.Name = "_StartBtn";
            this._StartBtn.Size = new System.Drawing.Size(450, 77);
            this._StartBtn.TabIndex = 1;
            this._StartBtn.Text = "Start";
            this._StartBtn.UseVisualStyleBackColor = true;
            this._StartBtn.Click += new System.EventHandler(this._StartBtn_Click);
            // 
            // _GetZoomXY
            // 
            this._GetZoomXY.Tick += new System.EventHandler(this._GetZoomXY_Tick);
            // 
            // _GetZoomJoinXY
            // 
            this._GetZoomJoinXY.Tick += new System.EventHandler(this.GetZoomJoinXY_Tick);
            // 
            // _zoomjoinlabel
            // 
            this._zoomjoinlabel.AutoSize = true;
            this._zoomjoinlabel.Font = new System.Drawing.Font("Reem Kufi", 21.75F);
            this._zoomjoinlabel.Location = new System.Drawing.Point(12, 65);
            this._zoomjoinlabel.Name = "_zoomjoinlabel";
            this._zoomjoinlabel.Size = new System.Drawing.Size(213, 56);
            this._zoomjoinlabel.TabIndex = 2;
            this._zoomjoinlabel.Text = "Zoom Join XY : ";
            // 
            // _CheckZoomRunner
            // 
            this._CheckZoomRunner.Tick += new System.EventHandler(this._CheckZoomRunner_Tick);
            // 
            // _zoomaudiolabel
            // 
            this._zoomaudiolabel.AutoSize = true;
            this._zoomaudiolabel.Font = new System.Drawing.Font("Reem Kufi", 21.75F);
            this._zoomaudiolabel.Location = new System.Drawing.Point(12, 121);
            this._zoomaudiolabel.Name = "_zoomaudiolabel";
            this._zoomaudiolabel.Size = new System.Drawing.Size(239, 56);
            this._zoomaudiolabel.TabIndex = 3;
            this._zoomaudiolabel.Text = "Zoom Audio XY : ";
            // 
            // _GetZoomAudioXY
            // 
            this._GetZoomAudioXY.Tick += new System.EventHandler(this._GetZoomAudioXY_Tick);
            // 
            // _zoomcontentviewXY
            // 
            this._zoomcontentviewXY.AutoSize = true;
            this._zoomcontentviewXY.Font = new System.Drawing.Font("Reem Kufi", 21.75F);
            this._zoomcontentviewXY.Location = new System.Drawing.Point(12, 177);
            this._zoomcontentviewXY.Name = "_zoomcontentviewXY";
            this._zoomcontentviewXY.Size = new System.Drawing.Size(369, 56);
            this._zoomcontentviewXY.TabIndex = 4;
            this._zoomcontentviewXY.Text = "Zoom ZPContentView XY : ";
            // 
            // _GetZoomContentViewXY
            // 
            this._GetZoomContentViewXY.Tick += new System.EventHandler(this._GetZoomContentViewXY_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 21.75F);
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zoom Leave XY : ";
            // 
            // _GetZoomLeaveXY
            // 
            this._GetZoomLeaveXY.Tick += new System.EventHandler(this.GetZoomLeaveXY_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._zoomcontentviewXY);
            this.Controls.Add(this._zoomaudiolabel);
            this.Controls.Add(this._zoomjoinlabel);
            this.Controls.Add(this._StartBtn);
            this.Controls.Add(this._zoomxylabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _zoomxylabel;
        private System.Windows.Forms.Button _StartBtn;
        private System.Windows.Forms.Timer _GetZoomXY;
        private System.Windows.Forms.Timer _GetZoomJoinXY;
        private System.Windows.Forms.Label _zoomjoinlabel;
        private System.Windows.Forms.Timer _CheckZoomRunner;
        private System.Windows.Forms.Label _zoomaudiolabel;
        private System.Windows.Forms.Timer _GetZoomAudioXY;
        private System.Windows.Forms.Label _zoomcontentviewXY;
        private System.Windows.Forms.Timer _GetZoomContentViewXY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer _GetZoomLeaveXY;
    }
}

