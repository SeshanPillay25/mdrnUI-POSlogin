namespace POS
{
    partial class Other
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuProgressBar3 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(80, 39);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(208, 192);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.SpringGreen;
            this.bunifuCards2.Controls.Add(this.bunifuProgressBar3);
            this.bunifuCards2.Controls.Add(this.bunifuProgressBar2);
            this.bunifuCards2.Controls.Add(this.bunifuProgressBar1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(77, 254);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(536, 165);
            this.bunifuCards2.TabIndex = 1;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Red;
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(405, 39);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(208, 192);
            this.bunifuCards3.TabIndex = 1;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 0;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(46, 24);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(410, 10);
            this.bunifuProgressBar1.TabIndex = 1;
            this.bunifuProgressBar1.Value = 68;
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar2.BorderRadius = 0;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(46, 65);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.Crimson;
            this.bunifuProgressBar2.Size = new System.Drawing.Size(410, 10);
            this.bunifuProgressBar2.TabIndex = 2;
            this.bunifuProgressBar2.Value = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuProgressBar3
            // 
            this.bunifuProgressBar3.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar3.BorderRadius = 0;
            this.bunifuProgressBar3.Location = new System.Drawing.Point(46, 102);
            this.bunifuProgressBar3.MaximumValue = 100;
            this.bunifuProgressBar3.Name = "bunifuProgressBar3";
            this.bunifuProgressBar3.ProgressColor = System.Drawing.Color.SteelBlue;
            this.bunifuProgressBar3.Size = new System.Drawing.Size(410, 10);
            this.bunifuProgressBar3.TabIndex = 3;
            this.bunifuProgressBar3.Value = 40;
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Other";
            this.Size = new System.Drawing.Size(716, 433);
            this.bunifuCards2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar3;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private System.Windows.Forms.Timer timer1;
    }
}
