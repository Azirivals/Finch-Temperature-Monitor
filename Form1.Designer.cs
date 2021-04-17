
namespace Finch_Temperature_Monitor___JTaber
{
    partial class frm_TempMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TempMon));
            this.frm_Title = new System.Windows.Forms.Label();
            this.lbl_CurrentTemp = new System.Windows.Forms.Label();
            this.txb_Temp = new System.Windows.Forms.TextBox();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_FinchConnect_Click = new System.Windows.Forms.Button();
            this.txb_thresh = new System.Windows.Forms.TextBox();
            this.lbl_EnterThresh = new System.Windows.Forms.Label();
            this.btn_ConfirmTemp = new System.Windows.Forms.Button();
            this.txb_threshFinal = new System.Windows.Forms.TextBox();
            this.lbl_finalThresh = new System.Windows.Forms.Label();
            this.btn_threshMon = new System.Windows.Forms.Button();
            this.tmr_mon = new System.Windows.Forms.Timer(this.components);
            this.txb_alarmTime = new System.Windows.Forms.TextBox();
            this.lbl_sysTime = new System.Windows.Forms.Label();
            this.lbl_step1 = new System.Windows.Forms.Label();
            this.lbl_step2 = new System.Windows.Forms.Label();
            this.lbl_step3 = new System.Windows.Forms.Label();
            this.lbl_step4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frm_Title
            // 
            this.frm_Title.AutoSize = true;
            this.frm_Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.frm_Title.Font = new System.Drawing.Font("SNES", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm_Title.ForeColor = System.Drawing.Color.Aqua;
            this.frm_Title.Location = new System.Drawing.Point(207, 27);
            this.frm_Title.Name = "frm_Title";
            this.frm_Title.Size = new System.Drawing.Size(186, 25);
            this.frm_Title.TabIndex = 0;
            this.frm_Title.Text = "Finch Temperature Monitor";
            // 
            // lbl_CurrentTemp
            // 
            this.lbl_CurrentTemp.AutoSize = true;
            this.lbl_CurrentTemp.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_CurrentTemp.Location = new System.Drawing.Point(52, 164);
            this.lbl_CurrentTemp.Name = "lbl_CurrentTemp";
            this.lbl_CurrentTemp.Size = new System.Drawing.Size(94, 20);
            this.lbl_CurrentTemp.TabIndex = 2;
            this.lbl_CurrentTemp.Text = "Current Temp C°:";
            // 
            // txb_Temp
            // 
            this.txb_Temp.Enabled = false;
            this.txb_Temp.Location = new System.Drawing.Point(153, 163);
            this.txb_Temp.Name = "txb_Temp";
            this.txb_Temp.ReadOnly = true;
            this.txb_Temp.Size = new System.Drawing.Size(37, 20);
            this.txb_Temp.TabIndex = 3;
            this.txb_Temp.TextChanged += new System.EventHandler(this.txb_Temp_TextChanged);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(56, 367);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(134, 33);
            this.btn_Quit.TabIndex = 4;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_FinchConnect_Click
            // 
            this.btn_FinchConnect_Click.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FinchConnect_Click.Location = new System.Drawing.Point(56, 112);
            this.btn_FinchConnect_Click.Name = "btn_FinchConnect_Click";
            this.btn_FinchConnect_Click.Size = new System.Drawing.Size(134, 33);
            this.btn_FinchConnect_Click.TabIndex = 5;
            this.btn_FinchConnect_Click.Text = "Connect to Finch";
            this.btn_FinchConnect_Click.UseVisualStyleBackColor = true;
            this.btn_FinchConnect_Click.Click += new System.EventHandler(this.frm_FinchConnect_Click_Click);
            // 
            // txb_thresh
            // 
            this.txb_thresh.Location = new System.Drawing.Point(504, 160);
            this.txb_thresh.Name = "txb_thresh";
            this.txb_thresh.Size = new System.Drawing.Size(37, 20);
            this.txb_thresh.TabIndex = 7;
            // 
            // lbl_EnterThresh
            // 
            this.lbl_EnterThresh.AutoSize = true;
            this.lbl_EnterThresh.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterThresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_EnterThresh.Location = new System.Drawing.Point(403, 161);
            this.lbl_EnterThresh.Name = "lbl_EnterThresh";
            this.lbl_EnterThresh.Size = new System.Drawing.Size(93, 20);
            this.lbl_EnterThresh.TabIndex = 6;
            this.lbl_EnterThresh.Text = "Enter Threshold:";
            // 
            // btn_ConfirmTemp
            // 
            this.btn_ConfirmTemp.Font = new System.Drawing.Font("SNES", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmTemp.Location = new System.Drawing.Point(407, 112);
            this.btn_ConfirmTemp.Name = "btn_ConfirmTemp";
            this.btn_ConfirmTemp.Size = new System.Drawing.Size(134, 33);
            this.btn_ConfirmTemp.TabIndex = 8;
            this.btn_ConfirmTemp.Text = "Confirm Temp Threshold";
            this.btn_ConfirmTemp.UseVisualStyleBackColor = true;
            this.btn_ConfirmTemp.Click += new System.EventHandler(this.btn_ConfirmTemp_Click);
            // 
            // txb_threshFinal
            // 
            this.txb_threshFinal.Enabled = false;
            this.txb_threshFinal.Location = new System.Drawing.Point(504, 300);
            this.txb_threshFinal.Name = "txb_threshFinal";
            this.txb_threshFinal.ReadOnly = true;
            this.txb_threshFinal.Size = new System.Drawing.Size(37, 20);
            this.txb_threshFinal.TabIndex = 10;
            // 
            // lbl_finalThresh
            // 
            this.lbl_finalThresh.AutoSize = true;
            this.lbl_finalThresh.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finalThresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_finalThresh.Location = new System.Drawing.Point(403, 301);
            this.lbl_finalThresh.Name = "lbl_finalThresh";
            this.lbl_finalThresh.Size = new System.Drawing.Size(89, 20);
            this.lbl_finalThresh.TabIndex = 9;
            this.lbl_finalThresh.Text = "Temp Threshold:";
            // 
            // btn_threshMon
            // 
            this.btn_threshMon.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_threshMon.Location = new System.Drawing.Point(407, 367);
            this.btn_threshMon.Name = "btn_threshMon";
            this.btn_threshMon.Size = new System.Drawing.Size(134, 33);
            this.btn_threshMon.TabIndex = 11;
            this.btn_threshMon.Text = "Start Monitor";
            this.btn_threshMon.UseVisualStyleBackColor = true;
            this.btn_threshMon.Click += new System.EventHandler(this.btn_threshMon_Click);
            // 
            // tmr_mon
            // 
            this.tmr_mon.Tick += new System.EventHandler(this.tmr_mon_Tick);
            // 
            // txb_alarmTime
            // 
            this.txb_alarmTime.Enabled = false;
            this.txb_alarmTime.Location = new System.Drawing.Point(177, 300);
            this.txb_alarmTime.Name = "txb_alarmTime";
            this.txb_alarmTime.ReadOnly = true;
            this.txb_alarmTime.Size = new System.Drawing.Size(34, 20);
            this.txb_alarmTime.TabIndex = 13;
            // 
            // lbl_sysTime
            // 
            this.lbl_sysTime.AutoSize = true;
            this.lbl_sysTime.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sysTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_sysTime.Location = new System.Drawing.Point(52, 301);
            this.lbl_sysTime.Name = "lbl_sysTime";
            this.lbl_sysTime.Size = new System.Drawing.Size(119, 20);
            this.lbl_sysTime.TabIndex = 12;
            this.lbl_sysTime.Text = "Threshold Reached At:";
            // 
            // lbl_step1
            // 
            this.lbl_step1.AutoSize = true;
            this.lbl_step1.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_step1.Location = new System.Drawing.Point(34, 118);
            this.lbl_step1.Name = "lbl_step1";
            this.lbl_step1.Size = new System.Drawing.Size(16, 20);
            this.lbl_step1.TabIndex = 14;
            this.lbl_step1.Text = "1.";
            // 
            // lbl_step2
            // 
            this.lbl_step2.AutoSize = true;
            this.lbl_step2.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_step2.Location = new System.Drawing.Point(390, 161);
            this.lbl_step2.Name = "lbl_step2";
            this.lbl_step2.Size = new System.Drawing.Size(18, 20);
            this.lbl_step2.TabIndex = 15;
            this.lbl_step2.Text = "2.";
            // 
            // lbl_step3
            // 
            this.lbl_step3.AutoSize = true;
            this.lbl_step3.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_step3.Location = new System.Drawing.Point(383, 118);
            this.lbl_step3.Name = "lbl_step3";
            this.lbl_step3.Size = new System.Drawing.Size(18, 20);
            this.lbl_step3.TabIndex = 16;
            this.lbl_step3.Text = "3.";
            // 
            // lbl_step4
            // 
            this.lbl_step4.AutoSize = true;
            this.lbl_step4.Font = new System.Drawing.Font("SNES", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_step4.Location = new System.Drawing.Point(383, 373);
            this.lbl_step4.Name = "lbl_step4";
            this.lbl_step4.Size = new System.Drawing.Size(18, 20);
            this.lbl_step4.TabIndex = 17;
            this.lbl_step4.Text = "4.";
            // 
            // frm_TempMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_step4);
            this.Controls.Add(this.lbl_step3);
            this.Controls.Add(this.lbl_step2);
            this.Controls.Add(this.lbl_step1);
            this.Controls.Add(this.txb_alarmTime);
            this.Controls.Add(this.lbl_sysTime);
            this.Controls.Add(this.btn_threshMon);
            this.Controls.Add(this.txb_threshFinal);
            this.Controls.Add(this.lbl_finalThresh);
            this.Controls.Add(this.btn_ConfirmTemp);
            this.Controls.Add(this.txb_thresh);
            this.Controls.Add(this.lbl_EnterThresh);
            this.Controls.Add(this.btn_FinchConnect_Click);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.txb_Temp);
            this.Controls.Add(this.lbl_CurrentTemp);
            this.Controls.Add(this.frm_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_TempMon";
            this.Text = "Finch Temperature Montor, FoxFox Productions";
            this.Load += new System.EventHandler(this.frm_TempMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frm_Title;
        private System.Windows.Forms.Label lbl_CurrentTemp;
        private System.Windows.Forms.TextBox txb_Temp;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_FinchConnect_Click;
        private System.Windows.Forms.TextBox txb_thresh;
        private System.Windows.Forms.Label lbl_EnterThresh;
        private System.Windows.Forms.Button btn_ConfirmTemp;
        private System.Windows.Forms.TextBox txb_threshFinal;
        private System.Windows.Forms.Label lbl_finalThresh;
        private System.Windows.Forms.Button btn_threshMon;
        private System.Windows.Forms.Timer tmr_mon;
        private System.Windows.Forms.TextBox txb_alarmTime;
        private System.Windows.Forms.Label lbl_sysTime;
        private System.Windows.Forms.Label lbl_step1;
        private System.Windows.Forms.Label lbl_step2;
        private System.Windows.Forms.Label lbl_step3;
        private System.Windows.Forms.Label lbl_step4;
    }
}

