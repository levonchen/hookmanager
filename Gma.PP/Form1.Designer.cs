namespace Gma.PP
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
            this.button2 = new System.Windows.Forms.Button();
            this.btNewCaiGouDan = new System.Windows.Forms.Button();
            this.butInputDingDanLeiXing = new System.Windows.Forms.Button();
            this.btNewRowWuLiao = new System.Windows.Forms.Button();
            this.butEditWuLiaoInTable = new System.Windows.Forms.Button();
            this.butEditOneWuLiaoAll = new System.Windows.Forms.Button();
            this.butTest = new System.Windows.Forms.Button();
            this.butInputGeneralInfo = new System.Windows.Forms.Button();
            this.butCreateATotalForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "1.设置点击位置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btNewCaiGouDan
            // 
            this.btNewCaiGouDan.Location = new System.Drawing.Point(12, 71);
            this.btNewCaiGouDan.Name = "btNewCaiGouDan";
            this.btNewCaiGouDan.Size = new System.Drawing.Size(90, 23);
            this.btNewCaiGouDan.TabIndex = 7;
            this.btNewCaiGouDan.Text = "新建采购单";
            this.btNewCaiGouDan.UseVisualStyleBackColor = true;
            this.btNewCaiGouDan.Click += new System.EventHandler(this.btNewCaiGouDan_Click);
            // 
            // butInputDingDanLeiXing
            // 
            this.butInputDingDanLeiXing.Location = new System.Drawing.Point(13, 101);
            this.butInputDingDanLeiXing.Name = "butInputDingDanLeiXing";
            this.butInputDingDanLeiXing.Size = new System.Drawing.Size(89, 23);
            this.butInputDingDanLeiXing.TabIndex = 8;
            this.butInputDingDanLeiXing.Text = "输入订单类型";
            this.butInputDingDanLeiXing.UseVisualStyleBackColor = true;
            this.butInputDingDanLeiXing.Click += new System.EventHandler(this.butInputDingDanLeiXing_Click);
            // 
            // btNewRowWuLiao
            // 
            this.btNewRowWuLiao.Location = new System.Drawing.Point(12, 155);
            this.btNewRowWuLiao.Name = "btNewRowWuLiao";
            this.btNewRowWuLiao.Size = new System.Drawing.Size(90, 23);
            this.btNewRowWuLiao.TabIndex = 9;
            this.btNewRowWuLiao.Text = "新建一行物料";
            this.btNewRowWuLiao.UseVisualStyleBackColor = true;
            this.btNewRowWuLiao.Click += new System.EventHandler(this.btNewRowWuLiao_Click);
            // 
            // butEditWuLiaoInTable
            // 
            this.butEditWuLiaoInTable.Location = new System.Drawing.Point(13, 184);
            this.butEditWuLiaoInTable.Name = "butEditWuLiaoInTable";
            this.butEditWuLiaoInTable.Size = new System.Drawing.Size(89, 23);
            this.butEditWuLiaoInTable.TabIndex = 10;
            this.butEditWuLiaoInTable.Text = "编辑物料";
            this.butEditWuLiaoInTable.UseVisualStyleBackColor = true;
            this.butEditWuLiaoInTable.Click += new System.EventHandler(this.butEditWuLiaoInTable_Click);
            // 
            // butEditOneWuLiaoAll
            // 
            this.butEditOneWuLiaoAll.Location = new System.Drawing.Point(119, 174);
            this.butEditOneWuLiaoAll.Name = "butEditOneWuLiaoAll";
            this.butEditOneWuLiaoAll.Size = new System.Drawing.Size(96, 23);
            this.butEditOneWuLiaoAll.TabIndex = 11;
            this.butEditOneWuLiaoAll.Text = "输入一行物料";
            this.butEditOneWuLiaoAll.UseVisualStyleBackColor = true;
            this.butEditOneWuLiaoAll.Click += new System.EventHandler(this.butEditOneWuLiaoAll_Click);
            // 
            // butTest
            // 
            this.butTest.Location = new System.Drawing.Point(140, 11);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(75, 23);
            this.butTest.TabIndex = 12;
            this.butTest.Text = "Test";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            // 
            // butInputGeneralInfo
            // 
            this.butInputGeneralInfo.Location = new System.Drawing.Point(119, 87);
            this.butInputGeneralInfo.Name = "butInputGeneralInfo";
            this.butInputGeneralInfo.Size = new System.Drawing.Size(100, 23);
            this.butInputGeneralInfo.TabIndex = 13;
            this.butInputGeneralInfo.Text = "输入采购信息";
            this.butInputGeneralInfo.UseVisualStyleBackColor = true;
            this.butInputGeneralInfo.Click += new System.EventHandler(this.butInputGeneralInfo_Click);
            // 
            // butCreateATotalForm
            // 
            this.butCreateATotalForm.Location = new System.Drawing.Point(13, 245);
            this.butCreateATotalForm.Name = "butCreateATotalForm";
            this.butCreateATotalForm.Size = new System.Drawing.Size(89, 23);
            this.butCreateATotalForm.TabIndex = 14;
            this.butCreateATotalForm.Text = "生成采购单";
            this.butCreateATotalForm.UseVisualStyleBackColor = true;
            this.butCreateATotalForm.Click += new System.EventHandler(this.butCreateATotalForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 305);
            this.Controls.Add(this.butCreateATotalForm);
            this.Controls.Add(this.butInputGeneralInfo);
            this.Controls.Add(this.butTest);
            this.Controls.Add(this.butEditOneWuLiaoAll);
            this.Controls.Add(this.butEditWuLiaoInTable);
            this.Controls.Add(this.btNewRowWuLiao);
            this.Controls.Add(this.butInputDingDanLeiXing);
            this.Controls.Add(this.btNewCaiGouDan);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "自动化输入";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btNewCaiGouDan;
        private System.Windows.Forms.Button butInputDingDanLeiXing;
        private System.Windows.Forms.Button btNewRowWuLiao;
        private System.Windows.Forms.Button butEditWuLiaoInTable;
        private System.Windows.Forms.Button butEditOneWuLiaoAll;
        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.Button butInputGeneralInfo;
        private System.Windows.Forms.Button butCreateATotalForm;
    }
}

